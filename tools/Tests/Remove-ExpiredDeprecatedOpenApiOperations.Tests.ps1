# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
BeforeAll {
    $scriptPath = Join-Path $PSScriptRoot '..\Remove-ExpiredDeprecatedOpenApiOperations.ps1'
    $referenceDate = [datetime]::Parse('2026-09-30T12:00:00Z').ToUniversalTime()

    function Write-TestOpenApi {
        param(
            [Parameter(Mandatory = $true)]
            [string] $Path,

            [Parameter(Mandatory = $true)]
            [string] $Content
        )

        $crlfContent = $Content.TrimStart("`r", "`n").Replace("`r`n", "`n").Replace("`n", "`r`n")
        [System.IO.File]::WriteAllText(
            $Path,
            $crlfContent,
            [System.Text.UTF8Encoding]::new($false)
        )
    }
}

Describe 'Remove-ExpiredDeprecatedOpenApiOperations' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item -Path $casePath -ItemType Directory
    }

    It 'removes expired operations and empty paths and writes the removal report' {
        $openApiPath = Join-Path $casePath 'ModuleA.yml'
        Write-TestOpenApi -Path $openApiPath -Content @'
openapi: 3.0.1
paths:
  '/mixed':
    get:
      operationId: mixed_Get
      responses:
        2XX:
          description: Success
      deprecated: true
      x-ms-deprecation:
        removalDate: '2026-09-28'
    post:
      operationId: mixed_Post
      responses:
        2XX:
          description: Success
      deprecated: true
      x-ms-deprecation:
        removalDate: '2026-10-01'
  '/fully-expired':
    get:
      operationId: fullyExpired_Get
      deprecated: true
      x-ms-deprecation:
        removalDate: '2020-01-01'
    delete:
      operationId: fullyExpired_Delete
      deprecated: true
      x-ms-deprecation:
        removalDate: '2021-01-01'
  x-paths-metadata: retained
  '/not-deprecated':
    get:
      operationId: notDeprecated_Get
      deprecated: false
      x-ms-deprecation:
        removalDate: '2020-01-01'
  '/missing-date':
    get:
      operationId: missingDate_Get
      deprecated: true
      x-ms-deprecation:
        description: No removal date
components:
  schemas: {}
'@

        & $scriptPath `
            -OpenApiFilesPath $casePath `
            -ReferenceDateUtc $referenceDate `
            -RemovalDateBufferDays 2

        $updatedContent = [System.IO.File]::ReadAllText($openApiPath)
        $updatedContent | Should -Not -Match 'mixed_Get'
        $updatedContent | Should -Match 'mixed_Post'
        $updatedContent | Should -Not -Match '/fully-expired'
        $updatedContent | Should -Match 'x-paths-metadata: retained'
        $updatedContent | Should -Match 'notDeprecated_Get'
        $updatedContent | Should -Match 'missingDate_Get'
        $updatedContent | Should -Match "`r`n"
        $updatedContent.Replace("`r`n", '') | Should -Not -Match "`n"

        $reportPath = Join-Path $casePath 'deprecated-removals.json'
        $report = Get-Content -LiteralPath $reportPath -Raw | ConvertFrom-Json
        $report.cutoffDate | Should -Be '2026-09-28'
        $report.bufferDays | Should -Be 2
        $report.generatedAtUtc | Should -Not -BeNullOrEmpty

        $moduleReport = $report.modules.ModuleA
        $mixedReport = $moduleReport.PSObject.Properties['/mixed'].Value
        @($mixedReport.operationsRemoved) | Should -Be @('get')
        $mixedReport.uriRemoved | Should -BeFalse

        $removedUriReport = $moduleReport.PSObject.Properties['/fully-expired'].Value
        @($removedUriReport.operationsRemoved) | Should -Be @('get', 'delete')
        $removedUriReport.uriRemoved | Should -BeTrue
    }

    It 'uses the configurable buffer and removes operations on the cutoff date' {
        $openApiPath = Join-Path $casePath 'ModuleB.yml'
        Write-TestOpenApi -Path $openApiPath -Content @'
openapi: 3.0.1
paths:
  '/buffered':
    get:
      operationId: buffered_Get
      deprecated: true
      x-ms-deprecation:
        removalDate: '2026-09-29'
components:
  schemas: {}
'@

        & $scriptPath `
            -OpenApiFilesPath $openApiPath `
            -ReferenceDateUtc $referenceDate `
            -RemovalDateBufferDays 2 `
            -ReportPath 'first-report.json'

        [System.IO.File]::ReadAllText($openApiPath) | Should -Match 'buffered_Get'

        & $scriptPath `
            -OpenApiFilesPath $openApiPath `
            -ReferenceDateUtc $referenceDate `
            -RemovalDateBufferDays 1

        [System.IO.File]::ReadAllText($openApiPath) | Should -Not -Match '/buffered'
        $report = Get-Content -LiteralPath (Join-Path $casePath 'deprecated-removals.json') -Raw |
            ConvertFrom-Json
        $report.cutoffDate | Should -Be '2026-09-29'
        $report.modules.ModuleB.PSObject.Properties['/buffered'].Value.uriRemoved |
            Should -BeTrue
    }

    It 'is idempotent and replaces the report with an empty removal map' {
        $openApiPath = Join-Path $casePath 'ModuleC.yml'
        Write-TestOpenApi -Path $openApiPath -Content @'
openapi: 3.0.1
paths:
  '/expired':
    trace:
      operationId: expired_Trace
      deprecated: true
      x-ms-deprecation:
        removalDate: '2020-01-01'
components:
  schemas: {}
'@

        & $scriptPath -OpenApiFilesPath $casePath -ReferenceDateUtc $referenceDate
        $contentAfterFirstRun = [System.IO.File]::ReadAllText($openApiPath)
        $contentAfterFirstRun | Should -Match '(?m)^paths: \{\}\r?$'
        & $scriptPath -OpenApiFilesPath $casePath -ReferenceDateUtc $referenceDate

        [System.IO.File]::ReadAllText($openApiPath) | Should -BeExactly $contentAfterFirstRun
        $report = Get-Content -LiteralPath (Join-Path $casePath 'deprecated-removals.json') -Raw |
            ConvertFrom-Json
        @($report.modules.PSObject.Properties).Count | Should -Be 0
    }

    It 'fails before modifying any document when a removal date is malformed' {
        $validPath = Join-Path $casePath 'AValid.yml'
        $validContent = @'
openapi: 3.0.1
paths:
  '/expired':
    get:
      operationId: expired_Get
      deprecated: true
      x-ms-deprecation:
        removalDate: '2020-01-01'
components:
  schemas: {}
'@
        Write-TestOpenApi -Path $validPath -Content $validContent
        $originalValidContent = [System.IO.File]::ReadAllText($validPath)

        $invalidPath = Join-Path $casePath 'BInvalid.yml'
        Write-TestOpenApi -Path $invalidPath -Content @'
openapi: 3.0.1
paths:
  '/invalid':
    patch:
      operationId: invalid_Patch
      deprecated: true
      x-ms-deprecation:
        removalDate: 'September 1, 2020'
components:
  schemas: {}
'@

        {
            & $scriptPath -OpenApiFilesPath $casePath -ReferenceDateUtc $referenceDate
        } | Should -Throw "*Invalid removalDate 'September 1, 2020'*PATCH '/invalid'*"

        [System.IO.File]::ReadAllText($validPath) | Should -BeExactly $originalValidContent
        Test-Path -LiteralPath (Join-Path $casePath 'deprecated-removals.json') |
            Should -BeFalse
    }

    It 'fails before modifying a document when the report directory is invalid' {
        $openApiPath = Join-Path $casePath 'ModuleD.yml'
        Write-TestOpenApi -Path $openApiPath -Content @'
openapi: 3.0.1
paths:
  '/expired':
    get:
      operationId: expired_Get
      deprecated: true
      x-ms-deprecation:
        removalDate: '2020-01-01'
components:
  schemas: {}
'@
        $originalContent = [System.IO.File]::ReadAllText($openApiPath)
        $invalidReportPath = Join-Path $casePath 'missing\deprecated-removals.json'

        {
            & $scriptPath `
                -OpenApiFilesPath $openApiPath `
                -ReferenceDateUtc $referenceDate `
                -ReportPath $invalidReportPath
        } | Should -Throw "*Report directory*does not exist*"

        [System.IO.File]::ReadAllText($openApiPath) | Should -BeExactly $originalContent
    }
}
