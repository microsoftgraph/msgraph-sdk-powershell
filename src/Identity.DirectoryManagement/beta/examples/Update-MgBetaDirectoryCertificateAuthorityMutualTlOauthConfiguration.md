### Example 1: Update the display name

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "THIS_IS_A_NEW_NAME"
}

Update-MgBetaDirectoryCertificateAuthorityMutualTlOauthConfiguration -MutualTlsOauthConfigurationId $mutualTlsOauthConfigurationId -BodyParameter $params

```
This example will update the display name

### Example 2: Remove a certificate from the list of certificateAuthorities

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	certificateAuthorities = @(
		@{
			isRootAuthority = $true
			certificateRevocationListUrl = "http://LakeshoreRetail.com/root.crl"
			deltaCertificateRevocationListUrl = $null
			certificate = [System.Text.Encoding]::ASCII.GetBytes("Binary")
			issuer = "Lakeshore Retail"
			issuerSubjectkeyIdentifier = "SKI"
		}
	)
}

Update-MgBetaDirectoryCertificateAuthorityMutualTlOauthConfiguration -MutualTlsOauthConfigurationId $mutualTlsOauthConfigurationId -BodyParameter $params

```
This example will remove a certificate from the list of certificateauthorities

