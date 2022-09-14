### Example 1
``` powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Email = "AdeleV@contoso.com"
}
New-MgSecurityCaseEdiscoveryCaseCustodian -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
