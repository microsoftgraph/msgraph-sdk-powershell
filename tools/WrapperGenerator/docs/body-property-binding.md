# Request-body property binding

How a request body's properties become cmdlet parameters, what each spec shape maps to, and
what is deliberately not bound. This is the durable record behind those decisions; the code
comments state the current rule, the measurements and reasoning live here.

## The authoritative chain

```
OpenAPI shape  ->  generated Kiota member  ->  emitted parameter + assignment
```

The generated Kiota member is the contract that matters. Every type in the mapping table below
was read off a generated Graph client, not from documentation: a parameter whose CLR type
disagrees with the member it assigns is a compile error in the module, so the generated code is
the only authority worth trusting.

The published (AutoRest) SDK is **not** part of this chain. It is a useful reference for cmdlet
and parameter *naming*, but its `IMicrosoftGraph*` interfaces are a different type system and
must never be used to decide a Kiota parameter type.

## Classification outcomes

Every property reached by the classifier lands in exactly one bucket. `Classify` counts the
properties it reaches independently of the buckets and throws if they disagree, so a shape that
fell through the switch fails generation rather than quietly disappearing.

| Outcome | Meaning |
|---|---|
| scalar | bound as a CLR scalar (see mapping) |
| model | bound as a named Kiota type - a model class or an enum |
| excluded | deliberately not a parameter, under a named policy |
| unsupported | a shape with no verified Kiota type; reported per property |

## Type mapping

### Referenced types

A `$ref` is resolved before it is classified: a reference is not automatically an object.
`microsoft.graph.importance` resolves to a string enum, and binding it as a model class would
not compile. Enums and models then bind through the same path, because Kiota emits both as
named types in the models namespace (`Models/Importance.cs` contains `public enum Importance`).

The CLR name comes from `ResolveModelTypeName`, which already encodes Kiota's reserved-name
renames (`File` -> `FileObject`) and sub-namespace moves. There is deliberately no second
resolver.

A nullable complex property is written by Graph as `anyOf[$ref, {type: object, nullable: true}]`
and is unwrapped only in that exact shape: exactly one branch resolves to a reference and every
other branch is an empty nullability placeholder. Two references, or a branch with real content,
is a genuine union and stays unsupported rather than having an arm chosen for the caller.

### Scalars

| OpenAPI | Kiota member type | Verified against |
|---|---|---|
| `boolean` | `bool?` | ubiquitous |
| `integer`/`number`, `int32` | `int?` | `mailFolder.childFolderCount` |
| `integer`/`number`, `int64` | `long?` | `drive.quotaUsed` |
| `number`, `float` / `double` / `decimal` | `float?` / `double?` / `decimal?` | ubiquitous |
| `integer`, `uint8` | `byte?` | `rgbColor.r/g/b` |
| `integer`, `int16` | `int?` | no `short` member exists in any generated client - Kiota widens |
| `string`, no format | `string` | ubiquitous |
| `string`, `date-time` | `DateTimeOffset?` | `user.birthday` |
| `string`, `uuid` | `Guid?` | `servicePrincipal.appId` |
| `string`, `duration` | `TimeSpan?` | `event.duration` |
| `string`, `date` | `Microsoft.Kiota.Abstractions.Date?` | `todoTask.startDate` |
| `string`, `time` | `Microsoft.Kiota.Abstractions.Time?` | `todoTask.dueTime` |
| `string`, `base64url` / `binary` | `byte[]?` | `application.logo`; no `Stream` member exists in any generated client |

Format types are emitted fully qualified. `Date` and `Time` come from
`Microsoft.Kiota.Abstractions`, which the emitted cmdlets do not import, and qualification also
prevents a Graph model named `Date` from capturing the name.

**Input contract for `date` and `time`.** Unlike every other scalar, these do not convert from a
string — `Date` and `Time` are Kiota's own structs and PowerShell has no string conversion for
them. They do convert from `[datetime]` (and from `[DateOnly]`/`[TimeOnly]`), which is what
`Get-Date` produces, so the usable form is:

```powershell
-ExpirationDate (Get-Date '2026-12-31')     # works
-ExpirationDate '2026-12-31'                # fails to bind
```

Measured against a compiled module; see the runtime gate below. This is a real sharp edge and is
the reason the runtime conversion check exists as a separate gate — the parameter compiles and
satisfies the coverage oracle either way.

An unrecognised format is reported as `UnknownFormat`, never silently bound as `string`: Kiota
would have mapped it to some other CLR type and the assignment would not compile.

### Collections

Kiota declares a collection of a **value** type with nullable elements and a collection of a
**reference** type without:

```csharp
List<Guid?>?                       // value type
List<CalendarRoleType?>?           // enum - also a value type
List<string>?                      // reference type
List<AssignedLicense>?             // reference type
```

`ToList()` on `T[]` yields `List<T>`, which will not assign to `List<T?>`, so an array parameter
whose element is a value type is declared `T?[]`. Value-ness travels with each mapping rather
than in a parallel list, so a new mapping cannot acquire the wrong element contract by omission.

This distinction was found by compiling the full 35-module population; a six-module sample
passed without it.

### The numeric/INF union

Graph encodes a numeric that may also carry OData's `INF`/`-INF`/`NaN` string as:

```yaml
price:
  oneOf:
    - { type: number, format: double, nullable: true }
    - { type: string, nullable: true }
    - $ref: '#/components/schemas/ReferenceNumeric'
```

Kiota keeps the numeric and drops the rest (`bookingService.price` generates as `double?`), so
the numeric branch is what binds. Recognition requires all three conditions, and names no schema
or property — the referenced enum is identified by its **values**:

1. exactly one numeric branch (two is a choice of precision);
2. every other branch merely stringish — a nullability placeholder or a plain string (a model or
   formatted-string arm would otherwise be silently discarded);
3. at least one referenced string enum whose values are drawn from `-INF`, `INF`, `NaN`.

Condition 3 is what makes this specific to the protocol encoding. Without it, an ordinary
`number | string` union — where the string arm means something — would collapse to the numeric.
All three are pinned by negative tests, none of which today's corpus exercises.

## Exclusion policies

These are protocol and framework rules, not Graph corpus exceptions. No endpoint, module, noun,
or incidental property name influences classification.

| Policy | Rule | Why |
|---|---|---|
| `ServerAssignedId` | property named `id` | assigned by the service |
| `ODataControlData` | name starts with `@` | OData metadata; Kiota's serializer supplies it, and the name is not a legal C# identifier |
| `KiotaAdditionalData` | property named `additionalData` | every Kiota model already exposes this through `IAdditionalDataHolder` as `IDictionary<string, object>`; binding it assigns a model type to that dictionary and fails to compile |
| `ReadOnlySchema` | `readOnly: true` | the OpenAPI signal for server-managed |
| `NavigationProperty` | `x-ms-navigationProperty: true` | a relationship addressed through its own request path, not a body field. Graph does **not** set `readOnly` on these, so the extension is the only signal that keeps them out |

Each exclusion is emitted as a named diagnostic so an external check can distinguish a policy
exclusion from an omission without re-deriving the policy.

## Requiredness

No bound parameter is declared mandatory. Graph's schemas do not carry usable requiredness:
across the v1.0 specs, **10,604 of 10,742** `required:` blocks list only `@odata.type`. Any
count of "required but unbound" properties derived from the spec is therefore close to
meaningless and must not be cited as evidence that nothing important is missing.

## Verification

Five gates, each proving something the others cannot (three are independent of the classifier;
see below for which):

| Gate | Proves | Cannot prove |
|---|---|---|
| `dotnet test tools/WrapperGenerator.Tests` | classification and emission rules | anything about the corpus |
| `tools/Build-WrapperModule.ps1` over every module | emitted CLR types match the generated Kiota members | that a member was omitted |
| `tools/Test-BodyBindingCoverage.ps1` | every settable member is bound or cited by a named policy | that a bound value converts at runtime |
| `tools/Test-WrapperModule.ps1` | PowerShell converts a hashtable to a model, a string to an enum, a `[datetime]` to a kiota `Date`, and 19 schema-less cases through the module's own compiled `UntypedValue` | compile-time type agreement |
| `tools/Compare-WrapperOperationInventory.ps1` | a parameter-level change did not alter which operations generate | anything about parameters |

`tools/Measure-BodyPropertyCoverage.ps1` reports what remains unbound, by shape, as both
occurrences and distinct identities - the same inherited property repeats across every cmdlet
that binds its model, so occurrences overstate the remaining work.

Compilation is the authority for type compatibility; the omission oracle is the authority for
omissions; runtime tests are the authority for PowerShell conversion.

**Only three of these are independent of the classifier, and the distinction matters.**
`Test-BodyBindingCoverage.ps1` builds its expectation from the *generated kiota models* and joins
it against the *emitted parameters*, so the classifier is the subject rather than the judge — it
catches a member the classifier never mentioned. `Measure-BodyPropertyCoverage.ps1` is different:
it consumes the generator's own `Unbound`/`Excluded` diagnostics, so it reports what the
classifier says about itself. That makes it a measurement instrument, not a gate, and a zero from
it means "the classifier reported nothing unbound", never "nothing is unbound". Cite the oracle
for that claim.

**The runtime gate refuses a stale binary.** It loads whatever is on disk, so a module last built
before the change under test would pass every check while proving nothing. `Build-` and `Test-`
both default to `Debug`, so a deliberate `-Configuration Release` build leaves a months-old
`Debug` binary in place for the test run to find — which is exactly what happened here, and it
reported green. The gate now compares the assembly's timestamp against the newest generated
source and fails with both dates rather than testing the wrong artifact.

## Schema-less properties

A property Graph writes with only a `description` — no type, reference, enum or format
(`workbookChartAxis.maximum`) — generates as `UntypedNode`, a base class PowerShell cannot
convert to. It binds as `object` and is converted on assignment by `UntypedValue.From` in
`Shared.g.cs`: string to `UntypedString`, integral to `UntypedInteger`/`UntypedLong`, fractional
to `UntypedDouble`/`UntypedDecimal`/`UntypedFloat`, bool to `UntypedBoolean`, array to
`UntypedArray`, hashtable recursively to `UntypedObject`. An unrecognised CLR type throws with
the type named rather than being stringified.

**Null handling.** The published SDK's `AddIf` helper adds a value only when it is non-null and
not an empty JSON object, and no model serializer has an explicit-null path — so `{"prop": null}`
was never sendable and clearing a field that way was never possible here. Emitting an explicit
null would invent a capability the published surface does not have, so the converter omits a null
and an empty hashtable. That much is parity.

The nested rules are an extension, and worth separating from the parity claim. AutoRest applies
`AddIf` at every level it generates — including per array element
(`autorest.powershell/powershell/llcsharp/schema/array.ts:227,235`) — so "drop, don't send null"
is its consistent behaviour rather than a top-level special case. But a caller-supplied untyped
bag has no analogue in the published SDK: every AutoRest body is a generated type, so there is no
precedent for what a null *inside* a hashtable should do. Extending the same rule is a choice, not
an inherited one. The converter therefore also drops a null nested among other members while its
siblings survive, drops a null array element, and omits an object whose members all drop out.
This is the wrapper's own input contract; it is pinned by the runtime gate rather than asserted.

## Residual debt

**None among the operations the generator emits: the oracle reports 0 failures across 2,240
body-writing cmdlets (24,050 model members seen, 15,872 bound).** The classifications for shapes that do not occur — `Union`,
`UnknownFormat`, `InlineObject`, `InlineEnum`, `Dictionary`, `Unresolvable` — are retained
deliberately so a future corpus change is reported rather than silently mis-bound.

That qualifier is load-bearing. Properties are only counted for operations that generate, and of
the 14,131 operations in the 38 v1.0 specs **10,401 (73.6%)** do. The rest are 3,173 suppressed
because the published SDK ships no cmdlet for them (oracle-derived), and 557 unsupported — 345
call segments on operations the spec does not class as an action or function, 125 routes calling a
parameterized function before their final segment, 42 whose content response is neither a stream nor a resolvable entity, and 45 others across four smaller causes. An operation refused upstream contributes
no properties here, so a zero says nothing about it. `InlineObject` in particular reads as zero
*because* action bodies are refused before classification, not because Graph avoids inline
objects.

Beware two ways of miscounting this, both made here before the accounting was forced to balance:
emitted files include GET dispatchers that issue no request (1,336 of the current 11,737), so
files are not operations; and subtracting only the unsupported from the total silently counts
every suppressed operation as generated — that error would read 13,574 "generated" against a true
10,401. A third trap is in the file *names*: `BaseName` of `GetMgApplication_List.g.cs` is
`GetMgApplication_List.g`, since only the last extension is stripped, so an orphan check written
against `BaseName -match '_(List|Get)$'` examines nothing and passes vacuously.

See [edge-cases/body-binding-edge-cases.md](edge-cases/body-binding-edge-cases.md) for each
shape, its population, and its exit criteria.

## Measured effect

| | Occurrences | Distinct |
|---|---:|---:|
| Unbound before this work | 4,466 | 2,426 |
| After typed models, enums, formats and unions | 28 | 20 |
| After schema-less properties | **0** | **0** |

`New-MgUser` went from 59 parameters to 82 over the same change **in a freshly generated tree**,
and across the body-binding slices the operation inventory was unchanged at 9,608 files — those
slices altered which *properties* bind, never which *operations* generate. The subsequent
parity derivation then changed the inventory deliberately (9,608 → 8,372 files: 1,896 removed as
suppressions and renames, 660 added as renames, reconciled row-by-row against the derivation
ledger); the operation shapes added since — actions, functions, `$count`, `$ref`, `$value`, PUT —
took it to the current 11,737. The committed output under `src/` predates all of this and still
shows 59 parameters; it has to be regenerated before any figure here applies there.
