### Example 1: Get the properties of a serviceHealth object

```powershellImport-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId
```
This example shows how to use the Get-MgBetaBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Include navigation property issues

```powershellImport-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues"
```
This example shows how to use the Get-MgBetaBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

