BeforeAll {
    $ModulePrefix = "Microsoft.Graph"
    $AuthModuleName = "Authentication"
    $AuthModulePath = Join-Path $PSScriptRoot "..\..\src\$AuthModuleName\$AuthModuleName\artifacts\$ModulePrefix.$AuthModuleName.psd1"
    $TestModuleName = "DirectoryObjects"
    $TestModulePath = Join-Path $PSScriptRoot "..\..\src\$TestModuleName\$TestModuleName\$ModulePrefix.$TestModuleName.psd1"
    Import-Module $AuthModulePath -Force
    Import-Module $TestModulePath -Force

    Connect-MgGraph
    Select-MgProfile beta
}
Describe 'Cmdlets Streams' {
    It 'Should Not Throw Exception when Debug Preference is Set'{
        $ps = [powershell]::Create()
$ps.AddScript(@'
        $DebugPreference = 'Continue'
        Test-MgDirectoryObjectProperty -DisplayName "New Name" -EntityType "Group" 
'@).Invoke()
        $ps.Streams.Debug | Should -notLike -BeLike "*Exception*"
        $ps.Streams.Debug -like  "*HTTP/1.1 200 OK*"
    }
 }