$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-RenewGroupLifecyclePolicyGroup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-RenewGroupLifecyclePolicyGroup' {
    It 'RenewExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Renew' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
