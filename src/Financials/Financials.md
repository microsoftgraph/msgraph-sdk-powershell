# Financials

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Financials v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

### Wrapper migration audit

The shared source below contains no cmdlet suppressions or renames and no deferred
parameter aliases/transforms or schema/response directives. The empty `mappings`
array in `wrapper/Financials_directiveMigrationMap.json` records that review.
There is no selector to translate or legacy match set to migrate.

Separately, the user explicitly excluded cmdlet generation for the three exact
beta URI paths ending in the literal segment `/post`: journal, purchase-invoice,
and sales-invoice item actions. These are path-specific exclusions, **not** a
blanket exclusion of HTTP POST operations. All 47 other POST operations,
including collection creation and `/postAndSend`, remain enabled. The OpenAPI
inputs and Kiota client routes are unchanged. This new user decision is recorded
as audit context, not fabricated as an original shared-directive mapping.

Separately, `Financials_cmdletConfigurations.cs` preserves the published
multi-route surface using nine shared, profile-neutral natural-ID groups (23
operations). Root list defaults remain unchanged; nested alternatives use
DimensionId, JournalId, or ItemId. The official beta 2.38.0 proxy parameter sets
prove these alternatives; command metadata alone retains only the first URI.
PATCH and DELETE on `items/{item-id}/itemCategory` cannot share a minimal default
ID set with `itemCategories/{itemCategory-id}`. They therefore use the explicit
`FinancialCompanyItemCategoryByItem` noun rather than dropping an endpoint or
adding a selector parameter. These two intentional names differ from the
published command's numbered parameter sets; other names are unchanged.

PATCH commands issue only their selected mutation. A successful 204 response
returns no object and does not trigger a GET; a 200 response returns its actual
typed model without another request. Callers can explicitly invoke the
corresponding GET with its own headers and queries when they need a read.
There is no readback switch or GET-derived input on PATCH.

Only `openApiDocs_KiotaCompat/beta/Financials.yml` is compatible with this migration.
v1.0 is excluded because it has no compatible specification; the legacy OpenAPI
directory is not a fallback. `src/readme.graph.md` and all profile-local readme
directives are explicitly outside this audit and remain unchanged.

`FinancialsDirectiveMigrationTests` pins real beta operation identities, legacy
lineage for every configured route, derived-data-on/off behavior, all grouped
alternatives, single-operation PATCH generation and unaffected neighboring routes. These
targeted tests do not establish full Kiota generation, module build, or nonzero
compiled exports; those remain a separate beta generation gate.

``` yaml
# Directives go here!
```
