$TestRecordingFile = Join-Path $PSScriptRoot 'Set-OfficeConfigurationClientConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-OfficeConfigurationClientConfiguration' {
    It 'AssignExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Assign' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AssignViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AssignViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
