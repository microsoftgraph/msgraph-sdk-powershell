if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgFilterRoleManagementEntitlementManagementRoleEligibilityScheduleInstanceByCurrentUser' {
    It 'Filter' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'FilterViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
