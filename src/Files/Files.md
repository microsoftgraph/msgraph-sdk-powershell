# Files

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Files v1.0 and/or beta modules.

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
# Wrapper migration: exact surviving legacy operation-ID selections are suppressed
# in wrapper/Files_cmdletConfigurations.cs; Files_directiveMigrationMap.json
# accounts for all 56 v1.0 and 272 beta legacy matches, including pruned routes.
# Current aligned operation IDs select exactly the complete original survivor sets;
# the tests reprove lineage and the current strict inventory validates literal IDs.
# Collection ListActivity GETs are not selected. FilesDirectiveMigrationTests pins
# both profiles and neighboring routes. Keep this AutoRest directive active.
  - remove-path-by-operation: .*_(Create|Get|Update|Set|Delete)Activity$|.*\.activity.*$|share\..*_createLink
# Wrapper migration: existing GET-only GroupDefaultDrive/UserDefaultDrive overrides
# already implement this rename; the adjacent ledger records exact spec evidence.
# Keep this AutoRest directive active. Profile-local/global readmes are ignored;
# parameter/schema migration remains deferred (none occur in this shared file).
# Separately, ambiguous shared-list GETs retain distinct descriptive nouns: the
# underlying listItem keeps ShareListItem and items contained in the list use
# ShareListContainedItem. Existing v1.0 derived suppression remains unchanged.
  - where:
      verb: Get
      subject: ^(Group|User)(Drive)$
      variant: ^Get$|^GetViaIdentity$
    set:
      subject: $1Default$2
```
