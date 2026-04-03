### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	displayName = "Contoso PKI"
}

New-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration -BodyParameter $params

```
This example shows how to use the New-MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration Cmdlet.

