$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-CalendarUserCalendarViewCalendar.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-CalendarUserCalendarViewCalendar' {
    It 'Calendar' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Calendar2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Calendar1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CalendarViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CalendarViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CalendarViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
