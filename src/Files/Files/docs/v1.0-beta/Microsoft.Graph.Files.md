---
Module Name: Microsoft.Graph.Beta.Files
Module Guid: a0be1b2f-a545-4869-97ed-e143aa1f77b3
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.files
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Files Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Files Cmdlets
### [Add-MgBetaDriveListContentTypeCopy](Add-MgBetaDriveListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaDriveListContentTypeCopyFromContentTypeHub](Add-MgBetaDriveListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaShareListContentTypeCopy](Add-MgBetaShareListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaShareListContentTypeCopyFromContentTypeHub](Add-MgBetaShareListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Copy-MgBetaDriveItem](Copy-MgBetaDriveItem.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaDriveListContentTypeToDefaultContentLocation](Copy-MgBetaDriveListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaDriveRoot](Copy-MgBetaDriveRoot.md)
Asynchronously creates a copy of an [driveItem][item-resource] (including any children), under a new parent item or with a new name.

### [Copy-MgBetaShareListContentTypeToDefaultContentLocation](Copy-MgBetaShareListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Get-MgBetaDrive](Get-MgBetaDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgBetaDriveActivity](Get-MgBetaDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.

### [Get-MgBetaDriveBundle](Get-MgBetaDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgBetaDriveBundleContent](Get-MgBetaDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveFollowing](Get-MgBetaDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaDriveFollowingContent](Get-MgBetaDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItem](Get-MgBetaDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgBetaDriveItemActivity](Get-MgBetaDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveItemActivityByInterval](Get-MgBetaDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveItemAnalytic](Get-MgBetaDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaDriveItemChild](Get-MgBetaDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaDriveItemChildContent](Get-MgBetaDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemContent](Get-MgBetaDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemDelta](Get-MgBetaDriveItemDelta.md)
Invoke function delta

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

### [Get-MgBetaDriveItemListItemDocumentSetVersion](Get-MgBetaDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaDriveItemListItemDriveItem](Get-MgBetaDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveItemListItemDriveItemContent](Get-MgBetaDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveItemListItemField](Get-MgBetaDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveItemListItemVersion](Get-MgBetaDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveItemListItemVersionField](Get-MgBetaDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveItemPermission](Get-MgBetaDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaDriveItemSubscription](Get-MgBetaDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaDriveItemThumbnail](Get-MgBetaDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaDriveItemVersion](Get-MgBetaDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaDriveItemVersionContent](Get-MgBetaDriveItemVersionContent.md)
Get content for the navigation property versions from drives

### [Get-MgBetaDriveList](Get-MgBetaDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaDriveListActivity](Get-MgBetaDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaDriveListColumn](Get-MgBetaDriveListColumn.md)
Get columns from drives

### [Get-MgBetaDriveListColumnSourceColumn](Get-MgBetaDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaDriveListContentType](Get-MgBetaDriveListContentType.md)
Get contentTypes from drives

### [Get-MgBetaDriveListContentTypeBase](Get-MgBetaDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaDriveListContentTypeBaseType](Get-MgBetaDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaDriveListContentTypeColumn](Get-MgBetaDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaDriveListContentTypeColumnLink](Get-MgBetaDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaDriveListContentTypeColumnPosition](Get-MgBetaDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaDriveListContentTypeColumnSourceColumn](Get-MgBetaDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaDriveListContentTypeCompatibleHubContentType](Get-MgBetaDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaDriveListDrive](Get-MgBetaDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaDriveListItem](Get-MgBetaDriveListItem.md)
All items contained in the list.

### [Get-MgBetaDriveListItemActivity](Get-MgBetaDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveListItemActivityByInterval](Get-MgBetaDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveListItemAnalytic](Get-MgBetaDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaDriveListItemDelta](Get-MgBetaDriveListItemDelta.md)
Invoke function delta

### [Get-MgBetaDriveListItemDocumentSetVersion](Get-MgBetaDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaDriveListItemDriveItem](Get-MgBetaDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveListItemDriveItemContent](Get-MgBetaDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveListItemField](Get-MgBetaDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveListItemVersion](Get-MgBetaDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveListItemVersionField](Get-MgBetaDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveListOperation](Get-MgBetaDriveListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaDriveListSubscription](Get-MgBetaDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaDriveRoot](Get-MgBetaDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.

### [Get-MgBetaDriveRootActivity](Get-MgBetaDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaDriveRootActivityByInterval](Get-MgBetaDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaDriveRootAnalytic](Get-MgBetaDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaDriveRootChild](Get-MgBetaDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaDriveRootChildContent](Get-MgBetaDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootContent](Get-MgBetaDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootDelta](Get-MgBetaDriveRootDelta.md)
Invoke function delta

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

### [Get-MgBetaDriveRootListItemDocumentSetVersion](Get-MgBetaDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaDriveRootListItemDriveItem](Get-MgBetaDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaDriveRootListItemDriveItemContent](Get-MgBetaDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaDriveRootListItemField](Get-MgBetaDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaDriveRootListItemVersion](Get-MgBetaDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaDriveRootListItemVersionField](Get-MgBetaDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaDriveRootPermission](Get-MgBetaDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaDriveRootSubscription](Get-MgBetaDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaDriveRootThumbnail](Get-MgBetaDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaDriveRootVersion](Get-MgBetaDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaDriveRootVersionContent](Get-MgBetaDriveRootVersionContent.md)
Get content for the navigation property versions from drives

### [Get-MgBetaDriveSpecial](Get-MgBetaDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgBetaDriveSpecialContent](Get-MgBetaDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDefaultDrive](Get-MgBetaGroupDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgBetaGroupDrive](Get-MgBetaGroupDrive.md)
The group's drives.
Read-only.

### [Get-MgBetaGroupDriveActivity](Get-MgBetaGroupDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.

### [Get-MgBetaGroupDriveBundle](Get-MgBetaGroupDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgBetaGroupDriveBundleContent](Get-MgBetaGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveFollowing](Get-MgBetaGroupDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaGroupDriveFollowingContent](Get-MgBetaGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItem](Get-MgBetaGroupDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemActivity](Get-MgBetaGroupDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveItemAnalytic](Get-MgBetaGroupDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaGroupDriveItemChild](Get-MgBetaGroupDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemChildContent](Get-MgBetaGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemContent](Get-MgBetaGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemListItem](Get-MgBetaGroupDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemListItemActivity](Get-MgBetaGroupDriveItemListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveItemListItemAnalytic](Get-MgBetaGroupDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveItemListItemDocumentSetVersion](Get-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaGroupDriveItemListItemDriveItem](Get-MgBetaGroupDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveItemListItemDriveItemContent](Get-MgBetaGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveItemListItemField](Get-MgBetaGroupDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveItemListItemVersion](Get-MgBetaGroupDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveItemListItemVersionField](Get-MgBetaGroupDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveItemPermission](Get-MgBetaGroupDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemSubscription](Get-MgBetaGroupDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaGroupDriveItemThumbnail](Get-MgBetaGroupDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemVersion](Get-MgBetaGroupDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveItemVersionContent](Get-MgBetaGroupDriveItemVersionContent.md)
Get content for the navigation property versions from groups

### [Get-MgBetaGroupDriveList](Get-MgBetaGroupDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveListActivity](Get-MgBetaGroupDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaGroupDriveListColumn](Get-MgBetaGroupDriveListColumn.md)
Get columns from groups

### [Get-MgBetaGroupDriveListColumnSourceColumn](Get-MgBetaGroupDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaGroupDriveListContentType](Get-MgBetaGroupDriveListContentType.md)
Get contentTypes from groups

### [Get-MgBetaGroupDriveListContentTypeBase](Get-MgBetaGroupDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaGroupDriveListContentTypeBaseType](Get-MgBetaGroupDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaGroupDriveListContentTypeColumn](Get-MgBetaGroupDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaGroupDriveListContentTypeColumnLink](Get-MgBetaGroupDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaGroupDriveListContentTypeColumnPosition](Get-MgBetaGroupDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaGroupDriveListContentTypeColumnSourceColumn](Get-MgBetaGroupDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaGroupDriveListDrive](Get-MgBetaGroupDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaGroupDriveListItem](Get-MgBetaGroupDriveListItem.md)
All items contained in the list.

### [Get-MgBetaGroupDriveListItemActivity](Get-MgBetaGroupDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveListItemAnalytic](Get-MgBetaGroupDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveListItemDocumentSetVersion](Get-MgBetaGroupDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaGroupDriveListItemDriveItem](Get-MgBetaGroupDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveListItemDriveItemContent](Get-MgBetaGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveListItemField](Get-MgBetaGroupDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveListItemVersion](Get-MgBetaGroupDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveListItemVersionField](Get-MgBetaGroupDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveListOperation](Get-MgBetaGroupDriveListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaGroupDriveListSubscription](Get-MgBetaGroupDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaGroupDriveRoot](Get-MgBetaGroupDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.

### [Get-MgBetaGroupDriveRootActivity](Get-MgBetaGroupDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveRootAnalytic](Get-MgBetaGroupDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaGroupDriveRootChild](Get-MgBetaGroupDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootChildContent](Get-MgBetaGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootContent](Get-MgBetaGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootListItem](Get-MgBetaGroupDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootListItemActivity](Get-MgBetaGroupDriveRootListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupDriveRootListItemAnalytic](Get-MgBetaGroupDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupDriveRootListItemDocumentSetVersion](Get-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaGroupDriveRootListItemDriveItem](Get-MgBetaGroupDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupDriveRootListItemDriveItemContent](Get-MgBetaGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupDriveRootListItemField](Get-MgBetaGroupDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupDriveRootListItemVersion](Get-MgBetaGroupDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupDriveRootListItemVersionField](Get-MgBetaGroupDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupDriveRootPermission](Get-MgBetaGroupDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootSubscription](Get-MgBetaGroupDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaGroupDriveRootThumbnail](Get-MgBetaGroupDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootVersion](Get-MgBetaGroupDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaGroupDriveRootVersionContent](Get-MgBetaGroupDriveRootVersionContent.md)
Get content for the navigation property versions from groups

### [Get-MgBetaGroupDriveSpecial](Get-MgBetaGroupDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgBetaGroupDriveSpecialContent](Get-MgBetaGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareDriveItem](Get-MgBetaShareDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a **shareId** or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

### [Get-MgBetaShareDriveItemContent](Get-MgBetaShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareItem](Get-MgBetaShareItem.md)
All driveItems contained in the sharing root.
This collection cannot be enumerated.

### [Get-MgBetaShareItemContent](Get-MgBetaShareItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareList](Get-MgBetaShareList.md)
Used to access the underlying list

### [Get-MgBetaShareListActivity](Get-MgBetaShareListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaShareListColumn](Get-MgBetaShareListColumn.md)
Get columns from shares

### [Get-MgBetaShareListColumnSourceColumn](Get-MgBetaShareListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaShareListContentType](Get-MgBetaShareListContentType.md)
Get contentTypes from shares

### [Get-MgBetaShareListContentTypeBase](Get-MgBetaShareListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaShareListContentTypeBaseType](Get-MgBetaShareListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaShareListContentTypeColumn](Get-MgBetaShareListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaShareListContentTypeColumnLink](Get-MgBetaShareListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaShareListContentTypeColumnPosition](Get-MgBetaShareListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaShareListContentTypeColumnSourceColumn](Get-MgBetaShareListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaShareListContentTypeCompatibleHubContentType](Get-MgBetaShareListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaShareListDrive](Get-MgBetaShareListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaShareListItem](Get-MgBetaShareListItem.md)
All items contained in the list.

### [Get-MgBetaShareListItemActivity](Get-MgBetaShareListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaShareListItemActivityByInterval](Get-MgBetaShareListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaShareListItemAnalytic](Get-MgBetaShareListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaShareListItemDelta](Get-MgBetaShareListItemDelta.md)
Invoke function delta

### [Get-MgBetaShareListItemDocumentSetVersion](Get-MgBetaShareListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaShareListItemDriveItem](Get-MgBetaShareListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaShareListItemDriveItemContent](Get-MgBetaShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareListItemField](Get-MgBetaShareListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaShareListItemVersion](Get-MgBetaShareListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaShareListItemVersionField](Get-MgBetaShareListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaShareListOperation](Get-MgBetaShareListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaShareListSubscription](Get-MgBetaShareListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaSharePermission](Get-MgBetaSharePermission.md)
Used to access the permission representing the underlying sharing link

### [Get-MgBetaShareRoot](Get-MgBetaShareRoot.md)
Get root from shares

### [Get-MgBetaShareRootContent](Get-MgBetaShareRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaShareSharedDriveItemSharedDriveItem](Get-MgBetaShareSharedDriveItemSharedDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a **shareId** or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

### [Get-MgBetaShareSite](Get-MgBetaShareSite.md)
Used to access the underlying site

### [Get-MgBetaUserDefaultDrive](Get-MgBetaUserDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgBetaUserDrive](Get-MgBetaUserDrive.md)
A collection of drives available for this user.
Read-only.

### [Get-MgBetaUserDriveActivity](Get-MgBetaUserDriveActivity.md)
List the recent activities that took place on an item or under a hierarchy.

### [Get-MgBetaUserDriveBundle](Get-MgBetaUserDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgBetaUserDriveBundleContent](Get-MgBetaUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveFollowing](Get-MgBetaUserDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgBetaUserDriveFollowingContent](Get-MgBetaUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItem](Get-MgBetaUserDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemActivity](Get-MgBetaUserDriveItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveItemAnalytic](Get-MgBetaUserDriveItemAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaUserDriveItemChild](Get-MgBetaUserDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemChildContent](Get-MgBetaUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemContent](Get-MgBetaUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemListItem](Get-MgBetaUserDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemListItemActivity](Get-MgBetaUserDriveItemListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveItemListItemAnalytic](Get-MgBetaUserDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveItemListItemDocumentSetVersion](Get-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaUserDriveItemListItemDriveItem](Get-MgBetaUserDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveItemListItemDriveItemContent](Get-MgBetaUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveItemListItemField](Get-MgBetaUserDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveItemListItemVersion](Get-MgBetaUserDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveItemListItemVersionField](Get-MgBetaUserDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveItemPermission](Get-MgBetaUserDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemSubscription](Get-MgBetaUserDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaUserDriveItemThumbnail](Get-MgBetaUserDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemVersion](Get-MgBetaUserDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveItemVersionContent](Get-MgBetaUserDriveItemVersionContent.md)
Get content for the navigation property versions from users

### [Get-MgBetaUserDriveList](Get-MgBetaUserDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgBetaUserDriveListActivity](Get-MgBetaUserDriveListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaUserDriveListColumn](Get-MgBetaUserDriveListColumn.md)
Get columns from users

### [Get-MgBetaUserDriveListColumnSourceColumn](Get-MgBetaUserDriveListColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaUserDriveListContentType](Get-MgBetaUserDriveListContentType.md)
Get contentTypes from users

### [Get-MgBetaUserDriveListContentTypeBase](Get-MgBetaUserDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaUserDriveListContentTypeBaseType](Get-MgBetaUserDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaUserDriveListContentTypeColumn](Get-MgBetaUserDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaUserDriveListContentTypeColumnLink](Get-MgBetaUserDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaUserDriveListContentTypeColumnPosition](Get-MgBetaUserDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaUserDriveListContentTypeColumnSourceColumn](Get-MgBetaUserDriveListContentTypeColumnSourceColumn.md)
The source column for content type column.

### [Get-MgBetaUserDriveListDrive](Get-MgBetaUserDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaUserDriveListItem](Get-MgBetaUserDriveListItem.md)
All items contained in the list.

### [Get-MgBetaUserDriveListItemActivity](Get-MgBetaUserDriveListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveListItemAnalytic](Get-MgBetaUserDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveListItemDocumentSetVersion](Get-MgBetaUserDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaUserDriveListItemDriveItem](Get-MgBetaUserDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveListItemDriveItemContent](Get-MgBetaUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveListItemField](Get-MgBetaUserDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveListItemVersion](Get-MgBetaUserDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveListItemVersionField](Get-MgBetaUserDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveListOperation](Get-MgBetaUserDriveListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaUserDriveListSubscription](Get-MgBetaUserDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaUserDriveRoot](Get-MgBetaUserDriveRoot.md)
Retrieve the metadata for a driveItem in a drive by file system path or ID.

### [Get-MgBetaUserDriveRootActivity](Get-MgBetaUserDriveRootActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveRootAnalytic](Get-MgBetaUserDriveRootAnalytic.md)
Get [itemAnalytics][] about the views that took place under this resource.\nThe **itemAnalytics** resource is a convenient way to get activity stats for `allTime` and the `lastSevenDays`.\nFor a custom time range or interval, use the [getActivitiesByInterval][] API.

### [Get-MgBetaUserDriveRootChild](Get-MgBetaUserDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootChildContent](Get-MgBetaUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootContent](Get-MgBetaUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootListItem](Get-MgBetaUserDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootListItemActivity](Get-MgBetaUserDriveRootListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaUserDriveRootListItemAnalytic](Get-MgBetaUserDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaUserDriveRootListItemDocumentSetVersion](Get-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaUserDriveRootListItemDriveItem](Get-MgBetaUserDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaUserDriveRootListItemDriveItemContent](Get-MgBetaUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaUserDriveRootListItemField](Get-MgBetaUserDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaUserDriveRootListItemVersion](Get-MgBetaUserDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaUserDriveRootListItemVersionField](Get-MgBetaUserDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaUserDriveRootPermission](Get-MgBetaUserDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootSubscription](Get-MgBetaUserDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgBetaUserDriveRootThumbnail](Get-MgBetaUserDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootVersion](Get-MgBetaUserDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgBetaUserDriveRootVersionContent](Get-MgBetaUserDriveRootVersionContent.md)
Get content for the navigation property versions from users

### [Get-MgBetaUserDriveSpecial](Get-MgBetaUserDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgBetaUserDriveSpecialContent](Get-MgBetaUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Grant-MgBetaDriveItemPermission](Grant-MgBetaDriveItemPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgBetaDriveRootPermission](Grant-MgBetaDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgBetaSharePermission](Grant-MgBetaSharePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgBetaCheckinDriveItem](Invoke-MgBetaCheckinDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckinDriveRoot](Invoke-MgBetaCheckinDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgBetaCheckoutDriveItem](Invoke-MgBetaCheckoutDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaCheckoutDriveRoot](Invoke-MgBetaCheckoutDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgBetaExtractDriveItemSensitivityLabel](Invoke-MgBetaExtractDriveItemSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaExtractDriveRootSensitivityLabel](Invoke-MgBetaExtractDriveRootSensitivityLabel.md)
Invoke action extractSensitivityLabels

### [Invoke-MgBetaFollowDriveItem](Invoke-MgBetaFollowDriveItem.md)
Follow a driveItem.

### [Invoke-MgBetaFollowDriveRoot](Invoke-MgBetaFollowDriveRoot.md)
Follow a driveItem.

### [Invoke-MgBetaGraphDrive](Invoke-MgBetaGraphDrive.md)
Invoke function sharedWithMe

### [Invoke-MgBetaInviteDriveItem](Invoke-MgBetaInviteDriveItem.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaInviteDriveRoot](Invoke-MgBetaInviteDriveRoot.md)
Sends a sharing invitation for a **DriveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends an email to the recipients to notify them the item was shared.

### [Invoke-MgBetaPreviewDriveItem](Invoke-MgBetaPreviewDriveItem.md)
Invoke action preview

### [Invoke-MgBetaPreviewDriveRoot](Invoke-MgBetaPreviewDriveRoot.md)
Invoke action preview

### [Invoke-MgBetaReauthorizeDriveItemSubscription](Invoke-MgBetaReauthorizeDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeDriveListSubscription](Invoke-MgBetaReauthorizeDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeDriveRootSubscription](Invoke-MgBetaReauthorizeDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaReauthorizeShareListSubscription](Invoke-MgBetaReauthorizeShareListSubscription.md)
Invoke action reauthorize

### [Invoke-MgBetaRecentDrive](Invoke-MgBetaRecentDrive.md)
Invoke function recent

### [Invoke-MgBetaUnfollowDriveItem](Invoke-MgBetaUnfollowDriveItem.md)
Unfollow a driveItem.

### [Invoke-MgBetaUnfollowDriveRoot](Invoke-MgBetaUnfollowDriveRoot.md)
Unfollow a driveItem.

### [Join-MgBetaDriveListContentTypeWithHubSite](Join-MgBetaDriveListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgBetaShareListContentTypeWithHubSite](Join-MgBetaShareListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [New-MgBetaDrive](New-MgBetaDrive.md)
Add new entity to drives

### [New-MgBetaDriveItem](New-MgBetaDriveItem.md)
Create new navigation property to items for drives

### [New-MgBetaDriveItemLink](New-MgBetaDriveItemLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaDriveItemListItemDocumentSetVersion](New-MgBetaDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaDriveItemListItemLink](New-MgBetaDriveItemListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaDriveItemListItemVersion](New-MgBetaDriveItemListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveItemPermission](New-MgBetaDriveItemPermission.md)
Create new navigation property to permissions for drives

### [New-MgBetaDriveItemSubscription](New-MgBetaDriveItemSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveItemThumbnail](New-MgBetaDriveItemThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgBetaDriveItemUploadSession](New-MgBetaDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaDriveItemVersion](New-MgBetaDriveItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveListColumn](New-MgBetaDriveListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaDriveListContentType](New-MgBetaDriveListContentType.md)
Create new navigation property to contentTypes for drives

### [New-MgBetaDriveListContentTypeColumn](New-MgBetaDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaDriveListContentTypeColumnLink](New-MgBetaDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for drives

### [New-MgBetaDriveListItem](New-MgBetaDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaDriveListItemDocumentSetVersion](New-MgBetaDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaDriveListItemLink](New-MgBetaDriveListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaDriveListItemVersion](New-MgBetaDriveListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveListOperation](New-MgBetaDriveListOperation.md)
Create new navigation property to operations for drives

### [New-MgBetaDriveListSubscription](New-MgBetaDriveListSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveRootLink](New-MgBetaDriveRootLink.md)
You can use **createLink** action to share a driveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgBetaDriveRootListItemDocumentSetVersion](New-MgBetaDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaDriveRootListItemLink](New-MgBetaDriveRootListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaDriveRootListItemVersion](New-MgBetaDriveRootListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaDriveRootPermission](New-MgBetaDriveRootPermission.md)
Create new navigation property to permissions for drives

### [New-MgBetaDriveRootSubscription](New-MgBetaDriveRootSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgBetaDriveRootThumbnail](New-MgBetaDriveRootThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgBetaDriveRootUploadSession](New-MgBetaDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.
An upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session:

### [New-MgBetaDriveRootVersion](New-MgBetaDriveRootVersion.md)
Create new navigation property to versions for drives

### [New-MgBetaGroupDrive](New-MgBetaGroupDrive.md)
Create new navigation property to drives for groups

### [New-MgBetaGroupDriveItem](New-MgBetaGroupDriveItem.md)
Create new navigation property to items for groups

### [New-MgBetaGroupDriveItemListItemDocumentSetVersion](New-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

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
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaGroupDriveListContentType](New-MgBetaGroupDriveListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgBetaGroupDriveListContentTypeColumn](New-MgBetaGroupDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaGroupDriveListContentTypeColumnLink](New-MgBetaGroupDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgBetaGroupDriveListItem](New-MgBetaGroupDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaGroupDriveListItemDocumentSetVersion](New-MgBetaGroupDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaGroupDriveListItemVersion](New-MgBetaGroupDriveListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupDriveListOperation](New-MgBetaGroupDriveListOperation.md)
Create new navigation property to operations for groups

### [New-MgBetaGroupDriveListSubscription](New-MgBetaGroupDriveListSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgBetaGroupDriveRootListItemDocumentSetVersion](New-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

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
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaShareListContentType](New-MgBetaShareListContentType.md)
Create new navigation property to contentTypes for shares

### [New-MgBetaShareListContentTypeColumn](New-MgBetaShareListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaShareListContentTypeColumnLink](New-MgBetaShareListContentTypeColumnLink.md)
Create new navigation property to columnLinks for shares

### [New-MgBetaShareListItem](New-MgBetaShareListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaShareListItemDocumentSetVersion](New-MgBetaShareListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

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

### [New-MgBetaUserDriveItem](New-MgBetaUserDriveItem.md)
Create new navigation property to items for users

### [New-MgBetaUserDriveItemListItemDocumentSetVersion](New-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

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
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaUserDriveListContentType](New-MgBetaUserDriveListContentType.md)
Create new navigation property to contentTypes for users

### [New-MgBetaUserDriveListContentTypeColumn](New-MgBetaUserDriveListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaUserDriveListContentTypeColumnLink](New-MgBetaUserDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for users

### [New-MgBetaUserDriveListItem](New-MgBetaUserDriveListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaUserDriveListItemDocumentSetVersion](New-MgBetaUserDriveListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaUserDriveListItemVersion](New-MgBetaUserDriveListItemVersion.md)
Create new navigation property to versions for users

### [New-MgBetaUserDriveListOperation](New-MgBetaUserDriveListOperation.md)
Create new navigation property to operations for users

### [New-MgBetaUserDriveListSubscription](New-MgBetaUserDriveListSubscription.md)
Create new navigation property to subscriptions for users

### [New-MgBetaUserDriveRootListItemDocumentSetVersion](New-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

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
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaShareListContentType](Publish-MgBetaShareListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Remove-MgBetaDrive](Remove-MgBetaDrive.md)
Delete entity from drives

### [Remove-MgBetaDriveItem](Remove-MgBetaDriveItem.md)
Delete navigation property items for drives

### [Remove-MgBetaDriveItemListItem](Remove-MgBetaDriveItemListItem.md)
Delete navigation property listItem for drives

### [Remove-MgBetaDriveItemListItemDocumentSetVersion](Remove-MgBetaDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

### [Remove-MgBetaDriveItemListItemField](Remove-MgBetaDriveItemListItemField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveItemListItemVersion](Remove-MgBetaDriveItemListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveItemListItemVersionField](Remove-MgBetaDriveItemListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveItemPermission](Remove-MgBetaDriveItemPermission.md)
Delete navigation property permissions for drives

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
Delete navigation property columns for drives

### [Remove-MgBetaDriveListContentTypeColumnLink](Remove-MgBetaDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for drives

### [Remove-MgBetaDriveListItem](Remove-MgBetaDriveListItem.md)
Delete navigation property items for drives

### [Remove-MgBetaDriveListItemDocumentSetVersion](Remove-MgBetaDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

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

### [Remove-MgBetaDriveRootListItem](Remove-MgBetaDriveRootListItem.md)
Delete navigation property listItem for drives

### [Remove-MgBetaDriveRootListItemDocumentSetVersion](Remove-MgBetaDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

### [Remove-MgBetaDriveRootListItemField](Remove-MgBetaDriveRootListItemField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveRootListItemVersion](Remove-MgBetaDriveRootListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaDriveRootListItemVersionField](Remove-MgBetaDriveRootListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgBetaDriveRootPermission](Remove-MgBetaDriveRootPermission.md)
Delete navigation property permissions for drives

### [Remove-MgBetaDriveRootSubscription](Remove-MgBetaDriveRootSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgBetaDriveRootThumbnail](Remove-MgBetaDriveRootThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgBetaDriveRootVersion](Remove-MgBetaDriveRootVersion.md)
Delete navigation property versions for drives

### [Remove-MgBetaGroupDrive](Remove-MgBetaGroupDrive.md)
Delete navigation property drives for groups

### [Remove-MgBetaGroupDriveItem](Remove-MgBetaGroupDriveItem.md)
Delete navigation property items for groups

### [Remove-MgBetaGroupDriveItemListItem](Remove-MgBetaGroupDriveItemListItem.md)
Delete navigation property listItem for groups

### [Remove-MgBetaGroupDriveItemListItemDocumentSetVersion](Remove-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgBetaGroupDriveItemListItemField](Remove-MgBetaGroupDriveItemListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveItemListItemVersion](Remove-MgBetaGroupDriveItemListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveItemListItemVersionField](Remove-MgBetaGroupDriveItemListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveItemPermission](Remove-MgBetaGroupDriveItemPermission.md)
Delete navigation property permissions for groups

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
Delete navigation property columns for groups

### [Remove-MgBetaGroupDriveListContentTypeColumnLink](Remove-MgBetaGroupDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgBetaGroupDriveListItem](Remove-MgBetaGroupDriveListItem.md)
Delete navigation property items for groups

### [Remove-MgBetaGroupDriveListItemDocumentSetVersion](Remove-MgBetaGroupDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

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

### [Remove-MgBetaGroupDriveRootListItem](Remove-MgBetaGroupDriveRootListItem.md)
Delete navigation property listItem for groups

### [Remove-MgBetaGroupDriveRootListItemDocumentSetVersion](Remove-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgBetaGroupDriveRootListItemField](Remove-MgBetaGroupDriveRootListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveRootListItemVersion](Remove-MgBetaGroupDriveRootListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupDriveRootListItemVersionField](Remove-MgBetaGroupDriveRootListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupDriveRootPermission](Remove-MgBetaGroupDriveRootPermission.md)
Delete navigation property permissions for groups

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
Delete navigation property columns for shares

### [Remove-MgBetaShareListContentTypeColumnLink](Remove-MgBetaShareListContentTypeColumnLink.md)
Delete navigation property columnLinks for shares

### [Remove-MgBetaShareListItem](Remove-MgBetaShareListItem.md)
Delete navigation property items for shares

### [Remove-MgBetaShareListItemDocumentSetVersion](Remove-MgBetaShareListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for shares

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
Delete navigation property items for users

### [Remove-MgBetaUserDriveItemListItem](Remove-MgBetaUserDriveItemListItem.md)
Delete navigation property listItem for users

### [Remove-MgBetaUserDriveItemListItemDocumentSetVersion](Remove-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

### [Remove-MgBetaUserDriveItemListItemField](Remove-MgBetaUserDriveItemListItemField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveItemListItemVersion](Remove-MgBetaUserDriveItemListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveItemListItemVersionField](Remove-MgBetaUserDriveItemListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveItemPermission](Remove-MgBetaUserDriveItemPermission.md)
Delete navigation property permissions for users

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
Delete navigation property columns for users

### [Remove-MgBetaUserDriveListContentTypeColumnLink](Remove-MgBetaUserDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for users

### [Remove-MgBetaUserDriveListItem](Remove-MgBetaUserDriveListItem.md)
Delete navigation property items for users

### [Remove-MgBetaUserDriveListItemDocumentSetVersion](Remove-MgBetaUserDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

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

### [Remove-MgBetaUserDriveRootListItem](Remove-MgBetaUserDriveRootListItem.md)
Delete navigation property listItem for users

### [Remove-MgBetaUserDriveRootListItemDocumentSetVersion](Remove-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

### [Remove-MgBetaUserDriveRootListItemField](Remove-MgBetaUserDriveRootListItemField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveRootListItemVersion](Remove-MgBetaUserDriveRootListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgBetaUserDriveRootListItemVersionField](Remove-MgBetaUserDriveRootListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgBetaUserDriveRootPermission](Remove-MgBetaUserDriveRootPermission.md)
Delete navigation property permissions for users

### [Remove-MgBetaUserDriveRootSubscription](Remove-MgBetaUserDriveRootSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgBetaUserDriveRootThumbnail](Remove-MgBetaUserDriveRootThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgBetaUserDriveRootVersion](Remove-MgBetaUserDriveRootVersion.md)
Delete navigation property versions for users

### [Restore-MgBetaDriveItem](Restore-MgBetaDriveItem.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaDriveItemListItemDocumentSetVersion](Restore-MgBetaDriveItemListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaDriveItemListItemVersion](Restore-MgBetaDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveItemVersion](Restore-MgBetaDriveItemVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaDriveListItemDocumentSetVersion](Restore-MgBetaDriveListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaDriveListItemVersion](Restore-MgBetaDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveRoot](Restore-MgBetaDriveRoot.md)
Restore a driveItem that has been deleted and is currently in the recycle bin.

### [Restore-MgBetaDriveRootListItemDocumentSetVersion](Restore-MgBetaDriveRootListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaDriveRootListItemVersion](Restore-MgBetaDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgBetaDriveRootVersion](Restore-MgBetaDriveRootVersion.md)
Restore a previous version of a DriveItem to be the current version.
This will create a new version with the contents of the previous version, but preserves all existing versions of the file.

### [Restore-MgBetaShareListItemDocumentSetVersion](Restore-MgBetaShareListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaShareListItemVersion](Restore-MgBetaShareListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgBetaDriveItemPermissionGrant](Revoke-MgBetaDriveItemPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaDriveRootPermissionGrant](Revoke-MgBetaDriveRootPermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Revoke-MgBetaSharePermissionGrant](Revoke-MgBetaSharePermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

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
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgBetaShareListContentType](Unpublish-MgBetaShareListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgBetaDrive](Update-MgBetaDrive.md)
Update entity in drives

### [Update-MgBetaDriveItem](Update-MgBetaDriveItem.md)
Update the navigation property items in drives

### [Update-MgBetaDriveItemListItem](Update-MgBetaDriveItemListItem.md)
Update the navigation property listItem in drives

### [Update-MgBetaDriveItemListItemDocumentSetVersion](Update-MgBetaDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveItemListItemField](Update-MgBetaDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaDriveItemListItemVersion](Update-MgBetaDriveItemListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveItemListItemVersionField](Update-MgBetaDriveItemListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveItemPermission](Update-MgBetaDriveItemPermission.md)
Update the navigation property permissions in drives

### [Update-MgBetaDriveItemSubscription](Update-MgBetaDriveItemSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveItemThumbnail](Update-MgBetaDriveItemThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgBetaDriveItemVersion](Update-MgBetaDriveItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveList](Update-MgBetaDriveList.md)
Update the navigation property list in drives

### [Update-MgBetaDriveListColumn](Update-MgBetaDriveListColumn.md)
Update the navigation property columns in drives

### [Update-MgBetaDriveListContentType](Update-MgBetaDriveListContentType.md)
Update the navigation property contentTypes in drives

### [Update-MgBetaDriveListContentTypeColumn](Update-MgBetaDriveListContentTypeColumn.md)
Update the navigation property columns in drives

### [Update-MgBetaDriveListContentTypeColumnLink](Update-MgBetaDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in drives

### [Update-MgBetaDriveListItem](Update-MgBetaDriveListItem.md)
Update the navigation property items in drives

### [Update-MgBetaDriveListItemDocumentSetVersion](Update-MgBetaDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveListItemField](Update-MgBetaDriveListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaDriveListItemVersion](Update-MgBetaDriveListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveListItemVersionField](Update-MgBetaDriveListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveListOperation](Update-MgBetaDriveListOperation.md)
Update the navigation property operations in drives

### [Update-MgBetaDriveListSubscription](Update-MgBetaDriveListSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveRoot](Update-MgBetaDriveRoot.md)
Update the navigation property root in drives

### [Update-MgBetaDriveRootListItem](Update-MgBetaDriveRootListItem.md)
Update the navigation property listItem in drives

### [Update-MgBetaDriveRootListItemDocumentSetVersion](Update-MgBetaDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgBetaDriveRootListItemField](Update-MgBetaDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaDriveRootListItemVersion](Update-MgBetaDriveRootListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaDriveRootListItemVersionField](Update-MgBetaDriveRootListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgBetaDriveRootPermission](Update-MgBetaDriveRootPermission.md)
Update the navigation property permissions in drives

### [Update-MgBetaDriveRootSubscription](Update-MgBetaDriveRootSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgBetaDriveRootThumbnail](Update-MgBetaDriveRootThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgBetaDriveRootVersion](Update-MgBetaDriveRootVersion.md)
Update the navigation property versions in drives

### [Update-MgBetaGroupDrive](Update-MgBetaGroupDrive.md)
Update the navigation property drives in groups

### [Update-MgBetaGroupDriveItem](Update-MgBetaGroupDriveItem.md)
Update the navigation property items in groups

### [Update-MgBetaGroupDriveItemListItem](Update-MgBetaGroupDriveItemListItem.md)
Update the navigation property listItem in groups

### [Update-MgBetaGroupDriveItemListItemDocumentSetVersion](Update-MgBetaGroupDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveItemListItemField](Update-MgBetaGroupDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaGroupDriveItemListItemVersion](Update-MgBetaGroupDriveItemListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveItemListItemVersionField](Update-MgBetaGroupDriveItemListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveItemPermission](Update-MgBetaGroupDriveItemPermission.md)
Update the navigation property permissions in groups

### [Update-MgBetaGroupDriveItemSubscription](Update-MgBetaGroupDriveItemSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveItemThumbnail](Update-MgBetaGroupDriveItemThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgBetaGroupDriveItemVersion](Update-MgBetaGroupDriveItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveList](Update-MgBetaGroupDriveList.md)
Update the navigation property list in groups

### [Update-MgBetaGroupDriveListColumn](Update-MgBetaGroupDriveListColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupDriveListContentType](Update-MgBetaGroupDriveListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgBetaGroupDriveListContentTypeColumn](Update-MgBetaGroupDriveListContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupDriveListContentTypeColumnLink](Update-MgBetaGroupDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgBetaGroupDriveListItem](Update-MgBetaGroupDriveListItem.md)
Update the navigation property items in groups

### [Update-MgBetaGroupDriveListItemDocumentSetVersion](Update-MgBetaGroupDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveListItemField](Update-MgBetaGroupDriveListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaGroupDriveListItemVersion](Update-MgBetaGroupDriveListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveListItemVersionField](Update-MgBetaGroupDriveListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveListOperation](Update-MgBetaGroupDriveListOperation.md)
Update the navigation property operations in groups

### [Update-MgBetaGroupDriveListSubscription](Update-MgBetaGroupDriveListSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveRoot](Update-MgBetaGroupDriveRoot.md)
Update the navigation property root in groups

### [Update-MgBetaGroupDriveRootListItem](Update-MgBetaGroupDriveRootListItem.md)
Update the navigation property listItem in groups

### [Update-MgBetaGroupDriveRootListItemDocumentSetVersion](Update-MgBetaGroupDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupDriveRootListItemField](Update-MgBetaGroupDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaGroupDriveRootListItemVersion](Update-MgBetaGroupDriveRootListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupDriveRootListItemVersionField](Update-MgBetaGroupDriveRootListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupDriveRootPermission](Update-MgBetaGroupDriveRootPermission.md)
Update the navigation property permissions in groups

### [Update-MgBetaGroupDriveRootSubscription](Update-MgBetaGroupDriveRootSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupDriveRootThumbnail](Update-MgBetaGroupDriveRootThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgBetaGroupDriveRootVersion](Update-MgBetaGroupDriveRootVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaShareList](Update-MgBetaShareList.md)
Update the navigation property list in shares

### [Update-MgBetaShareListColumn](Update-MgBetaShareListColumn.md)
Update the navigation property columns in shares

### [Update-MgBetaShareListContentType](Update-MgBetaShareListContentType.md)
Update the navigation property contentTypes in shares

### [Update-MgBetaShareListContentTypeColumn](Update-MgBetaShareListContentTypeColumn.md)
Update the navigation property columns in shares

### [Update-MgBetaShareListContentTypeColumnLink](Update-MgBetaShareListContentTypeColumnLink.md)
Update the navigation property columnLinks in shares

### [Update-MgBetaShareListItem](Update-MgBetaShareListItem.md)
Update the navigation property items in shares

### [Update-MgBetaShareListItemDocumentSetVersion](Update-MgBetaShareListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in shares

### [Update-MgBetaShareListItemField](Update-MgBetaShareListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaShareListItemVersion](Update-MgBetaShareListItemVersion.md)
Update the navigation property versions in shares

### [Update-MgBetaShareListItemVersionField](Update-MgBetaShareListItemVersionField.md)
Update the navigation property fields in shares

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

### [Update-MgBetaUserDriveItem](Update-MgBetaUserDriveItem.md)
Update the navigation property items in users

### [Update-MgBetaUserDriveItemListItem](Update-MgBetaUserDriveItemListItem.md)
Update the navigation property listItem in users

### [Update-MgBetaUserDriveItemListItemDocumentSetVersion](Update-MgBetaUserDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveItemListItemField](Update-MgBetaUserDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaUserDriveItemListItemVersion](Update-MgBetaUserDriveItemListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveItemListItemVersionField](Update-MgBetaUserDriveItemListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveItemPermission](Update-MgBetaUserDriveItemPermission.md)
Update the navigation property permissions in users

### [Update-MgBetaUserDriveItemSubscription](Update-MgBetaUserDriveItemSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveItemThumbnail](Update-MgBetaUserDriveItemThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgBetaUserDriveItemVersion](Update-MgBetaUserDriveItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveList](Update-MgBetaUserDriveList.md)
Update the navigation property list in users

### [Update-MgBetaUserDriveListColumn](Update-MgBetaUserDriveListColumn.md)
Update the navigation property columns in users

### [Update-MgBetaUserDriveListContentType](Update-MgBetaUserDriveListContentType.md)
Update the navigation property contentTypes in users

### [Update-MgBetaUserDriveListContentTypeColumn](Update-MgBetaUserDriveListContentTypeColumn.md)
Update the navigation property columns in users

### [Update-MgBetaUserDriveListContentTypeColumnLink](Update-MgBetaUserDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in users

### [Update-MgBetaUserDriveListItem](Update-MgBetaUserDriveListItem.md)
Update the navigation property items in users

### [Update-MgBetaUserDriveListItemDocumentSetVersion](Update-MgBetaUserDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveListItemField](Update-MgBetaUserDriveListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaUserDriveListItemVersion](Update-MgBetaUserDriveListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveListItemVersionField](Update-MgBetaUserDriveListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveListOperation](Update-MgBetaUserDriveListOperation.md)
Update the navigation property operations in users

### [Update-MgBetaUserDriveListSubscription](Update-MgBetaUserDriveListSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveRoot](Update-MgBetaUserDriveRoot.md)
Update the navigation property root in users

### [Update-MgBetaUserDriveRootListItem](Update-MgBetaUserDriveRootListItem.md)
Update the navigation property listItem in users

### [Update-MgBetaUserDriveRootListItemDocumentSetVersion](Update-MgBetaUserDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgBetaUserDriveRootListItemField](Update-MgBetaUserDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaUserDriveRootListItemVersion](Update-MgBetaUserDriveRootListItemVersion.md)
Update the navigation property versions in users

### [Update-MgBetaUserDriveRootListItemVersionField](Update-MgBetaUserDriveRootListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgBetaUserDriveRootPermission](Update-MgBetaUserDriveRootPermission.md)
Update the navigation property permissions in users

### [Update-MgBetaUserDriveRootSubscription](Update-MgBetaUserDriveRootSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgBetaUserDriveRootThumbnail](Update-MgBetaUserDriveRootThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgBetaUserDriveRootVersion](Update-MgBetaUserDriveRootVersion.md)
Update the navigation property versions in users

