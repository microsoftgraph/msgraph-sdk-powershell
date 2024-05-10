### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId

```
This example shows how to use the Get-MgBetaDriveItemDelta Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId -Token "latest" 

```
This example shows how to use the Get-MgBetaDriveItemDelta Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveItemDelta -DriveId $driveId -DriveItemId $driveItemId -Token "2021-09-29T20:00:00Z" 

```
This example shows how to use the Get-MgBetaDriveItemDelta Cmdlet.

