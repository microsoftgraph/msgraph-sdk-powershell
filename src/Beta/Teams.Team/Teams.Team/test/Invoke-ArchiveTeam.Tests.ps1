$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ArchiveTeam.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ArchiveTeam' {
    It 'ArchiveExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Archive' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ArchiveViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ArchiveViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
