$TestRecordingFile = Join-Path $PSScriptRoot 'Restore-DriveListItemVersion.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restore-DriveListItemVersion' {
    It 'Restore' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Restore1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RestoreViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RestoreViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
