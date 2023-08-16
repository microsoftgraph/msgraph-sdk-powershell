---
external help file:
Module Name: Microsoft.Graph.Beta.Users.Actions
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.users.actions/set-mgbetauserlicense
schema: 2.0.0
---

# Set-MgBetaUserLicense

## SYNOPSIS
Add or remove licenses for the user to enable or disable their use of Microsoft cloud offerings.
For example, an organization can have a Microsoft 365 Enterprise E3 subscription with 100 licenses, and this request assigns one of those licenses to a specific user.
You can also enable and disable specific plans associated with a subscription.
To learn more about subscriptions and licenses, see this Technet article.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

## SYNTAX

### AssignExpanded (Default)
```
Set-MgBetaUserLicense -UserId <String> [-AdditionalProperties <Hashtable>]
 [-AddLicenses <IMicrosoftGraphAssignedLicense[]>] [-RemoveLicenses <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Assign
```
Set-MgBetaUserLicense -UserId <String>
 -BodyParameter <IComponents103UmuuRequestbodiesAssignlicenserequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentity
```
Set-MgBetaUserLicense -InputObject <IUsersActionsIdentity>
 -BodyParameter <IComponents103UmuuRequestbodiesAssignlicenserequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AssignViaIdentityExpanded
```
Set-MgBetaUserLicense -InputObject <IUsersActionsIdentity> [-AdditionalProperties <Hashtable>]
 [-AddLicenses <IMicrosoftGraphAssignedLicense[]>] [-RemoveLicenses <String[]>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Add or remove licenses for the user to enable or disable their use of Microsoft cloud offerings.
For example, an organization can have a Microsoft 365 Enterprise E3 subscription with 100 licenses, and this request assigns one of those licenses to a specific user.
You can also enable and disable specific plans associated with a subscription.
To learn more about subscriptions and licenses, see this Technet article.
To get the subscriptions available in the directory, perform a GET subscribedSkus request.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

$EmsSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'

Set-MgBetaUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses @{SkuId = $EmsSku.SkuId} -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

$EmsSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$FlowSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'FLOW_FREE'
$addLicenses = @(
  @{SkuId = $EmsSku.SkuId},
  @{SkuId = $FlowSku.SkuId}
  )

Set-MgBetaUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member

### -------------------------- EXAMPLE 3 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

$EmsSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$disabledPlans = $EmsSku.ServicePlans | where ServicePlanName -in ("MFA_PREMIUM", "INTUNE_A") | Select -ExpandProperty ServicePlanId
$addLicenses = @(
  @{SkuId = $EmsSku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgBetaUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member

### -------------------------- EXAMPLE 4 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

$EmsSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'
$userLicense = Get-MgBetaUserLicenseDetail -UserId "38955658-c844-4f59-9430-6519430ac89b"

$userDisabledPlans = $userLicense.ServicePlans |
  Where ProvisioningStatus -eq "Disabled" |
  Select -ExpandProperty ServicePlanId

$newDisabledPlans = $EmsSku.ServicePlans |
  Where ServicePlanName -in ("AAD_PREMIUM_P2", "AAD_PREMIUM") |
  Select -ExpandProperty ServicePlanId

$disabledPlans = $userDisabledPlans + $newDisabledPlans | Select -Unique

$addLicenses = @(
  @{SkuId = $EmsSku.SkuId
  DisabledPlans = $disabledPlans
  }
  )

Set-MgBetaUserLicense -UserId '38955658-c844-4f59-9430-6519430ac89b' -AddLicenses $addLicenses -RemoveLicenses @()

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member

### -------------------------- EXAMPLE 5 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

Select-MgBetaProfile -Name Beta
$mgUser = Get-MgBetaUser -UserId '38955658-c844-4f59-9430-6519430ac89b'

Set-MgBetaUserLicense -UserId "82f51c98-7221-442f-8329-3faf9fe022f1" -AddLicenses $mgUser.AssignedLicenses -RemoveLicenses @()


Id                                   DisplayName    Mail UserPrincipalName                      UserType
--                                   -----------    ---- -----------------                      --------
82f51c98-7221-442f-8329-3faf9fe022f1 Mallory Cortez      MalloryC@contoso.onmicrosoft.com       Member

### -------------------------- EXAMPLE 6 --------------------------
```powershell
Connect-Graph -Scopes User.ReadWrite.All, Organization.Read.All
```

$EmsSku = Get-MgBetaSubscribedSku -All | Where SkuPartNumber -eq 'EMSPREMIUM'

Set-MgBetaUserLicense -UserId "38955658-c844-4f59-9430-6519430ac89b" -AddLicenses @() -RemoveLicenses @($EmsSku.SkuId)

Id                                   DisplayName   Mail UserPrincipalName                     UserType
--                                   -----------   ---- -----------------                     --------
38955658-c844-4f59-9430-6519430ac89b Bianca Pisani      BiancaP@contoso.onmicrosoft.com       Member

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AddLicenses
.
To construct, see NOTES section for ADDLICENSES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphAssignedLicense[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IComponents103UmuuRequestbodiesAssignlicenserequestbodyContentApplicationJsonSchema
Parameter Sets: Assign, AssignViaIdentity
Aliases:

Required: True
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
Parameter Sets: AssignViaIdentity, AssignViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -RemoveLicenses
.

```yaml
Type: System.String[]
Parameter Sets: AssignExpanded, AssignViaIdentityExpanded
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
Parameter Sets: Assign, AssignExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IComponents103UmuuRequestbodiesAssignlicenserequestbodyContentApplicationJsonSchema

### Microsoft.Graph.Beta.PowerShell.Models.IUsersActionsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUser

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADDLICENSES <IMicrosoftGraphAssignedLicense[]>`: .
  - `[DisabledPlans <String[]>]`: A collection of the unique identifiers for plans that have been disabled.
  - `[SkuId <String>]`: The unique identifier for the SKU.

`BODYPARAMETER <IComponents103UmuuRequestbodiesAssignlicenserequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AddLicenses <IMicrosoftGraphAssignedLicense[]>]`: 
    - `[DisabledPlans <String[]>]`: A collection of the unique identifiers for plans that have been disabled.
    - `[SkuId <String>]`: The unique identifier for the SKU.
  - `[RemoveLicenses <String[]>]`: 

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
  - `[DeviceId <String>]`: The unique identifier of device
  - `[DeviceLogCollectionResponseId <String>]`: The unique identifier of deviceLogCollectionResponse
  - `[DocumentSetVersionId <String>]`: The unique identifier of documentSetVersion
  - `[DriveId <String>]`: The unique identifier of drive
  - `[DriveItemId <String>]`: The unique identifier of driveItem
  - `[DriveItemVersionId <String>]`: The unique identifier of driveItemVersion
  - `[EventId <String>]`: The unique identifier of event
  - `[EventId1 <String>]`: The unique identifier of event
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
  - `[OutlookTaskFolderId <String>]`: The unique identifier of outlookTaskFolder
  - `[OutlookTaskGroupId <String>]`: The unique identifier of outlookTaskGroup
  - `[OutlookTaskId <String>]`: The unique identifier of outlookTask
  - `[PermissionId <String>]`: The unique identifier of permission
  - `[ResourceSpecificPermissionGrantId <String>]`: The unique identifier of resourceSpecificPermissionGrant
  - `[SensitivityLabelId <String>]`: The unique identifier of sensitivityLabel
  - `[SubscriptionId <String>]`: The unique identifier of subscription
  - `[TeamsAppInstallationId <String>]`: The unique identifier of teamsAppInstallation
  - `[TodoTaskId <String>]`: The unique identifier of todoTask
  - `[TodoTaskListId <String>]`: The unique identifier of todoTaskList
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

