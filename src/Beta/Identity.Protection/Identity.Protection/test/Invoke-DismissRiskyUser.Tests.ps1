$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-DismissRiskyUser.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-DismissRiskyUser' {
    It 'DismissExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Dismiss' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
