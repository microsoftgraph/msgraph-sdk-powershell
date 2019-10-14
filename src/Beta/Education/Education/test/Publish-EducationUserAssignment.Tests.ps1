$TestRecordingFile = Join-Path $PSScriptRoot 'Publish-EducationUserAssignment.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Publish-EducationUserAssignment' {
    It 'Publish' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PublishViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
