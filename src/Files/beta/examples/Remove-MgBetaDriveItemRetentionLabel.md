### Example 1: Remove the retention label from a driveItem

```powershell

Import-Module Microsoft.Graph.Beta.Files

Remove-MgBetaDriveItemRetentionLabel -DriveId $driveId -DriveItemId $driveItemId

```
This example will remove the retention label from a driveitem

### Example 2: Remove the retention label from a driveItem that fails due to insufficient permissions

```powershell

Import-Module Microsoft.Graph.Beta.Files

Remove-MgBetaDriveItemRetentionLabel -DriveId $driveId -DriveItemId $driveItemId

```
This example will remove the retention label from a driveitem that fails due to insufficient permissions

