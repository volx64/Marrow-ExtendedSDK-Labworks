using SLZ.Marrow.VoidLogic;
using System;
using System.Collections.Generic;
using System.Reflection;
using UltEvents;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Interaction
{
	public class ButtonToggle : MonoBehaviour
	{
		public ConfigurableJoint joint;

		public Transform endTransform;

		public AudioClip[] pressClips;

		public AudioClip[] depressClips;

		[Tooltip("Colliders that the button shaft collider will ignore")]
		public Collider[] ignoreColliders;

		public Collider buttonShaftCollider;

		[Header("Events")]
		public UnityEvent onPress;

		public UnityEvent onDepress;

		public UnityEvent onHold;

		public UnityEvent onPressOneShot;

		private Vector3 _endPosition;

		private Vector3 _startPosition;

		private Rigidbody _rb;

		private float _jointSqrLimit;

		private float _jointLimit;

		private float _jointHalfLimit;

		private float _limitOffset;

		private float _limitSqr;

		private float _padding;

		private bool _isPressed;

		private bool _hasBeenPressed;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		public void CancelOneShot()
		{
		}

#if UNITY_EDITOR

		[ContextMenu("Convert To Voidlogic Button")]
		public void ConvertToVLButton()
		{
			ButtonNode vl;
			if(!TryGetComponent(out vl))
				vl = gameObject.AddComponent<ButtonNode>();

			SetPrivateField(vl, "_lowThreshold", 0.05f);
            SetPrivateField(vl, "_highThreshold", 0.95f);
            SetPrivateField(vl, "_joint", joint);
            SetPrivateField(vl, "_endTransform", endTransform);
            SetPrivateField(vl, "_pressClips", pressClips);
            SetPrivateField(vl, "_depressClips", depressClips);
            SetPrivateField(vl, "_ignoreColliders", ignoreColliders);
            SetPrivateField(vl, "_buttonShaftCollider", buttonShaftCollider);

            PowerSource vlPower = GetComponentInChildren<PowerSource>();
			if(vlPower == null)
			{
				GameObject go = new GameObject("VL_Power");
				go.transform.parent = transform;
				go.transform.localPosition = Vector3.zero;
				go.transform.localRotation = Quaternion.identity;

				vlPower = go.AddComponent<PowerSource>();
				SetPrivateField(vlPower, "_value", 1);
			}

			MonoBehaviour[] previous = new MonoBehaviour[1];
			previous[0] = vlPower;

            SetPrivateField(vl, "_previous", previous, typeof(BaseNode));

            EventAdapter vlEvents = GetComponentInChildren<EventAdapter>();
            if (vlEvents == null)
            {
                GameObject go = new GameObject("VL_Events");
                go.transform.parent = transform;
                go.transform.localPosition = Vector3.zero;
                go.transform.localRotation = Quaternion.identity;

                vlEvents = go.AddComponent<EventAdapter>();
				SetPrivateField(vlEvents, "_previousNode", vl);
                SetPrivateField(vlEvents, "lowThreshold", 0.05f);
                SetPrivateField(vlEvents, "highThreshold", 0.95f);

				ConvertUnityEventToUltEvent(onPress, vlEvents.InputRose);
                ConvertUnityEventToUltEvent(onDepress, vlEvents.InputFell);
                ConvertUnityEventToUltEvent(onHold, vlEvents.InputHeld);
                ConvertUnityEventToUltEvent(onPressOneShot, vlEvents.InputRoseOneShot);
            }
        }

		public void SetPrivateField(object s, string field, object value, Type type = null)
		{
			var t = type == null ? s.GetType() : type;
			var prop = t.GetField(field, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
			prop.SetValue(s, value);
		}

        public object GetPrivateField(object s, string field, Type type = null)
        {
            var t = type == null ? s.GetType() : type;
            var prop = t.GetField(field, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            return prop.GetValue(s);
        }

        public void ConvertUnityEventToUltEvent(UnityEvent unityEvent, UltEventBase ultEvent)
        {
            // Get the private 'm_PersistentCalls' field using reflection
            FieldInfo persistentCallsField = typeof(UnityEventBase).GetField("m_PersistentCalls", BindingFlags.NonPublic | BindingFlags.Instance);
            if (persistentCallsField == null) return;
			Debug.Log("Persistent Calls is not null");

            // Get the PersistentCallGroup from the UnityEvent
            object persistentCalls = persistentCallsField.GetValue(unityEvent);
            if (persistentCalls == null) return;
            Debug.Log("Persistent Calls is not null");

            // Get the private 'm_Calls' field from the PersistentCallGroup
            FieldInfo callsField = persistentCalls.GetType().GetField("m_Calls", BindingFlags.NonPublic | BindingFlags.Instance);
            if (callsField == null) return;
            Debug.Log("Calls is not null");

            // Get the list of PersistentCalls
            var calls = callsField.GetValue(persistentCalls) as System.Collections.IList;
            if (calls == null) return;
            Debug.Log("Calls is not null");

            foreach (var call in calls)
            {
				Debug.Log("Doing Call");
				// Extract the target, method, and arguments from each PersistentCall
				string methodName = Convert.ToString(GetPrivateField(call, "m_MethodName"));

                object target = GetPrivateField(call, "m_Target");

                PersistentListenerMode mode = (PersistentListenerMode)GetPrivateField(call, "m_Mode");

                // Add the listener to the UltEvent
                if (mode == PersistentListenerMode.EventDefined)
                {
                    ultEvent.AddPersistentCall((UnityAction)Delegate.CreateDelegate(typeof(UnityAction), target, methodName));
                }
                if (mode == PersistentListenerMode.Bool)
                {
                    //ultEvent.AddPersistentCall((UnityAction)Delegate.CreateDelegate(typeof(UnityAction), target, methodName));
                }
            }
        }
#endif


    }
}
