### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	isIssuerHintEnabled = $true
}

Update-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -CertificateAuthorityDetailId $certificateAuthorityDetailId -BodyParameter $params

```
This example shows how to use the Update-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority Cmdlet.

