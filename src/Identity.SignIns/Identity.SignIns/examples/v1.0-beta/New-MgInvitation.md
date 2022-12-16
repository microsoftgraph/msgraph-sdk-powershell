### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	InvitedUserEmailAddress = "admin@fabrikam.com"
	InviteRedirectUrl = "https://myapp.contoso.com"
}

New-MgInvitation -BodyParameter $params
```
This example shows how to use the New-MgInvitation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

