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
# Wrapper migration 1: the adjacent Planner_directiveMigrationMap.json accounts
# for every original legacy regex match and its compatible successor (137 v1.0,
# 206 beta). Planner_cmdletConfigurations.cs suppresses those exact routes,
# including the unanchored group/user matches and qualified beta calls.
# Current v1.0 IDs support complete literal evidence; beta still needs the
# reviewed Legacy bridge for 24 actual action/function final-segment changes.
# Do not publish until the normally merged inventory helper validates beta.
  - remove-path-by-operation: ^user.planner_(Create|Update|Delete)All|planner.bucket_(Get|Create|Update|Delete)Task|planner.bucket.task.*|planner.plan_(Get|Create|Update|Delete)Bucket|planner.plan.bucket.*|planner.plan_(Get|Create|Update|Delete)Task|planner.plan.task.*$
# Remove cmdlets
# Wrapper migration 2: suppress singleton DELETE, preserving GET and PATCH.
  - where:
      verb: Remove
      subject: ^(User|Group)Planner$
    remove: true
# Wrapper migration 3: suppress navigation mutations, preserving collection GET.
  - where:
      verb: Remove|New|Update
      subject: ^(User|Group)Planner(Task|Plan)$
    remove: true
# Wrapper migration 4: suppress root details DELETE, not group plan details.
  - where:
      verb: Remove
      subject: ^Planner(Plan|Task)Detail$
    remove: true
    # Only list is supported.
# Wrapper migration 5: suppress user plan/task item GET, preserving List.
  - where:
      verb: Get
      variant: Get.*
      subject: ^UserPlanner(Task|Plan)$
    remove: true
# Wrapper migration 6: exact item GET already covered by directive 1; no duplicate.
  - where:
      verb: Get
      variant: Get.*
      subject: ^UserPlannerPlanTask$
    remove: true
# Wrapper migration 7: suppress descendant resource subjects and calls on those
# descendants, not calls on the Plan/Task parent subject (including delta).
  - where:
      subject: ^UserPlanner(Task[A-Z].*|Plan[A-Z].*)$
    remove: true
# Wrapper migration 8: these descendant routes already fall under directive 1.
# Keep all eight AutoRest directives active. PlannerDirectiveMigrationTests pins
# both profiles, the complete reviewed surface, and unaffected neighbors.
  - where:
      subject: ^GroupPlanner(PlanBucket[A-Z].*|PlanTask[A-Z].*)$
    remove: true
```
