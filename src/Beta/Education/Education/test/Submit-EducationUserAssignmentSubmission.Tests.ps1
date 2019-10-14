$TestRecordingFile = Join-Path $PSScriptRoot 'Submit-EducationUserAssignmentSubmission.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Submit-EducationUserAssignmentSubmission' {
    It 'Submit' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SubmitViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
