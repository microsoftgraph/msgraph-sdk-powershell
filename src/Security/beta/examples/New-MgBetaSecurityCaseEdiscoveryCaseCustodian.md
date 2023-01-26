### Example 1: Using the New-MgBetaSecurityCaseEdiscoveryCaseCustodian Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Email = "AdeleV@contoso.com"
}
New-MgBetaSecurityCaseEdiscoveryCaseCustodian -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityCaseEdiscoveryCaseCustodian Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
