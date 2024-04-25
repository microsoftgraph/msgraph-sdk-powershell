### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	displayName = "My Case 1 - Renamed"
	description = "Updated description"
}

Update-MgBetaSecurityCaseEdiscoveryCase -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCase Cmdlet.

