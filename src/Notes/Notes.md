# Notes

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Notes v1.0 and/or beta modules.

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
# Remove paths that are not valid.
  - remove-path-by-operation: ^(users|groups|sites)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebooks_(Get|Update|Delete)Section.*|.*\.notebooks\.section.*|.*\.sectionGroups_(Get|Update|Delete)Section.*|.*\.sectionGroups\.section.*|.*\.sections_(Get|Update|Delete)Pages|.*\.sections.pages.*|.*\.onenote_(List|Create|Update|Delete)(Operations|Resources)
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
