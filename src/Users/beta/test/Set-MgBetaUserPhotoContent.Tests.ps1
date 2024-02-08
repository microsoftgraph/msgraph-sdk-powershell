if(($null -eq $TestName) -or ($TestName -contains 'Set-MgBetaUserPhotoContent'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Set-MgBetaUserPhotoContent.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-MgBetaUserPhotoContent' {
    It 'Set' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Set1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SetViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
