$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-UnsubmitEducationMeAssignmentSubmission.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-UnsubmitEducationMeAssignmentSubmission' {
    It 'Unsubmit' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnsubmitViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
