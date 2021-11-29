# Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.

<#
       Install Required Tools
#>
Function Install-AzModule {
    if (!(Get-Module -Name Az -ListAvailable)) {
        Install-Module -Name Az -Repository PSGallery -Scope CurrentUser -Force -SkipPublisherCheck -AllowClobber 
        Import-Module Az
    }
}
<#
    Connect to the Graph Tenant
#>
Function Connect-GraphTenant
{
    $defaultCertificate = Get-Certificate
    #Connect To Microsoft Graph Raptor Default Tenant Using ClientId, TenantId and Certificate
    Connect-MgGraph -Certificate $defaultCertificate -ClientId ${env:CLIENTIDENTIFIER} -TenantId ${env:TENANTIDENTIFIER} | Out-Null
}

<#
    Connect to Azure Tenant to Access KeyVault and other resources.
#>
Function Connect-AzureTenant
{
    $AzureTenantID = ${env:AZURETENANTID}
    $AzureApplicationID = ${env:AZUREAPPLICATIONID}

    $securePassword = ConvertTo-SecureString -String $env:AZUREAPPCLIENTSECRET -AsPlainText -Force

    $Credential = New-Object -TypeName PSCredential -ArgumentList $AzureApplicationID, $securePassword
    Connect-AzAccount -Credential $Credential -Tenant $AzureTenantID -ServicePrincipal | Out-Null
}

<#
    Get Certificate from Azure KeyVault
#>
$global:DefaultCertificate = $null
Function Get-Certificate
{
    if ($null -eq $global:DefaultCertificate)
    {
        Connect-AzureTenant
        # Certificate must be downloaded as a Secret instead of a Certificate to bring down the PrivateKey as well.
        $keyVaultCertSecret = Get-AzKeyVaultSecret -VaultName ${env:AZUREKEYVAULTNAME} -Name ${env:CERTIFICATENAME}
        # Convert the Secret Value in the response to plainText
        $secureCertData = ConvertFrom-SecureString -SecureString $keyVaultCertSecret.SecretValue -AsPlainText
        # KeyVault Secrets are Base64 Encoded, thus decode.
        $base64CertData = [Convert]::FromBase64String($secureCertData)
        # Create an In-Memory cert from Cert Data
        $pfxCertificate = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2 -ArgumentList @($base64CertData, "", [System.Security.Cryptography.X509Certificates.X509KeyStorageFlags]::Exportable)
        $global:DefaultCertificate = $pfxCertificate
    }
    return $global:DefaultCertificate
}