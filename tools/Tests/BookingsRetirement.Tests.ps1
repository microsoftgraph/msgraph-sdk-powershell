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
    $fixture = $header + $retired + $retained
    function Write-BookingsFixture([string]$Path, [string]$Text) {
        [System.IO.File]::WriteAllText($Path, $Text, [System.Text.UTF8Encoding]::new($false))
    }
}

Describe 'Reviewed Bookings beta retirement policy' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item $casePath -ItemType Directory
        $spec = Join-Path $casePath 'Bookings.yml'
    }

    It 'prunes unannotated roots and quoted/case-insensitive descendants while preserving every unrelated byte (<Ending>, BOM=<Bom>)' -TestCases @(
        @{ Ending = "`n"; Bom = $false }
        @{ Ending = "`r`n"; Bom = $false }
        @{ Ending = "`r`n"; Bom = $true }
    ) {
        param($Ending, $Bom)
        $text = $fixture.Replace("`r`n", "`n").Replace("`n", $Ending).TrimEnd("`r", "`n")
        $expected = ($header + $retained).Replace("`r`n", "`n").Replace("`n", $Ending).TrimEnd("`r", "`n")
        [System.IO.File]::WriteAllText($spec, $text, [System.Text.UTF8Encoding]::new($Bom))
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        $bytes = [System.IO.File]::ReadAllBytes($spec)
        $expectedBytes = [System.Text.UTF8Encoding]::new($Bom).GetPreamble() +
            [System.Text.UTF8Encoding]::new($false).GetBytes($expected)
        [Convert]::ToBase64String($bytes) | Should -BeExactly ([Convert]::ToBase64String($expectedBytes))
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        $entries = @($report.modules.Bookings.PSObject.Properties)
        $entries.Count | Should -Be 4
        @($entries.Value.operationsRemoved).Count | Should -Be 5
        foreach ($entry in $entries) {
            $entry.Value.uriRemoved | Should -BeTrue
            $entry.Value.retirement.removalDate | Should -Be '2024-04-30'
            $entry.Value.retirement.source | Should -BeLike '*breaking-changes-in-microsoft-bookings-graph-apis-beta/'
        }
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [Convert]::ToBase64String([System.IO.File]::ReadAllBytes($spec)) |
            Should -BeExactly ([Convert]::ToBase64String($bytes))
        $secondReport = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        @($secondReport.modules.PSObject.Properties).Count | Should -Be 0
    }

    It 'does not apply beta retirement to v1.0 or an unrelated module' {
        Write-BookingsFixture $spec ($fixture.Replace('version: beta', 'version: v1.0'))
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly ($fixture.Replace('version: beta', 'version: v1.0'))
        $other = Join-Path $casePath 'Other.yml'
        Write-BookingsFixture $other $fixture
        & $pruner -OpenApiFilesPath $other -GraphVersion beta -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($other) | Should -BeExactly $fixture
    }

    It 'requires an identifiable profile and accepts an explicit profile when info is missing' {
        $text = $fixture.Replace("info:`n  title: Bookings`n  version: beta`n", '')
        Write-BookingsFixture $spec $text
        { & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate } |
            Should -Throw '*Cannot determine GraphVersion*'
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $text
        & $pruner -OpenApiFilesPath $spec -GraphVersion beta -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $text.Replace($retired, '')
    }

    It 'respects the retirement date and configured buffer' {
        Write-BookingsFixture $spec $fixture
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc ([datetime]'2024-05-01T00:00:00Z')
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $fixture
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc ([datetime]'2024-05-02T00:00:00Z')
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly ($header + $retained)
    }

    It 'removes retired path objects even when they have only path-level parameters' {
        Write-BookingsFixture $spec ($header + @'
  '/bookingBusinesses/{business-id}':
    parameters:
      - name: business-id
        in: path
components:
  schemas: {}
'@)
        & $pruner -OpenApiFilesPath $spec -ReferenceDateUtc $referenceDate
        Get-Content $spec -Raw | Should -Match '(?m)^paths: \{\}'
        Get-Content $spec -Raw | Should -Not -Match 'business-id'
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        $entry = $report.modules.Bookings.PSObject.Properties['/bookingBusinesses/{business-id}'].Value
        @($entry.operationsRemoved).Count | Should -Be 0
        $entry.uriRemoved | Should -BeTrue
    }

    It 'removes all 29 historical source paths and 53 operations without changing retained source text' {
        $original = [System.IO.File]::ReadAllText((Join-Path $repo 'openApiDocs\beta\Bookings.yml'))
        Write-BookingsFixture $spec $original
        & $pruner -OpenApiFilesPath $spec -GraphVersion beta -ReferenceDateUtc $referenceDate
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        $retirements = @($report.modules.Bookings.PSObject.Properties |
            Where-Object { $_.Value.PSObject.Properties['retirement'] })
        $retirements.Count | Should -Be 29
        @($retirements.Value.operationsRemoved).Count | Should -Be 53
        $actual = [System.IO.File]::ReadAllText($spec)
        $actual.Substring($actual.IndexOf("`ncomponents:")) |
            Should -BeExactly $original.Substring($original.IndexOf("`ncomponents:"))
        $actual | Should -Not -Match '(?im)^  [''"]?/(bookingBusinesses|bookingCurrencies)(?:/|[''"]?:)'
        $actual | Should -Match '(?m)^  /solutions/bookingBusinesses:'
        $actual | Should -Match '(?m)^  /solutions/bookingCurrencies:'
    }

    It 'keeps the active <Profile> compatible spec free of retired roots without further rewriting' -TestCases @(
        @{ Profile = 'v1.0' }
        @{ Profile = 'beta' }
    ) {
        param($Profile)
        $current = [System.IO.File]::ReadAllText((Join-Path $repo "openApiDocs_KiotaCompat\$Profile\Bookings.yml"))
        $current | Should -Not -Match '(?im)^  [''"]?/(bookingBusinesses|bookingCurrencies)(?:/|[''"]?:)'
        Write-BookingsFixture $spec $current
        & $pruner -OpenApiFilesPath $spec -GraphVersion $Profile -ReferenceDateUtc $referenceDate
        [System.IO.File]::ReadAllText($spec) | Should -BeExactly $current
        $current | Should -Match '(?m)^  /solutions/bookingBusinesses:'
    }
}

Describe 'Bookings retirement refresh entrypoints' {
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
            Should -BeExactly ($header + $retained)
        $report = Get-Content (Join-Path $casePath 'deprecated-removals.json') -Raw | ConvertFrom-Json
        @($report.modules.Bookings.PSObject.Properties).Count | Should -Be 4
        Should -Invoke Invoke-WebRequest -Times $(if ($Projection) { 2 } else { 1 }) -Exactly
    }

    It 'prunes full-profile beta refresh after ID tweaks and retains the complete aggregate report' {
        $mapping = Join-Path $casePath 'mapping.jsonc'
        Write-BookingsFixture $mapping '{"Bookings":"^bookingBusinesses\\."}'
        & $update -ModuleMappingConfigPath $mapping -OpenApiDocOutput $casePath -BetaGraphVersion -SkipForceRefresh
        [System.IO.File]::ReadAllText((Join-Path $casePath 'beta\Bookings.yml')) |
            Should -BeExactly ($header + $retained)
        $report = Get-Content (Join-Path $casePath 'beta\deprecated-removals.json') -Raw | ConvertFrom-Json
        @($report.modules.Bookings.PSObject.Properties).Count | Should -Be 4
        @($report.modules.Bookings.PSObject.Properties.Value.operationsRemoved).Count | Should -Be 5
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
