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
# Wrapper migration: all 11 shared groups are reviewed in the adjacent wrapper
# Identity.DirectoryManagement_directiveMigrationMap.json; module regression tests
# pin both profiles. Keep these AutoRest directives active until pipeline retirement.
# Group 1: no original legacy or compatible operation-ID match in either module spec.
# This is an unmatched selector, not evidence that a converted ID proves API absence.
  - remove-path-by-operation: ^tenantRelationship\.managedTenant\.managementTemplateStepVersion\.deployment_changeDeploymentStatus$
# Remove cmdlets.
# Group 2: suppress GET /directory/deletedItems only; preserve item GET and typed casts.
  - where:
      verb: Get
      variant: List
      subject: ^DirectoryDeletedItem$
    remove: true
# Group 3: suppress only the untyped /directory/deletedItems/$count.
  - where:
      verb: Get
      subject: ^DirectoryDeletedItem(Count)$
    remove: true
# Group 4: neither source profile has a deletedItems delta function; contacts/template
# delta functions and deletedItems actions are different lineages and remain untouched.
  - where:
      verb: Invoke
      subject: (^Delta)(DirectoryDeletedItem)
    remove: true
# Rename cmdlets with duplicates in their name.
# Group 5: structural route naming already emits the single template noun for CRUD.
  - where:
      subject: ^(DirectorySettingTemplate|DirectoryRoleTemplate)(\1)+
    set:
      subject: $1
# Group 6: structural /contacts naming already emits Contact for the orgContact CRUD.
  - where:
      subject: (^Contact)(OrgContact$)
    set:
      subject: $1
# Group 7: exact /settings collection/item overrides emit DirectorySetting in beta.
# Count and nested resources are not selected; v1.0 has no /settings lineage.
  - where:
      subject: ^(Setting)(DirectorySetting)$
    set:
      subject: $2
# Alias DirectoryDeletedItems cmdlets.
# Groups 8 and 10 are a rename sequence around group 9: the final noun retains
# DirectoryDeletedItemAs<Type>, which structural cast naming already supplies.
  - where:
      subject: ^(DirectoryDeleted)ItemAs(.*)$
    set:
      subject: $1$2
# Group 9: cmdlet aliases remain deferred (the inventory classifies alias directives
# as DeferredParameter). Do not implement aliases, parameter transforms, or
# schema/response rewrites in this cmdlet-surface migration.
  - where:
      subject: ^DirectoryDeleted(application|administrativeUnit|appRoleAssignment|directoryObject|directoryRole|device|group|orgContact|servicePrincipal|user)$
    set:
      alias: ${verb}-Mg${subject-prefix}${subject}
  - where:
      subject: ^(DirectoryDeleted)(application|administrativeUnit|appRoleAssignment|directoryObject|directoryRole|device|group|orgContact|servicePrincipal|user)$
    set:
      subject: $1ItemAs$2
##Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0.
# Group 11: bridge the full original legacy selector set, not literal converted IDs.
# Four collection-addressed DELETE $ref routes survive in each profile and are
# suppressed; item-addressed DELETE $ref, GET, and POST neighbors remain available.
# The beta directory/featureRolloutPolicies lineage requires separate absence review;
# the pre-existing policies/featureRolloutPolicies lineage belongs to Identity.SignIns.
  - remove-path-by-operation: ^device_DeleteRegisteredOwnerGraphBPreRef$|^device_DeleteRegisteredUserGraphBPreRef$|^directory.administrativeUnit_DeleteMemberGraphBPreRef$|^directoryRole_DeleteMemberGraphBPreRef$|^directory.featureRolloutPolicy_ListAppliesToGraphBPreRef$
```
