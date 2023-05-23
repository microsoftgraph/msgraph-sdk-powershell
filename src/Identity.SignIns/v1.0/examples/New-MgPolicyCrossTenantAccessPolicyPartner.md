### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	tenantId = "3d0f5dec-5d3d-455c-8016-e2af1ae4d31a"
	b2bDirectConnectOutbound = @{
		usersAndGroups = @{
			accessType = "blocked"
			targets = @(
				@{
					target = "6f546279-4da5-4b53-a095-09ea0cef9971"
					targetType = "group"
				}
			)
		}
	}
	b2bDirectConnectInbound = @{
		applications = @{
			accessType = "allowed"
			targets = @(
				@{
					target = "Office365"
					targetType = "application"
				}
			)
		}
	}
}

New-MgPolicyCrossTenantAccessPolicyPartner -BodyParameter $params
```
This example shows how to use the New-MgPolicyCrossTenantAccessPolicyPartner Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

