if(($null -eq $TestName) -or ($TestName -contains 'Set-MgBetaVirtualEventWebinarPresenterProfilePhoto'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Set-MgBetaVirtualEventWebinarPresenterProfilePhoto.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-MgBetaVirtualEventWebinarPresenterProfilePhoto' {
    It 'Set' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
