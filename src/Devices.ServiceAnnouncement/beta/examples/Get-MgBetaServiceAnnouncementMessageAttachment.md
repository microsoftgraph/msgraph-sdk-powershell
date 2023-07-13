### Example 1: Get an attachment with message ID

```powershell
Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId -ServiceAnnouncementAttachmentId $serviceAnnouncementAttachmentId
```
This example shows how to use the Get-MgBetaServiceAnnouncementMessageAttachment Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

