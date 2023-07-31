# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
    Import-Module $ModulePath -Force
    # Test JWT access token. Holds dummy values.
    $DummyToken = "eyJhbGciOiJIUzI1NiJ9.eyJSb2xlIjoiVGVzdCIsIklzc3VlciI6Iklzc3VlciIsIlVzZXJuYW1lIjoiVGVzdCIsImV4cCI6MTkxMTIzMDM1NiwiaWF0IjoxNjc4NDg4ODE2fQ.yjRvogDyxlQrrQV3EaEsZJKhpYuNzaCyrh5Ip9WvdjU"
}

Describe 'Get-MgContext' {
    It 'Should throw return null when no auth context exists for the session' {
        $Context = Get-MgContext
        $Context | Should -Be $null
    }
    
    It 'Should default to Global environment when no environment is specified' {
        Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken)
        $Context = Get-MgContext
        $Context | Should -Not -Be $null
        $Context.Environment | Should -Be "Global"
        $Context.AuthType | Should -Be "UserProvidedAccessToken"
    }

        
    It 'Should return the correct environment when specified via Connect-MgGraph -Environment' {
        Connect-MgGraph -AccessToken (ConvertTo-SecureString -AsPlainText -String $DummyToken) -Environment Germany
        $Context = Get-MgContext
        $Context | Should -Not -Be $null
        $Context.Environment | Should -Be "Germany"
        $Context.AuthType | Should -Be "UserProvidedAccessToken"
    }
}

AfterAll {
    Disconnect-MgGraph
}