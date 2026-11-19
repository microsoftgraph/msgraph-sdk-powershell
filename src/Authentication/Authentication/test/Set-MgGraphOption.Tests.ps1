# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Set-MgGraphOption" {    
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Authentication"
        $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
        Import-Module $ModulePath -Force -ErrorAction SilentlyContinue
    }
    Context "When executing the command" {
        it 'Should have one ParameterSets' {
            $SetMgGraphOptionCommand = Get-Command Set-MgGraphOption
            $SetMgGraphOptionCommand | Should -Not -BeNullOrEmpty
            $SetMgGraphOptionCommand.ParameterSets | Should -HaveCount 1
            $SetMgGraphOptionCommand.ParameterSets.Parameters | Should -HaveCount 13 # PS common parameters.
        }

        It 'Executes successfully when disabling WAM' {
            { Set-MgGraphOption -DisableLoginByWAM $true -Debug | Out-Null } | Should -Not -Be $null
            { Set-MgGraphOption -DisableLoginByWAM $true -ErrorAction SilentlyContinue } | Should -Not -Throw
        }

        It 'Executes successfully when enabling WAM' {
            { Set-MgGraphOption -DisableLoginByWAM $false -Debug | Out-Null } | Should -Not -Be $null
            { Set-MgGraphOption -DisableLoginByWAM $false -ErrorAction SilentlyContinue } | Should -Not -Throw
        }
    }
}