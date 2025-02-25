### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	uploadUrl = "https://microsoft.sharepoint.com/CBA/demo/CBARootPKI.p7b"
	sha256FileHash = "D7F9....61E6F"
}

Invoke-MgBetaUploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration -CertificateBasedAuthPkiId $certificateBasedAuthPkiId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaUploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration Cmdlet.

