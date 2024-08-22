### Example 1: Get all attachments of a message in a collection

```powershell

Import-Module Microsoft.Graph.Beta.Devices.ServiceAnnouncement

Get-MgBetaServiceAnnouncementMessageAttachment -ServiceUpdateMessageId $serviceUpdateMessageId

```
This example will get all attachments of a message in a collection

