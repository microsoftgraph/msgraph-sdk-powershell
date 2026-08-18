# WrapperGenerator

Generates the PowerShell **cmdlets** for the Microsoft Graph SDK from Graph's OpenAPI description — the C# classes behind commands like `Get-MgUserMessage` and `New-MgUserMessage`.

## Why this exists

The Microsoft Graph PowerShell SDK is thousands of cmdlets, and customers have scripts that depend on their exact names — `Get-MgUserMessage`, not `Get-MgUsersMessages`. Those names follow conventions, but the conventions are fiddly (singular nouns, a `Mg` prefix, a handful of hand-tuned exceptions), and the SDK's current generator (AutoRest) has quietly dropped cmdlets when names collided.

This tool regenerates those cmdlets from the same OpenAPI description **while reproducing the published names exactly**, so a regenerated module is a drop-in replacement. Because name parity is the hard part, most of the tool is a naming engine; the rest is a straightforward C# code emitter. The one exception to "exactly": a handful of published names are AutoRest naming defects (e.g. `Get-MgSecurityThreatIntelligenceHostWhoi`, where "Whois" lost its `s`) that the generator deliberately corrects — each is pinned by a test, allowlisted in the parity gate, and documented in the edge-case catalog ([docs/edge-cases/naming-edge-cases.md](docs/edge-cases/naming-edge-cases.md), one file per class of issue).

## What it produces

You give it operations from the OpenAPI document; it writes one C# file per cmdlet. For the four Mail operations on messages, the mapping is:

| OpenAPI operation | Cmdlet |
|---|---|
| `GET /users/{user-id}/messages` (a list) | `Get-MgUserMessage` |
| `GET /users/{user-id}/messages/{message-id}` (one item) | `Get-MgUserMessage` |
| `POST /users/{user-id}/messages` | `New-MgUserMessage` |
| `DELETE /users/{user-id}/messages/{message-id}` | `Remove-MgUserMessage` |

Each cmdlet is a `PSCmdlet` subclass that authenticates, binds parameters, and calls Graph through the Kiota-generated C# client. A user runs `Get-MgUserMessage -UserId <id>` and gets their messages back.

## How a cmdlet name is built

This is the core of the tool. A name has three parts: a **verb**, a **noun**, and the `Mg` prefix.

**Verb — from the HTTP method:**

| HTTP | Verb | | HTTP | Verb |
|---|---|---|---|---|
| GET | `Get` | | PUT | `Set` |
| POST | `New` | | DELETE | `Remove` |
| PATCH | `Update` | | | |

**Noun — from the URL path, not the operationId.** The operationId in the spec carries whatever plurality and casing the spec author chose; the URL path is deterministic. So the noun is built by walking the path:

1. Drop the `{parameter}` segments. `/users/{user-id}/messages` → `users` `messages`.
2. Pascal-case and **singularize each remaining segment**: `User`, `Message`.
3. Collapse repeats and stitch together, prefix `Mg`: `MgUserMessage`.

Singularization runs per camel-case word (so `termsAndConditions` → `TermAndCondition`), through an ordered list of rules — first match wins:

| Rule | Example |
|---|---|
| Acronyms / words under 3 letters stay | `OS` → `OS` |
| Irregulars | `Children` → `Child`, `People` → `Person` |
| Invariants (never singularized) | `Windows` → `Windows` |
| `ies` → `y` | `Policies` → `Policy` |
| `uses` → `us` | `Statuses` → `Status` |
| `es` after x/z/ch/sh/ss | `Businesses` → `Business` |
| ends in `ss`/`us`/`is` stays | `Access`, `Status`, `Analysis` |
| trailing `s` drops | `Messages` → `Message` |

A few published names aren't algorithmic, and the spec publishes some routes the SDK never shipped. Both live as data in `NamingOverrides.cs` — renames mirroring the SDK's hand-written AutoRest directives, and suppressions for routes that ship nothing — each entry citing its evidence: the directive when one exists, otherwise the shipped-command inventory. Examples: the `GET /users/{id}/calendar` rename to `…UserDefaultCalendar` (Calendar.md), the `Solution` prefix strip under `/solutions/*` with the BackupRestore exception (Bookings.md), and the self-referential `sites/{id}/sites` rename to `SubSite`/`GroupSubSite` (Sites.md) — without which the sub-sites cmdlets would collide with `Get-MgSite` itself. The generator fails loudly on any such file collision rather than silently overwriting.

On top of the curated entries sits a **derived** layer: `tools/Derive-CollisionResolutions.ps1` replays every route from the checked-in collision inventory (`data/collision-inventory.v1.0.txt`, captured with `--no-collision-data`) against the shipped-command inventory and emits `data/collision-suppressions.v1.0.json` and `data/collision-renames.v1.0.json` — one exact-match entry per contested method+route, each carrying its oracle evidence. The files are embedded into the generator at build time (generation never reads the 22 MB oracle), applied only when `GeneratorConfig.UseCollisionData` is set, and the script's `-Validate` mode fails if the checked-in files drift from a fresh derivation. Two routes in all of v1.0 are **deferred cross-path merges** — the published SDK serves `Get-MgGroupPhoto` from both `/photo` and `/photos`, and `Get-MgShareListItem` from both `/listItem` and `/list/items`, as parameter-set variants of one cmdlet; the generator keeps the singleton side and suppresses the collection side until cross-path parameter sets land (see [docs/edge-cases/crosspath-merge-edge-cases.md](docs/edge-cases/crosspath-merge-edge-cases.md)). With the derived data applied, a full v1.0 generation across all 38 configured modules produces zero collisions.

## The one subtle part: list + item GET become one cmdlet

Graph has two GETs for a resource — the collection (`GET …/messages`) and a single item (`GET …/messages/{message-id}`) — but the published SDK exposes **one** cmdlet, `Get-MgUserMessage`, that does both: no `-MessageId` lists them, a `-MessageId` fetches one.

The generator reproduces that. When it finds a list GET and an item GET that share a noun, it emits **three** files:

- `Get-MgUserMessage` — a thin **dispatcher**. It has two parameter sets, `List` (default) and `Get`, and makes no Graph call itself; it just forwards to one of the two cmdlets below.
- `Get-MgUserMessage_List` — the real list implementation.
- `Get-MgUserMessage_Get` — the real single-item implementation.

The dispatcher is small enough to read in full — this is the actual generated output:

```csharp
[Cmdlet(VerbsCommon.Get, "MgUserMessage", DefaultParameterSetName = "List")]
[OutputType(typeof(MessageCollectionResponse), ParameterSetName = new[] { "List" })]
[OutputType(typeof(Message), ParameterSetName = new[] { "Get" })]
public class GetMgUserMessageCommand : PSCmdlet
{
    [Parameter(Mandatory = true, Position = 0)]
    public string UserId { get; set; } = string.Empty;
    [Parameter(Mandatory = true, ParameterSetName = "Get", Position = 1)]
    public string MessageId { get; set; } = string.Empty;
    // ... -Filter/-Top/-Skip/... on the "List" set, -Property/-Expand on both ...

    protected override void ProcessRecord()
    {
        var internalCmdletName = ParameterSetName == "Get" ? "Get-MgUserMessage_Get" : "Get-MgUserMessage_List";
        InvokeCommand.InvokeScript(
            "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
            /* ... */ MyInvocation.BoundParameters, internalCmdletName);
    }
}
```

`-MessageId` belongs only to the `Get` set, so binding it selects that set and the dispatcher calls `Get-MgUserMessage_Get`; otherwise it calls `Get-MgUserMessage_List`. (Standalone GETs with no list/item pair — like a singleton `GET /users/{id}/calendar` — just get one plain cmdlet.)

## What's inside every cmdlet

Whatever the shape, a generated cmdlet has the same skeleton:

- **Path IDs** become mandatory positional parameters (`-UserId`, `-MessageId`).
- **Auth**: every cmdlet takes an optional `-AccessToken`; without it, the cmdlet uses the active
  `Connect-MgGraph` session. (The shared auth helpers are written once per module into `Shared.g.cs`.)
- **GETs** expose the OData query options the operation supports — `-Filter`, `-Property` (alias`-Select`), `-Sort` (alias `-OrderBy`), `-Top`, `-Skip`, `-Count`.
- **`New`/`Update`** bind the request body's properties as parameters. Primitives flatten directly
  (`-Subject`, `-IsRead`, …); a referenced model binds as its kiota type, so
  `New-MgUser -PasswordProfile @{ Password = '...' }` works — PowerShell converts the hashtable on
  binding. Referenced enums bind as the generated enum (`-Importance high`), and formatted strings
  bind as the CLR type kiota uses (`date-time` → `DateTimeOffset`, `uuid` → `Guid`, `base64url` →
  `byte[]`). A property the spec gives no type at all — which kiota emits as `UntypedNode` — takes
  an ordinary PowerShell value (`-Maximum 100`, `-ContentInfo @{ … }`) and is converted on
  assignment. Navigation properties, `id`, `additionalData` and `readOnly` properties are
  deliberately excluded: they are relationships or serializer infrastructure, not body fields.
  `Update` also re-fetches after a `204 No Content` so it still returns the updated object.
  See [docs/body-property-binding.md](docs/body-property-binding.md) for the full mapping, the
  `date`/`time` input contract, and what remains unbound.
- **`New`/`Update`/`Remove`** are gated by `ShouldProcess`, so `-WhatIf` and `-Confirm` work.
- **The actual request** is the Kiota client's fluent chain built from the path:
  `client.Users[UserId].Messages[MessageId].GetAsync(...)`.

## What it needs to actually run

The generated files are **source, not a built module**. They reference, by name, a Kiota-generated C# client (an `ApiClient` type and its `Models`) plus the Graph auth helpers. So this tool is step 2
of a two-step build:

```
Filtered OpenAPI (Graph)
   ├─► [1] kiota generate  ─► request builders + models  (the "ApiClient" — run separately)
   └─► [2] WrapperGenerator ─► the cmdlet wrappers        (this tool)
```

The wrappers compile and run only alongside step 1's output. Wiring the two into one buildable module is later work (see Gaps).

## The source files

| File | What it does |
|---|---|
| `Program.cs` | CLI entry point: load the spec, filter paths, run the generator |
| `IncludePathFilter.cs` | Trims the spec to the requested `--include-path` paths/methods |
| `PowerShellWrapperGenerationService.cs` | The orchestrator: walks the paths, pairs list/item GETs, writes the files |
| `CmdletNaming.cs` | Verb + noun + the `client.X[Y].Z` request chain |
| `Singularizer.cs` | The per-word singularization rules |
| `NamingOverrides.cs` | Cited rename/suppression data mirroring the shipped SDK surface |
| `CmdletEmitter.cs` | The C# templates for each cmdlet shape (the actual code text) |
| `SchemaProperties.cs` | Which body properties become `New`/`Update` parameters |
| `OperationInfo.cs`, `EmitContext.cs`, `GeneratorConfig.cs` | Small data/config carriers |
| `GeneratorExtensions.cs` | String + schema helper methods |

## Build, run, test

**Build:**

```powershell dotnet build tools/WrapperGenerator
```

**Run** — generate the Mail message cmdlets (the `--include-path` args pick which operations):

```powershell
dotnet run --project tools/WrapperGenerator -- `
  -d openApiDocs_KiotaCompat/v1.0/Mail.yml `
  -o <output-folder> `
  -n Microsoft.Graph.PowerShell.Mail.Client `
  --include-path '/users/{user-id}/message[s]#GET,POST' `
  --include-path '/users/{user-id}/messages/{message-id}*#GET,DELETE'
```

`-d` is the spec, `-o` the output folder, `-n` the namespace of the step-1 client the wrappers call. Each `--include-path` is a glob with an optional `#METHOD,METHOD` filter; omit them to generate every operation in the document. Output: `Shared.g.cs`, one `*.g.cs` per cmdlet (in a namespace derived from `-n` by dropping its trailing `.Client`, e.g. `-n Microsoft.Graph.PowerShell.Mail.Client` emits into `Microsoft.Graph.PowerShell.Mail`), and a small `kiota-lock.json` noting the source spec.

## The committed output

The generated modules are checked in under `src/{Module}/{v1.0|beta}/wrapper/`, one
self-contained project per module and API version:

```
src/Mail/v1.0/wrapper/
    Client/                             kiota client (models + request builders)
    Cmdlets/                            the wrapper cmdlets, one *.g.cs each, plus Shared.g.cs
    Microsoft.Graph.Wrapper.Mail.csproj compiles both into one assembly
```

Everything needed to build is in that folder, so no generation step is required to try it:

```powershell
dotnet build src/Mail/v1.0/wrapper                       # produces the dll + psd1 under bin/
Import-Module src/Mail/v1.0/wrapper/bin/Release/net10.0/Microsoft.Graph.Wrapper.Mail.psd1
```

To regenerate it after a generator change — this rewrites the committed folder in place, so the
diff shows exactly what the change did to the output:

```powershell
.\tools\Build-WrapperModule.ps1 -Module Mail -IntoSource -Configuration Release
.\tools\New-WrapperOutputManifest.ps1        # refresh docs/WrapperCmdlets-V1.0*.csv
```

`docs/WrapperCmdlets-V1.0.csv` is the reviewable inventory of that output — one row per emitted
cmdlet with its module, verb, noun and request path — with per-module totals in
`docs/WrapperCmdlets-V1.0-Summary.csv`. The generated tree is far larger than GitHub renders in
a diff, so those two files, not the tree, are what a reviewer reads.

**Test** — several layers, each proving something the others cannot:

```powershell
# 1. Naming and classification rules pinned to published Microsoft.Graph names
dotnet test tools/WrapperGenerator.Tests
#    => Passed! - Failed: 0, Passed: 180, Total: 180

# 2. Parity gate: generate, then check every cmdlet name against Graph's own command inventory
.\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath <output-folder>
#    => Mail [v1.0]: 4 of 4 cmdlets match the oracle ...  EXIT CODE: 0

# 3. Compile gate: every module builds against the kiota client it was generated with
.\tools\Build-WrapperModule.ps1 -Module <names> -Configuration Release

# 4. Omission oracle: every settable kiota body member is bound or cited by a named policy
.\tools\Test-BodyBindingCoverage.ps1

# 5. Runtime gate: the module imports and each bound shape accepts what a person would type
.\tools\Test-WrapperModule.ps1 -Module <names> -Configuration Release
```

The unit tests guard the naming and classification rules (their expected values are real published names from `src/Authentication/Authentication/custom/common/MgCommandMetadata.json`). The parity gate checks actual generated output against that same inventory; names on the deliberate-corrections list ([docs/edge-cases/naming-edge-cases.md](docs/edge-cases/naming-edge-cases.md)) are reported as `[CORRECTED]` instead of failing.

The generated cmdlets **are** compiled now: `Build-WrapperModule.ps1` builds each module against the kiota client it was generated with, which is the only authority on whether an emitted parameter's CLR type matches the member it assigns. Compilation cannot see an *omitted* member, so the oracle exists separately; and neither can see whether PowerShell converts a value at runtime, so the runtime gate exists separately again. The runtime gate refuses a binary older than any of its compiled inputs — `Build-` and `Test-` both default to `Debug`, so a Release-only build once left it validating a three-day-old assembly and reporting green.

## Gaps / not done yet

- **Only v1.0 output is committed.** The beta docs exist (`openApiDocs_KiotaCompat/beta`) but no beta output is generated or checked in yet; the layout already accommodates it at `src/{Module}/beta/wrapper/`.
- **No runtime base classes or real auth flow.** Shared paging, a proper `Connect-MgGraph`/session integration, and base cmdlet classes are a later phase.
- **Body binding covers every shape reaching the classifier** — the omission oracle reports 0 failures across 2,240 body-writing cmdlets (24,050 members seen, 15,872 bound). That is a statement about the operations that generate, not about v1.0: see the coverage figure below. Classifications for shapes that do not occur (inline objects and enums, genuine unions, dictionaries, unresolvable references, unknown formats) are retained so a future corpus change is reported rather than silently mis-bound; [docs/edge-cases/body-binding-edge-cases.md](docs/edge-cases/body-binding-edge-cases.md) records each with its exit criteria.
- **73.6% of v1.0 operations generate, deliberately.** Of 14,131 operations across the 38 specs: 10,401 become cmdlets, 3,173 are suppressed because the published SDK ships no cmdlet for them (oracle-derived), and 557 are unsupported — 345 call segments on operations the spec does not class as an action or function, 125 routes that call a parameterized function before their final segment, 42 whose content response is neither a stream nor a resolvable entity, 24 with no wrapper emitter for the HTTP method, 13 OData parameter aliases, 6 unresolvable collection schemas, 2 missing request schemas. The three populations sum to 14,131 by construction. The rise from 61.3% is the OData `$`-segments — `$count`, `$ref` and `$value` were 2,304 unsupported operations and now have emitters of their own — plus PUT and the media/content downloads.
- **Naming parity: every generated cmdlet is now compared.** The generator stamps each emitted class with a `[GraphRoute(method, path)]` attribute carrying the operation's route exactly as the spec declares it, and the gate reads that attribute out of the module's **compiled assembly**. Nothing is excluded: of 11,737 cmdlets, 9,564 match, 403 mismatch, 428 have no oracle row, 6 are documented deliberate corrections, and 1,336 are GET dispatchers verified through their `_List`/`_Get` siblings. Before this the gate reconstructed the route from the generated C#, which cannot work for a parameterized function (the builder member keeps the argument names but not the OData argument syntax) or a namespace-qualified action (kiota keeps the qualifier, the route does not) — so it excluded **1,669 cmdlets** from comparison and reported them as skipped. Those names were never wrong-free; they were unexamined. Renames and suppressions are derived from the oracle by `tools/Derive-ParityResolutions.ps1` — data, not rules — alongside a small curated set in `NamingOverrides.cs` and the comparer's deliberate-corrections table, each entry cited. A derived rename carries the published **verb** as well as the noun, because the SDK chooses an action's verb per operation (`sendMail` ships `Send-`, `checkMemberGroups` ships `Confirm-`, and `applyHold`/`removeHold` share one noun and differ only by verb).
- **Emitted files are not operations.** 11,737 files include 1,336 GET dispatchers that issue no request of their own, leaving 10,401 that correspond to an operation. Any coverage figure derived from file counts, or by subtracting only the unsupported from the total, is wrong in a way that flatters the result. The same trap applies to the file *names*: `BaseName` of `GetMgApplication_List.g.cs` is `GetMgApplication_List.g`, because only the last extension is stripped, so an orphan check written against `BaseName -match '_(List|Get)$'` examines nothing and passes vacuously. Strip `\.g\.cs$` explicitly; the corrected check examines 2,672 workers and finds 0 orphans.
- **`DeviceManagement.Actions` has no `openApiDocs_KiotaCompat` spec**, so its operations are never read and appear in none of the counts above. It also has no entry in `config/ModulesMapping.jsonc` — the mapping was removed in `659db09e81` ("modules that are causing duplicate cmdlets") — and the published inventory has no `DeviceManagement.Actions` rows for v1.0 at all: those operations ship from four modules that already existed (DeviceManagement, Reports, DeviceManagement.Administration, DeviceManagement.Enrollment), all of which generate them. 38 modules are configured for v1.0, not 39.
- **OData actions and functions generate**, as a general operation class keyed off `x-ms-docs-operation-type`: bound and unbound, entity/collection/singleton targets, inline request bodies, value-wrapping and no-content responses, and parameterized functions. [docs/edge-cases/action-function-edge-cases.md](docs/edge-cases/action-function-edge-cases.md) records the kiota naming rules each shape depends on and the two shapes still deferred (OData parameter aliases; routes that call a parameterized function part-way along).
