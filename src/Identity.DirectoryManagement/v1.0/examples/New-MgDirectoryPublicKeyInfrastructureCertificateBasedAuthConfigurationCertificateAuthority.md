### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	certificateAuthorityType = "intermediate"
}

New-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -BodyParameter $params

```
This example shows how to use the New-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority Cmdlet.

