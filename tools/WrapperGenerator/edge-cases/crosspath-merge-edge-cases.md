# Cross-path variant merge edge cases

This file covers one class of issue: **cross-path variant merges** — cases where the
published SDK serves ONE cmdlet from several unrelated request URIs, as AutoRest parameter-set
variants. The wrapper generator emits one cmdlet per route (plus the list/item dispatcher), so
it cannot express these yet; the resolution policy is deterministic deferral. The derivation
sweep of every v1.0 collision route (`tools/Derive-CollisionResolutions.ps1`, ledger in
`artifacts/collision-resolution-ledger.v1.0.csv`) found exactly two.

**Policy:** among same-command routes, the shallowest list/item pair survives (fewest path
parameters; tie broken by shortest, then ordinal — fully deterministic); the other routes are
suppressed with `deferredCrossPathMerge: true` in `data/collision-suppressions.v1.0.json`.
They come back when cross-path parameter sets are implemented (tracked with the operation
shapes / parameter-set work).

## Group photo: `/photo` vs `/photos`

- **Class:** crosspath-merge
- **Status:** workaround (singleton kept, collection deferred)
- **Evidence:** oracle ships `Get-MgGroupPhoto` for both `GET /groups/{id}/photo` and
  `GET /groups/{id}/photos`; `/photos/{id}` ships nothing. Mirrors the `/users/{id}/photo(s)`
  pair already curated in `NamingOverrides.cs`.
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
  suppression, `NamingOverrides.cs`).
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
