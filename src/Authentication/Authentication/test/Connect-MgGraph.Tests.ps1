BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\$ModuleName.psd1"
    Import-Module $ModulePath -Force
}
Describe 'Connect-MgGraph In Delegated Mode' {
    It 'ShouldThrowExceptionWhenInvalidTenantIdIsSpecified' {
        { Connect-MgGraph -TenantId "thisdomaindoesnotexist.com" -Scopes 'User.Read.All' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*Tenant 'thisdomaindoesnotexist.com' not found*"
    }

    It 'ShouldThrowExceptionWhenInvalidScopeIsSpecified' {
        { Connect-MgGraph -Scopes 'User.Read.XYZ' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*The scope 'User.Read.XYZ offline_access profile openid' does not exist*"
    }
}