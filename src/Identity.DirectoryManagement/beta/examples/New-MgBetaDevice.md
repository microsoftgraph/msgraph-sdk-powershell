### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
	alternativeSecurityIds = @(
		@{
			type = 2
			key = [System.Text.Encoding]::ASCII.GetBytes("base64Y3YxN2E1MWFlYw==")
		}
	)
	deviceId = "4c299165-6e8f-4b45-a5ba-c5d250a707ff"
	displayName = "Test device"
	operatingSystem = "linux"
	operatingSystemVersion = "1"
}

New-MgBetaDevice -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

