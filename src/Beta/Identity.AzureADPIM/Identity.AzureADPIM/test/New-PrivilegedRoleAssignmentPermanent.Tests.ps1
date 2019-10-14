$TestRecordingFile = Join-Path $PSScriptRoot 'New-PrivilegedRoleAssignmentPermanent.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-PrivilegedRoleAssignmentPermanent' {
    It 'MakeExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Make' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MakeViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MakeViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
