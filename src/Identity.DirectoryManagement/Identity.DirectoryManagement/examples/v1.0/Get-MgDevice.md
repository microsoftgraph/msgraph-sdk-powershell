### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Search "displayName:Android" -CountVariable CountVar -ConsistencyLevel eventual 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId -Property "id,extensionAttributes" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "extensionAttributes/extensionAttribute1 eq 'BYOD-Device'" -CountVariable CountVar -ConsistencyLevel eventual 
```
### Example 5
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice
```
### Example 6
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Property "id,extensionAttributes" 
```
### Example 7
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName" -ConsistencyLevel eventual 
```
