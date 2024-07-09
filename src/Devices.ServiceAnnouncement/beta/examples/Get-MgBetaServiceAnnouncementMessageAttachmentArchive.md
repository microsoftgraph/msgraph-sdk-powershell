### Example 1: Get a zip file of all attachments in stream for a message

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId

```
This example will get a zip file of all attachments in stream for a message

