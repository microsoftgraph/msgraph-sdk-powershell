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
  - remove-path-by-operation: groups\.groupLifecyclePolicies_.*$|groups_(Get|Create|Update|Delete)GroupLifecyclePolicies$|groups\.team.*$|users\.joinedGroups.*$|groups\.sites\.onenote.*$|.*\.onenote\..*parent.*|.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|.*\.calendar\.events\..*$|.*\.events\..*$
# Remove duplicates.
  - where:
      subject: ^(GroupLifecyclePolicy)(\1)+
    set:
      subject: $1
  - where:
      verb: Test
      subject: ^GroupProperty$
      variant: Validate1|ValidateExpanded1
    remove: true
  - where:
      verb: Test
      subject: ^(GroupDynamicMembership)$
      variant: Evaluate1|EvaluateExpanded1
    set:
      subject: $1Rule
  - where:
      verb: Remove
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1From$2
  - where:
      verb: Add
      subject: ^(Group)(LifecyclePolicy)Group$
    set:
      subject: $1To$2
  - where:
      verb: Invoke
      subject: ^(RenewGroup)(LifecyclePolicy)Group$
    set:
      subject: $1$2
  - where:
      verb: Get
      subject: ^(GroupOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
  - where:
      verb: Update
      subject: ^(GroupOnenotePage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteSectionGroupSectionPage)$
    set:
      subject: $1Content
  - where:
      verb: Update
      subject: ^(GroupOnenoteNotebookSectionGroupSectionPage)$
    set:
      subject: $1Content
```
