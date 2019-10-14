$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-InstantiateApplicationTemplate.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-InstantiateApplicationTemplate' {
    It 'InstantiateExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Instantiate' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'InstantiateViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'InstantiateViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
