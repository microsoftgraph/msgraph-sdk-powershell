$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgDeclineUserCalendarEvent.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-MgDeclineUserCalendarEvent' {
    It 'DeclineExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Decline2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeclineViaIdentityExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeclineViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
