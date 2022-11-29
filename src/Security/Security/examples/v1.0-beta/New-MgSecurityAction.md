### Example 1: Using the New-MgSecurityAction Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Name = "BlockIp"
	ActionReason = "Test"
	Parameters = @(
		@{
			Name = "IP"
			Value = "1.2.3.4"
		}
	)
	VendorInformation = @{
		Provider = "Windows Defender ATP"
		Vendor = "Microsoft"
	}
}
New-MgSecurityAction -BodyParameter $params
```
This example shows how to use the New-MgSecurityAction Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
