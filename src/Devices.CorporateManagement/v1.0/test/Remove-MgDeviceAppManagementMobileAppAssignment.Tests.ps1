if(($null -eq $TestName) -or ($TestName -contains 'Remove-MgDeviceAppManagementMobileAppAssignment'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-MgDeviceAppManagementMobileAppAssignment.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-MgDeviceAppManagementMobileAppAssignment' {
    It 'Delete' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
