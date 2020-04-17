using System;
using System.Collections.Generic;
using System.Linq;
using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace SuggestionsPlugin
{
    public class SuggestCommand : IRocketCommand
    {
        public void Execute(IRocketPlayer caller, string[] command)
        {
            var player = (UnturnedPlayer) caller;

            if (!command.Any())
            {
                    ChatManager.serverSendMessage(Main.Instance.Configuration.Instance.NullSuggestionMsg.Replace('{', '<').Replace('}', '>'), Color.white, null, player.SteamPlayer(), EChatMode.SAY, Main.Instance.Configuration.Instance.NullSuggestionMsgIcon, true);
                    return;
            }

            var args = string.Join(" ", command);

            ChatManager.serverSendMessage(Main.Instance.Configuration.Instance.SuggestionThankYouMsg.Replace('{', '<').Replace('}', '>'), Color.white, null, player.SteamPlayer(), EChatMode.SAY, Main.Instance.Configuration.Instance.SuggestionThankYouMsgIcon, true);

            Functions.SendToDiscord(Convert.ToString(player.CSteamID), player.DisplayName, args);
        }

        public AllowedCaller AllowedCaller { get; } = AllowedCaller.Player;
        
        public string Name { get; } = "suggest";
        
        public string Help { get; } = "Suggest an improvement for the server!";
        
        public string Syntax { get; } = "Usage: /suggest <Your improvement here>";
        
        public List<string> Aliases { get; } = new List<string>(){"feedback", "sug"};
        
        public List<string> Permissions { get; } = new List<string>(){"suggest"};
    }
}