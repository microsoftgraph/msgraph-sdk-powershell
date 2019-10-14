$TestRecordingFile = Join-Path $PSScriptRoot 'Add-GroupLifecyclePolicyGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Add-GroupLifecyclePolicyGroup' {
    It 'AddExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Add' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AddViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AddViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
