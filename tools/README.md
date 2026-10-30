# tools/

The supported v3 toolchain uses Kiota and WrapperGenerator. It does not require an
AutoRest submodule, Node.js, npm, or Rush.

**The Kiota wrapper generator** — the 13 `*-Wrapper*`, `Derive-*` and `Test-BodyBindingCoverage`
scripts documented below. They generate, build, package and verify the wrapper modules under
`src/<Module>/wrapper/<ApiVersion>/`.

**Authentication and shared helpers** — `GenerateAuthenticationModule.ps1` continues to use
`BuildModule.ps1`, `TestModule.ps1`, `PackModule.ps1`, and `PublishModule.ps1`.
Authentication targets in `build.proj` remain available; v3 service modules use
`Build-WrapperModule.ps1` instead.

The legacy AutoRest generation scripts and their CI, SDK release, weekly-generation, and
command-metadata-refresh pipeline entry points have been retired from this branch. Use
`.azure-pipelines/wrapper-release.yml` for the v3 wrapper release flow. Azure DevOps definitions
that reference the removed pipeline YAML files must be retired separately by their owners.

Module directive markdown and `src/readme.graph.md` are retained as historical migration
inputs, not as an executable v3 AutoRest generation path. Keep them available while directives
are migrated to the wrapper cmdlet configuration framework.

The generator itself is documented in
[WrapperGenerator/README.md](WrapperGenerator/README.md) — what it emits and why. This file is
about the scripts around it: what depends on what, and which one to reach for.

## Start here

```powershell
.\tools\Build-WrapperModule.ps1 -Module Mail          # generate + build one module
.\tools\Invoke-WrapperGates.ps1                       # run every gate, with a population each
```

Everything else is a narrower tool for one of the scenarios below.

## The scripts

| Script | Does | Reads | Writes |
|---|---|---|---|
| `Build-WrapperModule.ps1` | kiota client + generated cmdlets + compiled dll + manifest, per module | OpenAPI spec, `config/ModulesMapping.jsonc` | `src/<Module>/wrapper/<ApiVersion>/`, `artifacts/` with `-Pack` |
| `Invoke-WrapperGates.ps1` | runs all 8 gates in order, reporting a population per gate | the corpus | console report; exit 1 fail, 2 incomplete |
| `Compare-WrapperCmdletNames.ps1` | naming-parity gate — every generated name against the published inventory | generated `*.g.cs` + the compiled dll + `MgCommandMetadata.json` | `-OutLedger` CSV of per-file dispositions |
| `Compare-WrapperOperationInventory.ps1` | did a change alter *which* operations become cmdlets | the corpus, a baseline CSV | baseline CSV, or a diff |
| `Test-BodyBindingCoverage.ps1` | every settable kiota body member is bound or cited by a named policy | spec + generated cmdlets | console report |
| `Test-WrapperModule.ps1` | smoke test — imports the **package** and exercises a dispatcher | `artifacts/<Module>/*.nupkg` | console report |
| `Test-WrapperPaging.ps1` | pagination against a stub transport, no tenant data | compiled module | console report |
| `Test-WrapperDelta.ps1` | delta pagination against a stub transport | compiled module | console report |
| `Test-WrapperLive.ps1` | the one gate that calls real Graph; read-only, needs `User.Read` | compiled module + a session | console report |
| `Derive-CollisionResolutions.ps1` | derives collision suppressions/renames from the oracle | `data/collision-inventory.<ver>.txt`, `MgCommandMetadata.json` | `data/collision-*.json`, ledger CSV |
| `Derive-ParityResolutions.ps1` | derives parity renames/suppressions for the whole surface | frozen input ledger, or `-CaptureInput` to build one | `data/parity-*.json`, ledger CSVs |
| `Update-WrapperParityData.ps1` | orchestrates a clean parity refresh in an isolated copy | — | the four `data/parity-*` files |
| `New-WrapperOutputManifest.ps1` | reviewable inventory of the committed output | the corpus | `docs/WrapperCmdlets-*.csv` |
| `Get-WrapperDirectiveMigrationInventory.ps1` | classifies AutoRest directives and maps reviewed v1.0/beta operations | module `.md` files, OpenAPI specs, reviewed mapping ledger | pipeline objects; optional JSON/CSV |
| `Test-WrapperDirectiveMigrationInventory.ps1` | validates the inventory tool, Compliance pilot mapping and read-only behavior | inventory tool + mapping ledger | console pass/fail |
| [`Remove-ExpiredDeprecatedOpenApiOperations.ps1`](Remove-ExpiredDeprecatedOpenApiOperations.md) | prunes expired deprecated operations from one Kiota OpenAPI document or a profile directory | `openApiDocs_KiotaCompat` YAML | updated YAML and `deprecated-removals.json` |

## What depends on what

```
config/ModulesMapping.jsonc ─┐
OpenAPI (openApiDocs_KiotaCompat) ─┴─► Build-WrapperModule.ps1 ─► src/<Module>/wrapper/<ver>/
                                                │                        │
                          -NoCollisionData ─────┤                        ├─► Compare-WrapperCmdletNames.ps1 ──► ledger CSV
                          prints the collision  │                        │                                          │
                          report, which IS      │                        └─► Test-BodyBindingCoverage.ps1           │
                          data/collision-       │                        └─► New-WrapperOutputManifest.ps1          │
                          inventory.<ver>.txt   │                        └─► Compare-WrapperOperationInventory.ps1  │
                                                │                                                                   │
                                    -Pack ──► artifacts/<Module>/*.nupkg ──► Test-WrapperModule.ps1                  │
                                                                                                                    │
data/collision-inventory.<ver>.txt ──► Derive-CollisionResolutions.ps1 ──► data/collision-*.json ──┐                 │
MgCommandMetadata.json (the oracle) ──┘                                                            │                 │
                                                                                                   ├──► embedded into the generator
Update-WrapperParityData.ps1 ──► Derive-ParityResolutions.ps1 ◄─────────────────────────────────── ┘                 │
        (isolated copy, -NoCollisionData)          └── -CaptureInput invokes Compare-WrapperCmdletNames ◄─────────────┘
```

Two dependencies are easy to miss:

**The collision inventory is script output, not a hand-written file.** `Build-WrapperModule.ps1
-NoCollisionData` makes the generator *report* each collision instead of throwing, and that
report is what `data/collision-inventory.<ApiVersion>.txt` is captured from. `Derive-CollisionResolutions.ps1`
then reads that file. Run without the switch and there is nothing to capture.

**The parity derivation does not re-implement the oracle join.** `Derive-ParityResolutions.ps1
-CaptureInput` calls `Compare-WrapperCmdletNames.ps1` per module and derives from its ledger, so
the gate and the derivation cannot drift apart. Without `-CaptureInput` it requires the frozen
`data/parity-input-ledger.<ApiVersion>.csv` and fails if it is missing.

## Scenarios

### I need to refresh the Kiota-compatible OpenAPI documents

```powershell
.\tools\UpdateOpenApiKiotaCompat.ps1
.\tools\UpdateOpenApiKiotaCompat.ps1 -BetaGraphVersion
```

The refresh keeps `fileName=openapi` and `style=Plain` as the source of the documents.
Discriminators, `anyOf`/`oneOf`, navigation properties and response codes remain available
for Kiota client generation. [Expired deprecated operations](Remove-ExpiredDeprecatedOpenApiOperations.md)
are pruned, including on standalone `DownloadOpenApiDocKiotaCompat.ps1` calls.
Retired root-level Bookings beta cmdlets are instead suppressed by
`src/Bookings/wrapper/Bookings_cmdletConfigurations.cs`; their OpenAPI and Kiota HTTP
client routes remain present when not annotated as expired.

Operation IDs follow the existing PowerShell OpenAPI naming so operation-ID-based directives
are easier to migrate. DevX ignores `singularizeOperationIds` for `style=Plain`, so the downloader
requests a second view of the same Kiota source with `style=Powershell`,
`singularizeOperationIds=true` and `format=json`. Only its operation IDs are copied, matched by
path and HTTP method; none of its schemas, parameters or responses are used. Missing or
ambiguous operation-ID mappings fail the refresh rather than silently leaving mixed naming.

`TweakOpenApi.ps1 -OperationIdsOnly` then applies the existing preposition and word corrections.
This mode does not rewrite success response codes or mark navigation properties read-only.
For example, `auditLogs.auditLogRoot.UpdateAuditLogRoot` becomes
`auditLog.auditLogRoot_UpdateAuditLogRoot`. The existing `openApiDocs` refresh is unchanged.
These changes take effect on the next refresh; they do not regenerate the committed corpus
or rewrite existing wrapper directive migration ledgers.

### I changed the generator and want to see what it did to the output

```powershell
.\tools\Build-WrapperModule.ps1 -Module Mail -Configuration Release
git diff src/Mail/wrapper/v1.0/
```

Regeneration rewrites the committed folder in place, so the diff *is* the effect of your change.
For the whole surface, omit `-Module`. Add `-GenerateOnly` to skip compilation while iterating,
and `-SkipKiota` to reuse the client already on disk — kiota is only needed when the spec changes.

### I want to try a module

```powershell
.\tools\Build-WrapperModule.ps1 -Module Mail -Configuration Release
Import-Module .\src\Mail\wrapper\v1.0\bin\Release\netstandard2.0\Microsoft.Graph.Wrapper.Mail.psd1
```

### I want a package a tester can install

```powershell
.\tools\Build-WrapperModule.ps1 -ApiVersion v1.0 -Pack
.\tools\Test-WrapperModule.ps1 -Module Mail
```

`Test-WrapperModule.ps1` reads the **package**, not `bin/` — importing build output proves the
compiler ran, not that the artifact a user installs carries its dependencies and a manifest that
agrees with them. So pack before you smoke-test.

### The naming-parity gate failed

```powershell
.\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath src\Mail\wrapper\v1.0\Cmdlets -OutLedger ledger.csv
```

The ledger gives one row per cmdlet with its disposition — `matched`, `mismatch`, `corrected`,
`no-oracle`, `ambiguous`, `dispatcher`, `no-route`. Filter to `mismatch` to see what actually
diverged before deciding whether it is a generator defect or a deliberate correction.

### I need to refresh the derived data

```powershell
.\tools\Update-WrapperParityData.ps1                       # parity: full clean refresh
.\tools\Derive-CollisionResolutions.ps1 -Validate          # collisions: check for drift first
```

Both derivations have a `-Validate` mode that re-derives and fails if the checked-in files no
longer match. That is the safe thing to run in CI or before a PR; run without `-Validate` only
when you intend to update the data.

### I'm about to open a PR

```powershell
.\tools\Invoke-WrapperGates.ps1
```

Eight gates, in this order — each reports the population it examined, because a gate that
examined nothing cannot pass:

1. `generator-build` — the generator compiles
2. `unit-tests` — classification and emission rules
3. `module-compile` — emitted CLR types match the generated kiota members
4. `naming-parity` — names match the published SDK inventory
5. `omission-oracle` — every settable body member is bound or cited
6. `coverage-sweep` — what the classifier itself reports as unbound
7. `runtime-binding` — PowerShell converts each bound shape at runtime
8. `operation-inventory` — the change did not alter which operations generate

A gate that could not run reports NOT-RUN rather than PASS, and the overall verdict is then
INCOMPLETE (exit 2), which is distinct from a failure (exit 1).

`operation-inventory` needs `-InventoryBaseline` pointing at a CSV captured from a *previous*
generator; without one it reports NOT-RUN, because comparing a tree against itself proves nothing.

### I want to check it against real Graph

```powershell
.\tools\Test-WrapperLive.ps1 -Configuration Release
```

Read-only — every call is a GET of the signed-in user's own object. Consent floor is `User.Read`,
and it needs pwsh 7. It is the only gate that touches a tenant, and it exists because
offline gates are structurally blind to runtime assembly-resolution defects.

For pagination and delta there are deterministic equivalents that need no tenant data beyond one
`/me` call: `Test-WrapperPaging.ps1` and `Test-WrapperDelta.ps1`, both driving the real compiled
cmdlets through a stub transport.
