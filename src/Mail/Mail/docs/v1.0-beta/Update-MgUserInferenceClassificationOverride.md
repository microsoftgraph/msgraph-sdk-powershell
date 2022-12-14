---
external help file:
Module Name: Microsoft.Graph.Beta.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.mail/update-mguserinferenceclassificationoverride
schema: 2.0.0
---

# Update-MgBetaUserInferenceClassificationOverride

## SYNOPSIS
Update the navigation property overrides in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgBetaUserInferenceClassificationOverride -InferenceClassificationOverrideId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ClassifyAs <String>] [-Id <String>]
 [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update1
```
Update-MgBetaUserInferenceClassificationOverride -InferenceClassificationOverrideId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgBetaUserInferenceClassificationOverride -InputObject <IMailIdentity>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgBetaUserInferenceClassificationOverride -InputObject <IMailIdentity> [-AdditionalProperties <Hashtable>]
 [-ClassifyAs <String>] [-Id <String>] [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property overrides in users

## EXAMPLES

### Example 1: Using the Update-MgBetaUserInferenceClassificationOverride Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Mail
$params = @{
	ClassifyAs = "focused"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserInferenceClassificationOverride -UserId $userId -InferenceClassificationOverrideId $inferenceClassificationOverrideId -BodyParameter $params
```

This example shows how to use the Update-MgBetaUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
inferenceClassificationOverride
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ClassifyAs
inferenceClassificationType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InferenceClassificationOverrideId
key: id of inferenceClassificationOverride

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMailIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
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

### -SenderEmailAddress
emailAddress
To construct, please use Get-Help -Online and see NOTES section for SENDEREMAILADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphEmailAddress
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: System.String
Parameter Sets: Update1, UpdateExpanded1
Aliases:

Required: True
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

### Microsoft.Graph.Beta.PowerShell.Models.IMailIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphInferenceClassificationOverride>: inferenceClassificationOverride
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ClassifyAs <String>]`: inferenceClassificationType
  - `[SenderEmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.

INPUTOBJECT <IMailIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: id of attachment
  - `[ExtensionId <String>]`: key: id of extension
  - `[InferenceClassificationOverrideId <String>]`: key: id of inferenceClassificationOverride
  - `[MailFolderId <String>]`: key: id of mailFolder
  - `[MailFolderId1 <String>]`: key: id of mailFolder
  - `[MentionId <String>]`: key: id of mention
  - `[MessageId <String>]`: key: id of message
  - `[MessageRuleId <String>]`: key: id of messageRule
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: id of singleValueLegacyExtendedProperty
  - `[UserConfigurationId <String>]`: key: id of userConfiguration
  - `[UserId <String>]`: key: id of user

SENDEREMAILADDRESS <IMicrosoftGraphEmailAddress>: emailAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <String>]`: The email address of the person or entity.
  - `[Name <String>]`: The display name of the person or entity.

## RELATED LINKS

