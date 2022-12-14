---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mgidentitycustomauthenticationextension
schema: 2.0.0
---

# New-MgBetaIdentityCustomAuthenticationExtension

## SYNOPSIS
Create new navigation property to customAuthenticationExtensions for identity

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityCustomAuthenticationExtension [-AdditionalProperties <Hashtable>]
 [-AuthenticationConfiguration <Hashtable>]
 [-ClientConfiguration <IMicrosoftGraphCustomExtensionClientConfiguration>] [-Description <String>]
 [-DisplayName <String>] [-EndpointConfiguration <Hashtable>] [-Id <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityCustomAuthenticationExtension -BodyParameter <Hashtable> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to customAuthenticationExtensions for identity

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

### -AuthenticationConfiguration
customExtensionAuthenticationConfiguration

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
customAuthenticationExtension

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

### -ClientConfiguration
customExtensionClientConfiguration
To construct, please use Get-Help -Online and see NOTES section for CLIENTCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomExtensionClientConfiguration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for the customCalloutExtension object.

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
Display name for the customCalloutExtension object.

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

### -EndpointConfiguration
customExtensionEndpointConfiguration

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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCustomAuthenticationExtension

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


CLIENTCONFIGURATION <IMicrosoftGraphCustomExtensionClientConfiguration>: customExtensionClientConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[TimeoutInMilliseconds <Int32?>]`: The max duration in milliseconds that Azure AD will wait for a response from the logic app before it shuts down the connection. The valid range is between 200 and 2000 milliseconds. Default duration is 1000.

## RELATED LINKS

