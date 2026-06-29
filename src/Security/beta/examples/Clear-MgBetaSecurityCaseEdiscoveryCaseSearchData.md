### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	purgeType = "recoverable"
	purgeAreas = "teamsMessages"
}

Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the Clear-MgBetaSecurityCaseEdiscoveryCaseSearchData Cmdlet.

