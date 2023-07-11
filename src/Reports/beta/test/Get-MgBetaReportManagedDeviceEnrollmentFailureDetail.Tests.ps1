if(($null -eq $TestName) -or ($TestName -contains 'Get-MgBetaReportManagedDeviceEnrollmentFailureDetail'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgBetaReportManagedDeviceEnrollmentFailureDetail.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-MgBetaReportManagedDeviceEnrollmentFailureDetail' {
    It 'Detail' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Detail1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DetailViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
