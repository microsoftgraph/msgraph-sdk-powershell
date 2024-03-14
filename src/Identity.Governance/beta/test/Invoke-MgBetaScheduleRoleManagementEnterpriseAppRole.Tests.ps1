if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaScheduleRoleManagementEnterpriseAppRole'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaScheduleRoleManagementEnterpriseAppRole.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaScheduleRoleManagementEnterpriseAppRole' {
    It 'Schedule' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ScheduleViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
