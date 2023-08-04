### Example 1: Get serviceHealth resources

```powershell

Import-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementHealthOverview

```
This example will get servicehealth resources

### Example 2: Include navigation property issues

```powershell

Import-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementHealthOverview -ExpandProperty "issues" 

```
This example will include navigation property issues

