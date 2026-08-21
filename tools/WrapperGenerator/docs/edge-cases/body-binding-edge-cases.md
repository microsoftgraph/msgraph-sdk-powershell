# Body-binding edge cases

Request-body property shapes the generator classifies but does not bind. **Every shape reaching
the classifier now binds — the sweep reports 0 unbound properties across all 38 specs.** That is
a statement about the 8,164 operations (57.8% of 14,131) that generate: an operation refused
upstream — 767 suppressed because the published SDK ships no cmdlet, 5,200 unsupported shapes —
contributes no properties to any count in this file. What
remains here is one closed entry recording how the last gap was shut, and several classifications
with zero population that are retained deliberately: they exist so a future corpus change is
reported accurately instead of being silently mis-bound, and each is reported per property at
`--log-level Information` and counted by `tools/Measure-BodyPropertyCoverage.ps1`.

The type evidence and the policies behind what is bound live in
[../body-property-binding.md](../body-property-binding.md).

Entry template (keep field names exact so the file converts cleanly):

```
## <shape>
- **Class:** unsupported-shape
- **Status:** deferred | blocked | investigating
- **Counts:** <occurrences> occurrences / <distinct> distinct (v1.0, <date>)
- **Evidence:** <what the spec and the generated client show>
- **Why unsafe today:** <what would break if it were bound>
- **Intended representation:** <what binding it should look like>
- **Exit criteria:** <what has to be true to close it>
- **References:** <issue, code, tests>
```

## Untyped (`UntypedNode`) — CLOSED

- **Class:** unsupported-shape
- **Status:** closed 2026-08-13; kept as a record of how it was closed
- **Counts:** was 28 occurrences / 20 distinct (26 Files workbook internals — `maximum`,
  `minimum`, `majorUnit`, `minorUnit`, `value`, `values` — and 2
  `CrossDeviceExperiences.MgUserActivity.contentInfo`). Now **0**.
- **Evidence:** the schema carries no type, reference, enum or format at all — Graph writes these
  with only a `description` (`workbookChartAxis.maximum`) — and kiota emits `UntypedNode?`.
  `UntypedNode` is a non-abstract base with ten subclasses; PowerShell cannot convert to the base
  (`[UntypedNode]'hello'` fails), so the parameter could not be typed as the model member.
- **How it was closed:** the parameter binds as `object` and a shared `UntypedValue.From` helper
  in `Shared.g.cs` converts on assignment — string to `UntypedString`, integral to
  `UntypedInteger`/`UntypedLong`, fractional to `UntypedDouble`/`UntypedDecimal`/`UntypedFloat`,
  bool to `UntypedBoolean`, array to `UntypedArray`, hashtable recursively to `UntypedObject`.
  A `PSObject` wrapper is unwrapped first. An unrecognised CLR type throws with the type named
  rather than being stringified, so an unsupported value cannot be silently sent.
- **Null handling, and how much of it is parity.** The published SDK's `AddIf` helper
  (`src/<Module>/<version>/generated/runtime/Extensions.cs`) adds a value only when it is
  non-null **and not an empty JSON object**, and no model serializer has any explicit-null path —
  so `{"prop": null}` was never sendable from this SDK and clearing a field that way was never
  possible. Omitting a null and an empty hashtable is therefore parity. The *nested* rules are an
  extension: AutoRest applies `AddIf` at every level it generates, including per array element
  (`autorest.powershell/powershell/llcsharp/schema/array.ts:227,235`), but every AutoRest body is
  a generated type, so a caller-supplied untyped bag has no published analogue and no precedent
  for what a null inside it should do. Extending the same rule — dropping a nested null while its
  siblings survive, dropping a null array element, omitting an object whose members all drop out —
  is the wrapper's own documented contract, chosen for consistency and pinned by the runtime gate.
- **Verified:** 19 conversions runtime-tested by `tools/Test-WrapperModule.ps1` against each
  module's own compiled `UntypedValue` (reached by reflection, so the gate cannot drift from a
  copy of the converter), covering every branch: the seven numeric types, string, boolean,
  `PSObject` unwrapping, object, array, nesting, nested-null drop, null array element drop,
  empty-object omission, all-null-object omission, and the throw on an unsupported type. The
  helper is emitted into every module, so the gate reports `OK(19)` for all 35 that produce a
  manifest and treats a missing helper as a failure rather than N/A. Negative-tested: removing the
  empty-object omission from a
  module and rebuilding produced
  `FAILED: empty object omitted: sent UntypedObject; all-null object omitted: sent UntypedObject`.
- **References:** issue #3707; `UntypedValue` in `CmdletEmitter.EmitSharedAuth`;
  `SchemaProperties.UntypedProperty`.

## Genuine unions

- **Class:** unsupported-shape
- **Status:** deferred — zero population in v1.0
- **Counts:** 0. Before the numeric/INF family was bound this shape reported 56 occurrences /
  33 distinct; every one of them was that family, so nothing remains
  (`Measure-BodyPropertyCoverage.ps1`, 2026-08-12).
- **Evidence:** Graph's only union in the v1.0 corpus is a numeric with OData's `INF`/`NaN`
  string alternative, which kiota resolves to the numeric and which the generator now binds.
  A union whose branches are materially different schemas does not occur here — but the
  classification is retained so one would be reported rather than silently mis-bound.
- **Why unsafe today:** binding one arm silently commits the caller to a type the API may not
  want. Unlike the numeric family there is no branch kiota itself privileges, so there is no
  evidence for which arm is right.
- **Intended representation:** most likely a parameter per arm, or a single parameter typed as
  the shared base where one exists. Needs published-surface evidence before choosing.
- **Exit criteria:** the residual unions are enumerated, grouped by shape, and each group has a
  kiota member type that a chosen representation demonstrably matches.
- **References:** `UnsupportedShape.Union`; `SchemaProperties.TryMapNumericUnion`.

## Inline objects and inline enums

- **Class:** unsupported-shape
- **Status:** deferred — zero population **among the operations that generate**, which is not
  the same as zero in v1.0.
- **Counts:** 0 occurrences (`Measure-BodyPropertyCoverage.ps1`, 2026-08-12, all 38 specs).
- **Evidence:** the sweep produced no `InlineObject` or `InlineEnum` classification. For entity
  CRUD bodies that is a real property of the corpus: Graph declares those objects and enums as
  component `$ref`s, which is why referenced-type binding covers them.
- **Why the count is conditional:** action bodies are where Graph *does* write inline objects,
  and they never reach the property classifier — an action's `requestBody` is a `$ref` to a
  **requestBodies** component whose schema is an inline `type: object`, and the generator skips
  the whole operation first (1,528 POSTs corpus-wide, logged as `missing supported request JSON
  schema`). This population becomes non-zero the moment action generation lands.
- **Why unsafe today:** kiota synthesises a type name for an anonymous schema from its parent
  and property, and that name cannot be derived from the spec alone. Guessing it is the failure
  mode that produced 39 compile errors when numeric formats were first mapped.
- **Intended representation:** none required while the population is zero. The classifications
  are retained deliberately so a future spec shape is reported accurately instead of being
  mislabelled as something else.
- **Exit criteria:** revisit only if a corpus sweep reports a non-zero count — at which point
  the kiota name must be read from a generated client before any mapping is written.
- **References:** `UnsupportedShape.InlineObject`, `UnsupportedShape.InlineEnum`.

## Unknown string formats

- **Class:** unsupported-shape
- **Status:** deferred — zero population in v1.0
- **Counts:** 0 occurrences (`Measure-BodyPropertyCoverage.ps1`, 2026-08-12, all 38 specs);
  every format present in the corpus is mapped.
- **Evidence:** the format inventory across all v1.0 specs is `date-time`, `int32`, `int64`,
  `double`, `binary`, `base64url`, `uuid`, `time`, `date`, `duration`, `int16`, `float`,
  `uint8`, `decimal` — all mapped.
- **Why unsafe today:** an unmapped format bound as `string` would compile against whatever
  other CLR type kiota chose, or not compile at all. Reporting keeps the failure visible.
- **Exit criteria:** a new format appears in a sweep; its kiota member type is read from a
  generated client and added to the mapping with a pinned test.
- **References:** `UnsupportedShape.UnknownFormat`; `SchemaProperties.StringFormatTypes`.

## Dictionaries (`additionalProperties`)

- **Class:** unsupported-shape
- **Status:** deferred — zero population in v1.0
- **Counts:** 0 occurrences (`Measure-BodyPropertyCoverage.ps1`, 2026-08-12, all 38 specs).
- **Evidence:** no property classified as `Dictionary` in the sweep. Free-form
  bags in Graph reach the caller through the `additionalData` member instead, which is excluded
  by policy.
- **Why unsafe today:** untested; kiota's representation of an open map property has not been
  observed in a generated client here, so any mapping would be a guess.
- **Exit criteria:** a non-zero count, then the same read-it-from-the-client procedure.
- **References:** `UnsupportedShape.Dictionary`; `ExclusionPolicy.KiotaAdditionalData`.

## Unresolvable references and untyped arrays

- **Class:** unsupported-shape
- **Status:** deferred — zero population in v1.0
- **Counts:** 0 occurrences (`Measure-BodyPropertyCoverage.ps1`, 2026-08-13, all 38 specs).
- **Evidence:** three distinct situations share this classification — an array whose `items`
  schema is absent, a `$ref` whose target is not in the document, and a `$ref` to a bare scalar
  that has no kiota type of its own. None occurs in the corpus.
- **Why unsafe today:** unlike a schema-less property, which reliably generates as
  `UntypedNode` and can therefore be bound, these have no predictable kiota member type at all.
  A broken reference in particular is a spec defect; binding past it would hide the defect.
- **Exit criteria:** a non-zero count, then read the generated member type from a client and
  decide per situation — they may not share one answer.
- **References:** `UnsupportedShape.Unresolvable`; `SchemaProperties.ClassifyLeaf`.
