$TestRecordingFile = Join-Path $PSScriptRoot 'Test-DirectoryObjectProperty.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Test-DirectoryObjectProperty' {
    It 'ValidateExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Validate' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
