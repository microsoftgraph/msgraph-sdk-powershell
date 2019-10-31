$TestRecordingFile = Join-Path $PSScriptRoot 'New-PrivilegedRoleAssignmentEligible.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-PrivilegedRoleAssignmentEligible' {
    It 'Make' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MakeViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
