if(($null -eq $TestName) -or ($TestName -contains 'Publish-MgBetaBookingBusiness'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Publish-MgBetaBookingBusiness.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Publish-MgBetaBookingBusiness' {
    It 'Publish' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Publish1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PublishViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'PublishViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
