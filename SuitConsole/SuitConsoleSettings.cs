using System.IO;
using Newtonsoft.Json.Linq;
using Suit.Extensions;
using SuitConsole.Tools;

namespace SuitConsole
{
	class SuitConsoleSettings : IMyToolSettings
    {
        private JObject settings;

        public SuitConsoleSettings()
        {
            settings = File.ReadAllText("settings.json").FromJson<JObject>();
        }
    }
}