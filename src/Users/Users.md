# Users

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users v1.0 and/or beta modules.

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
# Remove invalid root paths e.g. users{id}/todo
  - remove-path-by-operation: users_(Get|Create|Update|Delete|Set)(Todo|outlook)
# Remove commands
  - where:
      verb: New
      subject: ^UserLicenseDetail$
    remove: true
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
