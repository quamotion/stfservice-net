using System;
using System.IO;
using System.Reflection;

namespace StfService.Net
{
    public static class StfServiceApk
    {
        public static Version GetVersion()
        {
            var assembly = typeof(StfServiceApk).GetTypeInfo().Assembly;
            var versionString = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>().Version;
            return new Version(versionString);
        }

        public static Stream GetApkStream()
        {
            var assembly = typeof(StfServiceApk).GetTypeInfo().Assembly;
            return assembly.GetManifestResourceStream("stfservice-net.STFService.apk");
        }
    }
}
