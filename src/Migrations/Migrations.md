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

# Rename commands with 'SolutionMigrationCrossTenantMigrationJob'  CrossTenantMigrationJob<>
directive:
  - where:
      subject: (^SolutionMigrationCrossTenantMigrationJob)(.*)
    set:
      subject: CrossTenantMigrationJob$2
# Remove all the 'DisplayName','SolutionMigration', and 'Count' commands, they are redundant/unsupported
  - where:
      subject: (DisplayName$|SolutionMigration$|Count$)
    remove: true
# Remove extra 'Remove' commands, only jobs can be removed
  - where:
      verb: Remove
      subject: CrossTenantMigrationJob.+$
    remove: true
# Remove New/Update-CrossTenantMigrationJobUser, they are not supported operations
  - where:
      verb: (New|Update)
      subject: CrossTenantMigrationJobUser$
    remove: true
```
