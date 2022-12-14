---
Module Name: Microsoft.Graph.Beta.Sites
Module Guid: 9687ec4e-62c0-459e-bbbe-51b49ea10c05
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.Beta.sites
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Sites Module
## Description
Microsoft.Graph.Beta PowerShell Cmdlets

## Microsoft.Graph.Beta.Sites Cmdlets
### [Add-MgBetaSiteContentTypeCopy](Add-MgBetaSiteContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaSiteContentTypeCopyFromContentTypeHub](Add-MgBetaSiteContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Add-MgBetaSiteListContentTypeCopy](Add-MgBetaSiteListContentTypeCopy.md)
Add a copy of a [content type][contentType] from a [site][site] to a [list][list].

### [Add-MgBetaSiteListContentTypeCopyFromContentTypeHub](Add-MgBetaSiteListContentTypeCopyFromContentTypeHub.md)
Add or sync a copy of a published content type from the content type hub to a target site or a list.
This method is part of the content type publishing changes to optimize the syncing of published content types to sites and lists, effectively switching from a 'push everywhere' to 'pull as needed' approach.
The method allows users to pull content types directly from the content type hub to a site or list.
For more information, see getCompatibleHubContentTypes and the blog post Syntex Product Updates – August 2021.

### [Copy-MgBetaSiteContentTypeToDefaultContentLocation](Copy-MgBetaSiteContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaSiteListContentTypeToDefaultContentLocation](Copy-MgBetaSiteListContentTypeToDefaultContentLocation.md)
Copy a file to a default content location in a [content type][contentType].
The file can then be added as a default file or template via a POST operation.

### [Copy-MgBetaSiteOnenoteNotebook](Copy-MgBetaSiteOnenoteNotebook.md)
Copies a notebook to the Notebooks folder in the destination Documents library.
The folder is created if it doesn't exist.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaSiteOnenotePageToSection](Copy-MgBetaSiteOnenotePageToSection.md)
Copy a page to a specific section.
For copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaSiteOnenoteSectionToNotebook](Copy-MgBetaSiteOnenoteSectionToNotebook.md)
Copies a section to a specific notebook.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Copy-MgBetaSiteOnenoteSectionToSectionGroup](Copy-MgBetaSiteOnenoteSectionToSectionGroup.md)
Copies a section to a specific section group.
For Copy operations, you follow an asynchronous calling pattern:  First call the Copy action, and then poll the operation endpoint for the result.

### [Get-MgBetaGroupSite](Get-MgBetaGroupSite.md)
The collection of the sub-sites under this site.

### [Get-MgBetaGroupSiteAnalytic](Get-MgBetaGroupSiteAnalytic.md)
Analytics about the view activities that took place in this site.

### [Get-MgBetaGroupSiteColumn](Get-MgBetaGroupSiteColumn.md)
The collection of column definitions reusable across lists under this site.

### [Get-MgBetaGroupSiteContentType](Get-MgBetaGroupSiteContentType.md)
The collection of content types defined for this site.

### [Get-MgBetaGroupSiteContentTypeColumn](Get-MgBetaGroupSiteContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaGroupSiteContentTypeColumnLink](Get-MgBetaGroupSiteContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaGroupSiteDrive](Get-MgBetaGroupSiteDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgBetaGroupSiteExternalColumn](Get-MgBetaGroupSiteExternalColumn.md)
The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.

### [Get-MgBetaGroupSiteItem](Get-MgBetaGroupSiteItem.md)
Used to address any item contained in this site.
This collection cannot be enumerated.

### [Get-MgBetaGroupSiteList](Get-MgBetaGroupSiteList.md)
The collection of lists under this site.

### [Get-MgBetaGroupSiteListActivity](Get-MgBetaGroupSiteListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaGroupSiteListColumn](Get-MgBetaGroupSiteListColumn.md)
Get columns from groups

### [Get-MgBetaGroupSiteListContentType](Get-MgBetaGroupSiteListContentType.md)
Get contentTypes from groups

### [Get-MgBetaGroupSiteListContentTypeBase](Get-MgBetaGroupSiteListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaGroupSiteListContentTypeBaseType](Get-MgBetaGroupSiteListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaGroupSiteListContentTypeColumn](Get-MgBetaGroupSiteListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaGroupSiteListContentTypeColumnLink](Get-MgBetaGroupSiteListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaGroupSiteListContentTypeColumnPosition](Get-MgBetaGroupSiteListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaGroupSiteListDrive](Get-MgBetaGroupSiteListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaGroupSiteListItem](Get-MgBetaGroupSiteListItem.md)
All items contained in the list.

### [Get-MgBetaGroupSiteListItemActivity](Get-MgBetaGroupSiteListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaGroupSiteListItemAnalytic](Get-MgBetaGroupSiteListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaGroupSiteListItemDocumentSetVersion](Get-MgBetaGroupSiteListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaGroupSiteListItemDriveItem](Get-MgBetaGroupSiteListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaGroupSiteListItemDriveItemContent](Get-MgBetaGroupSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaGroupSiteListItemField](Get-MgBetaGroupSiteListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaGroupSiteListItemVersion](Get-MgBetaGroupSiteListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaGroupSiteListItemVersionField](Get-MgBetaGroupSiteListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaGroupSiteListOperation](Get-MgBetaGroupSiteListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaGroupSiteListSubscription](Get-MgBetaGroupSiteListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaGroupSiteOperation](Get-MgBetaGroupSiteOperation.md)
The collection of long running operations for the site.

### [Get-MgBetaGroupSitePage](Get-MgBetaGroupSitePage.md)
The collection of pages in the SitePages list in this site.

### [Get-MgBetaGroupSitePermission](Get-MgBetaGroupSitePermission.md)
The permissions associated with the site.
Nullable.

### [Get-MgBetaGroupSiteTermStore](Get-MgBetaGroupSiteTermStore.md)
Read the properties and relationships of a store object.

### [Get-MgBetaGroupSiteTermStoreGroup](Get-MgBetaGroupSiteTermStoreGroup.md)
Collection of all groups available in the term store.

### [Get-MgBetaGroupSiteTermStoreGroupSet](Get-MgBetaGroupSiteTermStoreGroupSet.md)
All sets under the group in a term [store].

### [Get-MgBetaGroupSiteTermStoreGroupSetChild](Get-MgBetaGroupSiteTermStoreGroupSetChild.md)
Children terms of set in term [store].

### [Get-MgBetaGroupSiteTermStoreGroupSetRelation](Get-MgBetaGroupSiteTermStoreGroupSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgBetaGroupSiteTermStoreGroupSetTerm](Get-MgBetaGroupSiteTermStoreGroupSetTerm.md)
All the terms under the set.

### [Get-MgBetaGroupSiteTermStoreGroupSetTermChild](Get-MgBetaGroupSiteTermStoreGroupSetTermChild.md)
Children of current term.

### [Get-MgBetaGroupSiteTermStoreGroupSetTermRelation](Get-MgBetaGroupSiteTermStoreGroupSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgBetaGroupSiteTermStoreSet](Get-MgBetaGroupSiteTermStoreSet.md)
Collection of all sets available in the term store.

### [Get-MgBetaGroupSiteTermStoreSetChild](Get-MgBetaGroupSiteTermStoreSetChild.md)
Children terms of set in term [store].

### [Get-MgBetaGroupSiteTermStoreSetRelation](Get-MgBetaGroupSiteTermStoreSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgBetaGroupSiteTermStoreSetTerm](Get-MgBetaGroupSiteTermStoreSetTerm.md)
All the terms under the set.

### [Get-MgBetaGroupSiteTermStoreSetTermChild](Get-MgBetaGroupSiteTermStoreSetTermChild.md)
Children of current term.

### [Get-MgBetaGroupSiteTermStoreSetTermRelation](Get-MgBetaGroupSiteTermStoreSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgBetaGroupSubSite](Get-MgBetaGroupSubSite.md)
The list of SharePoint sites in this group.
Access the default site with /sites/root.

### [Get-MgBetaSite](Get-MgBetaSite.md)
Retrieve properties and relationships for a [site][] resource.\nA **site** resource represents a team site in SharePoint.

### [Get-MgBetaSiteActivityByInterval](Get-MgBetaSiteActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaSiteAnalytic](Get-MgBetaSiteAnalytic.md)
Analytics about the view activities that took place in this site.

### [Get-MgBetaSiteApplicableContentTypeForList](Get-MgBetaSiteApplicableContentTypeForList.md)
Invoke function getApplicableContentTypesForList

### [Get-MgBetaSiteByPath](Get-MgBetaSiteByPath.md)
Invoke function getByPath

### [Get-MgBetaSiteColumn](Get-MgBetaSiteColumn.md)
The collection of column definitions reusable across lists under this site.

### [Get-MgBetaSiteContentType](Get-MgBetaSiteContentType.md)
The collection of content types defined for this site.

### [Get-MgBetaSiteContentTypeColumn](Get-MgBetaSiteContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaSiteContentTypeColumnLink](Get-MgBetaSiteContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaSiteContentTypeCompatibleHubContentType](Get-MgBetaSiteContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaSiteDefaultDrive](Get-MgBetaSiteDefaultDrive.md)
Retrieve the properties and relationships of a Drive resource.
A Drive is the top-level container for a file system, such as OneDrive or SharePoint document libraries.

### [Get-MgBetaSiteDelta](Get-MgBetaSiteDelta.md)
Invoke function delta

### [Get-MgBetaSiteDrive](Get-MgBetaSiteDrive.md)
The collection of drives (document libraries) under this site.

### [Get-MgBetaSiteExternalColumn](Get-MgBetaSiteExternalColumn.md)
The collection of column definitions available in the site that are referenced from the sites in the parent hierarchy of the current site.

### [Get-MgBetaSiteList](Get-MgBetaSiteList.md)
The collection of lists under this site.

### [Get-MgBetaSiteListActivity](Get-MgBetaSiteListActivity.md)
The recent activities that took place within this list.

### [Get-MgBetaSiteListColumn](Get-MgBetaSiteListColumn.md)
Get columns from sites

### [Get-MgBetaSiteListContentType](Get-MgBetaSiteListContentType.md)
Get contentTypes from sites

### [Get-MgBetaSiteListContentTypeBase](Get-MgBetaSiteListContentTypeBase.md)
Parent contentType from which this content type is derived.

### [Get-MgBetaSiteListContentTypeBaseType](Get-MgBetaSiteListContentTypeBaseType.md)
The collection of content types that are ancestors of this content type.

### [Get-MgBetaSiteListContentTypeColumn](Get-MgBetaSiteListContentTypeColumn.md)
The collection of column definitions for this contentType.

### [Get-MgBetaSiteListContentTypeColumnLink](Get-MgBetaSiteListContentTypeColumnLink.md)
The collection of columns that are required by this content type

### [Get-MgBetaSiteListContentTypeColumnPosition](Get-MgBetaSiteListContentTypeColumnPosition.md)
Column order information in a content type.

### [Get-MgBetaSiteListContentTypeCompatibleHubContentType](Get-MgBetaSiteListContentTypeCompatibleHubContentType.md)
Invoke function getCompatibleHubContentTypes

### [Get-MgBetaSiteListDrive](Get-MgBetaSiteListDrive.md)
Only present on document libraries.
Allows access to the list as a [drive][] resource with [driveItems][driveItem].

### [Get-MgBetaSiteListItem](Get-MgBetaSiteListItem.md)
All items contained in the list.

### [Get-MgBetaSiteListItemActivity](Get-MgBetaSiteListItemActivity.md)
The list of recent activities that took place on this item.

### [Get-MgBetaSiteListItemActivityByInterval](Get-MgBetaSiteListItemActivityByInterval.md)
Invoke function getActivitiesByInterval

### [Get-MgBetaSiteListItemAnalytic](Get-MgBetaSiteListItemAnalytic.md)
Analytics about the view activities that took place on this item.

### [Get-MgBetaSiteListItemDelta](Get-MgBetaSiteListItemDelta.md)
Invoke function delta

### [Get-MgBetaSiteListItemDocumentSetVersion](Get-MgBetaSiteListItemDocumentSetVersion.md)
Version information for a document set version created by a user.

### [Get-MgBetaSiteListItemDriveItem](Get-MgBetaSiteListItemDriveItem.md)
For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]

### [Get-MgBetaSiteListItemDriveItemContent](Get-MgBetaSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Get-MgBetaSiteListItemField](Get-MgBetaSiteListItemField.md)
The values of the columns set on this list item.

### [Get-MgBetaSiteListItemVersion](Get-MgBetaSiteListItemVersion.md)
The list of previous versions of the list item.

### [Get-MgBetaSiteListItemVersionField](Get-MgBetaSiteListItemVersionField.md)
A collection of the fields and values for this version of the list item.

### [Get-MgBetaSiteListOperation](Get-MgBetaSiteListOperation.md)
The collection of long running operations for the list.

### [Get-MgBetaSiteListSubscription](Get-MgBetaSiteListSubscription.md)
The set of subscriptions on the list.

### [Get-MgBetaSiteOnenoteNotebookFromWebUrl](Get-MgBetaSiteOnenoteNotebookFromWebUrl.md)
Retrieve the properties and relationships of a notebook object by using its URL path.
The location can be user notebooks on Microsoft 365, group notebooks, or SharePoint site-hosted team notebooks on Microsoft 365.

### [Get-MgBetaSitePage](Get-MgBetaSitePage.md)
The collection of pages in the SitePages list in this site.

### [Get-MgBetaSitePermission](Get-MgBetaSitePermission.md)
The permissions associated with the site.
Nullable.

### [Get-MgBetaSiteRecentNotebook](Get-MgBetaSiteRecentNotebook.md)
Invoke function getRecentNotebooks

### [Get-MgBetaSiteTermStore](Get-MgBetaSiteTermStore.md)
Read the properties and relationships of a store object.

### [Get-MgBetaSiteTermStoreGroup](Get-MgBetaSiteTermStoreGroup.md)
Collection of all groups available in the term store.

### [Get-MgBetaSiteTermStoreGroupSet](Get-MgBetaSiteTermStoreGroupSet.md)
All sets under the group in a term [store].

### [Get-MgBetaSiteTermStoreGroupSetChild](Get-MgBetaSiteTermStoreGroupSetChild.md)
Children terms of set in term [store].

### [Get-MgBetaSiteTermStoreGroupSetRelation](Get-MgBetaSiteTermStoreGroupSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgBetaSiteTermStoreGroupSetTerm](Get-MgBetaSiteTermStoreGroupSetTerm.md)
All the terms under the set.

### [Get-MgBetaSiteTermStoreGroupSetTermChild](Get-MgBetaSiteTermStoreGroupSetTermChild.md)
Children of current term.

### [Get-MgBetaSiteTermStoreGroupSetTermRelation](Get-MgBetaSiteTermStoreGroupSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgBetaSiteTermStoreSet](Get-MgBetaSiteTermStoreSet.md)
Collection of all sets available in the term store.

### [Get-MgBetaSiteTermStoreSetChild](Get-MgBetaSiteTermStoreSetChild.md)
Children terms of set in term [store].

### [Get-MgBetaSiteTermStoreSetRelation](Get-MgBetaSiteTermStoreSetRelation.md)
Indicates which terms have been pinned or reused directly under the set.

### [Get-MgBetaSiteTermStoreSetTerm](Get-MgBetaSiteTermStoreSetTerm.md)
All the terms under the set.

### [Get-MgBetaSiteTermStoreSetTermChild](Get-MgBetaSiteTermStoreSetTermChild.md)
Children of current term.

### [Get-MgBetaSiteTermStoreSetTermRelation](Get-MgBetaSiteTermStoreSetTermRelation.md)
To indicate which terms are related to the current term as either pinned or reused.

### [Get-MgBetaSubSite](Get-MgBetaSubSite.md)
The collection of the sub-sites under this site.

### [Get-MgBetaUserFollowedSite](Get-MgBetaUserFollowedSite.md)
Get followedSites from users

### [Grant-MgBetaSitePermission](Grant-MgBetaSitePermission.md)
Grant users access to a link represented by a [permission][].

### [Invoke-MgBetaPreviewSiteOnenotePage](Invoke-MgBetaPreviewSiteOnenotePage.md)
Invoke function preview

### [Invoke-MgBetaReauthorizeSiteListSubscription](Invoke-MgBetaReauthorizeSiteListSubscription.md)
Invoke action reauthorize

### [Join-MgBetaSiteContentTypeWithHubSite](Join-MgBetaSiteContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [Join-MgBetaSiteListContentTypeWithHubSite](Join-MgBetaSiteListContentTypeWithHubSite.md)
Associate a [content type][contentType] with a list of hub sites.

### [New-MgBetaGroupSiteColumn](New-MgBetaGroupSiteColumn.md)
Create a column for a [site][site] by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaGroupSiteContentType](New-MgBetaGroupSiteContentType.md)
Create a new [contentType][] for a [site][].

### [New-MgBetaGroupSiteContentTypeColumn](New-MgBetaGroupSiteContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaGroupSiteContentTypeColumnLink](New-MgBetaGroupSiteContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgBetaGroupSiteList](New-MgBetaGroupSiteList.md)
Create a new [list][] in a [site][].

### [New-MgBetaGroupSiteListColumn](New-MgBetaGroupSiteListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaGroupSiteListContentType](New-MgBetaGroupSiteListContentType.md)
Create new navigation property to contentTypes for groups

### [New-MgBetaGroupSiteListContentTypeColumn](New-MgBetaGroupSiteListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaGroupSiteListContentTypeColumnLink](New-MgBetaGroupSiteListContentTypeColumnLink.md)
Create new navigation property to columnLinks for groups

### [New-MgBetaGroupSiteListItem](New-MgBetaGroupSiteListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaGroupSiteListItemDocumentSetVersion](New-MgBetaGroupSiteListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaGroupSiteListItemVersion](New-MgBetaGroupSiteListItemVersion.md)
Create new navigation property to versions for groups

### [New-MgBetaGroupSiteListOperation](New-MgBetaGroupSiteListOperation.md)
Create new navigation property to operations for groups

### [New-MgBetaGroupSiteListSubscription](New-MgBetaGroupSiteListSubscription.md)
Create new navigation property to subscriptions for groups

### [New-MgBetaGroupSiteOperation](New-MgBetaGroupSiteOperation.md)
Create new navigation property to operations for groups

### [New-MgBetaGroupSitePage](New-MgBetaGroupSitePage.md)
Create a new [sitePage][] in the site pages [list][] in a [site][].

### [New-MgBetaGroupSitePermission](New-MgBetaGroupSitePermission.md)
Create a new permission object on a site.

### [New-MgBetaGroupSiteTermStoreGroup](New-MgBetaGroupSiteTermStoreGroup.md)
Create a new group object.

### [New-MgBetaGroupSiteTermStoreGroupSet](New-MgBetaGroupSiteTermStoreGroupSet.md)
Create new navigation property to sets for groups

### [New-MgBetaGroupSiteTermStoreGroupSetChild](New-MgBetaGroupSiteTermStoreGroupSetChild.md)
Create a new term object.

### [New-MgBetaGroupSiteTermStoreGroupSetRelation](New-MgBetaGroupSiteTermStoreGroupSetRelation.md)
Create new navigation property to relations for groups

### [New-MgBetaGroupSiteTermStoreGroupSetTerm](New-MgBetaGroupSiteTermStoreGroupSetTerm.md)
Create new navigation property to terms for groups

### [New-MgBetaGroupSiteTermStoreGroupSetTermChild](New-MgBetaGroupSiteTermStoreGroupSetTermChild.md)
Create new navigation property to children for groups

### [New-MgBetaGroupSiteTermStoreGroupSetTermRelation](New-MgBetaGroupSiteTermStoreGroupSetTermRelation.md)
Create new navigation property to relations for groups

### [New-MgBetaGroupSiteTermStoreSet](New-MgBetaGroupSiteTermStoreSet.md)
Create new navigation property to sets for groups

### [New-MgBetaGroupSiteTermStoreSetChild](New-MgBetaGroupSiteTermStoreSetChild.md)
Create a new term object.

### [New-MgBetaGroupSiteTermStoreSetRelation](New-MgBetaGroupSiteTermStoreSetRelation.md)
Create new navigation property to relations for groups

### [New-MgBetaGroupSiteTermStoreSetTerm](New-MgBetaGroupSiteTermStoreSetTerm.md)
Create new navigation property to terms for groups

### [New-MgBetaGroupSiteTermStoreSetTermChild](New-MgBetaGroupSiteTermStoreSetTermChild.md)
Create new navigation property to children for groups

### [New-MgBetaGroupSiteTermStoreSetTermRelation](New-MgBetaGroupSiteTermStoreSetTermRelation.md)
Create new navigation property to relations for groups

### [New-MgBetaSiteColumn](New-MgBetaSiteColumn.md)
Create a column for a [site][site] by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaSiteContentType](New-MgBetaSiteContentType.md)
Create a new [contentType][] for a [site][].

### [New-MgBetaSiteContentTypeColumn](New-MgBetaSiteContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaSiteContentTypeColumnLink](New-MgBetaSiteContentTypeColumnLink.md)
Create new navigation property to columnLinks for sites

### [New-MgBetaSiteList](New-MgBetaSiteList.md)
Create a new [list][] in a [site][].

### [New-MgBetaSiteListColumn](New-MgBetaSiteListColumn.md)
Create a column for a [list][list] with a request that specifies a [columnDefinition][columnDefinition].

### [New-MgBetaSiteListContentType](New-MgBetaSiteListContentType.md)
Create new navigation property to contentTypes for sites

### [New-MgBetaSiteListContentTypeColumn](New-MgBetaSiteListContentTypeColumn.md)
Add a column to a [content type][contentType] in a site or list by specifying a [columnDefinition][columnDefinition].

### [New-MgBetaSiteListContentTypeColumnLink](New-MgBetaSiteListContentTypeColumnLink.md)
Create new navigation property to columnLinks for sites

### [New-MgBetaSiteListItem](New-MgBetaSiteListItem.md)
Create a new [listItem][] in a [list][].

### [New-MgBetaSiteListItemDocumentSetVersion](New-MgBetaSiteListItemDocumentSetVersion.md)
Create a new version of a document set item in a list.

### [New-MgBetaSiteListItemLink](New-MgBetaSiteListItemLink.md)
Create a sharing link for a listItem.
The **createLink** action creates a new sharing link if the specified link type doesn't already exist for the calling application.\nIf a sharing link of the specified type already exists for the app, this action will return the existing sharing link.
**listItem** resources inherit sharing permissions from the list the item resides in.

### [New-MgBetaSiteListItemVersion](New-MgBetaSiteListItemVersion.md)
Create new navigation property to versions for sites

### [New-MgBetaSiteListOperation](New-MgBetaSiteListOperation.md)
Create new navigation property to operations for sites

### [New-MgBetaSiteListSubscription](New-MgBetaSiteListSubscription.md)
Create new navigation property to subscriptions for sites

### [New-MgBetaSitePage](New-MgBetaSitePage.md)
Create a new [sitePage][] in the site pages [list][] in a [site][].

### [New-MgBetaSitePermission](New-MgBetaSitePermission.md)
Create a new permission object on a site.

### [New-MgBetaSiteTermStoreGroup](New-MgBetaSiteTermStoreGroup.md)
Create a new group object.

### [New-MgBetaSiteTermStoreGroupSet](New-MgBetaSiteTermStoreGroupSet.md)
Create new navigation property to sets for sites

### [New-MgBetaSiteTermStoreGroupSetChild](New-MgBetaSiteTermStoreGroupSetChild.md)
Create a new term object.

### [New-MgBetaSiteTermStoreGroupSetRelation](New-MgBetaSiteTermStoreGroupSetRelation.md)
Create new navigation property to relations for sites

### [New-MgBetaSiteTermStoreGroupSetTerm](New-MgBetaSiteTermStoreGroupSetTerm.md)
Create new navigation property to terms for sites

### [New-MgBetaSiteTermStoreGroupSetTermChild](New-MgBetaSiteTermStoreGroupSetTermChild.md)
Create new navigation property to children for sites

### [New-MgBetaSiteTermStoreGroupSetTermRelation](New-MgBetaSiteTermStoreGroupSetTermRelation.md)
Create new navigation property to relations for sites

### [New-MgBetaSiteTermStoreSet](New-MgBetaSiteTermStoreSet.md)
Create new navigation property to sets for sites

### [New-MgBetaSiteTermStoreSetChild](New-MgBetaSiteTermStoreSetChild.md)
Create a new term object.

### [New-MgBetaSiteTermStoreSetRelation](New-MgBetaSiteTermStoreSetRelation.md)
Create new navigation property to relations for sites

### [New-MgBetaSiteTermStoreSetTerm](New-MgBetaSiteTermStoreSetTerm.md)
Create new navigation property to terms for sites

### [New-MgBetaSiteTermStoreSetTermChild](New-MgBetaSiteTermStoreSetTermChild.md)
Create new navigation property to children for sites

### [New-MgBetaSiteTermStoreSetTermRelation](New-MgBetaSiteTermStoreSetTermRelation.md)
Create new navigation property to relations for sites

### [Publish-MgBetaSiteContentType](Publish-MgBetaSiteContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaSiteListContentType](Publish-MgBetaSiteListContentType.md)
Publishes a [contentType][] present in a content type hub site.

### [Publish-MgBetaSitePage](Publish-MgBetaSitePage.md)
Invoke action publish

### [Remove-MgBetaGroupSiteColumn](Remove-MgBetaGroupSiteColumn.md)
Delete navigation property columns for groups

### [Remove-MgBetaGroupSiteContentType](Remove-MgBetaGroupSiteContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgBetaGroupSiteContentTypeColumn](Remove-MgBetaGroupSiteContentTypeColumn.md)
Delete navigation property columns for groups

### [Remove-MgBetaGroupSiteContentTypeColumnLink](Remove-MgBetaGroupSiteContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgBetaGroupSiteList](Remove-MgBetaGroupSiteList.md)
Delete navigation property lists for groups

### [Remove-MgBetaGroupSiteListColumn](Remove-MgBetaGroupSiteListColumn.md)
Delete navigation property columns for groups

### [Remove-MgBetaGroupSiteListContentType](Remove-MgBetaGroupSiteListContentType.md)
Delete navigation property contentTypes for groups

### [Remove-MgBetaGroupSiteListContentTypeColumn](Remove-MgBetaGroupSiteListContentTypeColumn.md)
Delete navigation property columns for groups

### [Remove-MgBetaGroupSiteListContentTypeColumnLink](Remove-MgBetaGroupSiteListContentTypeColumnLink.md)
Delete navigation property columnLinks for groups

### [Remove-MgBetaGroupSiteListItem](Remove-MgBetaGroupSiteListItem.md)
Delete navigation property items for groups

### [Remove-MgBetaGroupSiteListItemDocumentSetVersion](Remove-MgBetaGroupSiteListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for groups

### [Remove-MgBetaGroupSiteListItemField](Remove-MgBetaGroupSiteListItemField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupSiteListItemVersion](Remove-MgBetaGroupSiteListItemVersion.md)
Delete navigation property versions for groups

### [Remove-MgBetaGroupSiteListItemVersionField](Remove-MgBetaGroupSiteListItemVersionField.md)
Delete navigation property fields for groups

### [Remove-MgBetaGroupSiteListOperation](Remove-MgBetaGroupSiteListOperation.md)
Delete navigation property operations for groups

### [Remove-MgBetaGroupSiteListSubscription](Remove-MgBetaGroupSiteListSubscription.md)
Delete navigation property subscriptions for groups

### [Remove-MgBetaGroupSiteOperation](Remove-MgBetaGroupSiteOperation.md)
Delete navigation property operations for groups

### [Remove-MgBetaGroupSitePage](Remove-MgBetaGroupSitePage.md)
Delete navigation property pages for groups

### [Remove-MgBetaGroupSitePermission](Remove-MgBetaGroupSitePermission.md)
Delete navigation property permissions for groups

### [Remove-MgBetaGroupSiteTermStore](Remove-MgBetaGroupSiteTermStore.md)
Delete navigation property termStore for groups

### [Remove-MgBetaGroupSiteTermStoreGroup](Remove-MgBetaGroupSiteTermStoreGroup.md)
Delete navigation property groups for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSet](Remove-MgBetaGroupSiteTermStoreGroupSet.md)
Delete navigation property sets for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSetChild](Remove-MgBetaGroupSiteTermStoreGroupSetChild.md)
Delete navigation property children for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSetRelation](Remove-MgBetaGroupSiteTermStoreGroupSetRelation.md)
Delete navigation property relations for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSetTerm](Remove-MgBetaGroupSiteTermStoreGroupSetTerm.md)
Delete navigation property terms for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSetTermChild](Remove-MgBetaGroupSiteTermStoreGroupSetTermChild.md)
Delete navigation property children for groups

### [Remove-MgBetaGroupSiteTermStoreGroupSetTermRelation](Remove-MgBetaGroupSiteTermStoreGroupSetTermRelation.md)
Delete navigation property relations for groups

### [Remove-MgBetaGroupSiteTermStoreSet](Remove-MgBetaGroupSiteTermStoreSet.md)
Delete navigation property sets for groups

### [Remove-MgBetaGroupSiteTermStoreSetChild](Remove-MgBetaGroupSiteTermStoreSetChild.md)
Delete navigation property children for groups

### [Remove-MgBetaGroupSiteTermStoreSetRelation](Remove-MgBetaGroupSiteTermStoreSetRelation.md)
Delete navigation property relations for groups

### [Remove-MgBetaGroupSiteTermStoreSetTerm](Remove-MgBetaGroupSiteTermStoreSetTerm.md)
Delete navigation property terms for groups

### [Remove-MgBetaGroupSiteTermStoreSetTermChild](Remove-MgBetaGroupSiteTermStoreSetTermChild.md)
Delete navigation property children for groups

### [Remove-MgBetaGroupSiteTermStoreSetTermRelation](Remove-MgBetaGroupSiteTermStoreSetTermRelation.md)
Delete navigation property relations for groups

### [Remove-MgBetaSiteColumn](Remove-MgBetaSiteColumn.md)
Delete navigation property columns for sites

### [Remove-MgBetaSiteContentType](Remove-MgBetaSiteContentType.md)
Delete navigation property contentTypes for sites

### [Remove-MgBetaSiteContentTypeColumn](Remove-MgBetaSiteContentTypeColumn.md)
Delete navigation property columns for sites

### [Remove-MgBetaSiteContentTypeColumnLink](Remove-MgBetaSiteContentTypeColumnLink.md)
Delete navigation property columnLinks for sites

### [Remove-MgBetaSiteList](Remove-MgBetaSiteList.md)
Delete navigation property lists for sites

### [Remove-MgBetaSiteListColumn](Remove-MgBetaSiteListColumn.md)
Delete navigation property columns for sites

### [Remove-MgBetaSiteListContentType](Remove-MgBetaSiteListContentType.md)
Delete navigation property contentTypes for sites

### [Remove-MgBetaSiteListContentTypeColumn](Remove-MgBetaSiteListContentTypeColumn.md)
Delete navigation property columns for sites

### [Remove-MgBetaSiteListContentTypeColumnLink](Remove-MgBetaSiteListContentTypeColumnLink.md)
Delete navigation property columnLinks for sites

### [Remove-MgBetaSiteListItem](Remove-MgBetaSiteListItem.md)
Delete navigation property items for sites

### [Remove-MgBetaSiteListItemDocumentSetVersion](Remove-MgBetaSiteListItemDocumentSetVersion.md)
Delete navigation property documentSetVersions for sites

### [Remove-MgBetaSiteListItemField](Remove-MgBetaSiteListItemField.md)
Delete navigation property fields for sites

### [Remove-MgBetaSiteListItemVersion](Remove-MgBetaSiteListItemVersion.md)
Delete navigation property versions for sites

### [Remove-MgBetaSiteListItemVersionField](Remove-MgBetaSiteListItemVersionField.md)
Delete navigation property fields for sites

### [Remove-MgBetaSiteListOperation](Remove-MgBetaSiteListOperation.md)
Delete navigation property operations for sites

### [Remove-MgBetaSiteListSubscription](Remove-MgBetaSiteListSubscription.md)
Delete navigation property subscriptions for sites

### [Remove-MgBetaSitePage](Remove-MgBetaSitePage.md)
Delete navigation property pages for sites

### [Remove-MgBetaSitePermission](Remove-MgBetaSitePermission.md)
Delete navigation property permissions for sites

### [Remove-MgBetaSiteTermStore](Remove-MgBetaSiteTermStore.md)
Delete navigation property termStore for sites

### [Remove-MgBetaSiteTermStoreGroup](Remove-MgBetaSiteTermStoreGroup.md)
Delete navigation property groups for sites

### [Remove-MgBetaSiteTermStoreGroupSet](Remove-MgBetaSiteTermStoreGroupSet.md)
Delete navigation property sets for sites

### [Remove-MgBetaSiteTermStoreGroupSetChild](Remove-MgBetaSiteTermStoreGroupSetChild.md)
Delete navigation property children for sites

### [Remove-MgBetaSiteTermStoreGroupSetRelation](Remove-MgBetaSiteTermStoreGroupSetRelation.md)
Delete navigation property relations for sites

### [Remove-MgBetaSiteTermStoreGroupSetTerm](Remove-MgBetaSiteTermStoreGroupSetTerm.md)
Delete navigation property terms for sites

### [Remove-MgBetaSiteTermStoreGroupSetTermChild](Remove-MgBetaSiteTermStoreGroupSetTermChild.md)
Delete navigation property children for sites

### [Remove-MgBetaSiteTermStoreGroupSetTermRelation](Remove-MgBetaSiteTermStoreGroupSetTermRelation.md)
Delete navigation property relations for sites

### [Remove-MgBetaSiteTermStoreSet](Remove-MgBetaSiteTermStoreSet.md)
Delete navigation property sets for sites

### [Remove-MgBetaSiteTermStoreSetChild](Remove-MgBetaSiteTermStoreSetChild.md)
Delete navigation property children for sites

### [Remove-MgBetaSiteTermStoreSetRelation](Remove-MgBetaSiteTermStoreSetRelation.md)
Delete navigation property relations for sites

### [Remove-MgBetaSiteTermStoreSetTerm](Remove-MgBetaSiteTermStoreSetTerm.md)
Delete navigation property terms for sites

### [Remove-MgBetaSiteTermStoreSetTermChild](Remove-MgBetaSiteTermStoreSetTermChild.md)
Delete navigation property children for sites

### [Remove-MgBetaSiteTermStoreSetTermRelation](Remove-MgBetaSiteTermStoreSetTermRelation.md)
Delete navigation property relations for sites

### [Restore-MgBetaSiteListItemDocumentSetVersion](Restore-MgBetaSiteListItemDocumentSetVersion.md)
Restore a document set version.

### [Restore-MgBetaSiteListItemVersion](Restore-MgBetaSiteListItemVersion.md)
Invoke action restoreVersion

### [Revoke-MgBetaSitePermissionGrant](Revoke-MgBetaSitePermissionGrant.md)
Revoke access to a [listItem][] or [driveItem][] granted via a sharing link by removing the specified [recipient][] from the link.

### [Set-MgBetaGroupSiteListItemDriveItemContent](Set-MgBetaGroupSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Set-MgBetaSiteListItemDriveItemContent](Set-MgBetaSiteListItemDriveItemContent.md)
The content stream, if the item represents a file.

### [Test-MgBetaSiteContentTypePublished](Test-MgBetaSiteContentTypePublished.md)
Invoke function isPublished

### [Test-MgBetaSiteListContentTypePublished](Test-MgBetaSiteListContentTypePublished.md)
Invoke function isPublished

### [Unpublish-MgBetaSiteContentType](Unpublish-MgBetaSiteContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Unpublish-MgBetaSiteListContentType](Unpublish-MgBetaSiteListContentType.md)
Unpublish a [contentType][] from a content type hub site.

### [Update-MgBetaGroupSite](Update-MgBetaGroupSite.md)
Update the navigation property sites in groups

### [Update-MgBetaGroupSiteColumn](Update-MgBetaGroupSiteColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupSiteContentType](Update-MgBetaGroupSiteContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgBetaGroupSiteContentTypeColumn](Update-MgBetaGroupSiteContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupSiteContentTypeColumnLink](Update-MgBetaGroupSiteContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgBetaGroupSiteList](Update-MgBetaGroupSiteList.md)
Update the navigation property lists in groups

### [Update-MgBetaGroupSiteListColumn](Update-MgBetaGroupSiteListColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupSiteListContentType](Update-MgBetaGroupSiteListContentType.md)
Update the navigation property contentTypes in groups

### [Update-MgBetaGroupSiteListContentTypeColumn](Update-MgBetaGroupSiteListContentTypeColumn.md)
Update the navigation property columns in groups

### [Update-MgBetaGroupSiteListContentTypeColumnLink](Update-MgBetaGroupSiteListContentTypeColumnLink.md)
Update the navigation property columnLinks in groups

### [Update-MgBetaGroupSiteListItem](Update-MgBetaGroupSiteListItem.md)
Update the navigation property items in groups

### [Update-MgBetaGroupSiteListItemDocumentSetVersion](Update-MgBetaGroupSiteListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in groups

### [Update-MgBetaGroupSiteListItemField](Update-MgBetaGroupSiteListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaGroupSiteListItemVersion](Update-MgBetaGroupSiteListItemVersion.md)
Update the navigation property versions in groups

### [Update-MgBetaGroupSiteListItemVersionField](Update-MgBetaGroupSiteListItemVersionField.md)
Update the navigation property fields in groups

### [Update-MgBetaGroupSiteListOperation](Update-MgBetaGroupSiteListOperation.md)
Update the navigation property operations in groups

### [Update-MgBetaGroupSiteListSubscription](Update-MgBetaGroupSiteListSubscription.md)
Update the navigation property subscriptions in groups

### [Update-MgBetaGroupSiteOperation](Update-MgBetaGroupSiteOperation.md)
Update the navigation property operations in groups

### [Update-MgBetaGroupSitePage](Update-MgBetaGroupSitePage.md)
Update the navigation property pages in groups

### [Update-MgBetaGroupSitePermission](Update-MgBetaGroupSitePermission.md)
Update the navigation property permissions in groups

### [Update-MgBetaGroupSiteTermStore](Update-MgBetaGroupSiteTermStore.md)
Update the navigation property termStore in groups

### [Update-MgBetaGroupSiteTermStoreGroup](Update-MgBetaGroupSiteTermStoreGroup.md)
Update the navigation property groups in groups

### [Update-MgBetaGroupSiteTermStoreGroupSet](Update-MgBetaGroupSiteTermStoreGroupSet.md)
Update the navigation property sets in groups

### [Update-MgBetaGroupSiteTermStoreGroupSetChild](Update-MgBetaGroupSiteTermStoreGroupSetChild.md)
Update the navigation property children in groups

### [Update-MgBetaGroupSiteTermStoreGroupSetRelation](Update-MgBetaGroupSiteTermStoreGroupSetRelation.md)
Update the navigation property relations in groups

### [Update-MgBetaGroupSiteTermStoreGroupSetTerm](Update-MgBetaGroupSiteTermStoreGroupSetTerm.md)
Update the navigation property terms in groups

### [Update-MgBetaGroupSiteTermStoreGroupSetTermChild](Update-MgBetaGroupSiteTermStoreGroupSetTermChild.md)
Update the navigation property children in groups

### [Update-MgBetaGroupSiteTermStoreGroupSetTermRelation](Update-MgBetaGroupSiteTermStoreGroupSetTermRelation.md)
Update the navigation property relations in groups

### [Update-MgBetaGroupSiteTermStoreSet](Update-MgBetaGroupSiteTermStoreSet.md)
Update the navigation property sets in groups

### [Update-MgBetaGroupSiteTermStoreSetChild](Update-MgBetaGroupSiteTermStoreSetChild.md)
Update the navigation property children in groups

### [Update-MgBetaGroupSiteTermStoreSetRelation](Update-MgBetaGroupSiteTermStoreSetRelation.md)
Update the navigation property relations in groups

### [Update-MgBetaGroupSiteTermStoreSetTerm](Update-MgBetaGroupSiteTermStoreSetTerm.md)
Update the navigation property terms in groups

### [Update-MgBetaGroupSiteTermStoreSetTermChild](Update-MgBetaGroupSiteTermStoreSetTermChild.md)
Update the navigation property children in groups

### [Update-MgBetaGroupSiteTermStoreSetTermRelation](Update-MgBetaGroupSiteTermStoreSetTermRelation.md)
Update the navigation property relations in groups

### [Update-MgBetaSite](Update-MgBetaSite.md)
Update entity in sites

### [Update-MgBetaSiteColumn](Update-MgBetaSiteColumn.md)
Update the navigation property columns in sites

### [Update-MgBetaSiteContentType](Update-MgBetaSiteContentType.md)
Update the navigation property contentTypes in sites

### [Update-MgBetaSiteContentTypeColumn](Update-MgBetaSiteContentTypeColumn.md)
Update the navigation property columns in sites

### [Update-MgBetaSiteContentTypeColumnLink](Update-MgBetaSiteContentTypeColumnLink.md)
Update the navigation property columnLinks in sites

### [Update-MgBetaSiteList](Update-MgBetaSiteList.md)
Update the navigation property lists in sites

### [Update-MgBetaSiteListColumn](Update-MgBetaSiteListColumn.md)
Update the navigation property columns in sites

### [Update-MgBetaSiteListContentType](Update-MgBetaSiteListContentType.md)
Update the navigation property contentTypes in sites

### [Update-MgBetaSiteListContentTypeColumn](Update-MgBetaSiteListContentTypeColumn.md)
Update the navigation property columns in sites

### [Update-MgBetaSiteListContentTypeColumnLink](Update-MgBetaSiteListContentTypeColumnLink.md)
Update the navigation property columnLinks in sites

### [Update-MgBetaSiteListItem](Update-MgBetaSiteListItem.md)
Update the navigation property items in sites

### [Update-MgBetaSiteListItemDocumentSetVersion](Update-MgBetaSiteListItemDocumentSetVersion.md)
Update the navigation property documentSetVersions in sites

### [Update-MgBetaSiteListItemField](Update-MgBetaSiteListItemField.md)
Update the properties on a **[listItem][]**.

### [Update-MgBetaSiteListItemVersion](Update-MgBetaSiteListItemVersion.md)
Update the navigation property versions in sites

### [Update-MgBetaSiteListItemVersionField](Update-MgBetaSiteListItemVersionField.md)
Update the navigation property fields in sites

### [Update-MgBetaSiteListOperation](Update-MgBetaSiteListOperation.md)
Update the navigation property operations in sites

### [Update-MgBetaSiteListSubscription](Update-MgBetaSiteListSubscription.md)
Update the navigation property subscriptions in sites

### [Update-MgBetaSiteOnenotePageContent](Update-MgBetaSiteOnenotePageContent.md)
Invoke action onenotePatchContent

### [Update-MgBetaSitePage](Update-MgBetaSitePage.md)
Update the navigation property pages in sites

### [Update-MgBetaSitePermission](Update-MgBetaSitePermission.md)
Update the navigation property permissions in sites

### [Update-MgBetaSiteTermStore](Update-MgBetaSiteTermStore.md)
Update the navigation property termStore in sites

### [Update-MgBetaSiteTermStoreGroup](Update-MgBetaSiteTermStoreGroup.md)
Update the navigation property groups in sites

### [Update-MgBetaSiteTermStoreGroupSet](Update-MgBetaSiteTermStoreGroupSet.md)
Update the navigation property sets in sites

### [Update-MgBetaSiteTermStoreGroupSetChild](Update-MgBetaSiteTermStoreGroupSetChild.md)
Update the navigation property children in sites

### [Update-MgBetaSiteTermStoreGroupSetRelation](Update-MgBetaSiteTermStoreGroupSetRelation.md)
Update the navigation property relations in sites

### [Update-MgBetaSiteTermStoreGroupSetTerm](Update-MgBetaSiteTermStoreGroupSetTerm.md)
Update the navigation property terms in sites

### [Update-MgBetaSiteTermStoreGroupSetTermChild](Update-MgBetaSiteTermStoreGroupSetTermChild.md)
Update the navigation property children in sites

### [Update-MgBetaSiteTermStoreGroupSetTermRelation](Update-MgBetaSiteTermStoreGroupSetTermRelation.md)
Update the navigation property relations in sites

### [Update-MgBetaSiteTermStoreSet](Update-MgBetaSiteTermStoreSet.md)
Update the navigation property sets in sites

### [Update-MgBetaSiteTermStoreSetChild](Update-MgBetaSiteTermStoreSetChild.md)
Update the navigation property children in sites

### [Update-MgBetaSiteTermStoreSetRelation](Update-MgBetaSiteTermStoreSetRelation.md)
Update the navigation property relations in sites

### [Update-MgBetaSiteTermStoreSetTerm](Update-MgBetaSiteTermStoreSetTerm.md)
Update the navigation property terms in sites

### [Update-MgBetaSiteTermStoreSetTermChild](Update-MgBetaSiteTermStoreSetTermChild.md)
Update the navigation property children in sites

### [Update-MgBetaSiteTermStoreSetTermRelation](Update-MgBetaSiteTermStoreSetTermRelation.md)
Update the navigation property relations in sites

