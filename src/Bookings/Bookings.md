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

Profile-local directives in `v1.0/readme.md` and `beta/readme.md`, all other
profile-local readme directives, and `src/readme.graph.md` are explicitly outside
this migration. Parameter aliases/transforms and schema/response directives remain
deferred; none occur in these three shared groups. Keep the AutoRest directives
active until the service-module pipeline is retired.

``` yaml
directive:
# Remove invalid paths.
# Wrapper audit: the literal singular solution\.solutionsRoot selector matches no
# operation IDs in either compatible spec. Their actual root IDs begin with
# solutions.solutionsRoot; retain the existing exact /solutions suppression as
# compatibility behavior, not as a claimed literal-selector match.
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
