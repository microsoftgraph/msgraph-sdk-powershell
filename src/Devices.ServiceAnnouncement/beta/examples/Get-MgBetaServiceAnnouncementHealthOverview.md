### Example 1: Get serviceHealth resources

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview

```
This example will get servicehealth resources

### Example 2: Include navigation property issues

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ExpandProperty "issues" 

```
This example will include navigation property issues

