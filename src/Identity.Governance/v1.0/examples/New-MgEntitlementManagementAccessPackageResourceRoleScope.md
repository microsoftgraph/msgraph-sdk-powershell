### Example 1: Add a SharePoint Online site role to an access package

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	role = @{
		displayName = "Contributors"
		originSystem = "SharePointOnline"
		originId = "4"
		resource = @{
			id = "53c71803-a0a8-4777-aecc-075de8ee3991"
		}
	}
	scope = @{
		displayName = "Root"
		description = "Root Scope"
		originId = "https://contoso.sharepoint.com/portals/Community"
		originSystem = "SharePointOnline"
		isRootScope = $true
	}
}

New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId $accessPackageId -BodyParameter $params

```
This example will add a sharepoint online site role to an access package

### Example 2: Add an application role to an access package

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	role = @{
		id = "cde82ecb-e461-496b-98fb-4f807c7ca640"
		displayName = "Standard User"
		description = "Standard User"
		originSystem = "AadApplication"
		originId = "a29a7690-b3c4-4ed5-96c6-f640cde06fb8"
		resource = @{
			id = "5f80c0c7-a180-4521-b585-18200048a0d8"
			originId = "e81d7f57-0840-45e1-894b-f505c1bdcc1f"
			originSystem = "AadApplication"
		}
	}
	scope = @{
		id = "dbeb8772-9907-4e95-a28e-a8d70dbcda69"
		originId = "e81d7f57-0840-45e1-894b-f505c1bdcc1f"
		originSystem = "AadApplication"
		isRootScope = $true
	}
}

New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId $accessPackageId -BodyParameter $params

```
This example will add an application role to an access package

### Example 3: Add group membership to an access package

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	role = @{
		id = "748f8431-c7c6-404d-8564-df67aa8cfc5e"
		displayName = "Member"
		originSystem = "AadGroup"
		originId = "Member_0282e19d-bf41-435d-92a4-99bab93af305"
		resource = @{
			id = "b16e0e71-17b4-4ebd-a3cd-8a468542e418"
			displayName = "example group"
			description = "a group whose members are to be assigned via an access package"
			originId = "0282e19d-bf41-435d-92a4-99bab93af305"
			originSystem = "AadGroup"
		}
	}
	scope = @{
		id = "83b3e3e9-c8b3-481b-ad80-53e29d1eda9c"
		displayName = "Root"
		description = "Root Scope"
		originId = "0282e19d-bf41-435d-92a4-99bab93af305"
		originSystem = "AadGroup"
		isRootScope = $true
	}
}

New-MgEntitlementManagementAccessPackageResourceRoleScope -AccessPackageId $accessPackageId -BodyParameter $params

```
This example will add group membership to an access package

