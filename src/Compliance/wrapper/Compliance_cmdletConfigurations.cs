using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> ComplianceCmdletConfigurations =
    [
        // Compliance.md removes the Update1/Delete1 variants for
        // ComplianceEdiscoveryCaseNoncustodialDataSource. Those variants are the nested
        // /dataSource navigation operations. Neither compatible profile currently contains
        // eDiscovery routes (see the reviewed ledger); retain these dormant exact rules
        // without affecting /compliance or the parent item if the routes return.
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/compliance/ediscovery/cases/{}/noncustodialdatasources/{}/datasource",
            Match: PathMatch.Exact, Value: null,
            Reason: "Compliance.md removes Update1 for ComplianceEdiscoveryCaseNoncustodialDataSource"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete,
            "/compliance/ediscovery/cases/{}/noncustodialdatasources/{}/datasource",
            Match: PathMatch.Exact, Value: null,
            Reason: "Compliance.md removes Delete1 for ComplianceEdiscoveryCaseNoncustodialDataSource"),

        // Compliance.md renames the corresponding Get1 variant by appending DataSource.
        // The wrapper's path-based naming already emits that published noun, so no override
        // entry is needed. ComplianceDirectiveMigrationTests pins the retired semantics
        // separately from actual current-spec coverage.
    ];
}
