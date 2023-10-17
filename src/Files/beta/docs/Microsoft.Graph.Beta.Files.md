---
Module Name: Microsoft.Graph.Beta.Files
Module Guid: 2e2f1e96-fe5f-4fb2-b62f-dab36041a5ca
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.files
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Files Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Files Cmdlets
### [Add-MgBetaDriveListContentTypeCopy](Add-MgBetaDriveListContentTypeCopy.md)
Add a copy of a content type][contentType] from a [site][site] to a [list][list].
This API is available in the following [national cloud deployments.

### [Add-MgBetaDriveListContentTypeCopyFromContentTypeHub](Add-MgBetaDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.
This API is available in the following national cloud deployments.

### [Add-MgBetaShareListContentTypeCopy](Add-MgBetaShareListContentTypeCopy.md)
Add a copy of a content type][contentType] from a [site][site] to a [list][list].
This API is available in the following [national cloud deployments.

### [Add-MgBetaShareListContentTypeCopyFromContentTypeHub](Add-MgBetaShareListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.
This API is available in the following national cloud deployments.

### [Copy-MgBetaDriveItem](Copy-MgBetaDriveItem.md)
Asynchronously creates a copy of an driveItem][item-resource] (including any children), under a new parent item or with a new name.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaDriveListContentTypeToDefaultContentLocation](Copy-MgBetaDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a content type][contentType].
The file can then be added as a default file or template via a POST operation.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaDriveRoot](Copy-MgBetaDriveRoot.md)
Asynchronously creates a copy of an driveItem][item-resource] (including any children), under a new parent item or with a new name.
This API is available in the following [national cloud deployments.

### [Copy-MgBetaShareListContentTypeToDefaultContentLocation](Copy-MgBetaShareListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a content type][contentType].
The file can then be added as a default file or template via a POST operation.
This API is available in the following [national cloud deployments.

### [Get-MgBetaDrive](Get-MgBetaDrive.md)
Get entity from drives by key

### [Get-MgBetaDriveActivity](Get-MgBetaDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveBundle](Get-MgBetaDriveBundle.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveBundleContent](Get-MgBetaDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveBundleCount](Get-MgBetaDriveBundleCount.md)
Get the number of the resource

### [Get-MgBetaDriveContentTypeBase](Get-MgBetaDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaDriveContentTypeBaseType](Get-MgBetaDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaDriveContentTypeBaseTypeCount](Get-MgBetaDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgBetaDriveCreatedByUser](Get-MgBetaDriveCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveCreatedByUserMailboxSetting](Get-MgBetaDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveCreatedByUserServiceProvisioningError](Get-MgBetaDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveFollowing](Get-MgBetaDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaDriveFollowingContent](Get-MgBetaDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveFollowingCount](Get-MgBetaDriveFollowingCount.md)
Get the number of the resource

### [Get-MgBetaDriveItem](Get-MgBetaDriveItem.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveItemActivity](Get-MgBetaDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveItemActivityByInterval](Get-MgBetaDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveItemAnalytic](Get-MgBetaDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveItemAnalyticItemActivityStat](Get-MgBetaDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgBetaDriveItemAnalyticItemActivityStatActivity](Get-MgBetaDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaDriveItemAnalyticItemActivityStatCount](Get-MgBetaDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemAnalyticLastSevenDay](Get-MgBetaDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgBetaDriveItemAnalyticTime](Get-MgBetaDriveItemAnalyticTime.md)
Get allTime from drives

### [Get-MgBetaDriveItemChild](Get-MgBetaDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaDriveItemChildContent](Get-MgBetaDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemChildCount](Get-MgBetaDriveItemChildCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemContent](Get-MgBetaDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemCount](Get-MgBetaDriveItemCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemCreatedByUser](Get-MgBetaDriveItemCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveItemCreatedByUserMailboxSetting](Get-MgBetaDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveItemCreatedByUserServiceProvisioningError](Get-MgBetaDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemDelta](Get-MgBetaDriveItemDelta.md)
Invoke function delta

### [Get-MgBetaDriveItemItemLastModifiedByUser](Get-MgBetaDriveItemItemLastModifiedByUser.md)
Get lastModifiedByUser from drives

### [Get-MgBetaDriveItemItemLastModifiedByUserMailboxSetting](Get-MgBetaDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgBetaDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemLastModifiedByUser](Get-MgBetaDriveItemLastModifiedByUser.md)
Get lastModifiedByUser from drives

### [Get-MgBetaDriveItemLastModifiedByUserMailboxSetting](Get-MgBetaDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveItemLastModifiedByUserServiceProvisioningError](Get-MgBetaDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemListItem](Get-MgBetaDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaDriveItemListItemActivity](Get-MgBetaDriveItemListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveItemListItemActivityByInterval](Get-MgBetaDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveItemListItemAnalytic](Get-MgBetaDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaDriveItemListItemCreatedByUser](Get-MgBetaDriveItemListItemCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveItemListItemCreatedByUserMailboxSetting](Get-MgBetaDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgBetaDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemListItemDocumentSetVersion](Get-MgBetaDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveItemListItemDocumentSetVersionCount](Get-MgBetaDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemListItemDocumentSetVersionField](Get-MgBetaDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveItemListItemDriveItem](Get-MgBetaDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveItemListItemDriveItemContent](Get-MgBetaDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemListItemField](Get-MgBetaDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveItemListItemVersion](Get-MgBetaDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveItemListItemVersionCount](Get-MgBetaDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemListItemVersionField](Get-MgBetaDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveItemPermission](Get-MgBetaDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveItemPermissionCount](Get-MgBetaDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemRetentionLabel](Get-MgBetaDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaDriveItemSubscription](Get-MgBetaDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaDriveItemSubscriptionCount](Get-MgBetaDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemThumbnail](Get-MgBetaDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaDriveItemThumbnailCount](Get-MgBetaDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaDriveItemVersion](Get-MgBetaDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveItemVersionContent](Get-MgBetaDriveItemVersionContent.md)
Get content for the navigation property versions from drives

### [Get-MgBetaDriveItemVersionCount](Get-MgBetaDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveLastModifiedByUser](Get-MgBetaDriveLastModifiedByUser.md)
Get lastModifiedByUser from drives

### [Get-MgBetaDriveLastModifiedByUserMailboxSetting](Get-MgBetaDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveLastModifiedByUserServiceProvisioningError](Get-MgBetaDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveList](Get-MgBetaDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaDriveListActivity](Get-MgBetaDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaDriveListColumn](Get-MgBetaDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgBetaDriveListColumnCount](Get-MgBetaDriveListColumnCount.md)
Get the number of the resource

### [Get-MgBetaDriveListColumnSourceColumn](Get-MgBetaDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaDriveListContentType](Get-MgBetaDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgBetaDriveListContentTypeColumn](Get-MgBetaDriveListContentTypeColumn.md)
Retrieve the metadata for a site][], [list][] or [contentType][] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveListContentTypeColumnCount](Get-MgBetaDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgBetaDriveListContentTypeColumnLink](Get-MgBetaDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaDriveListContentTypeColumnLinkCount](Get-MgBetaDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgBetaDriveListContentTypeColumnPosition](Get-MgBetaDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaDriveListContentTypeColumnPositionCount](Get-MgBetaDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgBetaDriveListContentTypeColumnSourceColumn](Get-MgBetaDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaDriveListContentTypeCompatibleHubContentType](Get-MgBetaDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaDriveListContentTypeCount](Get-MgBetaDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgBetaDriveListCreatedByUser](Get-MgBetaDriveListCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveListCreatedByUserMailboxSetting](Get-MgBetaDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveListCreatedByUserServiceProvisioningError](Get-MgBetaDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveListDrive](Get-MgBetaDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgBetaDriveListItem](Get-MgBetaDriveListItem.md)
Returns the metadata for an item][] in a [list][].
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveListItemActivity](Get-MgBetaDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveListItemActivityByInterval](Get-MgBetaDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveListItemAnalytic](Get-MgBetaDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaDriveListItemCount](Get-MgBetaDriveListItemCount.md)
Get the number of the resource

### [Get-MgBetaDriveListItemCreatedByUser](Get-MgBetaDriveListItemCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveListItemCreatedByUserMailboxSetting](Get-MgBetaDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveListItemCreatedByUserServiceProvisioningError](Get-MgBetaDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveListItemDelta](Get-MgBetaDriveListItemDelta.md)
Invoke function delta

### [Get-MgBetaDriveListItemDocumentSetVersion](Get-MgBetaDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveListItemDocumentSetVersionCount](Get-MgBetaDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveListItemDocumentSetVersionField](Get-MgBetaDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveListItemDriveItem](Get-MgBetaDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveListItemDriveItemContent](Get-MgBetaDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveListItemField](Get-MgBetaDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveListItemVersion](Get-MgBetaDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveListItemVersionCount](Get-MgBetaDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveListItemVersionField](Get-MgBetaDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveListOperation](Get-MgBetaDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgBetaDriveListOperationCount](Get-MgBetaDriveListOperationCount.md)
Get the number of the resource

### [Get-MgBetaDriveListSubscription](Get-MgBetaDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaDriveListSubscriptionCount](Get-MgBetaDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaDriveRoot](Get-MgBetaDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveRootActivity](Get-MgBetaDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveRootActivityByInterval](Get-MgBetaDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveRootAnalytic](Get-MgBetaDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaDriveRootAnalyticItemActivityStat](Get-MgBetaDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgBetaDriveRootAnalyticItemActivityStatActivity](Get-MgBetaDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaDriveRootAnalyticItemActivityStatCount](Get-MgBetaDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootAnalyticLastSevenDay](Get-MgBetaDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgBetaDriveRootAnalyticTime](Get-MgBetaDriveRootAnalyticTime.md)
Get allTime from drives

### [Get-MgBetaDriveRootChild](Get-MgBetaDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaDriveRootChildContent](Get-MgBetaDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootChildCount](Get-MgBetaDriveRootChildCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootContent](Get-MgBetaDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootCreatedByUser](Get-MgBetaDriveRootCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveRootCreatedByUserMailboxSetting](Get-MgBetaDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveRootCreatedByUserServiceProvisioningError](Get-MgBetaDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootDelta](Get-MgBetaDriveRootDelta.md)
Invoke function delta

### [Get-MgBetaDriveRootItemLastModifiedByUser](Get-MgBetaDriveRootItemLastModifiedByUser.md)
Get lastModifiedByUser from drives

### [Get-MgBetaDriveRootItemLastModifiedByUserMailboxSetting](Get-MgBetaDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgBetaDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootLastModifiedByUser](Get-MgBetaDriveRootLastModifiedByUser.md)
Get lastModifiedByUser from drives

### [Get-MgBetaDriveRootLastModifiedByUserMailboxSetting](Get-MgBetaDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveRootLastModifiedByUserServiceProvisioningError](Get-MgBetaDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootListItem](Get-MgBetaDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaDriveRootListItemActivity](Get-MgBetaDriveRootListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveRootListItemActivityByInterval](Get-MgBetaDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveRootListItemAnalytic](Get-MgBetaDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaDriveRootListItemCreatedByUser](Get-MgBetaDriveRootListItemCreatedByUser.md)
Get createdByUser from drives

### [Get-MgBetaDriveRootListItemCreatedByUserMailboxSetting](Get-MgBetaDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgBetaDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootListItemDocumentSetVersion](Get-MgBetaDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveRootListItemDocumentSetVersionCount](Get-MgBetaDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootListItemDocumentSetVersionField](Get-MgBetaDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveRootListItemDriveItem](Get-MgBetaDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveRootListItemDriveItemContent](Get-MgBetaDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootListItemField](Get-MgBetaDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveRootListItemVersion](Get-MgBetaDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveRootListItemVersionCount](Get-MgBetaDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootListItemVersionField](Get-MgBetaDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveRootPermission](Get-MgBetaDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveRootPermissionCount](Get-MgBetaDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootRetentionLabel](Get-MgBetaDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaDriveRootSubscription](Get-MgBetaDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaDriveRootSubscriptionCount](Get-MgBetaDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootThumbnail](Get-MgBetaDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaDriveRootThumbnailCount](Get-MgBetaDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaDriveRootVersion](Get-MgBetaDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveRootVersionContent](Get-MgBetaDriveRootVersionContent.md)
Get content for the navigation property versions from drives

### [Get-MgBetaDriveRootVersionCount](Get-MgBetaDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgBetaDriveSpecial](Get-MgBetaDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.
This API is available in the following national cloud deployments.

### [Get-MgBetaDriveSpecialContent](Get-MgBetaDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveSpecialCount](Get-MgBetaDriveSpecialCount.md)
Get the number of the resource

### [Get-MgBetaGroupDefaultDrive](Get-MgBetaGroupDefaultDrive.md)
The group's default drive.
Read-only.

### [Get-MgBetaGroupDrive](Get-MgBetaGroupDrive.md)
The group's drives.
Read-only.

### [Get-MgBetaGroupDriveActivity](Get-MgBetaGroupDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveBundle](Get-MgBetaGroupDriveBundle.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveBundleContent](Get-MgBetaGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveBundleCount](Get-MgBetaGroupDriveBundleCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveContentTypeBase](Get-MgBetaGroupDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaGroupDriveContentTypeBaseType](Get-MgBetaGroupDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaGroupDriveContentTypeBaseTypeCount](Get-MgBetaGroupDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveCount](Get-MgBetaGroupDriveCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveCreatedByUser](Get-MgBetaGroupDriveCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveCreatedByUserMailboxSetting](Get-MgBetaGroupDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveFollowing](Get-MgBetaGroupDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaGroupDriveFollowingContent](Get-MgBetaGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveFollowingCount](Get-MgBetaGroupDriveFollowingCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItem](Get-MgBetaGroupDriveItem.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveItemActivity](Get-MgBetaGroupDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveItemAnalytic](Get-MgBetaGroupDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveItemAnalyticItemActivityStat](Get-MgBetaGroupDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgBetaGroupDriveItemAnalyticItemActivityStatActivity](Get-MgBetaGroupDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaGroupDriveItemAnalyticItemActivityStatCount](Get-MgBetaGroupDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemAnalyticLastSevenDay](Get-MgBetaGroupDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgBetaGroupDriveItemAnalyticTime](Get-MgBetaGroupDriveItemAnalyticTime.md)
Get allTime from groups

### [Get-MgBetaGroupDriveItemChild](Get-MgBetaGroupDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemChildContent](Get-MgBetaGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemChildCount](Get-MgBetaGroupDriveItemChildCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemContent](Get-MgBetaGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemCount](Get-MgBetaGroupDriveItemCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemCreatedByUser](Get-MgBetaGroupDriveItemCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveItemCreatedByUserMailboxSetting](Get-MgBetaGroupDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveItemCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemItemLastModifiedByUser](Get-MgBetaGroupDriveItemItemLastModifiedByUser.md)
Get lastModifiedByUser from groups

### [Get-MgBetaGroupDriveItemItemLastModifiedByUserMailboxSetting](Get-MgBetaGroupDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgBetaGroupDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemLastModifiedByUser](Get-MgBetaGroupDriveItemLastModifiedByUser.md)
Get lastModifiedByUser from groups

### [Get-MgBetaGroupDriveItemLastModifiedByUserMailboxSetting](Get-MgBetaGroupDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveItemLastModifiedByUserServiceProvisioningError](Get-MgBetaGroupDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemListItem](Get-MgBetaGroupDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemListItemActivity](Get-MgBetaGroupDriveItemListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveItemListItemAnalytic](Get-MgBetaGroupDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveItemListItemCreatedByUser](Get-MgBetaGroupDriveItemListItemCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveItemListItemCreatedByUserMailboxSetting](Get-MgBetaGroupDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemListItemDocumentSetVersion](Get-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveItemListItemDocumentSetVersionCount](Get-MgBetaGroupDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemListItemDocumentSetVersionField](Get-MgBetaGroupDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveItemListItemDriveItem](Get-MgBetaGroupDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveItemListItemDriveItemContent](Get-MgBetaGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemListItemField](Get-MgBetaGroupDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveItemListItemVersion](Get-MgBetaGroupDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveItemListItemVersionCount](Get-MgBetaGroupDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemListItemVersionField](Get-MgBetaGroupDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveItemPermission](Get-MgBetaGroupDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveItemPermissionCount](Get-MgBetaGroupDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemRetentionLabel](Get-MgBetaGroupDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaGroupDriveItemSubscription](Get-MgBetaGroupDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaGroupDriveItemSubscriptionCount](Get-MgBetaGroupDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemThumbnail](Get-MgBetaGroupDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemThumbnailCount](Get-MgBetaGroupDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveItemVersion](Get-MgBetaGroupDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveItemVersionContent](Get-MgBetaGroupDriveItemVersionContent.md)
Get content for the navigation property versions from groups

### [Get-MgBetaGroupDriveItemVersionCount](Get-MgBetaGroupDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveLastModifiedByUser](Get-MgBetaGroupDriveLastModifiedByUser.md)
Get lastModifiedByUser from groups

### [Get-MgBetaGroupDriveLastModifiedByUserMailboxSetting](Get-MgBetaGroupDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveLastModifiedByUserServiceProvisioningError](Get-MgBetaGroupDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveList](Get-MgBetaGroupDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveListActivity](Get-MgBetaGroupDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaGroupDriveListColumn](Get-MgBetaGroupDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgBetaGroupDriveListColumnCount](Get-MgBetaGroupDriveListColumnCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListColumnSourceColumn](Get-MgBetaGroupDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaGroupDriveListContentType](Get-MgBetaGroupDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgBetaGroupDriveListContentTypeColumn](Get-MgBetaGroupDriveListContentTypeColumn.md)
Retrieve the metadata for a site][], [list][] or [contentType][] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveListContentTypeColumnCount](Get-MgBetaGroupDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListContentTypeColumnLink](Get-MgBetaGroupDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaGroupDriveListContentTypeColumnLinkCount](Get-MgBetaGroupDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListContentTypeColumnPosition](Get-MgBetaGroupDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaGroupDriveListContentTypeColumnPositionCount](Get-MgBetaGroupDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListContentTypeColumnSourceColumn](Get-MgBetaGroupDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaGroupDriveListContentTypeCount](Get-MgBetaGroupDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListCreatedByUser](Get-MgBetaGroupDriveListCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveListCreatedByUserMailboxSetting](Get-MgBetaGroupDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveListCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListDrive](Get-MgBetaGroupDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgBetaGroupDriveListItem](Get-MgBetaGroupDriveListItem.md)
Returns the metadata for an item][] in a [list][].
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveListItemActivity](Get-MgBetaGroupDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveListItemAnalytic](Get-MgBetaGroupDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveListItemCreatedByUser](Get-MgBetaGroupDriveListItemCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveListItemCreatedByUserMailboxSetting](Get-MgBetaGroupDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveListItemCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListItemDocumentSetVersion](Get-MgBetaGroupDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveListItemDocumentSetVersionCount](Get-MgBetaGroupDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListItemDocumentSetVersionField](Get-MgBetaGroupDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveListItemDriveItem](Get-MgBetaGroupDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveListItemDriveItemContent](Get-MgBetaGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveListItemField](Get-MgBetaGroupDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveListItemVersion](Get-MgBetaGroupDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveListItemVersionCount](Get-MgBetaGroupDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListItemVersionField](Get-MgBetaGroupDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveListOperation](Get-MgBetaGroupDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgBetaGroupDriveListOperationCount](Get-MgBetaGroupDriveListOperationCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveListSubscription](Get-MgBetaGroupDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaGroupDriveListSubscriptionCount](Get-MgBetaGroupDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRoot](Get-MgBetaGroupDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveRootActivity](Get-MgBetaGroupDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveRootAnalytic](Get-MgBetaGroupDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaGroupDriveRootAnalyticItemActivityStat](Get-MgBetaGroupDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgBetaGroupDriveRootAnalyticItemActivityStatActivity](Get-MgBetaGroupDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaGroupDriveRootAnalyticItemActivityStatCount](Get-MgBetaGroupDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootAnalyticLastSevenDay](Get-MgBetaGroupDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgBetaGroupDriveRootAnalyticTime](Get-MgBetaGroupDriveRootAnalyticTime.md)
Get allTime from groups

### [Get-MgBetaGroupDriveRootChild](Get-MgBetaGroupDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootChildContent](Get-MgBetaGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootChildCount](Get-MgBetaGroupDriveRootChildCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootContent](Get-MgBetaGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootCreatedByUser](Get-MgBetaGroupDriveRootCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveRootCreatedByUserMailboxSetting](Get-MgBetaGroupDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveRootCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootItemLastModifiedByUser](Get-MgBetaGroupDriveRootItemLastModifiedByUser.md)
Get lastModifiedByUser from groups

### [Get-MgBetaGroupDriveRootItemLastModifiedByUserMailboxSetting](Get-MgBetaGroupDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgBetaGroupDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootLastModifiedByUser](Get-MgBetaGroupDriveRootLastModifiedByUser.md)
Get lastModifiedByUser from groups

### [Get-MgBetaGroupDriveRootLastModifiedByUserMailboxSetting](Get-MgBetaGroupDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveRootLastModifiedByUserServiceProvisioningError](Get-MgBetaGroupDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootListItem](Get-MgBetaGroupDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootListItemActivity](Get-MgBetaGroupDriveRootListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveRootListItemAnalytic](Get-MgBetaGroupDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveRootListItemCreatedByUser](Get-MgBetaGroupDriveRootListItemCreatedByUser.md)
Get createdByUser from groups

### [Get-MgBetaGroupDriveRootListItemCreatedByUserMailboxSetting](Get-MgBetaGroupDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaGroupDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgBetaGroupDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaGroupDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaGroupDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootListItemDocumentSetVersion](Get-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveRootListItemDocumentSetVersionCount](Get-MgBetaGroupDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootListItemDocumentSetVersionField](Get-MgBetaGroupDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveRootListItemDriveItem](Get-MgBetaGroupDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveRootListItemDriveItemContent](Get-MgBetaGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootListItemField](Get-MgBetaGroupDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveRootListItemVersion](Get-MgBetaGroupDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveRootListItemVersionCount](Get-MgBetaGroupDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootListItemVersionField](Get-MgBetaGroupDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveRootPermission](Get-MgBetaGroupDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveRootPermissionCount](Get-MgBetaGroupDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootRetentionLabel](Get-MgBetaGroupDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaGroupDriveRootSubscription](Get-MgBetaGroupDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaGroupDriveRootSubscriptionCount](Get-MgBetaGroupDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootThumbnail](Get-MgBetaGroupDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootThumbnailCount](Get-MgBetaGroupDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveRootVersion](Get-MgBetaGroupDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveRootVersionContent](Get-MgBetaGroupDriveRootVersionContent.md)
Get content for the navigation property versions from groups

### [Get-MgBetaGroupDriveRootVersionCount](Get-MgBetaGroupDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgBetaGroupDriveSpecial](Get-MgBetaGroupDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.
This API is available in the following national cloud deployments.

### [Get-MgBetaGroupDriveSpecialContent](Get-MgBetaGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveSpecialCount](Get-MgBetaGroupDriveSpecialCount.md)
Get the number of the resource

### [Get-MgBetaShareContentTypeBase](Get-MgBetaShareContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaShareContentTypeBaseType](Get-MgBetaShareContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaShareContentTypeBaseTypeCount](Get-MgBetaShareContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgBetaShareCount](Get-MgBetaShareCount.md)
Get the number of the resource

### [Get-MgBetaShareCreatedByUser](Get-MgBetaShareCreatedByUser.md)
Get createdByUser from shares

### [Get-MgBetaShareCreatedByUserMailboxSetting](Get-MgBetaShareCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaShareCreatedByUserServiceProvisioningError](Get-MgBetaShareCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaShareCreatedByUserServiceProvisioningErrorCount](Get-MgBetaShareCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaShareDriveItem](Get-MgBetaShareDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a shareId or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.
This API is available in the following national cloud deployments.

### [Get-MgBetaShareDriveItemContent](Get-MgBetaShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareItem](Get-MgBetaShareItem.md)
All driveItems contained in the sharing root.
This collection cannot be enumerated.

### [Get-MgBetaShareItemContent](Get-MgBetaShareItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareItemCount](Get-MgBetaShareItemCount.md)
Get the number of the resource

### [Get-MgBetaShareItemLastModifiedByUser](Get-MgBetaShareItemLastModifiedByUser.md)
Get lastModifiedByUser from shares

### [Get-MgBetaShareItemLastModifiedByUserMailboxSetting](Get-MgBetaShareItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaShareItemLastModifiedByUserServiceProvisioningError](Get-MgBetaShareItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaShareItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaShareItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaShareLastModifiedByUser](Get-MgBetaShareLastModifiedByUser.md)
Get lastModifiedByUser from shares

### [Get-MgBetaShareLastModifiedByUserMailboxSetting](Get-MgBetaShareLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaShareLastModifiedByUserServiceProvisioningError](Get-MgBetaShareLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaShareLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaShareLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaShareList](Get-MgBetaShareList.md)
Used to access the underlying list

### [Get-MgBetaShareListActivity](Get-MgBetaShareListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaShareListColumn](Get-MgBetaShareListColumn.md)
The collection of field definitions for this list.

### [Get-MgBetaShareListColumnCount](Get-MgBetaShareListColumnCount.md)
Get the number of the resource

### [Get-MgBetaShareListColumnSourceColumn](Get-MgBetaShareListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaShareListContentType](Get-MgBetaShareListContentType.md)
The collection of content types present in this list.

### [Get-MgBetaShareListContentTypeColumn](Get-MgBetaShareListContentTypeColumn.md)
Retrieve the metadata for a site][], [list][] or [contentType][] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Get-MgBetaShareListContentTypeColumnCount](Get-MgBetaShareListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgBetaShareListContentTypeColumnLink](Get-MgBetaShareListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaShareListContentTypeColumnLinkCount](Get-MgBetaShareListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgBetaShareListContentTypeColumnPosition](Get-MgBetaShareListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaShareListContentTypeColumnPositionCount](Get-MgBetaShareListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgBetaShareListContentTypeColumnSourceColumn](Get-MgBetaShareListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaShareListContentTypeCompatibleHubContentType](Get-MgBetaShareListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaShareListContentTypeCount](Get-MgBetaShareListContentTypeCount.md)
Get the number of the resource

### [Get-MgBetaShareListCreatedByUser](Get-MgBetaShareListCreatedByUser.md)
Get createdByUser from shares

### [Get-MgBetaShareListCreatedByUserMailboxSetting](Get-MgBetaShareListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaShareListCreatedByUserServiceProvisioningError](Get-MgBetaShareListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaShareListCreatedByUserServiceProvisioningErrorCount](Get-MgBetaShareListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaShareListDrive](Get-MgBetaShareListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgBetaShareListItem](Get-MgBetaShareListItem.md)
Used to access the underlying listItem

### [Get-MgBetaShareListItemActivity](Get-MgBetaShareListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaShareListItemActivityByInterval](Get-MgBetaShareListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaShareListItemAnalytic](Get-MgBetaShareListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaShareListItemCreatedByUser](Get-MgBetaShareListItemCreatedByUser.md)
Get createdByUser from shares

### [Get-MgBetaShareListItemCreatedByUserMailboxSetting](Get-MgBetaShareListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaShareListItemCreatedByUserServiceProvisioningError](Get-MgBetaShareListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaShareListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaShareListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaShareListItemDelta](Get-MgBetaShareListItemDelta.md)
Invoke function delta

### [Get-MgBetaShareListItemDocumentSetVersion](Get-MgBetaShareListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaShareListItemDocumentSetVersionCount](Get-MgBetaShareListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaShareListItemDocumentSetVersionField](Get-MgBetaShareListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaShareListItemDriveItem](Get-MgBetaShareListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaShareListItemDriveItemContent](Get-MgBetaShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareListItemField](Get-MgBetaShareListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaShareListItemVersion](Get-MgBetaShareListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaShareListItemVersionCount](Get-MgBetaShareListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaShareListItemVersionField](Get-MgBetaShareListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaShareListOperation](Get-MgBetaShareListOperation.md)
The collection of long-running operations on the list.

### [Get-MgBetaShareListOperationCount](Get-MgBetaShareListOperationCount.md)
Get the number of the resource

### [Get-MgBetaShareListSubscription](Get-MgBetaShareListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaShareListSubscriptionCount](Get-MgBetaShareListSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaSharePermission](Get-MgBetaSharePermission.md)
Used to access the permission representing the underlying sharing link

### [Get-MgBetaShareRoot](Get-MgBetaShareRoot.md)
Get root from shares

### [Get-MgBetaShareRootContent](Get-MgBetaShareRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareSharedDriveItemSharedDriveItem](Get-MgBetaShareSharedDriveItemSharedDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a shareId or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.
This API is available in the following national cloud deployments.

### [Get-MgBetaShareSite](Get-MgBetaShareSite.md)
Used to access the underlying site

### [Get-MgBetaUserDefaultDrive](Get-MgBetaUserDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDrive](Get-MgBetaUserDrive.md)
A collection of drives available for this user.
Read-only.

### [Get-MgBetaUserDriveActivity](Get-MgBetaUserDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveBundle](Get-MgBetaUserDriveBundle.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveBundleContent](Get-MgBetaUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveBundleCount](Get-MgBetaUserDriveBundleCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveContentTypeBase](Get-MgBetaUserDriveContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaUserDriveContentTypeBaseType](Get-MgBetaUserDriveContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaUserDriveContentTypeBaseTypeCount](Get-MgBetaUserDriveContentTypeBaseTypeCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveCount](Get-MgBetaUserDriveCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveCreatedByUser](Get-MgBetaUserDriveCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveCreatedByUserMailboxSetting](Get-MgBetaUserDriveCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveFollowing](Get-MgBetaUserDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaUserDriveFollowingContent](Get-MgBetaUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveFollowingCount](Get-MgBetaUserDriveFollowingCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItem](Get-MgBetaUserDriveItem.md)
Retrieve the metadata for a bundle][] based on the unique ID of the bundle.
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveItemActivity](Get-MgBetaUserDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveItemAnalytic](Get-MgBetaUserDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveItemAnalyticItemActivityStat](Get-MgBetaUserDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgBetaUserDriveItemAnalyticItemActivityStatActivity](Get-MgBetaUserDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaUserDriveItemAnalyticItemActivityStatCount](Get-MgBetaUserDriveItemAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemAnalyticLastSevenDay](Get-MgBetaUserDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgBetaUserDriveItemAnalyticTime](Get-MgBetaUserDriveItemAnalyticTime.md)
Get allTime from users

### [Get-MgBetaUserDriveItemChild](Get-MgBetaUserDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemChildContent](Get-MgBetaUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemChildCount](Get-MgBetaUserDriveItemChildCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemContent](Get-MgBetaUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemCount](Get-MgBetaUserDriveItemCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemCreatedByUser](Get-MgBetaUserDriveItemCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveItemCreatedByUserMailboxSetting](Get-MgBetaUserDriveItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveItemCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemItemLastModifiedByUser](Get-MgBetaUserDriveItemItemLastModifiedByUser.md)
Get lastModifiedByUser from users

### [Get-MgBetaUserDriveItemItemLastModifiedByUserMailboxSetting](Get-MgBetaUserDriveItemItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveItemItemLastModifiedByUserServiceProvisioningError](Get-MgBetaUserDriveItemItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveItemItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveItemItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemLastModifiedByUser](Get-MgBetaUserDriveItemLastModifiedByUser.md)
Get lastModifiedByUser from users

### [Get-MgBetaUserDriveItemLastModifiedByUserMailboxSetting](Get-MgBetaUserDriveItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveItemLastModifiedByUserServiceProvisioningError](Get-MgBetaUserDriveItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemListItem](Get-MgBetaUserDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemListItemActivity](Get-MgBetaUserDriveItemListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveItemListItemAnalytic](Get-MgBetaUserDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveItemListItemCreatedByUser](Get-MgBetaUserDriveItemListItemCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveItemListItemCreatedByUserMailboxSetting](Get-MgBetaUserDriveItemListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveItemListItemCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveItemListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveItemListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveItemListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemListItemDocumentSetVersion](Get-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveItemListItemDocumentSetVersionCount](Get-MgBetaUserDriveItemListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemListItemDocumentSetVersionField](Get-MgBetaUserDriveItemListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveItemListItemDriveItem](Get-MgBetaUserDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveItemListItemDriveItemContent](Get-MgBetaUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemListItemField](Get-MgBetaUserDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveItemListItemVersion](Get-MgBetaUserDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveItemListItemVersionCount](Get-MgBetaUserDriveItemListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemListItemVersionField](Get-MgBetaUserDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveItemPermission](Get-MgBetaUserDriveItemPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveItemPermissionCount](Get-MgBetaUserDriveItemPermissionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemRetentionLabel](Get-MgBetaUserDriveItemRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaUserDriveItemSubscription](Get-MgBetaUserDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaUserDriveItemSubscriptionCount](Get-MgBetaUserDriveItemSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemThumbnail](Get-MgBetaUserDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemThumbnailCount](Get-MgBetaUserDriveItemThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveItemVersion](Get-MgBetaUserDriveItemVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveItemVersionContent](Get-MgBetaUserDriveItemVersionContent.md)
Get content for the navigation property versions from users

### [Get-MgBetaUserDriveItemVersionCount](Get-MgBetaUserDriveItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveLastModifiedByUser](Get-MgBetaUserDriveLastModifiedByUser.md)
Get lastModifiedByUser from users

### [Get-MgBetaUserDriveLastModifiedByUserMailboxSetting](Get-MgBetaUserDriveLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveLastModifiedByUserServiceProvisioningError](Get-MgBetaUserDriveLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveList](Get-MgBetaUserDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaUserDriveListActivity](Get-MgBetaUserDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaUserDriveListColumn](Get-MgBetaUserDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgBetaUserDriveListColumnCount](Get-MgBetaUserDriveListColumnCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListColumnSourceColumn](Get-MgBetaUserDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaUserDriveListContentType](Get-MgBetaUserDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgBetaUserDriveListContentTypeColumn](Get-MgBetaUserDriveListContentTypeColumn.md)
Retrieve the metadata for a site][], [list][] or [contentType][] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveListContentTypeColumnCount](Get-MgBetaUserDriveListContentTypeColumnCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListContentTypeColumnLink](Get-MgBetaUserDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaUserDriveListContentTypeColumnLinkCount](Get-MgBetaUserDriveListContentTypeColumnLinkCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListContentTypeColumnPosition](Get-MgBetaUserDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaUserDriveListContentTypeColumnPositionCount](Get-MgBetaUserDriveListContentTypeColumnPositionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListContentTypeColumnSourceColumn](Get-MgBetaUserDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaUserDriveListContentTypeCount](Get-MgBetaUserDriveListContentTypeCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListCreatedByUser](Get-MgBetaUserDriveListCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveListCreatedByUserMailboxSetting](Get-MgBetaUserDriveListCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveListCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveListCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveListCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveListCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListDrive](Get-MgBetaUserDriveListDrive.md)
Allows access to the list as a drive resource with driveItems.
Only present on document libraries.

### [Get-MgBetaUserDriveListItem](Get-MgBetaUserDriveListItem.md)
Returns the metadata for an item][] in a [list][].
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveListItemActivity](Get-MgBetaUserDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveListItemAnalytic](Get-MgBetaUserDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveListItemCreatedByUser](Get-MgBetaUserDriveListItemCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveListItemCreatedByUserMailboxSetting](Get-MgBetaUserDriveListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveListItemCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListItemDocumentSetVersion](Get-MgBetaUserDriveListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveListItemDocumentSetVersionCount](Get-MgBetaUserDriveListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListItemDocumentSetVersionField](Get-MgBetaUserDriveListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveListItemDriveItem](Get-MgBetaUserDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveListItemDriveItemContent](Get-MgBetaUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveListItemField](Get-MgBetaUserDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveListItemVersion](Get-MgBetaUserDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveListItemVersionCount](Get-MgBetaUserDriveListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListItemVersionField](Get-MgBetaUserDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveListOperation](Get-MgBetaUserDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgBetaUserDriveListOperationCount](Get-MgBetaUserDriveListOperationCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveListSubscription](Get-MgBetaUserDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaUserDriveListSubscriptionCount](Get-MgBetaUserDriveListSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRoot](Get-MgBetaUserDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveRootActivity](Get-MgBetaUserDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveRootAnalytic](Get-MgBetaUserDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe itemAnalytics resource is a convenient way to get activity stats for allTime and the lastSevenDays.\nFor a custom time range or interval, use the getActivitiesByInterval][] API.
This API is available in the following [national cloud deployments.

### [Get-MgBetaUserDriveRootAnalyticItemActivityStat](Get-MgBetaUserDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgBetaUserDriveRootAnalyticItemActivityStatActivity](Get-MgBetaUserDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgBetaUserDriveRootAnalyticItemActivityStatCount](Get-MgBetaUserDriveRootAnalyticItemActivityStatCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootAnalyticLastSevenDay](Get-MgBetaUserDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgBetaUserDriveRootAnalyticTime](Get-MgBetaUserDriveRootAnalyticTime.md)
Get allTime from users

### [Get-MgBetaUserDriveRootChild](Get-MgBetaUserDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootChildContent](Get-MgBetaUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootChildCount](Get-MgBetaUserDriveRootChildCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootContent](Get-MgBetaUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootCreatedByUser](Get-MgBetaUserDriveRootCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveRootCreatedByUserMailboxSetting](Get-MgBetaUserDriveRootCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveRootCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveRootCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveRootCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveRootCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootItemLastModifiedByUser](Get-MgBetaUserDriveRootItemLastModifiedByUser.md)
Get lastModifiedByUser from users

### [Get-MgBetaUserDriveRootItemLastModifiedByUserMailboxSetting](Get-MgBetaUserDriveRootItemLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveRootItemLastModifiedByUserServiceProvisioningError](Get-MgBetaUserDriveRootItemLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveRootItemLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveRootItemLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootLastModifiedByUser](Get-MgBetaUserDriveRootLastModifiedByUser.md)
Get lastModifiedByUser from users

### [Get-MgBetaUserDriveRootLastModifiedByUserMailboxSetting](Get-MgBetaUserDriveRootLastModifiedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveRootLastModifiedByUserServiceProvisioningError](Get-MgBetaUserDriveRootLastModifiedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveRootLastModifiedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveRootLastModifiedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootListItem](Get-MgBetaUserDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootListItemActivity](Get-MgBetaUserDriveRootListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveRootListItemAnalytic](Get-MgBetaUserDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveRootListItemCreatedByUser](Get-MgBetaUserDriveRootListItemCreatedByUser.md)
Get createdByUser from users

### [Get-MgBetaUserDriveRootListItemCreatedByUserMailboxSetting](Get-MgBetaUserDriveRootListItemCreatedByUserMailboxSetting.md)
Settings for the primary mailbox of the signed-in user.
You can get or update settings for sending automatic replies to incoming messages, locale, and time zone.
For more information, see User preferences for languages and regional formats.
Returned only on $select.

### [Get-MgBetaUserDriveRootListItemCreatedByUserServiceProvisioningError](Get-MgBetaUserDriveRootListItemCreatedByUserServiceProvisioningError.md)
Errors published by a federated service describing a nontransient, service-specific error regarding the properties or link from a user object.
Supports $filter (eq, not, for isResolved and serviceInstance).

### [Get-MgBetaUserDriveRootListItemCreatedByUserServiceProvisioningErrorCount](Get-MgBetaUserDriveRootListItemCreatedByUserServiceProvisioningErrorCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootListItemDocumentSetVersion](Get-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Read the properties and relationships of a documentSetVersion object.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveRootListItemDocumentSetVersionCount](Get-MgBetaUserDriveRootListItemDocumentSetVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootListItemDocumentSetVersionField](Get-MgBetaUserDriveRootListItemDocumentSetVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveRootListItemDriveItem](Get-MgBetaUserDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveRootListItemDriveItemContent](Get-MgBetaUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootListItemField](Get-MgBetaUserDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveRootListItemVersion](Get-MgBetaUserDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveRootListItemVersionCount](Get-MgBetaUserDriveRootListItemVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootListItemVersionField](Get-MgBetaUserDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveRootPermission](Get-MgBetaUserDriveRootPermission.md)
Return the effective sharing permission for a particular permission resource.
Effective permissions of an item can come from two sources: permissions set directly on the item itself or permissions that are inherited from the item's ancestors.
Callers can differentiate if the permission is inherited or not by checking the inheritedFrom property.\nThis property is an ItemReference resource referencing the ancestor that the permission is inherited from.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveRootPermissionCount](Get-MgBetaUserDriveRootPermissionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootRetentionLabel](Get-MgBetaUserDriveRootRetentionLabel.md)
Information about retention label and settings enforced on the driveItem.
Read-write.

### [Get-MgBetaUserDriveRootSubscription](Get-MgBetaUserDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaUserDriveRootSubscriptionCount](Get-MgBetaUserDriveRootSubscriptionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootThumbnail](Get-MgBetaUserDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootThumbnailCount](Get-MgBetaUserDriveRootThumbnailCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveRootVersion](Get-MgBetaUserDriveRootVersion.md)
Retrieve the metadata for a specific version of a DriveItem.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveRootVersionContent](Get-MgBetaUserDriveRootVersionContent.md)
Get content for the navigation property versions from users

### [Get-MgBetaUserDriveRootVersionCount](Get-MgBetaUserDriveRootVersionCount.md)
Get the number of the resource

### [Get-MgBetaUserDriveSpecial](Get-MgBetaUserDriveSpecial.md)
Use the special collection to access a special folder by name.
Special folders provide simple aliases to access well-known folders in OneDrive without the need to look up the folder by path (which would require localization), or reference the folder with an ID.
If a special folder is renamed or moved to another location within the drive, this syntax will continue to find that folder.
Special folders are automatically created the first time an application attempts to write to one, if it doesn't already exist.
If a user deletes one, it is recreated when written to again.
This API is available in the following national cloud deployments.

### [Get-MgBetaUserDriveSpecialContent](Get-MgBetaUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveSpecialCount](Get-MgBetaUserDriveSpecialCount.md)
Get the number of the resource

### [Grant-MgBetaDriveItemPermission](Grant-MgBetaDriveItemPermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Grant-MgBetaDriveRootPermission](Grant-MgBetaDriveRootPermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Grant-MgBetaSharePermission](Grant-MgBetaSharePermission.md)
Grant users access to a link represented by a permission][].
This API is available in the following [national cloud deployments.

### [Invoke-MgBetaCheckinDriveItem](Invoke-MgBetaCheckinDriveItem.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckinDriveRoot](Invoke-MgBetaCheckinDriveRoot.md)
Check in a checked out driveItem resource, which makes the version of the document available to others.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckoutDriveItem](Invoke-MgBetaCheckoutDriveItem.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaCheckoutDriveRoot](Invoke-MgBetaCheckoutDriveRoot.md)
Check out a driveItem resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaExtractDriveItemSensitivityLabel](Invoke-MgBetaExtractDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractDriveRootSensitivityLabel](Invoke-MgBetaExtractDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaFollowDriveItem](Invoke-MgBetaFollowDriveItem.md)
Follow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaFollowDriveRoot](Invoke-MgBetaFollowDriveRoot.md)
Follow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaGraphDrive](Invoke-MgBetaGraphDrive.md)
Invoke function sharedWithMe

### [Invoke-MgBetaInviteDriveItem](Invoke-MgBetaInviteDriveItem.md)
Sends a sharing invitation for a DriveItem.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaInviteDriveRoot](Invoke-MgBetaInviteDriveRoot.md)
Sends a sharing invitation for a DriveItem.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaPreviewDriveItem](Invoke-MgBetaPreviewDriveItem.md)
Invoke action preview

### [Invoke-MgBetaPreviewDriveRoot](Invoke-MgBetaPreviewDriveRoot.md)
Invoke action preview

### [Invoke-MgBetaReauthorizeDriveItemSubscription](Invoke-MgBetaReauthorizeDriveItemSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeDriveListSubscription](Invoke-MgBetaReauthorizeDriveListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeDriveRootSubscription](Invoke-MgBetaReauthorizeDriveRootSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaReauthorizeShareListSubscription](Invoke-MgBetaReauthorizeShareListSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaRecentDrive](Invoke-MgBetaRecentDrive.md)
Invoke function recent

### [Invoke-MgBetaUnfollowDriveItem](Invoke-MgBetaUnfollowDriveItem.md)
Unfollow a driveItem.
This API is available in the following national cloud deployments.

### [Invoke-MgBetaUnfollowDriveRoot](Invoke-MgBetaUnfollowDriveRoot.md)
Unfollow a driveItem.
This API is available in the following national cloud deployments.

### [Join-MgBetaDriveListContentTypeWithHubSite](Join-MgBetaDriveListContentTypeWithHubSite.md)
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

### [Join-MgBetaShareListContentTypeWithHubSite](Join-MgBetaShareListContentTypeWithHubSite.md)
Associate a content type][contentType] with a list of hub sites.
This API is available in the following [national cloud deployments.

### [New-MgBetaDrive](New-MgBetaDrive.md)
Add new entity to drives

### [New-MgBetaDriveBundle](New-MgBetaDriveBundle.md)
Create new navigation property to bundles for drives

### [New-MgBetaDriveItem](New-MgBetaDriveItem.md)
Create new navigation property to items for drives

### [New-MgBetaDriveItemAnalyticItemActivityStat](New-MgBetaDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for drives

### [New-MgBetaDriveItemChild](New-MgBetaDriveItemChild.md)
Create new navigation property to children for drives

### [New-MgBetaDriveItemLink](New-MgBetaDriveItemLink.md)
You can use createLink action to share a driveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveItemListItemDocumentSetVersion](New-MgBetaDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveItemListItemLink](New-MgBetaDriveItemListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveItemListItemVersion](New-MgBetaDriveItemListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveItemPermission](New-MgBetaDriveItemPermission.md)
Create new navigation property to permissions for drives

### [New-MgBetaDriveItemSubscription](New-MgBetaDriveItemSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveItemThumbnail](New-MgBetaDriveItemThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgBetaDriveItemUploadSession](New-MgBetaDriveItemUploadSession.md)
Invoke action createUploadSession

### [New-MgBetaDriveItemVersion](New-MgBetaDriveItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveListColumn](New-MgBetaDriveListColumn.md)
Create a column for a list][list] with a request that specifies a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaDriveListContentType](New-MgBetaDriveListContentType.md)
Create new navigation property to contentTypes for drives

### [New-MgBetaDriveListContentTypeColumn](New-MgBetaDriveListContentTypeColumn.md)
Add a column to a content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaDriveListContentTypeColumnLink](New-MgBetaDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for drives

### [New-MgBetaDriveListItem](New-MgBetaDriveListItem.md)
Create a new listItem][] in a [list][].
This API is available in the following [national cloud deployments.

### [New-MgBetaDriveListItemDocumentSetVersion](New-MgBetaDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveListItemLink](New-MgBetaDriveListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveListItemVersion](New-MgBetaDriveListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveListOperation](New-MgBetaDriveListOperation.md)
Create new navigation property to operations for drives

### [New-MgBetaDriveListSubscription](New-MgBetaDriveListSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveRootAnalyticItemActivityStat](New-MgBetaDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for drives

### [New-MgBetaDriveRootChild](New-MgBetaDriveRootChild.md)
Create new navigation property to children for drives

### [New-MgBetaDriveRootLink](New-MgBetaDriveRootLink.md)
You can use createLink action to share a driveItem via a sharing link.
The createLink action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveRootListItemDocumentSetVersion](New-MgBetaDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveRootListItemLink](New-MgBetaDriveRootListItemLink.md)
Create a sharing link for a listItem.
The createLink action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
listItem resources inherit sharing permissions from the list the item resides in.
This API is available in the following national cloud deployments.

### [New-MgBetaDriveRootListItemVersion](New-MgBetaDriveRootListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveRootPermission](New-MgBetaDriveRootPermission.md)
Create new navigation property to permissions for drives

### [New-MgBetaDriveRootSubscription](New-MgBetaDriveRootSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveRootThumbnail](New-MgBetaDriveRootThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgBetaDriveRootUploadSession](New-MgBetaDriveRootUploadSession.md)
Invoke action createUploadSession

### [New-MgBetaDriveRootVersion](New-MgBetaDriveRootVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaGroupDrive](New-MgBetaGroupDrive.md)
Create new navigation property to drives for groups

### [New-MgBetaGroupDriveBundle](New-MgBetaGroupDriveBundle.md)
Create new navigation property to bundles for groups

### [New-MgBetaGroupDriveItem](New-MgBetaGroupDriveItem.md)
Create new navigation property to items for groups

### [New-MgBetaGroupDriveItemAnalyticItemActivityStat](New-MgBetaGroupDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for groups

### [New-MgBetaGroupDriveItemChild](New-MgBetaGroupDriveItemChild.md)
Create new navigation property to children for groups

### [New-MgBetaGroupDriveItemListItemDocumentSetVersion](New-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveItemListItemVersion](New-MgBetaGroupDriveItemListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupDriveItemPermission](New-MgBetaGroupDriveItemPermission.md)
Create new navigation property to permissions for groups

### [New-MgBetaGroupDriveItemSubscription](New-MgBetaGroupDriveItemSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgBetaGroupDriveItemThumbnail](New-MgBetaGroupDriveItemThumbnail.md)
Create new navigation property to thumbnails for groups

### [New-MgBetaGroupDriveItemVersion](New-MgBetaGroupDriveItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupDriveListColumn](New-MgBetaGroupDriveListColumn.md)
Create a column for a list][list] with a request that specifies a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaGroupDriveListContentType](New-MgBetaGroupDriveListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgBetaGroupDriveListContentTypeColumn](New-MgBetaGroupDriveListContentTypeColumn.md)
Add a column to a content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaGroupDriveListContentTypeColumnLink](New-MgBetaGroupDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgBetaGroupDriveListItem](New-MgBetaGroupDriveListItem.md)
Create a new listItem][] in a [list][].
This API is available in the following [national cloud deployments.

### [New-MgBetaGroupDriveListItemDocumentSetVersion](New-MgBetaGroupDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveListItemVersion](New-MgBetaGroupDriveListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupDriveListOperation](New-MgBetaGroupDriveListOperation.md)
Create new navigation property to operations for groups

### [New-MgBetaGroupDriveListSubscription](New-MgBetaGroupDriveListSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgBetaGroupDriveRootAnalyticItemActivityStat](New-MgBetaGroupDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for groups

### [New-MgBetaGroupDriveRootChild](New-MgBetaGroupDriveRootChild.md)
Create new navigation property to children for groups

### [New-MgBetaGroupDriveRootListItemDocumentSetVersion](New-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaGroupDriveRootListItemVersion](New-MgBetaGroupDriveRootListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupDriveRootPermission](New-MgBetaGroupDriveRootPermission.md)
Create new navigation property to permissions for groups

### [New-MgBetaGroupDriveRootSubscription](New-MgBetaGroupDriveRootSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgBetaGroupDriveRootThumbnail](New-MgBetaGroupDriveRootThumbnail.md)
Create new navigation property to thumbnails for groups

### [New-MgBetaGroupDriveRootVersion](New-MgBetaGroupDriveRootVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaShareListColumn](New-MgBetaShareListColumn.md)
Create a column for a list][list] with a request that specifies a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaShareListContentType](New-MgBetaShareListContentType.md)
Create new navigation property to contentTypes for shares

### [New-MgBetaShareListContentTypeColumn](New-MgBetaShareListContentTypeColumn.md)
Add a column to a content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaShareListContentTypeColumnLink](New-MgBetaShareListContentTypeColumnLink.md)
Create new navigation property to columnLinks for shares

### [New-MgBetaShareListItem](New-MgBetaShareListItem.md)
Create a new listItem][] in a [list][].
This API is available in the following [national cloud deployments.

### [New-MgBetaShareListItemDocumentSetVersion](New-MgBetaShareListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaShareListItemVersion](New-MgBetaShareListItemVersion.md)
Create new navigation property to versions for shares

### [New-MgBetaShareListOperation](New-MgBetaShareListOperation.md)
Create new navigation property to operations for shares

### [New-MgBetaShareListSubscription](New-MgBetaShareListSubscription.md)
Create new navigation property to subscriptions for shares

### [New-MgBetaShareSharedDriveItemSharedDriveItem](New-MgBetaShareSharedDriveItemSharedDriveItem.md)
Add new entity to shares

### [New-MgBetaUserDrive](New-MgBetaUserDrive.md)
Create new navigation property to drives for users

### [New-MgBetaUserDriveBundle](New-MgBetaUserDriveBundle.md)
Create new navigation property to bundles for users

### [New-MgBetaUserDriveItem](New-MgBetaUserDriveItem.md)
Create new navigation property to items for users

### [New-MgBetaUserDriveItemAnalyticItemActivityStat](New-MgBetaUserDriveItemAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for users

### [New-MgBetaUserDriveItemChild](New-MgBetaUserDriveItemChild.md)
Create new navigation property to children for users

### [New-MgBetaUserDriveItemListItemDocumentSetVersion](New-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaUserDriveItemListItemVersion](New-MgBetaUserDriveItemListItemVersion.md)
Create new navigation property to versions for users

### [New-MgBetaUserDriveItemPermission](New-MgBetaUserDriveItemPermission.md)
Create new navigation property to permissions for users

### [New-MgBetaUserDriveItemSubscription](New-MgBetaUserDriveItemSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgBetaUserDriveItemThumbnail](New-MgBetaUserDriveItemThumbnail.md)
Create new navigation property to thumbnails for users

### [New-MgBetaUserDriveItemVersion](New-MgBetaUserDriveItemVersion.md)
Create new navigation property to versions for users

### [New-MgBetaUserDriveListColumn](New-MgBetaUserDriveListColumn.md)
Create a column for a list][list] with a request that specifies a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaUserDriveListContentType](New-MgBetaUserDriveListContentType.md)
Create new navigation property to contentTypes for users

### [New-MgBetaUserDriveListContentTypeColumn](New-MgBetaUserDriveListContentTypeColumn.md)
Add a column to a content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].
This API is available in the following [national cloud deployments.

### [New-MgBetaUserDriveListContentTypeColumnLink](New-MgBetaUserDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for users

### [New-MgBetaUserDriveListItem](New-MgBetaUserDriveListItem.md)
Create a new listItem][] in a [list][].
This API is available in the following [national cloud deployments.

### [New-MgBetaUserDriveListItemDocumentSetVersion](New-MgBetaUserDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaUserDriveListItemVersion](New-MgBetaUserDriveListItemVersion.md)
Create new navigation property to versions for users

### [New-MgBetaUserDriveListOperation](New-MgBetaUserDriveListOperation.md)
Create new navigation property to operations for users

### [New-MgBetaUserDriveListSubscription](New-MgBetaUserDriveListSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgBetaUserDriveRootAnalyticItemActivityStat](New-MgBetaUserDriveRootAnalyticItemActivityStat.md)
Create new navigation property to itemActivityStats for users

### [New-MgBetaUserDriveRootChild](New-MgBetaUserDriveRootChild.md)
Create new navigation property to children for users

### [New-MgBetaUserDriveRootListItemDocumentSetVersion](New-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.
This API is available in the following national cloud deployments.

### [New-MgBetaUserDriveRootListItemVersion](New-MgBetaUserDriveRootListItemVersion.md)
Create new navigation property to versions for users

### [New-MgBetaUserDriveRootPermission](New-MgBetaUserDriveRootPermission.md)
Create new navigation property to permissions for users

### [New-MgBetaUserDriveRootSubscription](New-MgBetaUserDriveRootSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgBetaUserDriveRootThumbnail](New-MgBetaUserDriveRootThumbnail.md)
Create new navigation property to thumbnails for users

### [New-MgBetaUserDriveRootVersion](New-MgBetaUserDriveRootVersion.md)
Create new navigation property to versions for users

### [Publish-MgBetaDriveListContentType](Publish-MgBetaDriveListContentType.md)
Publishes a contentType][] present in a content type hub site.
This API is available in the following [national cloud deployments.

### [Publish-MgBetaShareListContentType](Publish-MgBetaShareListContentType.md)
Publishes a contentType][] present in a content type hub site.
This API is available in the following [national cloud deployments.

### [Remove-MgBetaDrive](Remove-MgBetaDrive.md)
Delete entity from drives

### [Remove-MgBetaDriveItem](Remove-MgBetaDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveItemAnalytic](Remove-MgBetaDriveItemAnalytic.md)
Delete navigation property analytics for drives

### [Remove-MgBetaDriveItemAnalyticItemActivityStat](Remove-MgBetaDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for drives

### [Remove-MgBetaDriveItemChild](Remove-MgBetaDriveItemChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaDriveItemListItem](Remove-MgBetaDriveItemListItem.md)
Delete navigation property listItem for drives

### [Remove-MgBetaDriveItemListItemDocumentSetVersion](Remove-MgBetaDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveItemListItemDocumentSetVersionField](Remove-MgBetaDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveItemListItemField](Remove-MgBetaDriveItemListItemField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveItemListItemVersion](Remove-MgBetaDriveItemListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveItemListItemVersionField](Remove-MgBetaDriveItemListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveItemPermanent](Remove-MgBetaDriveItemPermanent.md)
Invoke action permanentDelete

### [Remove-MgBetaDriveItemPermission](Remove-MgBetaDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveItemRetentionLabel](Remove-MgBetaDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveItemSubscription](Remove-MgBetaDriveItemSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgBetaDriveItemThumbnail](Remove-MgBetaDriveItemThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgBetaDriveItemVersion](Remove-MgBetaDriveItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveList](Remove-MgBetaDriveList.md)
Delete navigation property list for drives

### [Remove-MgBetaDriveListColumn](Remove-MgBetaDriveListColumn.md)
Delete navigation property columns for drives

### [Remove-MgBetaDriveListContentType](Remove-MgBetaDriveListContentType.md)
Delete navigation property contentTypes for drives

### [Remove-MgBetaDriveListContentTypeColumn](Remove-MgBetaDriveListContentTypeColumn.md)
Remove a column][columndefinition] from a [site][], [list][] or [content type][contentType].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaDriveListContentTypeColumnLink](Remove-MgBetaDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for drives

### [Remove-MgBetaDriveListItem](Remove-MgBetaDriveListItem.md)
Removes an item from a list][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaDriveListItemDocumentSetVersion](Remove-MgBetaDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveListItemDocumentSetVersionField](Remove-MgBetaDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveListItemField](Remove-MgBetaDriveListItemField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveListItemVersion](Remove-MgBetaDriveListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveListItemVersionField](Remove-MgBetaDriveListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveListOperation](Remove-MgBetaDriveListOperation.md)
Delete navigation property operations for drives

### [Remove-MgBetaDriveListSubscription](Remove-MgBetaDriveListSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgBetaDriveRoot](Remove-MgBetaDriveRoot.md)
Delete navigation property root for drives

### [Remove-MgBetaDriveRootAnalytic](Remove-MgBetaDriveRootAnalytic.md)
Delete navigation property analytics for drives

### [Remove-MgBetaDriveRootAnalyticItemActivityStat](Remove-MgBetaDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for drives

### [Remove-MgBetaDriveRootChild](Remove-MgBetaDriveRootChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaDriveRootListItem](Remove-MgBetaDriveRootListItem.md)
Delete navigation property listItem for drives

### [Remove-MgBetaDriveRootListItemDocumentSetVersion](Remove-MgBetaDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveRootListItemDocumentSetVersionField](Remove-MgBetaDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveRootListItemField](Remove-MgBetaDriveRootListItemField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveRootListItemVersion](Remove-MgBetaDriveRootListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveRootListItemVersionField](Remove-MgBetaDriveRootListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveRootPermanent](Remove-MgBetaDriveRootPermanent.md)
Invoke action permanentDelete

### [Remove-MgBetaDriveRootPermission](Remove-MgBetaDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveRootRetentionLabel](Remove-MgBetaDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaDriveRootSubscription](Remove-MgBetaDriveRootSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgBetaDriveRootThumbnail](Remove-MgBetaDriveRootThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgBetaDriveRootVersion](Remove-MgBetaDriveRootVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaGroupDrive](Remove-MgBetaGroupDrive.md)
Delete navigation property drives for groups

### [Remove-MgBetaGroupDriveItem](Remove-MgBetaGroupDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveItemAnalytic](Remove-MgBetaGroupDriveItemAnalytic.md)
Delete navigation property analytics for groups

### [Remove-MgBetaGroupDriveItemAnalyticItemActivityStat](Remove-MgBetaGroupDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for groups

### [Remove-MgBetaGroupDriveItemChild](Remove-MgBetaGroupDriveItemChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaGroupDriveItemListItem](Remove-MgBetaGroupDriveItemListItem.md)
Delete navigation property listItem for groups

### [Remove-MgBetaGroupDriveItemListItemDocumentSetVersion](Remove-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveItemListItemDocumentSetVersionField](Remove-MgBetaGroupDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveItemListItemField](Remove-MgBetaGroupDriveItemListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveItemListItemVersion](Remove-MgBetaGroupDriveItemListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveItemListItemVersionField](Remove-MgBetaGroupDriveItemListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveItemPermission](Remove-MgBetaGroupDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveItemRetentionLabel](Remove-MgBetaGroupDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveItemSubscription](Remove-MgBetaGroupDriveItemSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgBetaGroupDriveItemThumbnail](Remove-MgBetaGroupDriveItemThumbnail.md)
Delete navigation property thumbnails for groups

### [Remove-MgBetaGroupDriveItemVersion](Remove-MgBetaGroupDriveItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveList](Remove-MgBetaGroupDriveList.md)
Delete navigation property list for groups

### [Remove-MgBetaGroupDriveListColumn](Remove-MgBetaGroupDriveListColumn.md)
Delete navigation property columns for groups

### [Remove-MgBetaGroupDriveListContentType](Remove-MgBetaGroupDriveListContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgBetaGroupDriveListContentTypeColumn](Remove-MgBetaGroupDriveListContentTypeColumn.md)
Remove a column][columndefinition] from a [site][], [list][] or [content type][contentType].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaGroupDriveListContentTypeColumnLink](Remove-MgBetaGroupDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgBetaGroupDriveListItem](Remove-MgBetaGroupDriveListItem.md)
Removes an item from a list][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaGroupDriveListItemDocumentSetVersion](Remove-MgBetaGroupDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveListItemDocumentSetVersionField](Remove-MgBetaGroupDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveListItemField](Remove-MgBetaGroupDriveListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveListItemVersion](Remove-MgBetaGroupDriveListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveListItemVersionField](Remove-MgBetaGroupDriveListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveListOperation](Remove-MgBetaGroupDriveListOperation.md)
Delete navigation property operations for groups

### [Remove-MgBetaGroupDriveListSubscription](Remove-MgBetaGroupDriveListSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgBetaGroupDriveRoot](Remove-MgBetaGroupDriveRoot.md)
Delete navigation property root for groups

### [Remove-MgBetaGroupDriveRootAnalytic](Remove-MgBetaGroupDriveRootAnalytic.md)
Delete navigation property analytics for groups

### [Remove-MgBetaGroupDriveRootAnalyticItemActivityStat](Remove-MgBetaGroupDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for groups

### [Remove-MgBetaGroupDriveRootChild](Remove-MgBetaGroupDriveRootChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaGroupDriveRootListItem](Remove-MgBetaGroupDriveRootListItem.md)
Delete navigation property listItem for groups

### [Remove-MgBetaGroupDriveRootListItemDocumentSetVersion](Remove-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveRootListItemDocumentSetVersionField](Remove-MgBetaGroupDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveRootListItemField](Remove-MgBetaGroupDriveRootListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveRootListItemVersion](Remove-MgBetaGroupDriveRootListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveRootListItemVersionField](Remove-MgBetaGroupDriveRootListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveRootPermission](Remove-MgBetaGroupDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveRootRetentionLabel](Remove-MgBetaGroupDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaGroupDriveRootSubscription](Remove-MgBetaGroupDriveRootSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgBetaGroupDriveRootThumbnail](Remove-MgBetaGroupDriveRootThumbnail.md)
Delete navigation property thumbnails for groups

### [Remove-MgBetaGroupDriveRootVersion](Remove-MgBetaGroupDriveRootVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaShareList](Remove-MgBetaShareList.md)
Delete navigation property list for shares

### [Remove-MgBetaShareListColumn](Remove-MgBetaShareListColumn.md)
Delete navigation property columns for shares

### [Remove-MgBetaShareListContentType](Remove-MgBetaShareListContentType.md)
Delete navigation property contentTypes for shares

### [Remove-MgBetaShareListContentTypeColumn](Remove-MgBetaShareListContentTypeColumn.md)
Remove a column][columndefinition] from a [site][], [list][] or [content type][contentType].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaShareListContentTypeColumnLink](Remove-MgBetaShareListContentTypeColumnLink.md)
Delete navigation property columnLinks for shares

### [Remove-MgBetaShareListItem](Remove-MgBetaShareListItem.md)
Delete navigation property listItem for shares

### [Remove-MgBetaShareListItemDocumentSetVersion](Remove-MgBetaShareListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaShareListItemDocumentSetVersionField](Remove-MgBetaShareListItemDocumentSetVersionField.md)
Delete navigation property fields for shares

### [Remove-MgBetaShareListItemField](Remove-MgBetaShareListItemField.md)
Delete navigation property fields for shares

### [Remove-MgBetaShareListItemVersion](Remove-MgBetaShareListItemVersion.md)
Delete navigation property versions for shares

### [Remove-MgBetaShareListItemVersionField](Remove-MgBetaShareListItemVersionField.md)
Delete navigation property fields for shares

### [Remove-MgBetaShareListOperation](Remove-MgBetaShareListOperation.md)
Delete navigation property operations for shares

### [Remove-MgBetaShareListSubscription](Remove-MgBetaShareListSubscription.md)
Delete navigation property subscriptions for shares

### [Remove-MgBetaSharePermission](Remove-MgBetaSharePermission.md)
Delete navigation property permission for shares

### [Remove-MgBetaShareSharedDriveItemSharedDriveItem](Remove-MgBetaShareSharedDriveItemSharedDriveItem.md)
Delete entity from shares

### [Remove-MgBetaUserDrive](Remove-MgBetaUserDrive.md)
Delete navigation property drives for users

### [Remove-MgBetaUserDriveItem](Remove-MgBetaUserDriveItem.md)
Delete a DriveItem by using its ID or path.\nDeleting items using this method moves the items to the recycle bin instead of permanently deleting the item.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveItemAnalytic](Remove-MgBetaUserDriveItemAnalytic.md)
Delete navigation property analytics for users

### [Remove-MgBetaUserDriveItemAnalyticItemActivityStat](Remove-MgBetaUserDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for users

### [Remove-MgBetaUserDriveItemChild](Remove-MgBetaUserDriveItemChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaUserDriveItemListItem](Remove-MgBetaUserDriveItemListItem.md)
Delete navigation property listItem for users

### [Remove-MgBetaUserDriveItemListItemDocumentSetVersion](Remove-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveItemListItemDocumentSetVersionField](Remove-MgBetaUserDriveItemListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveItemListItemField](Remove-MgBetaUserDriveItemListItemField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveItemListItemVersion](Remove-MgBetaUserDriveItemListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveItemListItemVersionField](Remove-MgBetaUserDriveItemListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveItemPermission](Remove-MgBetaUserDriveItemPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveItemRetentionLabel](Remove-MgBetaUserDriveItemRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveItemSubscription](Remove-MgBetaUserDriveItemSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgBetaUserDriveItemThumbnail](Remove-MgBetaUserDriveItemThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgBetaUserDriveItemVersion](Remove-MgBetaUserDriveItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveList](Remove-MgBetaUserDriveList.md)
Delete navigation property list for users

### [Remove-MgBetaUserDriveListColumn](Remove-MgBetaUserDriveListColumn.md)
Delete navigation property columns for users

### [Remove-MgBetaUserDriveListContentType](Remove-MgBetaUserDriveListContentType.md)
Delete navigation property contentTypes for users

### [Remove-MgBetaUserDriveListContentTypeColumn](Remove-MgBetaUserDriveListContentTypeColumn.md)
Remove a column][columndefinition] from a [site][], [list][] or [content type][contentType].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaUserDriveListContentTypeColumnLink](Remove-MgBetaUserDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for users

### [Remove-MgBetaUserDriveListItem](Remove-MgBetaUserDriveListItem.md)
Removes an item from a list][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaUserDriveListItemDocumentSetVersion](Remove-MgBetaUserDriveListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveListItemDocumentSetVersionField](Remove-MgBetaUserDriveListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveListItemField](Remove-MgBetaUserDriveListItemField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveListItemVersion](Remove-MgBetaUserDriveListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveListItemVersionField](Remove-MgBetaUserDriveListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveListOperation](Remove-MgBetaUserDriveListOperation.md)
Delete navigation property operations for users

### [Remove-MgBetaUserDriveListSubscription](Remove-MgBetaUserDriveListSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgBetaUserDriveRoot](Remove-MgBetaUserDriveRoot.md)
Delete navigation property root for users

### [Remove-MgBetaUserDriveRootAnalytic](Remove-MgBetaUserDriveRootAnalytic.md)
Delete navigation property analytics for users

### [Remove-MgBetaUserDriveRootAnalyticItemActivityStat](Remove-MgBetaUserDriveRootAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for users

### [Remove-MgBetaUserDriveRootChild](Remove-MgBetaUserDriveRootChild.md)
Remove an item from a bundle][].
This API is available in the following [national cloud deployments.

### [Remove-MgBetaUserDriveRootListItem](Remove-MgBetaUserDriveRootListItem.md)
Delete navigation property listItem for users

### [Remove-MgBetaUserDriveRootListItemDocumentSetVersion](Remove-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Delete a version of a document set in a list.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveRootListItemDocumentSetVersionField](Remove-MgBetaUserDriveRootListItemDocumentSetVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveRootListItemField](Remove-MgBetaUserDriveRootListItemField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveRootListItemVersion](Remove-MgBetaUserDriveRootListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveRootListItemVersionField](Remove-MgBetaUserDriveRootListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveRootPermission](Remove-MgBetaUserDriveRootPermission.md)
Remove access to a DriveItem.
Only sharing permissions that are not inherited can be deleted.\nThe inheritedFrom property must be null.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveRootRetentionLabel](Remove-MgBetaUserDriveRootRetentionLabel.md)
Remove a retention label from a driveItem.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
This API is available in the following national cloud deployments.

### [Remove-MgBetaUserDriveRootSubscription](Remove-MgBetaUserDriveRootSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgBetaUserDriveRootThumbnail](Remove-MgBetaUserDriveRootThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgBetaUserDriveRootVersion](Remove-MgBetaUserDriveRootVersion.md)
Delete navigation property versions for users

### [Restore-MgBetaDriveItem](Restore-MgBetaDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveItemListItemDocumentSetVersion](Restore-MgBetaDriveItemListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveItemListItemVersion](Restore-MgBetaDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveItemVersion](Restore-MgBetaDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveListItemDocumentSetVersion](Restore-MgBetaDriveListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveListItemVersion](Restore-MgBetaDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveRoot](Restore-MgBetaDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveRootListItemDocumentSetVersion](Restore-MgBetaDriveRootListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaDriveRootListItemVersion](Restore-MgBetaDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveRootVersion](Restore-MgBetaDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.
This API is available in the following national cloud deployments.

### [Restore-MgBetaShareListItemDocumentSetVersion](Restore-MgBetaShareListItemDocumentSetVersion.md)
Restore a document set version.
This API is available in the following national cloud deployments.

### [Restore-MgBetaShareListItemVersion](Restore-MgBetaShareListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgBetaDriveItemPermissionGrant](Revoke-MgBetaDriveItemPermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Revoke-MgBetaDriveRootPermissionGrant](Revoke-MgBetaDriveRootPermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Revoke-MgBetaSharePermissionGrant](Revoke-MgBetaSharePermissionGrant.md)
Revoke access to a listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.
This API is available in the following [national cloud deployments.

### [Search-MgBetaDrive](Search-MgBetaDrive.md)
Invoke function search

### [Search-MgBetaDriveItem](Search-MgBetaDriveItem.md)
Invoke function search

### [Search-MgBetaDriveRoot](Search-MgBetaDriveRoot.md)
Invoke function search

### [Set-MgBetaDriveBundleContent](Set-MgBetaDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveFollowingContent](Set-MgBetaDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveItemChildContent](Set-MgBetaDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveItemContent](Set-MgBetaDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveItemListItemDriveItemContent](Set-MgBetaDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveItemSensitivityLabel](Set-MgBetaDriveItemSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaDriveItemVersionContent](Set-MgBetaDriveItemVersionContent.md)
Update content for the navigation property versions in drives

### [Set-MgBetaDriveListItemDriveItemContent](Set-MgBetaDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveRootChildContent](Set-MgBetaDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveRootContent](Set-MgBetaDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveRootListItemDriveItemContent](Set-MgBetaDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaDriveRootSensitivityLabel](Set-MgBetaDriveRootSensitivityLabel.md)
Invoke action assignSensitivityLabel

### [Set-MgBetaDriveRootVersionContent](Set-MgBetaDriveRootVersionContent.md)
Update content for the navigation property versions in drives

### [Set-MgBetaDriveSpecialContent](Set-MgBetaDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveBundleContent](Set-MgBetaGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveFollowingContent](Set-MgBetaGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveItemChildContent](Set-MgBetaGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveItemContent](Set-MgBetaGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveItemListItemDriveItemContent](Set-MgBetaGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveItemVersionContent](Set-MgBetaGroupDriveItemVersionContent.md)
Update content for the navigation property versions in groups

### [Set-MgBetaGroupDriveListItemDriveItemContent](Set-MgBetaGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveRootChildContent](Set-MgBetaGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveRootContent](Set-MgBetaGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveRootListItemDriveItemContent](Set-MgBetaGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaGroupDriveRootVersionContent](Set-MgBetaGroupDriveRootVersionContent.md)
Update content for the navigation property versions in groups

### [Set-MgBetaGroupDriveSpecialContent](Set-MgBetaGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaShareDriveItemContent](Set-MgBetaShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaShareItemContent](Set-MgBetaShareItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaShareListItemDriveItemContent](Set-MgBetaShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaShareRootContent](Set-MgBetaShareRootContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveBundleContent](Set-MgBetaUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveFollowingContent](Set-MgBetaUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveItemChildContent](Set-MgBetaUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveItemContent](Set-MgBetaUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveItemListItemDriveItemContent](Set-MgBetaUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveItemVersionContent](Set-MgBetaUserDriveItemVersionContent.md)
Update content for the navigation property versions in users

### [Set-MgBetaUserDriveListItemDriveItemContent](Set-MgBetaUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveRootChildContent](Set-MgBetaUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveRootContent](Set-MgBetaUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveRootListItemDriveItemContent](Set-MgBetaUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaUserDriveRootVersionContent](Set-MgBetaUserDriveRootVersionContent.md)
Update content for the navigation property versions in users

### [Set-MgBetaUserDriveSpecialContent](Set-MgBetaUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Test-MgBetaDriveItemPermission](Test-MgBetaDriveItemPermission.md)
Invoke action validatePermission

### [Test-MgBetaDriveListContentTypePublished](Test-MgBetaDriveListContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaDriveRootPermission](Test-MgBetaDriveRootPermission.md)
Invoke action validatePermission

### [Test-MgBetaShareListContentTypePublished](Test-MgBetaShareListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgBetaDriveListContentType](Unpublish-MgBetaDriveListContentType.md)
Unpublish a contentType][] from a content type hub site.
This API is available in the following [national cloud deployments.

### [Unpublish-MgBetaShareListContentType](Unpublish-MgBetaShareListContentType.md)
Unpublish a contentType][] from a content type hub site.
This API is available in the following [national cloud deployments.

### [Update-MgBetaDrive](Update-MgBetaDrive.md)
Update entity in drives

### [Update-MgBetaDriveCreatedByUserMailboxSetting](Update-MgBetaDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveItem](Update-MgBetaDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.
This API is available in the following national cloud deployments.

### [Update-MgBetaDriveItemAnalytic](Update-MgBetaDriveItemAnalytic.md)
Update the navigation property analytics in drives

### [Update-MgBetaDriveItemAnalyticItemActivityStat](Update-MgBetaDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in drives

### [Update-MgBetaDriveItemCreatedByUserMailboxSetting](Update-MgBetaDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveItemLastModifiedByUserMailboxSetting](Update-MgBetaDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveItemListItem](Update-MgBetaDriveItemListItem.md)
Update the navigation property listItem in drives

### [Update-MgBetaDriveItemListItemCreatedByUserMailboxSetting](Update-MgBetaDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveItemListItemDocumentSetVersion](Update-MgBetaDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveItemListItemDocumentSetVersionField](Update-MgBetaDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveItemListItemField](Update-MgBetaDriveItemListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgBetaDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveItemListItemVersion](Update-MgBetaDriveItemListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveItemListItemVersionField](Update-MgBetaDriveItemListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveItemPermission](Update-MgBetaDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaDriveItemRetentionLabel](Update-MgBetaDriveItemRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaDriveItemSubscription](Update-MgBetaDriveItemSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveItemThumbnail](Update-MgBetaDriveItemThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgBetaDriveItemVersion](Update-MgBetaDriveItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveLastModifiedByUserMailboxSetting](Update-MgBetaDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveList](Update-MgBetaDriveList.md)
Update the navigation property list in drives

### [Update-MgBetaDriveListColumn](Update-MgBetaDriveListColumn.md)
Update the navigation property columns in drives

### [Update-MgBetaDriveListContentType](Update-MgBetaDriveListContentType.md)
Update the navigation property contentTypes in drives

### [Update-MgBetaDriveListContentTypeColumn](Update-MgBetaDriveListContentTypeColumn.md)
Update a site][], [list][] or [content type][contentType] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Update-MgBetaDriveListContentTypeColumnLink](Update-MgBetaDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in drives

### [Update-MgBetaDriveListCreatedByUserMailboxSetting](Update-MgBetaDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveListItem](Update-MgBetaDriveListItem.md)
Update the navigation property items in drives

### [Update-MgBetaDriveListItemCreatedByUserMailboxSetting](Update-MgBetaDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveListItemDocumentSetVersion](Update-MgBetaDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveListItemDocumentSetVersionField](Update-MgBetaDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveListItemField](Update-MgBetaDriveListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaDriveListItemLastModifiedByUserMailboxSetting](Update-MgBetaDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveListItemVersion](Update-MgBetaDriveListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveListItemVersionField](Update-MgBetaDriveListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveListLastModifiedByUserMailboxSetting](Update-MgBetaDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveListOperation](Update-MgBetaDriveListOperation.md)
Update the navigation property operations in drives

### [Update-MgBetaDriveListSubscription](Update-MgBetaDriveListSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveRoot](Update-MgBetaDriveRoot.md)
Update the navigation property root in drives

### [Update-MgBetaDriveRootAnalytic](Update-MgBetaDriveRootAnalytic.md)
Update the navigation property analytics in drives

### [Update-MgBetaDriveRootAnalyticItemActivityStat](Update-MgBetaDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in drives

### [Update-MgBetaDriveRootCreatedByUserMailboxSetting](Update-MgBetaDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveRootLastModifiedByUserMailboxSetting](Update-MgBetaDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveRootListItem](Update-MgBetaDriveRootListItem.md)
Update the navigation property listItem in drives

### [Update-MgBetaDriveRootListItemCreatedByUserMailboxSetting](Update-MgBetaDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveRootListItemDocumentSetVersion](Update-MgBetaDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveRootListItemDocumentSetVersionField](Update-MgBetaDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveRootListItemField](Update-MgBetaDriveRootListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgBetaDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaDriveRootListItemVersion](Update-MgBetaDriveRootListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveRootListItemVersionField](Update-MgBetaDriveRootListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveRootPermission](Update-MgBetaDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaDriveRootRetentionLabel](Update-MgBetaDriveRootRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaDriveRootSubscription](Update-MgBetaDriveRootSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveRootThumbnail](Update-MgBetaDriveRootThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgBetaDriveRootVersion](Update-MgBetaDriveRootVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaGroupDrive](Update-MgBetaGroupDrive.md)
Update the navigation property drives in groups

### [Update-MgBetaGroupDriveCreatedByUserMailboxSetting](Update-MgBetaGroupDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveItem](Update-MgBetaGroupDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupDriveItemAnalytic](Update-MgBetaGroupDriveItemAnalytic.md)
Update the navigation property analytics in groups

### [Update-MgBetaGroupDriveItemAnalyticItemActivityStat](Update-MgBetaGroupDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in groups

### [Update-MgBetaGroupDriveItemCreatedByUserMailboxSetting](Update-MgBetaGroupDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveItemLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveItemListItem](Update-MgBetaGroupDriveItemListItem.md)
Update the navigation property listItem in groups

### [Update-MgBetaGroupDriveItemListItemCreatedByUserMailboxSetting](Update-MgBetaGroupDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveItemListItemDocumentSetVersion](Update-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveItemListItemDocumentSetVersionField](Update-MgBetaGroupDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveItemListItemField](Update-MgBetaGroupDriveItemListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaGroupDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveItemListItemVersion](Update-MgBetaGroupDriveItemListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveItemListItemVersionField](Update-MgBetaGroupDriveItemListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveItemPermission](Update-MgBetaGroupDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupDriveItemRetentionLabel](Update-MgBetaGroupDriveItemRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupDriveItemSubscription](Update-MgBetaGroupDriveItemSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveItemThumbnail](Update-MgBetaGroupDriveItemThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgBetaGroupDriveItemVersion](Update-MgBetaGroupDriveItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveList](Update-MgBetaGroupDriveList.md)
Update the navigation property list in groups

### [Update-MgBetaGroupDriveListColumn](Update-MgBetaGroupDriveListColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupDriveListContentType](Update-MgBetaGroupDriveListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgBetaGroupDriveListContentTypeColumn](Update-MgBetaGroupDriveListContentTypeColumn.md)
Update a site][], [list][] or [content type][contentType] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Update-MgBetaGroupDriveListContentTypeColumnLink](Update-MgBetaGroupDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgBetaGroupDriveListCreatedByUserMailboxSetting](Update-MgBetaGroupDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveListItem](Update-MgBetaGroupDriveListItem.md)
Update the navigation property items in groups

### [Update-MgBetaGroupDriveListItemCreatedByUserMailboxSetting](Update-MgBetaGroupDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveListItemDocumentSetVersion](Update-MgBetaGroupDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveListItemDocumentSetVersionField](Update-MgBetaGroupDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveListItemField](Update-MgBetaGroupDriveListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaGroupDriveListItemLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveListItemVersion](Update-MgBetaGroupDriveListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveListItemVersionField](Update-MgBetaGroupDriveListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveListLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveListOperation](Update-MgBetaGroupDriveListOperation.md)
Update the navigation property operations in groups

### [Update-MgBetaGroupDriveListSubscription](Update-MgBetaGroupDriveListSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveRoot](Update-MgBetaGroupDriveRoot.md)
Update the navigation property root in groups

### [Update-MgBetaGroupDriveRootAnalytic](Update-MgBetaGroupDriveRootAnalytic.md)
Update the navigation property analytics in groups

### [Update-MgBetaGroupDriveRootAnalyticItemActivityStat](Update-MgBetaGroupDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in groups

### [Update-MgBetaGroupDriveRootCreatedByUserMailboxSetting](Update-MgBetaGroupDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveRootLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveRootListItem](Update-MgBetaGroupDriveRootListItem.md)
Update the navigation property listItem in groups

### [Update-MgBetaGroupDriveRootListItemCreatedByUserMailboxSetting](Update-MgBetaGroupDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveRootListItemDocumentSetVersion](Update-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveRootListItemDocumentSetVersionField](Update-MgBetaGroupDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveRootListItemField](Update-MgBetaGroupDriveRootListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaGroupDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgBetaGroupDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaGroupDriveRootListItemVersion](Update-MgBetaGroupDriveRootListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveRootListItemVersionField](Update-MgBetaGroupDriveRootListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveRootPermission](Update-MgBetaGroupDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupDriveRootRetentionLabel](Update-MgBetaGroupDriveRootRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaGroupDriveRootSubscription](Update-MgBetaGroupDriveRootSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveRootThumbnail](Update-MgBetaGroupDriveRootThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgBetaGroupDriveRootVersion](Update-MgBetaGroupDriveRootVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaShareCreatedByUserMailboxSetting](Update-MgBetaShareCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareLastModifiedByUserMailboxSetting](Update-MgBetaShareLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareList](Update-MgBetaShareList.md)
Update the navigation property list in shares

### [Update-MgBetaShareListColumn](Update-MgBetaShareListColumn.md)
Update the navigation property columns in shares

### [Update-MgBetaShareListContentType](Update-MgBetaShareListContentType.md)
Update the navigation property contentTypes in shares

### [Update-MgBetaShareListContentTypeColumn](Update-MgBetaShareListContentTypeColumn.md)
Update a site][], [list][] or [content type][contentType] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Update-MgBetaShareListContentTypeColumnLink](Update-MgBetaShareListContentTypeColumnLink.md)
Update the navigation property columnLinks in shares

### [Update-MgBetaShareListCreatedByUserMailboxSetting](Update-MgBetaShareListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareListItem](Update-MgBetaShareListItem.md)
Update the navigation property listItem in shares

### [Update-MgBetaShareListItemCreatedByUserMailboxSetting](Update-MgBetaShareListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareListItemDocumentSetVersion](Update-MgBetaShareListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in shares

### [Update-MgBetaShareListItemDocumentSetVersionField](Update-MgBetaShareListItemDocumentSetVersionField.md)
Update the navigation property fields in shares

### [Update-MgBetaShareListItemField](Update-MgBetaShareListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaShareListItemLastModifiedByUserMailboxSetting](Update-MgBetaShareListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareListItemVersion](Update-MgBetaShareListItemVersion.md)
Update the navigation property versions in shares

### [Update-MgBetaShareListItemVersionField](Update-MgBetaShareListItemVersionField.md)
Update the navigation property fields in shares

### [Update-MgBetaShareListLastModifiedByUserMailboxSetting](Update-MgBetaShareListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaShareListOperation](Update-MgBetaShareListOperation.md)
Update the navigation property operations in shares

### [Update-MgBetaShareListSubscription](Update-MgBetaShareListSubscription.md)
Update the navigation property subscriptions in shares

### [Update-MgBetaSharePermission](Update-MgBetaSharePermission.md)
Update the navigation property permission in shares

### [Update-MgBetaShareSharedDriveItemSharedDriveItem](Update-MgBetaShareSharedDriveItemSharedDriveItem.md)
Update entity in shares

### [Update-MgBetaUserDrive](Update-MgBetaUserDrive.md)
Update the navigation property drives in users

### [Update-MgBetaUserDriveCreatedByUserMailboxSetting](Update-MgBetaUserDriveCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveItem](Update-MgBetaUserDriveItem.md)
To move a DriveItem to a new parent item, your app requests to update the parentReference of the DriveItem to move.
This is a special case of the Update method.\nYour app can combine moving an item to a new container and updating other properties of the item into a single request.
Items cannot be moved between Drives using this request.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserDriveItemAnalytic](Update-MgBetaUserDriveItemAnalytic.md)
Update the navigation property analytics in users

### [Update-MgBetaUserDriveItemAnalyticItemActivityStat](Update-MgBetaUserDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in users

### [Update-MgBetaUserDriveItemCreatedByUserMailboxSetting](Update-MgBetaUserDriveItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveItemLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveItemListItem](Update-MgBetaUserDriveItemListItem.md)
Update the navigation property listItem in users

### [Update-MgBetaUserDriveItemListItemCreatedByUserMailboxSetting](Update-MgBetaUserDriveItemListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveItemListItemDocumentSetVersion](Update-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveItemListItemDocumentSetVersionField](Update-MgBetaUserDriveItemListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveItemListItemField](Update-MgBetaUserDriveItemListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaUserDriveItemListItemLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveItemListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveItemListItemVersion](Update-MgBetaUserDriveItemListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveItemListItemVersionField](Update-MgBetaUserDriveItemListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveItemPermission](Update-MgBetaUserDriveItemPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserDriveItemRetentionLabel](Update-MgBetaUserDriveItemRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserDriveItemSubscription](Update-MgBetaUserDriveItemSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveItemThumbnail](Update-MgBetaUserDriveItemThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgBetaUserDriveItemVersion](Update-MgBetaUserDriveItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveList](Update-MgBetaUserDriveList.md)
Update the navigation property list in users

### [Update-MgBetaUserDriveListColumn](Update-MgBetaUserDriveListColumn.md)
Update the navigation property columns in users

### [Update-MgBetaUserDriveListContentType](Update-MgBetaUserDriveListContentType.md)
Update the navigation property contentTypes in users

### [Update-MgBetaUserDriveListContentTypeColumn](Update-MgBetaUserDriveListContentTypeColumn.md)
Update a site][], [list][] or [content type][contentType] [column][columnDefinition].
This API is available in the following [national cloud deployments.

### [Update-MgBetaUserDriveListContentTypeColumnLink](Update-MgBetaUserDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in users

### [Update-MgBetaUserDriveListCreatedByUserMailboxSetting](Update-MgBetaUserDriveListCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveListItem](Update-MgBetaUserDriveListItem.md)
Update the navigation property items in users

### [Update-MgBetaUserDriveListItemCreatedByUserMailboxSetting](Update-MgBetaUserDriveListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveListItemDocumentSetVersion](Update-MgBetaUserDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveListItemDocumentSetVersionField](Update-MgBetaUserDriveListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveListItemField](Update-MgBetaUserDriveListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaUserDriveListItemLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveListItemVersion](Update-MgBetaUserDriveListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveListItemVersionField](Update-MgBetaUserDriveListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveListLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveListLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveListOperation](Update-MgBetaUserDriveListOperation.md)
Update the navigation property operations in users

### [Update-MgBetaUserDriveListSubscription](Update-MgBetaUserDriveListSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveRoot](Update-MgBetaUserDriveRoot.md)
Update the navigation property root in users

### [Update-MgBetaUserDriveRootAnalytic](Update-MgBetaUserDriveRootAnalytic.md)
Update the navigation property analytics in users

### [Update-MgBetaUserDriveRootAnalyticItemActivityStat](Update-MgBetaUserDriveRootAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in users

### [Update-MgBetaUserDriveRootCreatedByUserMailboxSetting](Update-MgBetaUserDriveRootCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveRootLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveRootLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveRootListItem](Update-MgBetaUserDriveRootListItem.md)
Update the navigation property listItem in users

### [Update-MgBetaUserDriveRootListItemCreatedByUserMailboxSetting](Update-MgBetaUserDriveRootListItemCreatedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveRootListItemDocumentSetVersion](Update-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveRootListItemDocumentSetVersionField](Update-MgBetaUserDriveRootListItemDocumentSetVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveRootListItemField](Update-MgBetaUserDriveRootListItemField.md)
Update the properties on a listItem][].
This API is available in the following [national cloud deployments.

### [Update-MgBetaUserDriveRootListItemLastModifiedByUserMailboxSetting](Update-MgBetaUserDriveRootListItemLastModifiedByUserMailboxSetting.md)
Update property mailboxSettings value.

### [Update-MgBetaUserDriveRootListItemVersion](Update-MgBetaUserDriveRootListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveRootListItemVersionField](Update-MgBetaUserDriveRootListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveRootPermission](Update-MgBetaUserDriveRootPermission.md)
Update the properties of a sharing permission by patching the permission resource.
Only the roles property can be modified this way.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserDriveRootRetentionLabel](Update-MgBetaUserDriveRootRetentionLabel.md)
Lock or unlock a retention label on a driveItem that classifies content as records.
For information about retention labels from an administrator's perspective, see Use retention labels to manage the lifecycle of documents stored in SharePoint.
For information about how you can lock and unlock retention labels, see Use record versioning to update records stored in SharePoint or OneDrive.
This API is available in the following national cloud deployments.

### [Update-MgBetaUserDriveRootSubscription](Update-MgBetaUserDriveRootSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveRootThumbnail](Update-MgBetaUserDriveRootThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgBetaUserDriveRootVersion](Update-MgBetaUserDriveRootVersion.md)
Update the navigation property versions in users

