if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaDismissDirectoryRecommendationImpactedResource'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaDismissDirectoryRecommendationImpactedResource.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaDismissDirectoryRecommendationImpactedResource' {
    It 'DismissExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Dismiss' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DismissViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DismissViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
