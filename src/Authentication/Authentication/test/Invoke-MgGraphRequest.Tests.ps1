
Describe 'Invoke-MgGraphRequest Command' {
     BeforeAll {
         $utils = Join-Path $PSScriptRoot "../../../../tools/Utilities/utils.ps1" -Resolve
          . $utils
          $ModuleName = "Microsoft.Graph.Authentication"
          $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
          Import-Module $ModulePath -Force

          Connect-GraphTenant
     }
     Context 'Collection Results' {
          It 'ShouldReturnPsObject' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'ShouldReturnHashTable' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'ShouldReturnJsonString' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.String]
          }

          It 'ShouldReturnHttpResponseMessage' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }

          It 'ShouldReturnPsObjectBeta' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'ShouldReturnHashTableBeta' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'ShouldReturnJsonStringBeta' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.String]
          }

          It 'ShouldReturnHttpResponseMessageBeta' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }
     }
     Context 'Single Entity' {
          It 'ShouldReturnPsObject' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'ShouldReturnHashTable' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'ShouldReturnJsonString' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.String]
          }

          It 'ShouldReturnHttpResponseMessage' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }

          It 'ShouldReturnPsObjectBeta' {
               Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Management.Automation.PSObject]
          }

          It 'ShouldReturnHashTableBeta' {
               Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Collections.Hashtable]
          }

          It 'ShouldReturnJsonStringBeta' {
               Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.String]
          }

          It 'ShouldReturnHttpResponseMessageBeta' {
               Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
          }
     }

     Context 'Non-Json Responses' {
          It 'Should Throw when -OutputFilePath is not Specified and Request Returns a Non-Json Response' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" } | Should -Throw
          }
          It 'Should Not Throw when -OutputFilePath is Specified' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" -OutputFilePath ./data.csv } | Should -Not -Throw
          }
          It 'Should Not Throw when -InferOutputFilePath is Specified' {
               { Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/reports/getTeamsUserActivityUserDetail(period='D7')" -InferOutputFileName } | Should -Not -Throw
          }
     }

     Context 'Absolute and relative URIs' {
          It 'Should not throw when absolute URI is used on GET' {
               { Invoke-MgGraphRequest -Method GET -Uri "https://graph.microsoft.com/v1.0/organization" } | Should -Not -Throw
          }
          It 'Should not throw when relative URI is used on GET' {
               { Invoke-MgGraphRequest -Method GET -Uri "/v1.0/organization" } | Should -Not -Throw
          }
          It 'Should not throw when absolute URI is used on POST' {
               $body = @{ "ids" = @("00257bcc-c612-4a8b-b04d-ddc1e3cbafc1"); "types" = @("user") }
               { Invoke-MgGraphRequest -Method POST -Uri "https://graph.microsoft.com/v1.0/directoryObjects/getByIds" -Body $body } | Should -Not -Throw
          }
          It 'Should not throw when relative URI is used on POST' {
               $body = @{ "ids" = @("00257bcc-c612-4a8b-b04d-ddc1e3cbafc1"); "types" = @("user") }
               { Invoke-MgGraphRequest -Method POST -Uri "/v1.0/directoryObjects/getByIds" -Body $body } | Should -Not -Throw
          }
     }

     Context 'Empty Body Requests' {
         It 'Should Not Throw when Body is Empty for POST Requests' {
                { 
                    Invoke-MgGraphRequest -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}/revokeSignInSessions" -Method POST -Verbose
                } | Should  -Not -Throw
         }
     }

     AfterAll {
          Disconnect-MgGraph
     }
}