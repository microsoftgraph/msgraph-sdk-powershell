# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Microsoft.Graph.Authentication module" {
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Authentication"
        $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
        $PSModuleInfo = Import-Module $ModulePath -Force -PassThru
    }

    AfterAll {
        Remove-Module $ModuleName -Force -ErrorAction Ignore
    }

    Context "On module import" {
        It 'Should be compatible with PS core and desktop' {
            {
                $PSModuleInfo.CompatiblePSEditions | Should -BeIn @("Core", "Desktop")
            } | Should -Not -Throw
        }

        It 'Should point to script module' {
            {
                $PSModuleInfo.Path | Should -BeLikeExactly "*$ModuleName.psm1"
            } | Should -Not -Throw
        }

        It 'Should have a definition' {
            {
                $PSModuleInfo.Definition | Should -Not -BeNullOrEmpty
            } | Should -Not -Throw
        }

        It 'Should export expected commands' {
            {
                $ExpectedCommands = @(
                    "Add-MgEnvironment",
                    "Connect-MgGraph",
                    "Disconnect-MgGraph",
                    "Get-MgContext",
                    "Get-MgEnvironment",
                    "Get-MgProfile",
                    "Invoke-MgGraphRequest",
                    "Remove-MgEnvironment",
                    "Select-MgProfile",
                    "Set-MgEnvironment",
                    "Find-MgGraphCommand",
                    "Connect-Graph",
                    "Disconnect-Graph",
                    "Invoke-GraphRequest",
                    "Find-MgGraphPermission"
                )

                $PSModuleInfo.ExportedCommands.Keys | Should -BeIn $ExpectedCommands
            } | Should -Not -Throw
        }

        It 'Should export expected aliases' {
            {
                $ExpectedAliases = @(
                    "Connect-Graph",
                    "Disconnect-Graph",
                    "Invoke-GraphRequest",
                    "Invoke-MgRestMethod"
                )

                $PSModuleInfo.ExportedAliases.Keys | Should -BeIn $ExpectedAliases
            } | Should -Not -Throw
        }

        It 'Should lock GUID' {
            $PSModuleInfo.Guid.Guid | Should -Be "883916f2-9184-46ee-b1f8-b6a2fb784cee"
        }
    }
}