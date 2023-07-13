### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Seattle District Technical Schools"
	description = "Seattle district technical schools administration"
	visibility = "HiddenMembership"
}

New-MgBetaDirectoryAdministrativeUnit -BodyParameter $params
```
This example shows how to use the New-MgBetaDirectoryAdministrativeUnit Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

