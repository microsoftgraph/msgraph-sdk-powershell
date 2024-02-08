if(($null -eq $TestName) -or ($TestName -contains 'Remove-MgGroupSiteTermStoreGroupSetChild'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Remove-MgGroupSiteTermStoreGroupSetChild.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Remove-MgGroupSiteTermStoreGroupSetChild' {
    It 'Delete' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Delete1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'DeleteViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
