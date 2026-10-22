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
    ];
}
