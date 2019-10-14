$TestRecordingFile = Join-Path $PSScriptRoot 'Stop-BookingBusinessAppointment.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Stop-BookingBusinessAppointment' {
    It 'CancelExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Cancel' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CancelViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CancelViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
