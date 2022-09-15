### Example 1: Using the Remove-MgAdministrativeUnitScopedRoleMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Remove-MgAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -ScopedRoleMembershipId $scopedRoleMembershipId
```
This example shows how to use the Remove-MgAdministrativeUnitScopedRoleMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
