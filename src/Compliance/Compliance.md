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
# Wrapper migration: PATCH and DELETE for the nested /dataSource navigation are
# suppressed in src/Compliance/wrapper/Compliance_cmdletConfigurations.cs and
# mapped in the adjacent Compliance_directiveMigrationMap.json. NamingTests pins
# the behavior. Keep this AutoRest directive active until the service-module
# pipeline is retired.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1$
    remove: true
# Wrapper migration: the wrapper's structural path naming already emits the
# appended DataSource noun for GET .../noncustodialDataSources/{id}/dataSource;
# the adjacent Compliance_directiveMigrationMap.json records the profile evidence
# and NamingTests pins the behavior. Keep this AutoRest rename active until the
# service-module pipeline is retired.
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Get1$|^GetViaIdentity1$
    set:
      subject: $1DataSource
```
