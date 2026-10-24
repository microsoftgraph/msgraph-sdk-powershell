# Cross-path variant merge edge cases

This file covers one class of issue: **cross-path variant merges** — cases where the
published SDK serves ONE cmdlet from several unrelated request URIs, as AutoRest parameter-set
variants. The wrapper generator normally emits one cmdlet per route (plus the list/item
dispatcher). Reviewed exact route groups can opt into the multi-route dispatcher described
below; all other collisions retain their existing failure or deferral policy. The derivation
sweep of every v1.0 collision route (`tools/Derive-CollisionResolutions.ps1`, ledger in
`artifacts/collision-resolution-ledger.v1.0.csv`) found exactly two.

**Existing derived-data policy (unchanged):** among same-command routes, the shallowest list/item pair survives (fewest path
parameters; tie broken by shortest, then ordinal — fully deterministic); the other routes are
suppressed with `deferredCrossPathMerge: true` in `data/collision-suppressions.v1.0.json`.
These entries remain deferred until a module owner reviews and explicitly opts in their
complete route groups; introducing the capability does not remove a suppression.

## Explicit reviewed multi-route groups

Module-owned `*_cmdletConfigurations.cs` entries can retain several live routes under one
public command without inventing another noun. The opt-in is an entry in the existing
`CmdletConfigurator` configuration list:

```csharp
MergeRoutes(new MultiRouteGroup("beta",
[
    new("GET", "/bookingBusinesses", "Legacy"),
    new("GET", "/bookingBusinesses/{bookingBusiness-id}", "Legacy"),
    new("GET", "/solutions/bookingBusinesses", "Solutions"),
    new("GET", "/solutions/bookingBusinesses/{bookingBusiness-id}", "Solutions"),
], DefaultRoute: "Legacy", SelectorParameter: "Route"),
    "Reviewed shared directive and published default-route evidence.")
```

`MultiRoute(Method, Path, Name)` identifies an **exact source-spec method/path** and a
route-family label. It accepts no prefix, subtree, wildcard, operation-ID inference, or
collision deduplication. `MultiRouteGroup(ApiVersion, Routes, DefaultRoute,
SelectorParameter = null)` is profile-scoped. Every member must already resolve to the
same public verb/noun through the existing naming rules and derived-data precedence;
the group never renames an operation. Suppressions remain authoritative unless the exact
reviewed derived-only opt-in described below is present. `GeneratorConfig.MultiRouteGroups`
also accepts these records for focused engine callers and fixtures.

Two dispatch modes are available:

- With `SelectorParameter: "Route"`, the public cmdlet accepts
  `-Route Published|Legacy|Solutions` (labels come from the group).
  Omission and `Published` use the group's **explicit** `DefaultRoute`, never input order
  or the shallowest subtree. `Legacy` and `Solutions` always select those routes. Corresponding
  operations must have identical public parameter shapes. List/item selection still uses the
  existing item ID, with `List`/`Get` parameter sets.
- Without a selector, existing mandatory path IDs discriminate route families.
  Governance's four reviewed GETs can use `Standalone` and `Role` labels, producing
  `StandaloneList`, `StandaloneGet`, `RoleList`, and `RoleGet` sets. The nested sets require
  `PrivilegedRoleId`; both item sets require `PrivilegedRoleAssignmentId`. No extra route
  flag or renamed ID is introduced.

The public default set is the configured default family's list when present, otherwise its
single operation (`Get`, `Scalar`, or `Invoke`, with the family label in no-selector mode).
Mutations retain their workers' ShouldProcess behavior and receive `WhatIf`/`Confirm`.
Workers are the existing typed emitters with stable `_Route0`, `_Route1`, ... suffixes in
declaration order; each uses its own Kiota builder and action request/response namespace.
They remain exported like the existing `_List`/`_Get` workers so in-runspace forwarding
works. Public dispatch strips only its selector and forwards bound parameters, including
body properties, aliases' canonical names, headers, token, paging options and common parameters.
Worker errors retain their original ErrorRecord; pipeline stops/cancellation are not
reclassified as Graph failures.

Supported opt-in shapes are entity list/item GETs, scalar `/$count` GETs, JSON
POST/PATCH/PUT, DELETE (including collection-only DELETE), and JSON/bodyless actions.
Plain named string queries are preserved with their declared requiredness on opted-in GET
workers and dispatchers. This covers Bookings calendarView's required `start` and `end` on
both list and item routes. Existing OData query options and aliases retain their ordinary
bindings; continuation links retain their query state and headers. Other extra query types, functions/delta, media, and reference operations are rejected
unless covered by the explicit reviewed extension policies below. No flag enables delta,
parameterized functions, or arbitrary query aliases.

Groups fail explicitly for missing/filtered/suppressed members, incompatible response/body/
query/header shapes, parameter conflicts, nonstructural list/item families, ambiguous same-ID
families without a selector, a no-selector default set that shadows a shallower route, or
duplicate membership. Unopted groups retain the original
collision diagnostics. This does not activate any module migration, change an excluded
profile-local directive, or broadly deduplicate collisions.

Binding checks compare all emitted mandatory parameters, including required queries, across
shapes within each selector label (or across the whole group without a selector). Selector,
parameter and alias conflicts are case-insensitive, including existing query aliases such as
`Select` and PowerShell common-parameter aliases such as `ea`.

## Separately reviewed extension policies

The original four-argument `MultiRouteGroup` constructor and three-argument `MultiRoute`
constructor are unchanged. These additional **init-only flags default to false**:

| Flag | Reviewed allowance |
|---|---|
| `AllowZeroArgumentFunctions` | GET functions with an empty argument list, no operation query/header parameters, a resolvable non-stream response, and no request body. |
| `AllowAsymmetricRoutes` | Explicit-selector resource GET groups whose route families do not expose identical List/Get shapes. |
| `AllowResponseUnion` | Different resolvable response models on reviewed resource GET or POST action routes; each typed worker and public parameter set retains its actual output type. |
| `AllowRouteSpecificBodies` | POST action groups with different supported expanded body properties; parent discrimination or the separate explicit-selector policy, never shared body-type coercion. |
| `AllowReferenceDelete` | Exact resource DELETE `/$ref` groups, with the reviewed required `@id` query mapping where declared. |
| `AllowMediaRoutes` | Exact resource GET/DELETE `/$value` groups with compatible typed media contracts. |
| `AllowExplicitRouteSelection` | A single public `Route` parameter set with shared required parameters; every selected typed worker's complete required/allowed contract is enforced at runtime. |
| `AllowPublishedParameterInference` | Only with explicit per-route parameters: prefer a compatible published-default family, otherwise require exactly one compatible alternate based on bound parameters. |
| `AllowMixedReadOperations` | The reviewed three-operation paged aggregate zero-argument function plus resource List/Get family, returning the same entity type. |
| `IncludeDerivedSuppressedRoutes` | Restore only exact reviewed group members from derived suppression data; never bypass a curated shared suppression. |
| `AllowMixedMediaReads` | Beta-only explicit Binary/List/Item resource-read plans for the reviewed recording groups; not general media/function merging. |
| `RequireExplicitRoute` | Only with the mixed-media policy: mandatory `Route Binary|Recordings`, an empty internal default and no Published value, inference or fallback. |

The flags do not rename, unsuppress, or infer membership for any operation. Exact route
lists, API-profile matching, published defaults, common parameter/alias conflict checks,
and all unrelated collision failures still apply. Unsupported properties in a
route-specific action body fail instead of being dropped. Extra query types, non-JSON
action body alternatives, inline function arguments, `@` function aliases, intermediate
parameterized calls and delta remain unsupported. Reviewed GET extensions reject **any**
declared request body, including non-JSON bodies. Reviewed extensions reject
path-item query/header declarations rather than ignoring an inherited required parameter;
the demonstrated cases declare their query/header contracts on the operations.

### Files: published singleton default, explicit or inferred collection

```csharp
MergeRoutes(new MultiRouteGroup("beta",
[
    new("GET", "/shares/{sharedDriveItem-id}/listItem", "Singleton"),
    new("GET", "/shares/{sharedDriveItem-id}/list/items", "Collection"),
], DefaultRoute: "Singleton", SelectorParameter: "Route")
{
    AllowAsymmetricRoutes = true,
}, "Published Get default and List variant; both require SharedDriveItemId.")
```

`-Route Published|Singleton|Collection` defaults to `Published`. The public parameter sets
remain `Get` (default) and `List`: `SharedDriveItemId` alone selects the published singleton,
while a bound list-only parameter such as `All`, `Top`, or `Filter` selects the collection.
Explicit `Collection` reaches the collection even without list-only parameters.
Explicit `Singleton` with a list-only parameter fails; the dispatcher neither ignores the
parameter nor falls back to the collection URL. The existing bare
`/shares/{}/list/items/{}` suppression is not broadened or removed.

### Search: zero-argument statistics and explicitly selected nested activity

The two `industryData.getStatistics()` routes use `AllowZeroArgumentFunctions = true`,
`Collection`/`Item` labels, no selector, and `DefaultRoute: "Collection"`. The published
collection function requires no run ID; the item function requires `IndustryDataRunId`.
The public sets are `CollectionGet` (default) and `ItemGet`; existing typed function workers
keep each exact namespace-qualified function URL.

The activity group uses the normal collection/item routes under `RunActivity`, the nested
`.../activities/{industryDataRunActivity-id}/activity` GET under `Activity`, and:

```csharp
new MultiRouteGroup("beta", reviewedActivityRoutes, "RunActivity", "Route")
{
    AllowAsymmetricRoutes = true,
    AllowResponseUnion = true,
}
```

`Published` preserves `List` inference from `IndustryDataRunId` and `Get` inference when
`IndustryDataRunActivityId` is also supplied. Its Get default is the normal
`industryDataRunActivity`, not the nested `industryDataActivity`. Explicit `Activity`
requires both IDs and selects the nested worker. Without the activity ID it fails rather
than falling back to List. The public Get output metadata includes both distinct typed
models only because this group explicitly permits the response union.

For every asymmetric group, selection checks all bound operation parameters and all
required parameters. Published mode uses the actual binder-selected shape and prefers the
reviewed default family when it offers a compatible route; otherwise exactly one compatible
route must exist. An explicit non-Published label considers only that label, requires
exactly one compatible worker, and reports missing/unsupported parameters through
`InvalidGraphRouteParameters`. Body/query/header/token/common parameters are not discarded;
only the selector is removed before invoking the selected worker.

### Directory actions: per-route expanded bodies and typed responses

Each of the four reviewed root/recommendation `addTag`/`removeTag` groups uses
`Collection` and `Item` labels, no selector, `DefaultRoute: "Collection"`, and both
`AllowRouteSpecificBodies = true` and `AllowResponseUnion = true`.

The collection body is `{ resourceIds: string[], displayName: string }` and returns an
impacted-resource collection response. Item `addTag` takes `{ displayName: string }`
and returns `recommendationTag|null`; item `removeTag` takes `{ tagId: string }` and
returns `impactedResource|null`. The existing `ImpactedResourceId` discriminates
`CollectionInvoke` from `ItemInvoke`; recommendation routes additionally retain
`RecommendationId`. `ResourceIds` is collection-only and `TagId` is item-only.
There are no invented `Expanded` parameter-set names or shared `BodyParameter` unions.
Each worker constructs its own Kiota request body and returns its own typed result.

### Directory member-reference DELETE: published item default and explicit URI binding

```csharp
MergeRoutes(new MultiRouteGroup("beta",
[
    new("DELETE", "/administrativeUnits/{administrativeUnit-id}/members/{directoryObject-id}/$ref", "Item"),
    new("DELETE", "/administrativeUnits/{administrativeUnit-id}/members/$ref", "Collection")
    {
        QueryBindings = [new("@id", "MemberReferenceUri")],
    },
], DefaultRoute: "Item")
{
    AllowReferenceDelete = true,
}, "Published Delete default requires AdministrativeUnitId and DirectoryObjectId.")
```

`MultiRouteQueryBinding(QueryName, ParameterName)` is permitted only for the demonstrated
required plain-string `@id` query, explicitly named `MemberReferenceUri`. Kiota's typed
query configuration uses `Id` with `[QueryParameter("%40id")]`; this is not a raw URL
rewrite, an `Id` alias, or a conversion to a different route.

The public default remains `ItemInvoke`, requiring `AdministrativeUnitId` and
`DirectoryObjectId`. `CollectionInvoke` instead requires `AdministrativeUnitId` and
`MemberReferenceUri`. Supplying both member selectors is an invalid parameter-set
combination. `IfMatch` belongs only to sets whose workers declare it, and generic `Headers`
and ShouldProcess parameters are forwarded normally. The oracle's collection URI alone
does not override the published item-default syntax.

### Explicit per-route parameters: Security defaults and Notes overlap

`AllowExplicitRouteSelection = true` requires a selector such as `"Route"`. This policy
uses one public parameter set named `Route`; a parameter is mandatory in that public set
only when it is mandatory for every worker. Route-unique IDs remain visible, but their
requiredness is enforced against the chosen worker **before** invoking it. All worker
parameters remain typed and mandatory exactly as before. Conflicting types, aliases or
positional contracts are rejected instead of being guessed.

This is distinct from the Files/Search asymmetric policy: with explicit selection,
omission or `Published` considers only the configured default family unless
`AllowPublishedParameterInference` is separately enabled. It never infers a Security bulk
action from a supplied `Ids` body property or a TopLevel count merely because the required
Nested ID is missing.

The two reviewed Nested-default Security count groups set
`SelectorParameter: "Route"`, `DefaultRoute: "Nested"` and
`AllowExplicitRouteSelection = true`; `Published|Nested|TopLevel` exposes the alternate
without changing the default URL. Explicit `TopLevel` rejects a Nested-only ID, and
explicit `Nested` rejects a missing ID. The six Item-default hold/index actions use
`Published|Item|Collection`, `DefaultRoute: "Item"`, and additionally
`AllowRouteSpecificBodies = true`. Only explicit `Collection` admits its expanded `Ids`
body parameter. Five TopLevel-default count groups retain ordinary no-selector ID
discrimination and need no additional flags.

Notes' reviewed three-operation groups retain Root List/Get and Nested List, but not the
nested item GET suppressed by the shared source. They use:

```csharp
new MultiRouteGroup(profile, reviewedSectionGroupRoutes, "Root", "Route")
{
    AllowAsymmetricRoutes = true,
    AllowExplicitRouteSelection = true,
    AllowPublishedParameterInference = true,
    IncludeDerivedSuppressedRoutes = profile == "v1.0",
}
```

The exact reviewed roots are `/groups/{group-id}/onenote/sectionGroups`,
`/sites/{site-id}/onenote/sectionGroups` and `/users/{user-id}/onenote/sectionGroups`.
For each root, the normal item path appends `/{sectionGroup-id}` and the nested collection
appends `/{sectionGroup-id}/sectionGroups`. The common parent ID remains publicly
mandatory; `SectionGroupId` is optional in the public binder but required by the Root Get
and Nested List workers. Parent ID alone selects Root List. IDs alone prefer Root Get.
IDs plus a list-only parameter such as `All` or `Top` can infer the unique Nested List
only because Published inference is explicitly enabled. Explicit Root/Nested never falls
back to the other family.

`IncludeDerivedSuppressedRoutes` corrects the demonstrated first-URI-only v1.0 data loss
for these exact Nested Lists. It does not modify frozen JSON, affect a different route,
override naming precedence, or reintroduce the curated nested item GET.

### Mixed resource/function reads: Teams aggregate default

The reviewed Teams family is exactly the resource List/Get at
`/users/{user-id}/chats/{chat-id}/messages[/{chatMessage-id}]` plus the zero-argument
function `/users/{user-id}/chats/getAllMessages()`. The module's existing naming directives
must already map all three to the same public command. Its group labels the function
`Aggregate` and the resource pair `Chat`, with `DefaultRoute: "Aggregate"` and `"Route"`
as selector, and enables:

```csharp
AllowMixedReadOperations = true,
AllowZeroArgumentFunctions = true,
AllowAsymmetricRoutes = true,
AllowExplicitRouteSelection = true,
AllowPublishedParameterInference = true,
```

The group uses the same public `Route` parameter-set policy. `UserId` is shared and
mandatory. The Aggregate default requires no Chat ID; bound `ChatId`/`ChatMessageId` can
infer the unique Chat List/Get without discarding those IDs. Explicit Chat requires its
IDs. Explicit Aggregate with a Chat ID, or Chat with Aggregate-only `Model`, fails.

This allowance is not general mixed-kind generation: it requires exactly one paged
zero-argument function and its resource list/item family, no request body or function
header, matching shared query contracts, and the same emitted entity type. Only the
reviewed optional string `model` query may differ. The function reuses the typed list
worker with its actual wrapped-response method, `GetAsGetAllMessagesGetResponseAsync`,
preserving `All`, total `Top` caps, item streaming, headers and `@odata.nextLink`.
`Model` and other queries bind only the first request; continuation URLs carry their own
query state. In v1.0 an exact reviewed `IncludeDerivedSuppressedRoutes` opt-in retains the
aggregate URI otherwise lost by frozen first-URI suppression data.

### Users media: singleton photo default and alternate photo ID

GET and DELETE are separate exact two-route groups over
`/users/{user-id}/photo/$value` (`Singleton`, default) and
`/users/{user-id}/photos/{profilePhoto-id}/$value` (`Photos`), each enabling only
`AllowMediaRoutes = true`. No selector is needed: `ProfilePhotoId` selects the alternate;
the published singleton default remains unchanged.

GET reuses the existing typed stream worker: optional `OutFile` writes the bytes to a file,
and omission returns bytes as in the existing wrapper media contract. Streams are disposed;
the new opted-in request uses the inherited stopping token. DELETE retains its no-body,
If-Match, ShouldProcess and error behavior. This policy is not a reference DELETE, does not
enable arbitrary media shapes or queries, and does not broaden metadata-photo suppressions.

### Ordinary Users sponsor reference: published `Id`, not a fake route group

After the module's exact published item-noun repair, the root sponsor reference command
is a separate single operation and must not be merged with that item command:

```csharp
BindReferenceDeleteQuery(
    new ReferenceDeleteQueryBinding("v1.0", "/users/{user-id}/sponsors/$ref", "Id"),
    "Published root Delete requires UserId and the Id delete URI.")
```

The beta entry is identical with `"beta"` as API version. This factory returns an entry
in the existing module configuration array. It declares only the exact reviewed ordinary
DELETE `/$ref` mapping: the actual operation must have exactly one required plain-string
`@id` query, no body/success payload, and no inherited unbound query/header. Public `Id`
is mandatory and maps to Kiota's typed `Id` query field. Other parameter names, normalized
`{}` placeholders, duplicate/overlapping registrations and unsafe name/alias conflicts
fail explicitly. An overlapping multi-route group is invalid; no one-member group,
invented noun, `MemberReferenceUri` alias or general query translation is introduced.
Unconfigured ordinary deletes remain unchanged, and a configured suppressed target fails
rather than silently losing its required input. Focused engine callers can supply
`GeneratorConfig.ReferenceDeleteQueryBindings`; module entries are read through
`CmdletConfigurator.GetReferenceDeleteQueryBindings`.

### CloudCommunications beta: required selection when the old default is unavailable

The independently pinned official 2.38.0 proxy and compiled dispatch prove that the old
recording GET default (`Get2`) is an aggregate `getAllRecordings` function, not one of the
three colliding recording routes. Its current COMM form uses three undeclared `@` alias
arguments and remains baseline-unsupported. The USER aggregate is intentionally removed
by immutable shared directive #5. These are **different reasons** for unavailability;
neither permits restoring the suppressed operation, guessing an alias binding, or calling
one of the remaining endpoints the old published default.

For the two reviewed beta groups only, the surviving resource GETs have explicit plans:

```csharp
MergeRoutes(new MultiRouteGroup("beta",
[
    new("GET", binarySingletonPath, "Binary") { ReadKind = MultiRouteReadKind.Binary },
    new("GET", jsonCollectionPath, "Recordings") { ReadKind = MultiRouteReadKind.List },
    new("GET", jsonItemPath, "Recordings") { ReadKind = MultiRouteReadKind.Item },
], DefaultRoute: "", SelectorParameter: "Route")
{
    AllowMixedMediaReads = true,
    RequireExplicitRoute = true,
    AllowAsymmetricRoutes = true,
    AllowExplicitRouteSelection = true,
    AllowResponseUnion = true,
}, "Old Get2 unavailable: COMM unsupported aliases; USER shared-source suppression.")
```

The exact parents are `/communications/onlineMeetings/{onlineMeeting-id}` and
`/users/{user-id}/onlineMeetings/{onlineMeeting-id}`. Binary appends `/recording`; JSON
collection appends `/recordings`; JSON item additionally appends `/{callRecording-id}`.
`MultiRoute.ReadKind` defaults to `Auto` for every existing group and is otherwise allowed
only by this narrowly reviewed policy. It must agree with the actual response contract.
All three methods remain resource GETs; aggregate functions are not members.

This is an explicitly documented **beta deviation**: `Route` is mandatory and accepts
only `Binary` or `Recordings`, case-insensitively. There is no `Published` option,
initializer, implicit endpoint default, inference or fallback. The empty constructor
`DefaultRoute` represents absence of a default, not a Binary default. Omission fails
before any worker or authentication; passing `Published` fails validation.

Binary selects the typed stream worker, returning bytes or writing optional `OutFile`,
with stream disposal and request cancellation. It accepts no JSON query options or
recording ID. Recordings selects the typed JSON list when no recording ID is bound, or
the typed JSON item when it is. Only JSON List accepts paging/list options; JSON Item
accepts select/expand. `OutFile` is rejected for either JSON role, and item IDs combined
with list-only options fail rather than being ignored. Public output metadata is the
explicit bytes/recording-model union; all three exact routes retain metadata.

The policy requires the demonstrated optional OData query sets and compatible shared
parent IDs, no request body or declared operation headers, and no derived-suppression
bypass. Generic caller `Headers` still forwards to every selected worker. Existing
optional Published groups, homogeneous `/$value` groups, alias guards and curated
suppression priority are unchanged.

### Published Bookings defaults

The module owner's reviewed beta evidence covers 53 pairs / 106 operations in 45 public
groups (eight list/item groups and 37 two-operation groups, including eight scalar counts).
Fifty operation pairs publish the legacy default; three actions publish the `/solutions`
default: appointment `cancel`, calendarView `cancel`, and `getStaffAvailability`.
Those three action groups must specify `DefaultRoute: "Solutions"`; the remaining groups
use `"Legacy"`. `-Route Published` preserves this distinction while both explicit routes
remain reachable. These are module-owned opt-ins, not a generator hard-coded route list.

### Route evidence and focused gates

`GraphRouteAttribute` permits multiple attributes. Every public multi-route dispatcher
carries all reachable method/path pairs with their public `ParameterSetName`, and each
worker carries its own single route.
The source operation inventory and output manifest retain every attribute, including
alternatives; compiled name parity checks every worker against the public name.
The metadata oracle's first-URI-only limitation is **not** evidence that a secondary route
does not exist and must not be used to suppress it.

`MultiRouteTests` covers generation and rejection boundaries. After building the generator,
`tools\Test-WrapperMultiRouteDispatcher.ps1` compiles emitted dispatchers against the shared
runtime inside real PowerShell and
exercises selector defaults, parent-ID sets, binding rejection and parameter forwarding with
recording workers, without Graph requests. `tools\Test-WrapperRouteMetadata.ps1` exercises
multi-attribute inventory/manifest evidence and compiled parity joins.
The additional `Test-WrapperAsymmetricRoutes.ps1`, `Test-WrapperRouteSpecificActions.ps1`,
and `Test-WrapperReferenceDelete.ps1` gates compile real emitted dispatchers against the
shared runtime and exercise the reviewed positive/negative binding cases without Graph
requests. `ReviewedRouteExtensionTests` and `ReferenceDeleteTests` pin the new opt-ins and
their rejection boundaries; the original group defaults and collision tests still run.
`Test-WrapperExplicitRouteSelection.ps1` covers strict Security defaults and separately
enabled Notes inference. `Test-WrapperMediaRoutes.ps1`, `Test-WrapperMixedReadRoutes.ps1`
and `Test-WrapperOrdinaryReferenceDelete.ps1` accept a compiled typed fixture assembly
(`-FixtureAssembly`) and use only local/mock requests: media bytes/OutFile, disposal,
errors/cancellation; aggregate Model/paging/headers and inference; and the exact ordinary
`Id`/`@id` contract. They do not require tenant data or make Graph network calls.
`Test-WrapperRequiredMediaRoutes.ps1` and the actual-client
`Test-WrapperMixedMediaReads.ps1 -FixtureAssembly <dll>` gate pin the beta required-choice
deviation: no omitted/Published route, no worker on invalid parameters, real binary/JSON
requests, paging, OutFile/bytes, disposal, cancellation and truthful output metadata,
without live Graph calls.

## Group photo: `/photo` vs `/photos`

- **Class:** crosspath-merge
- **Status:** workaround (singleton kept, collection deferred)
- **Evidence:** oracle ships `Get-MgGroupPhoto` for both `GET /groups/{id}/photo` and
  `GET /groups/{id}/photos`; `/photos/{id}` ships nothing. Mirrors the `/users/{id}/photo(s)`
  pair already curated through `CmdletConfigurator`.
- **Decision:** generate from the `/photo` singleton (the primary published variant); defer
  `/photos` (the all-sizes collection) until parameter sets can put both URIs behind one
  cmdlet.
- **Migration impact:** `Get-MgGroupPhoto` exists with identical name; listing all photo
  sizes via `-All`-style enumeration is not available until the deferral lifts.
- **References:** `data/collision-suppressions.v1.0.json` (`GET /groups/{}/photos`),
  DerivedCollisionResolutionsTests.

## Shared list items: `/listItem` vs `/list/items`

- **Class:** crosspath-merge
- **Status:** workaround (singleton kept, collection deferred)
- **Evidence:** oracle ships `Get-MgShareListItem` for both `GET /shares/{id}/listItem` and
  `GET /shares/{id}/list/items`; the bare `/list/items/{id}` item GET ships nothing (curated
  suppression, `CmdletConfigurator`).
- **Decision:** generate from the `/listItem` singleton; defer the `/list/items` collection.
- **Migration impact:** `Get-MgShareListItem` exists with identical name; enumerating a
  shared list's items through this cmdlet is not available until the deferral lifts.
- **References:** `data/collision-suppressions.v1.0.json` (`GET /shares/{}/list/items`),
  DerivedCollisionResolutionsTests.

## Status summary

| Case | Class | Status |
|---|---|---|
| `/groups/{id}/photo` vs `/photos` | crosspath-merge | workaround |
| `/shares/{id}/listItem` vs `/list/items` | crosspath-merge | workaround |
