$TestRecordingFile = Join-Path $PSScriptRoot 'Grant-SharePermission.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Grant-SharePermission' {
    It 'GrantExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Grant' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GrantViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GrantViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
