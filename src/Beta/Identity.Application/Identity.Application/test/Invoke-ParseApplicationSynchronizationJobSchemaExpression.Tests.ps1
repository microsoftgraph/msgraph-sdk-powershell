$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-ParseApplicationSynchronizationJobSchemaExpression.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-ParseApplicationSynchronizationJobSchemaExpression' {
    It 'ParseExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Parse' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ParseViaIdentityExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ParseViaIdentity' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
