---
external help file: Microsoft.Graph.Mail-help.xml
Module Name: Microsoft.Graph.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/update-mguserinferenceclassificationoverride
schema: 2.0.0
---

# Update-MgUserInferenceClassificationOverride

## SYNOPSIS
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserInferenceClassificationOverride -InferenceClassificationOverrideId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ClassifyAs <String>] [-Id <String>]
 [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update1
```
Update-MgUserInferenceClassificationOverride -InferenceClassificationOverrideId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserInferenceClassificationOverride -InputObject <IMailIdentity> [-AdditionalProperties <Hashtable>]
 [-ClassifyAs <String>] [-Id <String>] [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserInferenceClassificationOverride -InputObject <IMailIdentity>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

## DESCRIPTION
A set of overrides for a user to always classify messages from specific senders in certain ways: focused, or other.
Read-only.
Nullable.

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphInferenceClassificationOverride
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
Type: String
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
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
Type: String
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
Type: String
Parameter Sets: UpdateExpanded1, Update1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IMailIdentity
Parameter Sets: UpdateViaIdentityExpanded1, UpdateViaIdentity1
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
Type: SwitchParameter
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
To construct, see NOTES section for SENDEREMAILADDRESS properties and create a hash table.

```yaml
Type: IMicrosoftGraphEmailAddress
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
Type: String
Parameter Sets: UpdateExpanded1, Update1
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMailIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride
## OUTPUTS

### System.Boolean
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphInferenceClassificationOverride>: inferenceClassificationOverride
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ClassifyAs <String>]`: inferenceClassificationType
  - `[SenderEmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of an entity instance.
    - `[Name <String>]`: The display name of an entity instance.

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
  - `[Address <String>]`: The email address of an entity instance.
  - `[Name <String>]`: The display name of an entity instance.

## RELATED LINKS
