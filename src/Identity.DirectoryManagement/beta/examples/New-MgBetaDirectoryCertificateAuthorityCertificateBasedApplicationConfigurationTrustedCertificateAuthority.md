### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	isRootAuthority = $true
	certificate = [System.Text.Encoding]::ASCII.GetBytes("MIIGrDCCBJSgAwIBAgITWgACAdWQXvWynRA6/AABAAIB....")
	issuer = "ExampleIssuer"
	issuerSubjectKeyIdentifier = " BA:AF:4A:02:4D:AA:A6:F1:3C:25:8E:AD:FA:38:98:CE:D9:23:32:D9"
}

New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthority -CertificateBasedApplicationConfigurationId $certificateBasedApplicationConfigurationId -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthority Cmdlet.

