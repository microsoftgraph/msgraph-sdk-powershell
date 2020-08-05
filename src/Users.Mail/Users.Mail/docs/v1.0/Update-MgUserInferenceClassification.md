---
external help file:
Module Name: Microsoft.Graph.Users.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.mail/update-mguserinferenceclassification
schema: 2.0.0
---

# Update-MgUserInferenceClassification

## SYNOPSIS
Update the navigation property inferenceClassification in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserInferenceClassification -UserId <String> [-Id <String>]
 [-Overrides <IMicrosoftGraphInferenceClassificationOverride[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update1
```
Update-MgUserInferenceClassification -UserId <String> -BodyParameter <IMicrosoftGraphInferenceClassification>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserInferenceClassification -InputObject <IUsersMailIdentity>
 -BodyParameter <IMicrosoftGraphInferenceClassification> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserInferenceClassification -InputObject <IUsersMailIdentity> [-Id <String>]
 [-Overrides <IMicrosoftGraphInferenceClassificationOverride[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property inferenceClassification in users

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
inferenceClassification
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassification
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersMailIdentity
Parameter Sets: UpdateViaIdentity1, UpdateViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Overrides
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.
To construct, see NOTES section for OVERRIDES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride[]
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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

### -UserId
key: user-id of user

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassification

### Microsoft.Graph.PowerShell.Models.IUsersMailIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphInferenceClassification>: inferenceClassification
  - `[Id <String>]`: Read-only.
  - `[Overrides <IMicrosoftGraphInferenceClassificationOverride[]>]`: A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ClassifyAs <String>]`: inferenceClassificationType
    - `[SenderEmailAddressAddress <String>]`: The email address of the person or entity.
    - `[SenderEmailAddressName <String>]`: The display name of the person or entity.

INPUTOBJECT <IUsersMailIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[InferenceClassificationOverrideId <String>]`: key: inferenceClassificationOverride-id of inferenceClassificationOverride
  - `[MailFolderId <String>]`: key: mailFolder-id of mailFolder
  - `[MailFolderId1 <String>]`: key: mailFolder-id of mailFolder
  - `[MentionId <String>]`: key: mention-id of mention
  - `[MessageId <String>]`: key: message-id of message
  - `[MessageRuleId <String>]`: key: messageRule-id of messageRule
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserConfigurationId <String>]`: key: userConfiguration-id of userConfiguration
  - `[UserId <String>]`: key: user-id of user

OVERRIDES <IMicrosoftGraphInferenceClassificationOverride[]>: A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ClassifyAs <String>]`: inferenceClassificationType
  - `[SenderEmailAddressAddress <String>]`: The email address of the person or entity.
  - `[SenderEmailAddressName <String>]`: The display name of the person or entity.

## RELATED LINKS

