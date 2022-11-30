<!-- region Generated -->
# Microsoft.Graph.WindowsUpdates
This directory contains the PowerShell module for the WindowsUpdates service.

---
## Status
[![Microsoft.Graph.WindowsUpdates](https://img.shields.io/powershellgallery/v/Microsoft.Graph.WindowsUpdates.svg?style=flat-square&label=Microsoft.Graph.WindowsUpdates "Microsoft.Graph.WindowsUpdates")](https://www.powershellgallery.com/packages/Microsoft.Graph.WindowsUpdates/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.WindowsUpdates`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^admin(_.*Windows|.windows_.*Updates|.windows.updates.deployments_.*Audience)$|^admin(?!\.windows).*$
# Pluralize.
  - where:
      subject: (.*)AdminWindowUpdate(.*)
    set:
      subject: $1WindowsUpdates$2
# Remove cmdlets.
  - where:
      subject: ^WindowsUpdatesCatalog$
    remove: true
  - where:
      verb: New|Remove|Update
      subject: ^WindowsUpdates(CatalogEntry|DeploymentAudienceMember|DeploymentAudienceExclusion)$
    remove: true
  - where:
      verb: Add|Remove
      subject: ^WindowsUpdatesDeploymentAudience(ExclusionMember|ExclusionMemberById)$
    remove: true
  - where:
      verb: Invoke
      subject: ^(Enroll|UnEnroll)WindowsUpdatesDeploymentAudience(ExclusionAsset|ExclusionAssetById|MemberAsset|MemberAssetById)$
    remove: true
# Alias cmdlets.
# NB: We have to rename the command to the desired alias name, alias based on the rename, then undo the rename due to:
# - https://github.com/Azure/autorest.powershell/issues/769
  - where:
      subject: (.*)(WindowsUpdates)(.*)
    set:
      subject: $1Wu$3
      alias: ${verb}-Mg${subject}
  - where:
      subject: (.*)(Wu)(.*)
    set:
      subject: $1WindowsUpdates$3
```
### Versioning

``` yaml
module-version: 1.18.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
