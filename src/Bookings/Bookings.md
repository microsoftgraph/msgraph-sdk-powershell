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
  - remove-path-by-operation: ^solution\.solutionsRoot.*$
# Remove cmdlets
  - where:
      subject: ^(.*)VirtualEvent$
      variant: ^Get$|^Delete$|^Update$|^UpdateExpanded$
    remove: true
# Rename cmdlets
  - where:
      subject: ^Solution(.*)$
    set:
      subject: $1
```
