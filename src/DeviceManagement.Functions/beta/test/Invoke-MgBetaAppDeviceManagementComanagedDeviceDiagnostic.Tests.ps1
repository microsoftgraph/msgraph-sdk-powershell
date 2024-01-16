if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaAppDeviceManagementComanagedDeviceDiagnostic'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaAppDeviceManagementComanagedDeviceDiagnostic.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaAppDeviceManagementComanagedDeviceDiagnostic' {
    It 'App' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AppViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
