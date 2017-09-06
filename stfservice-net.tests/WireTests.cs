using Google.Protobuf;
using Jp.Co.Cyberagent.Stf.Proto;
using System.IO;
using Xunit;

namespace StfService.Net.Tests
{
    public class WireTests
    {
        // Only purpose of this test is to make sure that Wire.cs has been generated properly by making sure one of the types
        // that should live in that file, actually exist.
        [Fact]
        public void TestDoIdentifyRequest()
        {
            using (MemoryStream buffer = new MemoryStream())
            using (CodedOutputStream stream = new CodedOutputStream(buffer))
            {
                var request = new DoIdentifyRequest();
                request.Serial = "1234";

                request.WriteTo(stream);
                stream.Flush();

                var expected = new byte[] { 0x0a, 0x04, 0x31, 0x32, 0x33, 0x34 };
                Assert.Equal(expected, buffer.ToArray());
            }
        }
    }
}
