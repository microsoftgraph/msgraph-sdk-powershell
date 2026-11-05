# PATCH result semantics

A generated Update command issues PATCH and returns only the model provided by that
response. A successful `204 No Content` returns no object and is success. It never
issues an implicit GET, even if the path supports GET. There is no ReadBack, PassThru
or Refetch switch and no hidden retrieval request.

The caller can retrieve the updated resource with a separate explicit command:

```powershell
Update-MgWidget -WidgetId $id -QueryTenantId $tenant -DisplayName 'updated' -Confirm:$false
Get-MgWidget -WidgetId $id -QueryView 'current' -Headers @{ 'X-Caller' = 'read' }
```

Each operation requires and binds only its own native query parameters. A GET-only
`QueryView` is absent from PATCH; `QueryTenantId` stays mandatory on PATCH when its
OpenAPI operation requires it. GET's query type, availability or authorization does
not affect the completed PATCH. Unsupported selected GET inputs still fail their
own generation checks; an unselected GET does not constrain PATCH generation.

Ordinary, grouped and composite mutations retain the selected typed Kiota builder,
path/body IDs, per-request generic headers, typed IfMatch, output model declaration,
error/cancellation behavior and one worker-owned ShouldProcess prompt. WhatIf and
declined confirmation return before body/transport work. PUT/no-GET neighbors keep
the same no-read-back semantics. Transport retries are unchanged.

## Regression gates

The existing `PatchRefetchTests` and `Test-WrapperPatchRefetch.ps1` filenames are
retained for continuity; their assertions now positively require **no read-back**.
`EmitterTests`, `MutationRouteTests` and `CompositeKeyTests` preserve typed receiver,
complete key dictionary/body separation and operation metadata coverage.
`RequiredQueryTests` checks independent PATCH/GET input types and unselected
unsupported GET metadata.

```powershell
dotnet build tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj --no-incremental
dotnet test tools\WrapperGenerator.Tests\WrapperGenerator.Tests.csproj --no-build `
  --filter 'FullyQualifiedName~PatchRefetchTests|FullyQualifiedName~EmitterTests|FullyQualifiedName~MutationRouteTests|FullyQualifiedName~CompositeKeyTests|FullyQualifiedName~RequiredQueryTests'
```

The compiled gate requires Kiota 1.36.1, the .NET SDK, PowerShell 7 on .NET 10 and the
normally built Authentication 2.41.2 package first on process-local PSModulePath.
Run once per profile plus representative USGov coverage, with new artifact roots:

```powershell
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperPatchRefetch.ps1 `
  -FixtureRoot <new-directory> -ApiVersion beta -Environment USGov `
  -KiotaPath <kiota.exe> -AuthenticationModulePath <normal-built-Authentication.psd1>
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredQuery.ps1 `
  -ArtifactRoot <new-directory> -ApiVersion beta -Environment USGov -KiotaPath <kiota.exe>
pwsh -NoProfile -NonInteractive -File .\tools\Test-WrapperRequiredDeleteQuery.ps1 `
  -ArtifactRoot <new-directory> -ApiVersion beta -KiotaPath <kiota.exe>
```

The PATCH gate generates real Kiota C# and generation-service ordinary/grouped/
composite wrappers, compiles and NuGet-packs with the normal repository templates,
then imports the unpacked manifest in a fresh process. The terminal capture handler
follows the real Connect-MgGraph/GraphHttpClientFactory token pipeline with an
in-memory test store and no live Graph/OAuth. Authentication owns one full Kiota
closure; wrappers carry only their three own DLLs and no dependency preloads.
The selected Global/USGov service root comes from the normal session adapter without
mutating the shared client's factory-default v1.0 BaseAddress.

Every PATCH204 case must send one PATCH, return no output and succeed with GET
deliberately configured to reject authorization. Every PATCH200 case must send one
PATCH and return its actual Kiota response model. Required mutation queries and
headers are captured exactly, including typed/generic conditional headers.
Two explicit GETs prove caller-selected retrieval with their own mandatory query
and headers; a rejected explicit GET is a separate error. Each invocation completes
25 checks, 12 missing/empty/null query binder checks with zero HTTP, 20 genuine
confirmation prompts and 25 captured requests, with zero live Graph calls.

The generalized required-query family gate independently verifies PATCH204 no
output/one request, explicit GET's view query, native string/bool/zero/array/formatted
inputs, paging/delta isolation and DELETE/bodyless neighbors. `FixtureRoot` retains
all spec/generated source/projects/build/package/capture/provenance evidence.

The earlier implicit GET header-loss proofs and old 2.38.1/RecyclableMemoryStream
packaging limitation are preserved historical artifacts. The user-directed
one-operation semantics supersede implicit-read-back acceptance: absence of a
follow-up GET is now the intended success condition, not a header gate failure.
