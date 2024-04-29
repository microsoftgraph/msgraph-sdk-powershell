---
external help file:
Module Name: Microsoft.Graph.Beta.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users.actions/convert-mgbetauserexternaltointernalmemberuser
schema: 2.0.0
---

# Convert-MgBetaUserExternalToInternalMemberUser

## SYNOPSIS
Convert an externally authenticated user into an internal user.
The user is able to sign into the host tenant as an internal user and access resources as a member.
For more information about this conversion, see Convert external users to internal users.

## SYNTAX

### ConvertExpanded (Default)
```
Convert-MgBetaUserExternalToInternalMemberUser -UserId <String> [-AdditionalProperties <Hashtable>]
 [-Mail <String>] [-PasswordProfile <IMicrosoftGraphPasswordProfile>] [-ResponseHeadersVariable <String>]
 [-UserPrincipalName <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Convert
```
Convert-MgBetaUserExternalToInternalMemberUser -UserId <String>
 -Body <IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ConvertViaIdentity
```
Convert-MgBetaUserExternalToInternalMemberUser -InputObject <IUsersActionsIdentity>
 -BodyParameter <IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### ConvertViaIdentityExpanded
```
Convert-MgBetaUserExternalToInternalMemberUser -InputObject <IUsersActionsIdentity>
 [-AdditionalProperties <Hashtable>] [-Mail <String>] [-PasswordProfile <IMicrosoftGraphPasswordProfile>]
 [-ResponseHeadersVariable <String>] [-UserPrincipalName <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Convert an externally authenticated user into an internal user.
The user is able to sign into the host tenant as an internal user and access resources as a member.
For more information about this conversion, see Convert external users to internal users.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: ConvertExpanded, ConvertViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Body
.
To construct, see NOTES section for BODY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema
Parameter Sets: Convert
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema
Parameter Sets: ConvertViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity
Parameter Sets: ConvertViaIdentity, ConvertViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Mail
.

```yaml
Type: System.String
Parameter Sets: ConvertExpanded, ConvertViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PasswordProfile
passwordProfile
To construct, see NOTES section for PASSWORDPROFILE properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPasswordProfile
Parameter Sets: ConvertExpanded, ConvertViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

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
Parameter Sets: Convert, ConvertExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
.

```yaml
Type: System.String
Parameter Sets: ConvertExpanded, ConvertViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphConversionUserDetails

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODY <IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Mail <String>]`: 
  - `[PasswordProfile <IMicrosoftGraphPasswordProfile>]`: passwordProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change their password on the next sign-in; otherwise false. If not set, default is false.
    - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multifactor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multifactor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
    - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next sign-in. The password must satisfy minimum requirements as specified by the user's passwordPolicies property. By default, a strong password is required.
  - `[UserPrincipalName <String>]`: 

`BODYPARAMETER <IComponents189ZsniRequestbodiesConvertexternaltointernalmemberuserrequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Mail <String>]`: 
  - `[PasswordProfile <IMicrosoftGraphPasswordProfile>]`: passwordProfile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change their password on the next sign-in; otherwise false. If not set, default is false.
    - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multifactor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multifactor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
    - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next sign-in. The password must satisfy minimum requirements as specified by the user's passwordPolicies property. By default, a strong password is required.
  - `[UserPrincipalName <String>]`: 

`INPUTOBJECT <IUsersActionsIdentity>`: Identity Parameter
  - `[AccessReviewInstanceId <String>]`: The unique identifier of accessReviewInstance
  - `[AccessReviewStageId <String>]`: The unique identifier of accessReviewStage
  - `[AppLogCollectionRequestId <String>]`: The unique identifier of appLogCollectionRequest
  - `[AuthenticationMethodId <String>]`: The unique identifier of authenticationMethod
  - `[CalendarId <String>]`: The unique identifier of calendar
  - `[ChatId <String>]`: The unique identifier of chat
  - `[ChatMessageId <String>]`: The unique identifier of chatMessage
  - `[ChatMessageId1 <String>]`: The unique identifier of chatMessage
  - `[CloudPcId <String>]`: The unique identifier of cloudPC
  - `[ContentTypeId <String>]`: The unique identifier of contentType
  - `[DeviceEnrollmentConfigurationId <String>]`: The unique identifier of deviceEnrollmentConfiguration
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
  - `[JoinWebUrl <String>]`: Alternate key of onlineMeeting
  - `[ListItemId <String>]`: The unique identifier of listItem
  - `[ListItemVersionId <String>]`: The unique identifier of listItemVersion
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[ManagedDeviceId <String>]`: The unique identifier of managedDevice
  - `[MessageId <String>]`: The unique identifier of message
  - `[MobileAppTroubleshootingEventId <String>]`: The unique identifier of mobileAppTroubleshootingEvent
  - `[NotebookId <String>]`: The unique identifier of notebook
  - `[OnenotePageId <String>]`: The unique identifier of onenotePage
  - `[OnenoteSectionId <String>]`: The unique identifier of onenoteSection
  - `[OnlineMeetingId <String>]`: The unique identifier of onlineMeeting
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[PlannerPlanId <String>]`: The unique identifier of plannerPlan
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

`PASSWORDPROFILE <IMicrosoftGraphPasswordProfile>`: passwordProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ForceChangePasswordNextSignIn <Boolean?>]`: true if the user must change their password on the next sign-in; otherwise false. If not set, default is false.
  - `[ForceChangePasswordNextSignInWithMfa <Boolean?>]`: If true, at next sign-in, the user must perform a multifactor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multifactor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
  - `[Password <String>]`: The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next sign-in. The password must satisfy minimum requirements as specified by the user's passwordPolicies property. By default, a strong password is required.

## RELATED LINKS

