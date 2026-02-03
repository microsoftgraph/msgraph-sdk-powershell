### Example 1: Request without Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	description = "description-updated"
}

Update-MgBetaSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params

```
This example will request without prefer header

### Example 2: Request with Prefer header

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	additionalInformation = "additionalInformation-after-update"
	confidence = 42
	description = "description-after-update"
}

Update-MgBetaSecurityTiIndicator -TiIndicatorId $tiIndicatorId -BodyParameter $params

```
This example will request with prefer header

