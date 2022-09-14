### Example 1: Using the New-MgGroupAcceptedSenderByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/users/alexd@contoso.com"
}
New-MgGroupAcceptedSenderByRef -GroupId $groupId -BodyParameter $params
```
This example shows how to use the New-MgGroupAcceptedSenderByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
