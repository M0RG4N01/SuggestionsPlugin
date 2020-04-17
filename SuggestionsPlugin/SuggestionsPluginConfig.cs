using Rocket.API;

namespace SuggestionsPlugin
{
    public class SuggestionsPluginConfig : IRocketPluginConfiguration
    {
        public string DiscordWebHookLink;
        public string NullSuggestionMsg;
        public string NullSuggestionMsgIcon;
        public string SuggestionThankYouMsg;
        public string SuggestionThankYouMsgIcon;

        public void LoadDefaults()
        {
            DiscordWebHookLink = "";
            NullSuggestionMsg = "{size=17}{color=magenta}{i}Please provide an improvement for the server!{/i}{/color}{/size}";
            NullSuggestionMsgIcon = "http://imgur.com/m3fY6Wy.png";
            SuggestionThankYouMsg = "{size=17}{color=magenta}{i}Thank you for your suggestion!{/i}{/color}{/size}";
            SuggestionThankYouMsgIcon = "http://imgur.com/m3fY6Wy.png";
        }
    }
}
