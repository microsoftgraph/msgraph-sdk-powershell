# Naming edge cases

This folder is the wrapper generator's edge-case catalog: one Markdown file per **class** of
issue, each entry written with the same fixed fields so the files stay cheap to maintain and
trivial to convert to JSON for automated processing. This file covers the first class:
**cmdlet-naming defects** — cases where the published Microsoft.Graph name is an artifact of
the previous generator (AutoRest) rather than the name the conventions would produce.

Two policies govern the entries (agreed 2026-08-03/04, wrapper-generator review + sync):

- **Obviously wrong published names are corrected, not reproduced.** The shipped SDK is the
  baseline, not 100% ground truth. Each correction is a deliberate, documented break from
  parity.
- **Corrected names ship without a back-compat alias for the old name.** Documenting the
  change here and in the migration guide is the agreed mechanism; the generator does not emit
  the wrong name in any form.

## How to add an entry

A correction lands as four pieces together:

1. **Fix** — the naming rule change (or, as with Whois, confirmation that the existing rules
   already produce the correct name).
2. **Pinned test** — a row in `AppliesDeliberateNameCorrections` (NamingTests.cs) so the
   corrected name cannot regress silently. Parity-preserving edge cases go in the regular
   pinned tests instead.
3. **Gate entry** — a row in `$deliberateCorrections` in `tools/Compare-WrapperCmdletNames.ps1`
   mapping the shipped name to the corrected one, so the parity gate reports `[CORRECTED]`
   instead of failing.
4. **Catalog entry** — a section below using the fixed field template.

Entry template (keep the field names exact so the file converts cleanly):

```
## <short case name>
- **Class:** <inflection-defect | operationid-truncation | hand-rename | ...>
- **Status:** <corrected | reproduced-for-parity | structurally-avoided | not-yet-reachable>
- **Evidence:** <what the oracle/spec shows>
- **Decision:** <what the generator does and why>
- **Migration impact:** <what breaks for users, if anything>
- **References:** <issues, commits, docs>
```

## Status summary

| Case | Class | Status |
|---|---|---|
| `HostWhoi` → `HostWhois` | inflection-defect | corrected |
| `PlaceCheck` → `PlaceCheckIn` | operationid-truncation | corrected |
| operationId preposition truncation | operationid-truncation | structurally-avoided |
| `SkypeForBusiness` subject truncation | operationid-truncation | not-yet-reachable |
| `Cookies`/`Skus`/`Dns`/`Ios`/`Statistics` quirks | inflection-defect | reproduced-for-parity |

## Whois truncated to Whoi on the host navigation

- **Class:** inflection-defect
- **Status:** corrected
- **Evidence:** `GET /security/threatIntelligence/hosts/{host-id}/whois` shipped as
  `Get-MgSecurityThreatIntelligenceHostWhoi` (v1.0 and beta): AutoRest's inflector treated the
  trailing `whois` segment as a plural and stripped the `s`. The shipped SDK is inconsistent
  with itself — the other 28 whois-family commands in MgCommandMetadata.json
  (`.../whoisRecords`, `.../whoisHistoryRecords`, and their children) all keep **Whois**
  intact, e.g. `Get-MgSecurityThreatIntelligenceWhoisRecord`.
- **Decision:** emit `Get-MgSecurityThreatIntelligenceHostWhois` / `Get-MgBetaSecurityThreatIntelligenceHostWhois`.
  The singularizer's `is`-guard (the rule that keeps Access/Status/Analysis) already produces
  `Whois`, so no rule change was needed — the corrected behavior is pinned rather than coded.
- **Migration impact:** scripts calling `Get-MgSecurityThreatIntelligenceHostWhoi` must add the
  trailing `s`; no alias is emitted for the old name. Belongs in the migration guide when the
  Security module is generated for real.
- **References:** pinned in `AppliesDeliberateNameCorrections` (NamingTests.cs); gate rows in
  `$deliberateCorrections` (Compare-WrapperCmdletNames.ps1).

## CheckIns truncated to Check on the places API

- **Class:** operationid-truncation
- **Status:** corrected
- **Evidence:** `/places/{place-id}/checkIns` shipped as `{Get,New,Update,Remove}-Mg(Beta)PlaceCheck`
  (8 commands) — AutoRest truncated "CheckIns" at the preposition "In", the #912 defect
  class. The SDK is inconsistent with itself: `Get-MgPlaceCheckInCount` (the `$count` path)
  keeps "In" intact. Found by the parity gate during the full-inventory module fan-out.
- **Decision:** emit `...PlaceCheckIn` for all four verbs, v1.0 and beta; no alias for the
  old names. Pinned in `AppliesDeliberateNameCorrections`; gate rows in
  `$deliberateCorrections`.
- **Migration impact:** scripts using `*-MgPlaceCheck` must switch to `*-MgPlaceCheckIn`.
  Belongs in the migration guide when the Calendar module ships for real.
- **References:** issue [#912](https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/912)
  (the AutoRest defect class).

## operationId preposition/linking-verb truncation

- **Class:** operationid-truncation
- **Status:** structurally-avoided
- **Evidence:** AutoRest built cmdlet names from **operationIds** and truncated them at
  prepositions and linking verbs, so ids like `...ByRef...` lost everything after the
  preposition. The SDK worked around it with hand-written rename directives per affected
  command.
- **Decision:** no mitigation needed for path-derived nouns — this generator never reads the
  operationId; nouns come from URL path segments (CmdletNaming.cs), so the defect class cannot
  occur there. Two watch items: (a) **OData actions/functions** (not yet generated) take their
  names from an operationId-like segment (`microsoft.graph.assignLicense`,
  `getSkypeForBusiness...`) — when that support lands, word-splitting must not treat
  prepositions as truncation points; (b) path segments that legitimately contain prepositions
  (`termsAndConditions`) are already pinned — the singularizer inflects per word and keeps the
  `And` (`TermAndCondition`).
- **Migration impact:** none today.
- **References:** issue [microsoftgraph/msgraph-sdk-powershell#912](https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/912),
  PR [#915](https://github.com/microsoftgraph/msgraph-sdk-powershell/pull/915).

## SkypeForBusiness subject names

- **Class:** operationid-truncation
- **Status:** not-yet-reachable
- **Evidence:** historically AutoRest truncated subjects containing `SkypeForBusiness` at the
  `For`. The shipped names are correct today
  (`Get-MgReportSkypeForBusinessActivityUserDetail`, etc.), so there is nothing to correct —
  but every affected endpoint is an OData function
  (`/reports/getSkypeForBusinessActivityCounts(period='{period}')`), a shape this generator
  does not emit yet.
- **Decision:** when function support is implemented, add pinned tests for the
  `SkypeForBusiness` family so the `For` survives word-splitting.
- **Migration impact:** none.
- **References:** [Azure/autorest.powershell#795](https://github.com/Azure/autorest.powershell/issues/795).

## Inflection quirks reproduced for parity

- **Class:** inflection-defect
- **Status:** reproduced-for-parity
- **Evidence:** auditing every v1.0 GET in MgCommandMetadata.json against the singularizer
  surfaced four words where shipped names disagree with naive inflection rules: `Cookies` →
  `Cookie` (not `Cooky`), `Skus` → `Sku` (despite the `us`-guard), and `Dns`/`Ios` kept as-is.
  A fifth, `Statistics`, came from cross-checking the DEVX API's Humanizer exception list:
  the shipped SDK keeps it intact everywhere, including as an interior word
  (`Get-MgSecurityCaseEdiscoveryCaseSearchLastEstimateStatisticsOperation`,
  `Get-MgBetaUserActivityStatistics`), where the plain s-drop rule would have produced
  `Statistic`.
- **Decision:** these shipped names are *reasonable*, just not what naive rules produce, so the
  generator reproduces them via the irregulars/invariants tables in Singularizer.cs. The
  README's rule table cites the proving cmdlet for each.
- **Migration impact:** none — these are parity-preserving.
- **References:** commit `a429b5999c`; Singularizer.cs `Irregulars`/`Invariants`; the DEVX
  API's Humanizer vocabulary in `OpenAPIService/PowershellFormatter.cs` (private
  `microsoftgraph/microsoft-graph-devx-api` repo) — its five entries are `drives→drive`,
  `data`, `delta`, `quota` (Humanizer-specific mistakes this rule engine never makes) and
  `statistics` (the one that applied here).

## Watch list

Cases spotted but deliberately not acted on yet, so they aren't lost:

- **bare `rights` (beta-only):** "Rights" is now an invariant — v1.0 evidence arrived via
  `subjectRightsRequests` (42 cmdlets ship keeping "Rights"; `usageRights` in beta agrees).
  The one holdout is beta's bare `.../sensitivityLabels/{id}/rights`, which ships
  singularized (`...SensitivityLabelRight`) and now diverges from our invariant. Beta-only,
  4 cmdlets; resolve at the beta parity audit (likely a correction or a path override).
