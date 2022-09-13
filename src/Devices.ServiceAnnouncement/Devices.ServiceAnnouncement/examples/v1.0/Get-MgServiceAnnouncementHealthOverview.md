###Example 1
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId
```
###Example 2
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues" 
```
###Example 3
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview
```
###Example 4
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ExpandProperty "issues" 
```
