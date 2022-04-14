Describe 'New-MgSearchAcronym' {
    BeforeAll {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        # Set test mode to playback.
        $TestMode = 'playback'
        $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgSearchAcronym.Recording.json'
        $currentPath = $PSScriptRoot
        while(-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName

        Select-MgProfile 'beta'
        $debugLogPath = Join-Path $PSScriptRoot 'New-MgSearchAcronym.Debug.log'
        $Mock.PushDescription('New-MgSearchAcronym')
        $params = @{
            DisplayName = "DNN"
            StandsFor = "Deep Neural Network"
            Description = "A deep neural network is a neural network with a certain level of complexity, a neural network with more than two layers."
            WebUrl = "http://microsoft.com/deep-neural-network"
            State = "draft"
        }
        $recordedAcronymId = '733b26d5-af76-4eea-ac69-1a0ce8716897'
    }

    Context 'CreateExpanded' {
        It 'ShouldCreateSearchAcronymViaExpandedParameters' {
            $expandedAcronymResponse = New-MgSearchAcronym -DisplayName $params.DisplayName -StandsFor $params.StandsFor -Description $params.Description -WebUrl $params.WebUrl -State $params.State -Confirm:$false
            $expandedAcronymResponse | Should -Not -BeNullOrEmpty
            $expandedAcronymResponse.Id | Should -Be $recordedAcronymId
        }
    }

    Context 'Create'{
        It 'ShouldCreateSearchAcronymViaBodyParameterWithDebugLog' {
            $DebugPreference = 'Continue'
            $expandedAcronymResponse = New-MgSearchAcronym -BodyParameter $params -Confirm:$false -Debug 5>$debugLogPath
            $expandedAcronymResponse | Should -Not -BeNullOrEmpty
            $expandedAcronymResponse.Id | Should -Be $recordedAcronymId

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
