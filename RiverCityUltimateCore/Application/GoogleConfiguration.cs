using System.Configuration;

namespace RiverCityUltimate.Core.Application
{
    public class GoogleConfiguration : ConfigurationSection
    {
        public string AuthorizationCode => "authorization_code";

        [ConfigurationProperty("ProjectId", IsRequired = true)]
        public string ProjectId
        {
            get { return this["ProjectId"].ToString(); }
            set { this["ProjectId"] = value; }
        }

        [ConfigurationProperty("PrivateKeyId", IsRequired = true)]
        public string PrivateKeyId
        {
            get { return this["PrivateKeyId"].ToString(); }
            set { this["PrivateKeyId"] = value; }
        }

        [ConfigurationProperty("PrivateKey", IsRequired = true)]
        public string PrivateKey
        {
            get { return this["PrivateKey"].ToString(); }
            set { this["PrivateKey"] = value; }
        }

        [ConfigurationProperty("ClientEmail", IsRequired = true)]
        public string ClientEmail
        {
            get { return this["ClientEmail"].ToString(); }
            set { this["ClientEmail"] = value; }
        }

        [ConfigurationProperty("ClientId", IsRequired = true)]
        public string ClientId
        {
            get { return this["ClientId"].ToString(); }
            set { this["ClientId"] = value; }
        }

        [ConfigurationProperty("AuthUri", IsRequired = true)]
        public string AuthUri
        {
            get { return this["AuthUri"].ToString(); }
            set { this["AuthUri"] = value; }
        }

        [ConfigurationProperty("TokenUri", IsRequired = true)]
        public string TokenUri
        {
            get { return this["TokenUri"].ToString(); }
            set { this["TokenUri"] = value; }
        }

        [ConfigurationProperty("AuthProvider", IsRequired = true)]
        public string AuthProvider
        {
            get { return this["AuthProvider"].ToString(); }
            set { this["AuthProvider"] = value; }
        }

        [ConfigurationProperty("ClientCert", IsRequired = true)]
        public string ClientCert
        {
            get { return this["ClientCert"].ToString(); }
            set { this["ClientCert"] = value; }
        }

        [ConfigurationProperty("ApiKey", IsRequired = true)]
        public string ApiKey
        {
            get { return this["ApiKey"].ToString(); }
            set { this["ApiKey"] = value; }
        }

        [ConfigurationProperty("OAuthClientId", IsRequired = true)]
        public string OAuthClientId
        {
            get { return this["OAuthClientId"].ToString(); }
            set { this["OAuthClientId"] = value; }
        }

        [ConfigurationProperty("OAuthClientSecret", IsRequired = true)]
        public string OAuthClientSecret
        {
            get { return this["OAuthClientSecret"].ToString(); }
            set { this["OAuthClientSecret"] = value; }
        }
    }
}
