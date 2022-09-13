###Example 1
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentContent -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
###Example 2
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentContent -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId -OutFile $outFileId
```
