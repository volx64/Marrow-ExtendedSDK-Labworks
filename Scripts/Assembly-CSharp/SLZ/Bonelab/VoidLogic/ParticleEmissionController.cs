using System;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab.VoidLogic
{
	[Obsolete("This interface is not yet considered stable. Use at your own risk!")]
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic Particle Emission Controller")]
	[Support(SupportFlags.CowboySupported, null)]
	public class ParticleEmissionController : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[HideInInspector]
		private bool _deprecated;

		[Obsolete("Dead Field: Please remove")]
		[Tooltip("Dead Field: Please remove")]
		[SerializeField]
		[NonReorderable]
		protected internal MonoBehaviour _previousNode;

		[SerializeField]
		[Tooltip("Previous node in the chain")]
		private OutputPortReference _previousConnection;

		[FormerlySerializedAs("ParticleSystems")]
		[SerializeField]
		private ParticleSystem[] _particleSystems;

		private bool _disable;

		private ParticleSystem.EmissionModule[] _emissionSystems;

		private float[] _cachedRateMultipliers;

		private static readonly PortMetadata _portMetadata;

		[field: NotUsedInEditMode]
		[field: ReadOnly(false)]
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int InputCount => 0;

		PortMetadata IVoidLogicNode.PortMetadata => default(PortMetadata);

		private void Reset()
		{
		}

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

		private void OnTriggerEnter(Collider c)
		{
		}

		private void OnTriggerExit(Collider c)
		{
		}

		void IVoidLogicActuator.Actuate(ref NodeState nodeState)
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
