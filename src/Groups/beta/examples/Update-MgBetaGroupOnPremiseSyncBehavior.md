### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	"@odata.type" = "#microsoft.graph.onPremisesSyncBehavior"
	isCloudManaged = $true
}

Update-MgBetaGroupOnPremiseSyncBehavior -GroupId $groupId -BodyParameter $params

```
This example shows how to use the Update-MgBetaGroupOnPremiseSyncBehavior Cmdlet.

