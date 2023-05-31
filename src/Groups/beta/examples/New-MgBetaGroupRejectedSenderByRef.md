### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/alexd@contoso.com"
}

New-MgBetaGroupRejectedSenderByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgBetaGroupRejectedSenderByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

