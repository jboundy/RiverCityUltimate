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
            var result = auth.ConfigureCredentials().Result;

            result.Should().NotBeNull();
        }
    }
}
