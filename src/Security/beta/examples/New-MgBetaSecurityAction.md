### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	name = "BlockIp"
	actionReason = "Test"
	parameters = @(
		@{
			name = "IP"
			value = "1.2.3.4"
		}
	)
	vendorInformation = @{
		provider = "Windows Defender ATP"
		vendor = "Microsoft"
	}
}

New-MgBetaSecurityAction -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityAction Cmdlet.

