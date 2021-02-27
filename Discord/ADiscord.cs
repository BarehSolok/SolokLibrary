using System.Collections.Specialized;
using System.Net;

namespace AtomicLibrary.Discord
{
    public class ADiscord
    {
        public static void send(string webhookURL, string username, string content)
        {
            WebClient wc = new WebClient();
            wc.UploadValues(webhookURL, new NameValueCollection
            {
                {
                    "username", username
                },
                {
                    "content", content
                }
            });
        }
    }
}
