$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-MgUserCalendarView.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-MgUserCalendarView' {
    It 'UpdateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentityExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
