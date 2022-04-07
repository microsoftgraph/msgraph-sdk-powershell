using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class AuthenticationHelpersTests
    {
        public AuthenticationHelpersTests()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();
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

            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthenticationProvider(userProvidedAuthContext);
            HttpRequestMessage requestMessage = new HttpRequestMessage();

            // Act
            await authProvider.AuthenticateRequestAsync(requestMessage);

            // Assert
            Assert.IsType<TokenCredentialAuthProvider>(authProvider);
            Assert.Equal("Bearer", requestMessage.Headers.Authorization.Scheme);
            Assert.Equal(accessToken, requestMessage.Headers.Authorization.Parameter);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseDeviceCodeWhenSpecifiedByUserAsync()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process,
                TokenCredentialType = TokenCredentialType.DeviceCode
            };

            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(delegatedAuthContext, default);

            // Assert
            Assert.IsType<DeviceCodeCredential>(tokenCredential);

            // reset static instance.
            GraphSession.Reset();
        }
        [Fact]
        public async Task ShouldUseDeviceCodeWhenFallbackAsync()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process,
                TokenCredentialType = TokenCredentialType.DeviceCode
            };

            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(delegatedAuthContext, default);

            // Assert
            Assert.IsType<DeviceCodeCredential>(tokenCredential);

            // reset static instance.
            GraphSession.Reset();
        }
        [Fact]
        public async Task ShouldUseInteractiveProviderWhenDelegatedAsync()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process
            };

            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(delegatedAuthContext, default);

            // Assert
            Assert.IsType<InteractiveBrowserCredential>(tokenCredential);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseInteractiveAuthenticationProviderWhenDelegatedContextAndClientIdIsProvidedAsync()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                ClientId = Guid.NewGuid().ToString(),
                Scopes = new string[] { "User.Read" },
                ContextScope = ContextScope.Process
            };

            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(delegatedAuthContext, default);

            // Assert
            Assert.IsType<InteractiveBrowserCredential>(tokenCredential);

            // reset static instance.
            GraphSession.Reset();
        }

#if NETCORE
        [Fact]
        public async Task ShouldUseClientCredentialProviderWhenAppOnlyContextIsProvidedAsync()
        {
            // Arrange
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                CertificateSubjectName = "cn=dummyCert",
                ContextScope = ContextScope.Process
            };
            CreateAndStoreSelfSignedCert(appOnlyAuthContext.CertificateSubjectName);

            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            // Assert
            Assert.IsType<ClientCertificateCredential>(tokenCredential);

            // reset
            DeleteSelfSignedCertByName(appOnlyAuthContext.CertificateSubjectName);
            GraphSession.Reset();

        }

        [Fact]
        public async Task ShouldUseInMemoryCertificateWhenProvidedAsync()
        {
            // Arrange
            var certificate = CreateSelfSignedCert("cn=inmemorycert");
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                Certificate = certificate,
                ContextScope = ContextScope.Process
            };
            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            // Assert
            Assert.IsType<ClientCertificateCredential>(tokenCredential);

            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseCertNameInsteadOfPassedInCertificateWhenBothAreSpecifiedAsync()
        {
            // Arrange
            var dummyCertName = "CN=dummycert";
            var inMemoryCertName = "CN=inmemorycert";
            CreateAndStoreSelfSignedCert(dummyCertName);
            var inMemoryCertificate = CreateSelfSignedCert(inMemoryCertName);
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                CertificateSubjectName = dummyCertName,
                Certificate = inMemoryCertificate,
                ContextScope = ContextScope.Process
            };
            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            // Assert
            Assert.IsType<ClientCertificateCredential>(tokenCredential);

            //CleanUp
            DeleteSelfSignedCertByName(appOnlyAuthContext.CertificateSubjectName);
            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseCertThumbPrintInsteadOfPassedInCertificateWhenBothAreSpecifiedAsync()
        {
            // Arrange
            var dummyCertName = "CN=dummycert";
            var inMemoryCertName = "CN=inmemorycert";
            var storedDummyCertificate = CreateAndStoreSelfSignedCert(dummyCertName);
            var inMemoryCertificate = CreateSelfSignedCert(inMemoryCertName);
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                CertificateThumbprint = storedDummyCertificate.Thumbprint,
                Certificate = inMemoryCertificate,
                ContextScope = ContextScope.Process
            };
            // Act
            TokenCredential tokenCredential = await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            // Assert
            Assert.IsType<ClientCertificateCredential>(tokenCredential);

            //CleanUp
            DeleteSelfSignedCertByThumbprint(appOnlyAuthContext.CertificateThumbprint);
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldThrowIfNonExistentCertNameIsProvided()
        {
            // Arrange
            var dummyCertName = "CN=NonExistingCert";
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                CertificateSubjectName = dummyCertName,
                ContextScope = ContextScope.Process
            };
            // Act
            async void action() => await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            //Assert
            Assert.ThrowsAny<Exception>(action);
        }

        [Fact]
        public void ShouldThrowIfNullInMemoryCertIsProvided()
        {
            // Arrange
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = Guid.NewGuid().ToString(),
                Certificate = null,
                ContextScope = ContextScope.Process
            };
            // Act
            async void action() => await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default);

            //Assert
            Assert.Throws<ArgumentNullException>(action);
        }

        /// <summary>
        ///     Create and Store a Self Signed Certificate
        /// </summary>
        /// <param name="certName"></param>
        private static X509Certificate2 CreateAndStoreSelfSignedCert(string certName)
        {
            var cert = CreateSelfSignedCert(certName);
            using (var store = new X509Store(StoreName.My, StoreLocation.CurrentUser))
            {
                store.Open(OpenFlags.ReadWrite);
                store.Add(cert);
            }

            return cert;
        }

        /// <summary>
        ///     Create a Self Signed Certificate
        /// </summary>
        /// <param name="certName"></param>
        /// <returns></returns>
        private static X509Certificate2 CreateSelfSignedCert(string certName)
        {
            ECDsa ecdsaKey = ECDsa.Create();
            CertificateRequest certificateRequest = new CertificateRequest(certName, ecdsaKey, HashAlgorithmName.SHA256);
            // We have to export cert to dummy cert since `CreateSelfSigned` creates a cert without a private key.
            X509Certificate2 cert = certificateRequest.CreateSelfSigned(DateTimeOffset.Now, DateTimeOffset.Now.AddYears(5));

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                return new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.Exportable);
            else
                return new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.PersistKeySet);
        }

        private static void DeleteSelfSignedCertByName(string certificateName)
        {
            using X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
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
        private static void DeleteSelfSignedCertByThumbprint(string certificateThumbPrint)
        {
            using X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            xStore.Open(OpenFlags.ReadWrite);

            X509Certificate2Collection unexpiredCerts = xStore.Certificates
                .Find(X509FindType.FindByTimeValid, DateTime.Now, false)
                .Find(X509FindType.FindByThumbprint, certificateThumbPrint, false);

            // Only return current cert.
            var xCertificate = unexpiredCerts
                .OfType<X509Certificate2>()
                .OrderByDescending(c => c.NotBefore)
                .FirstOrDefault();

            xStore.Remove(xCertificate);
        }
#endif

    }
}
