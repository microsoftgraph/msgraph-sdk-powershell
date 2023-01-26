### Example 1: Get serviceHealth resources

```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview
```
This example shows how to use the New-MgBetaServiceAnnouncementHealthOverview Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Include navigation property issues

```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ExpandProperty "issues"
```
This example shows how to use the New-MgBetaServiceAnnouncementHealthOverview Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

