### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Contoso PKI"
}

Update-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration Cmdlet.

