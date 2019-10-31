$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-PreviewGroupOnenoteNotebookSectionGroupSectionPage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-PreviewGroupOnenoteNotebookSectionGroupSectionPage' {
    It 'Preview' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PreviewViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
