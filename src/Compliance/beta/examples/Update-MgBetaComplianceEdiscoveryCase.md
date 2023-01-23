### Example 1: Using the Update-MgBetaComplianceEdiscoveryCase Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
$params = @{
	DisplayName = "My Case 1 - Renamed"
	Description = "Updated description"
	ExternalId = "Updated externalId"
}
Update-MgBetaComplianceEdiscoveryCase -CaseId $caseId -BodyParameter $params
```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCase Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
