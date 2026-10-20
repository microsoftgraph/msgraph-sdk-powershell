using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> ComplianceCmdletConfigurations =
    [
        // Historical beta routes, now absent from both current specs (see the adjacent ledger).
        // Compliance.md removes the Update1/Delete1 variants for
        // ComplianceEdiscoveryCaseNoncustodialDataSource. Those variants are the nested
        // /dataSource navigation operations; the parent noncustodialDataSource item remains.
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/compliance/ediscovery/cases/{}/noncustodialdatasources/{}/datasource",
            Match: PathMatch.Exact, Value: null,
            Reason: "Compliance.md removes Update1 for ComplianceEdiscoveryCaseNoncustodialDataSource",
            ApiVersion: "beta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/compliance/ediscovery/cases/{}/noncustodialdatasources/{}/datasource",
            Match: PathMatch.Exact, Value: null,
            Reason: "Compliance.md removes Delete1 for ComplianceEdiscoveryCaseNoncustodialDataSource",
            ApiVersion: "beta"),

        // Compliance.md renames the corresponding Get1 variant by appending DataSource.
        // The wrapper's path-based naming already emits that published noun, so no override
        // entry is needed; NamingTests pins it beside the suppressions above.
    ];
}
