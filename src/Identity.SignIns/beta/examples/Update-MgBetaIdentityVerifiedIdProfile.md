### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	verifiedIdUsageConfigurations = @(
		@{
			isEnabledForTestOnly = $false
			purpose = "recovery"
		}
	)
}

Update-MgBetaIdentityVerifiedIdProfile -VerifiedIdProfileId $verifiedIdProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityVerifiedIdProfile Cmdlet.

