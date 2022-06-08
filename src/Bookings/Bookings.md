# Bookings

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Bookings v1.0 and/or beta modules.

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
# Remove invalid paths.
  - remove-path-by-operation: ^solutions.solutionsRoot.*$
# Rename cmdlets
  - where:
      subject: ^Solution(.*)$
    set:
      subject: $1
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
