if(($null -eq $TestName) -or ($TestName -contains 'Suspend-MgBetaApplicationSynchronizationJob'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Suspend-MgBetaApplicationSynchronizationJob.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Suspend-MgBetaApplicationSynchronizationJob' {
    It 'Pause' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PauseViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
