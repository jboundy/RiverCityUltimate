﻿using System.Configuration;
using RiverCityUltimate.Core.Application;

namespace RiverCityUltimate.Core
{
    public static class Settings
    {
        public static GoogleConfiguration GoogleConfig { get; internal set; }
        public static TwitterConfiguration TwitterConfig { get; internal set; }

        public static void Initialize()
        {
            GoogleConfig = ConfigurationManager.GetSection("GoogleConfiguration") as GoogleConfiguration;
            TwitterConfig = ConfigurationManager.GetSection("TwitterConfiguration") as TwitterConfiguration;
        }
    }
}
