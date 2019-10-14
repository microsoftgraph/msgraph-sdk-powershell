$TestRecordingFile = Join-Path $PSScriptRoot 'Submit-EducationMeAssignmentSubmission.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Submit-EducationMeAssignmentSubmission' {
    It 'Submit' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SubmitViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
