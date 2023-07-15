### Example 1: Get an attachment message ID

```powershell
Import-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
This example shows how to use the Get-MgServiceAnnouncementMessageAttachment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

