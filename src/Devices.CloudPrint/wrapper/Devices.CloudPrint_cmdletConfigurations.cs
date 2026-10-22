using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DevicesCloudPrintCmdletConfigurations =
    [
        // v1.0 parity data already suppresses this route. The shared directive also
        // applies to beta and no-data runs; /printers/create is a separate action.
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/print/printers",
            Match: PathMatch.Exact, Value: null,
            Reason: "Devices.CloudPrint.md removes New PrintPrinter Create/CreateExpanded"),

        // Carry the existing collision-suppressions.v1.0.json policy into beta.
        // Both profiles' published metadata uses the collection $ref DELETE;
        // keep that route and its GET/POST siblings, not a duplicate item DELETE.
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/print/shares/{}/allowedgroups/{}/$ref", PathMatch.Exact, null,
            "Existing reviewed collision policy; Remove-Mg(Beta)PrintShareAllowedGroupByRef uses collection $ref"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/print/shares/{}/allowedusers/{}/$ref", PathMatch.Exact, null,
            "Existing reviewed collision policy; Remove-Mg(Beta)PrintShareAllowedUserByRef uses collection $ref"),
    ];
}
