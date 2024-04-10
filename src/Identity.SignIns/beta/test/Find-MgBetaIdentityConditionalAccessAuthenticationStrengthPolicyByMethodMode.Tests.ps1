if(($null -eq $TestName) -or ($TestName -contains 'Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Find-MgBetaIdentityConditionalAccessAuthenticationStrengthPolicyByMethodMode' {
    It 'Find1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'FindViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
