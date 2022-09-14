### Example 1
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues" 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ExpandProperty "issues" 
```
