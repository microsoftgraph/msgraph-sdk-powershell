$TestRecordingFile = Join-Path $PSScriptRoot 'Search-Drive.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Search-Drive' {
    It 'Search' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Search1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SearchViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SearchViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
