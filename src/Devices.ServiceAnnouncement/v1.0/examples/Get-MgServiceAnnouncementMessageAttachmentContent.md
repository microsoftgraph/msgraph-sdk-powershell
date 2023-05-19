### Example 1: Get all attachments of a message in a collection

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId
```
This example shows how to use the Get-MgServiceAnnouncementMessageAttachmentContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a zip file of all attachments in stream for a message

```powershellImport-Module Microsoft.Graph.Devices.ServiceAnnouncement

Get-MgServiceAnnouncementMessageAttachmentArchive -ServiceUpdateMessageId $serviceUpdateMessageId
```
This example shows how to use the Get-MgServiceAnnouncementMessageAttachmentContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

