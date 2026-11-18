using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DeviceManagementEnrollmentCmdletConfigurations =
    [
        // DeviceManagement.Enrollment.md's legacy operation-ID selector covers five
        // analytics CRUD routes, not the separately suppressed $count route.
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes legacy analytics operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes legacy analytics operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice/{}",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes legacy analytics operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice/{}",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes legacy analytics operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice/{}",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes legacy analytics operations"),

        // Only inherited assignedPrincipals functions and inherited counts matched the
        // legacy selector. Preserve inheritsPermissionsFrom navigation CRUD and the
        // assignedPrincipals function directly on each role definition.
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/cloudpc/roledefinitions/{}/inheritspermissionsfrom/{}/assignedprincipals(transitive=@transitive,directoryscopetype='@directoryscopetype',directoryscopeid='@directoryscopeid')",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited assignedPrincipals"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/cloudpc/roledefinitions/{}/inheritspermissionsfrom/$count",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited role definition counts"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/devicemanagement/roledefinitions/{}/inheritspermissionsfrom/{}/assignedprincipals(transitive=@transitive,directoryscopetype='@directoryscopetype',directoryscopeid='@directoryscopeid')",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited assignedPrincipals"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/devicemanagement/roledefinitions/{}/inheritspermissionsfrom/$count",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited role definition counts"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/exchange/roledefinitions/{}/inheritspermissionsfrom/{}/assignedprincipals(transitive=@transitive,directoryscopetype='@directoryscopetype',directoryscopeid='@directoryscopeid')",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited assignedPrincipals"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/rolemanagement/exchange/roledefinitions/{}/inheritspermissionsfrom/$count",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes inherited role definition counts"),

        // Already derived for v1.0, but also required for beta and without derived data.
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/devicemanagement/windowsautopilotdeviceidentities/{}",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes Update DeviceManagementWindowAutopilotDeviceIdentity"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get,
            "/devicemanagement/userexperienceanalyticsnotautopilotreadydevice/$count",
            PathMatch.Exact, null, "DeviceManagement.Enrollment.md removes Get DeviceManagementUserExperienceAnalyticNotAutopilotReadyDeviceCount"),
    ];
}
