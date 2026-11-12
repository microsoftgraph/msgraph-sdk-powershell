# DeviceManagement.Administration

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Administration v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The wrapper migration reviews only these shared cmdlet directives for v1.0.
The compatible beta specification is unavailable, so beta is explicitly excluded,
not classified as API absence. Profile-local readmes and `src/readme.graph.md` are
outside this review. Parameter aliases/transforms and schema/response directives
remain deferred; none occur in this shared file.

``` yaml
directive:
# Remove cmdlets.
# Wrapper migration: no groupPolicyMigrationReports operation exists in either
# actual v1.0 source specification. The adjacent wrapper migration ledger records
# this reviewed no-op, and DeviceManagementAdministrationDirectiveMigrationTests
# checks both specifications. Keep the AutoRest directive active.
  - where:
      verb: New
      subject: ^DeviceManagementGroupPolicyMigrationReport$
    remove: true
# Wrapper migration: no groupPolicyUploadedDefinitionFiles operation exists in
# either actual v1.0 source specification. The ledger records this reviewed no-op;
# the module regression tests pin the absence without claiming beta API absence.
  - where:
      verb: Remove
      subject: ^DeviceManagementGroupPolicyUploadedDefinitionFile$
    remove: true
# Wrapper migration: existing parity-suppressions.v1.0.json already suppresses
# POST/PATCH/DELETE on the auditEvents and cloudPCs collections/items (six exact
# operations). The selected audit-activity/source-image functions are GET-only,
# so New|Remove|Update does not select them. The ledger and module tests pin this
# coverage and preserve neighboring reads/actions; no duplicate overrides.
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint(AuditEvent|CloudPC|AuditEventAuditActivityType|DeviceImageSourceImage)$
    remove: true
# Wrapper migration: existing derived parity data suppresses the singleton's
# PATCH and DELETE. There is no POST in either v1.0 source. The ledger and module
# tests pin this exact scope while preserving GET and nested resource writes.
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint$
    remove: true
```
