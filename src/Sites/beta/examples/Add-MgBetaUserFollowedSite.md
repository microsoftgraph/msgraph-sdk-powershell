### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	value = @(
		@{
			id = "contoso.sharepoint.com,da60e844-ba1d-49bc-b4d4-d5e36bae9019,712a596e-90a1-49e3-9b48-bfa80bee8740"
		}
		@{
			id = "contoso.sharepoint.com,da60e844-ba1d-49bc-b4d4-d5e36bae9019,0271110f-634f-4300-a841-3a8a2e851851"
		}
	)
}

Add-MgBetaUserFollowedSite -UserId $userId -BodyParameter $params

```
This example shows how to use the Add-MgBetaUserFollowedSite Cmdlet.

