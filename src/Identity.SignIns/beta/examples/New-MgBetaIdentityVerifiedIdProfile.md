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
		type = "verifiedIdentity"
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
	verifiedIdUsageConfigurations = @(
		@{
			isEnabledForTestOnly = $true
			purpose = "recovery"
		}
	)
}

New-MgBetaIdentityVerifiedIdProfile -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityVerifiedIdProfile Cmdlet.

