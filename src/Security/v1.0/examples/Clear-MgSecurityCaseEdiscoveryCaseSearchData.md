### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	purgeType = "recoverable"
	purgeAreas = "teamsMessages"
}

Clear-MgSecurityCaseEdiscoveryCaseSearchData -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params

```
This example shows how to use the Clear-MgSecurityCaseEdiscoveryCaseSearchData Cmdlet.

