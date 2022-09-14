### Example 1
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	DisplayName = "My Case 1 - Renamed"
	Description = "Updated description"
}
Update-MgSecurityCaseEdiscoveryCase -EdiscoveryCaseId $ediscoveryCaseId -BodyParameter $params
```
