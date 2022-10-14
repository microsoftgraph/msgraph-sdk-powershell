### Example 1: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId -Property "id,extensionAttributes" 
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "extensionAttributes/extensionAttribute1 eq 'BYOD-Device'" -CountVariable CountVar -ConsistencyLevel eventual 
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Property "id,extensionAttributes" 
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the Get-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName" -ConsistencyLevel eventual 
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
