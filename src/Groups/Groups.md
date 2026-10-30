# Groups

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Groups v1.0 and/or beta modules.

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
# Wrapper migration: all 17 shared groups are reviewed in wrapper/Groups_directiveMigrationMap.json;
# GroupsDirectiveMigrationTests pins compatible v1.0/beta operations and neighboring behavior.
# Keep every AutoRest directive active until the service-module pipeline is retired.
# There are no deferred parameter/schema groups here. Profile-local readmes and readme.graph.md
# are outside this audit; existing unrelated curated/derived behavior is retained.
# Group 1: aligned compatible IDs now match the complete original 7 v1.0 / 10 beta
# source selections literally; the ledger/tests retain exact legacy and qualified-path proof.
# Four collection-reference DELETEs and beta joinedGroups calls
# use exact suppressions; existing nested lifecycle suppression covers add/remove/count/renew.
# No legacy-only inventory support or removed-operation claims are needed.
#Prevent cmdlets with the below operation Ids from being generated to allow for aliasing as a result of breaking changes in 2.18.0 and 2.17.0. The affected operation Ids starts from  group_DeleteAcceptedSenderGraphBPreRef
  - remove-path-by-operation: group\.groupLifecyclePolicy_.*$|group_(Get|Create|Update|Delete)GroupLifecyclePolicies$|group\.team.*$|user\.joinedGroup.*$|group\.site\.onenote.*$|.*\.onenote\..*parent.*|.*\.calendarView.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|.*\.calendar\.event\..*$|.*\.event\..*$|^group_DeleteAcceptedSenderGraphBPreRef$|^group_DeleteMemberGraphBPreRef$|^group_DeleteOwnerGraphBPreRef$|^group_DeleteOwnerGraphBPreRef$|^group_DeleteRejectedSenderGraphBPreRef$
# Group 2: existing curated GET /groups/{id}/groupLifecyclePolicies rename supplies ByGroup.
  - where:
      verb: Get
      subject: ^(GroupLifecyclePolicy)$
      variant: ^List$
    set:
      subject: $1ByGroup
# Group 3: structural naming already supplies GroupLifecyclePolicy for top-level CRUD.
  - where:
      subject: ^(GroupLifecyclePolicy)(\1)+
    set:
      subject: $1
# Group 4: curated POST /groups/validateProperties suppression removes only unbound Validate1.
  - where:
      verb: Test
      subject: ^GroupProperty$
      variant: Validate1|ValidateExpanded1
    remove: true
# Group 5: beta unbound POST /groups/evaluateDynamicMembership becomes
# Test-GroupDynamicMembershipRule; bound evaluation stays distinct. Absent in v1.0.
  - where:
      verb: Test
      subject: ^(GroupDynamicMembership)$
      variant: Evaluate1|EvaluateExpanded1
    set:
      subject: $1Rule
# Group 6: curated noun/verb overrides preserve Remove-GroupFromLifecyclePolicy in both profiles;
# existing v1.0 derived parity agrees.
  - where:
      verb: Remove
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1From$2
# Group 7: curated noun/verb overrides preserve Add-GroupToLifecyclePolicy in both profiles;
# existing v1.0 derived parity agrees.
  - where:
      verb: Add
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1To$2
# Group 8: existing nested lifecycle prefix suppression covers beta Renew1 at
# /groups/{id}/groupLifecyclePolicies/renewGroup. This action is absent in v1.0.
  - where:
      verb: Invoke
      subject: ^(RenewGroup)(LifecyclePolicy)Group$
      variant: ^Renew1$|^RenewExpanded1$|^RenewViaIdentity$|^RenewViaIdentityExpanded$
    remove: true
# Group 9: curated rename retains beta POST /groupLifecyclePolicies/renewGroup as
# Invoke-RenewGroupLifecyclePolicy. Absent in v1.0; do not rename /groups/{id}/renew.
  - where:
      verb: Invoke
      subject: ^(RenewGroup)(LifecyclePolicy)Group$
    set:
      subject: $1$2
# Group 10: recent-notebook function absent from both compatible Groups specs;
# retain this AutoRest rename without inventing wrapper routes.
  - where:
      verb: Get
      subject: ^(GroupOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
# Group 11: OneNote page-content action absent from both compatible Groups specs.
  - where:
      verb: Update
      subject: ^(GroupOnenotePage)$
    set:
      subject: $1Content
# Group 12: OneNote section page-content action absent from both compatible Groups specs.
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionPage)$
    set:
      subject: $1Content
# Group 13: OneNote notebook section page-content action absent from both compatible Groups specs.
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionPage)$
    set:
      subject: $1Content
# Group 14: OneNote section-group section page-content action absent from both compatible Groups specs.
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionGroupSectionPage)$
    set:
      subject: $1Content
# Group 15: OneNote notebook section-group page-content action absent from both compatible Groups specs.
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionGroupSectionPage)$
    set:
      subject: $1Content
# Group 16: direct sites collection/item GETs absent from both compatible Groups specs.
# Nested site getByPath operations remain in the specs and must not be renamed to AllGroupSite.
# Their intermediate parameterized functions are a separate baseline emitter limitation.
  - where:
      verb: Get
      subject: ^(GroupSite)$
    set:
      subject: All$1
# Group 17: curated PATCH /groups/{id}/photo suppression covers both profiles;
# existing v1.0 derived parity agrees. GET photo and PUT photo/$value remain untouched.
# PUT content is unsuppressed but has a preexisting unsupported-response emission limitation.
  - where:
      verb: Update
      subject: ^GroupPhoto$
    remove: true
```
