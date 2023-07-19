---
external help file:
Module Name: Microsoft.Graph.Identity.Governance
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.identity.governance/new-mgentitlementmanagementresource
schema: 2.0.0
---

# New-MgEntitlementManagementResource

## SYNOPSIS
Create new navigation property to resources for identityGovernance

## SYNTAX

### CreateExpanded (Default)
```
New-MgEntitlementManagementResource [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>]
 [-Environment <IMicrosoftGraphAccessPackageResourceEnvironment>] [-Id <String>]
 [-ModifiedDateTime <DateTime>] [-OriginId <String>] [-OriginSystem <String>]
 [-Roles <IMicrosoftGraphAccessPackageResourceRole[]>] [-Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgEntitlementManagementResource -BodyParameter <IMicrosoftGraphAccessPackageResource> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to resources for identityGovernance

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
accessPackageResource
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Description
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

### -Environment
accessPackageResourceEnvironment
To construct, see NOTES section for ENVIRONMENT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceEnvironment
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
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

### -ModifiedDateTime
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

### -OriginId
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

### -OriginSystem
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

### -Roles
.
To construct, see NOTES section for ROLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceRole[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Scopes
.
To construct, see NOTES section for SCOPES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResourceScope[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessPackageResource

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAccessPackageResource>`: accessPackageResource
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsDefaultEnvironment <Boolean?>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
  - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[IsRootScope <Boolean?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource

`ENVIRONMENT <IMicrosoftGraphAccessPackageResourceEnvironment>`: accessPackageResourceEnvironment
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsDefaultEnvironment <Boolean?>]`: 
  - `[ModifiedDateTime <DateTime?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource

`ROLES <IMicrosoftGraphAccessPackageResourceRole[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsDefaultEnvironment <Boolean?>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
    - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsRootScope <Boolean?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource

`SCOPES <IMicrosoftGraphAccessPackageResourceScope[]>`: .
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: 
  - `[IsRootScope <Boolean?>]`: 
  - `[OriginId <String>]`: 
  - `[OriginSystem <String>]`: 
  - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Environment <IMicrosoftGraphAccessPackageResourceEnvironment>]`: accessPackageResourceEnvironment
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CreatedDateTime <DateTime?>]`: 
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[IsDefaultEnvironment <Boolean?>]`: 
      - `[ModifiedDateTime <DateTime?>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resources <IMicrosoftGraphAccessPackageResource[]>]`: 
    - `[ModifiedDateTime <DateTime?>]`: 
    - `[OriginId <String>]`: 
    - `[OriginSystem <String>]`: 
    - `[Roles <IMicrosoftGraphAccessPackageResourceRole[]>]`: 
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Description <String>]`: 
      - `[DisplayName <String>]`: 
      - `[OriginId <String>]`: 
      - `[OriginSystem <String>]`: 
      - `[Resource <IMicrosoftGraphAccessPackageResource>]`: accessPackageResource
    - `[Scopes <IMicrosoftGraphAccessPackageResourceScope[]>]`: 

## RELATED LINKS

