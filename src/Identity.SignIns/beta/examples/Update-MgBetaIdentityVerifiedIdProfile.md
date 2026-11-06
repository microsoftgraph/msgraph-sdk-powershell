### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	verifiedIdProfileConfiguration = @{
		methodType = "tenantCustomCredential"
		manifestUrl = "https://verifiedid.contoso.com/manifest"
	}
	mobileDriversLicenseConfiguration = @{
		acceptedRegions = @(
		"region-code"
	)
	documentStandard = "document-standard"
}
selfServiceIssuance = @{
	isEnabled = $true
	issuanceUrl = "https://verifiedid.contoso.com/issue"
}
verifiedIdUsageConfigurations = @(
	@{
		isEnabledForTestOnly = $false
		purpose = "verification"
	}
)
}

Update-MgBetaIdentityVerifiedIdProfile -VerifiedIdProfileId $verifiedIdProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityVerifiedIdProfile Cmdlet.

