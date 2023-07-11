if(($null -eq $TestName) -or ($TestName -contains 'Import-MgBetaDeviceManagementTemplateMigratableToOffice365DeviceConfigurationPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Import-MgBetaDeviceManagementTemplateMigratableToOffice365DeviceConfigurationPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Import-MgBetaDeviceManagementTemplateMigratableToOffice365DeviceConfigurationPolicy' {
    It 'Import' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ImportViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
