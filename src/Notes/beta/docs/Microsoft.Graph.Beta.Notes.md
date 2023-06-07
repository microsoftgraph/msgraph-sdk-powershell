---
Module Name: Microsoft.Graph.Beta.Notes
Module Guid: ea8cf835-22ae-4566-8d60-f7850b4a3a46
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.notes
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.Notes Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.Notes Cmdlets
### [Get-MgBetaGroupOnenoteNotebook](Get-MgBetaGroupOnenoteNotebook.md)
Retrieve the properties and relationships of a notebook object.

### [Get-MgBetaGroupOnenoteNotebookCount](Get-MgBetaGroupOnenoteNotebookCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteNotebookSection](Get-MgBetaGroupOnenoteNotebookSection.md)
Retrieve a list of section objects from the specified notebook.

### [Get-MgBetaGroupOnenoteNotebookSectionGroup](Get-MgBetaGroupOnenoteNotebookSectionGroup.md)
Retrieve a list of section groups from the specified notebook.

### [Get-MgBetaGroupOnenoteOperation](Get-MgBetaGroupOnenoteOperation.md)
Get the status of a long-running OneNote operation.
This applies to operations that return the **Operation-Location** header in the response, such as `CopyNotebook`, `CopyToNotebook`, `CopyToSectionGroup`, `and CopyToSection`.
  You can poll the Operation-Location endpoint until the `status` property returns `completed` or `failed`.
If the status is `completed`, the `resourceLocation` property contains the resource endpoint URI.
If the status is `failed`, the error and `@api.diagnostics` properties provide error information.

### [Get-MgBetaGroupOnenoteOperationCount](Get-MgBetaGroupOnenoteOperationCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenotePage](Get-MgBetaGroupOnenotePage.md)
The pages in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.

### [Get-MgBetaGroupOnenotePageContent](Get-MgBetaGroupOnenotePageContent.md)
The page's HTML content.

### [Get-MgBetaGroupOnenotePageCount](Get-MgBetaGroupOnenotePageCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteResource](Get-MgBetaGroupOnenoteResource.md)
The image and other file resources in OneNote pages.
Getting a resources collection is not supported, but you can get the binary content of a specific resource.
Read-only.
Nullable.

### [Get-MgBetaGroupOnenoteResourceContent](Get-MgBetaGroupOnenoteResourceContent.md)
Get content for the navigation property resources from groups

### [Get-MgBetaGroupOnenoteResourceCount](Get-MgBetaGroupOnenoteResourceCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteSection](Get-MgBetaGroupOnenoteSection.md)
Retrieve the properties and relationships of a section object.

### [Get-MgBetaGroupOnenoteSectionCount](Get-MgBetaGroupOnenoteSectionCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteSectionGroup](Get-MgBetaGroupOnenoteSectionGroup.md)
Retrieve the properties and relationships of a sectionGroup object.

### [Get-MgBetaGroupOnenoteSectionGroupCount](Get-MgBetaGroupOnenoteSectionGroupCount.md)
Get the number of the resource

### [Get-MgBetaGroupOnenoteSectionGroupSection](Get-MgBetaGroupOnenoteSectionGroupSection.md)
Retrieve a list of onenoteSection objects from the specified section group.

### [Get-MgBetaGroupOnenoteSectionPage](Get-MgBetaGroupOnenoteSectionPage.md)
The collection of pages in the section.
Read-only.
Nullable.

### [Get-MgBetaSiteOnenoteNotebook](Get-MgBetaSiteOnenoteNotebook.md)
Retrieve the properties and relationships of a notebook object.

### [Get-MgBetaSiteOnenoteNotebookCount](Get-MgBetaSiteOnenoteNotebookCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenoteNotebookSection](Get-MgBetaSiteOnenoteNotebookSection.md)
Retrieve a list of section objects from the specified notebook.

### [Get-MgBetaSiteOnenoteNotebookSectionGroup](Get-MgBetaSiteOnenoteNotebookSectionGroup.md)
Retrieve a list of section groups from the specified notebook.

### [Get-MgBetaSiteOnenoteOperation](Get-MgBetaSiteOnenoteOperation.md)
Get the status of a long-running OneNote operation.
This applies to operations that return the **Operation-Location** header in the response, such as `CopyNotebook`, `CopyToNotebook`, `CopyToSectionGroup`, `and CopyToSection`.
  You can poll the Operation-Location endpoint until the `status` property returns `completed` or `failed`.
If the status is `completed`, the `resourceLocation` property contains the resource endpoint URI.
If the status is `failed`, the error and `@api.diagnostics` properties provide error information.

### [Get-MgBetaSiteOnenoteOperationCount](Get-MgBetaSiteOnenoteOperationCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenotePage](Get-MgBetaSiteOnenotePage.md)
The pages in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.

### [Get-MgBetaSiteOnenotePageContent](Get-MgBetaSiteOnenotePageContent.md)
The page's HTML content.

### [Get-MgBetaSiteOnenotePageCount](Get-MgBetaSiteOnenotePageCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenoteResource](Get-MgBetaSiteOnenoteResource.md)
The image and other file resources in OneNote pages.
Getting a resources collection is not supported, but you can get the binary content of a specific resource.
Read-only.
Nullable.

### [Get-MgBetaSiteOnenoteResourceContent](Get-MgBetaSiteOnenoteResourceContent.md)
Get content for the navigation property resources from sites

### [Get-MgBetaSiteOnenoteResourceCount](Get-MgBetaSiteOnenoteResourceCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenoteSection](Get-MgBetaSiteOnenoteSection.md)
Retrieve the properties and relationships of a section object.

### [Get-MgBetaSiteOnenoteSectionCount](Get-MgBetaSiteOnenoteSectionCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenoteSectionGroup](Get-MgBetaSiteOnenoteSectionGroup.md)
Retrieve the properties and relationships of a sectionGroup object.

### [Get-MgBetaSiteOnenoteSectionGroupCount](Get-MgBetaSiteOnenoteSectionGroupCount.md)
Get the number of the resource

### [Get-MgBetaSiteOnenoteSectionGroupSection](Get-MgBetaSiteOnenoteSectionGroupSection.md)
Retrieve a list of onenoteSection objects from the specified section group.

### [Get-MgBetaSiteOnenoteSectionPage](Get-MgBetaSiteOnenoteSectionPage.md)
The collection of pages in the section.
Read-only.
Nullable.

### [Get-MgBetaUserOnenoteNotebook](Get-MgBetaUserOnenoteNotebook.md)
Retrieve the properties and relationships of a notebook object.

### [Get-MgBetaUserOnenoteNotebookCount](Get-MgBetaUserOnenoteNotebookCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenoteNotebookSection](Get-MgBetaUserOnenoteNotebookSection.md)
Retrieve a list of section objects from the specified notebook.

### [Get-MgBetaUserOnenoteNotebookSectionGroup](Get-MgBetaUserOnenoteNotebookSectionGroup.md)
Retrieve a list of section groups from the specified notebook.

### [Get-MgBetaUserOnenoteOperation](Get-MgBetaUserOnenoteOperation.md)
Get the status of a long-running OneNote operation.
This applies to operations that return the **Operation-Location** header in the response, such as `CopyNotebook`, `CopyToNotebook`, `CopyToSectionGroup`, `and CopyToSection`.
  You can poll the Operation-Location endpoint until the `status` property returns `completed` or `failed`.
If the status is `completed`, the `resourceLocation` property contains the resource endpoint URI.
If the status is `failed`, the error and `@api.diagnostics` properties provide error information.

### [Get-MgBetaUserOnenoteOperationCount](Get-MgBetaUserOnenoteOperationCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenotePage](Get-MgBetaUserOnenotePage.md)
The pages in all OneNote notebooks that are owned by the user or group.
Read-only.
Nullable.

### [Get-MgBetaUserOnenotePageContent](Get-MgBetaUserOnenotePageContent.md)
The page's HTML content.

### [Get-MgBetaUserOnenotePageCount](Get-MgBetaUserOnenotePageCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenoteResource](Get-MgBetaUserOnenoteResource.md)
The image and other file resources in OneNote pages.
Getting a resources collection is not supported, but you can get the binary content of a specific resource.
Read-only.
Nullable.

### [Get-MgBetaUserOnenoteResourceContent](Get-MgBetaUserOnenoteResourceContent.md)
Get content for the navigation property resources from users

### [Get-MgBetaUserOnenoteResourceCount](Get-MgBetaUserOnenoteResourceCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenoteSection](Get-MgBetaUserOnenoteSection.md)
Retrieve the properties and relationships of a section object.

### [Get-MgBetaUserOnenoteSectionCount](Get-MgBetaUserOnenoteSectionCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenoteSectionGroup](Get-MgBetaUserOnenoteSectionGroup.md)
Retrieve the properties and relationships of a sectionGroup object.

### [Get-MgBetaUserOnenoteSectionGroupCount](Get-MgBetaUserOnenoteSectionGroupCount.md)
Get the number of the resource

### [Get-MgBetaUserOnenoteSectionGroupSection](Get-MgBetaUserOnenoteSectionGroupSection.md)
Retrieve a list of onenoteSection objects from the specified section group.

### [Get-MgBetaUserOnenoteSectionPage](Get-MgBetaUserOnenoteSectionPage.md)
The collection of pages in the section.
Read-only.
Nullable.

### [New-MgBetaGroupOnenoteNotebook](New-MgBetaGroupOnenoteNotebook.md)
Create a new OneNote notebook.

### [New-MgBetaGroupOnenoteNotebookSection](New-MgBetaGroupOnenoteNotebookSection.md)
Create a new section in the specified notebook.

### [New-MgBetaGroupOnenoteNotebookSectionGroup](New-MgBetaGroupOnenoteNotebookSectionGroup.md)
Create a new section group in the specified notebook.

### [New-MgBetaGroupOnenotePage](New-MgBetaGroupOnenotePage.md)
Create new navigation property to pages for groups

### [New-MgBetaGroupOnenoteSection](New-MgBetaGroupOnenoteSection.md)
Create new navigation property to sections for groups

### [New-MgBetaGroupOnenoteSectionGroup](New-MgBetaGroupOnenoteSectionGroup.md)
Create new navigation property to sectionGroups for groups

### [New-MgBetaGroupOnenoteSectionGroupSection](New-MgBetaGroupOnenoteSectionGroupSection.md)
Create a new section in the specified section group.

### [New-MgBetaGroupOnenoteSectionPage](New-MgBetaGroupOnenoteSectionPage.md)
Create new navigation property to pages for groups

### [New-MgBetaSiteOnenoteNotebook](New-MgBetaSiteOnenoteNotebook.md)
Create a new OneNote notebook.

### [New-MgBetaSiteOnenoteNotebookSection](New-MgBetaSiteOnenoteNotebookSection.md)
Create a new section in the specified notebook.

### [New-MgBetaSiteOnenoteNotebookSectionGroup](New-MgBetaSiteOnenoteNotebookSectionGroup.md)
Create a new section group in the specified notebook.

### [New-MgBetaSiteOnenotePage](New-MgBetaSiteOnenotePage.md)
Create new navigation property to pages for sites

### [New-MgBetaSiteOnenoteSection](New-MgBetaSiteOnenoteSection.md)
Create new navigation property to sections for sites

### [New-MgBetaSiteOnenoteSectionGroup](New-MgBetaSiteOnenoteSectionGroup.md)
Create new navigation property to sectionGroups for sites

### [New-MgBetaSiteOnenoteSectionGroupSection](New-MgBetaSiteOnenoteSectionGroupSection.md)
Create a new section in the specified section group.

### [New-MgBetaSiteOnenoteSectionPage](New-MgBetaSiteOnenoteSectionPage.md)
Create new navigation property to pages for sites

### [New-MgBetaUserOnenoteNotebook](New-MgBetaUserOnenoteNotebook.md)
Create a new OneNote notebook.

### [New-MgBetaUserOnenoteNotebookSection](New-MgBetaUserOnenoteNotebookSection.md)
Create a new section in the specified notebook.

### [New-MgBetaUserOnenoteNotebookSectionGroup](New-MgBetaUserOnenoteNotebookSectionGroup.md)
Create a new section group in the specified notebook.

### [New-MgBetaUserOnenotePage](New-MgBetaUserOnenotePage.md)
Create new navigation property to pages for users

### [New-MgBetaUserOnenoteSection](New-MgBetaUserOnenoteSection.md)
Create new navigation property to sections for users

### [New-MgBetaUserOnenoteSectionGroup](New-MgBetaUserOnenoteSectionGroup.md)
Create new navigation property to sectionGroups for users

### [New-MgBetaUserOnenoteSectionGroupSection](New-MgBetaUserOnenoteSectionGroupSection.md)
Create a new section in the specified section group.

### [New-MgBetaUserOnenoteSectionPage](New-MgBetaUserOnenoteSectionPage.md)
Create new navigation property to pages for users

### [Remove-MgBetaGroupOnenoteNotebook](Remove-MgBetaGroupOnenoteNotebook.md)
Delete navigation property notebooks for groups

### [Remove-MgBetaGroupOnenotePage](Remove-MgBetaGroupOnenotePage.md)
Delete a OneNote page.

### [Remove-MgBetaGroupOnenoteSection](Remove-MgBetaGroupOnenoteSection.md)
Delete navigation property sections for groups

### [Remove-MgBetaGroupOnenoteSectionGroup](Remove-MgBetaGroupOnenoteSectionGroup.md)
Delete navigation property sectionGroups for groups

### [Remove-MgBetaSiteOnenoteNotebook](Remove-MgBetaSiteOnenoteNotebook.md)
Delete navigation property notebooks for sites

### [Remove-MgBetaSiteOnenotePage](Remove-MgBetaSiteOnenotePage.md)
Delete a OneNote page.

### [Remove-MgBetaSiteOnenoteSection](Remove-MgBetaSiteOnenoteSection.md)
Delete navigation property sections for sites

### [Remove-MgBetaSiteOnenoteSectionGroup](Remove-MgBetaSiteOnenoteSectionGroup.md)
Delete navigation property sectionGroups for sites

### [Remove-MgBetaUserOnenoteNotebook](Remove-MgBetaUserOnenoteNotebook.md)
Delete navigation property notebooks for users

### [Remove-MgBetaUserOnenotePage](Remove-MgBetaUserOnenotePage.md)
Delete a OneNote page.

### [Remove-MgBetaUserOnenoteSection](Remove-MgBetaUserOnenoteSection.md)
Delete navigation property sections for users

### [Remove-MgBetaUserOnenoteSectionGroup](Remove-MgBetaUserOnenoteSectionGroup.md)
Delete navigation property sectionGroups for users

### [Set-MgBetaGroupOnenotePageContent](Set-MgBetaGroupOnenotePageContent.md)
The page's HTML content.

### [Set-MgBetaGroupOnenoteResourceContent](Set-MgBetaGroupOnenoteResourceContent.md)
Update content for the navigation property resources in groups

### [Set-MgBetaGroupOnenoteSectionPageContent](Set-MgBetaGroupOnenoteSectionPageContent.md)
The page's HTML content.

### [Set-MgBetaSiteOnenotePageContent](Set-MgBetaSiteOnenotePageContent.md)
The page's HTML content.

### [Set-MgBetaSiteOnenoteResourceContent](Set-MgBetaSiteOnenoteResourceContent.md)
Update content for the navigation property resources in sites

### [Set-MgBetaSiteOnenoteSectionPageContent](Set-MgBetaSiteOnenoteSectionPageContent.md)
The page's HTML content.

### [Set-MgBetaUserOnenotePageContent](Set-MgBetaUserOnenotePageContent.md)
The page's HTML content.

### [Set-MgBetaUserOnenoteResourceContent](Set-MgBetaUserOnenoteResourceContent.md)
Update content for the navigation property resources in users

### [Set-MgBetaUserOnenoteSectionPageContent](Set-MgBetaUserOnenoteSectionPageContent.md)
The page's HTML content.

### [Update-MgBetaGroupOnenoteNotebook](Update-MgBetaGroupOnenoteNotebook.md)
Update the navigation property notebooks in groups

### [Update-MgBetaGroupOnenotePage](Update-MgBetaGroupOnenotePage.md)
Update the navigation property pages in groups

### [Update-MgBetaGroupOnenoteSection](Update-MgBetaGroupOnenoteSection.md)
Update the navigation property sections in groups

### [Update-MgBetaGroupOnenoteSectionGroup](Update-MgBetaGroupOnenoteSectionGroup.md)
Update the navigation property sectionGroups in groups

### [Update-MgBetaSiteOnenoteNotebook](Update-MgBetaSiteOnenoteNotebook.md)
Update the navigation property notebooks in sites

### [Update-MgBetaSiteOnenotePage](Update-MgBetaSiteOnenotePage.md)
Update the navigation property pages in sites

### [Update-MgBetaSiteOnenoteSection](Update-MgBetaSiteOnenoteSection.md)
Update the navigation property sections in sites

### [Update-MgBetaSiteOnenoteSectionGroup](Update-MgBetaSiteOnenoteSectionGroup.md)
Update the navigation property sectionGroups in sites

### [Update-MgBetaUserOnenoteNotebook](Update-MgBetaUserOnenoteNotebook.md)
Update the navigation property notebooks in users

### [Update-MgBetaUserOnenotePage](Update-MgBetaUserOnenotePage.md)
Update the navigation property pages in users

### [Update-MgBetaUserOnenoteSection](Update-MgBetaUserOnenoteSection.md)
Update the navigation property sections in users

### [Update-MgBetaUserOnenoteSectionGroup](Update-MgBetaUserOnenoteSectionGroup.md)
Update the navigation property sectionGroups in users

