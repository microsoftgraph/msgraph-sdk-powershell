# Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

<#
    Connect to the Graph Tenant
#>
Function Connect-GraphTenant {
    $defaultCertificate = Get-LocalCertificate
    #Connect To Microsoft Graph Raptor Default Tenant Using ClientId, TenantId and Certificate
    if ($null -eq $defaultCertificate) {
        Connect-MgGraph -CertificateThumbprint ${env:CERTIFICATETHUMBPRINT} -ClientId ${env:CLIENTIDENTIFIER} -TenantId ${env:TENANTIDENTIFIER} | Out-Null
    }
    else {
        Connect-MgGraph -Certificate $defaultCertificate -ClientId ${env:CLIENTIDENTIFIER} -TenantId ${env:TENANTIDENTIFIER} | Out-Null
    }
}

<#
    Get Certificate from Azure KeyVault loaded via Environment variable
#>
Function Get-LocalCertificate {
    if (($null -eq $global:DefaultCertificate) -and ($null -ne $env:CLIENTCERTIFICATE)) {
        $kvSecretBytes = [System.Convert]::FromBase64String($env:CLIENTCERTIFICATE)
        $pfxCertificate = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2 -ArgumentList @($kvSecretBytes, "", [System.Security.Cryptography.X509Certificates.X509KeyStorageFlags]::Exportable)
        $global:DefaultCertificate = $pfxCertificate
    }
    return $global:DefaultCertificate
}

<#
    Converts a simple single-level YAML string into a hashtable.
#>
Function ConvertFrom-SimpleYaml {
    param([string]$Yaml)
    $result = @{}
    $Yaml -split "`n" | ForEach-Object {
        if ($_.Trim() -match '^([^:]+):\s*(.*)$') {
            $result[$Matches[1].Trim()] = $Matches[2].Trim()
        }
    }
    return $result
}