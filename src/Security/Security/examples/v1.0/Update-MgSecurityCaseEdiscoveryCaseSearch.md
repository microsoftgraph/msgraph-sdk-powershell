### Example 1
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "Teams search"
}
Update-MgSecurityCaseEdiscoveryCaseSearch -EdiscoveryCaseId $ediscoveryCaseId -EdiscoverySearchId $ediscoverySearchId -BodyParameter $params
```
