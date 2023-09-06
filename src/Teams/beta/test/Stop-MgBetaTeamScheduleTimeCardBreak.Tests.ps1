if(($null -eq $TestName) -or ($TestName -contains 'Stop-MgBetaTeamScheduleTimeCardBreak'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Stop-MgBetaTeamScheduleTimeCardBreak.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Stop-MgBetaTeamScheduleTimeCardBreak' {
    It 'EndExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'End' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'EndViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'EndViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
