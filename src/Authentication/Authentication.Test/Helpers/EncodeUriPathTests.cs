
using Xunit;
using System;
using Microsoft.Graph.PowerShell.Authentication.Helpers;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class EncodeUriPathTests
    {
        private string url = "https://graph.microsoft.com/beta/users/first.last_foo.com#EXT#@contoso.onmicrosoft.com";
        private string encodedUrl = "https://graph.microsoft.com/beta/users/first.last_foo.com%23EXT%23%40contoso.onmicrosoft.com";

        [Fact]
        public void ShouldReturnAnEncodedUriGivenAUrlWithSpecialCharactersInPathSegments()
        {
            //arrange
            Uri uri = new Uri(url);

            //act
            Uri result = uri.EscapeDataStrings();

            //assert
            Assert.Equal(encodedUrl, result.ToString());
        }
    }
}
