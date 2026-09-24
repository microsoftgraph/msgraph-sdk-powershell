using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DeviceManagementAdministrationCmdletConfigurations =
    [
        // Naming-parity sweep (2026-08-13): the other of the two rules proved safe against the
        // whole corpus, fixing real mismatches without rewriting a currently matching name.
        // The resource repeats its parent's name, so segment-joining yields
        // DeviceManagementDeviceManagementPartner. The published SDK collapses the repetition.
        new(OverrideKind.ReplaceNoun, Method: null, "/devicemanagement/devicemanagementpartners", Match: PathMatch.Exact, Value: "DeviceManagementPartner",
            Reason: "oracle ships Get-MgDeviceManagementPartner, not ...DeviceManagementDeviceManagementPartner"),
        new(OverrideKind.ReplaceNoun, Method: null, "/devicemanagement/devicemanagementpartners/{}", Match: PathMatch.Exact, Value: "DeviceManagementPartner",
            Reason: "oracle ships Get-MgDeviceManagementPartner"),
    ];
}
