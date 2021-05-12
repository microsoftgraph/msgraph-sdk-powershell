﻿namespace Microsoft.Graph.Authentication.Test.Helpers
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
        public void ShouldUseDeviceCodeWhenSpecifiedByUser()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process,
                AuthProviderType = AuthProviderType.DeviceCodeProvider
            };

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(delegatedAuthContext);

            // Assert
            Assert.IsType<DeviceCodeProvider>(authProvider);

            // reset static instance.
            GraphSession.Reset();
        }
        [Fact]
        public void ShouldUseDeviceCodeWhenFallback()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process,
                AuthProviderType = AuthProviderType.DeviceCodeProviderFallBack
            };

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(delegatedAuthContext);

            // Assert
            Assert.IsType<DeviceCodeProvider>(authProvider);

            // reset static instance.
            GraphSession.Reset();
        }
        [Fact]
        public void ShouldUseInteractiveProviderWhenDelegated()
        {
            // Arrange
            AuthContext delegatedAuthContext = new AuthContext
            {
                AuthType = AuthenticationType.Delegated,
                Scopes = new[] { "User.Read" },
                ContextScope = ContextScope.Process
            };

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(delegatedAuthContext);

            // Assert
            Assert.IsType<InteractiveAuthenticationProvider>(authProvider);

            // reset static instance.
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldUseInteractiveAuthenticationProviderWhenDelegatedContextAndClientIdIsProvided()
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
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(delegatedAuthContext);

            // Assert
            Assert.IsType<InteractiveAuthenticationProvider>(authProvider);

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
            CreateAndStoreSelfSignedCert(appOnlyAuthContext.CertificateName);

            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

            // Assert
            Assert.IsType<ClientCredentialProvider>(authProvider);

            // reset
            DeleteSelfSignedCertByName(appOnlyAuthContext.CertificateName);
            GraphSession.Reset();

        }

        [Fact]
        public void ShouldUseInMemoryCertificateWhenProvided()
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
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

            // Assert
            Assert.IsType<ClientCredentialProvider>(authProvider);
            var clientCredentialProvider = (ClientCredentialProvider)authProvider;
            // Assert: That the certificate created and set above is the same as used here.
            Assert.Equal(clientCredentialProvider.ClientApplication.AppConfig.ClientCredentialCertificate, certificate);
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldUseCertNameInsteadOfPassedInCertificateWhenBothAreSpecified()
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
                CertificateName = dummyCertName,
                Certificate = inMemoryCertificate,
                ContextScope = ContextScope.Process
            };
            // Act
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

            // Assert
            Assert.IsType<ClientCredentialProvider>(authProvider);
            var clientCredentialProvider = (ClientCredentialProvider)authProvider;
            // Assert: That the certificate used is dummycert, that is in the store
            Assert.NotEqual(inMemoryCertName, clientCredentialProvider.ClientApplication.AppConfig.ClientCredentialCertificate.SubjectName.Name);
            Assert.Equal(appOnlyAuthContext.CertificateName, clientCredentialProvider.ClientApplication.AppConfig.ClientCredentialCertificate.SubjectName.Name);

            //CleanUp
            DeleteSelfSignedCertByName(appOnlyAuthContext.CertificateName);
            GraphSession.Reset();
        }

        [Fact]
        public void ShouldUseCertThumbPrintInsteadOfPassedInCertificateWhenBothAreSpecified()
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
            IAuthenticationProvider authProvider = AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

            // Assert
            Assert.IsType<ClientCredentialProvider>(authProvider);
            var clientCredentialProvider = (ClientCredentialProvider)authProvider;
            // Assert: That the certificate used is dummycert (Thumbprint), that is in the store
            Assert.NotEqual(inMemoryCertName, clientCredentialProvider.ClientApplication.AppConfig.ClientCredentialCertificate.SubjectName.Name);
            Assert.Equal(appOnlyAuthContext.CertificateThumbprint, clientCredentialProvider.ClientApplication.AppConfig.ClientCredentialCertificate.Thumbprint);

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
                CertificateName = dummyCertName,
                ContextScope = ContextScope.Process
            };
            // Act
            Action action = () => AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

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
            Action action = () => AuthenticationHelpers.GetAuthProvider(appOnlyAuthContext);

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

            X509Certificate2 dummyCert = null;
            if (PowerShell.Authentication.Helpers.OperatingSystem.IsMacOS())
            {
                dummyCert = new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.Exportable);
            }
            else
            {
                dummyCert = new X509Certificate2(cert.Export(X509ContentType.Pfx, "P@55w0rd"), "P@55w0rd", X509KeyStorageFlags.PersistKeySet);
            }

            return dummyCert;
        }

        private static void DeleteSelfSignedCertByName(string certificateName)
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
        private static void DeleteSelfSignedCertByThumbprint(string certificateThumbPrint)
        {
            using (X509Store xStore = new X509Store(StoreName.My, StoreLocation.CurrentUser))
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
#endif

    }
}
