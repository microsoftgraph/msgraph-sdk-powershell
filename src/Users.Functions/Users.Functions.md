# Users.Functions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users.Functions v1.0 and/or beta modules.

The wrapper migration audits only the shared directives below, for both v1.0 and beta
(no excluded profiles). Profile-local readmes and `src/readme.graph.md` directives are
ignored. Parameter/schema aliases and transforms remain deferred; none occur here.

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
# Wrapper migration: reviewed the ORIGINAL regex against all actual legacy operations
# (7 v1.0, 16 beta): zero matches in both profiles, also zero compatible matches.
# This is selector absence, NOT API absence: every function survives with an aligned ID
# and a metadata-kind-guarded final namespace bridge in the adjacent wrapper ledger's
# scopeAudit. No suppression is added. UsersFunctionsDirectiveMigrationTests pins the
# complete inventories and unaffected functions. Keep this AutoRest directive active.
  - remove-path-by-operation: .*exceptionOccurrence.*|user\.joinedGroup.*|user\.joinedTeam.*|user\.onenote\..*.parent.*|user.*\.calendarView.*|.*\.notebook\.section.*|.*\.sectionGroup.section.*|.*\.section\.page.*|user\.calendar\.event\..*|user\.calendarGroup\.calendar|user\.calendar\.event\..*|user\.event\.calendar\..*|user\.pendingAccessReviewInstance\.stage\.decision.*|user\.pendingAccessReviewInstance(\.decision|\.stage\.decision)\.instance.*
# Rename cmdlets.
# Wrapper migration: neither actual legacy nor compatible Users.Functions profile has
# an onenote route; this selector has no module-local target. The adjacent
# Users.Functions_directiveMigrationMap.json records the reviewed no-match disposition.
# Do not add a global override for another module. Keep this AutoRest directive active.
  - where:
      verb: Get
      subject: ^(UserOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
```
