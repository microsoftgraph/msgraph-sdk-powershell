if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaUsageIdentityConditionalAccessAuthenticationStrengthPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaUsageIdentityConditionalAccessAuthenticationStrengthPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaUsageIdentityConditionalAccessAuthenticationStrengthPolicy' {
    It 'Usage' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Usage1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UsageViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UsageViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
