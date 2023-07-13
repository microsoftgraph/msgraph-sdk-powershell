# Devices.ServiceAnnouncement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Devices.ServiceAnnouncement v1.0 and/or beta modules.

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
  - remove-path-by-operation: ^admin(?!\.serviceAnnouncement).*$

# Drop admin from command names.
  - where:
      subject: (.*)AdminServiceAnnouncement(.*)
    set:
      subject: $1ServiceAnnouncement$2
```
