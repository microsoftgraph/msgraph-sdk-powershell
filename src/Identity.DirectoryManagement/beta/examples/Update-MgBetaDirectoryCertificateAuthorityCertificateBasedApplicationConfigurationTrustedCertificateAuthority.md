### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isRootAuthority = $true
}

Update-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthority -CertificateBasedApplicationConfigurationId $certificateBasedApplicationConfigurationId -CertificateAuthorityAsEntityId $certificateAuthorityAsEntityId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthority Cmdlet.

