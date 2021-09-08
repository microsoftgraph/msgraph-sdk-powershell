# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Microsoft.Graph.Planner module" {
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Planner"
        $ModulePath = Join-Path $PSScriptRoot "..\$ModuleName.psd1"
        $PSModuleInfo = Import-Module $ModulePath -Force -PassThru
    }

    AfterAll {
        Remove-Module $ModuleName -Force
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

        It 'Should not export suppressed commands' {
            {
                $SuppressedCommands = @(
                    "Update-MgUserPlannerTask",
                    "New-MgUserPlannerTask",
                    "Remove-MgUserPlannerTask",
                    "Get-MgUserPlannerPlanTask",
                    "Get-MgUserPlannerFavoritePlanByRef",
                    "New-MgUserPlannerFavoritePlanByRef",
                    "New-MgUserPlannerPlanTask",
                    "Remove-MgUserPlannerPlanTask"
                )

                $SuppressedCommands | Should -Not -BeIn $PSModuleInfo.ExportedCommands.Keys
            } | Should -Not -Throw
        }

        It 'Should export expected commands' {
            {
                $ExpectedCommands = @(
                    "Get-MgUserPlannerTask",
                    "Get-MgUserPlannerPlan"
                )

                $ExpectedCommands | Should -BeIn $PSModuleInfo.ExportedCommands.Keys
            } | Should -Not -Throw
        }
    }
}