$TestRecordingFile = Join-Path $PSScriptRoot 'Resume-EducationSynchronizationProfile.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Resume-EducationSynchronizationProfile' {
    It 'Resume' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ResumeViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
