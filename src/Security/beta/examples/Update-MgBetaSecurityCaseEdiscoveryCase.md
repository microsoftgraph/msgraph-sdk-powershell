### Example 1: Using the Update-MgBetaSecurityCaseEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	DisplayName = "My Case 1 - Renamed"
	Description = "Updated description"
}
Update-MgBetaSecurityCaseEdiscoveryCase -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
