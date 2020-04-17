using System;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;

namespace SuggestionsPlugin
{
    public class Main : RocketPlugin<SuggestionsPluginConfig>
    {
        public static Main Instance;

        protected override void Load()
        {
            Instance = this;
            Logger.Log("Suggestions Plugin loaded. All Systems are go!");
        }

        protected override void Unload()
        {
            Logger.Log("Suggestions Plugin unloaded. System Shutting down!");
        }
        
        private void FixedUpdate()
        {
        }
    }
}