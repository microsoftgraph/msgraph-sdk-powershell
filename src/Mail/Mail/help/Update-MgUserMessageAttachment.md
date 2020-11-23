---
external help file: Microsoft.Graph.Mail-help.xml
Module Name: Microsoft.Graph.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/update-mgusermessageattachment
schema: 2.0.0
---

# Update-MgUserMessageAttachment

## SYNOPSIS
Update the navigation property attachments in users

## SYNTAX

### UpdateExpanded1 (Default)
```
Update-MgUserMessageAttachment -AttachmentId <String> -MessageId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-ContentType <String>] [-Id <String>] [-IsInline]
 [-LastModifiedDateTime <DateTime>] [-Name <String>] [-Size <Int32>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Update1
```
Update-MgUserMessageAttachment -AttachmentId <String> -MessageId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded1
```
Update-MgUserMessageAttachment -InputObject <IMailIdentity> [-AdditionalProperties <Hashtable>]
 [-ContentType <String>] [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>]
 [-Size <Int32>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity1
```
Update-MgUserMessageAttachment -InputObject <IMailIdentity> -BodyParameter <IMicrosoftGraphAttachment>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property attachments in users

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

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

### -AttachmentId
key: id of attachment

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

### -BodyParameter
attachment
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAttachment
Parameter Sets: Update1, UpdateViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentType
The MIME type.

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

### -IsInline
true if the attachment is an inline attachment; otherwise, false.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MessageId
key: id of message

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

### -Name
The attachment's file name.

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

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Size
The length of the attachment in bytes.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded1, UpdateViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: 0
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachment
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphAttachment\>: attachment
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ContentType \<String\>\]: The MIME type.
  \[IsInline \<Boolean?\>\]: true if the attachment is an inline attachment; otherwise, false.
  \[LastModifiedDateTime \<DateTime?\>\]: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  \[Name \<String\>\]: The attachment's file name.
  \[Size \<Int32?\>\]: The length of the attachment in bytes.

INPUTOBJECT \<IMailIdentity\>: Identity Parameter
  \[AttachmentId \<String\>\]: key: id of attachment
  \[ExtensionId \<String\>\]: key: id of extension
  \[InferenceClassificationOverrideId \<String\>\]: key: id of inferenceClassificationOverride
  \[MailFolderId \<String\>\]: key: id of mailFolder
  \[MailFolderId1 \<String\>\]: key: id of mailFolder
  \[MentionId \<String\>\]: key: id of mention
  \[MessageId \<String\>\]: key: id of message
  \[MessageRuleId \<String\>\]: key: id of messageRule
  \[MultiValueLegacyExtendedPropertyId \<String\>\]: key: id of multiValueLegacyExtendedProperty
  \[SingleValueLegacyExtendedPropertyId \<String\>\]: key: id of singleValueLegacyExtendedProperty
  \[UserConfigurationId \<String\>\]: key: id of userConfiguration
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/update-mgusermessageattachment](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/update-mgusermessageattachment)

