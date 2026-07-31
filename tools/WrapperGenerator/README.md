# WrapperGenerator

Generates the PowerShell **cmdlets** for the Microsoft Graph SDK from Graph's OpenAPI description — the C# classes behind commands like `Get-MgUserMessage` and `New-MgUserMessage`.

## Why this exists

The Microsoft Graph PowerShell SDK is thousands of cmdlets, and customers have scripts that depend on their exact names — `Get-MgUserMessage`, not `Get-MgUsersMessages`. Those names follow conventions, but the conventions are fiddly (singular nouns, a `Mg` prefix, a handful of hand-tuned exceptions), and the SDK's current generator (AutoRest) has quietly dropped cmdlets when names collided.

This tool regenerates those cmdlets from the same OpenAPI description **while reproducing the published names exactly**, so a regenerated module is a drop-in replacement. Because name parity is the hard part, most of the tool is a naming engine; the rest is a straightforward C# code emitter.

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

A few published names aren't algorithmic — they come from hand-written directives in the SDK's module configs. Those live as data in `NamingOverrides.cs`, each with a cited source, rather than as special cases in the naming code. There are three today: suppress `PATCH /users/{id}/calendar` (the SDK ships no such cmdlet), rename `GET /users/{id}/calendar` to `…UserDefaultCalendar`, and strip the `Solution` prefix for most `/solutions/*` nouns (for example, `Get-MgBookingBusiness`, not `Get-MgSolutionBookingBusiness`) while preserving it for known exceptions such as BackupRestore (`Get-MgSolutionBackupRestore`).

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
- **`New`/`Update`** flatten the request body's top-level primitive properties into parameters (`-Subject`, `-IsRead`, …). Nested/complex properties are skipped, with one special case:
  `passwordProfile` is exposed as `-Password`/`-ForceChangePasswordNextSignIn` because creating a user requires it. `Update` also re-fetches after a `204 No Content` so it still returns the updated object.
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
| `NamingOverrides.cs` | The three hand-cited name exceptions |
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
  -d openApiDocs/v1.0/Mail.yml `
  -o <output-folder> `
  -n Microsoft.Graph.PowerShell.Mail.Client `
  --include-path '/users/{user-id}/message[s]#GET,POST' `
  --include-path '/users/{user-id}/messages/{message-id}*#GET,DELETE'
```

`-d` is the spec, `-o` the output folder, `-n` the namespace of the step-1 client the wrappers call. Each `--include-path` is a glob with an optional `#METHOD,METHOD` filter; omit them to generate every operation in the document. Output: `Shared.g.cs`, one `*.g.cs` per cmdlet (in namespace `MgPoC`), and a small `kiota-lock.json` noting the source spec.

**Test** — two layers:

```powershell
# 1. Naming rules pinned to published Microsoft.Graph names (69 tests)
dotnet test tools/WrapperGenerator.Tests
#    => Passed! - Failed: 0, Passed: 69, Total: 69

# 2. Parity gate: generate, then check every cmdlet name against Graph's own command inventory
.\tools\Compare-WrapperCmdletNames.ps1 -GeneratedPath <output-folder>
#    => Mail [v1.0]: 4 of 4 cmdlets match the oracle ...  EXIT CODE: 0
```

The unit tests guard the naming rules (their expected values are real published names from `src/Authentication/Authentication/custom/common/MgCommandMetadata.json`). The parity gate checks actual generated output against that same inventory. There is **no** test yet that the generated cmdlets *compile* — that needs step 1's client to compile against.

## Gaps / not done yet

- **Output isn't wired into a module.** Files go to whatever `-o` folder you pass, in a fixed `MgPoC` namespace. The target design commits wrappers into `src/{Module}/` with a per-module namespace; that alignment (and a namespace override) isn't built.
- **No runtime base classes or real auth flow.** Shared paging, a proper `Connect-MgGraph`/session integration, and base cmdlet classes are a later phase.
- **Body binding is shallow** — top-level primitive properties only; no nested/complex types beyond the `passwordProfile` special case.
- **Some operation shapes aren't generated** — `$count`/`$ref`/`$value`, delta, OData actions/functions, and cast endpoints.
