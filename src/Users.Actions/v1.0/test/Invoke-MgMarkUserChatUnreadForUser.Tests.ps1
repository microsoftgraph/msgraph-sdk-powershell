if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgMarkUserChatUnreadForUser'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgMarkUserChatUnreadForUser.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgMarkUserChatUnreadForUser' {
    It 'MarkExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Mark' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MarkViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'MarkViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
