using System;
using SLZ.Marrow;
using SLZ.Marrow.Data;
using SLZ.Marrow.VoidLogic;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Control_MonoMatNew : MonoBehaviour
	{
		[Serializable]
		public class MonomatInventoryItem
		{
			public SpawnableCrateReference[] monomatItems;

			public int itemPrice;

			public int mult;
		}

		[Serializable]
		public class MonomatInventory
		{
			public MonomatInventoryItem[] inventory;
		}

		private MonomatInventory currentInventory;

		private int selectedItem;

		public MonomatInventory[] inventories;

		[SerializeField]
        public PowerSource doorPower;

		[SerializeField]
		public int multiplier;

		[SerializeField]
        public int itemPrice;

		[SerializeField]
        public int lightBullets;

		[SerializeField]
        public int mediumBullets;

		[SerializeField]
        public int heavyBullets;

		[SerializeField]
        public TextMeshPro bulletBalanceTextmesh;

		[SerializeField]
        public TextMeshPro refundTextmesh;

		[SerializeField]
        public AmmoReciever reciever;

		[SerializeField]
        public GameObject[] previewObjects;

		[SerializeField]
        public GameObject[] previewRots;

		[SerializeField]
        public MeshFilter[] previewMeshes;

		private SpawnableCrate[] lastCrates;

		private Mesh[] loadedMeshes;

		private Vector3[] cashedEularOffsets;

		[SerializeField]
        public MeshFilter drawerBounds;

		[SerializeField]
        public MeshFilter drawerPreviewMesh;

		[SerializeField]
        public Transform drawerPreviewRots;

		public float previewMeshScaleTune;

		private Vector3[] offsets;

		[SerializeField]
        public Spawnable lightRefundSpawnable;

		[SerializeField]
        public Spawnable mediumRefundSpawnable;

		[SerializeField]
        public Spawnable heavyRefundSpawnable;

		[SerializeField]
        public AudioClip _openedClip;

		[SerializeField]
        public AudioClip _unlockedClip;

		[SerializeField]
        public AudioClip _lockedClip;

		public Transform giveChangeTransform;

		private bool[] itemConsumed;

		private void Start()
		{
		}

		[ContextMenu("SetInventory0")]
		public void SetInventory0()
		{
		}

		[ContextMenu("SetInventory1")]
		public void SetInventory1()
		{
		}

		[ContextMenu("SetInventory2")]
		public void SetInventory2()
		{
		}

		public void SETINVENTORY(int index)
		{
		}

		public void SETINVENTORY(MonomatInventory inventory)
		{
		}

		private void UpdateItems()
		{
		}

		public void UpdatePreviewMeshes(int index, SpawnableCrate crate)
		{
		}

		public void SELECTITEM(int index)
		{
		}

		[ContextMenu("CheckItemMenu")]
		public void CheckItemMenu()
		{
		}

		public void CHECKITEM()
		{
		}

		public void GIVECHANGE()
		{
		}

		public void InsertMagazine(Magazine magazine)
		{
		}

		private void AddBullets(int addedBullets, int type)
		{
		}

		private void SpawnItems(SpawnableCrate crate)
		{
		}
	}
}
