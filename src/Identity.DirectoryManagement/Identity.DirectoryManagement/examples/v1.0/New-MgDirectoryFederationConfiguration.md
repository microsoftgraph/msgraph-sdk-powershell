###Example 1
```
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
