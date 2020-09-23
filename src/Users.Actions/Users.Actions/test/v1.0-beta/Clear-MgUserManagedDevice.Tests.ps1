$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Clear-MgUserManagedDevice.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Clear-MgUserManagedDevice' {
    It 'WipeExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Wipe1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'WipeViaIdentityExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'WipeViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
