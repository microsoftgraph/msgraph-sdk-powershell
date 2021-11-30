# Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

<#
    Connect to the Graph Tenant
#>
Function Connect-GraphTenant
{
    $defaultCertificate = Get-LocalCertificate
    #Connect To Microsoft Graph Raptor Default Tenant Using ClientId, TenantId and Certificate
    Connect-MgGraph -Certificate $defaultCertificate -ClientId ${env:CLIENTIDENTIFIER} -TenantId ${env:TENANTIDENTIFIER} | Out-Null
}

<#
    Get Certificate from Azure KeyVault loaded via Environment variable
#>
Function Get-LocalCertificate
{
    if ($null -eq $global:DefaultCertificate)
    {
        $certificateData = $env:MsGraphPSSDKCertificate
        $kvSecretBytes = [System.Convert]::FromBase64String($certificateData)
        $pfxCertificate = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2 -ArgumentList @($kvSecretBytes, "", [System.Security.Cryptography.X509Certificates.X509KeyStorageFlags]::Exportable)
        $global:DefaultCertificate = $pfxCertificate
    }
    return $global:DefaultCertificate
}