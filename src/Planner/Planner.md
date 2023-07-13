# Planner

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Planner v1.0 and/or beta modules.

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
# Remove paths that are not valid.
  - remove-path-by-operation: ^user.planner_(Create|Update|Delete)All|planner.bucket_(Get|Create|Update|Delete)Task|planner.bucket.task.*|planner.plan_(Get|Create|Update|Delete)Bucket|planner.plan.bucket.*|planner.plan_(Get|Create|Update|Delete)Task|planner.plan.task.*$
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
