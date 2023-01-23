### Example 1: Using the New-MgBetaGroupAcceptedSenderByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/alexd@contoso.com"
}
New-MgBetaGroupAcceptedSenderByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupAcceptedSenderByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
