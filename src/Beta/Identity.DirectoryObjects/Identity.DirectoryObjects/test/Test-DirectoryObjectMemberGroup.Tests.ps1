$TestRecordingFile = Join-Path $PSScriptRoot 'Test-DirectoryObjectMemberGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Test-DirectoryObjectMemberGroup' {
    It 'CheckExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Check' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CheckViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CheckViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
