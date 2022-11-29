### Example 1: Using the Update-MgComplianceEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Compliance
$params = @{
	DisplayName = "My Case 1 - Renamed"
	Description = "Updated description"
	ExternalId = "Updated externalId"
}
Update-MgComplianceEdiscoveryCase -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgComplianceEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
