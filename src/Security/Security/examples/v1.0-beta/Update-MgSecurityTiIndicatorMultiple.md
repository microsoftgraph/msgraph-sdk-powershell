### Example 1: Using the Update-MgSecurityTiIndicatorMultiple Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Value = @(
		@{
			Id = "c6fb948b-89c5-3bba-a2cd-a9d9a1e430e4"
			AdditionalInformation = "mytest"
		}
		@{
			Id = "e58c072b-c9bb-a5c4-34ce-eb69af44fb1e"
			AdditionalInformation = "test again"
		}
	)
}
Update-MgSecurityTiIndicatorMultiple -BodyParameter $params
```
This example shows how to use the Update-MgSecurityTiIndicatorMultiple Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
