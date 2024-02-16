if(($null -eq $TestName) -or ($TestName -contains 'Restart-MgBetaDeviceManagementManagedDeviceNow'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Restart-MgBetaDeviceManagementManagedDeviceNow.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Restart-MgBetaDeviceManagementManagedDeviceNow' {
    It 'Reboot' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RebootViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
