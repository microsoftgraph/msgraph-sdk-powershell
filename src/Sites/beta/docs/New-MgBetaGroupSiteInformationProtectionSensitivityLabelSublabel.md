---
external help file:
Module Name: Microsoft.Graph.Beta.Sites
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.sites/new-mgbetagroupsiteinformationprotectionsensitivitylabelsublabel
schema: 2.0.0
---

# New-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel

## SYNOPSIS
Create new navigation property to sublabels for groups

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel -GroupId <String>
 -SensitivityLabelId <String> -SiteId <String> [-AdditionalProperties <Hashtable>] [-ApplicableTo <String>]
 [-ApplicationMode <String>] [-AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]
 [-AutoLabeling <IMicrosoftGraphAutoLabeling>] [-Description <String>] [-DisplayName <String>] [-Id <String>]
 [-IsDefault] [-IsEndpointProtectionEnabled] [-LabelActions <IMicrosoftGraphLabelActionBase[]>]
 [-Name <String>] [-Priority <Int32>] [-ResponseHeadersVariable <String>]
 [-Sublabels <IMicrosoftGraphSensitivityLabel[]>] [-ToolTip <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel -GroupId <String>
 -SensitivityLabelId <String> -SiteId <String> -BodyParameter <IMicrosoftGraphSensitivityLabel>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel -InputObject <ISitesIdentity>
 -BodyParameter <IMicrosoftGraphSensitivityLabel> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaGroupSiteInformationProtectionSensitivityLabelSublabel -InputObject <ISitesIdentity>
 [-AdditionalProperties <Hashtable>] [-ApplicableTo <String>] [-ApplicationMode <String>]
 [-AssignedPolicies <IMicrosoftGraphLabelPolicy[]>] [-AutoLabeling <IMicrosoftGraphAutoLabeling>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsDefault] [-IsEndpointProtectionEnabled]
 [-LabelActions <IMicrosoftGraphLabelActionBase[]>] [-Name <String>] [-Priority <Int32>]
 [-ResponseHeadersVariable <String>] [-Sublabels <IMicrosoftGraphSensitivityLabel[]>] [-ToolTip <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sublabels for groups

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicableTo
sensitivityLabelTarget

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationMode
applicationMode

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AssignedPolicies
.
To construct, see NOTES section for ASSIGNEDPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLabelPolicy[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AutoLabeling
autoLabeling
To construct, see NOTES section for AUTOLABELING properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAutoLabeling
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sensitivityLabel
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupId
The unique identifier of group

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsDefault
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEndpointProtectionEnabled
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LabelActions
.
To construct, see NOTES section for LABELACTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphLabelActionBase[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
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

### -SensitivityLabelId
The unique identifier of sensitivityLabel

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SiteId
The unique identifier of site

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sublabels
.
To construct, see NOTES section for SUBLABELS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ToolTip
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel

### Microsoft.Graph.Beta.PowerShell.Models.ISitesIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSensitivityLabel

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ASSIGNEDPOLICIES <IMicrosoftGraphLabelPolicy[]>`: .
  - `[Id <String>]`: 
  - `[Name <String>]`: 

`AUTOLABELING <IMicrosoftGraphAutoLabeling>`: autoLabeling
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Message <String>]`: 
  - `[SensitiveTypeIds <String[]>]`: 

`BODYPARAMETER <IMicrosoftGraphSensitivityLabel>`: sensitivityLabel
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[ApplicationMode <String>]`: applicationMode
  - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
  - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Message <String>]`: 
    - `[SensitiveTypeIds <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsEndpointProtectionEnabled <Boolean?>]`: 
  - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
    - `[Name <String>]`: 
  - `[Name <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
  - `[ToolTip <String>]`: 

`INPUTOBJECT <ISitesIdentity>`: Identity Parameter
  - `[BaseItemId <String>]`: The unique identifier of baseItem
  - `[BaseSitePageId <String>]`: The unique identifier of baseSitePage
  - `[BitlockerRecoveryKeyId <String>]`: The unique identifier of bitlockerRecoveryKey
  - `[ColumnDefinitionId <String>]`: The unique identifier of columnDefinition
  - `[ColumnLinkId <String>]`: The unique identifier of columnLink
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[ContentTypeId1 <String>]`: The unique identifier of contentType
  - `[DataLossPreventionPolicyId <String>]`: The unique identifier of dataLossPreventionPolicy
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[EndDateTime <String>]`: Usage: endDateTime='{endDateTime}'
  - `[GroupId <String>]`: The unique identifier of group
  - `[GroupId1 <String>]`: The unique identifier of group
  - `[HorizontalSectionColumnId <String>]`: The unique identifier of horizontalSectionColumn
  - `[HorizontalSectionId <String>]`: The unique identifier of horizontalSection
  - `[IncludePersonalNotebooks <Boolean?>]`: Usage: includePersonalNotebooks={includePersonalNotebooks}
  - `[InformationProtectionLabelId <String>]`: The unique identifier of informationProtectionLabel
  - `[Interval <String>]`: Usage: interval='{interval}'
  - `[ItemActivityId <String>]`: The unique identifier of itemActivity
  - `[ItemActivityOldId <String>]`: The unique identifier of itemActivityOLD
  - `[ItemActivityStatId <String>]`: The unique identifier of itemActivityStat
  - `[ListId <String>]`: The unique identifier of list
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenoteOperationId <String>]`: The unique identifier of onenoteOperation
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteResourceId <String>]`: The unique identifier of onenoteResource
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[Path <String>]`: Usage: path='{path}'
  - `[Path1 <String>]`: Usage: path='{path1}'
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[RecycleBinItemId <String>]`: The unique identifier of recycleBinItem
  - `[RelationId <String>]`: The unique identifier of relation
  - `[RichLongRunningOperationId <String>]`: The unique identifier of richLongRunningOperation
  - `[SectionGroupId <String>]`: The unique identifier of sectionGroup
  - `[SectionGroupId1 <String>]`: The unique identifier of sectionGroup
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SensitivityLabelId1 <String>]`: The unique identifier of sensitivityLabel
  - `[SetId <String>]`: The unique identifier of set
  - `[SetId1 <String>]`: The unique identifier of set
  - `[SiteId <String>]`: The unique identifier of site
  - `[SiteId1 <String>]`: The unique identifier of site
  - `[StartDateTime <String>]`: Usage: startDateTime='{startDateTime}'
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TermId <String>]`: The unique identifier of term
  - `[TermId1 <String>]`: The unique identifier of term
  - `[ThreatAssessmentRequestId <String>]`: The unique identifier of threatAssessmentRequest
  - `[ThreatAssessmentResultId <String>]`: The unique identifier of threatAssessmentResult
  - `[Token <String>]`: Usage: token='{token}'
  - `[UserId <String>]`: The unique identifier of user
  - `[WebPartId <String>]`: The unique identifier of webPart

`LABELACTIONS <IMicrosoftGraphLabelActionBase[]>`: .
  - `[Name <String>]`: 

`SUBLABELS <IMicrosoftGraphSensitivityLabel[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ApplicableTo <String>]`: sensitivityLabelTarget
  - `[ApplicationMode <String>]`: applicationMode
  - `[AssignedPolicies <IMicrosoftGraphLabelPolicy[]>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
  - `[AutoLabeling <IMicrosoftGraphAutoLabeling>]`: autoLabeling
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Message <String>]`: 
    - `[SensitiveTypeIds <String[]>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsEndpointProtectionEnabled <Boolean?>]`: 
  - `[LabelActions <IMicrosoftGraphLabelActionBase[]>]`: 
    - `[Name <String>]`: 
  - `[Name <String>]`: 
  - `[Priority <Int32?>]`: 
  - `[Sublabels <IMicrosoftGraphSensitivityLabel[]>]`: 
  - `[ToolTip <String>]`: 

## RELATED LINKS

