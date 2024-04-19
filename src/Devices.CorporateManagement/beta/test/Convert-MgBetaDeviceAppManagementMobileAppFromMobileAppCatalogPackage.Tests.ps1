if(($null -eq $TestName) -or ($TestName -contains 'Convert-MgBetaDeviceAppManagementMobileAppFromMobileAppCatalogPackage'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Convert-MgBetaDeviceAppManagementMobileAppFromMobileAppCatalogPackage.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Convert-MgBetaDeviceAppManagementMobileAppFromMobileAppCatalogPackage' {
    It 'Convert' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ConvertViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
