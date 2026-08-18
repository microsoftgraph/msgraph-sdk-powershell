# Action and function edge cases

Part of the wrapper generator's edge-case catalog (one file per **class** of issue, fixed
fields per entry). This file covers **OData actions and functions**: operations that call
something on a resource rather than doing CRUD over one.

An action is `x-ms-docs-operation-type: action` (always POST, parameters in an inline request
body); a function is `x-ms-docs-operation-type: function` (always GET, parameters inline in the
path segment). The classification comes from that extension, never from guessing at a path
shape — a parenthesised segment is a *consequence* of being a function, not the definition.

Population across the 38 configured v1.0 modules: **2,737 operations** (1,683 actions, 1,054
functions) in 33 modules. 118 are `application/octet-stream` downloads, which fall under the
existing stream-download gap; 13 use OData parameter aliases (below).

## Entry template

```
## <short case name>
- **Class:** <kiota-naming | spec-shape | binding-model | ...>
- **Status:** <handled | not-yet-reachable | workaround | deferred>
- **Evidence:** <what the generated client or the spec shows>
- **Decision:** <what the generator does and why>
- **References:** <tests, issues, files>
```

## Status summary

| Case | Class | Status |
|---|---|---|
| Per-operation types drop a qualifier the builder keeps | kiota-naming | handled |
| Entity `$ref` outranks a `value` member | spec-shape | handled |
| Function arguments are named by their placeholder | kiota-naming | handled |
| Reserved namespace names gain a `Namespace` suffix | kiota-naming | handled |
| Reserved model names gain an `Object` suffix | kiota-naming | handled |
| `/delete` segment clashes with the request methods | kiota-naming | handled |
| Value-wrapping responses have a non-obsolete accessor | kiota-naming | handled |
| Parameterized functions have no bindable accessor | spec-shape | workaround |
| Byte responses (`application/octet-stream`) | spec-shape | handled |
| `-OutFile` is only meaningful on a stream response | binding-model | handled |
| OData parameter aliases (`@name`) | binding-model | deferred |

## Per-operation types drop a qualifier the request builder keeps

- **Class:** kiota-naming
- **Status:** handled
- **Evidence:** for `/security/alerts_v2/microsoft.graph.security.moveAlerts`, kiota generates
  the folder, namespace and builder as `MicrosoftGraphSecurityMoveAlerts…` but names the body
  class `MoveAlertsPostRequestBody` — the qualifier is dropped from the type, not the namespace.
  Same split on `…/microsoft.graph.callRecords.getDirectRoutingCalls(…)`, whose response class
  is `GetDirectRoutingCallsWithFromDateTimeWithToDateTimeGetResponse`.
- **Decision:** `CmdletNaming` carries both `OperationMemberName` (qualified — namespace and
  builder) and `OperationTypeName` (bare — request body, response, and the
  `…As<Type><Verb>ResponseAsync` method).
- **References:** `PredictsTheKiotaMemberAndTypeNamespace` (ActionFunctionTests).

## Entity `$ref` outranks a `value` member

- **Class:** spec-shape
- **Status:** handled
- **Evidence:** `microsoft.graph.workbookFunctionResult` is a normal entity that happens to
  declare a `value` property. Treating any response containing `value` as a value-wrapper made
  every workbook function ask for a `CountIfPostResponse` class kiota never generates.
- **Decision:** resolve a referenced entity first; only an **inline** object whose payload hangs
  off `value` gets the per-operation `<Type><Verb>Response`.
- **References:** `EmitsActionWithComplexRequestBodyAndEntityReturn`,
  `CallsTheNonObsoleteMethodForAValueWrappingResponse`.

## Function arguments are named by their placeholder

- **Class:** kiota-naming
- **Status:** handled
- **Evidence:** `…/cell(row={row},column={column})/column(column={column1})` generates
  `ColumnWithColumn1` — kiota takes the name from the `{placeholder}`, not the OData parameter
  on the left of the `=`. The two usually match, so this only surfaces where the spec
  disambiguates a repeated argument name.
- **Decision:** parse the placeholder as the parameter's name. It is also the key the URL
  template expands, so taking the left-hand side would leave the value unbound at runtime as
  well as mis-name the member.
- **References:** `ParameterizedFunctionCarriesItsArgumentsInPathOrder`.

## Reserved namespace and model names

- **Class:** kiota-naming
- **Status:** handled
- **Evidence:** kiota appends `Namespace` to a namespace whose name collides with a BCL type —
  `/directory/…` generates under `DirectoryNamespace`. Observed across the 38 built clients:
  Char, Convert, Date, Decimal, Directory, Environment, File, Range, Task, Type. The
  model-class equivalent appends `Object`; the actions surfaced three names the previous list
  lacked (`Action`, `DayOfWeek`, `ValueType`), each confirmed as a rename by the schema existing
  unsuffixed in the spec — unlike `microsoft.graph.referencedObject` and
  `microsoft.graph.expressionInputObject`, which are genuine Graph names.
- **Decision:** both sets are encoded as data with the observed corpus as their citation. A name
  kiota starts renaming that is missing from either set is a module compile error, never a
  silent mis-emission.

## `/delete` segment clashes with the request methods

- **Class:** kiota-naming
- **Status:** handled
- **Evidence:** kiota exposes the `/delete` navigation as `DeletePath`, because `Delete` would
  clash with the request methods the builder declares. 25 v1.0 routes contain a `/delete`
  segment; `/get`, `/post`, `/patch` and `/put` do not occur.
- **Decision:** rename only the clash that occurs. A new one appears as a compile error.

## Value-wrapping responses have a non-obsolete accessor

- **Class:** kiota-naming
- **Status:** handled
- **Evidence:** for a response wrapping its payload in `value`, kiota generates
  `PostAs<Type>PostResponseAsync` returning `<Type>PostResponse`, and marks the plain
  `PostAsync` beside it `[Obsolete]` (it returns `<Type>Response`, which derives from the
  former).
- **Decision:** always call the non-obsolete accessor, so the emitted modules compile without
  deprecation warnings and survive kiota removing the old overload.

## Parameterized functions have no bindable accessor

- **Class:** spec-shape
- **Status:** workaround (kiota's public path-parameter constructor)
- **Evidence:** `grep -c 'in: path' openApiDocs_KiotaCompat/v1.0/*.yml` is **0** — the DevX
  `style=Plain` conversion emits no path-parameter declarations at all. Kiota still infers `{id}`
  indexer segments structurally, but only lifts an in-segment function argument into a typed
  accessor argument when the spec declares it, so it generates
  `ReminderViewWithStartDateTimeWithEndDateTime()` with an empty signature while leaving
  `{StartDateTime}` in the URL template. The same operation from the legacy `openApiDocs` spec,
  which does declare them, generates `(string endDateTime, string startDateTime)`.
  `BaseRequestBuilder.PathParameters` is protected, so the values cannot be set after the fact.
- **Decision:** construct the builder through its public `(Dictionary<string, object>,
  IRequestAdapter)` constructor with the path ids and function arguments populated, keyed by the
  URL template's own placeholder names (percent-encoded as kiota encodes them: `{user-id}` is
  `user%2Did`). This expands kiota's own template rather than assembling a URL by hand.
  524 operations take this path. The root fix is upstream: the KiotaCompat documents should
  declare the parameters their paths already reference.
- **References:** `EmitsParameterizedFunctionBindingItsArgumentsThroughThePathParameters`.

## Byte responses (`application/octet-stream`)

- **Class:** spec-shape
- **Status:** handled
- **Evidence:** 118 action/function operations declare their success response as
  `application/octet-stream` and nothing else — the Intune reporting surface is almost all of
  them. **101 are cmdlets the published SDK ships** (94 in Reports, the rest spread across
  Compliance, Devices.ServiceAnnouncement, Security and DeviceManagement.Administration), so
  skipping the shape left a large hole in a module that otherwise generates. Kiota types every
  one identically: the ordinary `PostAsync`/`GetAsync` returns `Task<Stream?>`.
- **Decision:** generate them. Request binding, naming and the call are unchanged from any other
  action or function; only the response differs. The cmdlet declares
  `[OutputType(typeof(byte[]))]` and copies the stream into a byte array before writing it,
  because the raw `Stream` is bound to the request that produced it and would already be
  unusable by the time a caller read it. No parameter is invented for this: the published
  example (`src/DeviceManagement.Actions/v1.0/examples/Get-MgDeviceManagementReportCachedReport.md`)
  shows the shipped cmdlet writing to the pipeline, not to a file.
- **Scope:** action and function operations only. The ~78 **resource** GETs that return a stream
  (`/content`, `/$value`) are a separate emitter path and remain the pre-existing gap.
- **References:** `EmitsStreamReturningActionAsBytes` (ActionFunctionTests); `CallPlan.ReturnsStream`.

## `-OutFile` is only meaningful on a stream response

- **Class:** binding-model
- **Status:** handled
- **Evidence:** `EmitContentSet` is reached from two callers — the `/$value` PUT branch and
  `EmitSetFor`'s non-JSON-request-body branch, which is how an ordinary content route such as
  `PUT /drives/{drive-id}/bundles/{driveItem-id}/content` arrives. On 56 of the 190 v1.0 cmdlets
  it produced, the success response is the updated **entity**, not the bytes back:
  `Set-MgDriveBundleContent` emits `[OutputType(typeof(…Models.DriveItem))]` and declares
  `DriveItem? result`. `-OutFile` is only ever read inside the stream-output block, so on those 56
  it was a parameter that accepted a file path and silently ignored it.
- **Decision:** the declaration is gated on the resolved response actually being a stream, which is
  what `EmitAction` and `EmitFunction` already did — the two content emitters were the outliers.
  Across the regenerated v1.0 corpus all 134 cmdlets that declare `-OutFile` now also read it
  (was 190 declaring / 134 reading).
- **References:** `CmdletEmitter.EmitContentGet`, `CmdletEmitter.EmitContentSet`;
  `ActionFunctionTests.ContentWriteDeclaresOutFileOnlyWhenTheResponseIsAStream`, which asserts the
  entity case declares no `-OutFile` **and** the stream case still does, so neither deleting the
  gate nor hard-coding it to empty passes.

## OData parameter aliases (`@name`)

- **Class:** binding-model
- **Status:** deferred (reported, not emitted)
- **Evidence:** 13 v1.0 operations pass arguments as OData parameter aliases —
  `doesUserHaveAccess(userId='@userId',tenantId='@tenantId',userPrincipalName='@userPrincipalName')`
  and the `getAllRecordings`/`getAllTranscripts` families. An alias supplies its value as a
  **query option**, not a path substitution, which none of the emitted shapes cover; kiota's
  member name for the quoted form is also irregular
  (`GetAllRecordingsuserIdUserIdWithStartDateTimeWithEndDateTime`).
- **Decision:** skipped with a named reason rather than emitted against a guessed name. The
  published SDK ships 5 of the 13 (the `doesUserHaveAccess` family, e.g.
  `Invoke-MgHaveTeamChannel`), so this is a real coverage gap and is counted as one.
- **References:** `Compare-WrapperCmdletNames.ps1` reports them as unshipped-by-us; the skip
  reason is "OData parameter-alias arguments (@name), not generated yet".
