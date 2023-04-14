---
external help file:
Module Name: Microsoft.Graph.Calendar
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.calendar/update-mgusercalendarpermission
schema: 2.0.0
---

# Update-MgUserCalendarPermission

## SYNOPSIS
Update the navigation property calendarPermissions in users

## SYNTAX

### UpdateExpanded2 (Default)
```
Update-MgUserCalendarPermission -CalendarPermissionId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedRoles <String[]>] [-EmailAddress <IMicrosoftGraphEmailAddress>]
 [-Id <String>] [-IsInsideOrganization] [-IsRemovable] [-Role <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update2
```
Update-MgUserCalendarPermission -CalendarPermissionId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphCalendarPermission> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update3
```
Update-MgUserCalendarPermission -CalendarId <String> -CalendarPermissionId <String> -UserId <String>
 -BodyParameter <IMicrosoftGraphCalendarPermission> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateExpanded3
```
Update-MgUserCalendarPermission -CalendarId <String> -CalendarPermissionId <String> -UserId <String>
 [-AdditionalProperties <Hashtable>] [-AllowedRoles <String[]>] [-EmailAddress <IMicrosoftGraphEmailAddress>]
 [-Id <String>] [-IsInsideOrganization] [-IsRemovable] [-Role <String>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity2
```
Update-MgUserCalendarPermission -InputObject <ICalendarIdentity>
 -BodyParameter <IMicrosoftGraphCalendarPermission> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity3
```
Update-MgUserCalendarPermission -InputObject <ICalendarIdentity>
 -BodyParameter <IMicrosoftGraphCalendarPermission> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded2
```
Update-MgUserCalendarPermission -InputObject <ICalendarIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedRoles <String[]>] [-EmailAddress <IMicrosoftGraphEmailAddress>] [-Id <String>]
 [-IsInsideOrganization] [-IsRemovable] [-Role <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded3
```
Update-MgUserCalendarPermission -InputObject <ICalendarIdentity> [-AdditionalProperties <Hashtable>]
 [-AllowedRoles <String[]>] [-EmailAddress <IMicrosoftGraphEmailAddress>] [-Id <String>]
 [-IsInsideOrganization] [-IsRemovable] [-Role <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property calendarPermissions in users

## EXAMPLES

### Example 1: Using the Update-MgUserCalendarPermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Role = "write"
}
Update-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params
```

This example shows how to use the Update-MgUserCalendarPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedRoles
List of allowed sharing or delegating permission levels for the calendar.
Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
calendarPermission
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendarPermission
Parameter Sets: Update2, Update3, UpdateViaIdentity2, UpdateViaIdentity3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CalendarId
The unique identifier of calendar

```yaml
Type: System.String
Parameter Sets: Update3, UpdateExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CalendarPermissionId
The unique identifier of calendarPermission

```yaml
Type: System.String
Parameter Sets: Update2, Update3, UpdateExpanded2, UpdateExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailAddress
emailAddress
To construct, please use Get-Help -Online and see NOTES section for EMAILADDRESS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailAddress
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
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
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
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
Type: Microsoft.Graph.PowerShell.Models.ICalendarIdentity
Parameter Sets: UpdateViaIdentity2, UpdateViaIdentity3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsInsideOrganization
True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsRemovable
True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise.
The 'My organization' user determines the permissions other people within your organization have to the given calendar.
You cannot remove 'My organization' as a sharee to a calendar.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
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

### -Role
calendarRoleType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded2, UpdateExpanded3, UpdateViaIdentityExpanded2, UpdateViaIdentityExpanded3
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Update2, Update3, UpdateExpanded2, UpdateExpanded3
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

### Microsoft.Graph.PowerShell.Models.ICalendarIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCalendarPermission

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCalendarPermission>: calendarPermission
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[AllowedRoles <String[]>]`: List of allowed sharing or delegating permission levels for the calendar. Possible values are: none, freeBusyRead, limitedRead, read, write, delegateWithoutPrivateEventAccess, delegateWithPrivateEventAccess, custom.
  - `[EmailAddress <IMicrosoftGraphEmailAddress>]`: emailAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <String>]`: The email address of the person or entity.
    - `[Name <String>]`: The display name of the person or entity.
  - `[IsInsideOrganization <Boolean?>]`: True if the user in context (sharee or delegate) is inside the same organization as the calendar owner.
  - `[IsRemovable <Boolean?>]`: True if the user can be removed from the list of sharees or delegates for the specified calendar, false otherwise. The 'My organization' user determines the permissions other people within your organization have to the given calendar. You cannot remove 'My organization' as a sharee to a calendar.
  - `[Role <String>]`: calendarRoleType

EMAILADDRESS <IMicrosoftGraphEmailAddress>: emailAddress
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <String>]`: The email address of the person or entity.
  - `[Name <String>]`: The display name of the person or entity.

INPUTOBJECT <ICalendarIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[CalendarGroupId <String>]`: The unique identifier of calendarGroup
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[CalendarPermissionId <String>]`: The unique identifier of calendarPermission
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[EventId2 <String>]`: The unique identifier of event
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[GroupId <String>]`: The unique identifier of group
  - `[MultiValueLegacyExtendedPropertyId <String>]`: The unique identifier of multiValueLegacyExtendedProperty
  - `[PlaceId <String>]`: The unique identifier of place
  - `[SingleValueLegacyExtendedPropertyId <String>]`: The unique identifier of singleValueLegacyExtendedProperty
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

