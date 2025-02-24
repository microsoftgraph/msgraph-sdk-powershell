### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isIssuerHintEnabled = $true
}

Update-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -CertificateAuthorityDetailId $certificateAuthorityDetailId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority Cmdlet.

