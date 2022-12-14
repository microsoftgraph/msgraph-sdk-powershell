---
Module Name: Microsoft.Graph.People
Module Guid: 135e4116-e582-4179-9648-aa94bbf819a6
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.people
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.People Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.People Cmdlets
### [Get-MgUserLastSharedMethodInsight](Get-MgUserLastSharedMethodInsight.md)
Get lastSharedMethod from users

### [Get-MgUserPerson](Get-MgUserPerson.md)
People that are relevant to the user.
Read-only.
Nullable.

### [Get-MgUserSharedInsight](Get-MgUserSharedInsight.md)
Calculated relationship identifying documents shared with or by the user.
This includes URLs, file attachments, and reference attachments to OneDrive for Business and SharePoint files found in Outlook messages and meetings.
This also includes URLs and reference attachments to Teams conversations.
Ordered by recency of share.

### [Get-MgUserSharedResourceInsight](Get-MgUserSharedResourceInsight.md)
Used for navigating to the item that was shared.
For file attachments, the type is fileAttachment.
For linked attachments, the type is driveItem.

### [Get-MgUserTrendingInsight](Get-MgUserTrendingInsight.md)
Calculated relationship identifying documents trending around a user.
Trending documents are calculated based on activity of the user's closest network of people and include files stored in OneDrive for Business and SharePoint.
Trending insights help the user to discover potentially useful content that the user has access to, but has never viewed before.

### [Get-MgUserTrendingResourceInsight](Get-MgUserTrendingResourceInsight.md)
Used for navigating to the trending document.

### [Get-MgUserUsedInsight](Get-MgUserUsedInsight.md)
Calculated relationship identifying the latest documents viewed or modified by a user, including OneDrive for Business and SharePoint documents, ranked by recency of use.

### [Get-MgUserUsedResourceInsight](Get-MgUserUsedResourceInsight.md)
Used for navigating to the item that was used.
For file attachments, the type is fileAttachment.
For linked attachments, the type is driveItem.

