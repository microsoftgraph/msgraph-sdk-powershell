---
external help file:
Module Name: Microsoft.Graph.Identity.OAuth2PermissionGrants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.oauth2permissiongrants/new-mgoauth2permissiongrantoauth2permissiongrantoauth2permissiongrant
schema: 2.0.0
---

# New-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant

## SYNOPSIS
Add new entity to oauth2PermissionGrants

## SYNTAX

### CreateExpanded (Default)
```
New-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant [-ClientId <String>]
 [-ConsentType <String>] [-ExpiryTime <DateTime>] [-Id <String>] [-PrincipalId <String>]
 [-ResourceId <String>] [-Scope <String>] [-StartTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant
 -BodyParameter <IMicrosoftGraphOAuth2PermissionGrant> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to oauth2PermissionGrants

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

### -BodyParameter
oAuth2PermissionGrant
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClientId
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

### -ConsentType
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

### -ExpiryTime
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

### -PrincipalId
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

### -ResourceId
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

### -Scope
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

### -StartTime
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphOAuth2PermissionGrant>: oAuth2PermissionGrant
  - `[Id <String>]`: Read-only.
  - `[ClientId <String>]`: 
  - `[ConsentType <String>]`: 
  - `[ExpiryTime <DateTime?>]`: 
  - `[PrincipalId <String>]`: 
  - `[ResourceId <String>]`: 
  - `[Scope <String>]`: 
  - `[StartTime <DateTime?>]`: 

## RELATED LINKS

