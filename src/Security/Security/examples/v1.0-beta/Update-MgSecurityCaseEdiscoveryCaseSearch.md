### Example 1: Using the Update-MgSecurityCaseEdiscoveryCaseSearch Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "Teams search"
}
Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityCaseEdiscoveryCaseSearch Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
