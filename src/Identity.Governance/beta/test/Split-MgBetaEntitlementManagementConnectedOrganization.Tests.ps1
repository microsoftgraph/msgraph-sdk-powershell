if(($null -eq $TestName) -or ($TestName -contains 'Split-MgBetaEntitlementManagementConnectedOrganization'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Split-MgBetaEntitlementManagementConnectedOrganization.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Split-MgBetaEntitlementManagementConnectedOrganization' {
    It 'SplitByIdentitySource' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
