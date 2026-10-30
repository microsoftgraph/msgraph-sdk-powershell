# Bookings

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Bookings v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The three shared cmdlet directive groups below have been audited against the v1.0
and beta Kiota-compatible specifications. Exact reviewed evidence is recorded in
`wrapper/Bookings_directiveMigrationMap.json`; `BookingsDirectiveMigrationTests`
pins the existing curated behavior without adding redundant overrides.
The root suppression's original IDs are checked against both historical and
compatible specs. The current compatible refresh preserves PowerShell operation
IDs, so the exact root IDs now match the original selector directly.

Profile-local directives in `v1.0/readme.md` and `beta/readme.md`, all other
profile-local readme directives, and `src/readme.graph.md` are explicitly outside
this migration. Parameter aliases/transforms and schema/response directives remain
deferred; none occur in these three shared groups. Keep the AutoRest directives
active until the service-module pipeline is retired.

Microsoft [retired the root-level Bookings beta routes on 2024-04-30](https://devblogs.microsoft.com/microsoft365dev/breaking-changes-in-microsoft-bookings-graph-apis-beta/).
`wrapper/Bookings_cmdletConfigurations.cs` suppresses cmdlet generation for
`/bookingBusinesses`, `/bookingCurrencies`, and their descendants in beta only,
even without upstream deprecation annotations. Their `/solutions/...` successors
remain active, and v1.0 behavior is unchanged. This is a cmdlet policy, not an
OpenAPI filter: the compatible beta input and generated Kiota HTTP client retain
the legacy routes. The generic pruner removes only annotated expired operations.
Historical source specs and directives remain intact. Historical command metadata
is not evidence that a retired route is still supported; no legacy cmdlet route
selector is exposed.

``` yaml
directive:
# Remove invalid paths.
# Wrapper audit: this selector matches GET/PATCH /solutions in both legacy source
# specs and the current compatible specs, which preserve the original IDs.
# Existing exact root suppression covers both operations; this is not API absence.
  - remove-path-by-operation: ^solution\.solutionsRoot.*$
# Remove cmdlets
# Wrapper audit: existing exact /solutions/virtualEvents suppression covers GET,
# PATCH, and DELETE in both profiles. Child event/webinar routes remain active.
  - where:
      subject: ^(.*)VirtualEvent$
      variant: ^Get$|^Delete$|^Update$|^UpdateExpanded$
    remove: true
# Rename cmdlets
# Wrapper audit: the existing /solutions/ StripNounPrefix configuration supplies
# this rename. The reviewed ledger enumerates every compatible child operation;
# the existing BackupRestore exception is retained and regression-tested.
  - where:
      subject: ^Solution(.*)$
    set:
      subject: $1
```
