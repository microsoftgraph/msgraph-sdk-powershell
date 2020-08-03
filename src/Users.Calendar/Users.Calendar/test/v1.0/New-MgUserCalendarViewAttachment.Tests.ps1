$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-MgUserCalendarViewAttachment.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-MgUserCalendarViewAttachment' {
    It 'CreateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentityExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentity5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentity4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
