if(($null -eq $TestName) -or ($TestName -contains 'Add-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Add-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Add-MgBetaWindowsUpdatesDeploymentAudienceExclusionMemberById' {
    It 'AddExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Add' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AddViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AddViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
