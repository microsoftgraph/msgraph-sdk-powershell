### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "DoorCamera_Model_X_TrustedCAs"
	tlsClientAuthParameter = "tls_client_auth_san_uri"
	certificateAuthorities = @(
		@{
			"@odata.type" = "microsoft.graph.certificateAuthority"
		}
	)
}

New-MgBetaDirectoryCertificateAuthorityMutualTlOauthConfiguration -BodyParameter $params

```
This example shows how to use the New-MgBetaDirectoryCertificateAuthorityMutualTlOauthConfiguration Cmdlet.

