### Example 1: List member objects

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryAdministrativeUnitMember -AdministrativeUnitId $administrativeUnitId
```
This example shows how to use the Get-MgDirectoryAdministrativeUnitMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: List member references

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDirectoryAdministrativeUnitMemberByRef -AdministrativeUnitId $administrativeUnitId
```
This example shows how to use the Get-MgDirectoryAdministrativeUnitMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

