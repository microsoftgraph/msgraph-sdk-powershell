$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-SharedDrive.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-SharedDrive' {
    It 'Shared' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Shared1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SharedViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
