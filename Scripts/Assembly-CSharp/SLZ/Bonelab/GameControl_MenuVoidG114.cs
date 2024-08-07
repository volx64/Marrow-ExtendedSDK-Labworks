using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Data;
using SLZ.Marrow.Interaction;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class GameControl_MenuVoidG114 : BonelabInternalGameControl
	{
		[CompilerGenerated]
		private sealed class _003CStartSequence_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_MenuVoidG114 _003C_003E4__this;

			private float _003ClogoSLZTime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStartSequence_003Ed__76(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CDissolveBoneLab_003Ed__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
public void Reset(){}
public void Dispose(){}
public object Current { get; }
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameControl_MenuVoidG114 _003C_003E4__this;

			private float _003ClogoSLZTime_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDissolveBoneLab_003Ed__84(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadAvatarFromSaveDataAsync_003Ed__89 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GameControl_MenuVoidG114 _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
			}

			[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Header("BUILD INFO")]
		public string buildTitle;

		public string buildState;

		private string buildDate;

		public TextMeshPro tmp_Title;

		public TextMeshPro tmp_BuildInfo;

		[Header("TITLE")]
		public LaserCursor mainMenuUIController;

		public GameObject logoSLZ;

		public GameObject logoCredits;

		public GameObject logoGameTitle;

		public GameObject rootSLZ;

		public GameObject rootCredits;

		public GameObject rootGameTitle;

		public GameObject animGameTitle;

		public float holdTime_Rest;

		public float holdTime_SLZ;

		public float holdTime_Credits;

		public float holdTime_GameTitle;

		public AudioClip sfx_slzLogo;

		public AudioClip sfx_marrow;

		public AudioClip sfx_bonelab;

		public ZoneMusic music_menu;

		public ZoneMusic music_keygen;

		public GameObject particles_elements;

		public GameObject particles_elementsALL;

		public ParticleSystem particles_Fireflies;

		private Material[] logoSLZMaterial;

		private Renderer[] logoSLZTextRenderer;

		private Renderer logoCreditsRenders;

		private Renderer logoGameTitleBeakerRenderer;

		private Renderer logoGameTitleBoneLabRenderer;

		public AnimationCurve curve_title;

		public float titleLerpTime;

		private float m_curTitleLerpTime;

		public Transform logoGameTitleStartTrans;

		private Vector3 m_logoPos;

		private Vector3 m_logoScale;

		public Transform logoGameTitleTargetTrans;

		public GameObject[] panels_ProfileSelect;

		public GameObject[] uiGroups;

		public FadeAndDisableVolume fadeVolume;

		public GameObject avatarTransform;

		public MeshFilter avatarMeshFilter;

		public TextMeshProUGUI avatarName;

		public float avatarMeshScaleTune;

		private AvatarCrate avatarCrate;

		[Header("CONTROL")]
		[HideInInspector]
		public BodyVitals ctrl_bodyVitals;

		private bool m_waitForConfirm;

		private bool m_waitForLevelLoad;

		private WaitForSeconds frameWait;

		[Header("INPUT")]
		private float startHoldTime;

		private float timerHold;

		public float holdTime;

		private bool buttonHeld;

		private string heldKey;

		[HideInInspector]
		public Control_Player controlPlayer;

		[Header("LEVEL PROGRESS")]
		public LevelCrateReference level_quickPlay;

		public LevelCrateReference descentLevelCrate;

		public LevelCrateReference hubLevelCrate;

		public LevelCrateReference longRunLevelCrate;

		public LevelCrateReference mineDiveLevelCrate;

		public LevelCrateReference jimmyLevelCrate;

		public LevelCrateReference ascentLevelCrate;

		public LevelCrateReference townFightLevelCrate;

		public LevelCrateReference voidG114LevelCrate;

		public LevelCrateReference loadScreenLevel;

		private LevelCrateReference _loadcrate;

		public Spawnable vfxFadeOutSpawnable;

		private bool canClick;

		private MarrowEntity playerEntity;

		private static PlayerProgression Progression => null;

		private new void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void PullLocalizedText()
		{
		}

		public override void Start()
		{
		}

		private bool GetPlayerReferences()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CStartSequence_003Ed__76))]
		private IEnumerator StartSequence()
		{
			return null;
		}

		public void PLAYMENUMUSIC(int song = 0)
		{
		}

		public void NEXCTLEVELLOADED()
		{
		}

		public void NEXTSTEP()
		{
		}

		public void BUTTON_QUICKPLAY()
		{
		}

		public void BUTTON_PLAYNEWGAME()
		{
		}

		public void BUTTON_PLAYHUB()
		{
		}

		public void BUTTON_PLAYCONTINUE()
		{
		}

		[IteratorStateMachine(typeof(_003CDissolveBoneLab_003Ed__84))]
		public IEnumerator DissolveBoneLab()
		{
			return null;
		}

		private void LoadLevel()
		{
		}

		private LevelCrateReference ContinueDestination()
		{
			return null;
		}

		public void BUTTON_OPTIONS()
		{
		}

		public void BUTTON_LOADCUSTOM(string sceneName)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadAvatarFromSaveDataAsync_003Ed__89))]
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		private void SetPreviewMesh(AvatarCrate crate)
		{
		}
	}
}
