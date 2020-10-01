namespace Microsoft.Graph.Authentication.Test.Helpers
{
    using Microsoft.Graph.Auth;
    using Microsoft.Graph.PowerShell.Authentication;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;
    using Xunit;
    public class AuthenticationHelpersTests
    {
        public AuthenticationHelpersTests()
        {
            GraphSession.Initialize(() => new GraphSession());
        }

        [Fact]
        public async Task ShouldUseDelegateAuthProviderWhenUserAccessTokenIsProvidedAsync()
        {
            // Arrange
            string accessToken = "ACCESS_TOKEN_VIA_DELEGATE_PROVIDER";
            GraphSession.Instance.UserProvidedToken = new NetworkCredential(string.Empty, accessToken).SecurePassword;
            AuthContext userProvidedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(userProvidedAuthContext);
            HttpRequestMessage requestMessage = new HttpRequestMessage();

            // Act
            await authProvider.AuthenticateRequestAsync(requestMessage);

            // Assert
            Assert.IsType<DelegateAuthenticationProvider>(authProvider);
            Assert.Equal("Bearer", requestMessage.Headers.Authorization.Scheme);
            Assert.Equal(accessToken, requestMessage.Headers.Authorization.Parameter);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldUseDeviceCodeProviderWhenDelegatedContextIsProvided()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new string[] { "User.Read" },
                ContextScope = ContextScope.Process
            };

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(delegatedAuthContext);

            // Assert
            Assert.IsType<DeviceCodeProvider>(authProvider);

            // reset static instance.
            GraphSession.Reset();
        }

#if NETCORE
        [Fact]
        public void ShouldUseClientCredentialProviderWhenAppOnlyContextIsProvided()
        {
            // Arrange
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                CertificateName = "cn=dummyCert",
                ContextScope = ContextScope.Process
            };
            CreateSelfSignedCert(appOnlyAuthContext.CertificateName);

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

            // Assert
            Assert.IsType<ClientCredentialProvider>(authProvider);

            // reset
            DeleteSelfSignedCert(appOnlyAuthContext.CertificateName);
            GraphSession.Reset();
            
        }

        private void CreateSelfSignedCert(string certName)
        {
            ECDsa ecdsaKey = ECDsa.Create();
            CertificateRequest certificateRequest = new CertificateRequest(certName, ecdsaKey, HashAlgorithmName.SHA256);
            // We have to export cert to dummy cert since `CreateSelfSigned` creates a cert without a private key.
            X509Certificate2 cert = certificateRequest.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(5));

            X509Certificate2 dummyCert = null;
            if (PowerShell.Authentication.Helpers.OperatingSystem.IsMacOS())
            {
                dummyCert = new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.Exportable);
            }
            else
            {
                dummyCert = new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.PersistKeySet);
            }
            using (X509Store store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                store.Open(OpenFlags.ReadWrite);
                store.Add(dummyCert);
            }
        }

        private void DeleteSelfSignedCert(string certificateName)
        {
            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                xStore.Open(OpenFlags.ReadWrite);

                X509Certificate2Collection unexpiredCerts = xStore.Certificates
                   .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                   .Find(X509FindType.FindBySubjectDistinguishedName, certificateName, false);

                // Only return current cert.
                var xCertificate = unexpiredCerts
                    .OfType<X509Certificate2>()
                    .OrderByDescending(c => c.NotBefore)
                    .FirstOrDefault();

                xStore.Remove(xCertificate);
            }
        }
#endif

    }
}
