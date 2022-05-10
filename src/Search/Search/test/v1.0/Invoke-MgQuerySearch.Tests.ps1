# Fails due to response object mismatch between OpenAPI & OData.
Describe 'Invoke-MgQuerySearch' -skip{
    BeforeAll {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        # Set test mode to playback.
        $TestMode = 'playback'
        $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgQuerySearch.Recording.json'
        $currentPath = $PSScriptRoot
        while(-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName

        Select-MgProfile 'v1.0'
        $debugLogPath = Join-Path $PSScriptRoot 'Invoke-MgQuerySearch.Debug.log'
        $Mock.PushDescription('Invoke-MgQuerySearch')
        $params = @{
            Requests = @(
                @{
                    EntityTypes = @(
                        "externalItem"
                    )
                    ContentSources = @(
                        "/external/connections/connectionfriendlyname"
                    )
                    Query = @{
                        QueryString = "contoso product"
                    }
                    From = 0
                    Size = 25
                    Fields = @(
                        "title"
                        "description"
                    )
                }
            )
        }
        $debugLogPath = Join-Path $PSScriptRoot 'Invoke-MgQuerySearch.Debug.log'
    }

    Context 'QueryExpanded1' {
        It "ShouldQueryDataViaExpandedParameters" {
            $expandedSearchResponse = Invoke-MgQuerySearch -Requests $params.Requests
            $expandedSearchResponse | Should -Not -BeNullOrEmpty
            $expandedSearchResponse.Count | Should -Be 1
        }
    }

    Context 'Query1' {
        It "ShouldQueryDataViaBodyParameterWithDebugLog" {
            $DebugPreference = 'Continue'
            $expandedSearchResponse = Invoke-MgQuerySearch -BodyParameter $params -Debug 5>$debugLogPath
            $expandedSearchResponse | Should -Not -BeNullOrEmpty
            $expandedSearchResponse.Count | Should -Be 1

            $debugContent = Get-Content $debugLogPath
            $debugContent | Should -Not -BeNullOrEmpty
            $debugContent | Should -Contain 'Body:'
            for ($i = 0; $i -lt $debugContent.Count; $i++) {
                if ($debugContent[$i] -eq 'Body:') {
                    $debugContent[$i+1] | Should -Be '{'
                }
            }
        }
    }

    AfterAll {
        if (Test-Path $debugLogPath) {
            Remove-Item $debugLogPath -Force
        }
    }
}
