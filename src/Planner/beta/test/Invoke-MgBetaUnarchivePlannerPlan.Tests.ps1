if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaUnarchivePlannerPlan'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaUnarchivePlannerPlan.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaUnarchivePlannerPlan' {
    It 'UnarchiveExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Unarchive' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnarchiveViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnarchiveViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
