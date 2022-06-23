BeforeAll {
    $ModuleName = "Microsoft.Graph.Applications"
    $ModulePath = Join-Path $PSScriptRoot "..\$ModuleName.psd1"
}

Describe "Applications Module" {
    It "Module should be available when imported" {
        Import-Module $ModulePath
        $LoadedModule = Get-Module -Name $ModuleName

        $LoadedModule | Should -Not -Be $null
        $LoadedModule.ExportedCommands.Count | Should -Not -Be 0
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