if(($null -eq $TestName) -or ($TestName -contains 'Set-MgBetaDriveRootSensitivityLabel'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Set-MgBetaDriveRootSensitivityLabel.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Set-MgBetaDriveRootSensitivityLabel' {
    It 'AssignExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Assign' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AssignViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'AssignViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
