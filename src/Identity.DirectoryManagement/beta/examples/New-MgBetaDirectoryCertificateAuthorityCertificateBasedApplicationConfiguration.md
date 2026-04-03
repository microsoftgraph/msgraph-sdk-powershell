### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Tenant Trusted Certificate Chain of Trust for Application Configuration"
	description = "The Trusted Certificate Chain of Trust containing a certificate chain used by the Tenant app policy, to only allow application certificates from this issuer."
	"trustedCertificateAuthorities " = @(
		@{
			isRootAuthority = $true
			certificate = "MIIHMDCCBRigAwIBAgITWgAAmdzMYKZPslw+twABAACZ"
		}
	)
}

New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfiguration -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryCertificateAuthorityCertificateBasedApplicationConfiguration Cmdlet.

