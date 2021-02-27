using System.Collections.Specialized;
using System.Net;

namespace AtomicLibrary.Discord
{
    public class ADiscord
    {
        class Http
        {
            public static byte[] Post(string url, NameValueCollection pairs)
            {
                using (WebClient webClient = new WebClient())
                    return webClient.UploadValues(url, pairs);
            }
        }

        public void send(string content, string webHookUrl)
        {
            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },

        });

        }
        public void send(string content, string webHookUrl, string username)
        {

            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },
            {
                "username", username
            }
        });
        }
        public void send(string content, string webHookUrl, string username, string avatarUrl)
        {
            Http.Post(webHookUrl, new NameValueCollection()
        {
            {
                "content", content
            },
            {
                "username", username
            },
            {
                "avatar_url", avatarUrl
            }
        });
        }
    }
}
