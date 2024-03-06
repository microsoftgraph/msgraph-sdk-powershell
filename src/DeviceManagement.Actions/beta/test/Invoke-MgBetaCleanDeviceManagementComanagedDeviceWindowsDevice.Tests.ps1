if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaCleanDeviceManagementComanagedDeviceWindowsDevice'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaCleanDeviceManagementComanagedDeviceWindowsDevice.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaCleanDeviceManagementComanagedDeviceWindowsDevice' {
    It 'CleanExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Clean' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CleanViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CleanViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
