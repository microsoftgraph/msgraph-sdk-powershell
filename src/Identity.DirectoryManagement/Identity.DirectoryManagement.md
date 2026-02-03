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
  - remove-path-by-operation: ^tenantRelationship\.managedTenant\.managementTemplateStepVersion\.deployment_changeDeploymentStatus$
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
      alias: ${verb}-Mg${subject-prefix}${subject}
  - where:
      subject: ^(DirectoryDeleted)(application|administrativeUnit|appRoleAssignment|directoryObject|directoryRole|device|group|orgContact|servicePrincipal|user)$
    set:
      subject: $1ItemAs$2
##Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0.
  - remove-path-by-operation: ^device_DeleteRegisteredOwnerGraphBPreRef$|^device_DeleteRegisteredUserGraphBPreRef$|^directory.administrativeUnit_DeleteMemberGraphBPreRef$|^directoryRole_DeleteMemberGraphBPreRef$|^directory.featureRolloutPolicy_ListAppliesToGraphBPreRef$
```
