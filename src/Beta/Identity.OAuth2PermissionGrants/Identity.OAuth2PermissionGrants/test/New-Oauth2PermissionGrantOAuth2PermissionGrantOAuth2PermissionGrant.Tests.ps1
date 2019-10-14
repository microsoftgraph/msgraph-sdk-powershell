$TestRecordingFile = Join-Path $PSScriptRoot 'New-Oauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-Oauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant' {
    It 'CreateExpanded' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
