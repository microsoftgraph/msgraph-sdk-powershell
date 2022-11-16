---
Module Name: Microsoft.Graph.Files
Module Guid: 1bb92e1a-5617-4bb2-9a94-bf82270c5dfd
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.files
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
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

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
Retrieve the metadata for a driveItem in a drive by file system path or ID.\n`item-id` is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgDriveRootActivityByInterval](Get-MgDriveRootActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgDriveRootAnalytic](Get-MgDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

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
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

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
Retrieve the metadata for a driveItem in a drive by file system path or ID.\n`item-id` is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgGroupDriveRootAnalytic](Get-MgGroupDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

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
Access a shared DriveItem or a collection of shared items by using a **shareId** or sharing URL.
To use a sharing URL with this API, your app needs to transform the URL into a sharing token.

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
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

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
Retrieve the metadata for a driveItem in a drive by file system path or ID.\n`item-id` is the ID of a driveItem.
It may also be the unique ID of a SharePoint list item.

### [Get-MgUserDriveRootAnalytic](Get-MgUserDriveRootAnalytic.md)
Analytics about the view activities that took place on this item.

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
Grant users access to a link represented by a [permission][].

### [Grant-MgDriveRootPermission](Grant-MgDriveRootPermission.md)
Grant users access to a link represented by a [permission][].

### [Grant-MgSharePermission](Grant-MgSharePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgCheckinDriveItem](Invoke-MgCheckinDriveItem.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckinDriveRoot](Invoke-MgCheckinDriveRoot.md)
Check in a checked out **driveItem** resource, which makes the version of the document available to others.

### [Invoke-MgCheckoutDriveItem](Invoke-MgCheckoutDriveItem.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgCheckoutDriveRoot](Invoke-MgCheckoutDriveRoot.md)
Check out a **driveItem** resource to prevent others from editing the document, and prevent your changes from being visible until the documented is checked in.

### [Invoke-MgFollowDriveItem](Invoke-MgFollowDriveItem.md)
Follow a driveItem.

### [Invoke-MgFollowDriveRoot](Invoke-MgFollowDriveRoot.md)
Follow a driveItem.

### [Invoke-MgGraphDrive](Invoke-MgGraphDrive.md)
Invoke function sharedWithMe

### [Invoke-MgInviteDriveItem](Invoke-MgInviteDriveItem.md)
Sends a sharing invitation for a **driveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

### [Invoke-MgInviteDriveRoot](Invoke-MgInviteDriveRoot.md)
Sends a sharing invitation for a **driveItem**.\nA sharing invitation provides permissions to the recipients and optionally sends them an email with a [sharing link][].

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
Unfollow a driveItem.

### [Invoke-MgUnfollowDriveRoot](Invoke-MgUnfollowDriveRoot.md)
Unfollow a driveItem.

### [Join-MgDriveListContentTypeWithHubSite](Join-MgDriveListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [Join-MgShareListContentTypeWithHubSite](Join-MgShareListContentTypeWithHubSite.md)
Associate a published [content type][contentType] present in a content type hub with a list of hub sites.

### [New-MgDrive](New-MgDrive.md)
Add new entity to drives

### [New-MgDriveItem](New-MgDriveItem.md)
Create new navigation property to items for drives

### [New-MgDriveItemLink](New-MgDriveItemLink.md)
You can use **createLink** action to share a DriveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgDriveItemListItemDocumentSetVersion](New-MgDriveItemListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgDriveItemListItemVersion](New-MgDriveItemListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveItemPermission](New-MgDriveItemPermission.md)
Create new navigation property to permissions for drives

### [New-MgDriveItemSubscription](New-MgDriveItemSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveItemThumbnail](New-MgDriveItemThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgDriveItemUploadSession](New-MgDriveItemUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.\nAn upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session, there are two steps:

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

### [New-MgDriveListItemVersion](New-MgDriveListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveListOperation](New-MgDriveListOperation.md)
Create new navigation property to operations for drives

### [New-MgDriveListSubscription](New-MgDriveListSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveRootLink](New-MgDriveRootLink.md)
You can use **createLink** action to share a DriveItem via a sharing link.
The **createLink** action will create a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, the existing sharing link will be returned.
DriveItem resources inherit sharing permissions from their ancestors.

### [New-MgDriveRootListItemDocumentSetVersion](New-MgDriveRootListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgDriveRootListItemVersion](New-MgDriveRootListItemVersion.md)
Create new navigation property to versions for drives

### [New-MgDriveRootPermission](New-MgDriveRootPermission.md)
Create new navigation property to permissions for drives

### [New-MgDriveRootSubscription](New-MgDriveRootSubscription.md)
Create new navigation property to subscriptions for drives

### [New-MgDriveRootThumbnail](New-MgDriveRootThumbnail.md)
Create new navigation property to thumbnails for drives

### [New-MgDriveRootUploadSession](New-MgDriveRootUploadSession.md)
Create an upload session to allow your app to upload files up to the maximum file size.\nAn upload session allows your app to upload ranges of the file in sequential API requests, which allows the transfer to be resumed if a connection is dropped while the upload is in progress.
To upload a file using an upload session, there are two steps:

### [New-MgDriveRootVersion](New-MgDriveRootVersion.md)
Create new navigation property to versions for drives

### [New-MgGroupDrive](New-MgGroupDrive.md)
Create new navigation property to drives for groups

### [New-MgGroupDriveItem](New-MgGroupDriveItem.md)
Create new navigation property to items for groups

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

### [New-MgUserDriveItem](New-MgUserDriveItem.md)
Create new navigation property to items for users

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
Delete navigation property items for drives

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
Restore a driveItem that has been deleted and is currently in the recycle bin.
**NOTE**: This functionality is currently only available for OneDrive Personal.

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
**NOTE**: This functionality is currently only available for OneDrive Personal.

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
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgShareListContentType](Unpublish-MgShareListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgDrive](Update-MgDrive.md)
Update entity in drives

### [Update-MgDriveItem](Update-MgDriveItem.md)
Update the navigation property items in drives

### [Update-MgDriveItemListItem](Update-MgDriveItemListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveItemListItemDocumentSetVersion](Update-MgDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveItemListItemField](Update-MgDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

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
Update the properties on a **[listItem][]**.

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

### [Update-MgDriveRootListItem](Update-MgDriveRootListItem.md)
Update the navigation property listItem in drives

### [Update-MgDriveRootListItemDocumentSetVersion](Update-MgDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in drives

### [Update-MgDriveRootListItemField](Update-MgDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

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

### [Update-MgGroupDriveItemListItem](Update-MgGroupDriveItemListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveItemListItemDocumentSetVersion](Update-MgGroupDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveItemListItemField](Update-MgGroupDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

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
Update the properties on a **[listItem][]**.

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

### [Update-MgGroupDriveRootListItem](Update-MgGroupDriveRootListItem.md)
Update the navigation property listItem in groups

### [Update-MgGroupDriveRootListItemDocumentSetVersion](Update-MgGroupDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupDriveRootListItemField](Update-MgGroupDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

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
Update the properties on a **[listItem][]**.

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

### [Update-MgUserDriveItemListItem](Update-MgUserDriveItemListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveItemListItemDocumentSetVersion](Update-MgUserDriveItemListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveItemListItemField](Update-MgUserDriveItemListItemField.md)
Update the properties on a **[listItem][]**.

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
Update the properties on a **[listItem][]**.

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

### [Update-MgUserDriveRootListItem](Update-MgUserDriveRootListItem.md)
Update the navigation property listItem in users

### [Update-MgUserDriveRootListItemDocumentSetVersion](Update-MgUserDriveRootListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in users

### [Update-MgUserDriveRootListItemField](Update-MgUserDriveRootListItemField.md)
Update the properties on a **[listItem][]**.

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

