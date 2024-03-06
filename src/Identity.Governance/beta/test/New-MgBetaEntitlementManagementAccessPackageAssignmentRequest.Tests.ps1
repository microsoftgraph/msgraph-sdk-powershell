if(($null -eq $TestName) -or ($TestName -contains 'New-MgBetaEntitlementManagementAccessPackageAssignmentRequest'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgBetaEntitlementManagementAccessPackageAssignmentRequest.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-MgBetaEntitlementManagementAccessPackageAssignmentRequest' {
    It 'CreateRequestAdminAdd' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateRequestAdminAddExternal' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateRequestAdminRemove' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
