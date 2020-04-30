$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgUserCalendarViewDelta.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-MgUserCalendarViewDelta' {
    It 'Delta2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delta' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delta3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delta1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
