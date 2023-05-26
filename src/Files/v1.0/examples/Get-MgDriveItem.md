### Example 2: Get a bundle and its children in a single call

```powershellImport-Module Microsoft.Graph.Files

Get-MgDriveItem -DriveId $driveId -DriveItemId $driveItemId -ExpandProperty "children"
```
This example shows how to use the Get-MgDriveItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 1: {{ Add title here }}
```powershell
 PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
 PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}
