---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/new-mgbetadirectoryrecommendation
schema: 2.0.0
---

# New-MgBetaDirectoryRecommendation

## SYNOPSIS
Create new navigation property to recommendations for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDirectoryRecommendation [-ActionSteps <IMicrosoftGraphActionStep[]>]
 [-AdditionalProperties <Hashtable>] [-Benefits <String>] [-Category <String>] [-CreatedDateTime <DateTime>]
 [-CurrentScore <Double>] [-DisplayName <String>] [-FeatureAreas <String[]>] [-Id <String>]
 [-ImpactedResources <IMicrosoftGraphImpactedResource[]>] [-ImpactStartDateTime <DateTime>]
 [-ImpactType <String>] [-Insights <String>] [-LastCheckedDateTime <DateTime>] [-LastModifiedBy <String>]
 [-LastModifiedDateTime <DateTime>] [-MaxScore <Double>] [-PostponeUntilDateTime <DateTime>]
 [-Priority <String>] [-RecommendationType <String>] [-ReleaseType <String>] [-RemediationImpact <String>]
 [-ResponseHeadersVariable <String>] [-Status <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDirectoryRecommendation -BodyParameter <Hashtable> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to recommendations for directory

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -ActionSteps
List of actions to take to complete a recommendation.
To construct, see NOTES section for ACTIONSTEPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphActionStep[]
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
An explanation of why completing the recommendation will benefit you.
Corresponds to the Value section of a recommendation shown in the Microsoft Entra admin center.

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

```yaml
Type: System.Collections.Hashtable
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
The date and time when the recommendation was detected as applicable to your directory.

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

### -CurrentScore
The number of points the tenant has attained.
Only applies to recommendations with category set to identitySecureScore.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The title of the recommendation.

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

### -FeatureAreas
The directory feature that the recommendation is related to.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactedResources
The list of directory objects associated with the recommendation.
To construct, see NOTES section for IMPACTEDRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphImpactedResource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ImpactStartDateTime
The future date and time when a recommendation should be completed.

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
Indicates the scope of impact of a recommendation.
Tenant level indicates that the recommendation impacts the whole tenant.
Other possible values include users, applications.

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
Describes why a recommendation uniquely applies to your directory.
Corresponds to the Description section of a recommendation shown in the Microsoft Entra admin center.

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
The most recent date and time a recommendation was deemed applicable to your directory.

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
Name of the user who last updated the status of the recommendation.

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
The date and time the status of a recommendation was last updated.

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

### -MaxScore
The maximum number of points attainable.
Only applies to recommendations with category set to identitySecureScore.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PostponeUntilDateTime
The future date and time when the status of a postponed recommendation will be active again.

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

### -RecommendationType
recommendationType

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

### -ReleaseType
The current release type of the recommendation.
The possible values are: preview, generallyAvailable, unknownFutureValue.

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

### -RemediationImpact
Description of the impact on users of the remediation.
Only applies to recommendations with category set to identitySecureScore.

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

### System.Collections.Hashtable

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRecommendation

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ACTIONSTEPS <IMicrosoftGraphActionStep[]>`: List of actions to take to complete a recommendation.
  - `[ActionUrl <IMicrosoftGraphActionUrl>]`: actionUrl
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: Brief title for the page that the links directs to.
    - `[Url <String>]`: The URL to the documentation or Microsoft Entra admin center page.
  - `[StepNumber <Int64?>]`: Indicates the position for this action in the order of the collection of actions to be taken.
  - `[Text <String>]`: Friendly description of the action to take.

`IMPACTEDRESOURCES <IMicrosoftGraphImpactedResource[]>`: The list of directory objects associated with the recommendation.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AddedDateTime <DateTime?>]`: The date and time when the impactedResource object was initially associated with the recommendation.
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Additional information unique to the impactedResource to help contextualize the recommendation.
    - `[Key <String>]`: Key.
    - `[Value <String>]`: Value.
  - `[ApiUrl <String>]`: The URL link to the corresponding Microsoft Entra resource.
  - `[DisplayName <String>]`: Friendly name of the Microsoft Entra resource.
  - `[LastModifiedBy <String>]`: Name of the user or service that last updated the status.
  - `[LastModifiedDateTime <String>]`: The date and time when the status was last updated.
  - `[Owner <String>]`: The user responsible for maintaining the resource.
  - `[PortalUrl <String>]`: The URL link to the corresponding Microsoft Entra admin center page of the resource.
  - `[PostponeUntilDateTime <DateTime?>]`: The future date and time when the status of a postponed impactedResource will be active again.
  - `[Rank <Int32?>]`: Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.
  - `[RecommendationId <String>]`: The unique identifier of the recommendation that the resource is associated with.
  - `[ResourceType <String>]`: Indicates the type of Microsoft Entra resource. Examples include user, application.
  - `[Status <String>]`: recommendationStatus
  - `[SubjectId <String>]`: The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.

## RELATED LINKS

