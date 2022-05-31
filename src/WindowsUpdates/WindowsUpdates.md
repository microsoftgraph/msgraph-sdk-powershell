# WindowsUpdates

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for WindowsUpdates v1.0 and/or beta modules.

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
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
