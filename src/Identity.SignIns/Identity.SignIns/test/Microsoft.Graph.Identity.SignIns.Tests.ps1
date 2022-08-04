# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

Describe "Microsoft.Graph.Identity.SignIns module" {
    BeforeAll {
        $ModuleName = "Microsoft.Graph.Identity.SignIns"
        $PSModuleInfo = Get-Module $ModuleName
    }

    Context "On module import" {
        It 'Should be compatible with PS core and desktop' {
            $PSModuleInfo.CompatiblePSEditions | Should -BeIn @("Core", "Desktop")
        }

        It 'Should point to script module' {
            $PSModuleInfo.Path | Should -BeLikeExactly "*$ModuleName.psm1"
        }

        It 'Should have a definition' {
            $PSModuleInfo.Definition | Should -Not -BeNullOrEmpty
        }

        It 'Should lock GUID' {
            $PSModuleInfo.Guid.Guid | Should -Be "60f889fa-f873-43ad-b7d3-b7fc1273a44f"
        }
    }
}