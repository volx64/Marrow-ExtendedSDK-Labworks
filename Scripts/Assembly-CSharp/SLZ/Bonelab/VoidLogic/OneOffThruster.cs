using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, null)]
	[AddComponentMenu(null)]
	public sealed class OneOffThruster : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Obsolete("Dead Field: Please remove")]
		[Tooltip("Dead Field: Please remove")]
		[NonReorderable]
		[SerializeField]
		protected internal MonoBehaviour[] _previous;

		[Tooltip("Previous node(s) in the chain")]
		[NonReorderable]
		[SerializeField]
		protected internal OutputPortReference[] _previousConnections;

		[SerializeField]
		private ForceMode forceMode;

		[SerializeField]
		private bool _relativeForce;

		[SerializeField]
		private bool _relativeTorque;

		[SerializeField]
		private Rigidbody _target;

		private static readonly PortMetadata _portMetadata;

		[field: NotUsedInEditMode]
		[field: SerializeField]
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
