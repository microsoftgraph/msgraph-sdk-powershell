if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaReportServiceAnnouncementHealthOverviewIssueIncident'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaReportServiceAnnouncementHealthOverviewIssueIncident.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaReportServiceAnnouncementHealthOverviewIssueIncident' {
    It 'Report' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'ReportViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
