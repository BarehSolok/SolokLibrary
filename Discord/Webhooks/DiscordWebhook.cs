using System.Collections.Specialized;
using System.Net;

namespace SolokLibrary.Discord.Webhooks
{
    public static class DiscordWebhook
    {
        public static void Send(string webhookUrl, string message)
        {
            var wc = new WebClient();
            wc.UploadValues(webhookUrl, new NameValueCollection
            {
                {
                    "content", message
                }
            });
        }

        public static void Send(string webhookUrl, string message, string webhookUserName)
        {
            var wc = new WebClient();
            wc.UploadValues(webhookUrl, new NameValueCollection
            {
                {
                    "content", message
                },
                {
                    "username", webhookUserName
                }
            });
        }
    }
}
