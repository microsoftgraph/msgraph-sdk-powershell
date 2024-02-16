if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaReorderDeviceManagementReusablePolicySettingReferencingConfigurationPolicy'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaReorderDeviceManagementReusablePolicySettingReferencingConfigurationPolicy.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaReorderDeviceManagementReusablePolicySettingReferencingConfigurationPolicy' {
    It 'ReorderExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Reorder' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ReorderViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ReorderViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
