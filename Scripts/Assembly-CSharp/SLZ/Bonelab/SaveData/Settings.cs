using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SLZ.Marrow.SaveData;

namespace SLZ.Bonelab.SaveData
{
	public sealed class Settings : ISettings
	{
		[JsonProperty("version")]
		public int Version
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("modified")]
		public string Modified
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("active_save_game")]
		public string ActiveSave
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("debug_settings")]
		public DebugSettings DebugSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("graphics_settings")]
		public GraphicsSettings GraphicsSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[JsonProperty("spectator_settings")]
		public SpectatorSettings SpectatorSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void FixFieldsIfNeeded()
		{
		}
	}
}
