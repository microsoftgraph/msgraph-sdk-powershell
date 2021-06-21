# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "The Microsoft.Graph.Authentication module" {
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Authentication"
        $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
        Import-Module $ModulePath -Force
    }

    AfterAll {
        Remove-Module $ModulePath -Force -ErrorAction Ignore
    }

    Context "When importing the module" {
        It "Should export specific set of commands"{
            $expectedCommands = @(
                'Add-MgEnvironment'
                'Connect-MgGraph'
                'Disconnect-MgGraph'
                'Get-MgContext'
                'Get-MgEnvironment'
                'Get-MgProfile'
                'Invoke-MgGraphRequest'
                'Remove-MgEnvironment'
                'Select-MgProfile'
                'Set-MgEnvironment'
                'Find-MgGraphPermission'
            )

            $actualCommands = Get-Module $ModuleName |
                 Select-Object -ExpandProperty ExportedCommands |
                 Select-Object -ExpandProperty Keys
            
            $expectedCommands.Count | Should -Be $actualCommands.Count

            ForEach ( $expectedCommand in $expectedCommands ) {
                $expectedCommand | Should -BeIn $actualCommands 
            }  
        }
    }
}