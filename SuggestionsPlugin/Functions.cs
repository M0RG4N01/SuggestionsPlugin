using System.ComponentModel;
using System.Net;
using System.Text;

namespace SuggestionsPlugin
{
	public static class Functions
	{
		public static void SendToDiscord(string caller, string displayname, string message)
		{
			var discordWebHookLink = Main.Instance.Configuration.Instance.DiscordWebHookLink;
			var httpWebRequest = (HttpWebRequest) WebRequest.Create(discordWebHookLink);
			var s = "{ \"content\": \"" + "``STEAMID64: " + caller + "`` **" + displayname + "** suggested: ``" + message + "``" + "\"}";
			var bytes = Encoding.ASCII.GetBytes(s);
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/json";
			httpWebRequest.ContentLength = (long) bytes.Length;
			using (var requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			httpWebRequest.GetResponse();
		}
	}
}
