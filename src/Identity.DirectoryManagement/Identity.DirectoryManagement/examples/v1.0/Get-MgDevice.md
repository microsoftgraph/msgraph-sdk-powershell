###Example 1
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Search "displayName:Android" -CountVariable CountVar -ConsistencyLevel eventual 
```
###Example 2
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId
```
###Example 3
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -DeviceId $deviceId -Property "id,extensionAttributes" 
```
###Example 4
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "extensionAttributes/extensionAttribute1 eq 'BYOD-Device'" -CountVariable CountVar -ConsistencyLevel eventual 
```
###Example 5
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice
```
###Example 6
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Property "id,extensionAttributes" 
```
###Example 7
```
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDevice -Filter "startswith(displayName, 'a')" -CountVariable CountVar -Top 1 -Sort "displayName" -ConsistencyLevel eventual 
```
