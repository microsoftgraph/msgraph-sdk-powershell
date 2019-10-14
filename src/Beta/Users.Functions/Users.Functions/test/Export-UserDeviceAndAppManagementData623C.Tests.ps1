$TestRecordingFile = Join-Path $PSScriptRoot 'Export-UserDeviceAndAppManagementData623C.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Export-UserDeviceAndAppManagementData623C' {
    It 'Export' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ExportViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
