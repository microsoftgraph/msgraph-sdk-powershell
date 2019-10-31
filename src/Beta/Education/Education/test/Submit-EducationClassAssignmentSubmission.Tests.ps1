$TestRecordingFile = Join-Path $PSScriptRoot 'Submit-EducationClassAssignmentSubmission.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Submit-EducationClassAssignmentSubmission' {
    It 'Submit' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SubmitViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
