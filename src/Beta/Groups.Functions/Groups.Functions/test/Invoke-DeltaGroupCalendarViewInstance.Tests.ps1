$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-DeltaGroupCalendarViewInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-DeltaGroupCalendarViewInstance' {
    It 'Delta' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delta1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeltaViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
