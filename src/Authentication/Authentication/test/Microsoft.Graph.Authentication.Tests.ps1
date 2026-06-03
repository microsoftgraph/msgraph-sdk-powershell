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

        It 'Should load the root authentication assembly outside the default AssemblyLoadContext' -Skip:($PSEdition -ne 'Core') {
            $assembly = [AppDomain]::CurrentDomain.GetAssemblies() |
                Where-Object { $_.GetName().Name -eq $ModuleName } |
                Select-Object -First 1

            $assembly | Should -Not -BeNullOrEmpty
            [System.Runtime.Loader.AssemblyLoadContext]::Default.Assemblies |
                Where-Object { $_.GetName().Name -eq $ModuleName } |
                Should -BeNullOrEmpty

            $loadContext = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly)
            $loadContext.Name | Should -Match '^Microsoft\.Graph\.Authentication\.'
        }

        It 'Should resolve isolated dependencies from worker threads on PowerShell Core' -Skip:($PSEdition -ne 'Core') {
            if (-not ('GraphAuthenticationAssemblyLoadContextTestHelper' -as [type])) {
                Add-Type -TypeDefinition @'
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

public static class GraphAuthenticationAssemblyLoadContextTestHelper
{
    public static Assembly LoadFromWorker(AssemblyLoadContext context, string assemblyName)
    {
        return Task.Run(() => context.LoadFromAssemblyName(new AssemblyName(assemblyName))).GetAwaiter().GetResult();
    }
}
'@
            }

            $assembly = [AppDomain]::CurrentDomain.GetAssemblies() |
                Where-Object { $_.GetName().Name -eq $ModuleName } |
                Select-Object -First 1

            $loadContext = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($assembly)
            $dependencyAssembly = [GraphAuthenticationAssemblyLoadContextTestHelper]::LoadFromWorker($loadContext, 'Azure.Core')
            $dependencyContext = [System.Runtime.Loader.AssemblyLoadContext]::GetLoadContext($dependencyAssembly)

            $dependencyAssembly.GetName().Name | Should -Be 'Azure.Core'
            $dependencyContext.Name | Should -Be $loadContext.Name
            [System.Runtime.Loader.AssemblyLoadContext]::Default.Assemblies |
                Where-Object { $_.GetName().Name -eq 'Azure.Core' } |
                Should -BeNullOrEmpty
        }
    }
}
