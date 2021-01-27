<!-- region Generated -->
# Microsoft.Graph.Applications
This directory contains the PowerShell module for the Applications service.

---
## Status
[![Microsoft.Graph.Applications](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Applications.svg?style=flat-square&label=Microsoft.Graph.Applications "Microsoft.Graph.Applications")](https://www.powershellgallery.com/packages/Microsoft.Graph.Applications/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Applications`, see [how-to.md](how-to.md).
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
# Remove invalid paths.
  - remove-path-by-operation: onPremisesPublishingProfiles\.(connectors\.memberOf_.*|connectors_GetMemberOf|connectorGroups\.members_.*|connectorGroups_(Get|Create|Update|Delete)Members)

# Remove cmdlets
  - where:
      verb: Test
      subject: (Application|ServicePrincipal)SynchronizationJobCredentials
      variant: Validate1|ValidateExpanded1|ValidateViaIdentity1|ValidateViaIdentityExpanded1
    remove: true
# Rename wrongly named cmdlets
  - where:
      verb: Get
      subject: (^Application$)
      variant: Get2|Get3|GetExpanded|GetExpanded1
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get
      subject: (^ServicePrincipal$)
      variant: Get1|Get3|GetExpanded|GetExpanded1
    set:
      verb: Get
      subject: $1ById
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(OnPremisPublishingProfile)(\1)+
    set:
      subject: $1
# Fix AutoREST OnPremis* typo.
  - where:
      subject: ^OnPremis(PublishingProfile.*)$
    set:
      subject: OnPremise$1
# Fix cmdlet name
  - where:
      subject: (^OnPremisePublishingProfileConnectorMember$)
    set:
      subject: $1Of
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
