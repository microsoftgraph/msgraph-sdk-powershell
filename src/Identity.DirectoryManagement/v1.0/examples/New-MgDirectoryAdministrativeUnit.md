### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	displayName = "Seattle District Technical Schools"
	description = "Seattle district technical schools administration"
	visibility = "HiddenMembership"
}

New-MgDirectoryAdministrativeUnit -BodyParameter $params

```
This example shows how to use the New-MgDirectoryAdministrativeUnit Cmdlet.

