# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------
Describe "Microsoft.Graph.Applications Module" {
    Context "On module import" {
        BeforeAll {
            $ModuleName = "Microsoft.Graph.Applications"
            $ModulePath = Join-Path $PSScriptRoot "..\$ModuleName.psd1"
            $PSModuleInfo = Get-Module $ModuleName
        }

        It "Should have exported commands" {
            $PSModuleInfo | Should -Not -Be $null
            $PSModuleInfo.ExportedCommands.Count | Should -Not -Be 0
        }
    
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
            $PSModuleInfo.Guid.Guid | Should -Be "467f54f2-44a8-4993-8e75-b96c3e443098"
        }
    
        It "Module import should not write to streams when debug preference is not set" {
            $ps = [powershell]::Create()
            $ps.AddScript("Import-Module $ModulePath -ErrorAction SilentlyContinue").Invoke()

            $ps.Streams.Information.Count | Should -Be 0
            $ps.Streams.Debug.Count | Should -Be 0
            $ps.Streams.Error.Count | Should -Be 0
            $ps.Streams.Verbose.Count | Should -Be 0
            $ps.Streams.Warning.Count | Should -Be 0
            $ps.Streams.Progress.Count | Should -Be 0

            $ps.Dispose()
        }
    
        It "Module import should write to streams when debug preference is set" {
            $ps = [powershell]::Create()
            $ps.AddScript("`$DebugPreference = 'Inquire'; Import-Module $ModulePath -ErrorAction SilentlyContinue").Invoke()
    
            $ps.Streams.Information.Count | Should -Be 0
            $ps.Streams.Debug.Count | Should -Be 0
            $ps.Streams.Error.Count | Should -Be 0
            $ps.Streams.Verbose.Count | Should -Be 0
            $ps.Streams.Warning.Count | Should -Be 0
            $ps.Streams.Progress.Count | Should -Be 0

            $ps.Dispose()
        }
    }
}