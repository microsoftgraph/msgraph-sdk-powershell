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
  - remove-path-by-operation: .*\.onenote\..*parent.*|.*\.calendarView.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|.*\.calendar\.events\..*$|.*\.events\..*$
# Remove cmdlets
  - where:
      verb: Test
      subject: ^GroupProperty$
      variant: Validate1|ValidateExpanded1|Validate3|ValidateExpanded3
    remove: true
  - where:
      verb: Test
      subject: ^GroupDynamicMembership$
      variant: Evaluate1|EvaluateExpanded1
    remove: true
# Rename cmdlets
  - where:
      subject: ^(GroupLifecyclePolicy)(\1)+
    set:
      subject: $1
  - where:
      verb: Get
      subject: ^Group$
      variant: Get1|GetExpanded|Get3|GetExpanded1
    set:
      subject: GroupById
  - where:
      verb: Get
      subject: ^GroupMember$
      variant: ^Get$|^GetViaIdentity$|^List2$|^Get3$|^GetViaIdentity3$|^List5$
    set:
      subject: GroupMemberOf
  - where:
      verb: Get
      subject: ^GroupMember$
      variant: ^Get2$|^GetViaIdentity2$|^List1$|^Get5$|^GetViaIdentity5$|^List4$
    set:
      subject: GroupMemberWithLicenseError
  - where:
      verb: Get
      subject: ^GroupTransitiveMember$
      variant: ^Get$|^List$|^GetViaIdentity$|^Get2$|^List2$|^GetViaIdentity2$
    set:
      subject: GroupTransitiveMemberOf
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
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
