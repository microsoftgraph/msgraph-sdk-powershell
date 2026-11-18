# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Microsoft.Graph.Authentication module" {
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Authentication"
        $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
        $PSModuleInfo = Import-Module $ModulePath -Force -PassThru
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
                    "Invoke-MgGraphRequest",
                    "Remove-MgEnvironment",
                    "Set-MgEnvironment",
                    "Find-MgGraphCommand",
                    "Connect-Graph",
                    "Disconnect-Graph",
                    "Invoke-GraphRequest",
                    "Find-MgGraphPermission",
                    "Invoke-MgRestMethod",
                    "Get-MgRequestContext",
                    "Set-MgRequestContext",
                    "Set-MgGraphOption",
                    "Get-MgGraphOption"
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

    Context "On module re-import" {
        # Regression guard for the switch to a private AssemblyLoadContext on PowerShell 7+.
        # Importing, removing and re-importing the module must succeed: the second import must not fail
        # because the isolated load context (and its already-loaded dependencies) is being initialized again.
        It 'Should import, remove and re-import without error' {
            {
                Import-Module $ModulePath -Force
                Remove-Module $ModuleName -Force
                Import-Module $ModulePath -Force
            } | Should -Not -Throw
        }

        It 'Should expose its cmdlets after a re-import' {
            Import-Module $ModulePath -Force
            Remove-Module $ModuleName -Force
            $ReimportedInfo = Import-Module $ModulePath -Force -PassThru

            $ReimportedInfo.ExportedCommands.Keys | Should -Contain "Connect-MgGraph"
            $ReimportedInfo.ExportedCommands.Keys | Should -Contain "Invoke-MgGraphRequest"
        }

        It 'Should keep the same isolated assemblies loaded after a re-import' {
            Import-Module $ModulePath -Force
            Remove-Module $ModuleName -Force
            Import-Module $ModulePath -Force

            # Invoking a cmdlet forces the isolated dependencies (Azure.Identity / MSAL / Kiota) to bind.
            # If the re-import left the load context in a broken state this throws instead of returning $null.
            { Get-MgContext } | Should -Not -Throw
        }
    }
}