using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverCityUltimate.Core.Application
{
    public class TwitterConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("ApiKey", IsRequired = true)]
        public string ApiKey
        {
            get { return this["ApiKey"].ToString(); }
            set { this["ApiKey"] = value; }
        }

        [ConfigurationProperty("ApiSecret", IsRequired = true)]
        public string ApiSecret
        {
            get { return this["ApiSecret"].ToString(); }
            set { this["ApiSecret"] = value; }
        }
    }
}
