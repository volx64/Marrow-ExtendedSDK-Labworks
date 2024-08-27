using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu(null)]
	[Support(SupportFlags.Unsupported, "This is a one-off for testing.")]
	public sealed class OneOffDriveEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Obsolete("Dead Field: Please remove")]
		[Tooltip("Dead Field: Please remove")]
		[SerializeField]
		[NonReorderable]
		protected internal MonoBehaviour[] _previous;

		[Tooltip("Previous node(s) in the chain")]
		[NonReorderable]
		[SerializeField]
		protected internal OutputPortReference[] _previousConnections;

		[SerializeField]
		private ConfigurableJoint target;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: ReadOnly(false)]
		[field: NotUsedInEditMode]
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

		void IVoidLogicNode.Initialize(ref NodeState nodeState)
		{
		}

		void IVoidLogicActuator.Actuate(ref NodeState nodeState)
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
