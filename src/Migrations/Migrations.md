# Migrations

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Migrations v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
# Directives go here!

# Rename commands with 'SolutionMigrationCrossTenantMigrationJob<x>' to 'CrossTenantMigrationJob<x>'
directive:
# Wrapper migration: directive 1 is implemented by the job-scoped Migration prefix
# strip after the existing Solution strip. Exact beta route/old/new ID evidence is
# in wrapper/Migrations_directiveMigrationMap.json; MigrationsDirectiveTests pins it.
# Keep all shared AutoRest directives active until that pipeline is retired.
  - where:
      subject: (^SolutionMigrationCrossTenantMigrationJob)(.*)
    set:
      subject: CrossTenantMigrationJob$2
# Remove all the 'DisplayName','SolutionMigration', and 'Count' commands, they are redundant/unsupported
# Wrapper migration: directive 2 suppresses the three root operations, six
# alternate-displayName operations and both count GETs, not the job/user reads.
  - where:
      subject: (DisplayName$|SolutionMigration$|Count$)
    remove: true
# Remove extra 'Remove' commands, only jobs can be removed
# Wrapper migration: directive 3 suppresses only the user-item DELETE; job DELETE
# and the user cancel action remain supported.
  - where:
      verb: Remove
      subject: CrossTenantMigrationJob.+$
    remove: true
# Remove New/Update-CrossTenantMigrationJobUser, they are not supported operations
# Wrapper migration: directive 4 suppresses user collection POST and item PATCH.
# Scope: beta only; v1.0 is excluded, not an API-absence claim. All profile-local
# readmes and src/readme.graph.md are ignored. Parameter aliases/transforms and
# schema/response directives remain Deferred (none occur in this shared file).
  - where:
      verb: (New|Update)
      subject: CrossTenantMigrationJobUser$
    remove: true
```
