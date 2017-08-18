using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using RiverCityUltimate.Core;
using Xunit;

namespace RiverCityUltimate.GoogleIntegration.Tests
{
    public class AuthorizationTests
    {
        public AuthorizationTests()
        {
            Settings.Initialize();
        }

        [Fact]
        public void CanRetrieveAuthorizationFromGoogle()
        {
            var auth = new Authorization();
            var result = auth.ExportRequestAsync().Result;

            result.Should().NotBeNull();
        }
    }
}
