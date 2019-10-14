$TestRecordingFile = Join-Path $PSScriptRoot 'Restore-DirectoryObject.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restore-DirectoryObject' {
    It 'Restore' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RestoreViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
