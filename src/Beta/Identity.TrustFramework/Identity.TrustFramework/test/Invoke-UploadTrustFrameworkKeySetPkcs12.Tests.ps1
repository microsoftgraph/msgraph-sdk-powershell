$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-UploadTrustFrameworkKeySetPkcs12.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-UploadTrustFrameworkKeySetPkcs12' {
    It 'UploadExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Upload' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UploadViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UploadViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
