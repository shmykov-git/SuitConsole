using Suit;
using SuitConsole.Tools;
using Unity;

namespace SuitConsole
{
	public static class IoCSuitConsole
	{
        public static void Register(UnityContainer container)
        {
            container.RegisterSingleton<SuitConsoleSettings>();
            container.RegisterFactory<IMyToolSettings>(c => IoC.Get<SuitConsoleSettings>());
        }
    }
}