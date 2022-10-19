---
Module Name: Microsoft.Graph.Sites
Module Guid: 93dadb83-fcc3-47fb-9030-0a9f5d26e13f
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.sites
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Sites Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Sites Cmdlets
### [Add-MgSiteContentTypeCopy](Add-MgSiteContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgSiteContentTypeCopyFromContentTypeHub](Add-MgSiteContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgSiteListContentTypeCopy](Add-MgSiteListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgSiteListContentTypeCopyFromContentTypeHub](Add-MgSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Copy-MgSiteContentTypeToDefaultContentLocation](Copy-MgSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgSiteListContentTypeToDefaultContentLocation](Copy-MgSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgSiteOnenoteNotebook](Copy-MgSiteOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgSiteOnenotePageToSection](Copy-MgSiteOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgSiteOnenoteSectionToNotebook](Copy-MgSiteOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgSiteOnenoteSectionToSectionGroup](Copy-MgSiteOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Get-MgGroupSite](Get-MgGroupSite.md)
The collection of the sub-sites under this site.

### [Get-MgGroupSiteAnalytic](Get-MgGroupSiteAnalytic.md)
Analytics about the view activities that took place in this site.

### [Get-MgGroupSiteColumn](Get-MgGroupSiteColumn.md)
The collection of column definitions reusable across lists under this site.

### [Get-MgGroupSiteContentType](Get-MgGroupSiteContentType.md)
The collection of content types defined for this site.

### [Get-MgGroupSiteContentTypeColumn](Get-MgGroupSiteContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgGroupSiteContentTypeColumnLink](Get-MgGroupSiteContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgGroupSiteDrive](Get-MgGroupSiteDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgGroupSiteExternalColumn](Get-MgGroupSiteExternalColumn.md)
The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.

### [Get-MgGroupSiteItem](Get-MgGroupSiteItem.md)
Used to address any item contained in this site.
This collection cannot be enumerated.

### [Get-MgGroupSiteList](Get-MgGroupSiteList.md)
The collection of lists under this site.

### [Get-MgGroupSiteListActivity](Get-MgGroupSiteListActivity.md)
The recent activities that took place within this list.

### [Get-MgGroupSiteListColumn](Get-MgGroupSiteListColumn.md)
Get columns from groups

### [Get-MgGroupSiteListContentType](Get-MgGroupSiteListContentType.md)
Get contentTypes from groups

### [Get-MgGroupSiteListContentTypeBase](Get-MgGroupSiteListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgGroupSiteListContentTypeBaseType](Get-MgGroupSiteListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgGroupSiteListContentTypeColumn](Get-MgGroupSiteListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgGroupSiteListContentTypeColumnLink](Get-MgGroupSiteListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgGroupSiteListContentTypeColumnPosition](Get-MgGroupSiteListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgGroupSiteListDrive](Get-MgGroupSiteListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgGroupSiteListItem](Get-MgGroupSiteListItem.md)
All items contained in the list.

### [Get-MgGroupSiteListItemActivity](Get-MgGroupSiteListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgGroupSiteListItemAnalytic](Get-MgGroupSiteListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgGroupSiteListItemDocumentSetVersion](Get-MgGroupSiteListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgGroupSiteListItemDriveItem](Get-MgGroupSiteListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgGroupSiteListItemDriveItemContent](Get-MgGroupSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgGroupSiteListItemField](Get-MgGroupSiteListItemField.md)
The values of the columns set on this list item.

### [Get-MgGroupSiteListItemVersion](Get-MgGroupSiteListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgGroupSiteListItemVersionField](Get-MgGroupSiteListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgGroupSiteListOperation](Get-MgGroupSiteListOperation.md)
The collection of long running operations for the list.

### [Get-MgGroupSiteListSubscription](Get-MgGroupSiteListSubscription.md)
The set of subscriptions on the list.

### [Get-MgGroupSiteOperation](Get-MgGroupSiteOperation.md)
The collection of long running operations for the site.

### [Get-MgGroupSitePage](Get-MgGroupSitePage.md)
The collection of pages in the SitePages list in this site.

### [Get-MgGroupSitePermission](Get-MgGroupSitePermission.md)
The permissions associated with the site.
Nullable.

### [Get-MgGroupSiteTermStore](Get-MgGroupSiteTermStore.md)
Read the properties and relationships of a store object.

### [Get-MgGroupSiteTermStoreGroup](Get-MgGroupSiteTermStoreGroup.md)
Collection of all groups available in the term store.

### [Get-MgGroupSiteTermStoreGroupSet](Get-MgGroupSiteTermStoreGroupSet.md)
All sets under the group in a term [store].

### [Get-MgGroupSiteTermStoreGroupSetChild](Get-MgGroupSiteTermStoreGroupSetChild.md)
Children terms of set in term [store].

### [Get-MgGroupSiteTermStoreGroupSetRelation](Get-MgGroupSiteTermStoreGroupSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgGroupSiteTermStoreGroupSetTerm](Get-MgGroupSiteTermStoreGroupSetTerm.md)
All the terms under the set.

### [Get-MgGroupSiteTermStoreGroupSetTermChild](Get-MgGroupSiteTermStoreGroupSetTermChild.md)
Children of current term.

### [Get-MgGroupSiteTermStoreGroupSetTermRelation](Get-MgGroupSiteTermStoreGroupSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgGroupSiteTermStoreSet](Get-MgGroupSiteTermStoreSet.md)
Collection of all sets available in the term store.

### [Get-MgGroupSiteTermStoreSetChild](Get-MgGroupSiteTermStoreSetChild.md)
Children terms of set in term [store].

### [Get-MgGroupSiteTermStoreSetRelation](Get-MgGroupSiteTermStoreSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgGroupSiteTermStoreSetTerm](Get-MgGroupSiteTermStoreSetTerm.md)
All the terms under the set.

### [Get-MgGroupSiteTermStoreSetTermChild](Get-MgGroupSiteTermStoreSetTermChild.md)
Children of current term.

### [Get-MgGroupSiteTermStoreSetTermRelation](Get-MgGroupSiteTermStoreSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgGroupSubSite](Get-MgGroupSubSite.md)
The list of SharePoint sites in this group.
Access the default site with /sites/root.

### [Get-MgSite](Get-MgSite.md)
Retrieve properties and relationships for a [site][] resource.\nA **site** resource represents a team site in SharePoint.

### [Get-MgSiteActivityByInterval](Get-MgSiteActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgSiteAnalytic](Get-MgSiteAnalytic.md)
Analytics about the view activities that took place in this site.

### [Get-MgSiteApplicableContentTypeForList](Get-MgSiteApplicableContentTypeForList.md)
Invoke function getApplicableContentTypesForList

### [Get-MgSiteByPath](Get-MgSiteByPath.md)
Invoke function getByPath

### [Get-MgSiteColumn](Get-MgSiteColumn.md)
The collection of column definitions reusable across lists under this site.

### [Get-MgSiteContentType](Get-MgSiteContentType.md)
The collection of content types defined for this site.

### [Get-MgSiteContentTypeColumn](Get-MgSiteContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgSiteContentTypeColumnLink](Get-MgSiteContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgSiteContentTypeCompatibleHubContentType](Get-MgSiteContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgSiteDefaultDrive](Get-MgSiteDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgSiteDelta](Get-MgSiteDelta.md)
Invoke function delta

### [Get-MgSiteDrive](Get-MgSiteDrive.md)
The collection of drives (document libraries) under this site.

### [Get-MgSiteExternalColumn](Get-MgSiteExternalColumn.md)
The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.

### [Get-MgSiteList](Get-MgSiteList.md)
The collection of lists under this site.

### [Get-MgSiteListActivity](Get-MgSiteListActivity.md)
The recent activities that took place within this list.

### [Get-MgSiteListColumn](Get-MgSiteListColumn.md)
Get columns from sites

### [Get-MgSiteListContentType](Get-MgSiteListContentType.md)
Get contentTypes from sites

### [Get-MgSiteListContentTypeBase](Get-MgSiteListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgSiteListContentTypeBaseType](Get-MgSiteListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgSiteListContentTypeColumn](Get-MgSiteListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgSiteListContentTypeColumnLink](Get-MgSiteListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgSiteListContentTypeColumnPosition](Get-MgSiteListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgSiteListContentTypeCompatibleHubContentType](Get-MgSiteListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgSiteListDrive](Get-MgSiteListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgSiteListItem](Get-MgSiteListItem.md)
All items contained in the list.

### [Get-MgSiteListItemActivity](Get-MgSiteListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgSiteListItemActivityByInterval](Get-MgSiteListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgSiteListItemAnalytic](Get-MgSiteListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgSiteListItemDelta](Get-MgSiteListItemDelta.md)
Invoke function delta

### [Get-MgSiteListItemDocumentSetVersion](Get-MgSiteListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgSiteListItemDriveItem](Get-MgSiteListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgSiteListItemDriveItemContent](Get-MgSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgSiteListItemField](Get-MgSiteListItemField.md)
The values of the columns set on this list item.

### [Get-MgSiteListItemVersion](Get-MgSiteListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgSiteListItemVersionField](Get-MgSiteListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgSiteListOperation](Get-MgSiteListOperation.md)
The collection of long running operations for the list.

### [Get-MgSiteListSubscription](Get-MgSiteListSubscription.md)
The set of subscriptions on the list.

### [Get-MgSiteOnenoteNotebookFromWebUrl](Get-MgSiteOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgSitePage](Get-MgSitePage.md)
The collection of pages in the SitePages list in this site.

### [Get-MgSitePermission](Get-MgSitePermission.md)
The permissions associated with the site.
Nullable.

### [Get-MgSiteRecentNotebook](Get-MgSiteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgSiteTermStore](Get-MgSiteTermStore.md)
Read the properties and relationships of a store object.

### [Get-MgSiteTermStoreGroup](Get-MgSiteTermStoreGroup.md)
Collection of all groups available in the term store.

### [Get-MgSiteTermStoreGroupSet](Get-MgSiteTermStoreGroupSet.md)
All sets under the group in a term [store].

### [Get-MgSiteTermStoreGroupSetChild](Get-MgSiteTermStoreGroupSetChild.md)
Children terms of set in term [store].

### [Get-MgSiteTermStoreGroupSetRelation](Get-MgSiteTermStoreGroupSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgSiteTermStoreGroupSetTerm](Get-MgSiteTermStoreGroupSetTerm.md)
All the terms under the set.

### [Get-MgSiteTermStoreGroupSetTermChild](Get-MgSiteTermStoreGroupSetTermChild.md)
Children of current term.

### [Get-MgSiteTermStoreGroupSetTermRelation](Get-MgSiteTermStoreGroupSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgSiteTermStoreSet](Get-MgSiteTermStoreSet.md)
Collection of all sets available in the term store.

### [Get-MgSiteTermStoreSetChild](Get-MgSiteTermStoreSetChild.md)
Children terms of set in term [store].

### [Get-MgSiteTermStoreSetRelation](Get-MgSiteTermStoreSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgSiteTermStoreSetTerm](Get-MgSiteTermStoreSetTerm.md)
All the terms under the set.

### [Get-MgSiteTermStoreSetTermChild](Get-MgSiteTermStoreSetTermChild.md)
Children of current term.

### [Get-MgSiteTermStoreSetTermRelation](Get-MgSiteTermStoreSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgSubSite](Get-MgSubSite.md)
The collection of the sub-sites under this site.

### [Get-MgUserFollowedSite](Get-MgUserFollowedSite.md)
Get followedSites from users

### [Grant-MgSitePermission](Grant-MgSitePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgPreviewSiteOnenotePage](Invoke-MgPreviewSiteOnenotePage.md)
Invoke function preview

### [Invoke-MgReauthorizeSiteListSubscription](Invoke-MgReauthorizeSiteListSubscription.md)
Invoke action reauthorize

### [Join-MgSiteContentTypeWithHubSite](Join-MgSiteContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgSiteListContentTypeWithHubSite](Join-MgSiteListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [New-MgGroupSiteColumn](New-MgGroupSiteColumn.md)
Create a column for a [site][site] by specifying a [columnDefinition][columnDefinition].

### [New-MgGroupSiteContentType](New-MgGroupSiteContentType.md)
Create a new [contentType][] for a [site][].

### [New-MgGroupSiteContentTypeColumn](New-MgGroupSiteContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgGroupSiteContentTypeColumnLink](New-MgGroupSiteContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgGroupSiteList](New-MgGroupSiteList.md)
Create a new [list][] in a [site][].

### [New-MgGroupSiteListColumn](New-MgGroupSiteListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgGroupSiteListContentType](New-MgGroupSiteListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgGroupSiteListContentTypeColumn](New-MgGroupSiteListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgGroupSiteListContentTypeColumnLink](New-MgGroupSiteListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgGroupSiteListItem](New-MgGroupSiteListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgGroupSiteListItemDocumentSetVersion](New-MgGroupSiteListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgGroupSiteListItemVersion](New-MgGroupSiteListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgGroupSiteListOperation](New-MgGroupSiteListOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupSiteListSubscription](New-MgGroupSiteListSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgGroupSiteOperation](New-MgGroupSiteOperation.md)
Create new navigation property to operations for groups

### [New-MgGroupSitePage](New-MgGroupSitePage.md)
Create a new [sitePage][] in the site pages [list][] in a [site][].

### [New-MgGroupSitePermission](New-MgGroupSitePermission.md)
Create a new permission object on a site.

### [New-MgGroupSiteTermStoreGroup](New-MgGroupSiteTermStoreGroup.md)
Create a new group object.

### [New-MgGroupSiteTermStoreGroupSet](New-MgGroupSiteTermStoreGroupSet.md)
Create new navigation property to sets for groups

### [New-MgGroupSiteTermStoreGroupSetChild](New-MgGroupSiteTermStoreGroupSetChild.md)
Create a new term object.

### [New-MgGroupSiteTermStoreGroupSetRelation](New-MgGroupSiteTermStoreGroupSetRelation.md)
Create new navigation property to relations for groups

### [New-MgGroupSiteTermStoreGroupSetTerm](New-MgGroupSiteTermStoreGroupSetTerm.md)
Create new navigation property to terms for groups

### [New-MgGroupSiteTermStoreGroupSetTermChild](New-MgGroupSiteTermStoreGroupSetTermChild.md)
Create new navigation property to children for groups

### [New-MgGroupSiteTermStoreGroupSetTermRelation](New-MgGroupSiteTermStoreGroupSetTermRelation.md)
Create new navigation property to relations for groups

### [New-MgGroupSiteTermStoreSet](New-MgGroupSiteTermStoreSet.md)
Create new navigation property to sets for groups

### [New-MgGroupSiteTermStoreSetChild](New-MgGroupSiteTermStoreSetChild.md)
Create a new term object.

### [New-MgGroupSiteTermStoreSetRelation](New-MgGroupSiteTermStoreSetRelation.md)
Create new navigation property to relations for groups

### [New-MgGroupSiteTermStoreSetTerm](New-MgGroupSiteTermStoreSetTerm.md)
Create new navigation property to terms for groups

### [New-MgGroupSiteTermStoreSetTermChild](New-MgGroupSiteTermStoreSetTermChild.md)
Create new navigation property to children for groups

### [New-MgGroupSiteTermStoreSetTermRelation](New-MgGroupSiteTermStoreSetTermRelation.md)
Create new navigation property to relations for groups

### [New-MgSiteColumn](New-MgSiteColumn.md)
Create a column for a [site][site] by specifying a [columnDefinition][columnDefinition].

### [New-MgSiteContentType](New-MgSiteContentType.md)
Create a new [contentType][] for a [site][].

### [New-MgSiteContentTypeColumn](New-MgSiteContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgSiteContentTypeColumnLink](New-MgSiteContentTypeColumnLink.md)
Create new navigation property to columnLinks for sites

### [New-MgSiteList](New-MgSiteList.md)
Create a new [list][] in a [site][].

### [New-MgSiteListColumn](New-MgSiteListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgSiteListContentType](New-MgSiteListContentType.md)
Create new navigation property to contentTypes for sites

### [New-MgSiteListContentTypeColumn](New-MgSiteListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgSiteListContentTypeColumnLink](New-MgSiteListContentTypeColumnLink.md)
Create new navigation property to columnLinks for sites

### [New-MgSiteListItem](New-MgSiteListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgSiteListItemDocumentSetVersion](New-MgSiteListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgSiteListItemLink](New-MgSiteListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgSiteListItemVersion](New-MgSiteListItemVersion.md)
Create new navigation property to versions for sites

### [New-MgSiteListOperation](New-MgSiteListOperation.md)
Create new navigation property to operations for sites

### [New-MgSiteListSubscription](New-MgSiteListSubscription.md)
Create new navigation property to subscriptions for sites

### [New-MgSitePage](New-MgSitePage.md)
Create a new [sitePage][] in the site pages [list][] in a [site][].

### [New-MgSitePermission](New-MgSitePermission.md)
Create a new permission object on a site.

### [New-MgSiteTermStoreGroup](New-MgSiteTermStoreGroup.md)
Create a new group object.

### [New-MgSiteTermStoreGroupSet](New-MgSiteTermStoreGroupSet.md)
Create new navigation property to sets for sites

### [New-MgSiteTermStoreGroupSetChild](New-MgSiteTermStoreGroupSetChild.md)
Create a new term object.

### [New-MgSiteTermStoreGroupSetRelation](New-MgSiteTermStoreGroupSetRelation.md)
Create new navigation property to relations for sites

### [New-MgSiteTermStoreGroupSetTerm](New-MgSiteTermStoreGroupSetTerm.md)
Create new navigation property to terms for sites

### [New-MgSiteTermStoreGroupSetTermChild](New-MgSiteTermStoreGroupSetTermChild.md)
Create new navigation property to children for sites

### [New-MgSiteTermStoreGroupSetTermRelation](New-MgSiteTermStoreGroupSetTermRelation.md)
Create new navigation property to relations for sites

### [New-MgSiteTermStoreSet](New-MgSiteTermStoreSet.md)
Create new navigation property to sets for sites

### [New-MgSiteTermStoreSetChild](New-MgSiteTermStoreSetChild.md)
Create a new term object.

### [New-MgSiteTermStoreSetRelation](New-MgSiteTermStoreSetRelation.md)
Create new navigation property to relations for sites

### [New-MgSiteTermStoreSetTerm](New-MgSiteTermStoreSetTerm.md)
Create new navigation property to terms for sites

### [New-MgSiteTermStoreSetTermChild](New-MgSiteTermStoreSetTermChild.md)
Create new navigation property to children for sites

### [New-MgSiteTermStoreSetTermRelation](New-MgSiteTermStoreSetTermRelation.md)
Create new navigation property to relations for sites

### [Publish-MgSiteContentType](Publish-MgSiteContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgSiteListContentType](Publish-MgSiteListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgSitePage](Publish-MgSitePage.md)
Invoke action publish

### [Remove-MgGroupSiteColumn](Remove-MgGroupSiteColumn.md)
Delete navigation property columns for groups

### [Remove-MgGroupSiteContentType](Remove-MgGroupSiteContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgGroupSiteContentTypeColumn](Remove-MgGroupSiteContentTypeColumn.md)
Delete navigation property columns for groups

### [Remove-MgGroupSiteContentTypeColumnLink](Remove-MgGroupSiteContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgGroupSiteList](Remove-MgGroupSiteList.md)
Delete navigation property lists for groups

### [Remove-MgGroupSiteListColumn](Remove-MgGroupSiteListColumn.md)
Delete navigation property columns for groups

### [Remove-MgGroupSiteListContentType](Remove-MgGroupSiteListContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgGroupSiteListContentTypeColumn](Remove-MgGroupSiteListContentTypeColumn.md)
Delete navigation property columns for groups

### [Remove-MgGroupSiteListContentTypeColumnLink](Remove-MgGroupSiteListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgGroupSiteListItem](Remove-MgGroupSiteListItem.md)
Delete navigation property items for groups

### [Remove-MgGroupSiteListItemDocumentSetVersion](Remove-MgGroupSiteListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgGroupSiteListItemField](Remove-MgGroupSiteListItemField.md)
Delete navigation property fields for groups

### [Remove-MgGroupSiteListItemVersion](Remove-MgGroupSiteListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgGroupSiteListItemVersionField](Remove-MgGroupSiteListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgGroupSiteListOperation](Remove-MgGroupSiteListOperation.md)
Delete navigation property operations for groups

### [Remove-MgGroupSiteListSubscription](Remove-MgGroupSiteListSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgGroupSiteOperation](Remove-MgGroupSiteOperation.md)
Delete navigation property operations for groups

### [Remove-MgGroupSitePage](Remove-MgGroupSitePage.md)
Delete navigation property pages for groups

### [Remove-MgGroupSitePermission](Remove-MgGroupSitePermission.md)
Delete navigation property permissions for groups

### [Remove-MgGroupSiteTermStore](Remove-MgGroupSiteTermStore.md)
Delete navigation property termStore for groups

### [Remove-MgGroupSiteTermStoreGroup](Remove-MgGroupSiteTermStoreGroup.md)
Delete navigation property groups for groups

### [Remove-MgGroupSiteTermStoreGroupSet](Remove-MgGroupSiteTermStoreGroupSet.md)
Delete navigation property sets for groups

### [Remove-MgGroupSiteTermStoreGroupSetChild](Remove-MgGroupSiteTermStoreGroupSetChild.md)
Delete navigation property children for groups

### [Remove-MgGroupSiteTermStoreGroupSetRelation](Remove-MgGroupSiteTermStoreGroupSetRelation.md)
Delete navigation property relations for groups

### [Remove-MgGroupSiteTermStoreGroupSetTerm](Remove-MgGroupSiteTermStoreGroupSetTerm.md)
Delete navigation property terms for groups

### [Remove-MgGroupSiteTermStoreGroupSetTermChild](Remove-MgGroupSiteTermStoreGroupSetTermChild.md)
Delete navigation property children for groups

### [Remove-MgGroupSiteTermStoreGroupSetTermRelation](Remove-MgGroupSiteTermStoreGroupSetTermRelation.md)
Delete navigation property relations for groups

### [Remove-MgGroupSiteTermStoreSet](Remove-MgGroupSiteTermStoreSet.md)
Delete navigation property sets for groups

### [Remove-MgGroupSiteTermStoreSetChild](Remove-MgGroupSiteTermStoreSetChild.md)
Delete navigation property children for groups

### [Remove-MgGroupSiteTermStoreSetRelation](Remove-MgGroupSiteTermStoreSetRelation.md)
Delete navigation property relations for groups

### [Remove-MgGroupSiteTermStoreSetTerm](Remove-MgGroupSiteTermStoreSetTerm.md)
Delete navigation property terms for groups

### [Remove-MgGroupSiteTermStoreSetTermChild](Remove-MgGroupSiteTermStoreSetTermChild.md)
Delete navigation property children for groups

### [Remove-MgGroupSiteTermStoreSetTermRelation](Remove-MgGroupSiteTermStoreSetTermRelation.md)
Delete navigation property relations for groups

### [Remove-MgSiteColumn](Remove-MgSiteColumn.md)
Delete navigation property columns for sites

### [Remove-MgSiteContentType](Remove-MgSiteContentType.md)
Delete navigation property contentTypes for sites

### [Remove-MgSiteContentTypeColumn](Remove-MgSiteContentTypeColumn.md)
Delete navigation property columns for sites

### [Remove-MgSiteContentTypeColumnLink](Remove-MgSiteContentTypeColumnLink.md)
Delete navigation property columnLinks for sites

### [Remove-MgSiteList](Remove-MgSiteList.md)
Delete navigation property lists for sites

### [Remove-MgSiteListColumn](Remove-MgSiteListColumn.md)
Delete navigation property columns for sites

### [Remove-MgSiteListContentType](Remove-MgSiteListContentType.md)
Delete navigation property contentTypes for sites

### [Remove-MgSiteListContentTypeColumn](Remove-MgSiteListContentTypeColumn.md)
Delete navigation property columns for sites

### [Remove-MgSiteListContentTypeColumnLink](Remove-MgSiteListContentTypeColumnLink.md)
Delete navigation property columnLinks for sites

### [Remove-MgSiteListItem](Remove-MgSiteListItem.md)
Delete navigation property items for sites

### [Remove-MgSiteListItemDocumentSetVersion](Remove-MgSiteListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for sites

### [Remove-MgSiteListItemField](Remove-MgSiteListItemField.md)
Delete navigation property fields for sites

### [Remove-MgSiteListItemVersion](Remove-MgSiteListItemVersion.md)
Delete navigation property versions for sites

### [Remove-MgSiteListItemVersionField](Remove-MgSiteListItemVersionField.md)
Delete navigation property fields for sites

### [Remove-MgSiteListOperation](Remove-MgSiteListOperation.md)
Delete navigation property operations for sites

### [Remove-MgSiteListSubscription](Remove-MgSiteListSubscription.md)
Delete navigation property subscriptions for sites

### [Remove-MgSitePage](Remove-MgSitePage.md)
Delete navigation property pages for sites

### [Remove-MgSitePermission](Remove-MgSitePermission.md)
Delete navigation property permissions for sites

### [Remove-MgSiteTermStore](Remove-MgSiteTermStore.md)
Delete navigation property termStore for sites

### [Remove-MgSiteTermStoreGroup](Remove-MgSiteTermStoreGroup.md)
Delete navigation property groups for sites

### [Remove-MgSiteTermStoreGroupSet](Remove-MgSiteTermStoreGroupSet.md)
Delete navigation property sets for sites

### [Remove-MgSiteTermStoreGroupSetChild](Remove-MgSiteTermStoreGroupSetChild.md)
Delete navigation property children for sites

### [Remove-MgSiteTermStoreGroupSetRelation](Remove-MgSiteTermStoreGroupSetRelation.md)
Delete navigation property relations for sites

### [Remove-MgSiteTermStoreGroupSetTerm](Remove-MgSiteTermStoreGroupSetTerm.md)
Delete navigation property terms for sites

### [Remove-MgSiteTermStoreGroupSetTermChild](Remove-MgSiteTermStoreGroupSetTermChild.md)
Delete navigation property children for sites

### [Remove-MgSiteTermStoreGroupSetTermRelation](Remove-MgSiteTermStoreGroupSetTermRelation.md)
Delete navigation property relations for sites

### [Remove-MgSiteTermStoreSet](Remove-MgSiteTermStoreSet.md)
Delete navigation property sets for sites

### [Remove-MgSiteTermStoreSetChild](Remove-MgSiteTermStoreSetChild.md)
Delete navigation property children for sites

### [Remove-MgSiteTermStoreSetRelation](Remove-MgSiteTermStoreSetRelation.md)
Delete navigation property relations for sites

### [Remove-MgSiteTermStoreSetTerm](Remove-MgSiteTermStoreSetTerm.md)
Delete navigation property terms for sites

### [Remove-MgSiteTermStoreSetTermChild](Remove-MgSiteTermStoreSetTermChild.md)
Delete navigation property children for sites

### [Remove-MgSiteTermStoreSetTermRelation](Remove-MgSiteTermStoreSetTermRelation.md)
Delete navigation property relations for sites

### [Restore-MgSiteListItemDocumentSetVersion](Restore-MgSiteListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgSiteListItemVersion](Restore-MgSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgSitePermissionGrant](Revoke-MgSitePermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Set-MgGroupSiteListItemDriveItemContent](Set-MgGroupSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgSiteListItemDriveItemContent](Set-MgSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Test-MgSiteContentTypePublished](Test-MgSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgSiteListContentTypePublished](Test-MgSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgSiteContentType](Unpublish-MgSiteContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgSiteListContentType](Unpublish-MgSiteListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgGroupSite](Update-MgGroupSite.md)
Update the navigation property sites in groups

### [Update-MgGroupSiteColumn](Update-MgGroupSiteColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupSiteContentType](Update-MgGroupSiteContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgGroupSiteContentTypeColumn](Update-MgGroupSiteContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupSiteContentTypeColumnLink](Update-MgGroupSiteContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgGroupSiteList](Update-MgGroupSiteList.md)
Update the navigation property lists in groups

### [Update-MgGroupSiteListColumn](Update-MgGroupSiteListColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupSiteListContentType](Update-MgGroupSiteListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgGroupSiteListContentTypeColumn](Update-MgGroupSiteListContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgGroupSiteListContentTypeColumnLink](Update-MgGroupSiteListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgGroupSiteListItem](Update-MgGroupSiteListItem.md)
Update the navigation property items in groups

### [Update-MgGroupSiteListItemDocumentSetVersion](Update-MgGroupSiteListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgGroupSiteListItemField](Update-MgGroupSiteListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgGroupSiteListItemVersion](Update-MgGroupSiteListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgGroupSiteListItemVersionField](Update-MgGroupSiteListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgGroupSiteListOperation](Update-MgGroupSiteListOperation.md)
Update the navigation property operations in groups

### [Update-MgGroupSiteListSubscription](Update-MgGroupSiteListSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgGroupSiteOperation](Update-MgGroupSiteOperation.md)
Update the navigation property operations in groups

### [Update-MgGroupSitePage](Update-MgGroupSitePage.md)
Update the navigation property pages in groups

### [Update-MgGroupSitePermission](Update-MgGroupSitePermission.md)
Update the navigation property permissions in groups

### [Update-MgGroupSiteTermStore](Update-MgGroupSiteTermStore.md)
Update the navigation property termStore in groups

### [Update-MgGroupSiteTermStoreGroup](Update-MgGroupSiteTermStoreGroup.md)
Update the navigation property groups in groups

### [Update-MgGroupSiteTermStoreGroupSet](Update-MgGroupSiteTermStoreGroupSet.md)
Update the navigation property sets in groups

### [Update-MgGroupSiteTermStoreGroupSetChild](Update-MgGroupSiteTermStoreGroupSetChild.md)
Update the navigation property children in groups

### [Update-MgGroupSiteTermStoreGroupSetRelation](Update-MgGroupSiteTermStoreGroupSetRelation.md)
Update the navigation property relations in groups

### [Update-MgGroupSiteTermStoreGroupSetTerm](Update-MgGroupSiteTermStoreGroupSetTerm.md)
Update the navigation property terms in groups

### [Update-MgGroupSiteTermStoreGroupSetTermChild](Update-MgGroupSiteTermStoreGroupSetTermChild.md)
Update the navigation property children in groups

### [Update-MgGroupSiteTermStoreGroupSetTermRelation](Update-MgGroupSiteTermStoreGroupSetTermRelation.md)
Update the navigation property relations in groups

### [Update-MgGroupSiteTermStoreSet](Update-MgGroupSiteTermStoreSet.md)
Update the navigation property sets in groups

### [Update-MgGroupSiteTermStoreSetChild](Update-MgGroupSiteTermStoreSetChild.md)
Update the navigation property children in groups

### [Update-MgGroupSiteTermStoreSetRelation](Update-MgGroupSiteTermStoreSetRelation.md)
Update the navigation property relations in groups

### [Update-MgGroupSiteTermStoreSetTerm](Update-MgGroupSiteTermStoreSetTerm.md)
Update the navigation property terms in groups

### [Update-MgGroupSiteTermStoreSetTermChild](Update-MgGroupSiteTermStoreSetTermChild.md)
Update the navigation property children in groups

### [Update-MgGroupSiteTermStoreSetTermRelation](Update-MgGroupSiteTermStoreSetTermRelation.md)
Update the navigation property relations in groups

### [Update-MgSite](Update-MgSite.md)
Update entity in sites

### [Update-MgSiteColumn](Update-MgSiteColumn.md)
Update the navigation property columns in sites

### [Update-MgSiteContentType](Update-MgSiteContentType.md)
Update the navigation property contentTypes in sites

### [Update-MgSiteContentTypeColumn](Update-MgSiteContentTypeColumn.md)
Update the navigation property columns in sites

### [Update-MgSiteContentTypeColumnLink](Update-MgSiteContentTypeColumnLink.md)
Update the navigation property columnLinks in sites

### [Update-MgSiteList](Update-MgSiteList.md)
Update the navigation property lists in sites

### [Update-MgSiteListColumn](Update-MgSiteListColumn.md)
Update the navigation property columns in sites

### [Update-MgSiteListContentType](Update-MgSiteListContentType.md)
Update the navigation property contentTypes in sites

### [Update-MgSiteListContentTypeColumn](Update-MgSiteListContentTypeColumn.md)
Update the navigation property columns in sites

### [Update-MgSiteListContentTypeColumnLink](Update-MgSiteListContentTypeColumnLink.md)
Update the navigation property columnLinks in sites

### [Update-MgSiteListItem](Update-MgSiteListItem.md)
Update the navigation property items in sites

### [Update-MgSiteListItemDocumentSetVersion](Update-MgSiteListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in sites

### [Update-MgSiteListItemField](Update-MgSiteListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgSiteListItemVersion](Update-MgSiteListItemVersion.md)
Update the navigation property versions in sites

### [Update-MgSiteListItemVersionField](Update-MgSiteListItemVersionField.md)
Update the navigation property fields in sites

### [Update-MgSiteListOperation](Update-MgSiteListOperation.md)
Update the navigation property operations in sites

### [Update-MgSiteListSubscription](Update-MgSiteListSubscription.md)
Update the navigation property subscriptions in sites

### [Update-MgSiteOnenotePageContent](Update-MgSiteOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgSitePage](Update-MgSitePage.md)
Update the navigation property pages in sites

### [Update-MgSitePermission](Update-MgSitePermission.md)
Update the navigation property permissions in sites

### [Update-MgSiteTermStore](Update-MgSiteTermStore.md)
Update the navigation property termStore in sites

### [Update-MgSiteTermStoreGroup](Update-MgSiteTermStoreGroup.md)
Update the navigation property groups in sites

### [Update-MgSiteTermStoreGroupSet](Update-MgSiteTermStoreGroupSet.md)
Update the navigation property sets in sites

### [Update-MgSiteTermStoreGroupSetChild](Update-MgSiteTermStoreGroupSetChild.md)
Update the navigation property children in sites

### [Update-MgSiteTermStoreGroupSetRelation](Update-MgSiteTermStoreGroupSetRelation.md)
Update the navigation property relations in sites

### [Update-MgSiteTermStoreGroupSetTerm](Update-MgSiteTermStoreGroupSetTerm.md)
Update the navigation property terms in sites

### [Update-MgSiteTermStoreGroupSetTermChild](Update-MgSiteTermStoreGroupSetTermChild.md)
Update the navigation property children in sites

### [Update-MgSiteTermStoreGroupSetTermRelation](Update-MgSiteTermStoreGroupSetTermRelation.md)
Update the navigation property relations in sites

### [Update-MgSiteTermStoreSet](Update-MgSiteTermStoreSet.md)
Update the navigation property sets in sites

### [Update-MgSiteTermStoreSetChild](Update-MgSiteTermStoreSetChild.md)
Update the navigation property children in sites

### [Update-MgSiteTermStoreSetRelation](Update-MgSiteTermStoreSetRelation.md)
Update the navigation property relations in sites

### [Update-MgSiteTermStoreSetTerm](Update-MgSiteTermStoreSetTerm.md)
Update the navigation property terms in sites

### [Update-MgSiteTermStoreSetTermChild](Update-MgSiteTermStoreSetTermChild.md)
Update the navigation property children in sites

### [Update-MgSiteTermStoreSetTermRelation](Update-MgSiteTermStoreSetTermRelation.md)
Update the navigation property relations in sites

