<!-- region Generated -->
# Microsoft.Graph.Planner
This directory contains the PowerShell module for the Planner service.

---
## Status
[![Microsoft.Graph.Planner](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Planner.svg?style=flat-square&label=Microsoft.Graph.Planner "Microsoft.Graph.Planner")](https://www.powershellgallery.com/packages/Microsoft.Graph.Planner/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Planner`, see [how-to.md](how-to.md).
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
# Remove paths that are not valid.
  - remove-path-by-operation: ^users.planner_(Create|Update|Delete)All|planner.buckets_(Get|Create|Update|Delete)Tasks|planner.buckets.tasks.*|planner.plans_(Get|Create|Update|Delete)Buckets|planner.plans.buckets.*|planner.plans_(Get|Create|Update|Delete)Tasks|planner.plans.tasks.*$
# Remove cmdlets
  - where:
      verb: Remove
      subject: ^(User|Group)Planner$
    remove: true
  - where:
      verb: Remove|New|Update
      subject: ^(User|Group)Planner(Task|Plan)$
    remove: true
  - where:
      verb: Remove
      subject: ^Planner(Plan|Task)Detail$
    remove: true
    # Only list is supported.
  - where:
      verb: Get
      variant: Get.*
      subject: ^UserPlanner(Task|Plan)$
    remove: true
  - where:
      verb: Get
      variant: Get.*
      subject: ^UserPlannerPlanTask$
    remove: true
  - where:
      subject: ^UserPlanner(Task[A-Z].*|Plan[A-Z].*)$
    remove: true
  - where:
      subject: ^GroupPlanner(PlanBucket[A-Z].*|PlanTask[A-Z].*)$
    remove: true
```
### Versioning

``` yaml
module-version: 1.9.7
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
