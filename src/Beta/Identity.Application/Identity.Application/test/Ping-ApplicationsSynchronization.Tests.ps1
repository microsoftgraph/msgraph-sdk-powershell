$TestRecordingFile = Join-Path $PSScriptRoot 'Ping-ApplicationsSynchronization.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Ping-ApplicationsSynchronization' {
    It 'Ping' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PingViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
