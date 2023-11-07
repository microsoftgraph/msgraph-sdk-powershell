if(($null -eq $TestName) -or ($TestName -contains 'New-MgDeviceAppManagementMobileAppAssignment'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'New-MgDeviceAppManagementMobileAppAssignment.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-MgDeviceAppManagementMobileAppAssignment' {
    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Create10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'CreateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
