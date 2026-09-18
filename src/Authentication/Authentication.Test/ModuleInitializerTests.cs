using Microsoft.Graph.PowerShell.Authentication;
using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using Xunit;

namespace Microsoft.Graph.Authentication.Test
{
    public class ModuleInitializerTests
    {
        private static readonly byte[] MicrosoftPublicKeyToken = new byte[] { 0x31, 0xbf, 0x38, 0x56, 0xad, 0x36, 0x4e, 0x35 };

        [Fact]
        public void ShouldAcceptGraphAssemblyRequester()
        {
            Assembly requester = CreateAssembly("Microsoft.Graph.Users.private");

            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requester,
                dependencyFolder: null,
                isInGraphLoadContext: _ => false,
                allowUnknownRequester: false);

            Assert.True(isOwned);
        }

        [Fact]
        public void ShouldRejectExchangeAssemblyRequester()
        {
            Assembly requester = CreateAssembly("Microsoft.Exchange.Management.ExoPowershellGalleryModule");

            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requester,
                dependencyFolder: null,
                isInGraphLoadContext: _ => false,
                allowUnknownRequester: false);

            Assert.False(isOwned);
        }

        [Fact]
        public void ShouldRejectUnrelatedMicrosoftAssemblyRequester()
        {
            Assembly requester = CreateAssembly("Microsoft.Azure.Commands.Common");

            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requester,
                dependencyFolder: null,
                isInGraphLoadContext: _ => false,
                allowUnknownRequester: false);

            Assert.False(isOwned);
        }

        [Fact]
        public void ShouldAcceptAssemblyInGraphLoadContext()
        {
            Assembly requester = CreateAssembly("ThirdParty.Dependency");

            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requester,
                dependencyFolder: null,
                isInGraphLoadContext: assembly => ReferenceEquals(assembly, requester),
                allowUnknownRequester: false);

            Assert.True(isOwned);
        }

        [Fact]
        public void ShouldAcceptAssemblyLoadedFromDependencyFolder()
        {
            Assembly requester = typeof(Assert).Assembly;
            string dependencyFolder = Path.GetDirectoryName(requester.Location);

            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requester,
                dependencyFolder,
                isInGraphLoadContext: _ => false,
                allowUnknownRequester: false);

            Assert.True(isOwned);
        }

        [Fact]
        public void ShouldRejectUnknownRequesterInPowerShellCore()
        {
            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requestingAssembly: null,
                dependencyFolder: null,
                isInGraphLoadContext: _ => false,
                allowUnknownRequester: false);

            Assert.False(isOwned);
        }

        [Fact]
        public void ShouldPreserveUnknownRequesterFallbackForWindowsPowerShell()
        {
            bool isOwned = AssemblyRequestOwnership.IsOwned(
                requestingAssembly: null,
                dependencyFolder: null,
                isInGraphLoadContext: null,
                allowUnknownRequester: true);

            Assert.True(isOwned);
        }

        [Fact]
        public void ShouldAcceptPackagedAssemblyWithSameIdentity()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);

            Assert.True(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldAcceptHigherPackagedAssemblyVersion()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            var packaged = CreateAssemblyName("Dependency", new Version(2, 0, 0, 0), MicrosoftPublicKeyToken);

            Assert.True(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldRejectLowerPackagedAssemblyVersion()
        {
            var requested = CreateAssemblyName("Dependency", new Version(2, 0, 0, 0), MicrosoftPublicKeyToken);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);

            Assert.False(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldRejectDifferentPublicKeyToken()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), new byte[] { 0x00 });

            Assert.False(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldAcceptWeakNamedAssemblyWithWeakNamedPackage()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), null);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), null);

            Assert.True(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldRejectStrongNamedPackageForWeakNamedRequest()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), null);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);

            Assert.False(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldRejectWeakNamedPackageForStrongNamedRequest()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), null);

            Assert.False(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Fact]
        public void ShouldRejectDifferentCulture()
        {
            var requested = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            requested.CultureName = "en-US";
            var packaged = CreateAssemblyName("Dependency", new Version(1, 0, 0, 0), MicrosoftPublicKeyToken);
            packaged.CultureName = "fr-FR";

            Assert.False(AssemblyIdentity.IsCompatible(requested, packaged));
        }

        [Theory]
        [InlineData("Microsoft.Identity.Client")]
        [InlineData("Microsoft.Identity.Client.Broker")]
        [InlineData("Microsoft.Identity.Client.NativeInterop")]
        public void ShouldShareWamDependenciesInProcess(string assemblyName)
        {
            Assert.True(AssemblyDependencyPolicy.IsProcessShared(assemblyName, "Microsoft.Graph.Authentication.Core"));
        }

        [Theory]
        [InlineData("Azure.Identity")]
        [InlineData("Azure.Identity.Broker")]
        [InlineData("Microsoft.Identity.Client")]
        [InlineData("Microsoft.Identity.Client.Broker")]
        public void ShouldShareIdentityLoggerContractWithWamConsumers(string requestingAssemblyName)
        {
            Assert.True(AssemblyDependencyPolicy.IsProcessShared(
                "Microsoft.IdentityModel.Abstractions",
                requestingAssemblyName));
        }

        [Theory]
        [InlineData("Azure.Identity")]
        [InlineData("Azure.Identity.Broker")]
        [InlineData("Microsoft.Graph.Core")]
        [InlineData("Microsoft.Identity.Client.Extensions.Msal")]
        public void ShouldKeepNonWamDependenciesPrivate(string assemblyName)
        {
            Assert.False(AssemblyDependencyPolicy.IsProcessShared(
                assemblyName,
                "Microsoft.Graph.Authentication.Core"));
        }

        [Theory]
        [InlineData("Microsoft.IdentityModel.Logging")]
        [InlineData("Microsoft.IdentityModel.Tokens")]
        [InlineData("Microsoft.Graph.Core")]
        [InlineData(null)]
        public void ShouldKeepIdentityLoggerContractPrivateForNonWamConsumers(string requestingAssemblyName)
        {
            Assert.False(AssemblyDependencyPolicy.IsProcessShared(
                "Microsoft.IdentityModel.Abstractions",
                requestingAssemblyName));
        }

        [Fact]
        public void ShouldDetachResolverOnlyAfterLastImportIsRemoved()
        {
            var registration = new AssemblyResolverRegistration();
            int attachCount = 0;
            int detachCount = 0;

            registration.Register(() => attachCount++);
            registration.Register(() => attachCount++);
            registration.Unregister(() => detachCount++);

            Assert.Equal(1, attachCount);
            Assert.Equal(0, detachCount);

            registration.Unregister(() => detachCount++);
            registration.Unregister(() => detachCount++);

            Assert.Equal(1, detachCount);
        }

        private static Assembly CreateAssembly(string name)
        {
            return AssemblyBuilder.DefineDynamicAssembly(
                new AssemblyName(name),
                AssemblyBuilderAccess.Run);
        }

        private static AssemblyName CreateAssemblyName(string name, Version version, byte[] publicKeyToken)
        {
            var assemblyName = new AssemblyName(name)
            {
                Version = version
            };
            assemblyName.SetPublicKeyToken(publicKeyToken);
            return assemblyName;
        }
    }
}
