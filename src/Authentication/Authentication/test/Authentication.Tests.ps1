BeforeAll {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\$ModuleName.psd1"
    Import-Module $ModulePath -Force
}
Describe 'Invoke-GraphRequest' {
    BeforeAll {
         Connect-Graph
    }
    It 'ShouldReturnPsObject' {
         $psObject = Invoke-GraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users"  | Should -BeOfType [System.Management.Automation.PSObject]
    }

    It 'ShouldReturnHashTable' {
         $hashTable = Invoke-GraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users"  | Should -BeOfType [System.Collections.Hashtable]
    }

    It 'ShouldReturnJsonString' {
         $jsonString = Invoke-GraphRequest -OutputType Json -Uri "https://graph.microsoft.com/v1.0/users"  | Should -BeOfType [System.String]
    }

    It 'ShouldReturnHttpResponseMessage' {
        $httpResponseMessage = Invoke-GraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
    }

    It 'ShouldReturnPsObjectBeta' {
         $psObject = Invoke-GraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/beta/users"  | Should -BeOfType [System.Management.Automation.PSObject]
    }

    It 'ShouldReturnHashTableBeta' {
         $hashTable = Invoke-GraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/beta/users"  | Should -BeOfType [System.Collections.Hashtable]
    }

    It 'ShouldReturnJsonStringBeta' {
         $jsonString = Invoke-GraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users"  | Should -BeOfType [System.String]
    }

    It 'ShouldReturnHttpResponseMessageBeta' {
        $httpResponseMessage = Invoke-GraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
    }
}