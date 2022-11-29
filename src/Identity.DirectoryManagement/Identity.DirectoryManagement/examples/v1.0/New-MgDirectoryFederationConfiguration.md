### Example 1: Using the New-MgDirectoryFederationConfiguration Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.type" = "microsoft.graph.samlOrWsFedExternalDomainFederation"
	IssuerUri = "https://contoso.com/issuerUri"
	DisplayName = "contoso display name"
	MetadataExchangeUri = "https://contoso.com/metadataExchangeUri"
	PassiveSignInUri = "https://contoso.com/signin"
	PreferredAuthenticationProtocol = "wsFed"
	Domains = @(
		@{
			"@odata.type" = "microsoft.graph.externalDomainName"
			Id = "contoso.com"
		}
	)
	SigningCertificate = "MIIDADCCAeigAwIBAgIQEX41y8r6"
}
New-MgDirectoryFederationConfiguration -BodyParameter $params
```
This example shows how to use the New-MgDirectoryFederationConfiguration Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
