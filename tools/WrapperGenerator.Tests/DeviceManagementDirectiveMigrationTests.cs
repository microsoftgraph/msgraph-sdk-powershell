using System.Net.Http;
using WrapperGenerator;
using Xunit;

namespace WrapperGenerator.Tests;

public sealed class DeviceManagementDirectiveMigrationTests
{
    [Theory]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/assignedAccessMultiModeProfiles")]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/windowsPrivacyAccessControls")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}/managedDevice")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/$count")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}/managedDevice")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/$count")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}/definitionValue")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}/presentation")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/$count")]
    [InlineData("POST", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/updateDefinitionValues")]
    [InlineData("POST", "/deviceManagement/intents/{deviceManagementIntent-id}/updateSettings")]
    [InlineData("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers/{microsoftTunnelServer-id}/createServerLogCollectionRequest")]
    [InlineData("POST", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("POST", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}")]
    public void ReviewedRoutesAreSuppressedWithOrWithoutDerivedData(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path));
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
            Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
            Assert.True(CmdletConfigurator.IsSuppressed(httpMethod, path.ToUpperInvariant() + "/", config));
        }
    }

    [Theory]
    [InlineData("GET", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("GET", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("DELETE", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("POST", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}/createDownloadUrl")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("DELETE", "/deviceManagement/comanagedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}")]
    [InlineData("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}")]
    [InlineData("GET", "/deviceManagement/comanagedDevices")]
    [InlineData("POST", "/deviceManagement/comanagedDevices")]
    [InlineData("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}/deviceCategory")]
    [InlineData("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates")]
    [InlineData("GET", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates")]
    [InlineData("GET", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates/{deviceManagementScriptDeviceState-id}")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues")]
    [InlineData("GET", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}/presentationValues/{groupPolicyPresentationValue-id}")]
    [InlineData("PATCH", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/definitionValues/{groupPolicyDefinitionValue-id}")]
    [InlineData("PATCH", "/deviceManagement/intents/{deviceManagementIntent-id}/settings/{deviceManagementSettingInstance-id}")]
    [InlineData("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/assign")]
    [InlineData("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers/{microsoftTunnelServer-id}/generateServerLogCollectionRequest")]
    public void NeighboringOperationsRemainAvailable(string method, string path)
    {
        var httpMethod = new HttpMethod(method);
        Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path));
        foreach (var profile in new[] { "v1.0", "beta" })
        foreach (var useCollisionData in new[] { false, true })
        {
            var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
            Assert.False(CmdletConfigurator.IsSuppressed(httpMethod, path, config));
        }
    }

    [Theory]
    [InlineData("v1.0", false)]
    [InlineData("v1.0", true)]
    [InlineData("beta", false)]
    [InlineData("beta", true)]
    public void UnaffectedLogAndComanagedDeviceNamesArePreserved(string profile, bool useCollisionData)
    {
        var config = new GeneratorConfig("Test.Client", "unused", profile, useCollisionData);
        var logRequest = Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests"), config);
        Assert.Equal("Get", logRequest.VerbName);
        Assert.Equal("MgDeviceManagementManagedDeviceLogCollectionRequest", logRequest.Noun);
        var comanagedDevice = Naming.Resolve(new OperationInfo(HttpMethod.Get,
            "/deviceManagement/comanagedDevices/{managedDevice-id}"), config);
        Assert.Equal("Get", comanagedDevice.VerbName);
        Assert.Equal("MgDeviceManagementComanagedDevice", comanagedDevice.Noun);
    }
}
