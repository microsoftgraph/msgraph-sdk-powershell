<!-- region Generated -->
# Microsoft.Graph.Beta.Users
This directory contains the PowerShell module for the Users service.

---
## Status
[![Microsoft.Graph.Beta.Users](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Users.svg?style=flat-square&label=Microsoft.Graph.Beta.Users "Microsoft.Graph.Beta.Users")](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Users/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Beta.Users`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../Users.md
title: $(service-name)
subject-prefix: 'Beta'
namespace: Microsoft.Graph.Beta.PowerShell
directive:
  - where:
      verb: New
      subject: ^(UserTodoListTaskLinkedResource)$
    remove: true
```
