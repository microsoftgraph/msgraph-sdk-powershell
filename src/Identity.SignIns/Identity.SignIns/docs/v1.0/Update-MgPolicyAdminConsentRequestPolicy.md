---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicyadminconsentrequestpolicy
schema: 2.0.0
---

# Update-MgPolicyAdminConsentRequestPolicy

## SYNOPSIS
Update the navigation property adminConsentRequestPolicy in policies

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgPolicyAdminConsentRequestPolicy [-AdditionalProperties <Hashtable>] [-Id <String>] [-IsEnabled]
 [-NotifyReviewers] [-RemindersEnabled] [-RequestDurationInDays <Int32>]
 [-Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>] [-Version <Int32>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgPolicyAdminConsentRequestPolicy -BodyParameter <IMicrosoftGraphAdminConsentRequestPolicy> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property adminConsentRequestPolicy in policies

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
adminConsentRequestPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdminConsentRequestPolicy
Parameter Sets: Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEnabled
Specifies whether the admin consent request feature is enabled or disabled.
Required.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NotifyReviewers
Specifies whether reviewers will receive notifications.
Required.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
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

### -RemindersEnabled
Specifies whether reviewers will receive reminder emails.
Required.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestDurationInDays
Specifies the duration the request is active before it automatically expires if no decision is applied.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reviewers
Required.
To construct, please use Get-Help -Online and see NOTES section for REVIEWERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAccessReviewReviewerScope[]
Parameter Sets: UpdateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Version
Specifies the version of this policy.
When the policy is updated, this version is updated.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAdminConsentRequestPolicy

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAdminConsentRequestPolicy>: adminConsentRequestPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[IsEnabled <Boolean?>]`: Specifies whether the admin consent request feature is enabled or disabled. Required.
  - `[NotifyReviewers <Boolean?>]`: Specifies whether reviewers will receive notifications. Required.
  - `[RemindersEnabled <Boolean?>]`: Specifies whether reviewers will receive reminder emails. Required.
  - `[RequestDurationInDays <Int32?>]`: Specifies the duration the request is active before it automatically expires if no decision is applied.
  - `[Reviewers <IMicrosoftGraphAccessReviewReviewerScope[]>]`: Required.
    - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
    - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
    - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.
  - `[Version <Int32?>]`: Specifies the version of this policy. When the policy is updated, this version is updated. Read-only.

REVIEWERS <IMicrosoftGraphAccessReviewReviewerScope[]>: Required.
  - `[Query <String>]`: The query specifying who will be the reviewer. See table for examples.
  - `[QueryRoot <String>]`: In the scenario where reviewers need to be specified dynamically, this property is used to indicate the relative source of the query. This property is only required if a relative query, for example, ./manager, is specified. Possible value: decisions.
  - `[QueryType <String>]`: The type of query. Examples include MicrosoftGraph and ARM.

## RELATED LINKS

