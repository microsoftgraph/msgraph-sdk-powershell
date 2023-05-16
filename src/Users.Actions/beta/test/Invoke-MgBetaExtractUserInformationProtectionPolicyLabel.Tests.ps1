if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaExtractUserInformationProtectionPolicyLabel'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaExtractUserInformationProtectionPolicyLabel.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaExtractUserInformationProtectionPolicyLabel' {
    It 'ExtractExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Extract' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ExtractViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ExtractViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
