if(($null -eq $TestName) -or ($TestName -contains 'Invoke-MgGraphReportAuthenticationMethod'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-MgGraphReportAuthenticationMethod.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Invoke-MgGraphReportAuthenticationMethod' {
    It 'Graph' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Graph3' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Graph1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GraphViaIdentity1' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GraphViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
