if(($null -eq $TestName) -or ($TestName -contains 'New-MgBetaEntitlementManagementAccessPackageAssignment'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgBetaEntitlementManagementAccessPackageAssignment.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-MgBetaEntitlementManagementAccessPackageAssignment' {
    It 'CreateMultipleRequestAdminAddExistingUser' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateMultipleRequestAdminAddExistingGroupMember' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
