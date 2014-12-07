using System.IO;
using FitFilePreviewer.Decode.Fit.Types;
using NUnit.Framework;

namespace FitFilePreviewer.Decode.IntergrationTests
{
    public class DecoderTest
    {
        [Test, Explicit]
        public void CanDecode()
        {
            const string fileName = @"Examples\Activity.fit";
            var decoder = new Decoder();
            using (var file = System.IO.File.Open(fileName, FileMode.Open))
            {
                var result = decoder.Decode(file);
                Assert.AreEqual(Sport.Running, result.Sport);
            }
        }

        [Test, Explicit]
        public void ReturnsEmptyWhenDecodingSettingsFile()
        {
            const string fileName = @"Examples\Settings.fit";
            var decoder = new Decoder();
            using (var file = System.IO.File.Open(fileName, FileMode.Open))
            {
                var result = decoder.Decode(file);
                Assert.IsNull(result);
            }
        }
    }
}
