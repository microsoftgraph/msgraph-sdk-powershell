###Example 1
```
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 
```
###Example 2
```
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId
```
