# ConfigurationManagement

## Shared directive migration audit

At the reviewed `powershell-v3` baseline `51d441eeb5`, this module had no
`ConfigurationManagement.md` shared directive file. This file records that audit;
it introduces no AutoRest configuration or directives.

There are **zero shared cmdlet directives** to migrate. The existing
`wrapper/ConfigurationManagement_cmdletConfigurations.cs` is intentionally empty
and remains unchanged. The adjacent `ConfigurationManagement_directiveMigrationMap.json`
therefore has an empty `mappings` array, not invented directive-to-operation mappings.
Neither curated overrides nor the existing derived collision/parity data supplies
renames or suppressions for the reviewed operations; structural naming is retained.

### Compatible specification evidence

Both required profiles are available; no profile is excluded and no legacy
`openApiDocs` fallback is used.

| Profile | Compatible spec | Git blob |
| --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat/v1.0/ConfigurationManagement.yml` | `56b11ca6a8967733c3185101caf4bb91294856ef` |
| beta | `openApiDocs_KiotaCompat/beta/ConfigurationManagement.yml` | `8eaa133a303ae2e0e8133226938ec2dc74d27ec4` |

Each spec contains the same 18 method/path/operation-ID tuples: drift and monitoring
result list/item/count reads; monitor list/create/item read/update/delete/baseline/count;
snapshot-job list/item reads and item deletion; and snapshot list/item reads.
`ConfigurationManagementDirectiveMigrationTests` reads both real compatible specs,
pins that complete operation inventory, and checks unchanged names and absence of
suppression with derived collision data both enabled and disabled. These are
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
