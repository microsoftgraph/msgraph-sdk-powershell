---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.identity.signins/test-mgbetaidentityconditionalaccess
schema: 2.0.0
---

# Test-MgBetaIdentityConditionalAccess

## SYNOPSIS
Invoke action evaluate

## SYNTAX

### EvaluateExpanded (Default)
```
Test-MgBetaIdentityConditionalAccess [-AdditionalProperties <Hashtable>] [-AppliedPoliciesOnly]
 [-ConditionalAccessContext <Hashtable>]
 [-ConditionalAccessWhatIfConditions <IMicrosoftGraphConditionalAccessWhatIfConditions>]
 [-ConditionalAccessWhatIfSubject <Hashtable>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Evaluate
```
Test-MgBetaIdentityConditionalAccess
 -BodyParameter <IPathsDqhne3IdentityConditionalaccessMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action evaluate

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
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppliedPoliciesOnly
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsDqhne3IdentityConditionalaccessMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Evaluate
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConditionalAccessContext
conditionalAccessContext

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConditionalAccessWhatIfConditions
conditionalAccessWhatIfConditions
To construct, see NOTES section for CONDITIONALACCESSWHATIFCONDITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessWhatIfConditions
Parameter Sets: EvaluateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConditionalAccessWhatIfSubject
conditionalAccessWhatIfSubject

```yaml
Type: System.Collections.Hashtable
Parameter Sets: EvaluateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsDqhne3IdentityConditionalaccessMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConditionalAccessWhatIfPolicy

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsDqhne3IdentityConditionalaccessMicrosoftGraphEvaluatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AppliedPoliciesOnly <Boolean?>]`: 
  - `[ConditionalAccessContext <IMicrosoftGraphConditionalAccessContext>]`: conditionalAccessContext
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ConditionalAccessWhatIfConditions <IMicrosoftGraphConditionalAccessWhatIfConditions>]`: conditionalAccessWhatIfConditions
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuthenticationFlow <IMicrosoftGraphAuthenticationFlow>]`: authenticationFlow
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[TransferMethod <String>]`: conditionalAccessTransferMethods
    - `[ClientAppType <String>]`: conditionalAccessClientApp
    - `[Country <String>]`: 
    - `[DeviceInfo <IMicrosoftGraphDeviceInfo>]`: deviceInfo
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DeviceId <String>]`: 
      - `[DisplayName <String>]`: 
      - `[EnrollmentProfileName <String>]`: 
      - `[ExtensionAttribute1 <String>]`: 
      - `[ExtensionAttribute10 <String>]`: 
      - `[ExtensionAttribute11 <String>]`: 
      - `[ExtensionAttribute12 <String>]`: 
      - `[ExtensionAttribute13 <String>]`: 
      - `[ExtensionAttribute14 <String>]`: 
      - `[ExtensionAttribute15 <String>]`: 
      - `[ExtensionAttribute2 <String>]`: 
      - `[ExtensionAttribute3 <String>]`: 
      - `[ExtensionAttribute4 <String>]`: 
      - `[ExtensionAttribute5 <String>]`: 
      - `[ExtensionAttribute6 <String>]`: 
      - `[ExtensionAttribute7 <String>]`: 
      - `[ExtensionAttribute8 <String>]`: 
      - `[ExtensionAttribute9 <String>]`: 
      - `[IsCompliant <Boolean?>]`: 
      - `[Manufacturer <String>]`: 
      - `[MdmAppId <String>]`: 
      - `[Model <String>]`: 
      - `[OperatingSystem <String>]`: 
      - `[OperatingSystemVersion <String>]`: 
      - `[Ownership <String>]`: 
      - `[PhysicalIds <String[]>]`: 
      - `[ProfileType <String>]`: 
      - `[SystemLabels <String[]>]`: 
      - `[TrustType <String>]`: 
    - `[DevicePlatform <String>]`: conditionalAccessDevicePlatform
    - `[IPAddress <String>]`: 
    - `[InsiderRiskLevel <String>]`: insiderRiskLevel
    - `[ServicePrincipalRiskLevel <String>]`: riskLevel
    - `[SignInRiskLevel <String>]`: riskLevel
    - `[UserRiskLevel <String>]`: riskLevel
  - `[ConditionalAccessWhatIfSubject <IMicrosoftGraphConditionalAccessWhatIfSubject>]`: conditionalAccessWhatIfSubject
    - `[(Any) <Object>]`: This indicates any property can be added to this object.

`CONDITIONALACCESSWHATIFCONDITIONS <IMicrosoftGraphConditionalAccessWhatIfConditions>`: conditionalAccessWhatIfConditions
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuthenticationFlow <IMicrosoftGraphAuthenticationFlow>]`: authenticationFlow
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[TransferMethod <String>]`: conditionalAccessTransferMethods
  - `[ClientAppType <String>]`: conditionalAccessClientApp
  - `[Country <String>]`: 
  - `[DeviceInfo <IMicrosoftGraphDeviceInfo>]`: deviceInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DeviceId <String>]`: 
    - `[DisplayName <String>]`: 
    - `[EnrollmentProfileName <String>]`: 
    - `[ExtensionAttribute1 <String>]`: 
    - `[ExtensionAttribute10 <String>]`: 
    - `[ExtensionAttribute11 <String>]`: 
    - `[ExtensionAttribute12 <String>]`: 
    - `[ExtensionAttribute13 <String>]`: 
    - `[ExtensionAttribute14 <String>]`: 
    - `[ExtensionAttribute15 <String>]`: 
    - `[ExtensionAttribute2 <String>]`: 
    - `[ExtensionAttribute3 <String>]`: 
    - `[ExtensionAttribute4 <String>]`: 
    - `[ExtensionAttribute5 <String>]`: 
    - `[ExtensionAttribute6 <String>]`: 
    - `[ExtensionAttribute7 <String>]`: 
    - `[ExtensionAttribute8 <String>]`: 
    - `[ExtensionAttribute9 <String>]`: 
    - `[IsCompliant <Boolean?>]`: 
    - `[Manufacturer <String>]`: 
    - `[MdmAppId <String>]`: 
    - `[Model <String>]`: 
    - `[OperatingSystem <String>]`: 
    - `[OperatingSystemVersion <String>]`: 
    - `[Ownership <String>]`: 
    - `[PhysicalIds <String[]>]`: 
    - `[ProfileType <String>]`: 
    - `[SystemLabels <String[]>]`: 
    - `[TrustType <String>]`: 
  - `[DevicePlatform <String>]`: conditionalAccessDevicePlatform
  - `[IPAddress <String>]`: 
  - `[InsiderRiskLevel <String>]`: insiderRiskLevel
  - `[ServicePrincipalRiskLevel <String>]`: riskLevel
  - `[SignInRiskLevel <String>]`: riskLevel
  - `[UserRiskLevel <String>]`: riskLevel

## RELATED LINKS

