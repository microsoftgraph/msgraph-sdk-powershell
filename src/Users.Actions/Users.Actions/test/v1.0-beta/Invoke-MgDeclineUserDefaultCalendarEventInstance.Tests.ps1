$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgDeclineUserDefaultCalendarEventInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-MgDeclineUserDefaultCalendarEventInstance' {
    It 'DeclineExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Decline3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeclineViaIdentityExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeclineViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
