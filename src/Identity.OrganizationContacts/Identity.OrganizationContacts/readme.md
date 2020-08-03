<!-- region Generated -->
# Microsoft.Graph.Identity.OrganizationContacts
This directory contains the PowerShell module for the IdentityOrganizationContacts service.

---
## Status
[![Microsoft.Graph.Identity.OrganizationContacts](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.OrganizationContacts.svg?style=flat-square&label=Microsoft.Graph.Identity.OrganizationContacts "Microsoft.Graph.Identity.OrganizationContacts")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.OrganizationContacts/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.OrganizationContacts`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''

directive:
# Rename cmdlets
  - where:
      verb: Get
      subject: (^Contact$)
      variant: Get|GetExpanded
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get|New|Remove|Update
      subject: (^Contact)(OrgContact$)
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
