---
external help file: Microsoft.Graph.Users.Actions-help.xml
Module Name: Microsoft.Graph.Users.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/clear-mgusermanagedappregistrationbydevicetag
schema: 2.0.0
---

# Clear-MgUserManagedAppRegistrationByDeviceTag

## SYNOPSIS
Invoke action wipeManagedAppRegistrationsByDeviceTag

## SYNTAX

### WipeExpanded (Default)
```
Clear-MgUserManagedAppRegistrationByDeviceTag -UserId <String> [-AdditionalProperties <Hashtable>]
 [-DeviceTag <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Wipe
```
Clear-MgUserManagedAppRegistrationByDeviceTag -UserId <String>
 -BodyParameter <IPathsVloam1UsersUserIdMicrosoftGraphWipemanagedappregistrationsbydevicetagPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### WipeViaIdentityExpanded
```
Clear-MgUserManagedAppRegistrationByDeviceTag -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-DeviceTag <String>] [-PassThru] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### WipeViaIdentity
```
Clear-MgUserManagedAppRegistrationByDeviceTag -InputObject <IUsersActionsIdentity>
 -BodyParameter <IPathsVloam1UsersUserIdMicrosoftGraphWipemanagedappregistrationsbydevicetagPostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action wipeManagedAppRegistrationsByDeviceTag

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
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPathsVloam1UsersUserIdMicrosoftGraphWipemanagedappregistrationsbydevicetagPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Wipe, WipeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeviceTag
.

```yaml
Type: String
Parameter Sets: WipeExpanded, WipeViaIdentityExpanded
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
Type: IUsersActionsIdentity
Parameter Sets: WipeViaIdentityExpanded, WipeViaIdentity
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
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: WipeExpanded, Wipe
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

### Microsoft.Graph.PowerShell.Models.IPathsVloam1UsersUserIdMicrosoftGraphWipemanagedappregistrationsbydevicetagPostRequestbodyContentApplicationJsonSchema
### Microsoft.Graph.PowerShell.Models.IUsersActionsIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPathsVloam1UsersUserIdMicrosoftGraphWipemanagedappregistrationsbydevicetagPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DeviceTag \<String\>\]: 

INPUTOBJECT \<IUsersActionsIdentity\>: Identity Parameter
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AppLogCollectionRequestId \<String\>\]: key: id of appLogCollectionRequest
  \[AuthenticationMethodId \<String\>\]: key: id of authenticationMethod
  \[CalendarId \<String\>\]: key: id of calendar
  \[DeviceEnrollmentConfigurationId \<String\>\]: key: id of deviceEnrollmentConfiguration
  \[DeviceLogCollectionResponseId \<String\>\]: key: id of deviceLogCollectionResponse
  \[EventId \<String\>\]: key: id of event
  \[EventId1 \<String\>\]: key: id of event
  \[MailFolderId \<String\>\]: key: id of mailFolder
  \[MailFolderId1 \<String\>\]: key: id of mailFolder
  \[ManagedDeviceId \<String\>\]: key: id of managedDevice
  \[MessageId \<String\>\]: key: id of message
  \[MobileAppTroubleshootingEventId \<String\>\]: key: id of mobileAppTroubleshootingEvent
  \[NotebookId \<String\>\]: key: id of notebook
  \[OnenotePageId \<String\>\]: key: id of onenotePage
  \[OnenoteSectionId \<String\>\]: key: id of onenoteSection
  \[OutlookTaskFolderId \<String\>\]: key: id of outlookTaskFolder
  \[OutlookTaskGroupId \<String\>\]: key: id of outlookTaskGroup
  \[OutlookTaskId \<String\>\]: key: id of outlookTask
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/clear-mgusermanagedappregistrationbydevicetag](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users.actions/clear-mgusermanagedappregistrationbydevicetag)

