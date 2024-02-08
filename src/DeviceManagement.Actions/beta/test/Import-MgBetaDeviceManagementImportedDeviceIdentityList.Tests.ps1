if(($null -eq $TestName) -or ($TestName -contains 'Import-MgBetaDeviceManagementImportedDeviceIdentityList'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Import-MgBetaDeviceManagementImportedDeviceIdentityList.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Import-MgBetaDeviceManagementImportedDeviceIdentityList' {
    It 'ImportExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Import' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
