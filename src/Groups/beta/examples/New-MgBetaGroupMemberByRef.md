### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/directoryObjects/{id}"
}

New-MgBetaGroupMemberByRef -GroupId $groupId -BodyParameter $params

```
This example shows how to use the New-MgBetaGroupMemberByRef Cmdlet.

