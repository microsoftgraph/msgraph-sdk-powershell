$TestRecordingFile = Join-Path $PSScriptRoot 'Search-Drive.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Search-Drive' {
    It 'Search' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Search1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SearchViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SearchViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
