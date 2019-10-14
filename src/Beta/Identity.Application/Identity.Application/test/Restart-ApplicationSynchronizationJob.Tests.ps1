$TestRecordingFile = Join-Path $PSScriptRoot 'Restart-ApplicationSynchronizationJob.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restart-ApplicationSynchronizationJob' {
    It 'RestartExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Restart' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RestartViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RestartViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
