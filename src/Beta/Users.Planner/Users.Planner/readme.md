<!-- region Generated -->
# Microsoft.Graph.Users.Planner
This directory contains the PowerShell module for the UsersPlanner service.

---
## Status
[![Microsoft.Graph.Users.Planner](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.Planner.svg?style=flat-square&label=Microsoft.Graph.Users.Planner "Microsoft.Graph.Users.Planner")](https://www.powershellgallery.com/packages/Microsoft.Graph.Users.Planner/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Users.Planner`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
  - where:
      verb: Update
      subject: UserPlanner
      variant: Update1|UpdateExpanded1|UpdateViaIdentity1|UpdateViaIdentityExpanded1
    set:
      subject: AllUserPlanner
```
### Versioning

``` yaml
module-version: 0.7.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
