# Devices.ServiceAnnouncement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Devices.ServiceAnnouncement v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths.
  - remove-path-by-operation: ^admin(?!\.serviceAnnouncement).*$|^admin.serviceAnnouncement_CreateHealthOverview$|^admin.serviceAnnouncement.healthOverview_CreateIssue$|^admin.serviceAnnouncement_CreateIssue$|^admin.serviceAnnouncement_CreateMessage$|^admin.serviceAnnouncement.message_CreateAttachment$|^admin.serviceAnnouncement_DeleteHealthOverview$|^admin.serviceAnnouncement.healthOverview_DeleteIssue$|^admin.serviceAnnouncement_DeleteIssue$|^admin.serviceAnnouncement_DeleteMessage$|^admin.serviceAnnouncement.message_DeleteAttachment$|^admin.serviceAnnouncement_DeleteMessagesAttachmentsArchive$|^admin.serviceAnnouncement.message_DeleteAttachmentsContent$|^admin.serviceAnnouncement_UpdateHealthOverview$|^admin.serviceAnnouncement.healthOverview_UpdateIssue$|^admin.serviceAnnouncement_UpdateIssue$|^admin.serviceAnnouncement_UpdateMessage$|^admin.serviceAnnouncement.message_UpdateAttachment$|^admin.serviceAnnouncement_SetMessagesAttachmentsArchive$|^admin.serviceAnnouncement.message_SetAttachmentsContent$|

# Drop admin from command names.
  - where:
      subject: (.*)AdminServiceAnnouncement(.*)
    set:
      subject: $1ServiceAnnouncement$2
```
