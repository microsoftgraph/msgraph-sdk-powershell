$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ShareTeamSchedule.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ShareTeamSchedule' {
    It 'ShareExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Share' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ShareViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ShareViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
