### Example 1: Using the New-MgBetaGroupRejectedSenderByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/users/alexd@contoso.com"
}
New-MgBetaGroupRejectedSenderByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupRejectedSenderByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
