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

``` yaml
directive:
  - where:
      verb: New
      subject: PrintPrinter
      variant: ^Create$|^CreateExpanded$
    remove: true
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
