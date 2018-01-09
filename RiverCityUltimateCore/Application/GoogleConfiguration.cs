using System.Configuration;

namespace RiverCityUltimate.Core.Application
{
    public class GoogleConfiguration : ConfigurationSection
    {
        public string AuthorizationCode => "authorization_code";

        [ConfigurationProperty("ClientId", DefaultValue = "", IsRequired = true)]
        public string ClientId
        {
            get { return this["ClientId"].ToString(); }
            set { this["ClientId"] = value; }
        }

        [ConfigurationProperty("ProjectId", IsRequired = true)]
        public string ProjectId
        {
            get { return this["ProjectId"].ToString(); }
            set { this["ProjectId"] = value; }
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

        [ConfigurationProperty("ClientSecret", IsRequired = true)]
        public string ClientSecret
        {
            get { return this["ClientSecret"].ToString(); }
            set { this["ClientSecret"] = value; }
        }

        [ConfigurationProperty("FileId", IsRequired = true)]
        public string FileId
        {
            get { return this["FileId"].ToString(); }
            set { this["FileId"] = value; }
        }

        [ConfigurationProperty("ClientCert", IsRequired = true)]
        public string ClientCert
        {
            get { return this["ClientCert"].ToString(); }
            set { this["ClientCert"] = value; }
        }

    }
}
