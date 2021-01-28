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
Describe 'Invoke-MgGraphRequest Collection Results' {
    BeforeAll {
         Connect-MgGraph
    }
    It 'ShouldReturnPsObject' {
         Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Management.Automation.PSObject]
    }

    It 'ShouldReturnHashTable' {
         $hashTable = Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Collections.Hashtable]
    }

    It 'ShouldReturnJsonString' {
         $jsonString = Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.String]
    }

    It 'ShouldReturnHttpResponseMessage' {
        $httpResponseMessage = Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/v1.0/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
    }

    It 'ShouldReturnPsObjectBeta' {
         $psObject = Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Management.Automation.PSObject]
    }

    It 'ShouldReturnHashTableBeta' {
         $hashTable = Invoke-MgGraphRequest -OutputType Hashtable -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Collections.Hashtable]
    }

    It 'ShouldReturnJsonStringBeta' {
         $jsonString = Invoke-MgGraphRequest -OutputType Json -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.String]
    }

    It 'ShouldReturnHttpResponseMessageBeta' {
        $httpResponseMessage = Invoke-MgGraphRequest -OutputType HttpResponseMessage -Uri "https://graph.microsoft.com/beta/users" | Should -BeOfType [System.Net.Http.HttpResponseMessage]
    }
}
Describe 'Invoke-MgGraphRequest Single Entity' {
    BeforeAll {
         Connect-MgGraph
    }
    It 'ShouldReturnPsObject' {
         $psObject = Invoke-MgGraphRequest -OutputType PSObject -Uri "https://graph.microsoft.com/v1.0/users/${env:DEFAULTUSERID}" | Should -BeOfType [System.Management.Automation.PSObject]
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

Describe 'Invoke-MgGraphRequest Non-Json Responses'{
    BeforeAll {
        Connect-MgGraph
    }
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