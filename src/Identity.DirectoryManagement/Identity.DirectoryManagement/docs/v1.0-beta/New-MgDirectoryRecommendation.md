---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryrecommendation
schema: 2.0.0
---

# New-MgDirectoryRecommendation

## SYNOPSIS
Create new navigation property to recommendations for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectoryRecommendation [-ActionSteps <IMicrosoftGraphActionStep[]>] [-AdditionalProperties <Hashtable>]
 [-Benefits <String>] [-Category <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>]
 [-Id <String>] [-ImpactedResources <IMicrosoftGraphRecommendationResource[]>]
 [-ImpactStartDateTime <DateTime>] [-ImpactType <String>] [-Insights <String>]
 [-LastCheckedDateTime <DateTime>] [-LastModifiedBy <String>] [-LastModifiedDateTime <DateTime>]
 [-PostponeUntilDateTime <DateTime>] [-Priority <String>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDirectoryRecommendation -BodyParameter <IMicrosoftGraphRecommendation> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to recommendations for directory

## EXAMPLES

## PARAMETERS

### -ActionSteps
.
To construct, please use Get-Help -Online and see NOTES section for ACTIONSTEPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphActionStep[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Benefits
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
recommendation
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendation
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
recommendationCategory

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactedResources
.
To construct, please use Get-Help -Online and see NOTES section for IMPACTEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendationResource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactStartDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Insights
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastCheckedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedBy
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostponeUntilDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Priority
recommendationPriority

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
recommendationStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendation

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACTIONSTEPS <IMicrosoftGraphActionStep[]>: .
  - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: 
    - `[Url <String>]`: 
  - `[StepNumber <Int64?>]`: 
  - `[Text <String>]`: 

BODYPARAMETER <IMicrosoftGraphRecommendation>: recommendation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[ActionSteps <IMicrosoftGraphActionStep[]>]`: 
    - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: 
      - `[Url <String>]`: 
    - `[StepNumber <Int64?>]`: 
    - `[Text <String>]`: 
  - `[Benefits <String>]`: 
  - `[Category <String>]`: recommendationCategory
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[ImpactStartDateTime <DateTime?>]`: 
  - `[ImpactType <String>]`: 
  - `[ImpactedResources <IMicrosoftGraphRecommendationResource[]>]`: 
    - `[Id <String>]`: 
    - `[AddedDateTime <DateTime?>]`: 
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: 
      - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
      - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
    - `[ApiUrl <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Owner <String>]`: 
    - `[PortalUrl <String>]`: 
    - `[Rank <Int32?>]`: 
    - `[RecommendationId <String>]`: 
    - `[ResourceType <String>]`: 
    - `[Status <String>]`: recommendationStatus
  - `[Insights <String>]`: 
  - `[LastCheckedDateTime <DateTime?>]`: 
  - `[LastModifiedBy <String>]`: 
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[PostponeUntilDateTime <DateTime?>]`: 
  - `[Priority <String>]`: recommendationPriority
  - `[Status <String>]`: recommendationStatus

IMPACTEDRESOURCES <IMicrosoftGraphRecommendationResource[]>: .
  - `[Id <String>]`: 
  - `[AddedDateTime <DateTime?>]`: 
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
    - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.
  - `[ApiUrl <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Owner <String>]`: 
  - `[PortalUrl <String>]`: 
  - `[Rank <Int32?>]`: 
  - `[RecommendationId <String>]`: 
  - `[ResourceType <String>]`: 
  - `[Status <String>]`: recommendationStatus

## RELATED LINKS

