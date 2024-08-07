using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Linq;
using SLZ.Marrow.Console;

namespace SLZ.Bonelab.Console
{
	[ConsoleCommand("assetwarehouse", "reload", "Reload Pallet")]
	[ConsoleCommand("aw", "reload", "Reload Pallet")]
	public class AssetWarehouseReloadConsoleCommand : SimpleConsoleCommand
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRunSimpleCommand_003Ed__0 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string parameter;

			public IAsyncWriter<object> writer;

			private UniTask.Awaiter _003C_003Eu__1;

			public void MoveNext()
			{
				throw new System.NotImplementedException();
			}

			public void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw new System.NotImplementedException();
			}
		}

		[AsyncStateMachine(typeof(_003CRunSimpleCommand_003Ed__0))]
		public override UniTask RunSimpleCommand(IAsyncWriter<object> writer, string parameter)
		{
			return default(UniTask);
		}
	}
}
