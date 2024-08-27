using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.CowboySupported, null)]
	[AddComponentMenu("VoidLogic/Bonelab Internal/VoidLogic Collision Sensor One-off")]
	public class OneOffCollisionSensor : MonoBehaviour, IVoidLogicSource, IVoidLogicNode, IVoidLogicSensor
	{
		[HideInInspector]
		[SerializeField]
		private bool _deprecated;

		[SerializeField]
		private bool _negate;

		private Rigidbody _rigidbody;

		private readonly Queue<(Vector3 force, Vector3 torque)> _impacts;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: NotUsedInEditMode]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		public int OutputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		private void Start()
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		void IVoidLogicNode.Initialize(ref NodeState nodeState)
		{
		}

		void IVoidLogicSensor.ReadSensors(ref NodeState nodeState)
		{
		}

		void IVoidLogicSource.Calculate(ref NodeState nodeState)
		{
		}
	}
}
