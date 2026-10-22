# Compliance

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Compliance v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The shared directives below were reviewed against both current Kiota-compatible
profiles. Each exposes only `GET /compliance` and `PATCH /compliance`; neither
contains the retired eDiscovery nested `dataSource` operations. The adjacent
`wrapper/Compliance_directiveMigrationMap.json` records expected absence in each
profile, not coverage of APIs that are no longer available. The exact suppression
configuration remains dormant to preserve the shared directive semantics, and
structural naming still supplies the intended noun if that route is reintroduced.
`ComplianceDirectiveMigrationTests` distinguishes these synthetic semantic checks
from current-spec coverage and pins the unaffected root operations.

Only this shared file is in migration scope. Global and profile-specific readme
directives are excluded. There are no parameter or schema directives in this
shared file; those directive classes remain deferred.

``` yaml
directive:
# Wrapper migration: expected absent in v1.0 and beta. Dormant exact PATCH/DELETE
# suppressions remain in Compliance_cmdletConfigurations.cs; the adjacent ledger
# records the retired coverage. Keep this AutoRest directive active.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1$
    remove: true
# Wrapper migration: expected absent in v1.0 and beta. Structural naming supplies
# the appended DataSource noun for the retired nested GET without an override.
# The adjacent ledger records absence, not a generated cmdlet. Keep this rename active.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Get1$|^GetViaIdentity1$
    set:
      subject: $1DataSource
```
