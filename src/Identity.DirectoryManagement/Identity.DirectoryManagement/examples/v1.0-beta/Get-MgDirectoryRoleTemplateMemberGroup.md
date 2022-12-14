### Example 1: Check group memberships for a directory object

```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects

$params = @{
	SecurityEnabledOnly = $false
}

Get-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```
This example shows how to use the Get-MgBetaDirectoryRoleTemplateMemberGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Check group memberships for the signed-in user

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	SecurityEnabledOnly = $true
}

# A UPN can also be used as -UserId.
Get-MgBetaUserMemberGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaDirectoryRoleTemplateMemberGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

