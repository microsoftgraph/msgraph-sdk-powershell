---
external help file:
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/rename-mguserpassword
schema: 2.0.0
---

# Rename-MgUserPassword

## SYNOPSIS
Invoke action changePassword

## SYNTAX

### ChangeExpanded1 (Default)
```
Rename-MgUserPassword -UserId <String> [-CurrentPassword <String>] [-NewPassword <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Change1
```
Rename-MgUserPassword -UserId <String>
 -BodyParameter <IPaths3Mx0JpUsersUserIdMicrosoftGraphChangepasswordPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentity1
```
Rename-MgUserPassword -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPaths3Mx0JpUsersUserIdMicrosoftGraphChangepasswordPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ChangeViaIdentityExpanded1
```
Rename-MgUserPassword -InputObject <IUsersActionsIdentity> [-CurrentPassword <String>] [-NewPassword <String>]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action changePassword

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
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths3Mx0JpUsersUserIdMicrosoftGraphChangepasswordPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Change1, ChangeViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CurrentPassword
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded1, ChangeViaIdentityExpanded1
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
Type: Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: ChangeViaIdentity1, ChangeViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -NewPassword
.

```yaml
Type: System.String
Parameter Sets: ChangeExpanded1, ChangeViaIdentityExpanded1
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
Parameter Sets: Change1, ChangeExpanded1
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

### Microsoft.Graph.PowerShell.Models.IPaths3Mx0JpUsersUserIdMicrosoftGraphChangepasswordPostRequestbodyContentApplicationJsonSchema

### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths3Mx0JpUsersUserIdMicrosoftGraphChangepasswordPostRequestbodyContentApplicationJsonSchema>: .
  - `[CurrentPassword <String>]`: 
  - `[NewPassword <String>]`: 

INPUTOBJECT <IUsersActionsIdentity>: Identity Parameter
  - `[AppLogCollectionRequestId <String>]`: key: appLogCollectionRequest-id of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: key: authenticationMethod-id of authenticationMethod
  - `[CalendarGroupId <String>]`: key: calendarGroup-id of calendarGroup
  - `[CalendarId <String>]`: key: calendar-id of calendar
  - `[DeviceEnrollmentConfigurationId <String>]`: key: deviceEnrollmentConfiguration-id of deviceEnrollmentConfiguration
  - `[EventId <String>]`: key: event-id of event
  - `[EventId1 <String>]`: key: event-id of event
  - `[MailFolderId <String>]`: key: mailFolder-id of mailFolder
  - `[MailFolderId1 <String>]`: key: mailFolder-id of mailFolder
  - `[ManagedDeviceId <String>]`: key: managedDevice-id of managedDevice
  - `[MessageId <String>]`: key: message-id of message
  - `[MobileAppTroubleshootingEventId <String>]`: key: mobileAppTroubleshootingEvent-id of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: key: notebook-id of notebook
  - `[OnenotePageId <String>]`: key: onenotePage-id of onenotePage
  - `[OnenoteSectionId <String>]`: key: onenoteSection-id of onenoteSection
  - `[OutlookTaskFolderId <String>]`: key: outlookTaskFolder-id of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: key: outlookTaskGroup-id of outlookTaskGroup
  - `[OutlookTaskId <String>]`: key: outlookTask-id of outlookTask
  - `[SectionGroupId <String>]`: key: sectionGroup-id of sectionGroup
  - `[TeamsAppInstallationId <String>]`: key: teamsAppInstallation-id of teamsAppInstallation
  - `[UserId <String>]`: key: user-id of user
  - `[WindowsInformationProtectionDeviceRegistrationId <String>]`: key: windowsInformationProtectionDeviceRegistration-id of windowsInformationProtectionDeviceRegistration

## RELATED LINKS

