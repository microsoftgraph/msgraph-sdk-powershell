$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-CalendarUserCalendar.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-CalendarUserCalendar' {
    It 'Calendar1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Calendar' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CalendarViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CalendarViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
