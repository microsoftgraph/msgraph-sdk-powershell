using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DeviceManagementCmdletConfigurations =
    [
        // DeviceManagement.md directive 1; the adjacent ledger bridges the complete legacy
        // selector, including five qualified final action segments, to compatible operations.
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/deviceconfigurations/{}/assignedaccessmultimodeprofiles",
            PathMatch.Exact, null, "DeviceManagement.md: invalid assignedAccessMultiModeProfile action"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/deviceconfigurations/{}/windowsprivacyaccesscontrols",
            PathMatch.Exact, null, "DeviceManagement.md: invalid windowsPrivacyAccessControl action"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/devicemanagementscripts/{}/userrunstates/{}/devicerunstates/{}/manageddevice",
            PathMatch.Exact, null, "DeviceManagement.md: invalid nested script managedDevice navigation"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/devicemanagementscripts/{}/userrunstates/{}/devicerunstates/$count",
            PathMatch.Exact, null, "DeviceManagement.md: invalid nested script deviceRunStates count"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/deviceshellscripts/{}/userrunstates/{}/devicerunstates/{}/manageddevice",
            PathMatch.Exact, null, "DeviceManagement.md: invalid nested shell script managedDevice navigation"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/deviceshellscripts/{}/userrunstates/{}/devicerunstates/$count",
            PathMatch.Exact, null, "DeviceManagement.md: invalid nested shell script deviceRunStates count"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/grouppolicyconfigurations/{}/definitionvalues/{}/presentationvalues/{}/definitionvalue",
            PathMatch.Exact, null, "DeviceManagement.md: invalid presentationValue definitionValue navigation"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/grouppolicyconfigurations/{}/definitionvalues/{}/presentationvalues/{}/presentation",
            PathMatch.Exact, null, "DeviceManagement.md: invalid presentationValue presentation navigation"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/grouppolicyconfigurations/{}/definitionvalues/{}/presentationvalues/$count",
            PathMatch.Exact, null, "DeviceManagement.md: invalid presentationValues count"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/grouppolicyconfigurations/{}/updatedefinitionvalues",
            PathMatch.Exact, null, "DeviceManagement.md: invalid updateDefinitionValue action"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/intents/{}/updatesettings",
            PathMatch.Exact, null, "DeviceManagement.md: invalid updateSetting action"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/microsofttunnelsites/{}/microsofttunnelservers/{}/createserverlogcollectionrequest",
            PathMatch.Exact, null, "DeviceManagement.md: invalid createServerLogCollectionRequest action"),

        // The derived v1.0 data already suppresses the managed-device POST, but beta
        // has no derived coverage. Keep both shared directive 2 routes profile-independent.
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/manageddevices/{}/logcollectionrequests",
            PathMatch.Exact, null, "DeviceManagement.md: remove New managed-device logCollectionRequest"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/comanageddevices/{}/logcollectionrequests",
            PathMatch.Exact, null, "DeviceManagement.md: remove New comanaged-device logCollectionRequest"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/devicemanagement/comanageddevices/{}",
            PathMatch.Exact, null, "DeviceManagement.md: remove Update comanagedDevice"),
    ];
}
