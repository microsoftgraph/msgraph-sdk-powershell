### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.externalCertificateAuthorityCertificate"
	name = "Contoso Enterprise CA"
	commonName = "Contoso Enterprise Root CA"
	organizationName = "Contoso Ltd"
}

New-MgBetaNetworkAccessTlExternalCertificateAuthorityCertificate -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessTlExternalCertificateAuthorityCertificate Cmdlet.

