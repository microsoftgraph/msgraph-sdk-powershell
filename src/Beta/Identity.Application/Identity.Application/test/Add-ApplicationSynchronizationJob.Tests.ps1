$TestRecordingFile = Join-Path $PSScriptRoot 'Add-ApplicationSynchronizationJob.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Add-ApplicationSynchronizationJob' {
    It 'ApplyExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Apply' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ApplyViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ApplyViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
