using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.NotForRelease, "This is a one-off for testing.")]
	[AddComponentMenu(null)]
	public sealed class OneOffSetEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Tooltip("Dead Field: Please remove")]
		[NonReorderable]
		[Obsolete("Dead Field: Please remove")]
		[SerializeField]
		protected internal MonoBehaviour[] _previous;

		[SerializeField]
		[NonReorderable]
		[Tooltip("Previous node(s) in the chain")]
		protected internal OutputPortReference[] _previousConnections;

		[SerializeField]
		private bool _setOnActuation;

		[SerializeField]
		private Transform _target;

		private Vector3 targetRotation;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: NotUsedInEditMode]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int InputCount => 0;

		PortMetadata IVoidLogicNode.PortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		void IVoidLogicNode.Initialize(ref NodeState nodeState)
		{
		}

		public void Actuate(ref NodeState nodeState)
		{
		}

		public bool TryGetInputConnection(uint inputIndex, out OutputPortReference connectedPort)
		{
			connectedPort = default(OutputPortReference);
			return false;
		}

		public bool TryConnectPortToInput(OutputPortReference output, uint inputIndex)
		{
			return false;
		}
	}
}
