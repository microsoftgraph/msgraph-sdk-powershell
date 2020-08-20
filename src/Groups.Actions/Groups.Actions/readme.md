<!-- region Generated -->
# Microsoft.Graph.Groups.Actions
This directory contains the PowerShell module for the GroupsActions service.

---
## Status
[![Microsoft.Graph.Groups.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups.Actions.svg?style=flat-square&label=Microsoft.Graph.Groups.Actions "Microsoft.Graph.Groups.Actions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups.Actions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Groups.Actions`, see [how-to.md](how-to.md).
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
# Remove paths that have /parent* or /calendarView*.
  - remove-path-by-operation: groups.onenote..*.parent.*|groups.*.calendarView.*|.*.notebooks.section.*|.*.sectionGroups.section.*|.*.sections.pages.*
  # Needs validation
# # Remove cmdlets.
#   - where:
#       verb: Test
#       subject: ^GroupProperty$
#       variant: ^Validate1$|^ValidateExpanded1$|^Validate3$|^ValidateExpanded3$
#     remove: true
#   - where:
#       verb: Test
#       subject: ^GroupDynamicMembership$
#       variant: ^Evaluate1$|^EvaluateExpanded1$
#     remove: true
#   - where:
#       verb: Get
#       subject: ^Group$
#     set:
#       subject: GroupById
#   - where:
#       verb: Update
#       subject: ^(GroupOnenotePage)$
#     set:
#       subject: $1Content
#   - where:
#       verb: Update
#       subject: ^(GroupOnenoteSectionPage)$
#     set:
#       subject: $1Content
#   - where:
#       verb: Update
#       subject: ^(GroupOnenoteNotebookSectionPage)$
#     set:
#       subject: $1Content
#   - where:
#       verb: Update
#       subject: ^(GroupOnenoteSectionGroupSectionPage)$
#     set:
#       subject: $1Content
#   - where:
#       verb: Update
#       subject: ^(GroupOnenoteNotebookSectionGroupSectionPage)$
#     set:
#       subject: $1Content
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
