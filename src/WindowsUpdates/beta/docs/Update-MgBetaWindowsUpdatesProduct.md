---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.windowsupdates/update-mgbetawindowsupdatesproduct
schema: 2.0.0
---

# Update-MgBetaWindowsUpdatesProduct

## SYNOPSIS
Update the navigation property products in admin

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaWindowsUpdatesProduct -ProductId <String> [-AdditionalProperties <Hashtable>]
 [-Editions <IMicrosoftGraphWindowsUpdatesEdition[]>] [-FriendlyNames <String[]>] [-GroupName <String>]
 [-Id <String>] [-KnownIssues <IMicrosoftGraphWindowsUpdatesKnownIssue[]>] [-Name <String>]
 [-ResponseHeadersVariable <String>] [-Revisions <IMicrosoftGraphWindowsUpdatesProductRevision[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaWindowsUpdatesProduct -ProductId <String> -BodyParameter <IMicrosoftGraphWindowsUpdatesProduct>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaWindowsUpdatesProduct -InputObject <IWindowsUpdatesIdentity>
 -BodyParameter <IMicrosoftGraphWindowsUpdatesProduct> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaWindowsUpdatesProduct -InputObject <IWindowsUpdatesIdentity> [-AdditionalProperties <Hashtable>]
 [-Editions <IMicrosoftGraphWindowsUpdatesEdition[]>] [-FriendlyNames <String[]>] [-GroupName <String>]
 [-Id <String>] [-KnownIssues <IMicrosoftGraphWindowsUpdatesKnownIssue[]>] [-Name <String>]
 [-ResponseHeadersVariable <String>] [-Revisions <IMicrosoftGraphWindowsUpdatesProductRevision[]>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property products in admin

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
product
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesProduct
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Editions
Represents an edition of a particular Windows product.
To construct, see NOTES section for EDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesEdition[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FriendlyNames
The friendly names of the product.
For example, Version 22H2 (OS build 22621).
Read-only.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupName
The name of the product group.
For example, Windows 11.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -KnownIssues
Represents a known issue related to a Windows product.
To construct, see NOTES section for KNOWNISSUES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesKnownIssue[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name of the product.
For example, Windows 11, version 22H2.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProductId
The unique identifier of product

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Revisions
Represents a product revision.
To construct, see NOTES section for REVISIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesProductRevision[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesProduct

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesProduct

## NOTES

ALIASES

Update-MgBetaWuProduct

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphWindowsUpdatesProduct>`: product
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Editions <IMicrosoftGraphWindowsUpdatesEdition[]>]`: Represents an edition of a particular Windows product.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeviceFamily <String>]`: The device family targeted by the edition.
    - `[EndOfServiceDateTime <DateTime?>]`: The date and time when the edition reached the end of service. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[GeneralAvailabilityDateTime <DateTime?>]`: The date and time when the edition became available to the general customers for the first time. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[IsInService <Boolean?>]`: Indicates whether the edition is in service or out of service.
    - `[Name <String>]`: The name of the edition. Read-only.
    - `[ReleasedName <String>]`: The public name of the edition. Read-only.
    - `[ServicingPeriods <IMicrosoftGraphWindowsUpdatesServicingPeriod[]>]`: 
      - `[EndDateTime <DateTime?>]`: The date and time when the servicing period ends. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[Name <String>]`: The name of the servicing period. For example, Modern Lifecycle.
      - `[StartDateTime <DateTime?>]`: The start date and time of the servicing period. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[FriendlyNames <String[]>]`: The friendly names of the product. For example, Version 22H2 (OS build 22621). Read-only.
  - `[GroupName <String>]`: The name of the product group. For example, Windows 11. Read-only.
  - `[KnownIssues <IMicrosoftGraphWindowsUpdatesKnownIssue[]>]`: Represents a known issue related to a Windows product.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Description <String>]`: The description of the particular known issue.
    - `[KnownIssueHistories <IMicrosoftGraphWindowsUpdatesKnownIssueHistoryItem[]>]`: 
      - `[Body <IMicrosoftGraphWindowsUpdatesItemBody>]`: itemBody
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Content <String>]`: The content of the item.
        - `[ContentType <String>]`: bodyType
      - `[CreatedDateTime <DateTime?>]`: The date and time when the post was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[LastUpdatedDateTime <DateTime?>]`: The date and time when the known issue was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[OriginatingKnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Url <String>]`: The URL of the knowledge base article. Read-only.
    - `[ResolvedDateTime <DateTime?>]`: The date and time when the known issue was resolved or mitigated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ResolvingKnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
    - `[SafeguardHoldIds <Int32[]>]`: 
    - `[StartDateTime <DateTime?>]`: The date and time when the known issue was first reported. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Status <String>]`: windowsReleaseHealthStatus
    - `[Title <String>]`: The title of the known issue.
    - `[WebViewUrl <String>]`: The URL to the known issue in the Windows Release Health dashboard on Microsoft 365 admin center.
  - `[Name <String>]`: The name of the product. For example, Windows 11, version 22H2. Read-only.
  - `[Revisions <IMicrosoftGraphWindowsUpdatesProductRevision[]>]`: Represents a product revision.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[DisplayName <String>]`: The display name of the content. Read-only.
      - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DisplayName <String>]`: The display name of the content. Read-only.
    - `[KnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
    - `[OSBuild <IMicrosoftGraphWindowsUpdatesBuildVersionDetails>]`: buildVersionDetails
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BuildNumber <Int32?>]`: The build number of the product release. Read-only.
      - `[MajorVersion <Int32?>]`: The major version of the product release. Read-only.
      - `[MinorVersion <Int32?>]`: The minor version of the product release. Read-only.
      - `[UpdateBuildRevision <Int32?>]`: The update build revision number of the product revision. Read-only.
    - `[Product <String>]`: The product of the revision. Possible values are: Windows 10, Windows 11. Read-only.
    - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Version <String>]`: The version of the feature update. Read-only.

`EDITIONS <IMicrosoftGraphWindowsUpdatesEdition[]>`: Represents an edition of a particular Windows product.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[DeviceFamily <String>]`: The device family targeted by the edition.
  - `[EndOfServiceDateTime <DateTime?>]`: The date and time when the edition reached the end of service. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[GeneralAvailabilityDateTime <DateTime?>]`: The date and time when the edition became available to the general customers for the first time. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[IsInService <Boolean?>]`: Indicates whether the edition is in service or out of service.
  - `[Name <String>]`: The name of the edition. Read-only.
  - `[ReleasedName <String>]`: The public name of the edition. Read-only.
  - `[ServicingPeriods <IMicrosoftGraphWindowsUpdatesServicingPeriod[]>]`: 
    - `[EndDateTime <DateTime?>]`: The date and time when the servicing period ends. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[Name <String>]`: The name of the servicing period. For example, Modern Lifecycle.
    - `[StartDateTime <DateTime?>]`: The start date and time of the servicing period. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.

`INPUTOBJECT <IWindowsUpdatesIdentity>`: Identity Parameter
  - `[ApplicableContentCatalogEntryId <String>]`: The unique identifier of applicableContent
  - `[ApplicableContentDeviceMatchDeviceId <String>]`: The unique identifier of applicableContentDeviceMatch
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[CatalogId <String>]`: Usage: catalogID='{catalogID}'
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DaysInPast <Int32?>]`: Usage: daysInPast={daysInPast}
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[EditionId <String>]`: The unique identifier of edition
  - `[KbNumber <Int32?>]`: Usage: kbNumber={kbNumber}
  - `[KnownIssueId <String>]`: The unique identifier of knownIssue
  - `[ProductId <String>]`: The unique identifier of product
  - `[ProductRevisionId <String>]`: The unique identifier of productRevision
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

`KNOWNISSUES <IMicrosoftGraphWindowsUpdatesKnownIssue[]>`: Represents a known issue related to a Windows product.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Description <String>]`: The description of the particular known issue.
  - `[KnownIssueHistories <IMicrosoftGraphWindowsUpdatesKnownIssueHistoryItem[]>]`: 
    - `[Body <IMicrosoftGraphWindowsUpdatesItemBody>]`: itemBody
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of the item.
      - `[ContentType <String>]`: bodyType
    - `[CreatedDateTime <DateTime?>]`: The date and time when the post was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[LastUpdatedDateTime <DateTime?>]`: The date and time when the known issue was last updated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[OriginatingKnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Url <String>]`: The URL of the knowledge base article. Read-only.
  - `[ResolvedDateTime <DateTime?>]`: The date and time when the known issue was resolved or mitigated. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ResolvingKnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
  - `[SafeguardHoldIds <Int32[]>]`: 
  - `[StartDateTime <DateTime?>]`: The date and time when the known issue was first reported. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Status <String>]`: windowsReleaseHealthStatus
  - `[Title <String>]`: The title of the known issue.
  - `[WebViewUrl <String>]`: The URL to the known issue in the Windows Release Health dashboard on Microsoft 365 admin center.

`REVISIONS <IMicrosoftGraphWindowsUpdatesProductRevision[]>`: Represents a product revision.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[CatalogEntry <IMicrosoftGraphWindowsUpdatesCatalogEntry>]`: catalogEntry
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[DeployableUntilDateTime <DateTime?>]`: The date on which the content is no longer available to deploy using the service. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[DisplayName <String>]`: The display name of the content. Read-only.
    - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[DisplayName <String>]`: The display name of the content. Read-only.
  - `[KnowledgeBaseArticle <IMicrosoftGraphWindowsUpdatesKnowledgeBaseArticle>]`: knowledgeBaseArticle
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Url <String>]`: The URL of the knowledge base article. Read-only.
  - `[OSBuild <IMicrosoftGraphWindowsUpdatesBuildVersionDetails>]`: buildVersionDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BuildNumber <Int32?>]`: The build number of the product release. Read-only.
    - `[MajorVersion <Int32?>]`: The major version of the product release. Read-only.
    - `[MinorVersion <Int32?>]`: The minor version of the product release. Read-only.
    - `[UpdateBuildRevision <Int32?>]`: The update build revision number of the product revision. Read-only.
  - `[Product <String>]`: The product of the revision. Possible values are: Windows 10, Windows 11. Read-only.
  - `[ReleaseDateTime <DateTime?>]`: The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
  - `[Version <String>]`: The version of the feature update. Read-only.

## RELATED LINKS

