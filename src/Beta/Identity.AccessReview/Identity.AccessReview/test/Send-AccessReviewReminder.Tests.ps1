$TestRecordingFile = Join-Path $PSScriptRoot 'Send-AccessReviewReminder.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Send-AccessReviewReminder' {
    It 'Send' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SendViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
