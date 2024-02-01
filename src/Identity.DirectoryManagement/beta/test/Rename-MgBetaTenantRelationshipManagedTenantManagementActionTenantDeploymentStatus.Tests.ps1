if(($null -eq $TestName) -or ($TestName -contains 'Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Rename-MgBetaTenantRelationshipManagedTenantManagementActionTenantDeploymentStatus' {
    It 'ChangeExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Change' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
