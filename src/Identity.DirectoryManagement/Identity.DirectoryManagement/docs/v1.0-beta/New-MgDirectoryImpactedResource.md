---
external help file:
Module Name: Microsoft.Graph.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.directorymanagement/new-mgdirectoryimpactedresource
schema: 2.0.0
---

# New-MgDirectoryImpactedResource

## SYNOPSIS
Create new navigation property to impactedResources for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgDirectoryImpactedResource [-AddedDateTime <DateTime>] [-AdditionalDetails <IMicrosoftGraphKeyValue[]>]
 [-AdditionalProperties <Hashtable>] [-ApiUrl <String>] [-DisplayName <String>] [-Id <String>]
 [-Owner <String>] [-PortalUrl <String>] [-Rank <Int32>] [-RecommendationId <String>] [-ResourceType <String>]
 [-Status <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDirectoryImpactedResource -BodyParameter <IMicrosoftGraphRecommendationResource> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to impactedResources for directory

## EXAMPLES

## PARAMETERS

### -AddedDateTime
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

### -AdditionalDetails
.
To construct, please use Get-Help -Online and see NOTES section for ADDITIONALDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValue[]
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

### -ApiUrl
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
recommendationResource
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendationResource
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Owner
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

### -PortalUrl
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

### -Rank
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecommendationId
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

### -ResourceType
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendationResource

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRecommendationResource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ADDITIONALDETAILS <IMicrosoftGraphKeyValue[]>: .
  - `[Key <String>]`: Contains the name of the field that a value is associated with. When a sign in or domain hint is included in the sign-in request, corresponding fields are included as key-value pairs. Possible keys: Login hint present, Domain hint present.
  - `[Value <String>]`: Contains the corresponding value for the specified key. The value is true if a sign in hint was included in the sign-in request; otherwise false. The value is true if a domain hint was included in the sign-in request; otherwise false.

BODYPARAMETER <IMicrosoftGraphRecommendationResource>: recommendationResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
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

