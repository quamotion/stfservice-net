using System;
using Xunit;

namespace StfService.Net.Tests
{
    public class StfServiceApkTests
    {
        [Fact]
        public void GetVersionTest()
        {
            var version = StfServiceApk.GetVersion();
            Assert.Equal(3, version.Major);
            Assert.Equal(1, version.Minor);
            Assert.Equal(0, version.Build);
        }

        [Fact]
        public void GetApkStreamTest()
        {
            Assert.NotNull(StfServiceApk.GetApkStream());
        }
    }
}
