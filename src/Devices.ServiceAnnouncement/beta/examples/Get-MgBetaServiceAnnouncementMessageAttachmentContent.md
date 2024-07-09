### Example 1: Return a file stream of an attachment content for a message

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementMessageAttachmentContent -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId

```
This example will return a file stream of an attachment content for a message

