### Example 1: Get an attachment message ID

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
This example shows how to use the Get-MgServiceAnnouncementMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Return a file stream of an attachment content for a message

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachmentContent -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
This example shows how to use the Get-MgServiceAnnouncementMessageAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

