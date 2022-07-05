---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicyserviceprincipalcreationpolicy
schema: 2.0.0
---

# New-MgPolicyServicePrincipalCreationPolicy

## SYNOPSIS
Create new navigation property to servicePrincipalCreationPolicies for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyServicePrincipalCreationPolicy [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>]
 [-Excludes <IMicrosoftGraphServicePrincipalCreationConditionSet[]>] [-Id <String>]
 [-Includes <IMicrosoftGraphServicePrincipalCreationConditionSet[]>] [-IsBuiltIn] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgPolicyServicePrincipalCreationPolicy -BodyParameter <IMicrosoftGraphServicePrincipalCreationPolicy>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to servicePrincipalCreationPolicies for policies

## EXAMPLES

## PARAMETERS

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

### -BodyParameter
servicePrincipalCreationPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalCreationPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

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

### -Description
Description for this policy.
Required.

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

### -DisplayName
Display name for this policy.
Required.

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

### -Excludes
.
To construct, please use Get-Help -Online and see NOTES section for EXCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalCreationConditionSet[]
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

### -Includes
.
To construct, please use Get-Help -Online and see NOTES section for INCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalCreationConditionSet[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsBuiltIn
.

```yaml
Type: System.Management.Automation.SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalCreationPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphServicePrincipalCreationPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphServicePrincipalCreationPolicy>: servicePrincipalCreationPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: 
  - `[Excludes <IMicrosoftGraphServicePrincipalCreationConditionSet[]>]`: 
    - `[Id <String>]`: 
    - `[ApplicationIds <String[]>]`: 
    - `[ApplicationPublisherIds <String[]>]`: 
    - `[ApplicationTenantIds <String[]>]`: 
    - `[ApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
    - `[CertifiedApplicationsOnly <Boolean?>]`: 
  - `[Includes <IMicrosoftGraphServicePrincipalCreationConditionSet[]>]`: 
  - `[IsBuiltIn <Boolean?>]`: 

EXCLUDES <IMicrosoftGraphServicePrincipalCreationConditionSet[]>: .
  - `[Id <String>]`: 
  - `[ApplicationIds <String[]>]`: 
  - `[ApplicationPublisherIds <String[]>]`: 
  - `[ApplicationTenantIds <String[]>]`: 
  - `[ApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
  - `[CertifiedApplicationsOnly <Boolean?>]`: 

INCLUDES <IMicrosoftGraphServicePrincipalCreationConditionSet[]>: .
  - `[Id <String>]`: 
  - `[ApplicationIds <String[]>]`: 
  - `[ApplicationPublisherIds <String[]>]`: 
  - `[ApplicationTenantIds <String[]>]`: 
  - `[ApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
  - `[CertifiedApplicationsOnly <Boolean?>]`: 

## RELATED LINKS

