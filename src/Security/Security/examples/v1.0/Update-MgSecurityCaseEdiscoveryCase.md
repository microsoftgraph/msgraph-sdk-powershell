### Example 1: Using the Update-MgSecurityCaseEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My Case 1 - Renamed"
	Description = "Updated description"
}
Update-MgSecurityCaseEdiscoveryCase -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
