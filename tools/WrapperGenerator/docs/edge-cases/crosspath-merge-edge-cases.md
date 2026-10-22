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
the group never renames or unsuppresses an operation. `GeneratorConfig.MultiRouteGroups`
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
bindings; continuation links retain their query state and headers. Other extra query types,
functions/delta, media, and reference operations are rejected rather than guessed.

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
