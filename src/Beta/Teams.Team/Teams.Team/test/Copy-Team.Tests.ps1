$TestRecordingFile = Join-Path $PSScriptRoot 'Copy-Team.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Copy-Team' {
    It 'CloneExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Clone' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CloneViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CloneViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
