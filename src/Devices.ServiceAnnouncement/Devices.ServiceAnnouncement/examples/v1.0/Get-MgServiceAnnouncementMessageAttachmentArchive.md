###Example 1
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId
```
###Example 2
```
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement
Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId -OutFile $outFileId
```
