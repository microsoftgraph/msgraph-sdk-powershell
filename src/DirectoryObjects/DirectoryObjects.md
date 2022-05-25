# DirectoryObjects

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DirectoryObjects v1.0 and/or beta modules.

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
# Rename cmdlets
# TODO: Clean up
  # - where:
  #     verb: Get
  #     subject: (^DirectoryObject$)
  #     variant: ^(Get|Get3|GetExpanded|GetExpanded1)$
  #   set:
  #     verb: Get
  #     subject: $1ById
  - where:
      subject: (^DirectoryObject)MicrosoftGraph(AdministrativeUnitDelta$)
    set:
      subject: $1$2
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
