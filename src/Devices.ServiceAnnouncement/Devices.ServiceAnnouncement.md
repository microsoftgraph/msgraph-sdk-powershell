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
# Wrapper migration: directive 1 is reviewed against each profile's legacy
# operation IDs and current compatible IDs; their complete selected route sets
# agree after the nine beta final action/function qualifiers are removed.
# The adjacent wrapper/Devices.ServiceAnnouncement_directiveMigrationMap.json
# records 22 suppressions in v1.0 and 31 in beta (including administrativeUnits).
# Shared curated entries extend existing v1.0 derived coverage to beta.
# DevicesServiceAnnouncementDirectiveTests pins the selector and neighboring reads.
# Keep the original AutoRest directive active as the reviewed migration source.
  - remove-path-by-operation: ^admin(?!\.serviceAnnouncement).*$|^admin.serviceAnnouncement_CreateHealthOverview$|^admin.serviceAnnouncement.healthOverview_CreateIssue$|^admin.serviceAnnouncement_CreateIssue$|^admin.serviceAnnouncement_CreateMessage$|^admin.serviceAnnouncement.message_CreateAttachment$|^admin.serviceAnnouncement_DeleteHealthOverview$|^admin.serviceAnnouncement.healthOverview_DeleteIssue$|^admin.serviceAnnouncement_DeleteIssue$|^admin.serviceAnnouncement_DeleteMessage$|^admin.serviceAnnouncement.message_DeleteAttachment$|^admin.serviceAnnouncement_DeleteMessagesAttachmentsArchive$|^admin.serviceAnnouncement.message_DeleteAttachmentsContent$|^admin.serviceAnnouncement_UpdateHealthOverview$|^admin.serviceAnnouncement.healthOverview_UpdateIssue$|^admin.serviceAnnouncement_UpdateIssue$|^admin.serviceAnnouncement_UpdateMessage$|^admin.serviceAnnouncement.message_UpdateAttachment$|^admin.serviceAnnouncement_SetMessagesAttachmentsArchive$|^admin.serviceAnnouncement.message_SetAttachmentsContent$

# Drop admin from command names.
# Wrapper migration: directive 2 strips Admin only within /admin/serviceAnnouncement/.
# Existing v1.0 derived names take precedence; the shared prefix rule covers beta
# and structural naming without duplicating the published per-operation renames.
# The adjacent ledger records the 25 surviving routes in each compatible profile.
# Profile-local readmes and src/readme.graph.md are intentionally not migrated.
# Parameter aliases/transforms and schema/response directives remain deferred;
# neither deferred class occurs in this shared module file.
# Keep the original AutoRest rename active as the reviewed migration source.
  - where:
      subject: (.*)AdminServiceAnnouncement(.*)
    set:
      subject: $1ServiceAnnouncement$2
```
