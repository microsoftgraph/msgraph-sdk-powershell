$TestRecordingFile = Join-Path $PSScriptRoot 'Test-Domain.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Test-Domain' {
    It 'Verify' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'VerifyViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
