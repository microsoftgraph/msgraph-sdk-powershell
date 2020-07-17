$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgReportSkype.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-MgReportSkype' {
    It 'Get17' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get33' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get32' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get31' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get30' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get29' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get28' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get27' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get26' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get25' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get24' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get22' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get21' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get20' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get18' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get23' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get19' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity33' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity32' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity31' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity30' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity29' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity28' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity27' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity26' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity25' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity24' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity23' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity22' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity21' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity20' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity19' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get17' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get33' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
