### Example 1: Using the Update-MgSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Description = "description-updated"
}
Update-MgSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	AdditionalInformation = "additionalInformation-after-update"
	Confidence = 42
	Description = "description-after-update"
}
Update-MgSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params
```
This example shows how to use the Update-MgSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
