if(($null -eq $TestName) -or ($TestName -contains 'Get-MgReportManagedDeviceEnrollmentTopFailure'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgReportManagedDeviceEnrollmentTopFailure.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-MgReportManagedDeviceEnrollmentTopFailure' {
    It 'Top' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Top1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'TopViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
