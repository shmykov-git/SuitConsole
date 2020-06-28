using Suit;
using SuitConsole.Tools;
using Unity;

namespace SuitConsole
{
	public static class IoCSuitConsole
	{
        public static void Register(UnityContainer container)
        {
            container.RegisterSingleton<Settings>();
            container.RegisterFactory<IMyToolSettings>(c => IoC.Get<Settings>());
        }
    }
}