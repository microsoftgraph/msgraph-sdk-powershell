if(($null -eq $TestName) -or ($TestName -contains 'Compare-MgBetaDeviceManagementIntent'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Compare-MgBetaDeviceManagementIntent.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Compare-MgBetaDeviceManagementIntent' {
    It 'Compare' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CompareViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
