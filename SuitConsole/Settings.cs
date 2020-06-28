using System.IO;
using Newtonsoft.Json.Linq;
using Suit.Extensions;
using SuitConsole.Tools;

namespace SuitConsole
{
	class Settings : IMyToolSettings
    {
        private JObject settings;

        public Settings()
        {
            settings = File.ReadAllText("settings.json").FromJson<JObject>();
        }
    }
}