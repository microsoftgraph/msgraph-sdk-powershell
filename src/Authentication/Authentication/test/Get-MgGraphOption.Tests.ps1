# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Get-MgGraphOption Command" {    
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Authentication"
        $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
        Import-Module $ModulePath -Force
    }
    Context "When executing the command" {
        it 'Should have one ParameterSets' {
            $GetMgGraphOptionCommand = Get-Command Set-MgGraphOption
            $GetMgGraphOptionCommand | Should -Not -BeNullOrEmpty
            $GetMgGraphOptionCommand.ParameterSets | Should -HaveCount 1
            $GetMgGraphOptionCommand.ParameterSets.Parameters | Should -HaveCount 14 # PS common parameters.
        }
    
        It 'Executes successfully' {
            { Get-MgGraphOption -Debug | Out-Null } | Should -Not -Be $null
            { Get-MgGraphOption -ErrorAction SilentlyContinue } | Should -Not -Throw
        }
    }
}