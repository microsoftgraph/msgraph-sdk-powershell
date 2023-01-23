### Example 1: Using the Update-MgBetaSecurityCaseEdiscoveryCaseSearch Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	DisplayName = "Teams search"
}
Update-MgBetaSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityCaseEdiscoveryCaseSearch Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
