$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgSnoozeUserCalendarEventInstanceReminder.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-MgSnoozeUserCalendarEventInstanceReminder' {
    It 'SnoozeExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Snooze2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SnoozeViaIdentityExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SnoozeViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
