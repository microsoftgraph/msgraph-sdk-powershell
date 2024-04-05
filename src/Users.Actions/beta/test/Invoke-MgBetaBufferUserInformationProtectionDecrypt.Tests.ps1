if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaBufferUserInformationProtectionDecrypt'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaBufferUserInformationProtectionDecrypt.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaBufferUserInformationProtectionDecrypt' {
    It 'BufferExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Buffer' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'BufferViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'BufferViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
