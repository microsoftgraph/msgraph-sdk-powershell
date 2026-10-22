# BackupRestore shared-directive migration audit

## Reviewed source and scope

At baseline `51d441eeb5`, `src\BackupRestore\BackupRestore.md` did not
exist. This file records that absence; it does not introduce an AutoRest
configuration or recreate directives from another source.

There are **zero shared cmdlet directives** to migrate and zero entries in
`wrapper\BackupRestore_cmdletConfigurations.cs`. The reviewed
`wrapper\BackupRestore_directiveMigrationMap.json` therefore contains an empty
`mappings` array, not invented selectors or operation mappings.

`src\readme.graph.md` and all profile-local readmes are explicitly outside this
audit. No configuration is copied from Bookings or inferred from those sources.
Parameter aliases/transforms and schema/response directive classes remain
**Deferred**; this audit does not implement them or claim to inventory excluded
files.

## Compatible specification evidence

Both required profiles have committed Kiota-compatible specifications. Neither
profile is excluded, and legacy `openApiDocs` is not a fallback.

| Profile | Compatible spec | Git blob | Paths | Operations | Existing output directory |
| --- | --- | --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat\v1.0\BackupRestore.yml` | `3748b0da077fe8f73e90bebc3f232411cacb49b2` | 150 | 247 | `wrapper\v1.0` |
| beta | `openApiDocs_KiotaCompat\beta\BackupRestore.yml` | `631fb0e595bbfa8efb43de570ab10adfe1d2954a` | 194 | 314 | `wrapper\Beta` |

These blobs match the coordinator's generation manifest and the reviewed
baseline. Preserve the committed `Beta` casing during subsequent generation.
Operation counts are specification coverage, not generated cmdlet/export counts.

## Existing behavior retained

The shared configurator deliberately preserves `Solution` in BackupRestore
structural nouns, such as `Get-MgSolutionBackupRestore` and
`Get-MgSolutionBackupRestoreProtectionPolicy`. Do not apply Bookings-style
`Solution` stripping to this module.

Existing oracle-derived behavior remains authoritative and is not reclassified
as a migrated shared directive. In v1.0 this includes ten action rename records.
For example, POST `/solutions/backupRestore/enable`
(`solutions.backupRestore.enable`) remains `Enable-MgSolutionBackupRestore`,
while the beta action keeps its existing structural name. Do not copy v1.0
parity entries to beta to manufacture matching behavior.

Known baseline limitation: the v1.0 parity data also records a suppression of GET
`/solutions/backupRestore/browseSessions/{browseSessionBase-id}/browse(nextFetchToken='{nextFetchToken}')`,
but its stored key retains `'{nextfetchtoken}'` while the configurator normalizes
that function argument to `'{}'`. The real route therefore is **not suppressed**
by the current lookup in either profile. This audit preserves actual baseline
behavior, reports the discrepancy, and does not invent a module directive or
duplicate override to repair shared derived data.

## Audit coverage and generation boundary

`tools\WrapperGenerator.Tests\BackupRestoreDirectiveMigrationTests.cs` reads both
real compatible specifications. It checks every method/path/operation-ID entry
for unchanged curated decisions with derived data disabled and unchanged
oracle-derived decisions with it enabled. Exact root, collection, item, nested,
action and function identities pin unaffected naming and suppression boundaries.
The strict reviewed inventory must return zero directive rows for this module.

This is a code-only audit, not end-to-end generation or compiled-module evidence.
Both full Release builds remain required before publication, followed by
separate v1.0 and beta commits each combining its newly generated Kiota client,
cmdlets, projects and lock files. A passing empty directive inventory alone does
not satisfy those gates.
