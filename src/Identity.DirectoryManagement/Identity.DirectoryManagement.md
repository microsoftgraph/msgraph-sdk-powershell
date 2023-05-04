# Identity.DirectoryManagement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Identity.DirectoryManagement v1.0 and/or beta modules.

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
# Remove cmdlets.
  - where:
      verb: Get
      variant: List
      subject: ^DirectoryDeletedItem$
    remove: true
  - where:
      verb: Get
      subject: ^DirectoryDeletedItem(Count)$
    remove: true
  - where:
      verb: Invoke
      subject: (^Delta)(DirectoryDeletedItem)
    remove: true
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(DirectorySettingTemplate|DirectoryRoleTemplate)(\1)+
    set:
      subject: $1
  - where:
      subject: (^Contact)(OrgContact$)
    set:
      subject: $1
  - where:
      subject: ^(Setting)(DirectorySetting)$
    set:
      subject: $2
# Alias DirectoryDeletedItems cmdlets.
  - where:
      subject: ^(DirectoryDeleted)ItemAs(.*)$
    set:
      subject: $1$2
  - where:
      subject: ^DirectoryDeleted(application|administrativeUnit|appRoleAssignment|directoryObject|directoryRole|device|group|orgContact|servicePrincipal|user)$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(DirectoryDeleted)(application|administrativeUnit|appRoleAssignment|directoryObject|directoryRole|device|group|orgContact|servicePrincipal|user)$
    set:
      subject: $1ItemAs$2
```
