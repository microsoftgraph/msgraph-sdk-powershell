# Kiota alignment edge cases

Second class file in the edge-case catalog (see `naming-edge-cases.md` for the catalog
conventions). These cases are places where the wrapper generator's *prediction* of what
kiota generates — type names, builder members, query parameters — met kiota's actual
output and lost. Every entry was found the same way: compiling generated wrappers against
a real kiota client, module by module. That is the point of the packaging pipeline: a wrong
prediction fails a build loudly instead of shipping.

The systemic backstop for this whole class is the compile gate (tracked with the pipeline
work): these entries document the specific rules learned so far, not a promise that no
others exist.

## Doc flavor: kiota requires the KiotaCompat conversion

- **Class:** doc-flavor
- **Status:** handled (Build-WrapperModule.ps1 defaults to openApiDocs_KiotaCompat)
- **Evidence:** the PowerShell-profile docs under `openApiDocs` flatten open types
  (`microsoft.graph.Dictionary`, `customExtensionData`, `onAttributeCollectionHandler`)
  into empty schemas; kiota rejects them ("the type does not contain any information") in
  Search, Identity.SignIns, Identity.Governance, and ConfigurationManagement, and hangs
  >35 min on Sites. The `openApiDocs_KiotaCompat` conversion (DEVX API, `style=Plain`,
  discriminators preserved) generates all five in seconds.
- **Decision:** KiotaCompat docs are the generator's canonical input. Open question raised
  with the team: make them canonical for the whole v3 pipeline.
- **Migration impact:** none — input selection, not output change.
- **References:** tools/DownloadOpenApiDocKiotaCompat.ps1 (provenance);
  Build-WrapperModule.ps1 `-SpecRoot`.

## kiota hangs on specific docs (both flavors)

- **Class:** doc-flavor
- **Status:** workaround (hard timeout + per-module doc-flavor fallback)
- **Evidence:** kiota 1.32.2 hangs silently (zero CPU, no output) on the *styled* Sites doc
  and on the *KiotaCompat* Teams doc — while generating each module fine from the other
  flavor. Content-dependent, not size-dependent (larger docs complete in seconds).
- **Decision:** Build-WrapperModule.ps1 kills kiota after 300s and fails the module rather
  than stalling a fan-out; Teams builds from the styled doc via `-SpecRoot`. Candidate for
  an upstream kiota report once a minimal repro is extracted.
- **Migration impact:** none.

## Reserved model names: Directory → DirectoryObject1

- **Class:** kiota-symbol-prediction
- **Status:** handled (observed rule encoded, pinned test)
- **Evidence:** kiota renames model classes on its C# reserved list (BCL conflicts) by
  appending `Object`, then dedupes numerically: `microsoft.graph.directory` generates as
  `DirectoryObject1` because `directoryObject` already exists (Identity.DirectoryManagement).
  A bare `Directory` reference had first resolved to `System.IO.Directory` under implicit
  usings.
- **Decision:** encode the observed rule for reserved names present in Graph docs
  (Directory/File/Task/Type/Environment), computed against the document's schema set. This
  mirrors observed kiota 1.32.2 behavior — a wrong prediction fails the module compile, it
  cannot fail silently.
- **Migration impact:** none — internal type references only.
- **References:** kiota's CSharpReservedClassNamesProvider;
  PowerShellWrapperGenerationService.KiotaReservedModelNames.

## A model that shares its name with a kiota sub-namespace moves inside it

- **Class:** kiota-symbol-prediction
- **Status:** handled (all model references fully qualified; pinned tests)
- **Evidence:** `microsoft.graph.security` generates as `Models.Security.Security` because
  the `microsoft.graph.security.*` family creates a `Models.Security` namespace; bare
  `Security` resolved to the namespace and did not compile (Security module; same for
  `partners`/`Models.Partners.Partners` in Reports).
- **Decision:** fully qualify every model type reference and mirror the move-inside rule
  when a single-segment name matches a sub-namespace derived from the document.
- **Migration impact:** none.

## kiota strips underscores from member names

- **Class:** kiota-symbol-prediction
- **Status:** handled (pinned test)
- **Evidence:** signIn's `riskEventTypes_v2` property generates as `RiskEventTypesV2`; the
  wrapper's naive Pascal-casing produced `RiskEventTypes_v2` and the body assignment did
  not compile (Reports).
- **Decision:** mirror the cleanup (drop `_`, upper-case the following character) when
  naming the model member a body parameter assigns to.
- **Migration impact:** none.

## Query options exist only where the doc declares them

- **Class:** kiota-builder-shape
- **Status:** handled (pinned by the option-table mechanism)
- **Evidence:** kiota omits query-parameter properties the operation doesn't declare:
  content/stream endpoints get a bare `DefaultQueryParameters` (Files, Notes, Users, +4 on
  the styled docs), and `subscribedSkus/{id}` declares `$select` but not `$expand`
  (Identity.DirectoryManagement, KiotaCompat). Unconditional `-Property`/`-ExpandProperty`
  bindings did not compile.
- **Decision:** item GETs and dispatchers now emit `$select`/`$expand` parameters only when
  the operation declares them, per parameter set — the same declared-options mechanism list
  GETs already used.
- **Migration impact:** cmdlets for endpoints without `$select`/`$expand` no longer expose
  dead `-Property`/`-ExpandProperty` parameters (they never worked server-side).

## Media/content endpoints return Stream regardless of declared JSON schema

- **Class:** kiota-builder-shape
- **Status:** handled (skipped with a logged reason; pinned by regression test)
- **Evidence:** the styled docs attach an entity JSON schema to media endpoints
  (`.../filesFolder/content`), but kiota generates `GetAsync` returning `System.IO.Stream`
  for them — assigning that to an entity type does not compile (Teams, built from the
  styled doc because kiota hangs on its KiotaCompat variant). The KiotaCompat docs declare
  these endpoints without a JSON schema, so they were already skipped there.
- **Decision:** a GET whose success response also declares non-JSON content is a media
  download and is skipped until stream support exists (same treatment as `$value`).
- **Migration impact:** content-download cmdlets (`Get-...Content`) are not generated yet;
  tracked with the operation-shapes work.

## PATCH-only resources have no GetAsync to re-fetch

- **Class:** kiota-builder-shape
- **Status:** handled (pinned test)
- **Evidence:** Update cmdlets re-fetch after a bodiless 204; `/places/{place-id}` has no
  GET, so the builder has no `GetAsync` and `Update-MgPlace` did not compile (Calendar).
- **Decision:** emit the re-fetch only when the path declares a GET; otherwise a bodiless
  204 returns nothing — matching the published SDK's Update behavior.
- **Migration impact:** none vs the published SDK.
