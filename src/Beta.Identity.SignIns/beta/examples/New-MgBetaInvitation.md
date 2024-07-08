### Example 1: Invite a guest user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	invitedUserEmailAddress = "admin@fabrikam.com"
	inviteRedirectUrl = "https://myapp.contoso.com"
}

New-MgBetaInvitation -BodyParameter $params

```
This example will invite a guest user

### Example 2: Reset the redemption status of a guest user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	invitedUserEmailAddress = "AdeleV@fabrikam.com"
	inviteRedirectUrl = "https://myapp.contoso.com"
	invitedUser = @{
		id = "264e6d50-eaec-461e-b187-873b1bcf855f"
	}
	resetRedemption = $true
}

New-MgBetaInvitation -BodyParameter $params

```
This example will reset the redemption status of a guest user

