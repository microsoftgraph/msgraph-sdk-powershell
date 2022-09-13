###Example 1
```
Import-Module Microsoft.Graph.Security
$params = @{
	Email = "AdeleV@contoso.com"
}
New-MgSecurityCaseEdiscoveryCaseCustodian -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
