$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-TimeUserOutlook.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-TimeUserOutlook' {
    It 'Time' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Time1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'TimeViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'TimeViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
