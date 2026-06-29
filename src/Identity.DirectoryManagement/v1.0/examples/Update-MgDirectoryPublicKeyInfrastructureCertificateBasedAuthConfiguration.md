### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	displayName = "Contoso PKI"
}

Update-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -BodyParameter $params

```
This example shows how to use the Update-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration Cmdlet.

