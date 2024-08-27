using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, "Replaced by TextAdapter.")]
	[Obsolete("Replaced by TextAdapter.")]
	[AddComponentMenu(null)]
	public sealed class OneOffValueReaderSink : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[Tooltip("Dead Field: Please remove")]
		[SerializeField]
		[Obsolete("Dead Field: Please remove")]
		[NonReorderable]
		protected internal MonoBehaviour _previousNode;

		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private OutputPortReference _previousConnection;

		private float _priorValue;

		public TextMeshPro tmp;

		public string labelText;

		private static readonly PortMetadata _portMetadata;

		[field: ReadOnly(false)]
		[field: NotUsedInEditMode]
		[field: SerializeField]
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

		private void UpdateText()
		{
		}

		void IVoidLogicNode.Initialize(ref NodeState nodeState)
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
