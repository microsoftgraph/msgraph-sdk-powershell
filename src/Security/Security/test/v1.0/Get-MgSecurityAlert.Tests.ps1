Describe 'Get-MgSecurityAlert' {
    BeforeAll {
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        # Set test mode to playback.
        $TestMode = 'playback'
        $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgSecurityAlert.Recording.json'
        $currentPath = $PSScriptRoot
        while(-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName

        Select-MgProfile 'v1.0'
        $debugLogPath = Join-Path $PSScriptRoot 'Get-MgSecurityAlert.Debug.log'
        $Mock.PushDescription('Get-MgSecurityAlert')
    }

    Context 'List1' {
        It 'ShouldGetACollectionOfSecurityAlerts' {
            $Mock.PushScenario('ShouldGetACollectionOfSecurityAlerts')
            $DebugPreference = 'Continue'
            $isHttpResponse = $false

            $SecurityAlerts = Get-MgSecurityAlert -Debug 5>$debugLogPath
            $SecurityAlerts | Should -HaveCount 1

            $debugContent = Get-Content $debugLogPath
            $debugContent | Should -Not -BeNullOrEmpty
            $debugContent | Should -Contain 'Body:'
            for ($i = 0; $i -lt $debugContent.Count; $i++) {
                if ($debugContent[$i] -like '*HTTP RESPONSE*') {
                    $isHttpResponse = $true
                }
                if ($debugContent[$i] -eq 'Body:' -and $isHttpResponse) {
                    $debugContent[$i+1] | Should -Be '{'
                }
            }
        }
    }

    It 'Get1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    AfterAll {
        if (Test-Path $debugLogPath) {
            Remove-Item -Path $debugLogPath -Force
        }
    }
}
