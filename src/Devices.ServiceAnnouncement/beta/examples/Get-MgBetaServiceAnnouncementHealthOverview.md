### Example 1: Get the properties of a serviceHealth object

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId

```
This example will get the properties of a servicehealth object

### Example 2: Include navigation property issues

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues" 

```
This example will include navigation property issues

