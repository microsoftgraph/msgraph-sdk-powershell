### Example 1
``` powershell
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Files
Get-MgShareDriveItem -SharedDriveItemId $sharedDriveItemId
```
