$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-UploadEducationSynchronizationProfileUrl.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-UploadEducationSynchronizationProfileUrl' {
    It 'Upload' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UploadViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
