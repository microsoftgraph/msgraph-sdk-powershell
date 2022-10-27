---
external help file:
Module Name: Microsoft.Graph.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/new-mguserinferenceclassificationoverride
schema: 2.0.0
---

# New-MgUserInferenceClassificationOverride

## SYNOPSIS
Create an override for a sender identified by an SMTP address.
Future messages from that SMTP address will be consistently classified\nas specified in the override.
**Note**

## SYNTAX

### CreateExpanded (Default)
```
New-MgUserInferenceClassificationOverride -UserId <String> [-AdditionalProperties <Hashtable>]
 [-ClassifyAs <String>] [-Id <String>] [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgUserInferenceClassificationOverride -UserId <String>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgUserInferenceClassificationOverride -InputObject <IMailIdentity>
 -BodyParameter <IMicrosoftGraphInferenceClassificationOverride> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgUserInferenceClassificationOverride -InputObject <IMailIdentity> [-AdditionalProperties <Hashtable>]
 [-ClassifyAs <String>] [-Id <String>] [-SenderEmailAddress <IMicrosoftGraphEmailAddress>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create an override for a sender identified by an SMTP address.
Future messages from that SMTP address will be consistently classified\nas specified in the override.
**Note**

## EXAMPLES

### Example 1: Using the New-MgUserInferenceClassificationOverride Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
$params = @{
	ClassifyAs = "focused"
	SenderEmailAddress = @{
		Name = "Samantha Booth"
		Address = "samanthab@adatum.onmicrosoft.com"
	}
}
# A UPN can also be used as -UserId.
New-MgUserInferenceClassificationOverride -UserId $userId -BodyParameter $params
```

This example shows how to use the New-MgUserInferenceClassificationOverride Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride
Parameter Sets: Create, CreateViaIdentity
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMailIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -SenderEmailAddress
emailAddress
To construct, please use Get-Help -Online and see NOTES section for SENDEREMAILADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailAddress
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: Create, CreateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMailIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphInferenceClassificationOverride

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

