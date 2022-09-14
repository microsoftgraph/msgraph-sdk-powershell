### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId -ScopedRoleMembershipId $scopedRoleMembershipId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDirectoryAdministrativeUnitScopedRoleMember -AdministrativeUnitId $administrativeUnitId
```
