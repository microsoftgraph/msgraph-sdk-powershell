### Example 1: List all bundles in a drive

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveBundle -DriveId $driveId

```
This example will list all bundles in a drive

### Example 2: List all photo albums in a drive

```powershell

Import-Module Microsoft.Graph.Beta.Files

Get-MgBetaDriveBundle -DriveId $driveId -Filter "bundle/album ne null" 

```
This example will list all photo albums in a drive

