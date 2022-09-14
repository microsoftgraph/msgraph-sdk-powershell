### Example 1: Using the Get-MgServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId
```
This example shows how to use the Get-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues" 
```
This example shows how to use the Get-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview
```
This example shows how to use the Get-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementHealthOverview -ExpandProperty "issues" 
```
This example shows how to use the Get-MgServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
