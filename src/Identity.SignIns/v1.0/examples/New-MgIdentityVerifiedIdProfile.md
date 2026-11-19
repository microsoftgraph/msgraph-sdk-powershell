### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	name = "Contoso Verified ID"
	description = "Contoso Verified Identity"
	lastModifiedDateTime = $null
	state = "enabled"
	verifierDid = "did:web:eu.did-dev.contoso.io"
	priority = 0
	verifiedIdProfileConfiguration = @{
		type = "verifiedIdentity"
		acceptedIssuer = "did:web:eu.did-dev.contoso.io"
		claimBindingSource = "directory"
		claimBindings = @(
			@{
				matchConfidenceLevel = "exact"
				sourceAttribute = "First name"
				verifiedIdClaim = "vc.credentialSubject.firstName"
			}
			@{
				matchConfidenceLevel = "exact"
				sourceAttribute = "Last name"
				verifiedIdClaim = "vc.credentialSubject.lastName"
			}
		)
		claimValidation = @{
			isEnabled = $true
			customExtensionId = "00aa00aa-bb11-cc22-dd33-44ee44ee44ee"
		}
	}
	faceCheckConfiguration = @{
		isEnabled = $true
		sourcePhotoClaimName = "portrait"
	}
	verifiedIdUsageConfigurations = @(
		@{
			isEnabledForTestOnly = $true
			purpose = "recovery"
		}
	)
}

New-MgIdentityVerifiedIdProfile -BodyParameter $params

```
This example shows how to use the New-MgIdentityVerifiedIdProfile Cmdlet.

