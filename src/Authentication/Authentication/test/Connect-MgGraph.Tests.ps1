# ------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT License. See License in the project root for license information.
# ------------------------------------------------------------------------------

BeforeAll {
    $ModuleName = "Microsoft.Graph.Authentication"
    $ModulePath = Join-Path $PSScriptRoot "..\artifacts\$ModuleName.psd1"
    Import-Module $ModulePath -Force
    $RandomClientId = (New-Guid).Guid

    if (!(Get-Module Az.Accounts -ListAvailable)) {
        Install-Module Az.Accounts -Repository PSGallery -Scope CurrentUser -Force
    }
}
Describe 'Connect-MgGraph In Delegated Mode' {
    It 'ShouldThrowExceptionWhenInvalidTenantIdIsSpecified' {
        { Connect-MgGraph -TenantId "thisdomaindoesnotexist.com" -Scopes 'User.Read.All' -ErrorAction Stop -UseDeviceAuthentication } | Should -Throw -ExpectedMessage "*Tenant 'thisdomaindoesnotexist.com' not found*"
    }

    It 'ShouldThrowExceptionWhenInvalidScopeIsSpecified' {
        { Connect-MgGraph -Scopes 'User.Read.XYZ' -ErrorAction Stop -UseDeviceAuthentication } | Should -Throw -ExpectedMessage "*The scope 'User.Read.XYZ offline_access profile openid' does not exist*"
    }
}

Describe 'Connect-MgGraph In App Mode' {
    It 'ShouldThrowExceptionWhenCertificateThumbprintLengthIs > 40' {
        { Connect-MgGraph -ClientId $RandomClientId -CertificateThumbprint '12345678901234567890123456789012345678901' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*'CertificateThumbprint' must have a length of 40.*"
    }

    It 'ShouldThrowExceptionWhenCertificateThumbprintLengthIs < 40' {
        { Connect-MgGraph -ClientId $RandomClientId -CertificateThumbprint '123456789012345678901234567890123456789' -ErrorAction Stop } | Should -Throw -ExpectedMessage "*'CertificateThumbprint' must have a length of 40.*"
    }

}
Describe 'Connect-MgGraph Dependency Resolution' {
    It 'ShouldLoadMgModuleSideBySideWithAzModule.' {
        { Connect-AzAccount -ApplicationId $RandomClientId -CertificateThumbprint "Invalid" -Tenant "Invalid" -ErrorAction Stop } | Should -Throw -ExpectedMessage "*Could not find tenant id*"
        { Connect-MgGraph -Scopes "invalid.scope" -ErrorAction Stop -UseDeviceAuthentication } | Should -Throw -ExpectedMessage "*AADSTS70011:*"
    }
}