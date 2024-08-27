using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic One-shot Sound Player")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This component is allowed without endorsement until we have an answer for that.")]
	public class OneShotSoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDoAStart_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public OneShotSoundPlayer _003C_003E4__this;

			public EdgeType edgeType;

			private UniTask.Awaiter _003C_003Eu__1;

			void IAsyncStateMachine.MoveNext()
			{
			}

			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSpawnAndPlayAudio_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public OneShotSoundPlayer _003C_003E4__this;

			public ClipPair chosenClipPair;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

			void IAsyncStateMachine.MoveNext()
			{
			}

			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[SerializeField]
		[Obsolete("Dead Field: Please remove")]
		[Tooltip("Dead Field: Please remove")]
		[NonReorderable]
		protected internal MonoBehaviour[] _previous;

		[NonReorderable]
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		protected internal OutputPortReference[] _previousConnections;

		private float _volumeMultiplier;

		private float _pitchMultiplier;

		private List<AudioPlayerAndClipPair> _audioPlayers;

		private Queue<(EdgeType, ClipPair)> _queuedPlays;

		private static readonly PortMetadata _portMetadata;

		[field: NotUsedInEditMode]
		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		[field: SerializeField]
		public ClipChooser ClipChooser { get; set; }

		[field: SerializeField]
		public Transform AudioPlacementOverride { get; set; }

		[field: Range(0.1f, 10f)]
		[field: SerializeField]
		public float SourceRadius { get; set; }

		[field: Range(0f, 1f)]
		[field: SerializeField]
		public float Volume { get; set; }

		[field: Range(0f, 1f)]
		[field: SerializeField]
		public float SpacialBlend { get; set; }

		[field: Range(1f, 5f)]
		[field: SerializeField]
		public int MaximumQueueDepth { get; set; }

		[field: SerializeField]
		[field: Tooltip("Edge detection configuration for start input")]
		private EdgeDetector StartEdgeDetector { get; set; }

		[field: Tooltip("Edge detection configuration for reset input")]
		[field: SerializeField]
		private EdgeDetector ResetEdgeDetector { get; set; }

		public int InputCount => 0;

		private PortMetadata SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicNode_002EPortMetadata => default(PortMetadata);

        public PortMetadata PortMetadata => throw new NotImplementedException();

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

		[AsyncStateMachine(typeof(_003CDoAStart_003Ed__50))]
		private UniTaskVoid DoAStart(EdgeType edgeType)
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSpawnAndPlayAudio_003Ed__51))]
		private UniTask SpawnAndPlayAudio(EdgeType edgeType, ClipPair chosenClipPair)
		{
			return default(UniTask);
		}

		private UniTask<GameObject> SpawnAudioPlayerAsync(Vector3 position = default(Vector3))
		{
			return default(UniTask<GameObject>);
		}

		private void OnAudioSourceDespawned(GameObject go)
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

        void IVoidLogicNode.Initialize(ref NodeState nodeState)
        {
        }
    }
}
