# BusinessScenario

## AutoRest Configuration

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

## Shared-directive migration audit

The shared `src\BusinessScenario\BusinessScenario.md` file did not exist at the
reviewed base `51d441eeb5f1afb57299a74564963f564baec930`. This document records that
absence and introduces no new directives or generation pipeline. The standard
`tools\Templates\module.md` require above preserves the legacy default wiring:
`Copy-ModuleTemplate` skips existing files, so an audit-only file at this path
would otherwise prevent that require from being created. The referenced global
directives remain unchanged and outside this migration's scope; the v3 wrapper
builder does not consume this markdown configuration.
There are **zero shared cmdlet directives** to migrate. The existing
`wrapper\BusinessScenario_cmdletConfigurations.cs` collection remains empty, and
`wrapper\BusinessScenario_directiveMigrationMap.json` deliberately contains an
empty `mappings` array. No directive indexes, operation mappings, suppressions, or
renames are invented for this audit.

### Compatible profile evidence

| Profile | Disposition | Evidence |
| --- | --- | --- |
| beta | Required | `openApiDocs_KiotaCompat\beta\BusinessScenario.yml`, Git blob `d9e1ebc5e38e58e0c197a07f388cf942d729c9f0`; 23 paths, 51 operations (20 GET, 7 POST, 12 PATCH, 12 DELETE). |
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
| GET | `/solutions/businessScenarios` | `solution_ListBusinessScenario` |
| POST | `/solutions/businessScenarios` | `solution_CreateBusinessScenario` |
| GET | `/solutions/businessScenarios/{businessScenario-id}` | `solution_GetBusinessScenario` |
| PATCH | `/solutions/businessScenarios/{businessScenario-id}` | `solution_UpdateBusinessScenario` |
| DELETE | `/solutions/businessScenarios/{businessScenario-id}` | `solution_DeleteBusinessScenario` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner` | `solution.businessScenario_GetPlanner` |
| POST | `/solutions/businessScenarios/{businessScenario-id}/planner/getPlan` | `solution.businessScenario.planner_getPlan` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner/tasks` | `solution.businessScenario.planner_ListTask` |
| GET | `/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}` | `solution.businessScenario.planner_GetTask` |
| GET | `/solutions/businessScenarios/$count` | `solution.businessScenario_GetCount` |

`tools\WrapperGenerator.Tests\BusinessScenarioDirectiveMigrationTests.cs` loads
the real compatible beta document, checks these operation identities and current
names with derived data enabled and disabled, and checks that all 51 beta
operations remain unsuppressed. After merging `powershell-v3` containing #3849
(`08e409a6aa8fd48736b8f9a9199559f46fc0d1ad`), the tests use the three-setting
`GeneratorConfig` API and pass `apiVersion: "beta"` separately to naming and
suppression, never implicitly selecting the v1.0 oracle. The identities above
reflect the integrated compatible spec's operation-ID alignment.
These names describe existing wrapper behavior,
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
