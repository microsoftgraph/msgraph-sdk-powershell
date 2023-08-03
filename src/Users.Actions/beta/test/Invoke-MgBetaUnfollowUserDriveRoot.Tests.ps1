if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaUnfollowUserDriveRoot'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaUnfollowUserDriveRoot.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaUnfollowUserDriveRoot' {
    It 'Unfollow' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnfollowViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
