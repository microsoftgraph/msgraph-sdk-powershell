---
external help file:
Module Name: Microsoft.Graph.Users.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.calendar/update-mgusercalendarviewattachment
schema: 2.0.0
---

# Update-MgUserCalendarViewAttachment

## SYNOPSIS
Update the navigation property attachments in users

## SYNTAX

### UpdateExpanded3 (Default)
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -EventId <String> -UserId <String>
 [-ContentType <String>] [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>]
 [-Size <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update3
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -EventId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update4
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -CalendarId <String> -EventId <String>
 -UserId <String> -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update5
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -EventId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded4
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -CalendarId <String> -EventId <String>
 -UserId <String> [-ContentType <String>] [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>]
 [-Name <String>] [-Size <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded5
```
Update-MgUserCalendarViewAttachment -AttachmentId <String> -EventId <String> -UserId <String>
 [-ContentType <String>] [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>]
 [-Size <Int32>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity4
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity5
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity>
 -BodyParameter <IMicrosoftGraphAttachment> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity> [-ContentType <String>]
 [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>] [-Size <Int32>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded4
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity> [-ContentType <String>]
 [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>] [-Size <Int32>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded5
```
Update-MgUserCalendarViewAttachment -InputObject <IUsersCalendarIdentity> [-ContentType <String>]
 [-Id <String>] [-IsInline] [-LastModifiedDateTime <DateTime>] [-Name <String>] [-Size <Int32>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property attachments in users

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

### -AttachmentId
key: attachment-id of attachment

```yaml
Type: System.String
Parameter Sets: Update3, Update4, Update5, UpdateExpanded3, UpdateExpanded4, UpdateExpanded5
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachment
Parameter Sets: Update3, Update4, Update5, UpdateViaIdentity3, UpdateViaIdentity4, UpdateViaIdentity5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CalendarId
key: calendar-id of calendar

```yaml
Type: System.String
Parameter Sets: Update4, UpdateExpanded4
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentType
The MIME type.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EventId
key: event-id of event

```yaml
Type: System.String
Parameter Sets: Update3, Update4, Update5, UpdateExpanded3, UpdateExpanded4, UpdateExpanded5
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
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
Type: Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity
Parameter Sets: UpdateViaIdentity3, UpdateViaIdentity4, UpdateViaIdentity5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
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
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The attachment's file name.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
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

### -Size
The length of the attachment in bytes.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded3, UpdateExpanded4, UpdateExpanded5, UpdateViaIdentityExpanded3, UpdateViaIdentityExpanded4, UpdateViaIdentityExpanded5
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
Parameter Sets: Update3, Update4, Update5, UpdateExpanded3, UpdateExpanded4, UpdateExpanded5
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAttachment

### Microsoft.Graph.PowerShell.Models.IUsersCalendarIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAttachment>: attachment
  - `[Id <String>]`: Read-only.
  - `[ContentType <String>]`: The MIME type.
  - `[IsInline <Boolean?>]`: true if the attachment is an inline attachment; otherwise, false.
  - `[LastModifiedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[Name <String>]`: The attachment's file name.
  - `[Size <Int32?>]`: The length of the attachment in bytes.

INPUTOBJECT <IUsersCalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[CalendarPermissionId <String>]`: key: calendarPermission-id of calendarPermission
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: key: user-id of user

## RELATED LINKS

