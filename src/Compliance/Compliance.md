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

``` yaml
directive:
# Wrapper migration: the historical nested /dataSource routes are absent from
# both current Kiota-compatible specs. The adjacent directiveMigrationMap records
# reviewed spec identities/absences, not current generated coverage. Historical
# suppressions and NamingTests remain; keep this AutoRest directive active.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1$
    remove: true
# Wrapper migration: historical structural naming appends DataSource, pinned in
# NamingTests. This GET route is absent from both current specs; the adjacent
# ledger records reviewed absence rather than claiming emitted coverage.
# Keep this AutoRest rename active until the service-module pipeline is retired.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Get1$|^GetViaIdentity1$
    set:
      subject: $1DataSource
```
