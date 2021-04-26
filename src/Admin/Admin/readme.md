<!-- region Generated -->
# Microsoft.Graph.Admin
This directory contains the PowerShell module for the Admin service.

---
## Status
[![Microsoft.Graph.Admin](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Admin.svg?style=flat-square&label=Microsoft.Graph.Admin "Microsoft.Graph.Admin")](https://www.powershellgallery.com/packages/Microsoft.Graph.Admin/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Admin`, see [how-to.md](how-to.md).
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
# Remove cmdlets
  - where:
      verb: Update
      subject: ^AdminWindowUpdateDeploymentAudience$
      variant: ^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$
    remove: true
# Rename cmdlets
  - where:
      verb: Add
      subject: ^(AdminWindowUpdate)(DeploymentAudienceExclusion|DeploymentAudience|UpdatableAsset)(Member)$
      variant: ^Add1$|^AddExpanded1$|^AddViaIdentity1$|^AddViaIdentityExpanded1$
    set:
      subject: $1$2$3ById
  - where:
      verb: Remove
      subject: ^(AdminWindowUpdate)(DeploymentAudienceExclusion|DeploymentAudience|UpdatableAsset)(Member)$
      variant: ^Remove1$|^RemoveExpanded1$|^RemoveViaIdentity1$|^RemoveViaIdentityExpanded1$
    set:
      subject: $1$2$3ById
  - where:
      verb: Invoke
      subject: ^(EnrollAdminWindowUpdate)(DeploymentAudienceExclusion|DeploymentAudienceMember|Updatable)(Asset)$
      variant: ^Enroll1$|^EnrollExpanded1$|^EnrollViaIdentity1$|^EnrollViaIdentityExpanded1$
    set:
      subject: $1$2$3ById
  - where:
      verb: Invoke
      subject: ^(UnenrollAdminWindowUpdate)(DeploymentAudienceExclusion|DeploymentAudienceMember|Updatable)(Asset)$
      variant: ^Unenroll1$|^UnenrollExpanded1$|^UnenrollViaIdentity1$|^UnenrollViaIdentityExpanded1$
    set:
      subject: $1$2$3ById
  - where:
      verb: Update
      subject: ^(AdminWindowUpdateDeploymentAudience)$
      variant: ^Update2$|^UpdateExpanded2$|^UpdateViaIdentity2$|^UpdateViaIdentityExpanded2$
    set:
      subject: $1ById
```

### Versioning

``` yaml
module-version: 1.5.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
