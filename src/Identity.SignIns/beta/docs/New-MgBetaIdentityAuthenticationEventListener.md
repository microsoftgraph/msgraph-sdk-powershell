---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/new-mgbetaidentityauthenticationeventlistener
schema: 2.0.0
---

# New-MgBetaIdentityAuthenticationEventListener

## SYNOPSIS
Create a new authenticationEventListener object.
You can create one of the following subtypes that are derived from authenticationEventListener.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaIdentityAuthenticationEventListener [-AdditionalProperties <Hashtable>]
 [-AuthenticationEventsFlowId <String>] [-Conditions <IMicrosoftGraphAuthenticationConditions>] [-Id <String>]
 [-Priority <Int32>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaIdentityAuthenticationEventListener -BodyParameter <IMicrosoftGraphAuthenticationEventListener>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new authenticationEventListener object.
You can create one of the following subtypes that are derived from authenticationEventListener.

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

### -AuthenticationEventsFlowId
The identifier of the authenticationEventsFlow object.

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
authenticationEventListener
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationEventListener
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Conditions
authenticationConditions
To construct, see NOTES section for CONDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationConditions
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

### -Priority
The priority of this handler.
Between 0 (lower priority) and 1000 (higher priority).

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationEventListener

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAuthenticationEventListener

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphAuthenticationEventListener>`: authenticationEventListener
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AuthenticationEventsFlowId <String>]`: The identifier of the authenticationEventsFlow object.
  - `[Conditions <IMicrosoftGraphAuthenticationConditions>]`: authenticationConditions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Applications <IMicrosoftGraphAuthenticationConditionsApplications>]`: authenticationConditionsApplications
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IncludeAllApplications <Boolean?>]`: Whether the custom authentication extension should trigger for all applications with appIds specified in the includeApplications relationship. This property must be set to false for listener of type onTokenIssuanceStartListener.
      - `[IncludeApplications <IMicrosoftGraphAuthenticationConditionApplication[]>]`: 
        - `[AppId <String>]`: The identifier for an application corresponding to a condition which will trigger an authenticationEventListener.
  - `[Priority <Int32?>]`: The priority of this handler. Between 0 (lower priority) and 1000 (higher priority).

`CONDITIONS <IMicrosoftGraphAuthenticationConditions>`: authenticationConditions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Applications <IMicrosoftGraphAuthenticationConditionsApplications>]`: authenticationConditionsApplications
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[IncludeAllApplications <Boolean?>]`: Whether the custom authentication extension should trigger for all applications with appIds specified in the includeApplications relationship. This property must be set to false for listener of type onTokenIssuanceStartListener.
    - `[IncludeApplications <IMicrosoftGraphAuthenticationConditionApplication[]>]`: 
      - `[AppId <String>]`: The identifier for an application corresponding to a condition which will trigger an authenticationEventListener.

## RELATED LINKS

