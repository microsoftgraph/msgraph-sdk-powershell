# Compatible operation variants distinguished by existing path IDs

Some published cmdlets expose the same conceptual operation through several paths.
When their existing mandatory path IDs distinguish those paths, one public command can
retain natural PowerShell parameter sets. Ambiguous or genuinely different operations
instead need manual review of a distinguishing cmdlet naming pattern. This feature does
not add a route switch, infer new public nouns, or make a retired endpoint supported.

## Native required DELETE queries are ordinary inputs, not variant selectors

The beta Identity.DirectoryManagement spec declares
`DELETE /administrativeUnits/{administrativeUnit-id}/members/$ref` as an ordinary
operation with required query `@id`, an unformatted string, and optional `If-Match`.
This is native OpenAPI input, not a legacy directive transform. Kiota 1.36.1 generates
`RefRequestBuilderDeleteQueryParameters.Id` with `[QueryParameter("%40id")]`.
Without a binding, its URL template sends `?@id=` with an empty value.

Ordinary bodyless DELETE emission exposes this as mandatory `-Id`, rejects missing,
null and empty arguments before transport, and assigns the strongly typed member in
the existing request-configuration lambda. Kiota retains ownership of the wire name
and URI encoding. Path IDs, `-IfMatch`, custom `-Headers`, GraphSession acquisition,
route metadata and the single High-ConfirmImpact `ShouldProcess` gate are unchanged.
No body serialization or URL construction is introduced.

DELETE parameters inherit from the path item, with operation-level declarations overriding
the same exact `(name, location)`. The bounded query support accepts required plain,
non-nullable, unformatted scalar strings with form serialization and identifier-shaped
names (an optional leading `@`, followed by an ASCII letter and ASCII letters/digits).
Unsupported required types, names, serialization contracts and parameter/member collisions
fail generation with the parameter and route identified. Optional query expansion is not
part of this feature, and no query-authoring registration is added.

This does **not** make a query-dependent DELETE eligible for an operation variant group.
Mutation groups still reject query inputs, including inherited ones; only existing
mandatory **path** IDs discriminate natural variants. Collection reference deletion
by URI and deletion through `/members/{directoryObject-id}/$ref` must retain their
reviewed distinct command names rather than being grouped by the new query argument.

`RequiredDeleteQueryTests` pins production-shaped metadata, inheritance/overrides,
explicit unsupported-contract failures, unchanged no-query neighbors and grouped-query
rejection. `tools/Test-WrapperRequiredDeleteQuery.ps1` generates actual Kiota 1.36.1
builders, compiles wrappers with the unchanged production project templates and imports
normal manifests against the installed Authentication module. Its in-memory GraphSession
transport verifies exact encoded/decoded DELETE URIs, reserved/Unicode escaping, ETags,
custom headers and absent bodies. It exercises missing/null/empty binding, WhatIf, and
genuine Yes/No confirmation hosts (one prompt and at most one DELETE per invocation).
The inherited-query fixture and item/no-query neighbors run through the same gate.
Neither RMS nor a live Graph connection is required.

```powershell
dotnet build .\tools\WrapperGenerator\WrapperGenerator.csproj --no-restore
dotnet test .\tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj --no-restore `
    --filter 'FullyQualifiedName~RequiredDeleteQueryTests|FullyQualifiedName~EmitterTests|FullyQualifiedName~MutationRouteTests|FullyQualifiedName~GenerationServiceRegressionTests'
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredDeleteQuery.ps1 `
    -KiotaPath <kiota-1.36.1-executable> -ArtifactRoot <new-artifact-directory>
```

The optional `-BaselineCmdletsDirectory` compiles an independently captured pre-fix
ordinary wrapper against the same real client and demonstrates its absent `-Id` and
empty `?@id=` request. Generated proof sources/binaries and `evidence.json` stay under
`ArtifactRoot`; they are not module migration output or committed generated trees.

## Exact reviewed configuration

Module-owned `*_cmdletConfigurations.cs` arrays can contain entries produced by
`CmdletConfigurator.GroupVariants(group, reason)`. The minimal records are nested in
`CmdletConfigurator`, alongside the registration factory:

```csharp
CmdletConfigurator.OperationVariant(string Method, string Path, string FamilyName)
CmdletConfigurator.OperationVariantGroup(IReadOnlyList<OperationVariant> Routes, string DefaultFamily)
```

These names describe compatible variants of **one public command**. Existing mandatory
path IDs select its parameter set; registration does not add a `Route` parameter or
an endpoint selector. HTTP routes and `GraphRouteAttribute` still describe the actual
requests made by each typed worker.

| Parameter | Meaning |
|---|---|
| `Method` | `GET`, `POST`, `PATCH`, `PUT` or `DELETE`. All group members must share the method and operation kind. |
| `Path` | Exact OpenAPI path with named placeholders. Matching ignores case but neither erases placeholder names nor accepts wildcards. |
| `FamilyName` | Maintainer-chosen family label, such as `Root`, `Profile`, `Parent` or `Agent`. These words have no built-in URL meaning. The label plus the operation shape names its parameter set: `ProfileList`, `ProfileGet`, `AgentList`, etc. |
| `Routes` | The complete reviewed operations that should share one public command, including an ordinary item operation if it would otherwise collide with the dispatcher. |
| `DefaultFamily` | An exact family label from `Routes`. Its list is the default when present; otherwise its single operation is the default. Its mandatory IDs must be a subset of every alternative's IDs. |

`FamilyName` is not a cmdlet noun or a caller-supplied argument. Users select the variant
through existing IDs, not `-FamilyName`, `-Profile`, `-Parent` or `-Route`. Labels are
visible when inspecting parameter sets with `Get-Command`.

All members must already resolve to the same public name through existing naming rules
and derived-data precedence. The annotation does not rename, unsuppress or classify away
an operation. `CmdletConfigurator` is the sole source of variant registrations, collected
from the module's `*_cmdletConfigurations.cs` array. There is no separate variant list
in `GeneratorConfig` or public generation-service overload. Authored configurations have
no API-version parameter: define a group once and reuse it for v1.0 and beta generation. All curated
suppression/rename entries likewise apply wherever their method and path match.

The module's input determines which operations exist. A group with no matching paths is
irrelevant and ignored; a partially present group still fails rather than silently dropping
variants. Defining a group once does not make an unavailable endpoint exist in another
profile. The generator does not automatically complete a partial group.

`GeneratorConfig` contains only client namespace, output directory, and the derived-data toggle:

```csharp
new GeneratorConfig(clientNamespace, outputPath, UseCollisionData: true);
```

The generation run's `--api-version` selects the correct **generated oracle data**, outside
authored configuration. `PowerShellWrapperGenerationService` receives that run context
separately; the CLI forwards it to naming and suppression lookups without filtering the
shared curated entries or variant registrations. Do not mix v1.0 oracle data into a beta run.

Isolated unit tests supply module-style `GroupVariants(...)` entries through an internal
constructor seam. It uses the same `CmdletConfigurator` registration reader without mutating
global module configuration; it is not a second public configuration API.

### One definition, three invocations

Inside the module's `CmdletConfigurator` partial-class configuration array, this single
definition is usable by either profile whose input includes these operations:

```csharp
GroupVariants(new OperationVariantGroup(
[
    new("GET", "/widgets", FamilyName: "Root"),
    new("GET", "/widgets/{widget-id}", FamilyName: "Root"),
    new("GET", "/widgets/{parent-id}/widgets", FamilyName: "Parent"),
], DefaultFamily: "Root"), "Reviewed compatible widget list/item operations.")
```

| Caller invocation | Parameter set | Request |
|---|---|---|
| `Get-MgWidget` | `RootList` (default) | `GET /widgets` |
| `Get-MgWidget -WidgetId $id` | `RootGet` | `GET /widgets/{widget-id}` |
| `Get-MgWidget -ParentId $id` | `ParentList` | `GET /widgets/{parent-id}/widgets` |

The maintainer could choose `Profile` instead of `Root`, provided `DefaultFamily` also
becomes `Profile`. Only the parameter-set labels would change; URL selection still uses IDs.

### Applications acceptance case

The official Beta.Applications 2.38.1 proxy AST, actual `Get-Command` parameter sets and
compiled worker URL evidence establish five current operations:

| Published variant | Mandatory existing IDs | Request shape |
|---|---|---|
| AgentGroup List (default) | OnPremisesPublishingProfileId | Root collection |
| AgentGroup Get | OnPremisesPublishingProfileId, OnPremisesAgentGroupId | Root item |
| AgentGroup List2 | OnPremisesPublishingProfileId, OnPremisesAgentId | Agent collection |
| AgentGroupCount Get (default) | OnPremisesPublishingProfileId | Root count |
| AgentGroupCount Get2 | OnPremisesPublishingProfileId, OnPremisesAgentId | Agent count |

These are compatible parameter-set variants, not different operations needing a selector.
The module-owned entries for exactly those paths are:

```csharp
GroupVariants(new OperationVariantGroup(
[
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/{onPremisesAgentGroup-id}", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups", "Agent"),
], DefaultFamily: "Root"), "Reviewed 2.38.1 List/Get/List2 contracts and exact worker URLs."),

GroupVariants(new OperationVariantGroup(
[
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/$count", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups/$count", "Agent"),
], DefaultFamily: "Root"), "Reviewed 2.38.1 Get/Get2 count contracts and exact worker URLs.")
```

The first command exposes `RootList` (default), `RootGet` and `AgentList`; the count exposes
`RootScalar` (default) and `AgentScalar`. These internal set names are not literal v2
`List`/`Get`/`List2`/`Get2` labels. Public command names, mandatory-ID behavior and root
defaults are preserved. No `Route`, `Published`, switch or other discriminator is added.
Supplying both the root item ID and the agent ID is an invalid parameter-set combination.

## Supported homogeneous contracts

A group contains compatible entity GETs (collection/list and item shapes), scalar
`/$count` GETs, resource creates/updates/replacements/deletes, or POST actions. It cannot
mix these categories. Every operation has a distinct mandatory path-ID set;
the default root set must be a subset of every other set. Each family's list/item pair,
when both exist, must be structurally related. All entity workers emit the same model;
same-shape response, query and header contracts must match.

### Response unions belong to Kiota

The wrapper does not reject a response merely because it contains `oneOf` or `anyOf`,
directly or through named references and `allOf`. The typed Kiota request builder owns
deserialization: a union may become a generated composed model, or a Kiota untyped node
for a shape it does not generate as a named model. Workers pass that actual result through
unchanged; they neither pick an arm, flatten the schema nor convert the returned object.

For example, `Widget: oneOf [BasicWidget, AdvancedWidget]` can be returned from both a
root GET and a parent-scoped GET, or appear as the `value.items` type in a named collection
response. The grouped command forwards the original Kiota union model(s). Collection paging
continues through the typed envelope, preserving each item's concrete union representation.
An `allOf`-nested union that Kiota exposes as `UntypedNode` is likewise returned intact.

For union contracts the wrapper uses `object` for result declarations and output metadata
rather than promising the schema reference's CLR name: Kiota may not generate that class.
This does not change the result's runtime type or deserialization. Named non-union models
and discriminator-based polymorphic collections keep their existing typed metadata.
Normal route/parameter compatibility and successful-response comparisons still apply.

GET workers reuse the unchanged ordinary typed `EmitListGet`, `EmitItemGet` and `EmitScalarGet`
templates. Their supported optional OData queries and aliases, declared optional string
headers, generic `Headers`, inherited authentication parameters and list paging remain
intact. The thin public dispatcher selects only by `ParameterSetName` and forwards bound
parameters wholesale to `_Route0`, `_Route1`, ... workers in declaration order. It retains
the existing worker ErrorRecord and does not reclassify pipeline stops or cancellation.
Workers remain exported, like ordinary `_List`/`_Get` workers, for in-runspace invocation.

### Resource mutations and POST actions

The same annotation can group ordinary resource `POST` (`New`), `PATCH` (`Update`),
`PUT` (`Set`), bodyless `DELETE` (`Remove`), or homogeneous POST actions. A mutation family
has exactly one operation; its internal set is its label plus `New`, `Update`, `Set`,
`Remove` or `Action`. There are still no selector parameters or capability flags.

For example, after separately reviewing the service and published naming/parameter
contracts, two repeated resource paths can retain their ordinary `Update-MgWidget` name:

```csharp
GroupVariants(new OperationVariantGroup(
[
    new("PATCH", "/widgets/{widget-id}", "Root"),
    new("PATCH", "/widgets/{parent-id}/widgets/{widget-id}", "Parent"),
], DefaultFamily: "Root"), "Reviewed identical public body, output and optional header contracts.")
```

`RootUpdate` requires `WidgetId`; `ParentUpdate` additionally requires `ParentId`. A body
property colliding with an ID keeps the existing ordinary numeric suffix, such as
`WidgetId1`, independently of the URL's `WidgetId`. If route-specific collision resolution
would change the public body parameter names or types, the group is rejected.

Resource JSON writes must use a named entity request body and the same named result
entity supported by the ordinary typed emitter. A documented no-content status may
coexist with that entity response. DELETE must have neither a body nor a result. An action
may be bodyless or have an ordinary inline JSON body, and may return no output or one
shared named entity. Bodyless and bodyful actions cannot share a group; neither can void
and entity outputs. Per-action generated request-body class names remain private to each
typed worker: only identical public property contracts may be grouped, without a shared
cast or hand conversion.

Body parameters come from the same scalar/complex/untyped binding descriptors and
collision resolution as ordinary commands. Existing type aliases, nullable declarations,
array/model/enum types, optional expanded fields and policy exclusions remain unchanged.
Request requiredness, required-property sets and inline property schemas must agree,
as must public parameter names/types, responses and optional string headers. Unsupported
body properties fail rather than disappearing from one selected worker. No new
`BodyParameter` or `Expanded` form is introduced. Mutations do not bind query parameters.

Public mutation dispatchers advertise `SupportsShouldProcess`; DELETE retains
`ConfirmImpact.High` and the other supported shapes retain `Medium`. The dispatcher
does **not** call `ShouldProcess`: exactly the selected ordinary worker performs that
gate, before constructing its body, acquiring transport or issuing requests.
`WhatIf`, `Confirm`, explicit `Confirm:$false` and ambient preference handling remain
the PowerShell engine's responsibility. The full bound-parameter splat is unchanged.
PATCH's existing no-body-result re-fetch uses only the selected typed route, and only
when that path declares GET; PUT never acquires a re-fetch. No operation tries another
URL on failure.

Preflight validates **all** configured groups before creating/clearing the output directory,
writing the CLI's `kiota-lock.json` marker or writing any command. Grouped dispatcher and
worker filenames are reserved case-insensitively and checked against the ordinary emission
pipeline, including its list/item workers and dispatchers. An ungrouped operation that would
occupy any reserved filename rejects the configuration, even with collision data disabled.
Include that operation in the reviewed group or review its naming; generation never keeps
an ordinary command in place of a grouped dispatcher. Unsupported ordinary operations that
emit no command do not reserve filenames. Ordinary collision
derivation still writes its marker before generation, as before. An unrelated module with
none of a group's paths ignores it;
a partially present, filtered or suppressed group fails. Invalid grouping never silently
keeps the first endpoint or falls back to another URL. Ordinary, unannotated operations,
list/item pairing, collision failures and the merged composite-key emitter are unchanged.

The following are rejected for grouped generation:

- Identical mandatory path-ID sets, a default that shadows a shallower route, incompatible
  parameter types/aliases, duplicate membership or nonstructural list/item pairs.
- Mixed methods/kinds, functions, media, `/$ref`, `/$value`, composite-key group routes,
  GET request bodies, unresolved response contracts, incompatible models or mutation queries.
- Non-JSON, root union or unbindable bodies; incompatible body requiredness, properties
  or public types; bodyless/bodyful or void/entity mixtures; resource JSON writes without
  the ordinary matching named body/result model; route-specific public body forms.
- Required queries, arbitrary/non-OData queries, unsupported query types, differing
  same-shape query/header contracts, required/non-string headers and unbound inherited
  query/header or unsupported parameter locations.

There are no policy flags, selector-based/asymmetric dispatch, mixed resource/function or
media plans, route-specific body conversions, derived-suppression bypass, arbitrary query bindings,
or independent ordinary-reference DELETE APIs in this capability. Their earlier
implementations are recoverable in Git history, not part of the current supported surface.
For a rejected ambiguous case, review the actual API operation and use a distinguishing
published or explicitly reviewed noun rather than adding switching machinery or pruning a
valid route. Module activation and complete module build/packaging validation are separate.

## Route evidence and focused gates

`GraphRouteAttribute` is repeatable. Each public dispatcher carries all exact method/path
pairs with their parameter-set names; each typed worker carries one route. Source coverage
inventories, compiled parity, output manifests and worker/orphan/export checks retain every
route. A missing oracle URI is not proof that a secondary operation is absent; the metadata
producer can retain only the first URI of a multi-variant command.

`MultiRouteTests` covers natural-ID GET grouping, root defaults, ordinary list/item behavior
and fail-fast rejection boundaries, plus union-response pass-through without choosing an arm.
`MutationRouteTests` covers compatible mutation/action
workers, their body/output/ShouldProcess contracts and preflight rejection boundaries.
`Test-WrapperMultiRouteDispatcher.ps1` compiles the emitted
ID dispatcher against the real runtime and exercises natural binding, invalid combinations,
query/header forwarding and error identity without Graph calls.
`Test-WrapperRouteMetadata.ps1` checks compiled GET/count and mutation/action metadata, exports, parity and
coverage. The Applications disposable acceptance fixture additionally compiles the five
actual typed GET workers and two public commands, and checks their five URLs and real
PowerShell binder/mock-wire cases. Such focused proofs are not full-module or live-service
validation.

## Existing deferred cross-path cases

The existing derived-data deferral policy is unchanged. Earlier v1.0 collision derivation
kept the shallower route family and recorded `deferredCrossPathMerge: true` suppressions;
this feature does not automatically remove those entries.

- Group `/photo` versus `/photos`: the single/collection shapes have the same mandatory
  IDs and cannot be selected by this natural-ID dispatcher. The existing singleton
  workaround remains; any supported alternative naming needs separate manual review.
- Shares `/listItem` versus `/list/items`: singleton and collection share the same
  mandatory IDs. The existing derived deferral and curated bare item suppression are not
  broadened or bypassed; review distinguishing names separately.

## Bookings beta retirement

Microsoft's [official Bookings announcement](https://devblogs.microsoft.com/microsoft365dev/breaking-changes-in-microsoft-bookings-graph-apis-beta/)
retired the `/beta/bookingBusinesses` and `/beta/bookingCurrencies` families effective
**April 30, 2024**, replacing them with `/beta/solutions/...`; requests to the old paths
after that date are documented to return an error. Continued spec/proxy presence is not
service-validity evidence. Do not retain retired roots as supported alternatives or a
default. Bookings legacy URI removal is separate module-owned work; this retirement is
not evidence that unrelated cross-path operations are retired.
