if(($null -eq $TestName) -or ($TestName -contains 'Get-MgDeviceAppManagementMobileAppCategory'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-MgDeviceAppManagementMobileAppCategory.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Get-MgDeviceAppManagementMobileAppCategory' {
    It 'List' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get17' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List17' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get17' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Get' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'List7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
