---
external help file:
Module Name: Microsoft.Graph.DeviceManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement/new-mgdevicemanagementnotificationmessagetemplate
schema: 2.0.0
---

# New-MgDeviceManagementNotificationMessageTemplate

## SYNOPSIS
Create new navigation property to notificationMessageTemplates for deviceManagement

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgDeviceManagementNotificationMessageTemplate [-AdditionalProperties <Hashtable>]
 [-BrandingOptions <NotificationTemplateBrandingOptions>] [-DefaultLocale <String>] [-DisplayName <String>]
 [-Id <String>] [-LastModifiedDateTime <DateTime>]
 [-LocalizedNotificationMessages <IMicrosoftGraphLocalizedNotificationMessage[]>]
 [-RoleScopeTagIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgDeviceManagementNotificationMessageTemplate -BodyParameter <IMicrosoftGraphNotificationMessageTemplate1>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to notificationMessageTemplates for deviceManagement

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
Notification messages are messages that are sent to end users who are determined to be not-compliant with the compliance policies defined by the administrator.
Administrators choose notifications and configure them in the Intune Admin Console using the compliance policy creation page under the “Actions for non-compliance” section.
Use the notificationMessageTemplate object to create your own custom notifications for administrators to choose while configuring actions for non-compliance.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotificationMessageTemplate1
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BrandingOptions
Branding Options for the Message Template.
Branding is defined in the Intune Admin Console.

```yaml
Type: Microsoft.Graph.PowerShell.Support.NotificationTemplateBrandingOptions
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultLocale
The default locale to fallback onto when the requested locale is not available.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
Display name for the Notification Message Template.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
DateTime the object was last modified.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LocalizedNotificationMessages
The list of localized messages for this Notification Message Template.
To construct, please use Get-Help -Online and see NOTES section for LOCALIZEDNOTIFICATIONMESSAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphLocalizedNotificationMessage[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTagIds
List of Scope Tags for this Entity instance.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotificationMessageTemplate1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNotificationMessageTemplate1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphNotificationMessageTemplate1>: Notification messages are messages that are sent to end users who are determined to be not-compliant with the compliance policies defined by the administrator. Administrators choose notifications and configure them in the Intune Admin Console using the compliance policy creation page under the “Actions for non-compliance” section. Use the notificationMessageTemplate object to create your own custom notifications for administrators to choose while configuring actions for non-compliance.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[BrandingOptions <NotificationTemplateBrandingOptions?>]`: Branding Options for the Message Template. Branding is defined in the Intune Admin Console.
  - `[DefaultLocale <String>]`: The default locale to fallback onto when the requested locale is not available.
  - `[DisplayName <String>]`: Display name for the Notification Message Template.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[LocalizedNotificationMessages <IMicrosoftGraphLocalizedNotificationMessage[]>]`: The list of localized messages for this Notification Message Template.
    - `[Id <String>]`: 
    - `[IsDefault <Boolean?>]`: Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.
    - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
    - `[Locale <String>]`: The Locale for which this message is destined.
    - `[MessageTemplate <String>]`: The Message Template content.
    - `[Subject <String>]`: The Message Template Subject.
  - `[RoleScopeTagIds <String[]>]`: List of Scope Tags for this Entity instance.

LOCALIZEDNOTIFICATIONMESSAGES <IMicrosoftGraphLocalizedNotificationMessage[]>: The list of localized messages for this Notification Message Template.
  - `[Id <String>]`: 
  - `[IsDefault <Boolean?>]`: Flag to indicate whether or not this is the default locale for language fallback. This flag can only be set. To unset, set this property to true on another Localized Notification Message.
  - `[LastModifiedDateTime <DateTime?>]`: DateTime the object was last modified.
  - `[Locale <String>]`: The Locale for which this message is destined.
  - `[MessageTemplate <String>]`: The Message Template content.
  - `[Subject <String>]`: The Message Template Subject.

## RELATED LINKS

