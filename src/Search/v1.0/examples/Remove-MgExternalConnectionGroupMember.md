### Example 1: Using the Remove-MgExternalConnectionGroupMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
Remove-MgExternalConnectionGroupMember -ExternalConnectionId $externalConnectionId -ExternalGroupId $externalGroupId -IdentityId $identityId
```
This example shows how to use the Remove-MgExternalConnectionGroupMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
