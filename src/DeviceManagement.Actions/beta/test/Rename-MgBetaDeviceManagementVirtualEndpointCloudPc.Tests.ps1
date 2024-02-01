if(($null -eq $TestName) -or ($TestName -contains 'Rename-MgBetaDeviceManagementVirtualEndpointCloudPc'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Rename-MgBetaDeviceManagementVirtualEndpointCloudPc.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Rename-MgBetaDeviceManagementVirtualEndpointCloudPc' {
    It 'RenameExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Rename' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RenameViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'RenameViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
