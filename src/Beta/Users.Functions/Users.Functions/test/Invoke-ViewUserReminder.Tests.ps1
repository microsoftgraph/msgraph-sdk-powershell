$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ViewUserReminder.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ViewUserReminder' {
    It 'View' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ViewViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
