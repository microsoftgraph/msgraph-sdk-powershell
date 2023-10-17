if(($null -eq $TestName) -or ($TestName -contains 'Reset-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfigurationToDefaultSetting'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Reset-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfigurationToDefaultSetting.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Reset-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfigurationToDefaultSetting' {
    It 'Reset' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
