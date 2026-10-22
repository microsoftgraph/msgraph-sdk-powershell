# BusinessScenario

## Shared-directive migration audit

The shared `src\BusinessScenario\BusinessScenario.md` file did not exist at the
reviewed base `51d441eeb5f1afb57299a74564963f564baec930`. This document records that
absence; it does not introduce an AutoRest configuration or generation pipeline.
There are **zero shared cmdlet directives** to migrate. The existing
`wrapper\BusinessScenario_cmdletConfigurations.cs` collection remains empty, and
`wrapper\BusinessScenario_directiveMigrationMap.json` deliberately contains an
empty `mappings` array. No directive indexes, operation mappings, suppressions, or
renames are invented for this audit.

### Compatible profile evidence

| Profile | Disposition | Evidence |
| --- | --- | --- |
| beta | Required | `openApiDocs_KiotaCompat\beta\BusinessScenario.yml`, Git blob `a983393bd3c39351c41be51b8a9c6cfe37f689c4`; 23 paths, 51 operations (20 GET, 7 POST, 12 PATCH, 12 DELETE). |
| v1.0 | Excluded | `openApiDocs_KiotaCompat\v1.0\BusinessScenario.yml` is absent. This is a missing-compatible-spec exclusion, not an assertion that service operations are absent. No legacy specification fallback is used. |

The existing committed beta output directory is `wrapper\Beta`; regeneration
must retain that casing. The audit itself does not claim generation or build
success.

### Existing behavior and unaffected routes

No BusinessScenario-specific curated entries or matching oracle-derived
collision/parity entries exist at the reviewed base. Existing shared
`Bookings_cmdletConfigurations.cs` coverage strips the `Solution` noun prefix
under `/solutions/`; it is retained, not copied into a redundant module override.
The following are representative exact beta specification identities, **not
directive migration mappings**:

| Method | Path | Operation ID |
| --- | --- | --- |
| GET | `/solutions/businessScenarios` | `solutions.ListBusinessScenarios` |
| POST | `/solutions/businessScenarios` | `solutions.CreateBusinessScenarios` |
| GET | `/solutions/businessScenarios/{businessScenario-id}` | `solutions.GetBusinessScenarios` |
| PATCH | `/solutions/businessScenarios/{businessScenario-id}` | `solutions.UpdateBusinessScenarios` |
| DELETE | `/solutions/businessScenarios/{businessScenario-id}` | `solutions.DeleteBusinessScenarios` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner` | `solutions.businessScenarios.GetPlanner` |
| POST | `/solutions/businessScenarios/{businessScenario-id}/planner/getPlan` | `solutions.businessScenarios.businessScenario.planner.getPlan` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner/tasks` | `solutions.businessScenarios.planner.ListTasks` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}` | `solutions.businessScenarios.planner.GetTasks` |
| GET | `/solutions/businessScenarios/$count` | `solutions.businessScenarios.GetCount-69a1` |

`tools\WrapperGenerator.Tests\BusinessScenarioDirectiveMigrationTests.cs` loads
the real compatible beta document, checks these operation identities and current
names with derived data enabled and disabled, and checks that every beta
operation remains unsuppressed. These names describe existing wrapper behavior,
not newly implemented parity with profile-local AutoRest directives.

### Scope and deferred classes

All profile-local readmes, including `beta\readme.md` and any
`v1.0\readme.md`, and `src\readme.graph.md` are explicitly ignored: their
directives are neither migrated nor annotated. Existing curated and derived
coverage is preserved independently of those excluded sources.

Parameter aliases/transforms and schema/response directives remain deferred and
unimplemented. There are no such directives in this originally absent shared
source; this audit makes no claim about their presence in ignored files.

The strict inventory command is
`.\tools\Get-WrapperDirectiveMigrationInventory.ps1 -Module BusinessScenario -FailOnUnresolved`;
the expected result is zero inventory rows, not fabricated `Mapped` entries.
