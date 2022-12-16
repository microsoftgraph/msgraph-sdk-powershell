### Example 1: Get serviceHealth resources

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementHealthOverview
```
This example shows how to use the New-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Include navigation property issues

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementHealthOverview -ExpandProperty "issues"
```
This example shows how to use the New-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

