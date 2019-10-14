$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-SelfPrivilegedRoleActivate.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-SelfPrivilegedRoleActivate' {
    It 'SelfExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Self' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SelfViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SelfViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
