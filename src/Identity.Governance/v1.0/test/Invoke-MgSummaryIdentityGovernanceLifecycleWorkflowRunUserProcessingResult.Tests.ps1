if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgSummaryIdentityGovernanceLifecycleWorkflowRunUserProcessingResult' {
    It 'Summary' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SummaryViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
