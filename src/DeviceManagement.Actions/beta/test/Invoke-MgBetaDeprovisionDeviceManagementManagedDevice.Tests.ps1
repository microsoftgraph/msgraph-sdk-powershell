if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaDeprovisionDeviceManagementManagedDevice'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaDeprovisionDeviceManagementManagedDevice.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaDeprovisionDeviceManagementManagedDevice' {
    It 'DeprovisionExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Deprovision' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeprovisionViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeprovisionViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
