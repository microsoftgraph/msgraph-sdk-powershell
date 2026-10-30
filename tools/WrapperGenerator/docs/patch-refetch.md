# PATCH refetch headers

When PATCH returns no model and the same selected path supports GET, an Update worker
re-fetches through that path's typed Kiota builder. Both ordinary workers and grouped
mutation workers use `ReFetchBlock`. The follow-up request binds only the inherited
generic `-Headers` dictionary through `GenericHeadersBinding` / `AddRequestHeaders`.

Typed mutation parameters such as `-IfMatch` apply only to PATCH. Its pre-update ETag
must not be replayed automatically on GET after the resource changes. Explicit values
inside `-Headers`, including a caller-supplied `If-Match`, remain caller-controlled and
are preserved unchanged; there is no header-name filtering. Mutation body and query
bindings are not copied.

The existing behavior is otherwise unchanged: mandatory IDs choose the route, one
worker owns `ShouldProcess`, WhatIf and declined confirmation return before writing,
a non-null PATCH result is returned without GET, PATCH-only routes write no output
for an empty response, and PUT never gains a fallback read.

## Regression gates

`PatchRefetchTests` generates both profiles through the normal generation service,
including the isolated group-registration seam already used by generator tests.
Existing `EmitterTests` and `MutationRouteTests` continue to pin GET availability.

```powershell
dotnet test .\tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj `
  --filter 'FullyQualifiedName~PatchRefetchTests|FullyQualifiedName~EmitterTests|FullyQualifiedName~MutationRouteTests'
```

The compiled transport gate requires Kiota, the .NET SDK, PowerShell 7 on .NET 10,
and the original official `Microsoft.Graph.Authentication` 2.38.1 on process-local
`PSModulePath`. Run once per profile, with a different new artifact directory:

```powershell
dotnet build .\tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj
pwsh -NoProfile -File .\tools\Test-WrapperPatchRefetch.ps1 `
  -FixtureRoot <new-artifact-directory> -ApiVersion v1.0 -KiotaPath <kiota.exe>
```

The gate generates an actual Kiota C# client, compiles ordinary/grouped wrappers
against the real shared runtime, and imports the normal manifest in a fresh child.
It substitutes only the shared GraphSession HttpClient with an offline terminal
capture handler. It checks exact escaped routes, typed JSON and models, generic
headers on PATCH/GET, typed IfMatch on PATCH only, explicit generic conditional
headers, non-null PATCH results, mixed GET/no-GET groups, ordinary/grouped PUT,
WhatIf, genuinely declined confirmation, and exactly one accepted prompt even when
PATCH causes a GET. Each profile must complete 19 checks, 18 actual prompts and 27
captured requests with zero live Graph requests.

`FixtureRoot` retains the spec, generated client/wrappers, build outputs,
`provenance.json` and `transport-result.json`. No generated module files are added
to the source tree. No assembly injection or Authentication modification is used.

On a target that cannot yet serialize bodies with official Authentication, this is
not a normal-source runtime PASS. `-PackagingTemplateRoot <candidate-tools\Templates>`
can explicitly select a separately reviewed module-packaging candidate for artifact
proof. Its template path/hash, generator hash and candidate status are recorded in
provenance. The normal client template, generator, Authentication and shared runtime
still come from this source. This does not overlay or stack packaging source into the
branch, and the emitter fix has no packaging dependency.
