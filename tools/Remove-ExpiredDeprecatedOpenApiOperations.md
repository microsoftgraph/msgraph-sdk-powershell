# Remove expired deprecated OpenAPI operations

`Remove-ExpiredDeprecatedOpenApiOperations.ps1` removes HTTP operations that:

- have `deprecated: true`;
- have an `x-ms-deprecation.removalDate` in `yyyy-MM-dd` format; and
- have a removal date on or before UTC today minus the configured buffer.

The default buffer is two days. The script updates OpenAPI documents in place and writes a
`deprecated-removals.json` report next to the processed document or in the processed directory.

Module-specific cmdlet retirement belongs in the module's `*_cmdletConfigurations.cs`,
not this generic OpenAPI pruner. For example, Bookings' beta-only configuration suppresses
cmdlets for the retired `/bookingBusinesses` and `/bookingCurrencies` root families.
Unannotated legacy paths remain in the compatible OpenAPI input and generated Kiota HTTP
client; the supported `/solutions/...` cmdlets and v1.0 behavior are unaffected.

## Process one API document

Pass a `.yml` or `.yaml` file to `OpenApiFilesPath`:

```powershell
.\tools\Remove-ExpiredDeprecatedOpenApiOperations.ps1 `
    -OpenApiFilesPath .\openApiDocs_KiotaCompat\beta\Users.yml
```

## Process every API document in a profile

Pass a directory to process each `.yml` file directly within it:

```powershell
.\tools\Remove-ExpiredDeprecatedOpenApiOperations.ps1 `
    -OpenApiFilesPath .\openApiDocs_KiotaCompat\v1.0
```

## Change the buffer or report location

```powershell
.\tools\Remove-ExpiredDeprecatedOpenApiOperations.ps1 `
    -OpenApiFilesPath .\openApiDocs_KiotaCompat\beta\Users.yml `
    -RemovalDateBufferDays 1 `
    -ReportPath .\artifacts\users-deprecated-removals.json
```

`ReportPath` can be absolute or relative to the processed document's directory. Its parent
directory must already exist.

## Removal behavior

- Expired operations are removed individually.
- A URI path is removed only when no HTTP operations remain.
- Deprecated operations without `removalDate` are retained.
- An invalid `removalDate` stops processing before any OpenAPI document is changed.
- The JSON report is keyed by module filename and URI and lists removed methods plus whether the
  URI itself was removed.
- Documents are edited by removing line ranges, not reserializing YAML. Unrelated text,
  schemas, encoding, and line endings are retained.

Both the bulk Kiota-compatible refresh and standalone download invoke pruning automatically:

```powershell
.\tools\UpdateOpenApiKiotaCompat.ps1
.\tools\UpdateOpenApiKiotaCompat.ps1 -BetaGraphVersion
.\tools\DownloadOpenApiDocKiotaCompat.ps1 -ModuleName Bookings `
    -ModuleRegex '^(bookingBusinesses|bookingCurrencies|solutions)\.' `
    -OpenApiDocOutput .\openApiDocs_KiotaCompat\beta -GraphVersion beta -SingularizeOperationIds
```

The bulk refresh defers per-file pruning until after its operation-ID tweaks so it produces
one complete profile removal report. The standalone downloader prunes immediately after a
successful download/ID projection and propagates pruning errors. Historical `openApiDocs`
and module directive markdown are not rewritten.
