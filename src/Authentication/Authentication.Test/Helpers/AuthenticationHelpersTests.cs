using Azure.Core;
using Azure.Identity;
using Microsoft.Graph.Authentication.Test.Mocks;
using Microsoft.Graph.PowerShell.Authentication;
using Microsoft.Graph.PowerShell.Authentication.Core.TokenCache;
using Microsoft.Graph.PowerShell.Authentication.Core.Utilities;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.Graph.Authentication.Test.Helpers
{
    public class AuthenticationHelpersTests : IDisposable
    {
        private MockAuthRecord mockAuthRecord;
        public AuthenticationHelpersTests()
        {
            GraphSession.Initialize(() => new GraphSession());
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache();
            mockAuthRecord = new MockAuthRecord("test");
            mockAuthRecord.SerializeToFile();
        }

        [Fact]
        public async Task ShouldUseDelegateAuthProviderWhenUserAccessTokenIsProvidedAsync()
        {
            // Arrange
            string accessToken = "ACCESS_TOKEN_VIA_DELEGATE_PROVIDER";
            GraphSession.Instance.InMemoryTokenCache = new InMemoryTokenCache(Encoding.UTF8.GetBytes(accessToken));
            AuthContext userProvidedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.UserProvidedAccessToken,
                ContextScope = ContextScope.Process
            };

            IAuthenticationProvider authProvider = await AuthenticationHelpers.GetAuthenticationProviderAsync(userProvidedAuthContext);
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

        [Fact]
        public async Task ShouldThrowWhenAuthContextIsNullAsync()
        {
            // Act
            var exception = await Assert.ThrowsAsync<PowerShell.AuthenticationException>(async () => await AuthenticationHelpers.GetTokenCredentialAsync(null, default));

            // Assert
            Assert.Equal(PowerShell.Authentication.Core.ErrorConstants.Message.MissingAuthContext, exception.Message);

            // reset
            GraphSession.Reset();
        }

        [Fact]
        public async Task ShouldUseClientCredentialProviderWhenAppOnlyContextIsProvidedAsync()
        {
            // Arrange
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = mockAuthRecord.ClientId,
                CertificateSubjectName = "cn=dummyCert",
                ContextScope = ContextScope.Process,
                TenantId = mockAuthRecord.TenantId
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
                ClientId = mockAuthRecord.ClientId,
                Certificate = certificate,
                ContextScope = ContextScope.Process,
                TenantId = mockAuthRecord.TenantId
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
                ClientId = mockAuthRecord.ClientId,
                CertificateSubjectName = dummyCertName,
                Certificate = inMemoryCertificate,
                ContextScope = ContextScope.Process,
                TenantId= mockAuthRecord.TenantId
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
                ClientId = mockAuthRecord.ClientId,
                CertificateThumbprint = storedDummyCertificate.Thumbprint,
                Certificate = inMemoryCertificate,
                ContextScope = ContextScope.Process,
                TenantId = mockAuthRecord.TenantId
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
        public async Task ShouldThrowIfNonExistentCertNameIsProvidedAsync()
        {
            // Arrange
            var dummyCertName = "CN=NonExistingCert";
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = mockAuthRecord.ClientId,
                CertificateSubjectName = dummyCertName,
                ContextScope = ContextScope.Process,
                TenantId = mockAuthRecord.TenantId
            };

            // Act
            var exception = await Assert.ThrowsAsync<ArgumentException>(async () => await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default));

            //Assert
            Assert.Equal(string.Format(CultureInfo.InvariantCulture, PowerShell.Authentication.Core.ErrorConstants.Message.CertificateNotFound, "subject name", dummyCertName), exception.Message);
        }

        [Fact]
        public async Task ShouldThrowIfNullInMemoryCertIsProvidedAsync()
        {
            // Arrange
            AuthContext appOnlyAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.AppOnly,
                ClientId = mockAuthRecord.ClientId,
                Certificate = null,
                ContextScope = ContextScope.Process,
                TenantId = mockAuthRecord.TenantId
            };

            // Act
            var exception = await Assert.ThrowsAsync<ArgumentNullException>(async () => await AuthenticationHelpers.GetTokenCredentialAsync(appOnlyAuthContext, default));

            //Assert
            Assert.Equal("certificate", exception.ParamName);
        }

        /// <summary>
        ///     Create and Store a Self Signed Certificate
        /// </summary>
        /// <param name="certName"></param>
        private static X509Certificate2 CreateAndStoreSelfSignedCert(string certName, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            var cert = CreateSelfSignedCert(certName);
            using (var store = new X509Store(StoreName.My, storeLocation))
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

        private static void DeleteSelfSignedCertByName(string certificateName, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            using (X509Store xStore = new X509Store(StoreName.My, storeLocation))
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
        private static void DeleteSelfSignedCertByThumbprint(string certificateThumbPrint, StoreLocation storeLocation = StoreLocation.CurrentUser)
        {
            using (X509Store xStore = new X509Store(StoreName.My, storeLocation))
            {
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
        }
        
        public void Dispose() => mockAuthRecord.DeleteCache();
    }
}
