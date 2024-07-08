### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	value = @(
		@{
			id = "c6fb948b-89c5-3bba-a2cd-a9d9a1e430e4"
			additionalInformation = "mytest"
		}
		@{
			id = "e58c072b-c9bb-a5c4-34ce-eb69af44fb1e"
			additionalInformation = "test again"
		}
	)
}

Update-MgBetaSecurityTiIndicatorMultiple -BodyParameter $params

```
This example shows how to use the Update-MgBetaSecurityTiIndicatorMultiple Cmdlet.

