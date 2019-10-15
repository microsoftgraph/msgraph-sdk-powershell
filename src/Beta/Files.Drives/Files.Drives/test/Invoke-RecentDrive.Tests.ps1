$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-RecentDrive.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-RecentDrive' {
    It 'Recent' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Recent1' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RecentViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
