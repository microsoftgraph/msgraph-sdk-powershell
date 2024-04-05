---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/reset-mgbetapolicycrosstenantaccesspolicytemplatemultitenantorganizationpartnerconfigurationtodefaultsetting
schema: 2.0.0
---

# Reset-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfigurationToDefaultSetting

## SYNOPSIS
Reset the cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization to the default values.
In its reset state, the template has no impact on partner configuration settings, other than that an unconfigured partner configuration is created if needed, for every multitenant organization tenant.

## SYNTAX

```
Reset-MgBetaPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationPartnerConfigurationToDefaultSetting
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Reset the cross-tenant access policy template with inbound and outbound partner configuration settings for a multitenant organization to the default values.
In its reset state, the template has no impact on partner configuration settings, other than that an unconfigured partner configuration is created if needed, for every multitenant organization tenant.

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

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

## RELATED LINKS

