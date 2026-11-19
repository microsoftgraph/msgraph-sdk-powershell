### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	verifiedIdUsageConfigurations = @(
		@{
			isEnabledForTestOnly = $false
			purpose = "recovery"
		}
	)
}

Update-MgIdentityVerifiedIdProfile -VerifiedIdProfileId $verifiedIdProfileId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityVerifiedIdProfile Cmdlet.

