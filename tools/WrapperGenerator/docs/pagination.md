# Pagination (#3706): decisions and evidence

Every list-shaped cmdlet follows `@odata.nextLink` under an opt-in `-All` switch; without it,
a surviving nextLink produces one short warning and no extra request. This file records the
decisions behind that behavior and the evidence each one rests on, so the emitter and test
comments can stay lean and cite here.

## The contract

| Invocation | Behavior |
|---|---|
| (no switches) | First page only. If the response carries a non-empty `@odata.nextLink`, one warning: `More results are available. Use -All to return all pages.` |
| `-All` | Follows every non-empty nextLink until exhaustion. Each page streams to the pipeline before the next request is issued. |
| `-All -Top N` | `-Top` is a TOTAL cap at whole-page granularity: iteration stops once fetched >= N; the final page is written whole, so more than N items can return. |
| `-Top N` alone | Single request with `$top=N` (unchanged from pre-pagination behavior). Known divergence: the published SDK auto-paginates when N exceeds the service page cap (999); the wrapper passes the raw `$top` through and the service rejects it. Pre-existing behavior, recorded here as deliberate scope. |

Continuation requests go through kiota's `WithUrl(nextLink)` and re-apply **headers only**
(`ConsistencyLevel`, `-Headers`): the nextLink already carries the original query state, and a
raw-URL builder ignores templated query parameters (see the `WithUrl` doc comment in any
generated request builder), so re-binding query options would be dead code.

A pipeline stop (`Select-Object -First N` downstream, Ctrl+C) passes through both catch layers
(worker and dispatcher) via `when (ex is not PipelineStoppedException)` filters instead of
being re-branded a Graph failure. `-All` also checks `Stopping` between pages. In-flight HTTP
cancellation on Ctrl+C is a known limitation: the loop stops between pages, not mid-request.

## Decisions and their evidence

**The truncation warning is a deliberate deviation from the published SDK.** The published
AutoRest `ListCmdlet` truncates silently: `src/*/v1.0/custom/ListCmdlet.cs` contains no
`WriteWarning`, and the only warning site in a generated list cmdlet is the generic event pump.
The warning was approved in the design spec ("warning (no extra call) when nextLink present
without -All"; spec section 7 building block 4, and section 9 resolved questions: "Pagination
warning - Approved").

**Whole-page `-Top` granularity is the published SDK's shipped behavior.** Its `ListCmdlet`
sets `limit = Top` under `-All` and iterates while `totalFetchedItems < limit`
(`ListCmdlet.cs`, `InitializeCmdlet`/`ShouldIteratePages`). The final-page trimmer
(`GetOverflowItemsNextLinkUri`) exists but has **zero call sites in current generated
output**: its injection directive (`src/readme.graph.md`, `odataNextLinkCallRegex`) anchors on
a callback named `onOk`, and current autorest emits `on2Xx` - verified by grep over the
generated cmdlet trees (definition present in `custom/ListCmdlet.cs`, zero call sites in
`generated/cmdlets/`). Whether older gallery builds (from the `onOk` era) trimmed is not
established and does not bear on parity with what generates today.

**`-PageSize` and `-CountVariable` are out of scope.** #3706 promises `-All` plus the warning.
The published `-PageSize`/`-CountVariable` surface (and its private `-Count` demotion) is a
separate parity decision - note that a naive `-CountVariable` port would silently fail: the
published implementation reads `@odata.count` from `AdditionalData`, while kiota deserializes
it into the typed `OdataCount` property.

**Delta operations are out of scope for this loop because of their SHAPE, not a guard.**
They generate - 72 cmdlets - but the spec classes them as functions, so they route to the
function emitter and never reach `EmitListGet`. They therefore follow no nextLink, and they
write the response envelope rather than enumerating items - which is why they already expose
`@odata.deltaLink`, unlike the published SDK's delta cmdlets. Tracked in #3742.

**Scope is v1.0.** The generated corpus contains only v1.0 modules.

## Verification

- Emitter pins: `WrapperGenerator.Tests/EmitterTests.cs` (loop, cap, warning, headers-only
  continuation, dispatcher declaration, catch filters, no-`$top` uncapped emission, non-list
  shapes paging-free).
- Deterministic transport proof: `tools/Test-WrapperPaging.ps1` drives the real compiled
  worker AND public dispatcher across a fabricated two-page collection - request counts,
  literal nextLink continuation, warning exactly-once (including across `InvokeScript`),
  zero warnings under `-All`, cap behavior.
- Live: the truncation warning fires exactly once against real Graph (`-Top 5` on `/users`);
  `tools/Test-WrapperLive.ps1` covers the session pipeline end to end.
- Behavioral gates: operation inventory, name parity and the body-binding oracle are
  parameter-blind and unchanged by this feature; the inventory additionally pins that the
  first emitted request keeps the direct `client.X.GetAsync(` form its regex keys on.
