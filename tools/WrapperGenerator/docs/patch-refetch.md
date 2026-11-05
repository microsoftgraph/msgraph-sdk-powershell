# PATCH refetch headers

When PATCH returns no model and the same selected path supports GET, an Update worker
re-fetches through that path's typed Kiota builder. Both ordinary workers and grouped
mutation workers use `ReFetchBlock`. The follow-up request binds the selected GET's
own required native queries through `RequiredQueryBindings(ctx.RefetchRequiredQueries)`
and the inherited generic `-Headers` dictionary through `GenericHeadersBinding` /
`AddRequestHeaders`. The mutation's `ctx.RequiredQueries` never supplies GET bindings.

Typed mutation parameters such as `-IfMatch` apply only to PATCH. Its pre-update ETag
must not be replayed automatically on GET after the resource changes. Explicit values
inside `-Headers`, including a caller-supplied `If-Match`, remain caller-controlled and
are preserved unchanged; there is no header-name filtering. Mutation body and query
bindings are not copied. The PATCH command declares the compatible union of its
required native queries and the selected GET's requirements, preserving mandatory
`Query<Name>` parameters and each Kiota member/wire name. For example, PATCH can
require `-QueryTenantId` while its GET requires `-QueryView`; only `tenantId` is sent
on PATCH and only `view` on GET. This does not expand the existing restrictions on
query-bearing natural-ID operation groups or add optional query support.

The existing behavior is otherwise unchanged: mandatory IDs choose the route, one
worker owns `ShouldProcess`, WhatIf and declined confirmation return before writing,
a non-null PATCH result is returned without GET, PATCH-only routes write no output
for an empty response, and PUT never gains a fallback read.

## Regression gates

`PatchRefetchTests` generates both profiles through the normal generation service,
including the isolated group-registration seam already used by generator tests.
Existing `EmitterTests` and `MutationRouteTests` continue to pin GET availability.
`CompositeKeyTests` requires the same typed constructor and complete parent/key
dictionary on the generic-header refetch, retaining distinct body/path parameters.
`RequiredQueryTests` also pins independent mutation/refetch contracts and their
generic-header binding.

```powershell
dotnet test .\tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj `
  --filter 'FullyQualifiedName~PatchRefetchTests|FullyQualifiedName~EmitterTests|FullyQualifiedName~MutationRouteTests|FullyQualifiedName~CompositeKeyTests|FullyQualifiedName~RequiredQueryTests'
```

The compiled transport gate requires Kiota, the .NET SDK, PowerShell 7 on .NET 10,
and the normally built `Microsoft.Graph.Authentication` package from the current
source (2.41.2 after #3891) on process-local `PSModulePath`. Identify its exact manifest
to reject a different package with the same version. Run once per profile, with a
different new artifact directory:

```powershell
dotnet build .\tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj
pwsh -NoProfile -File .\tools\Test-WrapperPatchRefetch.ps1 `
  -FixtureRoot <new-artifact-directory> -ApiVersion v1.0 -KiotaPath <kiota.exe> `
  -AuthenticationModulePath <built-Authentication.psd1> -Environment Global
```

The gate generates an actual Kiota C# client, compiles ordinary/grouped/composite wrappers
against the real shared runtime, packs using the repository's normal template and
NuGet file/dependency conventions, and imports its unpacked manifest in a fresh
child. The wrapper package carries only its three own DLLs and no dependency
preloads. Authentication owns the complete Kiota closure, including
RecyclableMemoryStream, UriTemplate and Multipart.

The gate connects with a synthetic offline token and an in-memory test data store.
Its terminal capture handler is inserted after the real Authentication factory's
token handler, so every captured PATCH/GET must be authenticated. It preserves the
factory's default global v1.0 HttpClient BaseAddress while generated beta/USGov
requests use their selected service root through the normal session adapter cache.
Run `-ApiVersion beta -Environment USGov` in a separate new fixture directory for
that representative cloud/profile check. The adapter is reused
and the shared client/BaseAddress remains unchanged. It checks exact escaped routes,
typed JSON and models, independent encoded PATCH/GET required queries, generic
headers on PATCH/GET, typed IfMatch on PATCH only, explicit generic conditional
headers, non-null PATCH results, mixed GET/no-GET groups, ordinary/grouped PUT,
WhatIf, genuinely declined confirmation, and exactly one accepted prompt even when
PATCH causes a GET. Each invocation must complete 22 transport checks, 12
missing/empty/null query binder checks with zero HTTP, 20 actual prompts and 32
captured requests with zero live Graph requests. Ordinary Agreement and composite
HealthScriptState PATCH require `QueryTenantId` and their GET requires `QueryView`;
the grouped and mixed GET/no-GET neighbors keep their existing no-query contract.

The merged required-query family gate now requires its generic header on both
PATCH and GET while still rejecting typed mutation IfMatch on GET. Its former
missing-header expectation was a historical baseline, not a valid new behavior.
Run it on both profiles and a representative USGov process using the same normal
Authentication environment and shared generation queue:

```powershell
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredQuery.ps1 `
  -ArtifactRoot <new-directory> -ApiVersion beta -Environment USGov -KiotaPath <kiota.exe>
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredDeleteQuery.ps1 `
  -ArtifactRoot <new-directory> -ApiVersion beta -KiotaPath <kiota.exe>
```

These retain the generalized required-query family, pagination/delta isolation,
typed inputs and native wire formats, and narrow bodyless DELETE neighbor coverage.

`FixtureRoot` retains the spec, generated client/wrappers, build outputs, NuGet
package, unpacked module, `provenance.json` and `transport-result.json`. It asserts
one Authentication/Kiota assembly identity from the expected package directory
and loader context. No generated module files are added to the source tree.
No dependency assembly injection or Authentication modification is used.

Historical proof before #3891 used Authentication 2.38.1 and an explicitly isolated
#3878 packaging candidate; the then-normal template failed body serialization for
missing RecyclableMemoryStream. Those artifacts remain historical evidence, not
the current support contract or a current blocker. The current gate has no
packaging-overlay option: templates, Authentication and runtime must follow the
normally merged source.
