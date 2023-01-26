### Example 1: Using the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId
```
This example shows how to use the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
Get-MgBetaServiceAnnouncementHealthOverview -ServiceHealthId $serviceHealthId -ExpandProperty "issues" 
```
This example shows how to use the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
Get-MgBetaServiceAnnouncementHealthOverview
```
This example shows how to use the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement
Get-MgBetaServiceAnnouncementHealthOverview -ExpandProperty "issues" 
```
This example shows how to use the Get-MgBetaServiceAnnouncementHealthOverview Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
