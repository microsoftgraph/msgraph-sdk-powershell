### Example 1: Using the New-MgBetaPolicyCrossTenantAccessPolicyPartner Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	TenantId = "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"
	B2bDirectConnectOutbound = @{
		UsersAndGroups = @{
			AccessType = "blocked"
			Targets = @(
				@{
					Target = "6f546279-4da5-4b53-a095-09ea0cef9971"
					TargetType = "group"
				}
			)
		}
	}
	B2bDirectConnectInbound = @{
		Applications = @{
			AccessType = "allowed"
			Targets = @(
				@{
					Target = "Office365"
					TargetType = "application"
				}
			)
		}
	}
}
New-MgBetaPolicyCrossTenantAccessPolicyPartner -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
