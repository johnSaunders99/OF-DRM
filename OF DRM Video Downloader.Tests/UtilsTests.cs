using WidevineClient;
using Xunit;

namespace OF_DRM_Video_Downloader.Tests
{
    public class UtilsTests
    {
        [Fact]
        public void Base64Pad_AddsExpectedPadding()
        {
            string unpadded = "YWJjZGU"; // length 7

            string result = Utils.Base64Pad(unpadded);

            Assert.Equal("YWJjZGU=", result);
            Assert.Equal(0, result.Length % 4);
        }

        [Fact]
        public void Base64Pad_DoesNotChangeValidPadding()
        {
            string alreadyPadded = "YWJjZGU=\n".Trim();

            string result = Utils.Base64Pad(alreadyPadded);

            Assert.Equal(alreadyPadded, result);
        }
    }
}
