# ConfigurationManagement

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

## Shared directive migration audit

At the reviewed `powershell-v3` baseline `51d441eeb5`, this module had no
`ConfigurationManagement.md` shared directive file. This file records that audit
and introduces no new directives. The standard template `require` above preserves
original legacy global configuration wiring: `Copy-ModuleTemplate` created the
module file only when absent, so this audit file retains that wiring itself. The required
global directives remain unchanged and outside this migration's scope.

There are **zero shared cmdlet directives** to migrate. The existing
`wrapper/ConfigurationManagement_cmdletConfigurations.cs` is intentionally empty
and remains unchanged. The adjacent `ConfigurationManagement_directiveMigrationMap.json`
therefore has an empty `mappings` array, not invented directive-to-operation mappings.
Neither curated overrides nor the existing derived collision/parity data supplies
renames or suppressions for the reviewed operations; structural naming is retained.

### Compatible specification evidence

Both required profiles are available; no profile is excluded and no legacy
`openApiDocs` fallback is used. The evidence below is refreshed against merged
`powershell-v3` target `08e409a6aa8fd48736b8f9a9199559f46fc0d1ad`.

| Profile | Compatible spec | Git blob |
| --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/ConfigurationManagement.yml` | `dd8ef9256120c1a463b2394238b81cfcc07ec5c0` |
| beta | `openApiDocs_KiotaCompat/beta/ConfigurationManagement.yml` | `0893ccbc044acbfc320945f06b26c378e7554c7b` |

Each spec contains the same 18 method/path/operation-ID tuples: drift and monitoring
result list/item/count reads; monitor list/create/item read/update/delete/baseline/count;
snapshot-job list/item reads and item deletion; and snapshot list/item reads.
`ConfigurationManagementDirectiveMigrationTests` reads both real compatible specs,
pins that complete operation inventory using the current PowerShell-aligned IDs,
and checks unchanged names and absence of suppression with derived collision data
both enabled and disabled. Each naming and configuration lookup receives its
profile explicitly as separate oracle context, not as an authored configuration
filter or a `GeneratorConfig` property. These are
unaffected-operation assertions, not claims of migrated suppressions or renames.

### Scope and deferred classes

All profile-local directive files, including `v1.0/readme.md` and `beta/readme.md`,
and `src/readme.graph.md` are explicitly ignored, not migrated, annotated, or edited.
Parameter aliases/transforms and schema/response directives remain **Deferred**
and are not implemented by this cmdlet-only audit. None exists in the audited
shared source; this does not assert their absence from the ignored sources.

The strict reviewed inventory command is:

``` powershell
.\tools\Get-WrapperDirectiveMigrationInventory.ps1 -Module ConfigurationManagement -FailOnUnresolved
```

It must return zero shared directive rows, with no stale mappings. This audit
does not establish generation, Release-build, compiled-export, or SDK parity
completion; those are separate profile gates. Existing beta generated output
uses `wrapper/Beta` casing and must retain it.
