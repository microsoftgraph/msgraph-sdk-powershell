# Reports

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Reports v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Wrapper migration: DeferredParameter. The Period completer remains AutoRest-only;
# parameter/schema behavior is outside this cmdlet-surface migration.
  - where:
      parameter-name: Period
    set:
      completer:
        name: Period Completer
        description: Gets the list of Period values.
        script: "'D7', 'D30', 'D90', 'D180'"
# Remove invalid paths.
# Wrapper migration: exact surviving method/path operations are suppressed in
# Reports_cmdletConfigurations.cs. ReportsDirectiveSourceReview.json in the generator
# tests records the complete original match set (beta: 66 survivors, 18 pruned routes).
# After #3861 aligned IDs, the unchanged regex literally also selects 17 additional
# beta resource mutations; each is separately justified in that test fixture. The
# baseline inventory validates every current match (v1.0: 34; beta: 83).
# Use exact entries, not broad root prefixes. Keep all AutoRest directives active.
  - remove-path-by-operation: auditLog\.auditLogRoot.*|report.reportRoot.*|(auditLog|report)_(Create|Delete|Update).*
# Remove cmdlets
# Wrapper migration: reviewed absence in both compatible and legacy Reports specs.
# The POST getCertificatesReport action is a different operation and remains.
  - where:
      verb: Get
      subject: ^ReportTenantSecureScore$|^DeviceManagementReportCertificateReport$
    remove: true
# Wrapper migration: functions already use Get; curated nouns preserve the shared
# singular TopFailure name and distinguish the parameterized overload. Checked-in
# v1.0 derived overload rows do not match normalized parameter placeholders;
# both actual overload routes remain, without changing the shared derived data.
  - where:
      verb: Invoke
      subject: ^TopReport$
    set:
      verb: Get
      subject: ReportManagedDeviceEnrollmentTopFailure
# Wrapper migration: StructuralNaming already supplies Get and the two
# ReportDeviceConfiguration*Activity nouns; no redundant overrides.
  - where:
      verb: Invoke
      subject: ^(Device)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
# Wrapper migration: exact failure/abandonment detail function nouns are curated;
# distinct failure-details overloads are not treated as duplicate operations.
  - where:
      verb: Invoke
      subject: ^(Detail)Report(.*)$
    set:
      verb: Get
      subject: Report$2$1
# Wrapper migration: exact beta abandonment summary and failure trend nouns are
# curated. These operations are absent from v1.0, not owned by a revived Actions module.
  - where:
      verb: Invoke
      subject: ^(Managed)Report(.*)$
    set:
      verb: Get
      subject: Report$1$2
# Wrapper migration: StructuralNaming retains InDetailedSummary for collection
# and item operations. Mutations remain suppressed by the shared path directive;
# the separate Count neighbor stays structurally named.
  - where:
      subject: ^(ReportApplicationSign)$
    set:
      subject: $1InDetailedSummary
# Wrapper migration: the sole beta function receives the shared AzureAd noun,
# including the InSummary suffix; no matching v1.0 operation exists.
  - where:
      subject: ^(ReportAzureAdApplicationSign)$
    set:
      subject: $1InSummary
```
