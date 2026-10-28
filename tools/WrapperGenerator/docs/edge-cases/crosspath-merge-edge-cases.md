# Compatible operation variants distinguished by existing path IDs

Some published cmdlets expose the same conceptual operation through several paths.
When their existing mandatory path IDs distinguish those paths, one public command can
retain natural PowerShell parameter sets. Ambiguous or genuinely different operations
instead need manual review of a distinguishing cmdlet naming pattern. This feature does
not add a route switch, infer new public nouns, or make a retired endpoint supported.

## Exact reviewed configuration

Module-owned `*_cmdletConfigurations.cs` arrays can contain entries produced by
`CmdletConfigurator.MergeRoutes(group, reason)`. The minimal records are:

```csharp
MultiRoute(string Method, string Path, string Name)
MultiRouteGroup(string ApiVersion, IReadOnlyList<MultiRoute> Routes, string DefaultRoute)
```

`Method` is `GET`, `POST`, `PATCH`, `PUT` or `DELETE`; every member of a group uses the
same method and operation kind. `Path` is the exact source-spec path, including named placeholders.
Matching ignores case but does not erase placeholder names or accept wildcards. `Name`
labels a route family for internal parameter-set names, not a new public parameter.
`DefaultRoute` explicitly identifies the root family. Its list is the default when present;
otherwise its single operation is the default.

All members must already resolve to the same public name through existing naming rules
and derived-data precedence. The annotation does not rename, unsuppress or classify away
an operation. Focused callers can provide the same groups through the optional
`GeneratorConfig.MultiRouteGroups` argument; module groups are globally aggregated and
filtered by API profile.

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
MergeRoutes(new MultiRouteGroup("beta",
[
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/{onPremisesAgentGroup-id}", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups", "Agent"),
], DefaultRoute: "Root"), "Reviewed 2.38.1 List/Get/List2 contracts and exact worker URLs."),

MergeRoutes(new MultiRouteGroup("beta",
[
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/$count", "Root"),
    new("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups/$count", "Agent"),
], DefaultRoute: "Root"), "Reviewed 2.38.1 Get/Get2 count contracts and exact worker URLs.")
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
MergeRoutes(new MultiRouteGroup("v1.0",
[
    new("PATCH", "/widgets/{widget-id}", "Root"),
    new("PATCH", "/widgets/{parent-id}/widgets/{widget-id}", "Parent"),
], DefaultRoute: "Root"), "Reviewed identical public body, output and optional header contracts.")
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
writing the CLI's `kiota-lock.json` marker or writing any command. Ordinary collision
derivation still writes its marker before generation, as before. An unrelated module with
none of a group's paths ignores it;
a partially present, filtered or suppressed group fails. Invalid grouping never silently
keeps the first endpoint or falls back to another URL. Ordinary, unannotated operations,
list/item pairing, collision failures and the merged composite-key emitter are unchanged.

The following are rejected for grouped generation:

- Identical mandatory path-ID sets, a default that shadows a shallower route, incompatible
  parameter types/aliases, duplicate membership or nonstructural list/item pairs.
- Mixed methods/kinds, functions, media, `/$ref`, `/$value`, composite-key group routes,
  GET request bodies, unresolved/union responses, mixed models or mutation queries.
- Non-JSON, root union or unbindable bodies; incompatible body requiredness, properties
  or public types; bodyless/bodyful or void/entity mixtures; resource JSON writes without
  the ordinary matching named body/result model; route-specific public body forms.
- Required queries, arbitrary/non-OData queries, unsupported query types, differing
  same-shape query/header contracts, required/non-string headers and unbound inherited
  query/header or unsupported parameter locations.

There are no policy flags, selector-based/asymmetric dispatch, mixed resource/function or
media plans, response/body unions, derived-suppression bypass, arbitrary query bindings,
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
and fail-fast rejection boundaries. `MutationRouteTests` covers compatible mutation/action
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
