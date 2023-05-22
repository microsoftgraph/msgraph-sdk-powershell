---
Module Name: Microsoft.Graph.Files
Module Guid: 5e670f0a-51f4-4703-ab9d-f81eec4577f8
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Files Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Files Cmdlets
### [Add-MgDriveListContentTypeCopy](Add-MgDriveListContentTypeCopy.md)
Invoke action addCopy

### [Add-MgDriveListContentTypeCopyFromContentTypeHub](Add-MgDriveListContentTypeCopyFromContentTypeHub.md)
Invoke action addCopyFromContentTypeHub

### [Add-MgShareListContentTypeCopy](Add-MgShareListContentTypeCopy.md)
Invoke action addCopy

### [Add-MgShareListContentTypeCopyFromContentTypeHub](Add-MgShareListContentTypeCopyFromContentTypeHub.md)
Invoke action addCopyFromContentTypeHub

### [Copy-MgDriveItem](Copy-MgDriveItem.md)
Invoke action copy

### [Copy-MgDriveListContentTypeToDefaultContentLocation](Copy-MgDriveListContentTypeToDefaultContentLocation.md)
Invoke action copyToDefaultContentLocation

### [Copy-MgDriveRoot](Copy-MgDriveRoot.md)
Invoke action copy

### [Copy-MgShareListContentTypeToDefaultContentLocation](Copy-MgShareListContentTypeToDefaultContentLocation.md)
Invoke action copyToDefaultContentLocation

### [Get-MgDrive](Get-MgDrive.md)
Get entity from drives by key

### [Get-MgDriveBundle](Get-MgDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgDriveBundleContent](Get-MgDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveFollowing](Get-MgDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgDriveFollowingContent](Get-MgDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItem](Get-MgDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgDriveItemActivityByInterval](Get-MgDriveItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveItemAnalytic](Get-MgDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveItemAnalyticItemActivityStat](Get-MgDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgDriveItemAnalyticItemActivityStatActivity](Get-MgDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgDriveItemAnalyticLastSevenDay](Get-MgDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgDriveItemAnalyticTime](Get-MgDriveItemAnalyticTime.md)
Get allTime from drives

### [Get-MgDriveItemChild](Get-MgDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgDriveItemChildContent](Get-MgDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemContent](Get-MgDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemDelta](Get-MgDriveItemDelta.md)
Invoke function delta

### [Get-MgDriveItemListItem](Get-MgDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgDriveItemListItemActivityByInterval](Get-MgDriveItemListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveItemListItemAnalytic](Get-MgDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveItemListItemDocumentSetVersion](Get-MgDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgDriveItemListItemDriveItem](Get-MgDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveItemListItemDriveItemContent](Get-MgDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveItemListItemField](Get-MgDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveItemListItemVersion](Get-MgDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgDriveItemListItemVersionField](Get-MgDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveItemPermission](Get-MgDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgDriveItemSubscription](Get-MgDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgDriveItemThumbnail](Get-MgDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgDriveItemVersion](Get-MgDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgDriveItemVersionContent](Get-MgDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgDriveList](Get-MgDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgDriveListColumn](Get-MgDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgDriveListColumnSourceColumn](Get-MgDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgDriveListContentType](Get-MgDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgDriveListContentTypeBase](Get-MgDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgDriveListContentTypeBaseType](Get-MgDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgDriveListContentTypeColumn](Get-MgDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgDriveListContentTypeColumnLink](Get-MgDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgDriveListContentTypeColumnPosition](Get-MgDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgDriveListContentTypeColumnSourceColumn](Get-MgDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgDriveListContentTypeCompatibleHubContentType](Get-MgDriveListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgDriveListDrive](Get-MgDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgDriveListItem](Get-MgDriveListItem.md)
All items contained in the list.

### [Get-MgDriveListItemActivityByInterval](Get-MgDriveListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveListItemAnalytic](Get-MgDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveListItemDocumentSetVersion](Get-MgDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgDriveListItemDriveItem](Get-MgDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveListItemDriveItemContent](Get-MgDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveListItemField](Get-MgDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveListItemVersion](Get-MgDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgDriveListItemVersionField](Get-MgDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveListOperation](Get-MgDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgDriveListSubscription](Get-MgDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgDriveRoot](Get-MgDriveRoot.md)
The root folder of the drive.
Read-only.

### [Get-MgDriveRootActivityByInterval](Get-MgDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveRootAnalytic](Get-MgDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveRootAnalyticItemActivityStat](Get-MgDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from drives

### [Get-MgDriveRootAnalyticItemActivityStatActivity](Get-MgDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgDriveRootAnalyticLastSevenDay](Get-MgDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from drives

### [Get-MgDriveRootAnalyticTime](Get-MgDriveRootAnalyticTime.md)
Get allTime from drives

### [Get-MgDriveRootChild](Get-MgDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgDriveRootChildContent](Get-MgDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootContent](Get-MgDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootDelta](Get-MgDriveRootDelta.md)
Invoke function delta

### [Get-MgDriveRootListItem](Get-MgDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgDriveRootListItemActivityByInterval](Get-MgDriveRootListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveRootListItemAnalytic](Get-MgDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgDriveRootListItemDocumentSetVersion](Get-MgDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgDriveRootListItemDriveItem](Get-MgDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgDriveRootListItemDriveItemContent](Get-MgDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgDriveRootListItemField](Get-MgDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgDriveRootListItemVersion](Get-MgDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgDriveRootListItemVersionField](Get-MgDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgDriveRootPermission](Get-MgDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgDriveRootSubscription](Get-MgDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgDriveRootThumbnail](Get-MgDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgDriveRootVersion](Get-MgDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgDriveRootVersionContent](Get-MgDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgDriveSpecial](Get-MgDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgDriveSpecialContent](Get-MgDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDefaultDrive](Get-MgGroupDefaultDrive.md)
The group's default drive.
Read-only.

### [Get-MgGroupDrive](Get-MgGroupDrive.md)
The group's drives.
Read-only.

### [Get-MgGroupDriveBundle](Get-MgGroupDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgGroupDriveBundleContent](Get-MgGroupDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveFollowing](Get-MgGroupDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgGroupDriveFollowingContent](Get-MgGroupDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItem](Get-MgGroupDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgGroupDriveItemAnalytic](Get-MgGroupDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveItemAnalyticItemActivityStat](Get-MgGroupDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgGroupDriveItemAnalyticItemActivityStatActivity](Get-MgGroupDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgGroupDriveItemAnalyticLastSevenDay](Get-MgGroupDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgGroupDriveItemAnalyticTime](Get-MgGroupDriveItemAnalyticTime.md)
Get allTime from groups

### [Get-MgGroupDriveItemChild](Get-MgGroupDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgGroupDriveItemChildContent](Get-MgGroupDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemContent](Get-MgGroupDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemListItem](Get-MgGroupDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgGroupDriveItemListItemAnalytic](Get-MgGroupDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveItemListItemDocumentSetVersion](Get-MgGroupDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgGroupDriveItemListItemDriveItem](Get-MgGroupDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveItemListItemDriveItemContent](Get-MgGroupDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveItemListItemField](Get-MgGroupDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveItemListItemVersion](Get-MgGroupDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgGroupDriveItemListItemVersionField](Get-MgGroupDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveItemPermission](Get-MgGroupDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgGroupDriveItemSubscription](Get-MgGroupDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgGroupDriveItemThumbnail](Get-MgGroupDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgGroupDriveItemVersion](Get-MgGroupDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgGroupDriveItemVersionContent](Get-MgGroupDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgGroupDriveList](Get-MgGroupDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgGroupDriveListColumn](Get-MgGroupDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgGroupDriveListColumnSourceColumn](Get-MgGroupDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgGroupDriveListContentType](Get-MgGroupDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgGroupDriveListContentTypeBase](Get-MgGroupDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgGroupDriveListContentTypeBaseType](Get-MgGroupDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgGroupDriveListContentTypeColumn](Get-MgGroupDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgGroupDriveListContentTypeColumnLink](Get-MgGroupDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgGroupDriveListContentTypeColumnPosition](Get-MgGroupDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgGroupDriveListContentTypeColumnSourceColumn](Get-MgGroupDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgGroupDriveListDrive](Get-MgGroupDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgGroupDriveListItem](Get-MgGroupDriveListItem.md)
All items contained in the list.

### [Get-MgGroupDriveListItemAnalytic](Get-MgGroupDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveListItemDocumentSetVersion](Get-MgGroupDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgGroupDriveListItemDriveItem](Get-MgGroupDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveListItemDriveItemContent](Get-MgGroupDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveListItemField](Get-MgGroupDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveListItemVersion](Get-MgGroupDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgGroupDriveListItemVersionField](Get-MgGroupDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveListOperation](Get-MgGroupDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgGroupDriveListSubscription](Get-MgGroupDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgGroupDriveRoot](Get-MgGroupDriveRoot.md)
The root folder of the drive.
Read-only.

### [Get-MgGroupDriveRootAnalytic](Get-MgGroupDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveRootAnalyticItemActivityStat](Get-MgGroupDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from groups

### [Get-MgGroupDriveRootAnalyticItemActivityStatActivity](Get-MgGroupDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgGroupDriveRootAnalyticLastSevenDay](Get-MgGroupDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from groups

### [Get-MgGroupDriveRootAnalyticTime](Get-MgGroupDriveRootAnalyticTime.md)
Get allTime from groups

### [Get-MgGroupDriveRootChild](Get-MgGroupDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgGroupDriveRootChildContent](Get-MgGroupDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootContent](Get-MgGroupDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootListItem](Get-MgGroupDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgGroupDriveRootListItemAnalytic](Get-MgGroupDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupDriveRootListItemDocumentSetVersion](Get-MgGroupDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgGroupDriveRootListItemDriveItem](Get-MgGroupDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupDriveRootListItemDriveItemContent](Get-MgGroupDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupDriveRootListItemField](Get-MgGroupDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupDriveRootListItemVersion](Get-MgGroupDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgGroupDriveRootListItemVersionField](Get-MgGroupDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupDriveRootPermission](Get-MgGroupDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgGroupDriveRootSubscription](Get-MgGroupDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgGroupDriveRootThumbnail](Get-MgGroupDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgGroupDriveRootVersion](Get-MgGroupDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgGroupDriveRootVersionContent](Get-MgGroupDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgGroupDriveSpecial](Get-MgGroupDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgGroupDriveSpecialContent](Get-MgGroupDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Get-MgShareDriveItem](Get-MgShareDriveItem.md)
Used to access the underlying driveItem

### [Get-MgShareDriveItemContent](Get-MgShareDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareItem](Get-MgShareItem.md)
All driveItems contained in the sharing root.
This collection cannot be enumerated.

### [Get-MgShareItemContent](Get-MgShareItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareList](Get-MgShareList.md)
Used to access the underlying list

### [Get-MgShareListColumn](Get-MgShareListColumn.md)
The collection of field definitions for this list.

### [Get-MgShareListColumnSourceColumn](Get-MgShareListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgShareListContentType](Get-MgShareListContentType.md)
The collection of content types present in this list.

### [Get-MgShareListContentTypeBase](Get-MgShareListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgShareListContentTypeBaseType](Get-MgShareListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgShareListContentTypeColumn](Get-MgShareListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgShareListContentTypeColumnLink](Get-MgShareListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgShareListContentTypeColumnPosition](Get-MgShareListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgShareListContentTypeColumnSourceColumn](Get-MgShareListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgShareListContentTypeCompatibleHubContentType](Get-MgShareListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgShareListDrive](Get-MgShareListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgShareListItem](Get-MgShareListItem.md)
All items contained in the list.

### [Get-MgShareListItemActivityByInterval](Get-MgShareListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgShareListItemAnalytic](Get-MgShareListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgShareListItemDocumentSetVersion](Get-MgShareListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgShareListItemDriveItem](Get-MgShareListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgShareListItemDriveItemContent](Get-MgShareListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgShareListItemField](Get-MgShareListItemField.md)
The values of the columns set on this list item.

### [Get-MgShareListItemVersion](Get-MgShareListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgShareListItemVersionField](Get-MgShareListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgShareListOperation](Get-MgShareListOperation.md)
The collection of long-running operations on the list.

### [Get-MgShareListSubscription](Get-MgShareListSubscription.md)
The set of subscriptions on the list.

### [Get-MgSharePermission](Get-MgSharePermission.md)
Used to access the permission representing the underlying sharing link

### [Get-MgShareRoot](Get-MgShareRoot.md)
Used to access the underlying driveItem.
Deprecated -- use driveItem instead.

### [Get-MgShareRootContent](Get-MgShareRootContent.md)
The content stream, if the item represents a file.

### [Get-MgShareSharedDriveItemSharedDriveItem](Get-MgShareSharedDriveItemSharedDriveItem.md)
Access a shared DriveItem or a collection of shared items by using a **shareId** or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

### [Get-MgShareSite](Get-MgShareSite.md)
Used to access the underlying site

### [Get-MgUserDefaultDrive](Get-MgUserDefaultDrive.md)
The user's OneDrive.
Read-only.

### [Get-MgUserDrive](Get-MgUserDrive.md)
A collection of drives available for this user.
Read-only.

### [Get-MgUserDriveBundle](Get-MgUserDriveBundle.md)
Collection of [bundles][bundle] (albums and multi-select-shared sets of items).
Only in personal OneDrive.

### [Get-MgUserDriveBundleContent](Get-MgUserDriveBundleContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveFollowing](Get-MgUserDriveFollowing.md)
The list of items the user is following.
Only in OneDrive for Business.

### [Get-MgUserDriveFollowingContent](Get-MgUserDriveFollowingContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItem](Get-MgUserDriveItem.md)
All items contained in the drive.
Read-only.
Nullable.

### [Get-MgUserDriveItemAnalytic](Get-MgUserDriveItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveItemAnalyticItemActivityStat](Get-MgUserDriveItemAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgUserDriveItemAnalyticItemActivityStatActivity](Get-MgUserDriveItemAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgUserDriveItemAnalyticLastSevenDay](Get-MgUserDriveItemAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgUserDriveItemAnalyticTime](Get-MgUserDriveItemAnalyticTime.md)
Get allTime from users

### [Get-MgUserDriveItemChild](Get-MgUserDriveItemChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgUserDriveItemChildContent](Get-MgUserDriveItemChildContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemContent](Get-MgUserDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemListItem](Get-MgUserDriveItemListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgUserDriveItemListItemAnalytic](Get-MgUserDriveItemListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveItemListItemDocumentSetVersion](Get-MgUserDriveItemListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgUserDriveItemListItemDriveItem](Get-MgUserDriveItemListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveItemListItemDriveItemContent](Get-MgUserDriveItemListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveItemListItemField](Get-MgUserDriveItemListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveItemListItemVersion](Get-MgUserDriveItemListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgUserDriveItemListItemVersionField](Get-MgUserDriveItemListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveItemPermission](Get-MgUserDriveItemPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgUserDriveItemSubscription](Get-MgUserDriveItemSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgUserDriveItemThumbnail](Get-MgUserDriveItemThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgUserDriveItemVersion](Get-MgUserDriveItemVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgUserDriveItemVersionContent](Get-MgUserDriveItemVersionContent.md)
The content stream for this version of the item.

### [Get-MgUserDriveList](Get-MgUserDriveList.md)
For drives in SharePoint, the underlying document library list.
Read-only.
Nullable.

### [Get-MgUserDriveListColumn](Get-MgUserDriveListColumn.md)
The collection of field definitions for this list.

### [Get-MgUserDriveListColumnSourceColumn](Get-MgUserDriveListColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgUserDriveListContentType](Get-MgUserDriveListContentType.md)
The collection of content types present in this list.

### [Get-MgUserDriveListContentTypeBase](Get-MgUserDriveListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgUserDriveListContentTypeBaseType](Get-MgUserDriveListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgUserDriveListContentTypeColumn](Get-MgUserDriveListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgUserDriveListContentTypeColumnLink](Get-MgUserDriveListContentTypeColumnLink.md)
The collection of columns that are required by this content type.

### [Get-MgUserDriveListContentTypeColumnPosition](Get-MgUserDriveListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgUserDriveListContentTypeColumnSourceColumn](Get-MgUserDriveListContentTypeColumnSourceColumn.md)
The source column for the content type column.

### [Get-MgUserDriveListDrive](Get-MgUserDriveListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgUserDriveListItem](Get-MgUserDriveListItem.md)
All items contained in the list.

### [Get-MgUserDriveListItemAnalytic](Get-MgUserDriveListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveListItemDocumentSetVersion](Get-MgUserDriveListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgUserDriveListItemDriveItem](Get-MgUserDriveListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveListItemDriveItemContent](Get-MgUserDriveListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveListItemField](Get-MgUserDriveListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveListItemVersion](Get-MgUserDriveListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgUserDriveListItemVersionField](Get-MgUserDriveListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveListOperation](Get-MgUserDriveListOperation.md)
The collection of long-running operations on the list.

### [Get-MgUserDriveListSubscription](Get-MgUserDriveListSubscription.md)
The set of subscriptions on the list.

### [Get-MgUserDriveRoot](Get-MgUserDriveRoot.md)
The root folder of the drive.
Read-only.

### [Get-MgUserDriveRootAnalytic](Get-MgUserDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveRootAnalyticItemActivityStat](Get-MgUserDriveRootAnalyticItemActivityStat.md)
Get itemActivityStats from users

### [Get-MgUserDriveRootAnalyticItemActivityStatActivity](Get-MgUserDriveRootAnalyticItemActivityStatActivity.md)
Exposes the itemActivities represented in this itemActivityStat resource.

### [Get-MgUserDriveRootAnalyticLastSevenDay](Get-MgUserDriveRootAnalyticLastSevenDay.md)
Get lastSevenDays from users

### [Get-MgUserDriveRootAnalyticTime](Get-MgUserDriveRootAnalyticTime.md)
Get allTime from users

### [Get-MgUserDriveRootChild](Get-MgUserDriveRootChild.md)
Collection containing Item objects for the immediate children of Item.
Only items representing folders have children.
Read-only.
Nullable.

### [Get-MgUserDriveRootChildContent](Get-MgUserDriveRootChildContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootContent](Get-MgUserDriveRootContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootListItem](Get-MgUserDriveRootListItem.md)
For drives in SharePoint, the associated document library list item.
Read-only.
Nullable.

### [Get-MgUserDriveRootListItemAnalytic](Get-MgUserDriveRootListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgUserDriveRootListItemDocumentSetVersion](Get-MgUserDriveRootListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgUserDriveRootListItemDriveItem](Get-MgUserDriveRootListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgUserDriveRootListItemDriveItemContent](Get-MgUserDriveRootListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgUserDriveRootListItemField](Get-MgUserDriveRootListItemField.md)
The values of the columns set on this list item.

### [Get-MgUserDriveRootListItemVersion](Get-MgUserDriveRootListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgUserDriveRootListItemVersionField](Get-MgUserDriveRootListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgUserDriveRootPermission](Get-MgUserDriveRootPermission.md)
The set of permissions for the item.
Read-only.
Nullable.

### [Get-MgUserDriveRootSubscription](Get-MgUserDriveRootSubscription.md)
The set of subscriptions on the item.
Only supported on the root of a drive.

### [Get-MgUserDriveRootThumbnail](Get-MgUserDriveRootThumbnail.md)
Collection containing [ThumbnailSet][] objects associated with the item.
For more info, see [getting thumbnails][].
Read-only.
Nullable.

### [Get-MgUserDriveRootVersion](Get-MgUserDriveRootVersion.md)
The list of previous versions of the item.
For more info, see [getting previous versions][].
Read-only.
Nullable.

### [Get-MgUserDriveRootVersionContent](Get-MgUserDriveRootVersionContent.md)
The content stream for this version of the item.

### [Get-MgUserDriveSpecial](Get-MgUserDriveSpecial.md)
Collection of common folders available in OneDrive.
Read-only.
Nullable.

### [Get-MgUserDriveSpecialContent](Get-MgUserDriveSpecialContent.md)
The content stream, if the item represents a file.

### [Grant-MgDriveItemPermission](Grant-MgDriveItemPermission.md)
Invoke action grant

### [Grant-MgDriveRootPermission](Grant-MgDriveRootPermission.md)
Invoke action grant

### [Grant-MgSharePermission](Grant-MgSharePermission.md)
Invoke action grant

### [Invoke-MgCheckinDriveItem](Invoke-MgCheckinDriveItem.md)
Invoke action checkin

### [Invoke-MgCheckinDriveRoot](Invoke-MgCheckinDriveRoot.md)
Invoke action checkin

### [Invoke-MgCheckoutDriveItem](Invoke-MgCheckoutDriveItem.md)
Invoke action checkout

### [Invoke-MgCheckoutDriveRoot](Invoke-MgCheckoutDriveRoot.md)
Invoke action checkout

### [Invoke-MgFollowDriveItem](Invoke-MgFollowDriveItem.md)
Invoke action follow

### [Invoke-MgFollowDriveRoot](Invoke-MgFollowDriveRoot.md)
Invoke action follow

### [Invoke-MgGraphDrive](Invoke-MgGraphDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteDriveItem](Invoke-MgInviteDriveItem.md)
Invoke action invite

### [Invoke-MgInviteDriveRoot](Invoke-MgInviteDriveRoot.md)
Invoke action invite

### [Invoke-MgPreviewDriveItem](Invoke-MgPreviewDriveItem.md)
Invoke action preview

### [Invoke-MgPreviewDriveRoot](Invoke-MgPreviewDriveRoot.md)
Invoke action preview

### [Invoke-MgReauthorizeDriveItemSubscription](Invoke-MgReauthorizeDriveItemSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeDriveListSubscription](Invoke-MgReauthorizeDriveListSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeDriveRootSubscription](Invoke-MgReauthorizeDriveRootSubscription.md)
Invoke action reauthorize

### [Invoke-MgReauthorizeShareListSubscription](Invoke-MgReauthorizeShareListSubscription.md)
Invoke action reauthorize

### [Invoke-MgRecentDrive](Invoke-MgRecentDrive.md)
Invoke function recent

### [Invoke-MgUnfollowDriveItem](Invoke-MgUnfollowDriveItem.md)
Invoke action unfollow

### [Invoke-MgUnfollowDriveRoot](Invoke-MgUnfollowDriveRoot.md)
Invoke action unfollow

### [Join-MgDriveListContentTypeWithHubSite](Join-MgDriveListContentTypeWithHubSite.md)
Invoke action associateWithHubSites

### [Join-MgShareListContentTypeWithHubSite](Join-MgShareListContentTypeWithHubSite.md)
Invoke action associateWithHubSites

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
Invoke action createLink

### [New-MgDriveItemListItemDocumentSetVersion](New-MgDriveItemListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for drives

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
Create new navigation property to columns for drives

### [New-MgDriveListContentType](New-MgDriveListContentType.md)
Create new navigation property to contentTypes for drives

### [New-MgDriveListContentTypeColumn](New-MgDriveListContentTypeColumn.md)
Create new navigation property to columns for drives

### [New-MgDriveListContentTypeColumnLink](New-MgDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for drives

### [New-MgDriveListItem](New-MgDriveListItem.md)
Create new navigation property to items for drives

### [New-MgDriveListItemDocumentSetVersion](New-MgDriveListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for drives

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
Invoke action createLink

### [New-MgDriveRootListItemDocumentSetVersion](New-MgDriveRootListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for drives

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
Create new navigation property to documentSetVersions for groups

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
Create new navigation property to columns for groups

### [New-MgGroupDriveListContentType](New-MgGroupDriveListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgGroupDriveListContentTypeColumn](New-MgGroupDriveListContentTypeColumn.md)
Create new navigation property to columns for groups

### [New-MgGroupDriveListContentTypeColumnLink](New-MgGroupDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgGroupDriveListItem](New-MgGroupDriveListItem.md)
Create new navigation property to items for groups

### [New-MgGroupDriveListItemDocumentSetVersion](New-MgGroupDriveListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for groups

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
Create new navigation property to documentSetVersions for groups

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
Create new navigation property to columns for shares

### [New-MgShareListContentType](New-MgShareListContentType.md)
Create new navigation property to contentTypes for shares

### [New-MgShareListContentTypeColumn](New-MgShareListContentTypeColumn.md)
Create new navigation property to columns for shares

### [New-MgShareListContentTypeColumnLink](New-MgShareListContentTypeColumnLink.md)
Create new navigation property to columnLinks for shares

### [New-MgShareListItem](New-MgShareListItem.md)
Create new navigation property to items for shares

### [New-MgShareListItemDocumentSetVersion](New-MgShareListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for shares

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
Create new navigation property to documentSetVersions for users

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
Create new navigation property to columns for users

### [New-MgUserDriveListContentType](New-MgUserDriveListContentType.md)
Create new navigation property to contentTypes for users

### [New-MgUserDriveListContentTypeColumn](New-MgUserDriveListContentTypeColumn.md)
Create new navigation property to columns for users

### [New-MgUserDriveListContentTypeColumnLink](New-MgUserDriveListContentTypeColumnLink.md)
Create new navigation property to columnLinks for users

### [New-MgUserDriveListItem](New-MgUserDriveListItem.md)
Create new navigation property to items for users

### [New-MgUserDriveListItemDocumentSetVersion](New-MgUserDriveListItemDocumentSetVersion.md)
Create new navigation property to documentSetVersions for users

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
Create new navigation property to documentSetVersions for users

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
Invoke action publish

### [Publish-MgShareListContentType](Publish-MgShareListContentType.md)
Invoke action publish

### [Remove-MgDrive](Remove-MgDrive.md)
Delete entity from drives

### [Remove-MgDriveItem](Remove-MgDriveItem.md)
Delete navigation property items for drives

### [Remove-MgDriveItemAnalytic](Remove-MgDriveItemAnalytic.md)
Delete navigation property analytics for drives

### [Remove-MgDriveItemAnalyticItemActivityStat](Remove-MgDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for drives

### [Remove-MgDriveItemListItem](Remove-MgDriveItemListItem.md)
Delete navigation property listItem for drives

### [Remove-MgDriveItemListItemDocumentSetVersion](Remove-MgDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

### [Remove-MgDriveItemListItemField](Remove-MgDriveItemListItemField.md)
Delete navigation property fields for drives

### [Remove-MgDriveItemListItemVersion](Remove-MgDriveItemListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveItemListItemVersionField](Remove-MgDriveItemListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveItemPermission](Remove-MgDriveItemPermission.md)
Delete navigation property permissions for drives

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
Delete navigation property columns for drives

### [Remove-MgDriveListContentTypeColumnLink](Remove-MgDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for drives

### [Remove-MgDriveListItem](Remove-MgDriveListItem.md)
Delete navigation property items for drives

### [Remove-MgDriveListItemDocumentSetVersion](Remove-MgDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

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

### [Remove-MgDriveRootListItem](Remove-MgDriveRootListItem.md)
Delete navigation property listItem for drives

### [Remove-MgDriveRootListItemDocumentSetVersion](Remove-MgDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for drives

### [Remove-MgDriveRootListItemField](Remove-MgDriveRootListItemField.md)
Delete navigation property fields for drives

### [Remove-MgDriveRootListItemVersion](Remove-MgDriveRootListItemVersion.md)
Delete navigation property versions for drives

### [Remove-MgDriveRootListItemVersionField](Remove-MgDriveRootListItemVersionField.md)
Delete navigation property fields for drives

### [Remove-MgDriveRootPermission](Remove-MgDriveRootPermission.md)
Delete navigation property permissions for drives

### [Remove-MgDriveRootSubscription](Remove-MgDriveRootSubscription.md)
Delete navigation property subscriptions for drives

### [Remove-MgDriveRootThumbnail](Remove-MgDriveRootThumbnail.md)
Delete navigation property thumbnails for drives

### [Remove-MgDriveRootVersion](Remove-MgDriveRootVersion.md)
Delete navigation property versions for drives

### [Remove-MgGroupDrive](Remove-MgGroupDrive.md)
Delete navigation property drives for groups

### [Remove-MgGroupDriveItem](Remove-MgGroupDriveItem.md)
Delete navigation property items for groups

### [Remove-MgGroupDriveItemAnalytic](Remove-MgGroupDriveItemAnalytic.md)
Delete navigation property analytics for groups

### [Remove-MgGroupDriveItemAnalyticItemActivityStat](Remove-MgGroupDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for groups

### [Remove-MgGroupDriveItemListItem](Remove-MgGroupDriveItemListItem.md)
Delete navigation property listItem for groups

### [Remove-MgGroupDriveItemListItemDocumentSetVersion](Remove-MgGroupDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgGroupDriveItemListItemField](Remove-MgGroupDriveItemListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveItemListItemVersion](Remove-MgGroupDriveItemListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveItemListItemVersionField](Remove-MgGroupDriveItemListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveItemPermission](Remove-MgGroupDriveItemPermission.md)
Delete navigation property permissions for groups

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
Delete navigation property columns for groups

### [Remove-MgGroupDriveListContentTypeColumnLink](Remove-MgGroupDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgGroupDriveListItem](Remove-MgGroupDriveListItem.md)
Delete navigation property items for groups

### [Remove-MgGroupDriveListItemDocumentSetVersion](Remove-MgGroupDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

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

### [Remove-MgGroupDriveRootListItem](Remove-MgGroupDriveRootListItem.md)
Delete navigation property listItem for groups

### [Remove-MgGroupDriveRootListItemDocumentSetVersion](Remove-MgGroupDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgGroupDriveRootListItemField](Remove-MgGroupDriveRootListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveRootListItemVersion](Remove-MgGroupDriveRootListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupDriveRootListItemVersionField](Remove-MgGroupDriveRootListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupDriveRootPermission](Remove-MgGroupDriveRootPermission.md)
Delete navigation property permissions for groups

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
Delete navigation property columns for shares

### [Remove-MgShareListContentTypeColumnLink](Remove-MgShareListContentTypeColumnLink.md)
Delete navigation property columnLinks for shares

### [Remove-MgShareListItem](Remove-MgShareListItem.md)
Delete navigation property items for shares

### [Remove-MgShareListItemDocumentSetVersion](Remove-MgShareListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for shares

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
Delete navigation property items for users

### [Remove-MgUserDriveItemAnalytic](Remove-MgUserDriveItemAnalytic.md)
Delete navigation property analytics for users

### [Remove-MgUserDriveItemAnalyticItemActivityStat](Remove-MgUserDriveItemAnalyticItemActivityStat.md)
Delete navigation property itemActivityStats for users

### [Remove-MgUserDriveItemListItem](Remove-MgUserDriveItemListItem.md)
Delete navigation property listItem for users

### [Remove-MgUserDriveItemListItemDocumentSetVersion](Remove-MgUserDriveItemListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

### [Remove-MgUserDriveItemListItemField](Remove-MgUserDriveItemListItemField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveItemListItemVersion](Remove-MgUserDriveItemListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveItemListItemVersionField](Remove-MgUserDriveItemListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveItemPermission](Remove-MgUserDriveItemPermission.md)
Delete navigation property permissions for users

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
Delete navigation property columns for users

### [Remove-MgUserDriveListContentTypeColumnLink](Remove-MgUserDriveListContentTypeColumnLink.md)
Delete navigation property columnLinks for users

### [Remove-MgUserDriveListItem](Remove-MgUserDriveListItem.md)
Delete navigation property items for users

### [Remove-MgUserDriveListItemDocumentSetVersion](Remove-MgUserDriveListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

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

### [Remove-MgUserDriveRootListItem](Remove-MgUserDriveRootListItem.md)
Delete navigation property listItem for users

### [Remove-MgUserDriveRootListItemDocumentSetVersion](Remove-MgUserDriveRootListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for users

### [Remove-MgUserDriveRootListItemField](Remove-MgUserDriveRootListItemField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveRootListItemVersion](Remove-MgUserDriveRootListItemVersion.md)
Delete navigation property versions for users

### [Remove-MgUserDriveRootListItemVersionField](Remove-MgUserDriveRootListItemVersionField.md)
Delete navigation property fields for users

### [Remove-MgUserDriveRootPermission](Remove-MgUserDriveRootPermission.md)
Delete navigation property permissions for users

### [Remove-MgUserDriveRootSubscription](Remove-MgUserDriveRootSubscription.md)
Delete navigation property subscriptions for users

### [Remove-MgUserDriveRootThumbnail](Remove-MgUserDriveRootThumbnail.md)
Delete navigation property thumbnails for users

### [Remove-MgUserDriveRootVersion](Remove-MgUserDriveRootVersion.md)
Delete navigation property versions for users

### [Restore-MgDriveItem](Restore-MgDriveItem.md)
Invoke action restore

### [Restore-MgDriveItemListItemDocumentSetVersion](Restore-MgDriveItemListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgDriveItemListItemVersion](Restore-MgDriveItemListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgDriveItemVersion](Restore-MgDriveItemVersion.md)
Invoke action restoreVersion

### [Restore-MgDriveListItemDocumentSetVersion](Restore-MgDriveListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgDriveListItemVersion](Restore-MgDriveListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgDriveRoot](Restore-MgDriveRoot.md)
Invoke action restore

### [Restore-MgDriveRootListItemDocumentSetVersion](Restore-MgDriveRootListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgDriveRootListItemVersion](Restore-MgDriveRootListItemVersion.md)
Invoke action restoreVersion

### [Restore-MgDriveRootVersion](Restore-MgDriveRootVersion.md)
Invoke action restoreVersion

### [Restore-MgShareListItemDocumentSetVersion](Restore-MgShareListItemDocumentSetVersion.md)
Invoke action restore

### [Restore-MgShareListItemVersion](Restore-MgShareListItemVersion.md)
Invoke action restoreVersion

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
Invoke action unpublish

### [Unpublish-MgShareListContentType](Unpublish-MgShareListContentType.md)
Invoke action unpublish

### [Update-MgDrive](Update-MgDrive.md)
Update entity in drives

### [Update-MgDriveItem](Update-MgDriveItem.md)
Update the navigation property items in drives

### [Update-MgDriveItemAnalytic](Update-MgDriveItemAnalytic.md)
Update the navigation property analytics in drives

### [Update-MgDriveItemAnalyticItemActivityStat](Update-MgDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in drives

### [Update-MgDriveItemListItem](Update-MgDriveItemListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveItemListItemDocumentSetVersion](Update-MgDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveItemListItemField](Update-MgDriveItemListItemField.md)
Update the navigation property fields in drives

### [Update-MgDriveItemListItemVersion](Update-MgDriveItemListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveItemListItemVersionField](Update-MgDriveItemListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveItemPermission](Update-MgDriveItemPermission.md)
Update the navigation property permissions in drives

### [Update-MgDriveItemSubscription](Update-MgDriveItemSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgDriveItemThumbnail](Update-MgDriveItemThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgDriveItemVersion](Update-MgDriveItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveList](Update-MgDriveList.md)
Update the navigation property list in drives

### [Update-MgDriveListColumn](Update-MgDriveListColumn.md)
Update the navigation property columns in drives

### [Update-MgDriveListContentType](Update-MgDriveListContentType.md)
Update the navigation property contentTypes in drives

### [Update-MgDriveListContentTypeColumn](Update-MgDriveListContentTypeColumn.md)
Update the navigation property columns in drives

### [Update-MgDriveListContentTypeColumnLink](Update-MgDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in drives

### [Update-MgDriveListItem](Update-MgDriveListItem.md)
Update the navigation property items in drives

### [Update-MgDriveListItemDocumentSetVersion](Update-MgDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveListItemField](Update-MgDriveListItemField.md)
Update the navigation property fields in drives

### [Update-MgDriveListItemVersion](Update-MgDriveListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveListItemVersionField](Update-MgDriveListItemVersionField.md)
Update the navigation property fields in drives

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

### [Update-MgDriveRootListItem](Update-MgDriveRootListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveRootListItemDocumentSetVersion](Update-MgDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveRootListItemField](Update-MgDriveRootListItemField.md)
Update the navigation property fields in drives

### [Update-MgDriveRootListItemVersion](Update-MgDriveRootListItemVersion.md)
Update the navigation property versions in drives

### [Update-MgDriveRootListItemVersionField](Update-MgDriveRootListItemVersionField.md)
Update the navigation property fields in drives

### [Update-MgDriveRootPermission](Update-MgDriveRootPermission.md)
Update the navigation property permissions in drives

### [Update-MgDriveRootSubscription](Update-MgDriveRootSubscription.md)
Update the navigation property subscriptions in drives

### [Update-MgDriveRootThumbnail](Update-MgDriveRootThumbnail.md)
Update the navigation property thumbnails in drives

### [Update-MgDriveRootVersion](Update-MgDriveRootVersion.md)
Update the navigation property versions in drives

### [Update-MgGroupDrive](Update-MgGroupDrive.md)
Update the navigation property drives in groups

### [Update-MgGroupDriveItem](Update-MgGroupDriveItem.md)
Update the navigation property items in groups

### [Update-MgGroupDriveItemAnalytic](Update-MgGroupDriveItemAnalytic.md)
Update the navigation property analytics in groups

### [Update-MgGroupDriveItemAnalyticItemActivityStat](Update-MgGroupDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in groups

### [Update-MgGroupDriveItemListItem](Update-MgGroupDriveItemListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveItemListItemDocumentSetVersion](Update-MgGroupDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveItemListItemField](Update-MgGroupDriveItemListItemField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveItemListItemVersion](Update-MgGroupDriveItemListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveItemListItemVersionField](Update-MgGroupDriveItemListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveItemPermission](Update-MgGroupDriveItemPermission.md)
Update the navigation property permissions in groups

### [Update-MgGroupDriveItemSubscription](Update-MgGroupDriveItemSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupDriveItemThumbnail](Update-MgGroupDriveItemThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgGroupDriveItemVersion](Update-MgGroupDriveItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveList](Update-MgGroupDriveList.md)
Update the navigation property list in groups

### [Update-MgGroupDriveListColumn](Update-MgGroupDriveListColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupDriveListContentType](Update-MgGroupDriveListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgGroupDriveListContentTypeColumn](Update-MgGroupDriveListContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupDriveListContentTypeColumnLink](Update-MgGroupDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgGroupDriveListItem](Update-MgGroupDriveListItem.md)
Update the navigation property items in groups

### [Update-MgGroupDriveListItemDocumentSetVersion](Update-MgGroupDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveListItemField](Update-MgGroupDriveListItemField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveListItemVersion](Update-MgGroupDriveListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveListItemVersionField](Update-MgGroupDriveListItemVersionField.md)
Update the navigation property fields in groups

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

### [Update-MgGroupDriveRootListItem](Update-MgGroupDriveRootListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveRootListItemDocumentSetVersion](Update-MgGroupDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveRootListItemField](Update-MgGroupDriveRootListItemField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveRootListItemVersion](Update-MgGroupDriveRootListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupDriveRootListItemVersionField](Update-MgGroupDriveRootListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupDriveRootPermission](Update-MgGroupDriveRootPermission.md)
Update the navigation property permissions in groups

### [Update-MgGroupDriveRootSubscription](Update-MgGroupDriveRootSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupDriveRootThumbnail](Update-MgGroupDriveRootThumbnail.md)
Update the navigation property thumbnails in groups

### [Update-MgGroupDriveRootVersion](Update-MgGroupDriveRootVersion.md)
Update the navigation property versions in groups

### [Update-MgShareList](Update-MgShareList.md)
Update the navigation property list in shares

### [Update-MgShareListColumn](Update-MgShareListColumn.md)
Update the navigation property columns in shares

### [Update-MgShareListContentType](Update-MgShareListContentType.md)
Update the navigation property contentTypes in shares

### [Update-MgShareListContentTypeColumn](Update-MgShareListContentTypeColumn.md)
Update the navigation property columns in shares

### [Update-MgShareListContentTypeColumnLink](Update-MgShareListContentTypeColumnLink.md)
Update the navigation property columnLinks in shares

### [Update-MgShareListItem](Update-MgShareListItem.md)
Update the navigation property items in shares

### [Update-MgShareListItemDocumentSetVersion](Update-MgShareListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in shares

### [Update-MgShareListItemField](Update-MgShareListItemField.md)
Update the navigation property fields in shares

### [Update-MgShareListItemVersion](Update-MgShareListItemVersion.md)
Update the navigation property versions in shares

### [Update-MgShareListItemVersionField](Update-MgShareListItemVersionField.md)
Update the navigation property fields in shares

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

### [Update-MgUserDriveItem](Update-MgUserDriveItem.md)
Update the navigation property items in users

### [Update-MgUserDriveItemAnalytic](Update-MgUserDriveItemAnalytic.md)
Update the navigation property analytics in users

### [Update-MgUserDriveItemAnalyticItemActivityStat](Update-MgUserDriveItemAnalyticItemActivityStat.md)
Update the navigation property itemActivityStats in users

### [Update-MgUserDriveItemListItem](Update-MgUserDriveItemListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveItemListItemDocumentSetVersion](Update-MgUserDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveItemListItemField](Update-MgUserDriveItemListItemField.md)
Update the navigation property fields in users

### [Update-MgUserDriveItemListItemVersion](Update-MgUserDriveItemListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveItemListItemVersionField](Update-MgUserDriveItemListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveItemPermission](Update-MgUserDriveItemPermission.md)
Update the navigation property permissions in users

### [Update-MgUserDriveItemSubscription](Update-MgUserDriveItemSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgUserDriveItemThumbnail](Update-MgUserDriveItemThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgUserDriveItemVersion](Update-MgUserDriveItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveList](Update-MgUserDriveList.md)
Update the navigation property list in users

### [Update-MgUserDriveListColumn](Update-MgUserDriveListColumn.md)
Update the navigation property columns in users

### [Update-MgUserDriveListContentType](Update-MgUserDriveListContentType.md)
Update the navigation property contentTypes in users

### [Update-MgUserDriveListContentTypeColumn](Update-MgUserDriveListContentTypeColumn.md)
Update the navigation property columns in users

### [Update-MgUserDriveListContentTypeColumnLink](Update-MgUserDriveListContentTypeColumnLink.md)
Update the navigation property columnLinks in users

### [Update-MgUserDriveListItem](Update-MgUserDriveListItem.md)
Update the navigation property items in users

### [Update-MgUserDriveListItemDocumentSetVersion](Update-MgUserDriveListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveListItemField](Update-MgUserDriveListItemField.md)
Update the navigation property fields in users

### [Update-MgUserDriveListItemVersion](Update-MgUserDriveListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveListItemVersionField](Update-MgUserDriveListItemVersionField.md)
Update the navigation property fields in users

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

### [Update-MgUserDriveRootListItem](Update-MgUserDriveRootListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveRootListItemDocumentSetVersion](Update-MgUserDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveRootListItemField](Update-MgUserDriveRootListItemField.md)
Update the navigation property fields in users

### [Update-MgUserDriveRootListItemVersion](Update-MgUserDriveRootListItemVersion.md)
Update the navigation property versions in users

### [Update-MgUserDriveRootListItemVersionField](Update-MgUserDriveRootListItemVersionField.md)
Update the navigation property fields in users

### [Update-MgUserDriveRootPermission](Update-MgUserDriveRootPermission.md)
Update the navigation property permissions in users

### [Update-MgUserDriveRootSubscription](Update-MgUserDriveRootSubscription.md)
Update the navigation property subscriptions in users

### [Update-MgUserDriveRootThumbnail](Update-MgUserDriveRootThumbnail.md)
Update the navigation property thumbnails in users

### [Update-MgUserDriveRootVersion](Update-MgUserDriveRootVersion.md)
Update the navigation property versions in users

