# Devices.CloudPrint

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Devices.CloudPrint v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The reviewed wrapper migration covers only these shared cmdlet directives, not
`src/readme.graph.md` or either profile-local readme. No shared parameter or
schema/response directives are present; those directive classes remain deferred.

``` yaml
directive:
# Wrapper migration: no operation IDs match this report selector in either
# compatible spec. The adjacent Devices.CloudPrint_directiveMigrationMap.json
# records reviewed absence; DevicesCloudPrintDirectiveMigrationTests pins it.
# Keep the AutoRest directive active until the service-module pipeline is retired.
  - remove-path-by-operation: ^print(_.*Report|\.report.*)
# Wrapper migration: suppress only POST /print/printers (print.CreatePrinters),
# not the /print/printers/create action or any other printer operation.
# Devices.CloudPrint_cmdletConfigurations.cs extends existing v1.0 derived
# suppression to beta and no-data runs. The adjacent ledger and module tests
# record both profiles; keep this AutoRest directive active.
  - where:
      verb: New
      subject: PrintPrinter
      variant: ^Create$|^CreateExpanded$
    remove: true
```
