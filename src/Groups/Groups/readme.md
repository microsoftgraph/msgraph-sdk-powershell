<!-- region Generated -->
# Microsoft.Graph.Groups
This directory contains the PowerShell module for the Groups service.

---
## Status
[![Microsoft.Graph.Groups](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups.svg?style=flat-square&label=Microsoft.Graph.Groups "Microsoft.Graph.Groups")](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Groups`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: groups\.groupLifecyclePolicies_.*$|groups_(Get|Create|Update|Delete)GroupLifecyclePolicies$|groups\.team.*$|users\.joinedGroups.*$|groups\.sites\.onenote.*$|.*\.onenote\..*parent.*|.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|.*\.calendar\.events\..*$|.*\.events\..*$
# Remove cmdlets
  - where:
      verb: Test
      subject: ^GroupProperty$
      variant: Validate1|ValidateExpanded1|Validate3|ValidateExpanded3
    remove: true
  - where:
      verb: Get
      subject: (Group)AvailableExtensionProperty
    remove: true
# Rename cmdlets
  - where:
      verb: Get
      subject: ^(GroupLifecyclePolicy)$
      variant: ^List$|^List1$
    set:
      subject: $1ByGroup
  - where:
      subject: ^(GroupLifecyclePolicy)(\1)+
    set:
      subject: $1
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
# Alias then rename cmdlets to avoid breaking change.
  - where:
      subject: ^((Group)(CreatedOnBehalf))Of$
    set:
      alias: ${verb}-Mg$1
```
### Versioning

``` yaml
module-version: 1.12.4
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
