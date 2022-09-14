### Example 1
``` powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId
```
