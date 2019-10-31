$TestRecordingFile = Join-Path $PSScriptRoot 'Publish-BookingBusiness.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Publish-BookingBusiness' {
    It 'Publish' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PublishViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
