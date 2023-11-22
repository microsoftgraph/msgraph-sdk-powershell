if(($null -eq $TestName) -or ($TestName -contains 'Get-MgDeviceAppManagementMobileAppContentVersionContainedAppCount'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgDeviceAppManagementMobileAppContentVersionContainedAppCount.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-MgDeviceAppManagementMobileAppContentVersionContainedAppCount' {
    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
