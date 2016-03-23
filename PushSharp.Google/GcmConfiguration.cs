using System;

namespace PushSharp.Google
{
    public class GcmConfiguration
    {
        private const string GCM_SEND_URL = "https://gcm-http.googleapis.com/gcm/send";

        public GcmConfiguration (string senderAuthToken)
        {
            this.SenderAuthToken = senderAuthToken;
            this.GcmUrl = GCM_SEND_URL;

            this.ValidateServerCertificate = false;
        }

        public GcmConfiguration (string optionalSenderID, string senderAuthToken, string optionalApplicationIdPackageName)
        {
            this.SenderID = optionalSenderID;
            this.SenderAuthToken = senderAuthToken;
            this.ApplicationIdPackageName = optionalApplicationIdPackageName;
            this.GcmUrl = GCM_SEND_URL;

            this.ValidateServerCertificate = false;
        }

        public string SenderID { get; private set; }

        public string SenderAuthToken { get; private set; }

        public string ApplicationIdPackageName { get; private set; }

        public bool ValidateServerCertificate { get; set; }

        public string GcmUrl { get; set; }

        public void OverrideUrl (string url)
        {
            GcmUrl = url;
        }
           public void SetProxy(string proxyHost, int proxyPort)
        {
            UseProxy = true;
            ProxyHost = proxyHost;
            ProxyPort = proxyPort;
            ProxyCredentials = CredentialCache.DefaultNetworkCredentials;
        }

        public void SetProxy(string proxyHost, int proxyPort, string userName, string password, string domain)
        {
            UseProxy = true;
            ProxyHost = proxyHost;
            ProxyPort = proxyPort;
            ProxyCredentials = new NetworkCredential(userName, password, domain);
        }
        public bool UseProxy { get;  set; }

        public string ProxyHost { get;  set; }

        public int ProxyPort { get;  set; }

        public NetworkCredential ProxyCredentials { get;  set; }
    }
}

