### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	name = "Contoso Verified ID"
	description = "Contoso Verified Identity"
	lastModifiedDateTime = $null
	state = "enabled"
	verifierDid = "did:web:eu.did-dev.contoso.io"
	priority = 0
	verifiedIdProfileConfiguration = @{
		methodType = "tenantCustomCredential"
		type = "verifiedIdentity"
		manifestUrl = "https://verifiedid.contoso.com/manifest"
		acceptedIssuer = "did:web:eu.did-dev.contoso.io"
		claimBindingSource = "directory"
		claimBindings = @(
			@{
				sourceAttribute = "First name"
				verifiedIdClaim = "vc.credentialSubject.firstName"
			}
			@{
				sourceAttribute = "Last name"
				verifiedIdClaim = "vc.credentialSubject.lastName"
			}
		)
	}
	faceCheckConfiguration = @{
		isEnabled = $true
		sourcePhotoClaimName = "portrait"
	}
	mobileDriversLicenseConfiguration = @{
		acceptedRegions = @(
		"region-code"
	)
	documentStandard = "document-standard"
}
verifiedIdUsageConfigurations = @(
	@{
		isEnabledForTestOnly = $true
		purpose = "verification"
	}
)
selfServiceIssuance = @{
	isEnabled = $true
	issuanceUrl = "https://verifiedid.contoso.com/issue"
}
}

New-MgBetaIdentityVerifiedIdProfile -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityVerifiedIdProfile Cmdlet.

