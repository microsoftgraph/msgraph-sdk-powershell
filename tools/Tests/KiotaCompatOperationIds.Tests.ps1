# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
BeforeAll {
    Import-Module powershell-yaml -ErrorAction Stop
    $toolsPath = Split-Path $PSScriptRoot -Parent
    $setIdsPath = Join-Path $toolsPath 'Utilities\Set-OpenApiOperationIds.ps1'
    $tweakPath = Join-Path $toolsPath 'TweakOpenApi.ps1'
    $downloadPath = Join-Path $toolsPath 'DownloadOpenApiDocKiotaCompat.ps1'
    $updatePath = Join-Path $toolsPath 'UpdateOpenApiKiotaCompat.ps1'
    $plainContent = @'
openapi: 3.0.1
info:
  title: Fixture
  version: v1.0
paths:
  /auditLogs:
    patch:
      operationId: auditLogs.auditLogRoot.UpdateAuditLogRoot
      requestBody:
        content:
          application/json:
            schema:
              $ref: '#/components/schemas/item'
      responses:
        '204':
          description: Success
  '/items/{item-id}/members/$ref':
    put:
      operationId: 'items.members.UpdateRefMembers' # keep this comment
      responses:
        '200':
          description: Success
  /items/delta:
    get:
      operationId: "items.items.GetDeltum"
  '/reports/export(period={period})':
    get:
      operationId: reports.export-abcd
  '/reports/export(date={date})':
    get:
      operationId: reports.export-ef01
components:
  x-metadata:
    payload:
      operationId: DoNotChangeByRef
  schemas:
    item:
      type: object
      description: 'operationId: DoNotChangeByRef'
      discriminator:
        propertyName: '@odata.type'
        mapping:
          '#fixture.item': '#/components/schemas/item'
      additionalProperties:
        type: string
      x-example:
        operationId: DoNotChangeByRef
      properties:
        related:
          x-ms-navigationProperty: true
          anyOf:
            - $ref: '#/components/schemas/item'
            - type: string
        choice:
          oneOf:
            - type: integer
            - type: string
'@
    $plainContent = $plainContent.Replace("`r`n", "`n").Replace("`n", "`r`n") + "`r`n"
    $formattedDocument = @{
        paths = @{
            '/auditLogs' = @{ patch = @{ operationId = 'auditLog.auditLogRoot_UpdateAuditLogRoot' } }
            '/items/{item-id}/members/$ref' = @{ put = @{ operationId = 'item.member_SetMembersByRef' } }
            '/items/delta' = @{ get = @{ operationId = 'item_GetDeltum' } }
            '/reports/export(period={period})' = @{ get = @{ operationId = 'report_export' } }
            '/reports/export(date={date})' = @{ get = @{ operationId = 'report_export' } }
        }
        # Deliberately unusable schemas: none of the styled document may replace the Plain schemas.
        components = @{ schemas = @{} }
    }
    $formattedContent = $plainContent.
        Replace('auditLogs.auditLogRoot.UpdateAuditLogRoot', 'auditLog.auditLogRoot_UpdateAuditLogRoot').
        Replace('items.members.UpdateRefMembers', 'item.member_SetMembersByRef').
        Replace('items.items.GetDeltum', 'item_GetDeltum').
        Replace('reports.export-abcd', 'report_export').
        Replace('reports.export-ef01', 'report_export')
    $tweakedContent = $formattedContent.
        Replace('item.member_SetMembersByRef', 'item.member_SetMembersGraphBPreRef').
        Replace('item_GetDeltum', 'item_Getdelta')
}

Describe 'Kiota-compatible operation ID projection' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item -Path $casePath -ItemType Directory
        $specPath = Join-Path $casePath 'Reports.yml'
        [System.IO.File]::WriteAllText($specPath, $plainContent)
        $reference = $formattedDocument | ConvertTo-Json -Depth 20 | ConvertFrom-Json -AsHashtable
    }

    It 'copies IDs by exact path and method without changing any other Plain YAML text' {
        & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference
        [System.IO.File]::ReadAllText($specPath) | Should -BeExactly $formattedContent
        & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference
        [System.IO.File]::ReadAllText($specPath) | Should -BeExactly $formattedContent
    }

    It 'also preserves LF line endings and a missing final newline' {
        $lfContent = $plainContent.Replace("`r`n", "`n").TrimEnd("`n")
        [System.IO.File]::WriteAllText($specPath, $lfContent)
        & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference
        [System.IO.File]::ReadAllText($specPath) |
            Should -BeExactly $formattedContent.Replace("`r`n", "`n").TrimEnd("`n")
    }

    It 'fails before writing when a formatted <Missing> is missing' -TestCases @(
        @{ Missing = 'path' }
        @{ Missing = 'method' }
        @{ Missing = 'operation ID' }
    ) {
        param($Missing)
        switch ($Missing) {
            'path' { $reference.paths.Remove('/auditLogs') }
            'method' { $reference.paths['/auditLogs'].Remove('patch') }
            'operation ID' { $reference.paths['/auditLogs'].patch.operationId = '' }
        }
        { & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference } |
            Should -Throw '*Missing formatted operation ID*'
        [System.IO.File]::ReadAllText($specPath) | Should -BeExactly $plainContent
    }

    It 'rejects ambiguous source IDs before writing' {
        $ambiguous = $plainContent.Replace('items.items.GetDeltum', 'auditLogs.auditLogRoot.UpdateAuditLogRoot')
        [System.IO.File]::WriteAllText($specPath, $ambiguous)
        { & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference } |
            Should -Throw '*Ambiguous operation ID*'
        [System.IO.File]::ReadAllText($specPath) | Should -BeExactly $ambiguous
    }

    It 'fails instead of leaving unrecognized operation ID formatting unchanged' {
        $indented = $plainContent.Replace('      operationId:', '      operationId :')
        [System.IO.File]::WriteAllText($specPath, $indented)
        { & $setIdsPath -OpenApiFilePath $specPath -OperationIdDocument $reference } |
            Should -Throw '*Not all operation IDs could be updated*'
        [System.IO.File]::ReadAllText($specPath) | Should -BeExactly $indented
    }
}

Describe 'Operation-ID-only OpenAPI tweaks' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item -Path $casePath -ItemType Directory
        $specPath = Join-Path $casePath 'Reports.yml'
        [System.IO.File]::WriteAllText($specPath, $formattedContent)
    }

    It 'applies legacy ID corrections but keeps schemas, parameters and response codes' {
        & $tweakPath -OpenAPIFilesPath $casePath -OperationIdsOnly -SetNavigationPropertiesAsReadOnly
        $actual = Get-Content -LiteralPath $specPath -Raw
        $actual | Should -BeExactly $tweakedContent
    }

    It 'preserves LF line endings and a missing final newline in operation-ID-only mode' {
        $lfContent = $formattedContent.Replace("`r`n", "`n").TrimEnd("`n")
        [System.IO.File]::WriteAllText($specPath, $lfContent)
        & $tweakPath -OpenAPIFilesPath $casePath -OperationIdsOnly
        [System.IO.File]::ReadAllText($specPath) |
            Should -BeExactly $tweakedContent.Replace("`r`n", "`n").TrimEnd("`n")
    }

    It 'retains the legacy <Before> correction' -TestCases @(
        @{ Before = 'item_GetWithDetails'; After = 'item_GetGraphWPreDetails' }
        @{ Before = 'item_GetAtTime'; After = 'item_GetGraphAPreTime' }
        @{ Before = 'item_GetForUser'; After = 'item_GetGraphFPreUser' }
        @{ Before = 'item_GetCreatedOnBehalfOfByRef'; After = 'item_GetCreatedOnBehalfGraphOPreGraphBPreRef' }
        @{ Before = 'item_GetQuotum'; After = 'item_Getquota' }
        @{ Before = 'item_GetStatistic'; After = 'item_Getstatistics' }
    ) {
        param($Before, $After)
        [System.IO.File]::WriteAllText($specPath, "paths:`n  /items:`n    get:`n      operationId: $Before")
        & $tweakPath -OpenAPIFilesPath $casePath -OperationIdsOnly
        [System.IO.File]::ReadAllText($specPath) |
            Should -BeExactly "paths:`n  /items:`n    get:`n      operationId: $After"
    }

    It 'leaves the default PowerShell response and navigation property tweaks enabled' {
        & $tweakPath -OpenAPIFilesPath $casePath -SetNavigationPropertiesAsReadOnly
        $actual = Get-Content -LiteralPath $specPath -Raw
        $actual | Should -Match '2XX:'
        $actual | Should -Not -Match "'204':"
        $actual | Should -Match 'readOnly: true'
        $actual | Should -Not -Match 'x-ms-navigationProperty: true'
    }

    It 'ignores removal reports and subdirectories while processing YAML files' {
        $reportPath = Join-Path $casePath 'deprecated-removals.json'
        $reportContent = '{"operationId:":"DoNotChangeByRef","status":"''204'':"}'
        [System.IO.File]::WriteAllText($reportPath, $reportContent)
        $null = New-Item -Path (Join-Path $casePath 'subdirectory') -ItemType Directory
        Rename-Item -LiteralPath $specPath -NewName 'Reports.yaml'
        & $tweakPath -OpenAPIFilesPath $casePath -OperationIdsOnly
        [System.IO.File]::ReadAllText($reportPath) | Should -BeExactly $reportContent
        Get-Content -LiteralPath (Join-Path $casePath 'Reports.yaml') -Raw |
            Should -Match 'item.member_SetMembersGraphBPreRef'
    }
}

Describe 'Kiota-compatible download and refresh' {
    BeforeEach {
        $casePath = Join-Path $TestDrive ([guid]::NewGuid().ToString())
        $null = New-Item -Path $casePath -ItemType Directory
        Mock Invoke-WebRequest {
            param($Uri, $OutFile)
            if ($OutFile) {
                [System.IO.File]::WriteAllText($OutFile, $plainContent)
            }
            else {
                @{ Content = ($formattedDocument | ConvertTo-Json -Depth 20) }
            }
        }
    }

    It 'requests singularized PowerShell IDs without using the styled schemas' {
        & $downloadPath -ModuleName Reports -ModuleRegex '^auditLogs\.' `
            -OpenApiDocOutput $casePath -GraphVersion v1.0 -ForceRefresh -SingularizeOperationIds
        [System.IO.File]::ReadAllText((Join-Path $casePath 'Reports.yml')) |
            Should -BeExactly $formattedContent
        Should -Invoke Invoke-WebRequest -Times 1 -Exactly -ParameterFilter {
            $Uri -cmatch 'style=Plain&fileName=openapi' -and $Uri -match 'forceRefresh=true' -and $OutFile
        }
        Should -Invoke Invoke-WebRequest -Times 1 -Exactly -ParameterFilter {
            $Uri -cmatch 'style=Powershell&fileName=openapi' -and
            $Uri -match 'forceRefresh=true' -and
            $Uri -match 'singularizeOperationIds=true&format=json' -and -not $OutFile
        }
    }

    It 'keeps the original standalone download behavior when singularization is not requested' {
        & $downloadPath -ModuleName Reports -ModuleRegex '^auditLogs\.' `
            -OpenApiDocOutput $casePath -GraphVersion beta
        [System.IO.File]::ReadAllText((Join-Path $casePath 'Reports.yml')) |
            Should -BeExactly $plainContent
        Should -Invoke Invoke-WebRequest -Times 1 -Exactly
    }

    It 'retries the download when the operation-ID reference is temporarily unavailable' {
        Mock Start-Sleep {}
        $script:referenceRequests = 0
        Mock Invoke-WebRequest {
            param($Uri, $OutFile)
            if ($OutFile) {
                [System.IO.File]::WriteAllText($OutFile, $plainContent)
            }
            else {
                $script:referenceRequests++
                if ($script:referenceRequests -eq 1) {
                    $response = [System.Net.Http.HttpResponseMessage]::new([System.Net.HttpStatusCode]::ServiceUnavailable)
                    throw [Microsoft.PowerShell.Commands.HttpResponseException]::new('Unavailable', $response)
                }
                @{ Content = ($formattedDocument | ConvertTo-Json -Depth 20) }
            }
        }
        & $downloadPath -ModuleName Reports -ModuleRegex '^auditLogs\.' `
            -OpenApiDocOutput $casePath -GraphVersion v1.0 -SingularizeOperationIds
        [System.IO.File]::ReadAllText((Join-Path $casePath 'Reports.yml')) |
            Should -BeExactly $formattedContent
        Should -Invoke Start-Sleep -Times 1 -Exactly
        Should -Invoke Invoke-WebRequest -Times 4 -Exactly
    }

    It 'surfaces operation-ID reference failures rather than reporting a successful download' {
        Mock Invoke-WebRequest { throw 'Reference request failed' } -ParameterFilter { -not $OutFile }
        { & $downloadPath -ModuleName Reports -ModuleRegex '^auditLogs\.' `
            -OpenApiDocOutput $casePath -GraphVersion v1.0 -SingularizeOperationIds } |
            Should -Throw '*Reference request failed*'
    }

    It 'does not skip a missing operation-ID reference as though the Plain module were missing' {
        Mock Invoke-WebRequest {
            $response = [System.Net.Http.HttpResponseMessage]::new([System.Net.HttpStatusCode]::NotFound)
            throw [Microsoft.PowerShell.Commands.HttpResponseException]::new('Reference not found', $response)
        } -ParameterFilter { -not $OutFile }
        { & $downloadPath -ModuleName Reports -ModuleRegex '^auditLogs\.' `
            -OpenApiDocOutput $casePath -GraphVersion v1.0 -SingularizeOperationIds } |
            Should -Throw '*Reference not found*'
    }

    It 'normalizes IDs and still runs deprecation pruning for <Version>' -TestCases @(
        @{ Version = 'v1.0'; Beta = $false }
        @{ Version = 'beta'; Beta = $true }
    ) {
        param($Version, $Beta)
        $mappingPath = Join-Path $casePath 'mapping.jsonc'
        [System.IO.File]::WriteAllText($mappingPath, '{"Reports":"^auditLogs\\\\."}')
        & $updatePath -ModuleMappingConfigPath $mappingPath -OpenApiDocOutput $casePath `
            -BetaGraphVersion:$Beta -SkipForceRefresh
        $profilePath = Join-Path $casePath $Version
        $actual = Get-Content -LiteralPath (Join-Path $profilePath 'Reports.yml') -Raw
        $actual | Should -BeExactly $tweakedContent
        Test-Path (Join-Path $profilePath 'deprecated-removals.json') | Should -BeTrue
        Should -Invoke Invoke-WebRequest -Times 2 -Exactly -ParameterFilter {
            $Uri -match "graphVersion=$([regex]::Escape($Version))" -and $Uri -notmatch 'forceRefresh=true'
        }
    }
}
