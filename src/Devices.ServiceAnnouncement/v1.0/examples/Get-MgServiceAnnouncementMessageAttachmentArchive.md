### Example 1: Get a zip file of all attachments in stream for a message

```powershell

Import-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId

```
This example will get a zip file of all attachments in stream for a message

