### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Contoso PKI"
}

New-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration Cmdlet.

