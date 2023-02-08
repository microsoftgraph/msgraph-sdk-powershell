### Example 1: Using the Update-MgBetaSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Description = "description-updated"
}
Update-MgBetaSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaSecurityTiIndicator Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	AdditionalInformation = "additionalInformation-after-update"
	Confidence = 42
	Description = "description-after-update"
}
Update-MgBetaSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSecurityTiIndicator Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
