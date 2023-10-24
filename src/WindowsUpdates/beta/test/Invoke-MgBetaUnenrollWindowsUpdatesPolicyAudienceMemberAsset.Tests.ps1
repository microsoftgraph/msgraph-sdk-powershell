if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgBetaUnenrollWindowsUpdatesPolicyAudienceMemberAsset'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgBetaUnenrollWindowsUpdatesPolicyAudienceMemberAsset.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgBetaUnenrollWindowsUpdatesPolicyAudienceMemberAsset' {
    It 'UnenrollExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Unenroll' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnenrollViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UnenrollViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
