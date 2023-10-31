using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using Microsoft.Identity.Client;
using Moq;
using System;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class JwtHelpersTests
    {
        private readonly IAccount _mockIAccount;
        public JwtHelpersTests()
        {
            _mockIAccount = GetIAccountMock();
        }

        [Fact]
        public void DecodeJWTStringShouldReturnAuthContextWithClaims()
        {
            IAuthContext authContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated
            };

            JwtHelpers.DecodeJWT(MockConstants.DummyAccessToken, _mockIAccount, ref authContext);

            Assert.Equal("mockAppId", authContext.ClientId);
            Assert.Equal("mockTid", authContext.TenantId);
            Assert.Equal("upn@contoso.com", authContext.Account);
            Assert.Equal(2, authContext.Scopes.Length);
        }

        [Fact]
        public void DecodeJWTStringShouldReturnNullAuthContextWhenTokenIsNotJWT()
        {
            IAuthContext authContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated
            };

            JwtHelpers.DecodeJWT("EwCQA_NOT_JWT", _mockIAccount, ref authContext);

            Assert.Null(authContext.Scopes);
            Assert.Equal("mockUsername", authContext.Account);
        }

        [Fact]
        public void DecodeJWTStringShouldThrowExceptionWhenTokenIsExpired()
        {
            IAuthContext authContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken
            };

            _ = Assert.Throws<Exception>(() => JwtHelpers.DecodeJWT(MockConstants.DummyAccessToken, _mockIAccount, ref authContext));
        }

        private IAccount GetIAccountMock()
        {
            var accountId = new AccountId("mockId", "mockObjectId", "mockTenantId");
            Mock<IAccount> accountMock = new Mock<IAccount>();
            _ = accountMock.SetupGet(account => account.HomeAccountId).Returns(accountId);
            _ = accountMock.SetupGet(account => account.Username).Returns("mockUsername");
            return accountMock.Object;
        }
    }
}
