if(($null -eq $TestName) -or ($TestName -contains 'Get-MgBetaReportManagedDeviceEnrollmentFailureTrend'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgBetaReportManagedDeviceEnrollmentFailureTrend.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-MgBetaReportManagedDeviceEnrollmentFailureTrend' {
    It 'Managed' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
