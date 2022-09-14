### Example 1
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My review set 2"
}
New-MgSecurityCaseEdiscoveryCaseReviewSet -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
