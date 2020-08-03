---
external help file:
Module Name: Microsoft.Graph.Identity.OAuth2PermissionGrants
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.oauth2permissiongrants/remove-mgoauth2permissiongrantoauth2permissiongrantoauth2permissiongrant
schema: 2.0.0
---

# Remove-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant

## SYNOPSIS
Delete entity from oauth2PermissionGrants

## SYNTAX

### Delete1 (Default)
```
Remove-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant -OAuth2PermissionGrantId <String>
 [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### DeleteViaIdentity1
```
Remove-MgOauth2PermissionGrantOAuth2PermissionGrantOAuth2PermissionGrant
 -InputObject <IIdentityOAuth2PermissionGrantsIdentity> [-IfMatch <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Delete entity from oauth2PermissionGrants

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

### -IfMatch
ETag

```yaml
Type: System.String
Parameter Sets: (All)
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
Type: Microsoft.Graph.PowerShell.Models.IIdentityOAuth2PermissionGrantsIdentity
Parameter Sets: DeleteViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OAuth2PermissionGrantId
key: oAuth2PermissionGrant-id of oAuth2PermissionGrant

```yaml
Type: System.String
Parameter Sets: Delete1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
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

### Microsoft.Graph.PowerShell.Models.IIdentityOAuth2PermissionGrantsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IIdentityOAuth2PermissionGrantsIdentity>: Identity Parameter
  - `[OAuth2PermissionGrantId <String>]`: key: oAuth2PermissionGrant-id of oAuth2PermissionGrant

## RELATED LINKS

