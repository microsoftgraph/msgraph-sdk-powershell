if(($null -eq $TestName) -or ($TestName -contains 'Update-MgDeviceAppManagementMobileAppAssignment'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Update-MgDeviceAppManagementMobileAppAssignment.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Update-MgDeviceAppManagementMobileAppAssignment' {
    It 'UpdateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update6' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update5' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update4' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update2' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update16' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update15' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update14' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update13' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update12' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update11' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Update10' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded9' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded8' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'UpdateExpanded7' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
