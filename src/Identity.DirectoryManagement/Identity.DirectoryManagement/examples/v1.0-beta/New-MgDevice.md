### Example 1: Using the New-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $true
	AlternativeSecurityIds = @(
		@{
			Type = 99
			IdentityProvider = "identityProvider-value"
			Key = [System.Text.Encoding]::ASCII.GetBytes("base64Y3YxN2E1MWFlYw==")
		}
	)
	ApproximateLastSignInDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	DeviceId = "deviceId-value"
	DeviceMetadata = "deviceMetadata-value"
	DeviceVersion = 99
}
New-MgDevice -BodyParameter $params
```
This example shows how to use the New-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
