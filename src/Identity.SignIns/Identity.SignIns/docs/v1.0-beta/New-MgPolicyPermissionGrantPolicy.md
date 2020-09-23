---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgpolicypermissiongrantpolicy
schema: 2.0.0
---

# New-MgPolicyPermissionGrantPolicy

## SYNOPSIS
Create new navigation property to permissionGrantPolicies for policies

## SYNTAX

### CreateExpanded (Default)
```
New-MgPolicyPermissionGrantPolicy [-AdditionalProperties <Hashtable>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]
 [-Id <String>] [-Includes <IMicrosoftGraphPermissionGrantConditionSet[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgPolicyPermissionGrantPolicy -BodyParameter <IMicrosoftGraphPermissionGrantPolicy> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to permissionGrantPolicies for policies

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

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
Represents an Azure Active Directory object.
The directoryObject type is the base type for many other directory entity types.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
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

### -Description
Description for this policy.

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
To construct, see NOTES section for EXCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
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

### -Includes
.
To construct, see NOTES section for INCLUDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantConditionSet[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPermissionGrantPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphPermissionGrantPolicy>: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy.
  - `[DisplayName <String>]`: Display name for this policy.
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[Excludes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[ClientApplicationIds <String[]>]`: 
    - `[ClientApplicationPublisherIds <String[]>]`: 
    - `[ClientApplicationTenantIds <String[]>]`: 
    - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
    - `[PermissionClassification <String>]`: 
    - `[PermissionType <String>]`: permissionType
    - `[Permissions <String[]>]`: 
    - `[ResourceApplication <String>]`: 
  - `[Includes <IMicrosoftGraphPermissionGrantConditionSet[]>]`: 

EXCLUDES <IMicrosoftGraphPermissionGrantConditionSet[]>: .
  - `[Id <String>]`: Read-only.
  - `[ClientApplicationIds <String[]>]`: 
  - `[ClientApplicationPublisherIds <String[]>]`: 
  - `[ClientApplicationTenantIds <String[]>]`: 
  - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
  - `[PermissionClassification <String>]`: 
  - `[PermissionType <String>]`: permissionType
  - `[Permissions <String[]>]`: 
  - `[ResourceApplication <String>]`: 

INCLUDES <IMicrosoftGraphPermissionGrantConditionSet[]>: .
  - `[Id <String>]`: Read-only.
  - `[ClientApplicationIds <String[]>]`: 
  - `[ClientApplicationPublisherIds <String[]>]`: 
  - `[ClientApplicationTenantIds <String[]>]`: 
  - `[ClientApplicationsFromVerifiedPublisherOnly <Boolean?>]`: 
  - `[PermissionClassification <String>]`: 
  - `[PermissionType <String>]`: permissionType
  - `[Permissions <String[]>]`: 
  - `[ResourceApplication <String>]`: 

## RELATED LINKS

