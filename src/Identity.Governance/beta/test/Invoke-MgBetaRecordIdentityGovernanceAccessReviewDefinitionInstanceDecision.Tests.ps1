if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaRecordIdentityGovernanceAccessReviewDefinitionInstanceDecision' {
    It 'RecordExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Record' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RecordViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RecordViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
