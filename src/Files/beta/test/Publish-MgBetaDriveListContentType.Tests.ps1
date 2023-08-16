if(($null -eq $TestName) -or ($TestName -contains 'Publish-MgBetaDriveListContentType'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Publish-MgBetaDriveListContentType.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Publish-MgBetaDriveListContentType' {
    It 'Publish' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PublishViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
