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

        It 'Should isolate authentication core dependencies on PowerShell Core' -Skip:($PSEdition -ne 'Core') {
            $authenticationAssembly = [System.AppDomain]::CurrentDomain.GetAssemblies() |
                Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication' } |
                Select-Object -First 1
            $authenticationCoreAssembly = [System.AppDomain]::CurrentDomain.GetAssemblies() |
                Where-Object { $_.GetName().Name -eq 'Microsoft.Graph.Authentication.Core' } |
                Select-Object -First 1
            $isolatedIdentityAssemblies = [System.AppDomain]::CurrentDomain.GetAssemblies() |
                Where-Object {
                    $_.GetName().Name -in @(
                        'Microsoft.Identity.Client',
                        'Microsoft.Identity.Client.Broker',
                        'Microsoft.IdentityModel.Abstractions'
                    ) -and
                    [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($_).Name -eq 'msgraph-load-context'
                }

            $authenticationAssembly | Should -Not -BeNullOrEmpty
            $authenticationCoreAssembly | Should -Not -BeNullOrEmpty
            [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($authenticationAssembly).Name | Should -Be 'Default'
            [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($authenticationCoreAssembly).Name | Should -Be 'msgraph-load-context'
            $isolatedIdentityAssemblies.GetName().Name | Should -Contain 'Microsoft.Identity.Client'
            $isolatedIdentityAssemblies.GetName().Name | Should -Contain 'Microsoft.Identity.Client.Broker'
            $isolatedIdentityAssemblies.GetName().Name | Should -Contain 'Microsoft.IdentityModel.Abstractions'
        }

        It 'Should isolate identity assemblies already loaded in the default context' -Skip:($PSEdition -ne 'Core') {
            $job = Start-Job -ScriptBlock {
                param($ModulePath)

                Add-Type -AssemblyName System.Runtime.Loader
                $moduleRoot = Split-Path $ModulePath
                $dependencies = Join-Path $moduleRoot 'Dependencies'
                $coreDependencies = Join-Path $dependencies 'Core'

                [void][System.Runtime.Loader.AssemblyLoadContext]::Default.LoadFromAssemblyPath(
                    (Join-Path $dependencies 'Microsoft.IdentityModel.Abstractions.dll'))
                [void][System.Runtime.Loader.AssemblyLoadContext]::Default.LoadFromAssemblyPath(
                    (Join-Path $coreDependencies 'Microsoft.Identity.Client.dll'))
                [void][System.Runtime.Loader.AssemblyLoadContext]::Default.LoadFromAssemblyPath(
                    (Join-Path $dependencies 'Microsoft.Identity.Client.Broker.dll'))

                Import-Module $ModulePath -Force

                [System.AppDomain]::CurrentDomain.GetAssemblies() |
                    Where-Object {
                        $_.GetName().Name -in @(
                            'Microsoft.Identity.Client',
                            'Microsoft.Identity.Client.Broker',
                            'Microsoft.IdentityModel.Abstractions'
                        )
                    } |
                    ForEach-Object {
                        [pscustomobject]@{
                            Name = $_.GetName().Name
                            Context = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($_).Name
                        }
                    }
            } -ArgumentList $ModulePath

            try {
                $identityAssemblies = $job | Wait-Job | Receive-Job
            }
            finally {
                $job | Remove-Job -Force -ErrorAction Ignore
            }

            foreach ($assemblyName in @(
                'Microsoft.Identity.Client',
                'Microsoft.Identity.Client.Broker',
                'Microsoft.IdentityModel.Abstractions'
            )) {
                $identityAssemblies |
                    Where-Object { $_.Name -eq $assemblyName } |
                    Select-Object -ExpandProperty Context |
                    Should -Contain 'Default'
                $identityAssemblies |
                    Where-Object { $_.Name -eq $assemblyName } |
                    Select-Object -ExpandProperty Context |
                    Should -Contain 'msgraph-load-context'
            }
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
}