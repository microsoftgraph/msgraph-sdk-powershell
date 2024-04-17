if(($null -eq $TestName) -or ($TestName -contains 'Undo-MgBetaTeamPrimaryChannelMessageReplySoftDelete'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Undo-MgBetaTeamPrimaryChannelMessageReplySoftDelete.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Undo-MgBetaTeamPrimaryChannelMessageReplySoftDelete' {
    It 'Undo' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UndoViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
