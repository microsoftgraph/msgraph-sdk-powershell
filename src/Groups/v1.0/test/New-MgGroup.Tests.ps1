BeforeAll {
    if (($null -eq $TestName) -or ($TestName -contains 'New-MgGroup')) {
        # Set test mode to playback.
        $TestMode = 'playback'
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgGroup.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }
}

Describe 'New-MgGroup' {
    BeforeAll {
        $Mock.PushDescription('New-MgGroup')
    }

    Context 'Create' {
        It 'ShouldCreateNewGroup' {
            $CreateGroups = @()
            1..100 | ForEach-Object {
                $Mock.PushScenario('ShouldCreateNewGroup')
                $CreateGroups += New-MgGroup -DisplayName "new-mggroup-test" -MailEnabled:$false -MailNickname 'unused' -SecurityEnabled
            }

            $CreateGroups | Should -HaveCount 100
            $CreateGroups[0].DisplayName | Should -Be "new-mggroup-test"
            $CreateGroups[0].MailEnabled | Should -BeFalse
        } 

        It 'ShouldHaveASingleResponseObjectIfRHVIsPassed' {
            $Mock.PushScenario('ShouldCreateNewGroup')
            $group = New-MgGroup -DisplayName "new-mggroup-test" -MailEnabled:$false -MailNickname 'unused' -SecurityEnabled -RHV rh
            $group.Count | Should -HaveCount 1
        }

        It 'ShouldAssignRetrieveHeadersToRHVIfPassed' {
            $Mock.PushScenario('ShouldCreateNewGroup')
            New-MgGroup -DisplayName "new-mggroup-test" -MailEnabled:$false -MailNickname 'unused' -SecurityEnabled -RHV rv
            $rv.Vary | Should -Be "Accept-Encoding"
            $rv.'Content-Type' | Should -Be "application/json" 
        }
    }
}
