# BackupRestore shared-directive migration audit

## Reviewed source and scope

At baseline `51d441eeb5`, `src\BackupRestore\BackupRestore.md` did not
exist. This file records that absence; it introduces no directive migration and
does not recreate directives from another source. The standard template
`require` below preserves legacy AutoRest wiring: `Copy-ModuleTemplate` only
creates a configuration when this file is absent.

There are **zero shared cmdlet directives** to migrate and zero entries in
`wrapper\BackupRestore_cmdletConfigurations.cs`. The reviewed
`wrapper\BackupRestore_directiveMigrationMap.json` therefore contains an empty
`mappings` array, not invented selectors or operation mappings.

`src\readme.graph.md` and all profile-local readmes are explicitly outside this
audit. No configuration is copied from Bookings or inferred from those sources.
Parameter aliases/transforms and schema/response directive classes remain
**Deferred**; this audit does not implement them or claim to inventory excluded
files.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

This is the existing `tools\Templates\module.md` wiring, not a migration of global
directives. Global directives remain unchanged and ignored by this audit. No
module directive block or overrides are introduced.

## Compatible specification evidence

Both required profiles have committed Kiota-compatible specifications. Neither
profile is excluded, and legacy `openApiDocs` is not a fallback.

| Profile | Compatible spec | Git blob | Paths | Operations | Existing output directory |
| --- | --- | --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat\v1.0\BackupRestore.yml` | `ee37fc867b82b35bb31d0c94a8c251d03059d383` | 150 | 247 | `wrapper\v1.0` |
| beta | `openApiDocs_KiotaCompat\beta\BackupRestore.yml` | `4b2f3dcc294720dfae40768403fcbccfeb69c1b3` | 197 | 320 | `wrapper\Beta` |

These blobs remain unchanged after normally merging `powershell-v3` at
`6475f3f5beb4908d39ea356db32bf1e0fd3273cb` (including #3886). They were also
unchanged at `844672d7c2238f6b29a208f9ba73fe28e9e29cef` (including #3891) and first
reviewed at `08e409a6aa8fd48736b8f9a9199559f46fc0d1ad` (including #3849). The earlier
reviewed blobs were `3748b0da077fe8f73e90bebc3f232411cacb49b2` and
`631fb0e595bbfa8efb43de570ab10adfe1d2954a`, respectively. Compatible operation
IDs now use the aligned legacy identities; the tests pin those exact current
IDs. Preserve the committed `Beta` casing during subsequent generation.
The refreshed beta spec adds three paths and six operations over the earlier
194-path / 314-operation audit; v1.0 remains at 150 paths / 247 operations.
Operation counts are specification coverage, not generated cmdlet/export counts.

## Existing behavior retained

The shared configurator deliberately preserves `Solution` in BackupRestore
structural nouns, such as `Get-MgSolutionBackupRestore` and
`Get-MgSolutionBackupRestoreProtectionPolicy`. Do not apply Bookings-style
`Solution` stripping to this module.

Existing oracle-derived behavior remains authoritative and is not reclassified
as a migrated shared directive. In v1.0 this includes ten action rename records.
For example, POST `/solutions/backupRestore/enable`
(`solution.backupRestore_enable`) remains `Enable-MgSolutionBackupRestore`,
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
The generation profile is passed separately to naming and configurator calls,
not stored in `GeneratorConfig`; derived data is checked both on and off for
each profile, including the v1.0-only action rename.
Real-spec generation also checks that every emitted transport call receives
its separate `v1.0` or `beta` context. This is not an authored profile filter.
Every emitted PATCH is checked to issue only its mutation and never read back.
Both real specifications have zero required query inputs; optional native
OData inputs remain unchanged and GET-only inputs are not added to PATCH.
The strict reviewed inventory must return zero directive rows for this module.

Source tests alone are not end-to-end generation or compiled-module evidence.
Both full Release builds remain required before publication, followed by
separate v1.0 and beta commits each combining its newly generated Kiota client,
cmdlets, projects and lock files. A passing empty directive inventory alone does
not satisfy those gates.

After #3891, acceptance uses the normally packaged adapted Authentication 2.41.2
from the integrated shipping source. Authentication owns the complete Kiota
closure; wrapper manifests require it without dependency preloads, and wrapper
bins contain only their three owned DLLs. Fresh offline requests must use the
normal authenticated factory pipeline and verify the emitted profile's service
root without changing the shared client's BaseAddress. Earlier Authentication
2.38.1 build/import logs remain historical evidence, not current acceptance.

After the normally merged #3886 change, PATCH 204 succeeds without output after
exactly one PATCH request and no automatic GET. A PATCH 200 model response is
returned as its actual typed model, also without another request. Retrieval is
a separate caller-explicit GET with independent headers, queries and errors;
no PassThru, ReadBack or Refetch switch is introduced. Earlier refetch/header-loss
reports remain historical, user-superseded evidence, not current failures.
Fresh offline proof must configure GET to fail while verifying successful
PATCH 204 and PATCH 200, and separately exercise caller-explicit retrieval.
