### Example 1: Using the New-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $false
	AlternativeSecurityIds = @(
		@{
			Type = 2
			Key = [System.Text.Encoding]::ASCII.GetBytes("base64Y3YxN2E1MWFlYw==")
		}
	)
	DeviceId = "4c299165-6e8f-4b45-a5ba-c5d250a707ff"
	DisplayName = "Test device"
	OperatingSystem = "linux"
	OperatingSystemVersion = "1"
}
New-MgDevice -BodyParameter $params
```
This example shows how to use the New-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
