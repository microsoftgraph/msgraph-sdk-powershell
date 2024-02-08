---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.directorymanagement/new-mgbetadirectoryinboundshareduserprofile
schema: 2.0.0
---

# New-MgBetaDirectoryInboundSharedUserProfile

## SYNOPSIS
Create new navigation property to inboundSharedUserProfiles for directory

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaDirectoryInboundSharedUserProfile [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-HomeTenantId <String>] [-UserId <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaDirectoryInboundSharedUserProfile -BodyParameter <IMicrosoftGraphInboundSharedUserProfile>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to inboundSharedUserProfiles for directory

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
inboundSharedUserProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInboundSharedUserProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name displayed in the address book for the user at the time when the sharing record was created.
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

### -HomeTenantId
The home tenant id of the external user.
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

### -UserId
The object id of the external user.
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

### -UserPrincipalName
The user principal name (UPN) of the external user.
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInboundSharedUserProfile

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInboundSharedUserProfile

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphInboundSharedUserProfile>`: inboundSharedUserProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The name displayed in the address book for the user at the time when the sharing record was created. Read-only.
  - `[HomeTenantId <String>]`: The home tenant id of the external user. Read-only.
  - `[UserId <String>]`: The object id of the external user. Read-only.
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the external user. Read-only.

## RELATED LINKS

