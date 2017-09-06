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
            Assert.Equal(new Version(3, 1, 0, 0), version);
        }

        [Fact]
        public void GetApkStreamTest()
        {
            Assert.NotNull(StfServiceApk.GetApkStream());
        }
    }
}
