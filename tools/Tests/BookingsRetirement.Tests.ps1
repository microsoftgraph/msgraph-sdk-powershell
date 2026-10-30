# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
BeforeAll {
    $tools = Split-Path $PSScriptRoot -Parent
    $pruner = Join-Path $tools 'Remove-ExpiredDeprecatedOpenApiOperations.ps1'
    $download = Join-Path $tools 'DownloadOpenApiDocKiotaCompat.ps1'
    $update = Join-Path $tools 'UpdateOpenApiKiotaCompat.ps1'
    $repo = Split-Path $tools -Parent
    $referenceDate = [datetime]'2026-10-27T00:00:00Z'
    $header = "openapi: 3.0.4`ninfo:`n  title: Bookings`n  version: beta`npaths:`n"
    $retired = @'
  /bookingBusinesses:
    get:
      operationId: legacy_List
    post:
      operationId: legacy_Create
  '/BOOKINGBUSINESSES/{business-id}/appointments':
    get:
      operationId: legacy_Appointments
  "/bookingCurrencies":
    get:
      operationId: legacy_Currencies
  '/bookingCurrencies/{currency-id}':
    delete:
      operationId: legacy_DeleteCurrency
'@ + "`n"
    $retained = @'
  /solutions/bookingBusinesses:
    get:
      operationId: solution_List
  '/solutions/bookingCurrencies/{currency-id}':
    get:
      operationId: solution_Currency
  /bookingBusinessesArchive:
    get:
      operationId: archive_List
  '/bookingCurrencies-extra/child':
    get:
      operationId: extra_List
  /other/bookingBusinesses:
    get:
      operationId: other_List
  x-paths-metadata: preserve
components:
  schemas:
    bookingBusiness:
      description: "/bookingBusinesses and /bookingCurrencies are historical example text"
      type: object
      discriminator:
        propertyName: '@odata.type'
      properties:
        related:
          anyOf:
            - $ref: '#/components/schemas/bookingBusiness'
            - type: string
'@ + "`n"
    $expired = @'
  /expired:
    delete:
      operationId: expired_Delete
      deprecated: true
      x-ms-deprecation:
        removalDate: '2020-01-01'
'@ + "`n"
    $unannotatedFixture = $header + $retired + $retained
    $fixture = $header + $retired + $expired + $retained
    function Write-BookingsFixture([string]$Path, [string]$Text) {
        [System.IO.File]::WriteAllText($Path, $Text, [System.Text.UTF8Encoding]::new($false))
    }
}

Describe 'Bookings uses generic annotated deprecation pruning only' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item $casePath -ItemType Directory
        $spec = Join-Path $casePath 'Bookings.yml'
    }

    It 'prunes only annotated expired operations while preserving every unrelated byte (<Ending>, BOM=<Bom>)' -TestCases @(
        @{ Ending = "`n"; Bom = $false }
        @{ Ending = "`r`n"; Bom = $false }
        @{ Ending = "`r`n"; Bom = $true }
    ) {
        param($Ending, $Bom)
        $text = $fixture.Replace("`r`n", "`n").Replace("`n", $Ending).TrimEnd("`r", "`n")
        $expected = $unannotatedFixture.Replace("`r`n", "`n").Replace("`n", $Ending).TrimEnd("`r", "`n")
        [System.IO.File]::WriteAllText($spec, $text, [System.Text.UTF8Encoding]::new($Bom))
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        $bytes = [System.IO.File]::ReadAllBytes($spec)
        $expectedBytes = [System.Text.UTF8Encoding]::new($Bom).GetPreamble() +
            [System.Text.UTF8Encoding]::new($false).GetBytes($expected)
        [Convert]::ToBase64String($bytes) | Should -BeExactly ([Convert]::ToBase64String($expectedBytes))
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        $entries = @($report.modules.Bookings.PSObject.Properties)
        $entries.Count | Should -Be 1
        $entries[0].Name | Should -Be '/expired'
        @($entries[0].Value.operationsRemoved) | Should -Be @('delete')
        $entries[0].Value.uriRemoved | Should -BeTrue
        @($entries[0].Value.PSObject.Properties.Name) | Should -Not -Contain 'retirement'
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [Convert]::ToBase64String([System.IO.File]::ReadAllBytes($spec)) |
            Should -BeExactly ([Convert]::ToBase64String($bytes))
        $secondReport = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        @($secondReport.modules.PSObject.Properties).Count | Should -Be 0
    }

    It 'preserves unannotated legacy roots regardless of profile (<Profile>)' -TestCases @(
        @{ Profile = 'beta' }
        @{ Profile = 'v1.0' }
    ) {
        param($Profile)
        $text = $unannotatedFixture.Replace('version: beta', "version: $Profile")
        Write-BookingsFixture $spec $text
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $text
        $other = Join-Path $casePath 'Other.yml'
        Write-BookingsFixture $other $text
        & $pruner -OpenApiFilesPath $other -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($other) | Should -BeExactly $text
    }

    It 'does not require a profile for unannotated Bookings routes' {
        $text = $unannotatedFixture.Replace("info:`n  title: Bookings`n  version: beta`n", '')
        Write-BookingsFixture $spec $text
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $text
    }

    It 'preserves unannotated paths with only path-level parameters' {
        $text = $header + @'
  '/bookingBusinesses/{business-id}':
    parameters:
      - name: business-id
        in: path
components:
  schemas: {}
'@
        Write-BookingsFixture $spec $text
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $text
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        @($report.modules.PSObject.Properties).Count | Should -Be 0
    }

    It 'does not hard-code retirement of the 29 historical Bookings root paths' {
        $original = [System.IO.File]::ReadAllText((Join-Path $repo 'openApiDocs\beta\Bookings.yml'))
        Write-BookingsFixture $spec $original
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        $actual = [System.IO.File]::ReadAllText($spec)
        $actual | Should -BeExactly $original
        [regex]::Matches($actual, '(?im)^  [''"]?/(bookingBusinesses|bookingCurrencies)(?:/[^:]*|[''"]?):').Count |
            Should -Be 29
        $actual | Should -Match '(?m)^  /solutions/bookingBusinesses:'
        $actual | Should -Match '(?m)^  /solutions/bookingCurrencies:'
    }

    It 'retains the active <Profile> compatible spec without module-specific pruning' -TestCases @(
        @{ Profile = 'v1.0' }
        @{ Profile = 'beta' }
    ) {
        param($Profile)
        $current = [System.IO.File]::ReadAllText((Join-Path $repo "openApiDocs_KiotaCompat\$Profile\Bookings.yml"))
        if ($Profile -eq 'beta') {
            $current | Should -Match '(?m)^  /bookingBusinesses:'
            $current | Should -Match '(?m)^  /bookingCurrencies:'
        }
        else {
            $current | Should -Not -Match '(?im)^  [''"]?/(bookingBusinesses|bookingCurrencies)(?:/|[''"]?:)'
        }
        Write-BookingsFixture $spec $current
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $current
        $current | Should -Match '(?m)^  /solutions/bookingBusinesses:'
    }
}

Describe 'Bookings refresh entrypoints retain legacy routes and prune annotated operations' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item $casePath -ItemType Directory
        Import-Module powershell-yaml -ErrorAction Stop
        $reference = ConvertFrom-Yaml $fixture -Ordered
        Mock Invoke-WebRequest {
            param($Uri, $OutFile)
            if ($OutFile) { Write-BookingsFixture $OutFile $fixture }
            else { @{ Content = ($reference | ConvertTo-Json -Depth 30) } }
        }
    }

    It 'prunes standalone downloads both with and without operation-ID projection (Projection=<Projection>)' -TestCases @(
        @{ Projection = $false }
        @{ Projection = $true }
    ) {
        param($Projection)
        & $download -ModuleName Bookings -ModuleRegex '^bookingBusinesses\.' -GraphVersion beta `
            -OpenApiDocOutput $casePath -SingularizeOperationIds:$Projection
        [System.IO.File]::ReadAllText((Join-Path $casePath 'Bookings.yml')) |
            Should -BeExactly $unannotatedFixture
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        @($report.modules.Bookings.PSObject.Properties).Count | Should -Be 1
        $report.modules.Bookings.PSObject.Properties.Name | Should -Be '/expired'
        Should -Invoke Invoke-WebRequest -Times $(if ($Projection) { 2 } else { 1 }) -Exactly
    }

    It 'prunes full-profile beta refresh after ID tweaks and retains the complete aggregate report' {
        $mapping = Join-Path $casePath 'mapping.jsonc'
        Write-BookingsFixture $mapping '{"Bookings":"^bookingBusinesses\\."}'
        & $update -ModuleMappingConfigPath $mapping -OpenApiDocOutput $casePath -BetaGraphVersion -SkipForceRefresh
        [System.IO.File]::ReadAllText((Join-Path $casePath 'beta\Bookings.yml')) |
            Should -BeExactly $unannotatedFixture
        $report = Get-Content (Join-Path $casePath 'beta\deprecated-removals.json') -Raw | ConvertFrom-Json
        @($report.modules.Bookings.PSObject.Properties).Count | Should -Be 1
        $report.modules.Bookings.PSObject.Properties.Name | Should -Be '/expired'
        @($report.modules.Bookings.PSObject.Properties.Value.operationsRemoved) | Should -Be @('delete')
        Should -Invoke Invoke-WebRequest -Times 2 -Exactly
    }

    It 'propagates standalone pruning errors rather than reporting download success' {
        Mock Invoke-WebRequest {
            param($Uri, $OutFile)
            Write-BookingsFixture $OutFile ($fixture.Replace(
                '      operationId: solution_List',
                "      operationId: solution_List`n      deprecated: true`n      x-ms-deprecation:`n        removalDate: invalid"))
        }
        { & $download -ModuleName Bookings -ModuleRegex '^bookingBusinesses\.' -GraphVersion beta `
            -OpenApiDocOutput $casePath } | Should -Throw '*Invalid removalDate*'
    }
}
