---
Module Name: Microsoft.Graph.Files
Module Guid: 2db6113a-4e22-4052-900b-c7f85ca0c2ec
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.files
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Files Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Files Cmdlets
### [Add-MgDriveListContentTypeCopy](Add-MgDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgDriveListContentTypeCopyFromContentTypeHub](Add-MgDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgShareListContentTypeCopy](Add-MgShareListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgShareListContentTypeCopyFromContentTypeHub](Add-MgShareListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see contentType: getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Copy-MgDriveItem](Copy-MgDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgDriveListContentTypeToDefaultContentLocation](Copy-MgDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgDriveRoot](Copy-MgDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgShareListContentTypeToDefaultContentLocation](Copy-MgShareListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Get-MgDrive](Get-MgDrive.md)
Get entity from drives by key

### [Get-MgDriveBundle](Get-MgDriveBundle.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgDriveBundleContent](Get-MgDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveBundleCount](Get-MgDriveBundleCount.md)
Get the number of the resource

### [Get-MgDriveContentTypeBase](Get-MgDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgDriveContentTypeBaseType](Get-MgDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgDriveContentTypeBaseTypeCount](Get-MgDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgDriveCreatedByUser](Get-MgDriveCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveCreatedByUserMailboxSetting](Get-MgDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveCreatedByUserServiceProvisioningError](Get-MgDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveCreatedByUserServiceProvisioningErrorCount](Get-MgDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveFollowing](Get-MgDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgDriveFollowingContent](Get-MgDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveFollowingCount](Get-MgDriveFollowingCount.md)
Get the number of the resource

### [Get-MgDriveItem](Get-MgDriveItem.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgDriveItemActivityByInterval](Get-MgDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveItemAnalytic](Get-MgDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveItemAnalyticItemActivityStat](Get-MgDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgDriveItemAnalyticItemActivityStatActivity](Get-MgDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgDriveItemAnalyticItemActivityStatCount](Get-MgDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgDriveItemAnalyticLastSevenDay](Get-MgDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgDriveItemAnalyticTime](Get-MgDriveItemAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgDriveItemChild](Get-MgDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgDriveItemChildContent](Get-MgDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemChildCount](Get-MgDriveItemChildCount.md)
Get the number of the resource

### [Get-MgDriveItemContent](Get-MgDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemCount](Get-MgDriveItemCount.md)
Get the number of the resource

### [Get-MgDriveItemCreatedByUser](Get-MgDriveItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveItemCreatedByUserMailboxSetting](Get-MgDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveItemCreatedByUserServiceProvisioningError](Get-MgDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveItemDelta](Get-MgDriveItemDelta.md)
Invoke function delta

### [Get-MgDriveItemItemLastModifiedByUser](Get-MgDriveItemItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgDriveItemItemLastModifiedByUserMailboxSetting](Get-MgDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveItemLastModifiedByUser](Get-MgDriveItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgDriveItemLastModifiedByUserMailboxSetting](Get-MgDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveItemLastModifiedByUserServiceProvisioningError](Get-MgDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveItemListItem](Get-MgDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgDriveItemListItemActivityByInterval](Get-MgDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveItemListItemAnalytic](Get-MgDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveItemListItemCreatedByUser](Get-MgDriveItemListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveItemListItemCreatedByUserMailboxSetting](Get-MgDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveItemListItemDocumentSetVersion](Get-MgDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgDriveItemListItemDocumentSetVersionCount](Get-MgDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgDriveItemListItemDocumentSetVersionField](Get-MgDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveItemListItemDriveItem](Get-MgDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveItemListItemDriveItemContent](Get-MgDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemListItemField](Get-MgDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveItemListItemVersion](Get-MgDriveItemListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgDriveItemListItemVersionCount](Get-MgDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgDriveItemListItemVersionField](Get-MgDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveItemPermission](Get-MgDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgDriveItemPermissionCount](Get-MgDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgDriveItemRetentionLabel](Get-MgDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgDriveItemSubscription](Get-MgDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgDriveItemSubscriptionCount](Get-MgDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgDriveItemThumbnail](Get-MgDriveItemThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgDriveItemThumbnailCount](Get-MgDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgDriveItemVersion](Get-MgDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgDriveItemVersionContent](Get-MgDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgDriveItemVersionCount](Get-MgDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgDriveLastModifiedByUser](Get-MgDriveLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgDriveLastModifiedByUserMailboxSetting](Get-MgDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveLastModifiedByUserServiceProvisioningError](Get-MgDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveList](Get-MgDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgDriveListColumn](Get-MgDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgDriveListColumnCount](Get-MgDriveListColumnCount.md)
Get the number of the resource

### [Get-MgDriveListColumnSourceColumn](Get-MgDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgDriveListContentType](Get-MgDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgDriveListContentTypeColumn](Get-MgDriveListContentTypeColumn.md)
Retrieve the metadata for a [site][], a [list][], or a [contentType][] [column][columnDefinition].

### [Get-MgDriveListContentTypeColumnCount](Get-MgDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgDriveListContentTypeColumnLink](Get-MgDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgDriveListContentTypeColumnLinkCount](Get-MgDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgDriveListContentTypeColumnPosition](Get-MgDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgDriveListContentTypeColumnPositionCount](Get-MgDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgDriveListContentTypeColumnSourceColumn](Get-MgDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgDriveListContentTypeCompatibleHubContentType](Get-MgDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgDriveListContentTypeCount](Get-MgDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgDriveListCreatedByUser](Get-MgDriveListCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveListCreatedByUserMailboxSetting](Get-MgDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveListCreatedByUserServiceProvisioningError](Get-MgDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveListDrive](Get-MgDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgDriveListItem](Get-MgDriveListItem.md)
Returns the metadata for an [item][] in a [list][].

### [Get-MgDriveListItemActivityByInterval](Get-MgDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveListItemAnalytic](Get-MgDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveListItemCount](Get-MgDriveListItemCount.md)
Get the number of the resource

### [Get-MgDriveListItemCreatedByUser](Get-MgDriveListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveListItemCreatedByUserMailboxSetting](Get-MgDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveListItemCreatedByUserServiceProvisioningError](Get-MgDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveListItemDocumentSetVersion](Get-MgDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgDriveListItemDocumentSetVersionCount](Get-MgDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgDriveListItemDocumentSetVersionField](Get-MgDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveListItemDriveItem](Get-MgDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveListItemDriveItemContent](Get-MgDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveListItemField](Get-MgDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveListItemVersion](Get-MgDriveListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgDriveListItemVersionCount](Get-MgDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgDriveListItemVersionField](Get-MgDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveListOperation](Get-MgDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgDriveListOperationCount](Get-MgDriveListOperationCount.md)
Get the number of the resource

### [Get-MgDriveListSubscription](Get-MgDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgDriveListSubscriptionCount](Get-MgDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgDriveRoot](Get-MgDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.\nitem-id is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgDriveRootActivityByInterval](Get-MgDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveRootAnalytic](Get-MgDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveRootAnalyticItemActivityStat](Get-MgDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgDriveRootAnalyticItemActivityStatActivity](Get-MgDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgDriveRootAnalyticItemActivityStatCount](Get-MgDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgDriveRootAnalyticLastSevenDay](Get-MgDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgDriveRootAnalyticTime](Get-MgDriveRootAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgDriveRootChild](Get-MgDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgDriveRootChildContent](Get-MgDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootChildCount](Get-MgDriveRootChildCount.md)
Get the number of the resource

### [Get-MgDriveRootContent](Get-MgDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootCreatedByUser](Get-MgDriveRootCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveRootCreatedByUserMailboxSetting](Get-MgDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveRootCreatedByUserServiceProvisioningError](Get-MgDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveRootDelta](Get-MgDriveRootDelta.md)
Invoke function delta

### [Get-MgDriveRootItemLastModifiedByUser](Get-MgDriveRootItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgDriveRootItemLastModifiedByUserMailboxSetting](Get-MgDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveRootLastModifiedByUser](Get-MgDriveRootLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgDriveRootLastModifiedByUserMailboxSetting](Get-MgDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveRootLastModifiedByUserServiceProvisioningError](Get-MgDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveRootListItem](Get-MgDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgDriveRootListItemActivityByInterval](Get-MgDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveRootListItemAnalytic](Get-MgDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveRootListItemCreatedByUser](Get-MgDriveRootListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgDriveRootListItemCreatedByUserMailboxSetting](Get-MgDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgDriveRootListItemDocumentSetVersion](Get-MgDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgDriveRootListItemDocumentSetVersionCount](Get-MgDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgDriveRootListItemDocumentSetVersionField](Get-MgDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveRootListItemDriveItem](Get-MgDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveRootListItemDriveItemContent](Get-MgDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootListItemField](Get-MgDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveRootListItemVersion](Get-MgDriveRootListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgDriveRootListItemVersionCount](Get-MgDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgDriveRootListItemVersionField](Get-MgDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveRootPermission](Get-MgDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgDriveRootPermissionCount](Get-MgDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgDriveRootRetentionLabel](Get-MgDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgDriveRootSubscription](Get-MgDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgDriveRootSubscriptionCount](Get-MgDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgDriveRootThumbnail](Get-MgDriveRootThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgDriveRootThumbnailCount](Get-MgDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgDriveRootVersion](Get-MgDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgDriveRootVersionContent](Get-MgDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgDriveRootVersionCount](Get-MgDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgDriveSpecial](Get-MgDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.

### [Get-MgDriveSpecialContent](Get-MgDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveSpecialCount](Get-MgDriveSpecialCount.md)
Get the number of the resource

### [Get-MgGroupDefaultDrive](Get-MgGroupDefaultDrive.md)
The group's default drive.
Read-only.

### [Get-MgGroupDrive](Get-MgGroupDrive.md)
The group's drives.
Read-only.

### [Get-MgGroupDriveBundle](Get-MgGroupDriveBundle.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgGroupDriveBundleContent](Get-MgGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveBundleCount](Get-MgGroupDriveBundleCount.md)
Get the number of the resource

### [Get-MgGroupDriveContentTypeBase](Get-MgGroupDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgGroupDriveContentTypeBaseType](Get-MgGroupDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgGroupDriveContentTypeBaseTypeCount](Get-MgGroupDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgGroupDriveCount](Get-MgGroupDriveCount.md)
Get the number of the resource

### [Get-MgGroupDriveCreatedByUser](Get-MgGroupDriveCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveCreatedByUserMailboxSetting](Get-MgGroupDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveCreatedByUserServiceProvisioningError](Get-MgGroupDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveFollowing](Get-MgGroupDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgGroupDriveFollowingContent](Get-MgGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveFollowingCount](Get-MgGroupDriveFollowingCount.md)
Get the number of the resource

### [Get-MgGroupDriveItem](Get-MgGroupDriveItem.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgGroupDriveItemAnalytic](Get-MgGroupDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveItemAnalyticItemActivityStat](Get-MgGroupDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgGroupDriveItemAnalyticItemActivityStatActivity](Get-MgGroupDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgGroupDriveItemAnalyticItemActivityStatCount](Get-MgGroupDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemAnalyticLastSevenDay](Get-MgGroupDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgGroupDriveItemAnalyticTime](Get-MgGroupDriveItemAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgGroupDriveItemChild](Get-MgGroupDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgGroupDriveItemChildContent](Get-MgGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemChildCount](Get-MgGroupDriveItemChildCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemContent](Get-MgGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemCount](Get-MgGroupDriveItemCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemCreatedByUser](Get-MgGroupDriveItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveItemCreatedByUserMailboxSetting](Get-MgGroupDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveItemCreatedByUserServiceProvisioningError](Get-MgGroupDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemItemLastModifiedByUser](Get-MgGroupDriveItemItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgGroupDriveItemItemLastModifiedByUserMailboxSetting](Get-MgGroupDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgGroupDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgGroupDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemLastModifiedByUser](Get-MgGroupDriveItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgGroupDriveItemLastModifiedByUserMailboxSetting](Get-MgGroupDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveItemLastModifiedByUserServiceProvisioningError](Get-MgGroupDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgGroupDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemListItem](Get-MgGroupDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgGroupDriveItemListItemAnalytic](Get-MgGroupDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveItemListItemCreatedByUser](Get-MgGroupDriveItemListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveItemListItemCreatedByUserMailboxSetting](Get-MgGroupDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgGroupDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemListItemDocumentSetVersion](Get-MgGroupDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgGroupDriveItemListItemDocumentSetVersionCount](Get-MgGroupDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemListItemDocumentSetVersionField](Get-MgGroupDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveItemListItemDriveItem](Get-MgGroupDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveItemListItemDriveItemContent](Get-MgGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemListItemField](Get-MgGroupDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveItemListItemVersion](Get-MgGroupDriveItemListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgGroupDriveItemListItemVersionCount](Get-MgGroupDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemListItemVersionField](Get-MgGroupDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveItemPermission](Get-MgGroupDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgGroupDriveItemPermissionCount](Get-MgGroupDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemRetentionLabel](Get-MgGroupDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgGroupDriveItemSubscription](Get-MgGroupDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgGroupDriveItemSubscriptionCount](Get-MgGroupDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemThumbnail](Get-MgGroupDriveItemThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgGroupDriveItemThumbnailCount](Get-MgGroupDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgGroupDriveItemVersion](Get-MgGroupDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgGroupDriveItemVersionContent](Get-MgGroupDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgGroupDriveItemVersionCount](Get-MgGroupDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveLastModifiedByUser](Get-MgGroupDriveLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgGroupDriveLastModifiedByUserMailboxSetting](Get-MgGroupDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveLastModifiedByUserServiceProvisioningError](Get-MgGroupDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgGroupDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveList](Get-MgGroupDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgGroupDriveListColumn](Get-MgGroupDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgGroupDriveListColumnCount](Get-MgGroupDriveListColumnCount.md)
Get the number of the resource

### [Get-MgGroupDriveListColumnSourceColumn](Get-MgGroupDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgGroupDriveListContentType](Get-MgGroupDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgGroupDriveListContentTypeColumn](Get-MgGroupDriveListContentTypeColumn.md)
Retrieve the metadata for a [site][], a [list][], or a [contentType][] [column][columnDefinition].

### [Get-MgGroupDriveListContentTypeColumnCount](Get-MgGroupDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgGroupDriveListContentTypeColumnLink](Get-MgGroupDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgGroupDriveListContentTypeColumnLinkCount](Get-MgGroupDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgGroupDriveListContentTypeColumnPosition](Get-MgGroupDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgGroupDriveListContentTypeColumnPositionCount](Get-MgGroupDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgGroupDriveListContentTypeColumnSourceColumn](Get-MgGroupDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgGroupDriveListContentTypeCount](Get-MgGroupDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgGroupDriveListCreatedByUser](Get-MgGroupDriveListCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveListCreatedByUserMailboxSetting](Get-MgGroupDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveListCreatedByUserServiceProvisioningError](Get-MgGroupDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveListDrive](Get-MgGroupDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgGroupDriveListItem](Get-MgGroupDriveListItem.md)
Returns the metadata for an [item][] in a [list][].

### [Get-MgGroupDriveListItemAnalytic](Get-MgGroupDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveListItemCreatedByUser](Get-MgGroupDriveListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveListItemCreatedByUserMailboxSetting](Get-MgGroupDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveListItemCreatedByUserServiceProvisioningError](Get-MgGroupDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveListItemDocumentSetVersion](Get-MgGroupDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgGroupDriveListItemDocumentSetVersionCount](Get-MgGroupDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveListItemDocumentSetVersionField](Get-MgGroupDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveListItemDriveItem](Get-MgGroupDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveListItemDriveItemContent](Get-MgGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveListItemField](Get-MgGroupDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveListItemVersion](Get-MgGroupDriveListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgGroupDriveListItemVersionCount](Get-MgGroupDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveListItemVersionField](Get-MgGroupDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveListOperation](Get-MgGroupDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgGroupDriveListOperationCount](Get-MgGroupDriveListOperationCount.md)
Get the number of the resource

### [Get-MgGroupDriveListSubscription](Get-MgGroupDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgGroupDriveListSubscriptionCount](Get-MgGroupDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgGroupDriveRoot](Get-MgGroupDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.\nitem-id is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgGroupDriveRootAnalytic](Get-MgGroupDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveRootAnalyticItemActivityStat](Get-MgGroupDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgGroupDriveRootAnalyticItemActivityStatActivity](Get-MgGroupDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgGroupDriveRootAnalyticItemActivityStatCount](Get-MgGroupDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootAnalyticLastSevenDay](Get-MgGroupDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgGroupDriveRootAnalyticTime](Get-MgGroupDriveRootAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgGroupDriveRootChild](Get-MgGroupDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgGroupDriveRootChildContent](Get-MgGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootChildCount](Get-MgGroupDriveRootChildCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootContent](Get-MgGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootCreatedByUser](Get-MgGroupDriveRootCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveRootCreatedByUserMailboxSetting](Get-MgGroupDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveRootCreatedByUserServiceProvisioningError](Get-MgGroupDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootItemLastModifiedByUser](Get-MgGroupDriveRootItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgGroupDriveRootItemLastModifiedByUserMailboxSetting](Get-MgGroupDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgGroupDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgGroupDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootLastModifiedByUser](Get-MgGroupDriveRootLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgGroupDriveRootLastModifiedByUserMailboxSetting](Get-MgGroupDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveRootLastModifiedByUserServiceProvisioningError](Get-MgGroupDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgGroupDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootListItem](Get-MgGroupDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgGroupDriveRootListItemAnalytic](Get-MgGroupDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveRootListItemCreatedByUser](Get-MgGroupDriveRootListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgGroupDriveRootListItemCreatedByUserMailboxSetting](Get-MgGroupDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgGroupDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgGroupDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgGroupDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgGroupDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootListItemDocumentSetVersion](Get-MgGroupDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgGroupDriveRootListItemDocumentSetVersionCount](Get-MgGroupDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootListItemDocumentSetVersionField](Get-MgGroupDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveRootListItemDriveItem](Get-MgGroupDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveRootListItemDriveItemContent](Get-MgGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootListItemField](Get-MgGroupDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveRootListItemVersion](Get-MgGroupDriveRootListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgGroupDriveRootListItemVersionCount](Get-MgGroupDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootListItemVersionField](Get-MgGroupDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveRootPermission](Get-MgGroupDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgGroupDriveRootPermissionCount](Get-MgGroupDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootRetentionLabel](Get-MgGroupDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgGroupDriveRootSubscription](Get-MgGroupDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgGroupDriveRootSubscriptionCount](Get-MgGroupDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootThumbnail](Get-MgGroupDriveRootThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgGroupDriveRootThumbnailCount](Get-MgGroupDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgGroupDriveRootVersion](Get-MgGroupDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgGroupDriveRootVersionContent](Get-MgGroupDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgGroupDriveRootVersionCount](Get-MgGroupDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgGroupDriveSpecial](Get-MgGroupDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.

### [Get-MgGroupDriveSpecialContent](Get-MgGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveSpecialCount](Get-MgGroupDriveSpecialCount.md)
Get the number of the resource

### [Get-MgShareContentTypeBase](Get-MgShareContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgShareContentTypeBaseType](Get-MgShareContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgShareContentTypeBaseTypeCount](Get-MgShareContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgShareCount](Get-MgShareCount.md)
Get the number of the resource

### [Get-MgShareCreatedByUser](Get-MgShareCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgShareCreatedByUserMailboxSetting](Get-MgShareCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgShareCreatedByUserServiceProvisioningError](Get-MgShareCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgShareCreatedByUserServiceProvisioningErrorCount](Get-MgShareCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgShareDriveItem](Get-MgShareDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a shareId or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

### [Get-MgShareDriveItemContent](Get-MgShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareItem](Get-MgShareItem.md)
All driveItems contained in the sharing root.
This collection cannot be enumerated.

### [Get-MgShareItemContent](Get-MgShareItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareItemCount](Get-MgShareItemCount.md)
Get the number of the resource

### [Get-MgShareItemLastModifiedByUser](Get-MgShareItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgShareItemLastModifiedByUserMailboxSetting](Get-MgShareItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgShareItemLastModifiedByUserServiceProvisioningError](Get-MgShareItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgShareItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgShareItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgShareLastModifiedByUser](Get-MgShareLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgShareLastModifiedByUserMailboxSetting](Get-MgShareLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgShareLastModifiedByUserServiceProvisioningError](Get-MgShareLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgShareLastModifiedByUserServiceProvisioningErrorCount](Get-MgShareLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgShareList](Get-MgShareList.md)
Used to access the underlying list

### [Get-MgShareListColumn](Get-MgShareListColumn.md)
The collection of field definitions for this list.

### [Get-MgShareListColumnCount](Get-MgShareListColumnCount.md)
Get the number of the resource

### [Get-MgShareListColumnSourceColumn](Get-MgShareListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgShareListContentType](Get-MgShareListContentType.md)
The collection of content types present in this list.

### [Get-MgShareListContentTypeColumn](Get-MgShareListContentTypeColumn.md)
Retrieve the metadata for a [site][], a [list][], or a [contentType][] [column][columnDefinition].

### [Get-MgShareListContentTypeColumnCount](Get-MgShareListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgShareListContentTypeColumnLink](Get-MgShareListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgShareListContentTypeColumnLinkCount](Get-MgShareListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgShareListContentTypeColumnPosition](Get-MgShareListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgShareListContentTypeColumnPositionCount](Get-MgShareListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgShareListContentTypeColumnSourceColumn](Get-MgShareListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgShareListContentTypeCompatibleHubContentType](Get-MgShareListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgShareListContentTypeCount](Get-MgShareListContentTypeCount.md)
Get the number of the resource

### [Get-MgShareListCreatedByUser](Get-MgShareListCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgShareListCreatedByUserMailboxSetting](Get-MgShareListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgShareListCreatedByUserServiceProvisioningError](Get-MgShareListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgShareListCreatedByUserServiceProvisioningErrorCount](Get-MgShareListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgShareListDrive](Get-MgShareListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgShareListItem](Get-MgShareListItem.md)
Used to access the underlying listItem

### [Get-MgShareListItemActivityByInterval](Get-MgShareListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgShareListItemAnalytic](Get-MgShareListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgShareListItemCreatedByUser](Get-MgShareListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgShareListItemCreatedByUserMailboxSetting](Get-MgShareListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgShareListItemCreatedByUserServiceProvisioningError](Get-MgShareListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgShareListItemCreatedByUserServiceProvisioningErrorCount](Get-MgShareListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgShareListItemDocumentSetVersion](Get-MgShareListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgShareListItemDocumentSetVersionCount](Get-MgShareListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgShareListItemDocumentSetVersionField](Get-MgShareListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgShareListItemDriveItem](Get-MgShareListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgShareListItemDriveItemContent](Get-MgShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareListItemField](Get-MgShareListItemField.md)
The values of the columns set on this list item.

### [Get-MgShareListItemVersion](Get-MgShareListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgShareListItemVersionCount](Get-MgShareListItemVersionCount.md)
Get the number of the resource

### [Get-MgShareListItemVersionField](Get-MgShareListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgShareListOperation](Get-MgShareListOperation.md)
The collection of long-running operations on the list.

### [Get-MgShareListOperationCount](Get-MgShareListOperationCount.md)
Get the number of the resource

### [Get-MgShareListSubscription](Get-MgShareListSubscription.md)
The set of subscriptions on the list.

### [Get-MgShareListSubscriptionCount](Get-MgShareListSubscriptionCount.md)
Get the number of the resource

### [Get-MgSharePermission](Get-MgSharePermission.md)
Used to access the permission representing the underlying sharing link

### [Get-MgShareRoot](Get-MgShareRoot.md)
Used to access the underlying driveItem.
Deprecated -- use driveItem instead.

### [Get-MgShareRootContent](Get-MgShareRootContent.md)
The content stream, if the item represents a file.

### [Get-MgShareSharedDriveItemSharedDriveItem](Get-MgShareSharedDriveItemSharedDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a shareId or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

### [Get-MgShareSite](Get-MgShareSite.md)
Used to access the underlying site

### [Get-MgUserDefaultDrive](Get-MgUserDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgUserDrive](Get-MgUserDrive.md)
A collection of drives available for this user.
Read-only.

### [Get-MgUserDriveBundle](Get-MgUserDriveBundle.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgUserDriveBundleContent](Get-MgUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveBundleCount](Get-MgUserDriveBundleCount.md)
Get the number of the resource

### [Get-MgUserDriveContentTypeBase](Get-MgUserDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgUserDriveContentTypeBaseType](Get-MgUserDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgUserDriveContentTypeBaseTypeCount](Get-MgUserDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgUserDriveCount](Get-MgUserDriveCount.md)
Get the number of the resource

### [Get-MgUserDriveCreatedByUser](Get-MgUserDriveCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveCreatedByUserMailboxSetting](Get-MgUserDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveCreatedByUserServiceProvisioningError](Get-MgUserDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveFollowing](Get-MgUserDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgUserDriveFollowingContent](Get-MgUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveFollowingCount](Get-MgUserDriveFollowingCount.md)
Get the number of the resource

### [Get-MgUserDriveItem](Get-MgUserDriveItem.md)
Retrieve the metadata for a [bundle][] based on the unique ID of the bundle.

### [Get-MgUserDriveItemAnalytic](Get-MgUserDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveItemAnalyticItemActivityStat](Get-MgUserDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgUserDriveItemAnalyticItemActivityStatActivity](Get-MgUserDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgUserDriveItemAnalyticItemActivityStatCount](Get-MgUserDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgUserDriveItemAnalyticLastSevenDay](Get-MgUserDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgUserDriveItemAnalyticTime](Get-MgUserDriveItemAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgUserDriveItemChild](Get-MgUserDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgUserDriveItemChildContent](Get-MgUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemChildCount](Get-MgUserDriveItemChildCount.md)
Get the number of the resource

### [Get-MgUserDriveItemContent](Get-MgUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemCount](Get-MgUserDriveItemCount.md)
Get the number of the resource

### [Get-MgUserDriveItemCreatedByUser](Get-MgUserDriveItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveItemCreatedByUserMailboxSetting](Get-MgUserDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveItemCreatedByUserServiceProvisioningError](Get-MgUserDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveItemItemLastModifiedByUser](Get-MgUserDriveItemItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgUserDriveItemItemLastModifiedByUserMailboxSetting](Get-MgUserDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgUserDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgUserDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveItemLastModifiedByUser](Get-MgUserDriveItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgUserDriveItemLastModifiedByUserMailboxSetting](Get-MgUserDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveItemLastModifiedByUserServiceProvisioningError](Get-MgUserDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgUserDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveItemListItem](Get-MgUserDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgUserDriveItemListItemAnalytic](Get-MgUserDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveItemListItemCreatedByUser](Get-MgUserDriveItemListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveItemListItemCreatedByUserMailboxSetting](Get-MgUserDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgUserDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveItemListItemDocumentSetVersion](Get-MgUserDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgUserDriveItemListItemDocumentSetVersionCount](Get-MgUserDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveItemListItemDocumentSetVersionField](Get-MgUserDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveItemListItemDriveItem](Get-MgUserDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveItemListItemDriveItemContent](Get-MgUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemListItemField](Get-MgUserDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveItemListItemVersion](Get-MgUserDriveItemListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgUserDriveItemListItemVersionCount](Get-MgUserDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveItemListItemVersionField](Get-MgUserDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveItemPermission](Get-MgUserDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgUserDriveItemPermissionCount](Get-MgUserDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgUserDriveItemRetentionLabel](Get-MgUserDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgUserDriveItemSubscription](Get-MgUserDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgUserDriveItemSubscriptionCount](Get-MgUserDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgUserDriveItemThumbnail](Get-MgUserDriveItemThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgUserDriveItemThumbnailCount](Get-MgUserDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgUserDriveItemVersion](Get-MgUserDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgUserDriveItemVersionContent](Get-MgUserDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgUserDriveItemVersionCount](Get-MgUserDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveLastModifiedByUser](Get-MgUserDriveLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgUserDriveLastModifiedByUserMailboxSetting](Get-MgUserDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveLastModifiedByUserServiceProvisioningError](Get-MgUserDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgUserDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveList](Get-MgUserDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgUserDriveListColumn](Get-MgUserDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgUserDriveListColumnCount](Get-MgUserDriveListColumnCount.md)
Get the number of the resource

### [Get-MgUserDriveListColumnSourceColumn](Get-MgUserDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgUserDriveListContentType](Get-MgUserDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgUserDriveListContentTypeColumn](Get-MgUserDriveListContentTypeColumn.md)
Retrieve the metadata for a [site][], a [list][], or a [contentType][] [column][columnDefinition].

### [Get-MgUserDriveListContentTypeColumnCount](Get-MgUserDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgUserDriveListContentTypeColumnLink](Get-MgUserDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgUserDriveListContentTypeColumnLinkCount](Get-MgUserDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgUserDriveListContentTypeColumnPosition](Get-MgUserDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgUserDriveListContentTypeColumnPositionCount](Get-MgUserDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgUserDriveListContentTypeColumnSourceColumn](Get-MgUserDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgUserDriveListContentTypeCount](Get-MgUserDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgUserDriveListCreatedByUser](Get-MgUserDriveListCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveListCreatedByUserMailboxSetting](Get-MgUserDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveListCreatedByUserServiceProvisioningError](Get-MgUserDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveListDrive](Get-MgUserDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgUserDriveListItem](Get-MgUserDriveListItem.md)
Returns the metadata for an [item][] in a [list][].

### [Get-MgUserDriveListItemAnalytic](Get-MgUserDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveListItemCreatedByUser](Get-MgUserDriveListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveListItemCreatedByUserMailboxSetting](Get-MgUserDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveListItemCreatedByUserServiceProvisioningError](Get-MgUserDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveListItemDocumentSetVersion](Get-MgUserDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgUserDriveListItemDocumentSetVersionCount](Get-MgUserDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveListItemDocumentSetVersionField](Get-MgUserDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveListItemDriveItem](Get-MgUserDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveListItemDriveItemContent](Get-MgUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveListItemField](Get-MgUserDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveListItemVersion](Get-MgUserDriveListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgUserDriveListItemVersionCount](Get-MgUserDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveListItemVersionField](Get-MgUserDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveListOperation](Get-MgUserDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgUserDriveListOperationCount](Get-MgUserDriveListOperationCount.md)
Get the number of the resource

### [Get-MgUserDriveListSubscription](Get-MgUserDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgUserDriveListSubscriptionCount](Get-MgUserDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgUserDriveRoot](Get-MgUserDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.\nitem-id is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgUserDriveRootAnalytic](Get-MgUserDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveRootAnalyticItemActivityStat](Get-MgUserDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgUserDriveRootAnalyticItemActivityStatActivity](Get-MgUserDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgUserDriveRootAnalyticItemActivityStatCount](Get-MgUserDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgUserDriveRootAnalyticLastSevenDay](Get-MgUserDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgUserDriveRootAnalyticTime](Get-MgUserDriveRootAnalyticTime.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgUserDriveRootChild](Get-MgUserDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgUserDriveRootChildContent](Get-MgUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootChildCount](Get-MgUserDriveRootChildCount.md)
Get the number of the resource

### [Get-MgUserDriveRootContent](Get-MgUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootCreatedByUser](Get-MgUserDriveRootCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveRootCreatedByUserMailboxSetting](Get-MgUserDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveRootCreatedByUserServiceProvisioningError](Get-MgUserDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveRootItemLastModifiedByUser](Get-MgUserDriveRootItemLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgUserDriveRootItemLastModifiedByUserMailboxSetting](Get-MgUserDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgUserDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgUserDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveRootLastModifiedByUser](Get-MgUserDriveRootLastModifiedByUser.md)
Identity of the user who last modified the item.
Read-only.

### [Get-MgUserDriveRootLastModifiedByUserMailboxSetting](Get-MgUserDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveRootLastModifiedByUserServiceProvisioningError](Get-MgUserDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgUserDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveRootListItem](Get-MgUserDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgUserDriveRootListItemAnalytic](Get-MgUserDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveRootListItemCreatedByUser](Get-MgUserDriveRootListItemCreatedByUser.md)
Identity of the user who created the item.
Read-only.

### [Get-MgUserDriveRootListItemCreatedByUserMailboxSetting](Get-MgUserDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
Returned only on $select.

### [Get-MgUserDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgUserDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from a user object .
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgUserDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgUserDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgUserDriveRootListItemDocumentSetVersion](Get-MgUserDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.

### [Get-MgUserDriveRootListItemDocumentSetVersionCount](Get-MgUserDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveRootListItemDocumentSetVersionField](Get-MgUserDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveRootListItemDriveItem](Get-MgUserDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveRootListItemDriveItemContent](Get-MgUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootListItemField](Get-MgUserDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveRootListItemVersion](Get-MgUserDriveRootListItemVersion.md)
Retrieve the metadata for a specific version of a ListItem.

### [Get-MgUserDriveRootListItemVersionCount](Get-MgUserDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveRootListItemVersionField](Get-MgUserDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveRootPermission](Get-MgUserDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.

### [Get-MgUserDriveRootPermissionCount](Get-MgUserDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgUserDriveRootRetentionLabel](Get-MgUserDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgUserDriveRootSubscription](Get-MgUserDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgUserDriveRootSubscriptionCount](Get-MgUserDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgUserDriveRootThumbnail](Get-MgUserDriveRootThumbnail.md)
Collection of [thumbnailSet][] objects associated with the item.
For more information, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgUserDriveRootThumbnailCount](Get-MgUserDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgUserDriveRootVersion](Get-MgUserDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.

### [Get-MgUserDriveRootVersionContent](Get-MgUserDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgUserDriveRootVersionCount](Get-MgUserDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgUserDriveSpecial](Get-MgUserDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.

### [Get-MgUserDriveSpecialContent](Get-MgUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveSpecialCount](Get-MgUserDriveSpecialCount.md)
Get the number of the resource

### [Grant-MgDriveItemPermission](Grant-MgDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgDriveRootPermission](Grant-MgDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgSharePermission](Grant-MgSharePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgCheckinDriveItem](Invoke-MgCheckinDriveItem.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.

### [Invoke-MgCheckinDriveRoot](Invoke-MgCheckinDriveRoot.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.

### [Invoke-MgCheckoutDriveItem](Invoke-MgCheckoutDriveItem.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCheckoutDriveRoot](Invoke-MgCheckoutDriveRoot.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgExtractDriveItemSensitivityLabel](Invoke-MgExtractDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgExtractDriveRootSensitivityLabel](Invoke-MgExtractDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgFollowDriveItem](Invoke-MgFollowDriveItem.md)
Follow a driveItem.

### [Invoke-MgFollowDriveRoot](Invoke-MgFollowDriveRoot.md)
Follow a driveItem.

### [Invoke-MgGraphDrive](Invoke-MgGraphDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteDriveItem](Invoke-MgInviteDriveItem.md)
Sends a sharing invitation for a driveItem.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgInviteDriveRoot](Invoke-MgInviteDriveRoot.md)
Sends a sharing invitation for a driveItem.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgPreviewDriveItem](Invoke-MgPreviewDriveItem.md)
Invoke action preview

### [Invoke-MgPreviewDriveRoot](Invoke-MgPreviewDriveRoot.md)
Invoke action preview

### [Invoke-MgReauthorizeDriveItemSubscription](Invoke-MgReauthorizeDriveItemSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeDriveListSubscription](Invoke-MgReauthorizeDriveListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeDriveRootSubscription](Invoke-MgReauthorizeDriveRootSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgReauthorizeShareListSubscription](Invoke-MgReauthorizeShareListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [Invoke-MgRecentDrive](Invoke-MgRecentDrive.md)
Invoke function recent

### [Invoke-MgUnfollowDriveItem](Invoke-MgUnfollowDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgUnfollowDriveRoot](Invoke-MgUnfollowDriveRoot.md)
Unfollow a driveItem.

### [Join-MgDriveListContentTypeWithHubSite](Join-MgDriveListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [Join-MgShareListContentTypeWithHubSite](Join-MgShareListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [New-MgDrive](New-MgDrive.md)
Add new entity to drives

### [New-MgDriveBundle](New-MgDriveBundle.md)
Create new navigation property to bundles for drives

### [New-MgDriveItem](New-MgDriveItem.md)
Create new navigation property to items for drives

### [New-MgDriveItemAnalyticItemActivityStat](New-MgDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for drives

### [New-MgDriveItemChild](New-MgDriveItemChild.md)
Create new navigation property to children for drives

### [New-MgDriveItemLink](New-MgDriveItemLink.md)
You can use createLink action to share a DriveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgDriveItemListItemDocumentSetVersion](New-MgDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgDriveItemListItemLink](New-MgDriveItemListItemLink.md)
Invoke action createLink

### [New-MgDriveItemListItemVersion](New-MgDriveItemListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveItemPermission](New-MgDriveItemPermission.md)
Create new navigation property to permissions for drives

### [New-MgDriveItemSubscription](New-MgDriveItemSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveItemThumbnail](New-MgDriveItemThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgDriveItemUploadSession](New-MgDriveItemUploadSession.md)
Invoke action createUploadSession

### [New-MgDriveItemVersion](New-MgDriveItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveListColumn](New-MgDriveListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgDriveListContentType](New-MgDriveListContentType.md)
Create new navigation property to contentTypes for drives

### [New-MgDriveListContentTypeColumn](New-MgDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site, or a list with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgDriveListContentTypeColumnLink](New-MgDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for drives

### [New-MgDriveListItem](New-MgDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgDriveListItemDocumentSetVersion](New-MgDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgDriveListItemLink](New-MgDriveListItemLink.md)
Invoke action createLink

### [New-MgDriveListItemVersion](New-MgDriveListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveListOperation](New-MgDriveListOperation.md)
Create new navigation property to operations for drives

### [New-MgDriveListSubscription](New-MgDriveListSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveRootAnalyticItemActivityStat](New-MgDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for drives

### [New-MgDriveRootChild](New-MgDriveRootChild.md)
Create new navigation property to children for drives

### [New-MgDriveRootLink](New-MgDriveRootLink.md)
You can use createLink action to share a DriveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgDriveRootListItemDocumentSetVersion](New-MgDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgDriveRootListItemLink](New-MgDriveRootListItemLink.md)
Invoke action createLink

### [New-MgDriveRootListItemVersion](New-MgDriveRootListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveRootPermission](New-MgDriveRootPermission.md)
Create new navigation property to permissions for drives

### [New-MgDriveRootSubscription](New-MgDriveRootSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveRootThumbnail](New-MgDriveRootThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgDriveRootUploadSession](New-MgDriveRootUploadSession.md)
Invoke action createUploadSession

### [New-MgDriveRootVersion](New-MgDriveRootVersion.md)
Create new navigation property to versions for drives

### [New-MgGroupDrive](New-MgGroupDrive.md)
Create new navigation property to drives for groups

### [New-MgGroupDriveBundle](New-MgGroupDriveBundle.md)
Create new navigation property to bundles for groups

### [New-MgGroupDriveItem](New-MgGroupDriveItem.md)
Create new navigation property to items for groups

### [New-MgGroupDriveItemAnalyticItemActivityStat](New-MgGroupDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for groups

### [New-MgGroupDriveItemChild](New-MgGroupDriveItemChild.md)
Create new navigation property to children for groups

### [New-MgGroupDriveItemListItemDocumentSetVersion](New-MgGroupDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgGroupDriveItemListItemVersion](New-MgGroupDriveItemListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgGroupDriveItemPermission](New-MgGroupDriveItemPermission.md)
Create new navigation property to permissions for groups

### [New-MgGroupDriveItemSubscription](New-MgGroupDriveItemSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgGroupDriveItemThumbnail](New-MgGroupDriveItemThumbnail.md)
Create new navigation property to thumbnails for groups

### [New-MgGroupDriveItemVersion](New-MgGroupDriveItemVersion.md)
Create new navigation property to versions for groups

### [New-MgGroupDriveListColumn](New-MgGroupDriveListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgGroupDriveListContentType](New-MgGroupDriveListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgGroupDriveListContentTypeColumn](New-MgGroupDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site, or a list with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgGroupDriveListContentTypeColumnLink](New-MgGroupDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgGroupDriveListItem](New-MgGroupDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgGroupDriveListItemDocumentSetVersion](New-MgGroupDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgGroupDriveListItemVersion](New-MgGroupDriveListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgGroupDriveListOperation](New-MgGroupDriveListOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupDriveListSubscription](New-MgGroupDriveListSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgGroupDriveRootAnalyticItemActivityStat](New-MgGroupDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for groups

### [New-MgGroupDriveRootChild](New-MgGroupDriveRootChild.md)
Create new navigation property to children for groups

### [New-MgGroupDriveRootListItemDocumentSetVersion](New-MgGroupDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgGroupDriveRootListItemVersion](New-MgGroupDriveRootListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgGroupDriveRootPermission](New-MgGroupDriveRootPermission.md)
Create new navigation property to permissions for groups

### [New-MgGroupDriveRootSubscription](New-MgGroupDriveRootSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgGroupDriveRootThumbnail](New-MgGroupDriveRootThumbnail.md)
Create new navigation property to thumbnails for groups

### [New-MgGroupDriveRootVersion](New-MgGroupDriveRootVersion.md)
Create new navigation property to versions for groups

### [New-MgShareListColumn](New-MgShareListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgShareListContentType](New-MgShareListContentType.md)
Create new navigation property to contentTypes for shares

### [New-MgShareListContentTypeColumn](New-MgShareListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site, or a list with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgShareListContentTypeColumnLink](New-MgShareListContentTypeColumnLink.md)
Create new navigation property to columnLinks for shares

### [New-MgShareListItem](New-MgShareListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgShareListItemDocumentSetVersion](New-MgShareListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgShareListItemVersion](New-MgShareListItemVersion.md)
Create new navigation property to versions for shares

### [New-MgShareListOperation](New-MgShareListOperation.md)
Create new navigation property to operations for shares

### [New-MgShareListSubscription](New-MgShareListSubscription.md)
Create new navigation property to subscriptions for shares

### [New-MgShareSharedDriveItemSharedDriveItem](New-MgShareSharedDriveItemSharedDriveItem.md)
Add new entity to shares

### [New-MgUserDrive](New-MgUserDrive.md)
Create new navigation property to drives for users

### [New-MgUserDriveBundle](New-MgUserDriveBundle.md)
Create new navigation property to bundles for users

### [New-MgUserDriveItem](New-MgUserDriveItem.md)
Create new navigation property to items for users

### [New-MgUserDriveItemAnalyticItemActivityStat](New-MgUserDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for users

### [New-MgUserDriveItemChild](New-MgUserDriveItemChild.md)
Create new navigation property to children for users

### [New-MgUserDriveItemListItemDocumentSetVersion](New-MgUserDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgUserDriveItemListItemVersion](New-MgUserDriveItemListItemVersion.md)
Create new navigation property to versions for users

### [New-MgUserDriveItemPermission](New-MgUserDriveItemPermission.md)
Create new navigation property to permissions for users

### [New-MgUserDriveItemSubscription](New-MgUserDriveItemSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgUserDriveItemThumbnail](New-MgUserDriveItemThumbnail.md)
Create new navigation property to thumbnails for users

### [New-MgUserDriveItemVersion](New-MgUserDriveItemVersion.md)
Create new navigation property to versions for users

### [New-MgUserDriveListColumn](New-MgUserDriveListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgUserDriveListContentType](New-MgUserDriveListContentType.md)
Create new navigation property to contentTypes for users

### [New-MgUserDriveListContentTypeColumn](New-MgUserDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site, or a list with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgUserDriveListContentTypeColumnLink](New-MgUserDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for users

### [New-MgUserDriveListItem](New-MgUserDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgUserDriveListItemDocumentSetVersion](New-MgUserDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgUserDriveListItemVersion](New-MgUserDriveListItemVersion.md)
Create new navigation property to versions for users

### [New-MgUserDriveListOperation](New-MgUserDriveListOperation.md)
Create new navigation property to operations for users

### [New-MgUserDriveListSubscription](New-MgUserDriveListSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgUserDriveRootAnalyticItemActivityStat](New-MgUserDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for users

### [New-MgUserDriveRootChild](New-MgUserDriveRootChild.md)
Create new navigation property to children for users

### [New-MgUserDriveRootListItemDocumentSetVersion](New-MgUserDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgUserDriveRootListItemVersion](New-MgUserDriveRootListItemVersion.md)
Create new navigation property to versions for users

### [New-MgUserDriveRootPermission](New-MgUserDriveRootPermission.md)
Create new navigation property to permissions for users

### [New-MgUserDriveRootSubscription](New-MgUserDriveRootSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgUserDriveRootThumbnail](New-MgUserDriveRootThumbnail.md)
Create new navigation property to thumbnails for users

### [New-MgUserDriveRootVersion](New-MgUserDriveRootVersion.md)
Create new navigation property to versions for users

### [Publish-MgDriveListContentType](Publish-MgDriveListContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Publish-MgShareListContentType](Publish-MgShareListContentType.md)
Publishes a [contentType][] present in the content type hub site.

### [Remove-MgDrive](Remove-MgDrive.md)
Delete entity from drives

### [Remove-MgDriveItem](Remove-MgDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.

### [Remove-MgDriveItemAnalytic](Remove-MgDriveItemAnalytic.md)
Delete navigation property analytics for drives

### [Remove-MgDriveItemAnalyticItemActivityStat](Remove-MgDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for drives

### [Remove-MgDriveItemChild](Remove-MgDriveItemChild.md)
Remove an item from a [bundle][].

### [Remove-MgDriveItemListItem](Remove-MgDriveItemListItem.md)
Delete navigation property listItem for drives

### [Remove-MgDriveItemListItemDocumentSetVersion](Remove-MgDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgDriveItemListItemDocumentSetVersionField](Remove-MgDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveItemListItemField](Remove-MgDriveItemListItemField.md)
Delete navigation property fields for drives

### [Remove-MgDriveItemListItemVersion](Remove-MgDriveItemListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveItemListItemVersionField](Remove-MgDriveItemListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveItemPermanent](Remove-MgDriveItemPermanent.md)
Invoke action permanentDelete

### [Remove-MgDriveItemPermission](Remove-MgDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgDriveItemRetentionLabel](Remove-MgDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgDriveItemSubscription](Remove-MgDriveItemSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgDriveItemThumbnail](Remove-MgDriveItemThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgDriveItemVersion](Remove-MgDriveItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveList](Remove-MgDriveList.md)
Delete navigation property list for drives

### [Remove-MgDriveListColumn](Remove-MgDriveListColumn.md)
Delete navigation property columns for drives

### [Remove-MgDriveListContentType](Remove-MgDriveListContentType.md)
Delete navigation property contentTypes for drives

### [Remove-MgDriveListContentTypeColumn](Remove-MgDriveListContentTypeColumn.md)
Remove a [column][columndefinition] from a [site][], a [list][], or a [content type][contentType].

### [Remove-MgDriveListContentTypeColumnLink](Remove-MgDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for drives

### [Remove-MgDriveListItem](Remove-MgDriveListItem.md)
Removes an item from a [list][].

### [Remove-MgDriveListItemDocumentSetVersion](Remove-MgDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgDriveListItemDocumentSetVersionField](Remove-MgDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveListItemField](Remove-MgDriveListItemField.md)
Delete navigation property fields for drives

### [Remove-MgDriveListItemVersion](Remove-MgDriveListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveListItemVersionField](Remove-MgDriveListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveListOperation](Remove-MgDriveListOperation.md)
Delete navigation property operations for drives

### [Remove-MgDriveListSubscription](Remove-MgDriveListSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgDriveRoot](Remove-MgDriveRoot.md)
Delete navigation property root for drives

### [Remove-MgDriveRootAnalytic](Remove-MgDriveRootAnalytic.md)
Delete navigation property analytics for drives

### [Remove-MgDriveRootAnalyticItemActivityStat](Remove-MgDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for drives

### [Remove-MgDriveRootChild](Remove-MgDriveRootChild.md)
Remove an item from a [bundle][].

### [Remove-MgDriveRootListItem](Remove-MgDriveRootListItem.md)
Delete navigation property listItem for drives

### [Remove-MgDriveRootListItemDocumentSetVersion](Remove-MgDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgDriveRootListItemDocumentSetVersionField](Remove-MgDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveRootListItemField](Remove-MgDriveRootListItemField.md)
Delete navigation property fields for drives

### [Remove-MgDriveRootListItemVersion](Remove-MgDriveRootListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveRootListItemVersionField](Remove-MgDriveRootListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveRootPermanent](Remove-MgDriveRootPermanent.md)
Invoke action permanentDelete

### [Remove-MgDriveRootPermission](Remove-MgDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgDriveRootRetentionLabel](Remove-MgDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgDriveRootSubscription](Remove-MgDriveRootSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgDriveRootThumbnail](Remove-MgDriveRootThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgDriveRootVersion](Remove-MgDriveRootVersion.md)
Delete navigation property versions for drives

### [Remove-MgGroupDrive](Remove-MgGroupDrive.md)
Delete navigation property drives for groups

### [Remove-MgGroupDriveItem](Remove-MgGroupDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.

### [Remove-MgGroupDriveItemAnalytic](Remove-MgGroupDriveItemAnalytic.md)
Delete navigation property analytics for groups

### [Remove-MgGroupDriveItemAnalyticItemActivityStat](Remove-MgGroupDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for groups

### [Remove-MgGroupDriveItemChild](Remove-MgGroupDriveItemChild.md)
Remove an item from a [bundle][].

### [Remove-MgGroupDriveItemListItem](Remove-MgGroupDriveItemListItem.md)
Delete navigation property listItem for groups

### [Remove-MgGroupDriveItemListItemDocumentSetVersion](Remove-MgGroupDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgGroupDriveItemListItemDocumentSetVersionField](Remove-MgGroupDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveItemListItemField](Remove-MgGroupDriveItemListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveItemListItemVersion](Remove-MgGroupDriveItemListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveItemListItemVersionField](Remove-MgGroupDriveItemListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveItemPermission](Remove-MgGroupDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgGroupDriveItemRetentionLabel](Remove-MgGroupDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgGroupDriveItemSubscription](Remove-MgGroupDriveItemSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgGroupDriveItemThumbnail](Remove-MgGroupDriveItemThumbnail.md)
Delete navigation property thumbnails for groups

### [Remove-MgGroupDriveItemVersion](Remove-MgGroupDriveItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveList](Remove-MgGroupDriveList.md)
Delete navigation property list for groups

### [Remove-MgGroupDriveListColumn](Remove-MgGroupDriveListColumn.md)
Delete navigation property columns for groups

### [Remove-MgGroupDriveListContentType](Remove-MgGroupDriveListContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgGroupDriveListContentTypeColumn](Remove-MgGroupDriveListContentTypeColumn.md)
Remove a [column][columndefinition] from a [site][], a [list][], or a [content type][contentType].

### [Remove-MgGroupDriveListContentTypeColumnLink](Remove-MgGroupDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgGroupDriveListItem](Remove-MgGroupDriveListItem.md)
Removes an item from a [list][].

### [Remove-MgGroupDriveListItemDocumentSetVersion](Remove-MgGroupDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgGroupDriveListItemDocumentSetVersionField](Remove-MgGroupDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveListItemField](Remove-MgGroupDriveListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveListItemVersion](Remove-MgGroupDriveListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveListItemVersionField](Remove-MgGroupDriveListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveListOperation](Remove-MgGroupDriveListOperation.md)
Delete navigation property operations for groups

### [Remove-MgGroupDriveListSubscription](Remove-MgGroupDriveListSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgGroupDriveRoot](Remove-MgGroupDriveRoot.md)
Delete navigation property root for groups

### [Remove-MgGroupDriveRootAnalytic](Remove-MgGroupDriveRootAnalytic.md)
Delete navigation property analytics for groups

### [Remove-MgGroupDriveRootAnalyticItemActivityStat](Remove-MgGroupDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for groups

### [Remove-MgGroupDriveRootChild](Remove-MgGroupDriveRootChild.md)
Remove an item from a [bundle][].

### [Remove-MgGroupDriveRootListItem](Remove-MgGroupDriveRootListItem.md)
Delete navigation property listItem for groups

### [Remove-MgGroupDriveRootListItemDocumentSetVersion](Remove-MgGroupDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgGroupDriveRootListItemDocumentSetVersionField](Remove-MgGroupDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveRootListItemField](Remove-MgGroupDriveRootListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveRootListItemVersion](Remove-MgGroupDriveRootListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveRootListItemVersionField](Remove-MgGroupDriveRootListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveRootPermission](Remove-MgGroupDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgGroupDriveRootRetentionLabel](Remove-MgGroupDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgGroupDriveRootSubscription](Remove-MgGroupDriveRootSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgGroupDriveRootThumbnail](Remove-MgGroupDriveRootThumbnail.md)
Delete navigation property thumbnails for groups

### [Remove-MgGroupDriveRootVersion](Remove-MgGroupDriveRootVersion.md)
Delete navigation property versions for groups

### [Remove-MgShareList](Remove-MgShareList.md)
Delete navigation property list for shares

### [Remove-MgShareListColumn](Remove-MgShareListColumn.md)
Delete navigation property columns for shares

### [Remove-MgShareListContentType](Remove-MgShareListContentType.md)
Delete navigation property contentTypes for shares

### [Remove-MgShareListContentTypeColumn](Remove-MgShareListContentTypeColumn.md)
Remove a [column][columndefinition] from a [site][], a [list][], or a [content type][contentType].

### [Remove-MgShareListContentTypeColumnLink](Remove-MgShareListContentTypeColumnLink.md)
Delete navigation property columnLinks for shares

### [Remove-MgShareListItem](Remove-MgShareListItem.md)
Delete navigation property listItem for shares

### [Remove-MgShareListItemDocumentSetVersion](Remove-MgShareListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgShareListItemDocumentSetVersionField](Remove-MgShareListItemDocumentSetVersionField.md)
Delete navigation property fields for shares

### [Remove-MgShareListItemField](Remove-MgShareListItemField.md)
Delete navigation property fields for shares

### [Remove-MgShareListItemVersion](Remove-MgShareListItemVersion.md)
Delete navigation property versions for shares

### [Remove-MgShareListItemVersionField](Remove-MgShareListItemVersionField.md)
Delete navigation property fields for shares

### [Remove-MgShareListOperation](Remove-MgShareListOperation.md)
Delete navigation property operations for shares

### [Remove-MgShareListSubscription](Remove-MgShareListSubscription.md)
Delete navigation property subscriptions for shares

### [Remove-MgSharePermission](Remove-MgSharePermission.md)
Delete navigation property permission for shares

### [Remove-MgShareSharedDriveItemSharedDriveItem](Remove-MgShareSharedDriveItemSharedDriveItem.md)
Delete entity from shares

### [Remove-MgUserDrive](Remove-MgUserDrive.md)
Delete navigation property drives for users

### [Remove-MgUserDriveItem](Remove-MgUserDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.

### [Remove-MgUserDriveItemAnalytic](Remove-MgUserDriveItemAnalytic.md)
Delete navigation property analytics for users

### [Remove-MgUserDriveItemAnalyticItemActivityStat](Remove-MgUserDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for users

### [Remove-MgUserDriveItemChild](Remove-MgUserDriveItemChild.md)
Remove an item from a [bundle][].

### [Remove-MgUserDriveItemListItem](Remove-MgUserDriveItemListItem.md)
Delete navigation property listItem for users

### [Remove-MgUserDriveItemListItemDocumentSetVersion](Remove-MgUserDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgUserDriveItemListItemDocumentSetVersionField](Remove-MgUserDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveItemListItemField](Remove-MgUserDriveItemListItemField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveItemListItemVersion](Remove-MgUserDriveItemListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveItemListItemVersionField](Remove-MgUserDriveItemListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveItemPermission](Remove-MgUserDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgUserDriveItemRetentionLabel](Remove-MgUserDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgUserDriveItemSubscription](Remove-MgUserDriveItemSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgUserDriveItemThumbnail](Remove-MgUserDriveItemThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgUserDriveItemVersion](Remove-MgUserDriveItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveList](Remove-MgUserDriveList.md)
Delete navigation property list for users

### [Remove-MgUserDriveListColumn](Remove-MgUserDriveListColumn.md)
Delete navigation property columns for users

### [Remove-MgUserDriveListContentType](Remove-MgUserDriveListContentType.md)
Delete navigation property contentTypes for users

### [Remove-MgUserDriveListContentTypeColumn](Remove-MgUserDriveListContentTypeColumn.md)
Remove a [column][columndefinition] from a [site][], a [list][], or a [content type][contentType].

### [Remove-MgUserDriveListContentTypeColumnLink](Remove-MgUserDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for users

### [Remove-MgUserDriveListItem](Remove-MgUserDriveListItem.md)
Removes an item from a [list][].

### [Remove-MgUserDriveListItemDocumentSetVersion](Remove-MgUserDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgUserDriveListItemDocumentSetVersionField](Remove-MgUserDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveListItemField](Remove-MgUserDriveListItemField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveListItemVersion](Remove-MgUserDriveListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveListItemVersionField](Remove-MgUserDriveListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveListOperation](Remove-MgUserDriveListOperation.md)
Delete navigation property operations for users

### [Remove-MgUserDriveListSubscription](Remove-MgUserDriveListSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgUserDriveRoot](Remove-MgUserDriveRoot.md)
Delete navigation property root for users

### [Remove-MgUserDriveRootAnalytic](Remove-MgUserDriveRootAnalytic.md)
Delete navigation property analytics for users

### [Remove-MgUserDriveRootAnalyticItemActivityStat](Remove-MgUserDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for users

### [Remove-MgUserDriveRootChild](Remove-MgUserDriveRootChild.md)
Remove an item from a [bundle][].

### [Remove-MgUserDriveRootListItem](Remove-MgUserDriveRootListItem.md)
Delete navigation property listItem for users

### [Remove-MgUserDriveRootListItemDocumentSetVersion](Remove-MgUserDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.

### [Remove-MgUserDriveRootListItemDocumentSetVersionField](Remove-MgUserDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveRootListItemField](Remove-MgUserDriveRootListItemField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveRootListItemVersion](Remove-MgUserDriveRootListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveRootListItemVersionField](Remove-MgUserDriveRootListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveRootPermission](Remove-MgUserDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.

### [Remove-MgUserDriveRootRetentionLabel](Remove-MgUserDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Remove-MgUserDriveRootSubscription](Remove-MgUserDriveRootSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgUserDriveRootThumbnail](Remove-MgUserDriveRootThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgUserDriveRootVersion](Remove-MgUserDriveRootVersion.md)
Delete navigation property versions for users

### [Restore-MgDriveItem](Restore-MgDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
NOTE: This functionality is currently only available for OneDrive Personal.

### [Restore-MgDriveItemListItemDocumentSetVersion](Restore-MgDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgDriveItemListItemVersion](Restore-MgDriveItemListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgDriveItemVersion](Restore-MgDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgDriveListItemDocumentSetVersion](Restore-MgDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgDriveListItemVersion](Restore-MgDriveListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgDriveRoot](Restore-MgDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
NOTE: This functionality is currently only available for OneDrive Personal.

### [Restore-MgDriveRootListItemDocumentSetVersion](Restore-MgDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgDriveRootListItemVersion](Restore-MgDriveRootListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Restore-MgDriveRootVersion](Restore-MgDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgShareListItemDocumentSetVersion](Restore-MgShareListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgShareListItemVersion](Restore-MgShareListItemVersion.md)
Restore a previous version of a ListItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the item.

### [Search-MgDrive](Search-MgDrive.md)
Invoke function search

### [Search-MgDriveItem](Search-MgDriveItem.md)
Invoke function search

### [Search-MgDriveRoot](Search-MgDriveRoot.md)
Invoke function search

### [Set-MgDriveBundleContent](Set-MgDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveFollowingContent](Set-MgDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveItemChildContent](Set-MgDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveItemContent](Set-MgDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveItemListItemDriveItemContent](Set-MgDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveItemSensitivityLabel](Set-MgDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgDriveItemVersionContent](Set-MgDriveItemVersionContent.md)
The content stream for this version of the item.

### [Set-MgDriveListItemDriveItemContent](Set-MgDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveRootChildContent](Set-MgDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveRootContent](Set-MgDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveRootListItemDriveItemContent](Set-MgDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgDriveRootSensitivityLabel](Set-MgDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgDriveRootVersionContent](Set-MgDriveRootVersionContent.md)
The content stream for this version of the item.

### [Set-MgDriveSpecialContent](Set-MgDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveBundleContent](Set-MgGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveFollowingContent](Set-MgGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveItemChildContent](Set-MgGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveItemContent](Set-MgGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveItemListItemDriveItemContent](Set-MgGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveItemVersionContent](Set-MgGroupDriveItemVersionContent.md)
The content stream for this version of the item.

### [Set-MgGroupDriveListItemDriveItemContent](Set-MgGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveRootChildContent](Set-MgGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveRootContent](Set-MgGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveRootListItemDriveItemContent](Set-MgGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgGroupDriveRootVersionContent](Set-MgGroupDriveRootVersionContent.md)
The content stream for this version of the item.

### [Set-MgGroupDriveSpecialContent](Set-MgGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Set-MgShareDriveItemContent](Set-MgShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgShareItemContent](Set-MgShareItemContent.md)
The content stream, if the item represents a file.

### [Set-MgShareListItemDriveItemContent](Set-MgShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgShareRootContent](Set-MgShareRootContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveBundleContent](Set-MgUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveFollowingContent](Set-MgUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveItemChildContent](Set-MgUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveItemContent](Set-MgUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveItemListItemDriveItemContent](Set-MgUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveItemVersionContent](Set-MgUserDriveItemVersionContent.md)
The content stream for this version of the item.

### [Set-MgUserDriveListItemDriveItemContent](Set-MgUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveRootChildContent](Set-MgUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveRootContent](Set-MgUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveRootListItemDriveItemContent](Set-MgUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgUserDriveRootVersionContent](Set-MgUserDriveRootVersionContent.md)
The content stream for this version of the item.

### [Set-MgUserDriveSpecialContent](Set-MgUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Test-MgDriveItemPermission](Test-MgDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgDriveListContentTypePublished](Test-MgDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgDriveRootPermission](Test-MgDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgShareListContentTypePublished](Test-MgShareListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgDriveListContentType](Unpublish-MgDriveListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgShareListContentType](Unpublish-MgShareListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgDrive](Update-MgDrive.md)
Update entity in drives

### [Update-MgDriveCreatedByUserMailboxSetting](Update-MgDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveItem](Update-MgDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.

### [Update-MgDriveItemAnalytic](Update-MgDriveItemAnalytic.md)
Update the navigation property analytics in drives

### [Update-MgDriveItemAnalyticItemActivityStat](Update-MgDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in drives

### [Update-MgDriveItemCreatedByUserMailboxSetting](Update-MgDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveItemLastModifiedByUserMailboxSetting](Update-MgDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveItemListItem](Update-MgDriveItemListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveItemListItemCreatedByUserMailboxSetting](Update-MgDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveItemListItemDocumentSetVersion](Update-MgDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveItemListItemDocumentSetVersionField](Update-MgDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveItemListItemField](Update-MgDriveItemListItemField.md)
Update the properties on a [listItem][].

### [Update-MgDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveItemListItemVersion](Update-MgDriveItemListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveItemListItemVersionField](Update-MgDriveItemListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveItemPermission](Update-MgDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgDriveItemRetentionLabel](Update-MgDriveItemRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgDriveItemSubscription](Update-MgDriveItemSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgDriveItemThumbnail](Update-MgDriveItemThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgDriveItemVersion](Update-MgDriveItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveLastModifiedByUserMailboxSetting](Update-MgDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveList](Update-MgDriveList.md)
Update the navigation property list in drives

### [Update-MgDriveListColumn](Update-MgDriveListColumn.md)
Update the navigation property columns in drives

### [Update-MgDriveListContentType](Update-MgDriveListContentType.md)
Update the navigation property contentTypes in drives

### [Update-MgDriveListContentTypeColumn](Update-MgDriveListContentTypeColumn.md)
Update a [site][], a [list][], or a [content type][contentType] [column][columnDefinition].

### [Update-MgDriveListContentTypeColumnLink](Update-MgDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in drives

### [Update-MgDriveListCreatedByUserMailboxSetting](Update-MgDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveListItem](Update-MgDriveListItem.md)
Update the navigation property items in drives

### [Update-MgDriveListItemCreatedByUserMailboxSetting](Update-MgDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveListItemDocumentSetVersion](Update-MgDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveListItemDocumentSetVersionField](Update-MgDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveListItemField](Update-MgDriveListItemField.md)
Update the properties on a [listItem][].

### [Update-MgDriveListItemLastModifiedByUserMailboxSetting](Update-MgDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveListItemVersion](Update-MgDriveListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveListItemVersionField](Update-MgDriveListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveListLastModifiedByUserMailboxSetting](Update-MgDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveListOperation](Update-MgDriveListOperation.md)
Update the navigation property operations in drives

### [Update-MgDriveListSubscription](Update-MgDriveListSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgDriveRoot](Update-MgDriveRoot.md)
Update the navigation property root in drives

### [Update-MgDriveRootAnalytic](Update-MgDriveRootAnalytic.md)
Update the navigation property analytics in drives

### [Update-MgDriveRootAnalyticItemActivityStat](Update-MgDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in drives

### [Update-MgDriveRootCreatedByUserMailboxSetting](Update-MgDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveRootLastModifiedByUserMailboxSetting](Update-MgDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveRootListItem](Update-MgDriveRootListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveRootListItemCreatedByUserMailboxSetting](Update-MgDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveRootListItemDocumentSetVersion](Update-MgDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveRootListItemDocumentSetVersionField](Update-MgDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveRootListItemField](Update-MgDriveRootListItemField.md)
Update the properties on a [listItem][].

### [Update-MgDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgDriveRootListItemVersion](Update-MgDriveRootListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveRootListItemVersionField](Update-MgDriveRootListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveRootPermission](Update-MgDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgDriveRootRetentionLabel](Update-MgDriveRootRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgDriveRootSubscription](Update-MgDriveRootSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgDriveRootThumbnail](Update-MgDriveRootThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgDriveRootVersion](Update-MgDriveRootVersion.md)
Update the navigation property versions in drives

### [Update-MgGroupDrive](Update-MgGroupDrive.md)
Update the navigation property drives in groups

### [Update-MgGroupDriveCreatedByUserMailboxSetting](Update-MgGroupDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveItem](Update-MgGroupDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.

### [Update-MgGroupDriveItemAnalytic](Update-MgGroupDriveItemAnalytic.md)
Update the navigation property analytics in groups

### [Update-MgGroupDriveItemAnalyticItemActivityStat](Update-MgGroupDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in groups

### [Update-MgGroupDriveItemCreatedByUserMailboxSetting](Update-MgGroupDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveItemLastModifiedByUserMailboxSetting](Update-MgGroupDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveItemListItem](Update-MgGroupDriveItemListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveItemListItemCreatedByUserMailboxSetting](Update-MgGroupDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveItemListItemDocumentSetVersion](Update-MgGroupDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveItemListItemDocumentSetVersionField](Update-MgGroupDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveItemListItemField](Update-MgGroupDriveItemListItemField.md)
Update the properties on a [listItem][].

### [Update-MgGroupDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgGroupDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveItemListItemVersion](Update-MgGroupDriveItemListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveItemListItemVersionField](Update-MgGroupDriveItemListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveItemPermission](Update-MgGroupDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgGroupDriveItemRetentionLabel](Update-MgGroupDriveItemRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgGroupDriveItemSubscription](Update-MgGroupDriveItemSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupDriveItemThumbnail](Update-MgGroupDriveItemThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgGroupDriveItemVersion](Update-MgGroupDriveItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveLastModifiedByUserMailboxSetting](Update-MgGroupDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveList](Update-MgGroupDriveList.md)
Update the navigation property list in groups

### [Update-MgGroupDriveListColumn](Update-MgGroupDriveListColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupDriveListContentType](Update-MgGroupDriveListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgGroupDriveListContentTypeColumn](Update-MgGroupDriveListContentTypeColumn.md)
Update a [site][], a [list][], or a [content type][contentType] [column][columnDefinition].

### [Update-MgGroupDriveListContentTypeColumnLink](Update-MgGroupDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgGroupDriveListCreatedByUserMailboxSetting](Update-MgGroupDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveListItem](Update-MgGroupDriveListItem.md)
Update the navigation property items in groups

### [Update-MgGroupDriveListItemCreatedByUserMailboxSetting](Update-MgGroupDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveListItemDocumentSetVersion](Update-MgGroupDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveListItemDocumentSetVersionField](Update-MgGroupDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveListItemField](Update-MgGroupDriveListItemField.md)
Update the properties on a [listItem][].

### [Update-MgGroupDriveListItemLastModifiedByUserMailboxSetting](Update-MgGroupDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveListItemVersion](Update-MgGroupDriveListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveListItemVersionField](Update-MgGroupDriveListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveListLastModifiedByUserMailboxSetting](Update-MgGroupDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveListOperation](Update-MgGroupDriveListOperation.md)
Update the navigation property operations in groups

### [Update-MgGroupDriveListSubscription](Update-MgGroupDriveListSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupDriveRoot](Update-MgGroupDriveRoot.md)
Update the navigation property root in groups

### [Update-MgGroupDriveRootAnalytic](Update-MgGroupDriveRootAnalytic.md)
Update the navigation property analytics in groups

### [Update-MgGroupDriveRootAnalyticItemActivityStat](Update-MgGroupDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in groups

### [Update-MgGroupDriveRootCreatedByUserMailboxSetting](Update-MgGroupDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveRootLastModifiedByUserMailboxSetting](Update-MgGroupDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveRootListItem](Update-MgGroupDriveRootListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveRootListItemCreatedByUserMailboxSetting](Update-MgGroupDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveRootListItemDocumentSetVersion](Update-MgGroupDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveRootListItemDocumentSetVersionField](Update-MgGroupDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveRootListItemField](Update-MgGroupDriveRootListItemField.md)
Update the properties on a [listItem][].

### [Update-MgGroupDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgGroupDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgGroupDriveRootListItemVersion](Update-MgGroupDriveRootListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveRootListItemVersionField](Update-MgGroupDriveRootListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveRootPermission](Update-MgGroupDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgGroupDriveRootRetentionLabel](Update-MgGroupDriveRootRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgGroupDriveRootSubscription](Update-MgGroupDriveRootSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupDriveRootThumbnail](Update-MgGroupDriveRootThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgGroupDriveRootVersion](Update-MgGroupDriveRootVersion.md)
Update the navigation property versions in groups

### [Update-MgShareCreatedByUserMailboxSetting](Update-MgShareCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareLastModifiedByUserMailboxSetting](Update-MgShareLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareList](Update-MgShareList.md)
Update the navigation property list in shares

### [Update-MgShareListColumn](Update-MgShareListColumn.md)
Update the navigation property columns in shares

### [Update-MgShareListContentType](Update-MgShareListContentType.md)
Update the navigation property contentTypes in shares

### [Update-MgShareListContentTypeColumn](Update-MgShareListContentTypeColumn.md)
Update a [site][], a [list][], or a [content type][contentType] [column][columnDefinition].

### [Update-MgShareListContentTypeColumnLink](Update-MgShareListContentTypeColumnLink.md)
Update the navigation property columnLinks in shares

### [Update-MgShareListCreatedByUserMailboxSetting](Update-MgShareListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareListItem](Update-MgShareListItem.md)
Update the navigation property listItem in shares

### [Update-MgShareListItemCreatedByUserMailboxSetting](Update-MgShareListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareListItemDocumentSetVersion](Update-MgShareListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in shares

### [Update-MgShareListItemDocumentSetVersionField](Update-MgShareListItemDocumentSetVersionField.md)
Update the navigation property fields in shares

### [Update-MgShareListItemField](Update-MgShareListItemField.md)
Update the properties on a [listItem][].

### [Update-MgShareListItemLastModifiedByUserMailboxSetting](Update-MgShareListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareListItemVersion](Update-MgShareListItemVersion.md)
Update the navigation property versions in shares

### [Update-MgShareListItemVersionField](Update-MgShareListItemVersionField.md)
Update the navigation property fields in shares

### [Update-MgShareListLastModifiedByUserMailboxSetting](Update-MgShareListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgShareListOperation](Update-MgShareListOperation.md)
Update the navigation property operations in shares

### [Update-MgShareListSubscription](Update-MgShareListSubscription.md)
Update the navigation property subscriptions in shares

### [Update-MgSharePermission](Update-MgSharePermission.md)
Update the navigation property permission in shares

### [Update-MgShareSharedDriveItemSharedDriveItem](Update-MgShareSharedDriveItemSharedDriveItem.md)
Update entity in shares

### [Update-MgUserDrive](Update-MgUserDrive.md)
Update the navigation property drives in users

### [Update-MgUserDriveCreatedByUserMailboxSetting](Update-MgUserDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveItem](Update-MgUserDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.

### [Update-MgUserDriveItemAnalytic](Update-MgUserDriveItemAnalytic.md)
Update the navigation property analytics in users

### [Update-MgUserDriveItemAnalyticItemActivityStat](Update-MgUserDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in users

### [Update-MgUserDriveItemCreatedByUserMailboxSetting](Update-MgUserDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveItemLastModifiedByUserMailboxSetting](Update-MgUserDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveItemListItem](Update-MgUserDriveItemListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveItemListItemCreatedByUserMailboxSetting](Update-MgUserDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveItemListItemDocumentSetVersion](Update-MgUserDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveItemListItemDocumentSetVersionField](Update-MgUserDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveItemListItemField](Update-MgUserDriveItemListItemField.md)
Update the properties on a [listItem][].

### [Update-MgUserDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgUserDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveItemListItemVersion](Update-MgUserDriveItemListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveItemListItemVersionField](Update-MgUserDriveItemListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveItemPermission](Update-MgUserDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgUserDriveItemRetentionLabel](Update-MgUserDriveItemRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgUserDriveItemSubscription](Update-MgUserDriveItemSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgUserDriveItemThumbnail](Update-MgUserDriveItemThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgUserDriveItemVersion](Update-MgUserDriveItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveLastModifiedByUserMailboxSetting](Update-MgUserDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveList](Update-MgUserDriveList.md)
Update the navigation property list in users

### [Update-MgUserDriveListColumn](Update-MgUserDriveListColumn.md)
Update the navigation property columns in users

### [Update-MgUserDriveListContentType](Update-MgUserDriveListContentType.md)
Update the navigation property contentTypes in users

### [Update-MgUserDriveListContentTypeColumn](Update-MgUserDriveListContentTypeColumn.md)
Update a [site][], a [list][], or a [content type][contentType] [column][columnDefinition].

### [Update-MgUserDriveListContentTypeColumnLink](Update-MgUserDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in users

### [Update-MgUserDriveListCreatedByUserMailboxSetting](Update-MgUserDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveListItem](Update-MgUserDriveListItem.md)
Update the navigation property items in users

### [Update-MgUserDriveListItemCreatedByUserMailboxSetting](Update-MgUserDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveListItemDocumentSetVersion](Update-MgUserDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveListItemDocumentSetVersionField](Update-MgUserDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveListItemField](Update-MgUserDriveListItemField.md)
Update the properties on a [listItem][].

### [Update-MgUserDriveListItemLastModifiedByUserMailboxSetting](Update-MgUserDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveListItemVersion](Update-MgUserDriveListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveListItemVersionField](Update-MgUserDriveListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveListLastModifiedByUserMailboxSetting](Update-MgUserDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveListOperation](Update-MgUserDriveListOperation.md)
Update the navigation property operations in users

### [Update-MgUserDriveListSubscription](Update-MgUserDriveListSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgUserDriveRoot](Update-MgUserDriveRoot.md)
Update the navigation property root in users

### [Update-MgUserDriveRootAnalytic](Update-MgUserDriveRootAnalytic.md)
Update the navigation property analytics in users

### [Update-MgUserDriveRootAnalyticItemActivityStat](Update-MgUserDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in users

### [Update-MgUserDriveRootCreatedByUserMailboxSetting](Update-MgUserDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveRootLastModifiedByUserMailboxSetting](Update-MgUserDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveRootListItem](Update-MgUserDriveRootListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveRootListItemCreatedByUserMailboxSetting](Update-MgUserDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveRootListItemDocumentSetVersion](Update-MgUserDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveRootListItemDocumentSetVersionField](Update-MgUserDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveRootListItemField](Update-MgUserDriveRootListItemField.md)
Update the properties on a [listItem][].

### [Update-MgUserDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgUserDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgUserDriveRootListItemVersion](Update-MgUserDriveRootListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveRootListItemVersionField](Update-MgUserDriveRootListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveRootPermission](Update-MgUserDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.

### [Update-MgUserDriveRootRetentionLabel](Update-MgUserDriveRootRetentionLabel.md)
Apply (set) a retention label on a driveItem (files and folders).
Retention labels don't need to be published in a retention label policy to be applied using this method.
When a retention label is applied to a folder, all the items in the folder are tagged with the same retention label.
For information about conflict resolution for retention labels, see Will an existing label be overridden or removed.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.

### [Update-MgUserDriveRootSubscription](Update-MgUserDriveRootSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgUserDriveRootThumbnail](Update-MgUserDriveRootThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgUserDriveRootVersion](Update-MgUserDriveRootVersion.md)
Update the navigation property versions in users

