### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Compliance

$params = @{
	displayName = "My Case 1 - Renamed"
	description = "Updated description"
	externalId = "Updated externalId"
}

Update-MgBetaComplianceEdiscoveryCase -CaseId $caseId -BodyParameter $params

```
This example shows how to use the Update-MgBetaComplianceEdiscoveryCase Cmdlet.

