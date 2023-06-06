if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaEnrollUserManagedDeviceNowAction'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaEnrollUserManagedDeviceNowAction.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaEnrollUserManagedDeviceNowAction' {
    It 'Enroll' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'EnrollViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
