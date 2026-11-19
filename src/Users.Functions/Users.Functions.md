# Users.Functions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users.Functions v1.0 and/or beta modules.

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
# Remove invalid paths.
  - remove-path-by-operation: .*exceptionOccurrence.*|user\.joinedGroup.*|user\.joinedTeam.*|user\.onenote\..*.parent.*|user.*\.calendarView.*|.*\.notebook\.section.*|.*\.sectionGroup.section.*|.*\.section\.page.*|user\.calendar\.event\..*|user\.calendarGroup\.calendar|user\.calendar\.event\..*|user\.event\.calendar\..*|user\.pendingAccessReviewInstance\.stage\.decision.*|user\.pendingAccessReviewInstance(\.decision|\.stage\.decision)\.instance.*
# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(UserOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
```
