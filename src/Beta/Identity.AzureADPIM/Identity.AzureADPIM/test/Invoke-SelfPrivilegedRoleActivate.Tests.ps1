$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-SelfPrivilegedRoleActivate.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-SelfPrivilegedRoleActivate' {
    It 'SelfExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Self' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SelfViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SelfViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
