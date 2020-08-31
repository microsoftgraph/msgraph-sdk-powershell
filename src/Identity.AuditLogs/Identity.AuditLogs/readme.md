<!-- region Generated -->
# Microsoft.Graph.Identity.AuditLogs
This directory contains the PowerShell module for the IdentityAuditLogs service.

---
## Status
[![Microsoft.Graph.Identity.AuditLogs](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.AuditLogs.svg?style=flat-square&label=Microsoft.Graph.Identity.AuditLogs "Microsoft.Graph.Identity.AuditLogs")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.AuditLogs/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.AuditLogs`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''

```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove paths that are not valid.
  - remove-path-by-operation: auditLogs.auditLogRoot_.*|auditLogs_(Create|Update|Delete).*
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
