# Delta (change tracking) edge cases

Delta operations are classed by the spec as functions (`x-ms-docs-operation-type: function`) but
behave as paged collections, so they are emitted from their own shape rather than the function
template. This file records the decisions and the evidence behind them.

## The command surface

One command per change-tracking operation, with two parameter sets:

| set | purpose |
|---|---|
| `DeltaSync` (default) | initial sync; binds the query options the operation declares |
| `Resume` | continues a previous sync from `-DeltaLink` |

Universal parameters: `-All`, and `-DeltaLinkVariable` (alias `DLV`), which receives the
`@odata.deltaLink` that terminates the change set.

## Why the token form is not its own command

The spec declares two routes for the same operation - `delta()` and, on some resources,
`delta(token='{token}')`. The published SDK does not ship the argument form as a separate
command: it folds it into the canonical delta command.

Measured on branch `feat/wrapper-pagination @ bc7f1e68cd`, POPULATION 11,719 emitted cmdlets and
11,116 v1.0 oracle rows:

- 72 delta cmdlets existed: 67 `delta()` + 5 `delta(token=…)`, agreed by two independent
  instruments (route attribute, and the kiota response-method call site).
- All 5 argument forms had exactly one parameterless sibling; none orphaned, none ambiguous.
- Each sibling mapped to exactly one published command; **no** argument form appeared anywhere
  in the oracle - 0 commands named `*WithToken*`, 0 URIs carrying a delta token.
- CONTROL: 22 routes carry `delta` inside their ARGUMENTS (the Excel
  `resizedRange(deltaRows=…,deltaColumns=…)` family). None were caught by the rule.

So the argument form is emitted as the `Resume` parameter set of its sibling. The pairing is
derived from route shape - never a list of cmdlet names - and anything the rule cannot resolve
(orphan, ambiguous, multiple resume forms) **fails generation** naming the offending routes,
rather than silently keeping or dropping an operation.

`-DeltaLink` rather than `-Token`: every generated delta request builder accepts a raw URL, so a
link resumes all 72 operations, whereas a token argument exists on 5.

## Terminal states

A delta response ends in one of four states, each handled explicitly:

| response carries | behaviour |
|---|---|
| `@odata.nextLink` only | continue if `-All`; otherwise write one warning and stop |
| `@odata.deltaLink` only | stop, and publish the link if `-DeltaLinkVariable` is bound |
| neither | stop, publish nothing - there is no link for a next round |
| both | `ThrowTerminatingError` - a response cannot be both continued and terminated |

A `-Top` cap or a pipeline stop reached before the terminal page ends the run **without**
publishing a link: a partial change set must not be resumable as though it were complete. The
variable is cleared at invocation start for the same reason, so a failed run cannot leave the
previous run's link readable.

## Why a caller-scope variable, not global

The published SDK's `-CountVariable` documents that it sets the variable in the **global** scope,
because its cmdlets are exported as functions and a function cannot modify its parent's scope.
Ours are compiled cmdlets, and the public dispatcher forwards through `InvokeCommand.InvokeScript`
with `useNewScope: false`. A compiled probe confirmed the value reaches the caller in all five
cases - direct, direct-global, dispatched, dispatched-global, and from inside a function - so the
global-scope fallback is not needed here.

## Output shape

Items are enumerated to the pipeline, like every other collection-returning cmdlet. Before this
change delta cmdlets wrote the whole response envelope, which incidentally exposed
`@odata.deltaLink` as a property; `-DeltaLinkVariable` replaces that access deliberately rather
than removing it.
