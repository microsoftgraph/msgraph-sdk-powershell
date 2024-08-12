### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId

```
This example shows how to use the Get-MgBetaShareDriveItem Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaShareDriveItem -SharedDriveItemId $sharedDriveItemId -ExpandProperty "children" 

```
This example shows how to use the Get-MgBetaShareDriveItem Cmdlet.

