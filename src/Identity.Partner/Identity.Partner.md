# Identity.Partner shared-directive migration audit

## Reviewed scope

The shared file `src\Identity.Partner\Identity.Partner.md` did not exist at
baseline `51d441eeb5`. This file records the audit; it introduces no AutoRest
directives. There are no shared cmdlet suppressions, subject renames, or verb
renames to migrate.

`wrapper\Identity.Partner_cmdletConfigurations.cs` already contains an empty
configuration list and remains unchanged. The adjacent
`wrapper\Identity.Partner_directiveMigrationMap.json` deliberately contains an
empty `mappings` array: the operation evidence below describes unchanged
behavior, not mappings for nonexistent source directives.

All profile-local readmes, including `v1.0\readme.md` and `beta\readme.md`, and
`src\readme.graph.md` are explicitly outside this audit. They are not sources
for overrides, mappings, or suppression assertions.

## Legacy configuration compatibility

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

This is the existing `tools\Templates\module.md` default configuration include.
`Copy-ModuleTemplate` creates that default only when the shared file is absent,
so this audit file must retain the include to preserve legacy configuration
wiring. The global file and its directives remain unchanged and ignored by
this migration; this include adds no module directive entries or v3 overrides.

## Compatible specification evidence

Both required profiles are present; neither is excluded. Only the
`openApiDocs_KiotaCompat` specifications were used, without a legacy fallback.
The coordinator's generation-manifest pins match these Git blobs:

| Profile | Compatible specification | Git blob | Paths | Operations |
| --- | --- | --- | --- | --- |
| v1.0 | `openApiDocs_KiotaCompat\v1.0\Identity.Partner.yml` | `dfd2f6ce01e4834a667c80af1052423e765c1eb8` | 18 | 36 |
| beta | `openApiDocs_KiotaCompat\beta\Identity.Partner.yml` | `bde85e06a46e09328344c9fda3728b513d29c298` | 18 | 36 |

The six collection/item/count route families below exist in both compatible
profiles. Each collection has GET/List and POST/Create; each item has GET/Get,
PATCH/Update, and DELETE/Delete. Each collection's `/$count` has GET. Operation
IDs are checked exactly, including the count suffixes, by the module-specific
regression tests.

| Collection path | Operation-ID prefix | Resource suffix | Count operation-ID suffix |
| --- | --- | --- | --- |
| `/tenantRelationships/delegatedAdminCustomers` | `tenantRelationships.` | `DelegatedAdminCustomers` | `delegatedAdminCustomers.GetCount-e293` |
| `/tenantRelationships/delegatedAdminCustomers/{delegatedAdminCustomer-id}/serviceManagementDetails` | `tenantRelationships.delegatedAdminCustomers.` | `ServiceManagementDetails` | `serviceManagementDetails.GetCount-d662` |
| `/tenantRelationships/delegatedAdminRelationships` | `tenantRelationships.` | `DelegatedAdminRelationships` | `delegatedAdminRelationships.GetCount-9d12` |
| `/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/accessAssignments` | `tenantRelationships.delegatedAdminRelationships.` | `AccessAssignments` | `accessAssignments.GetCount-8cbf` |
| `/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/operations` | `tenantRelationships.delegatedAdminRelationships.` | `Operations` | `operations.GetCount-3beb` |
| `/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/requests` | `tenantRelationships.delegatedAdminRelationships.` | `Requests` | `requests.GetCount-f3a6` |

For example, GET `/tenantRelationships/delegatedAdminRelationships` is
`tenantRelationships.ListDelegatedAdminRelationships` and retains the
structural name `Get-MgTenantRelationshipDelegatedAdminRelationship`.
PATCH and DELETE on its item route retain `Update-` and `Remove-`.
Neighboring customer, service-management-detail, access-assignment, operation,
request, and count routes remain unsuppressed and structurally named. Existing
curated and derived configuration does not override these operations in either
profile; no redundant overrides were added.

## Deferred directive classes

Parameter aliases/transforms and schema/response directives remain **Deferred**
and are not implemented by this cmdlet-only migration. None existed in the
absent shared source; this does not reclassify or migrate directives from
excluded readmes.

## Regression coverage and generation boundary

`tools\WrapperGenerator.Tests\IdentityPartnerDirectiveMigrationTests.cs` reads
both real compatible specifications. It pins all 36 method/path/operation-ID
triples per profile, their structural CRUD/count names, and the absence of
suppression, noun overrides, and verb overrides with curated-only and normal
derived configuration. It also checks that this audit has no directive block
and the reviewed mapping ledger is empty.

The strict shared-directive inventory must return zero rows with
`-Module Identity.Partner -FailOnUnresolved`. This is a no-directive audit, not a
claim of renamed or suppressed operations.

This audit does not claim fresh generation or Release-build completion. Those
are separate gated steps for both profiles. Subsequent generation must preserve
the committed output directory casing: `wrapper\v1.0` and `wrapper\Beta`.
