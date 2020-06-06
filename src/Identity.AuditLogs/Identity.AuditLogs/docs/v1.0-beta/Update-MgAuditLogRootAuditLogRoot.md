---
external help file:
Module Name: Microsoft.Graph.Identity.AuditLogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.auditlogs/update-mgauditlogrootauditlogroot
schema: 2.0.0
---

# Update-MgAuditLogRootAuditLogRoot

## SYNOPSIS
Update auditLogs

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAuditLogRootAuditLogRoot [-DirectoryAudits <IMicrosoftGraphDirectoryAudit1[]>]
 [-DirectoryProvisioning <IMicrosoftGraphProvisioningObjectSummary[]>] [-Id <String>]
 [-Provisioning <IMicrosoftGraphProvisioningObjectSummary[]>]
 [-RestrictedSignIns <IMicrosoftGraphRestrictedSignIn1[]>] [-SignIns <IMicrosoftGraphSignIn1[]>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAuditLogRootAuditLogRoot -BodyParameter <IMicrosoftGraphAuditLogRoot1> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update auditLogs

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
auditLogRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditLogRoot1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryAudits
Read-only.
Nullable.
To construct, see NOTES section for DIRECTORYAUDITS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryAudit1[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DirectoryProvisioning
.
To construct, see NOTES section for DIRECTORYPROVISIONING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisioningObjectSummary[]
Parameter Sets: UpdateExpanded
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
Type: System.String
Parameter Sets: UpdateExpanded
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

### -Provisioning
.
To construct, see NOTES section for PROVISIONING properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisioningObjectSummary[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RestrictedSignIns
.
To construct, see NOTES section for RESTRICTEDSIGNINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedSignIn1[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SignIns
Read-only.
Nullable.
To construct, see NOTES section for SIGNINS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSignIn1[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuditLogRoot1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphAuditLogRoot1>: auditLogRoot
  - `[Id <String>]`: Read-only.
  - `[DirectoryAudits <IMicrosoftGraphDirectoryAudit1[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ActivityDateTime <DateTime?>]`: Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
    - `[ActivityDisplayName <String>]`: Indicates the activity name or the operation name (examples: 'Create User' and 'Add member to group'). For full list, see Azure AD activity list.
    - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Indicates additional details on the activity.
      - `[Key <String>]`: Key for the key-value pair.
      - `[Value <String>]`: Value for the key-value pair.
    - `[AppDisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
    - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
    - `[AppServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
    - `[AppServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[Category <String>]`: Indicates which resource category that's targeted by the activity. (For example: User Management, Group Management etc..)
    - `[CorrelationId <String>]`: Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.
    - `[LoggedByService <String>]`: Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.
    - `[OperationType <String>]`: 
    - `[Result <String>]`: operationResult
    - `[ResultReason <String>]`: Describes cause of 'failure' or 'timeout' results.
    - `[TargetResources <IMicrosoftGraphTargetResource[]>]`: Indicates information on which resource was changed due to the activity. Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
      - `[DisplayName <String>]`: Indicates the visible name defined for the resource. Typically specified when the resource is created.
      - `[GroupType <String>]`: groupType
      - `[Id <String>]`: Indicates the unique ID of the resource.
      - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.
        - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
        - `[NewValue <String>]`: Indicates the updated value for the propery.
        - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
      - `[Type <String>]`: Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.
      - `[UserPrincipalName <String>]`: When type is set to User, this includes the user name that initiated the action; null for other types.
    - `[UserDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[UserIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserId <String>]`: Unique identifier for the identity.
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[DirectoryProvisioning <IMicrosoftGraphProvisioningObjectSummary[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Action <String>]`: 
    - `[ActivityDateTime <DateTime?>]`: 
    - `[ChangeId <String>]`: 
    - `[CycleId <String>]`: 
    - `[DurationInMilliseconds <Int32?>]`: 
    - `[InitiatedByDisplayName <String>]`: 
    - `[InitiatedById <String>]`: 
    - `[InitiatedByInitiatorType <String>]`: initiatorType
    - `[JobId <String>]`: 
    - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: 
    - `[ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>]`: 
      - `[Description <String>]`: 
      - `[Details <IMicrosoftGraphDetailsInfo>]`: detailsInfo
      - `[Name <String>]`: 
      - `[ProvisioningStepType <String>]`: provisioningStepType
      - `[Status <String>]`: provisioningResult
    - `[ServicePrincipalDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[ServicePrincipalId <String>]`: Unique identifier for the identity.
    - `[SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[SourceIdentityDisplayName <String>]`: 
    - `[SourceIdentityId <String>]`: 
    - `[SourceIdentityType <String>]`: 
    - `[SourceSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[SourceSystemDisplayName <String>]`: 
    - `[SourceSystemId <String>]`: 
    - `[StatusInfoStatus <String>]`: provisioningResult
    - `[TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[TargetIdentityDisplayName <String>]`: 
    - `[TargetIdentityId <String>]`: 
    - `[TargetIdentityType <String>]`: 
    - `[TargetSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[TargetSystemDisplayName <String>]`: 
    - `[TargetSystemId <String>]`: 
    - `[TenantId <String>]`: 
  - `[Provisioning <IMicrosoftGraphProvisioningObjectSummary[]>]`: 
  - `[RestrictedSignIns <IMicrosoftGraphRestrictedSignIn1[]>]`: 
    - `[AlternateSignInName <String>]`: 
    - `[AppDisplayName <String>]`: App name displayed in the Azure Portal.
    - `[AppId <String>]`: Unique GUID representing the app ID in the Azure Active Directory.
    - `[AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>]`: 
      - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
      - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
      - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
      - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
      - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
      - `[Id <String>]`: Unique GUID of the conditional access polic.y
      - `[Result <String>]`: 
    - `[AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>]`: 
      - `[AuthenticationMethod <String>]`: 
      - `[AuthenticationMethodDetail <String>]`: 
      - `[AuthenticationStepDateTime <DateTime?>]`: 
      - `[AuthenticationStepRequirement <String>]`: 
      - `[AuthenticationStepResultDetail <String>]`: 
      - `[Succeeded <Boolean?>]`: 
    - `[AuthenticationMethodsUsed <String[]>]`: 
    - `[AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[AuthenticationRequirement <String>]`: 
    - `[AuthenticationRequirementPolicies <IMicrosoftGraphAuthenticationRequirementPolicy[]>]`: 
      - `[Detail <String>]`: 
      - `[RequirementProvider <String>]`: requirementProvider
    - `[ClientAppUsed <String>]`: Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
    - `[ConditionalAccessStatus <String>]`: conditionalAccessStatus
    - `[CorrelationId <String>]`: The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
    - `[CreatedDateTime <DateTime?>]`: Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
    - `[DeviceDetailBrowser <String>]`: Indicates the browser information of the used for signing in.
    - `[DeviceDetailBrowserId <String>]`: 
    - `[DeviceDetailDeviceId <String>]`: Refers to the UniqueID of the device used for signing in.
    - `[DeviceDetailDisplayName <String>]`: Refers to the name of the device used for signing in.
    - `[DeviceDetailIsCompliant <Boolean?>]`: Indicates whether the device is compliant.
    - `[DeviceDetailIsManaged <Boolean?>]`: Indicates whether the device is managed.
    - `[DeviceDetailOperatingSystem <String>]`: Indicates the operating system name and version used for signing in.
    - `[DeviceDetailTrustType <String>]`: Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
    - `[GeoCoordinateAltitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[GeoCoordinateLatitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
    - `[GeoCoordinateLongitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
    - `[IPAddress <String>]`: IP address of the client used to sign in.
    - `[IsInteractive <Boolean?>]`: Indicates if a sign-in is interactive or not.
    - `[LocationCity <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
    - `[LocationCountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
    - `[LocationState <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
    - `[MfaDetailAuthDetail <String>]`: 
    - `[MfaDetailAuthMethod <String>]`: 
    - `[NetworkLocationDetails <IMicrosoftGraphNetworkLocationDetail[]>]`: 
      - `[NetworkNames <String[]>]`: 
      - `[NetworkType <String>]`: networkType
    - `[OriginalRequestId <String>]`: 
    - `[ProcessingTimeInMilliseconds <Int32?>]`: 
    - `[ResourceDisplayName <String>]`: Name of the resource the user signed into.
    - `[ResourceId <String>]`: ID of the resource that the user signed into.
    - `[RiskDetail <String>]`: riskDetail
    - `[RiskEventTypes <String[]>]`: Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
    - `[RiskEventTypesV2 <String[]>]`: The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
    - `[RiskLevelAggregated <String>]`: riskLevel
    - `[RiskLevelDuringSignIn <String>]`: riskLevel
    - `[RiskState <String>]`: riskState
    - `[ServicePrincipalId <String>]`: 
    - `[ServicePrincipalName <String>]`: 
    - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
    - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
    - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
    - `[TokenIssuerName <String>]`: 
    - `[TokenIssuerType <String>]`: tokenIssuerType
    - `[UserAgent <String>]`: 
    - `[UserDisplayName <String>]`: Display name of the user that initiated the sign-in.
    - `[UserId <String>]`: ID of the user that initiated the sign-in.
    - `[UserPrincipalName <String>]`: User principal name of the user that initiated the sign-in.
    - `[Id <String>]`: Read-only.
    - `[TargetTenantId <String>]`: 
  - `[SignIns <IMicrosoftGraphSignIn1[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AlternateSignInName <String>]`: 
    - `[AppDisplayName <String>]`: App name displayed in the Azure Portal.
    - `[AppId <String>]`: Unique GUID representing the app ID in the Azure Active Directory.
    - `[AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>]`: 
    - `[AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>]`: 
    - `[AuthenticationMethodsUsed <String[]>]`: 
    - `[AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[AuthenticationRequirement <String>]`: 
    - `[AuthenticationRequirementPolicies <IMicrosoftGraphAuthenticationRequirementPolicy[]>]`: 
    - `[ClientAppUsed <String>]`: Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
    - `[ConditionalAccessStatus <String>]`: conditionalAccessStatus
    - `[CorrelationId <String>]`: The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
    - `[CreatedDateTime <DateTime?>]`: Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
    - `[DeviceDetailBrowser <String>]`: Indicates the browser information of the used for signing in.
    - `[DeviceDetailBrowserId <String>]`: 
    - `[DeviceDetailDeviceId <String>]`: Refers to the UniqueID of the device used for signing in.
    - `[DeviceDetailDisplayName <String>]`: Refers to the name of the device used for signing in.
    - `[DeviceDetailIsCompliant <Boolean?>]`: Indicates whether the device is compliant.
    - `[DeviceDetailIsManaged <Boolean?>]`: Indicates whether the device is managed.
    - `[DeviceDetailOperatingSystem <String>]`: Indicates the operating system name and version used for signing in.
    - `[DeviceDetailTrustType <String>]`: Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
    - `[GeoCoordinateAltitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[GeoCoordinateLatitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
    - `[GeoCoordinateLongitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
    - `[IPAddress <String>]`: IP address of the client used to sign in.
    - `[IsInteractive <Boolean?>]`: Indicates if a sign-in is interactive or not.
    - `[LocationCity <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
    - `[LocationCountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
    - `[LocationState <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
    - `[MfaDetailAuthDetail <String>]`: 
    - `[MfaDetailAuthMethod <String>]`: 
    - `[NetworkLocationDetails <IMicrosoftGraphNetworkLocationDetail[]>]`: 
    - `[OriginalRequestId <String>]`: 
    - `[ProcessingTimeInMilliseconds <Int32?>]`: 
    - `[ResourceDisplayName <String>]`: Name of the resource the user signed into.
    - `[ResourceId <String>]`: ID of the resource that the user signed into.
    - `[RiskDetail <String>]`: riskDetail
    - `[RiskEventTypes <String[]>]`: Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
    - `[RiskEventTypesV2 <String[]>]`: The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
    - `[RiskLevelAggregated <String>]`: riskLevel
    - `[RiskLevelDuringSignIn <String>]`: riskLevel
    - `[RiskState <String>]`: riskState
    - `[ServicePrincipalId <String>]`: 
    - `[ServicePrincipalName <String>]`: 
    - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
    - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
    - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
    - `[TokenIssuerName <String>]`: 
    - `[TokenIssuerType <String>]`: tokenIssuerType
    - `[UserAgent <String>]`: 
    - `[UserDisplayName <String>]`: Display name of the user that initiated the sign-in.
    - `[UserId <String>]`: ID of the user that initiated the sign-in.
    - `[UserPrincipalName <String>]`: User principal name of the user that initiated the sign-in.

DIRECTORYAUDITS <IMicrosoftGraphDirectoryAudit1[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ActivityDateTime <DateTime?>]`: Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[ActivityDisplayName <String>]`: Indicates the activity name or the operation name (examples: 'Create User' and 'Add member to group'). For full list, see Azure AD activity list.
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Indicates additional details on the activity.
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[AppDisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
  - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
  - `[AppServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
  - `[AppServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
  - `[Category <String>]`: Indicates which resource category that's targeted by the activity. (For example: User Management, Group Management etc..)
  - `[CorrelationId <String>]`: Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.
  - `[LoggedByService <String>]`: Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.
  - `[OperationType <String>]`: 
  - `[Result <String>]`: operationResult
  - `[ResultReason <String>]`: Describes cause of 'failure' or 'timeout' results.
  - `[TargetResources <IMicrosoftGraphTargetResource[]>]`: Indicates information on which resource was changed due to the activity. Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
    - `[DisplayName <String>]`: Indicates the visible name defined for the resource. Typically specified when the resource is created.
    - `[GroupType <String>]`: groupType
    - `[Id <String>]`: Indicates the unique ID of the resource.
    - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.
      - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
      - `[NewValue <String>]`: Indicates the updated value for the propery.
      - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
    - `[Type <String>]`: Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.
    - `[UserPrincipalName <String>]`: When type is set to User, this includes the user name that initiated the action; null for other types.
  - `[UserDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[UserIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserId <String>]`: Unique identifier for the identity.
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

DIRECTORYPROVISIONING <IMicrosoftGraphProvisioningObjectSummary[]>: .
  - `[Id <String>]`: Read-only.
  - `[Action <String>]`: 
  - `[ActivityDateTime <DateTime?>]`: 
  - `[ChangeId <String>]`: 
  - `[CycleId <String>]`: 
  - `[DurationInMilliseconds <Int32?>]`: 
  - `[InitiatedByDisplayName <String>]`: 
  - `[InitiatedById <String>]`: 
  - `[InitiatedByInitiatorType <String>]`: initiatorType
  - `[JobId <String>]`: 
  - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: 
    - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
    - `[NewValue <String>]`: Indicates the updated value for the propery.
    - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
  - `[ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>]`: 
    - `[Description <String>]`: 
    - `[Details <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[Name <String>]`: 
    - `[ProvisioningStepType <String>]`: provisioningStepType
    - `[Status <String>]`: provisioningResult
  - `[ServicePrincipalDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ServicePrincipalId <String>]`: Unique identifier for the identity.
  - `[SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceIdentityDisplayName <String>]`: 
  - `[SourceIdentityId <String>]`: 
  - `[SourceIdentityType <String>]`: 
  - `[SourceSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceSystemDisplayName <String>]`: 
  - `[SourceSystemId <String>]`: 
  - `[StatusInfoStatus <String>]`: provisioningResult
  - `[TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetIdentityDisplayName <String>]`: 
  - `[TargetIdentityId <String>]`: 
  - `[TargetIdentityType <String>]`: 
  - `[TargetSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetSystemDisplayName <String>]`: 
  - `[TargetSystemId <String>]`: 
  - `[TenantId <String>]`: 

PROVISIONING <IMicrosoftGraphProvisioningObjectSummary[]>: .
  - `[Id <String>]`: Read-only.
  - `[Action <String>]`: 
  - `[ActivityDateTime <DateTime?>]`: 
  - `[ChangeId <String>]`: 
  - `[CycleId <String>]`: 
  - `[DurationInMilliseconds <Int32?>]`: 
  - `[InitiatedByDisplayName <String>]`: 
  - `[InitiatedById <String>]`: 
  - `[InitiatedByInitiatorType <String>]`: initiatorType
  - `[JobId <String>]`: 
  - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: 
    - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
    - `[NewValue <String>]`: Indicates the updated value for the propery.
    - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
  - `[ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>]`: 
    - `[Description <String>]`: 
    - `[Details <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[Name <String>]`: 
    - `[ProvisioningStepType <String>]`: provisioningStepType
    - `[Status <String>]`: provisioningResult
  - `[ServicePrincipalDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ServicePrincipalId <String>]`: Unique identifier for the identity.
  - `[SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceIdentityDisplayName <String>]`: 
  - `[SourceIdentityId <String>]`: 
  - `[SourceIdentityType <String>]`: 
  - `[SourceSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceSystemDisplayName <String>]`: 
  - `[SourceSystemId <String>]`: 
  - `[StatusInfoStatus <String>]`: provisioningResult
  - `[TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetIdentityDisplayName <String>]`: 
  - `[TargetIdentityId <String>]`: 
  - `[TargetIdentityType <String>]`: 
  - `[TargetSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetSystemDisplayName <String>]`: 
  - `[TargetSystemId <String>]`: 
  - `[TenantId <String>]`: 

RESTRICTEDSIGNINS <IMicrosoftGraphRestrictedSignIn1[]>: .
  - `[AlternateSignInName <String>]`: 
  - `[AppDisplayName <String>]`: App name displayed in the Azure Portal.
  - `[AppId <String>]`: Unique GUID representing the app ID in the Azure Active Directory.
  - `[AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>]`: 
    - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
    - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
    - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
    - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
    - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
    - `[Id <String>]`: Unique GUID of the conditional access polic.y
    - `[Result <String>]`: 
  - `[AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>]`: 
    - `[AuthenticationMethod <String>]`: 
    - `[AuthenticationMethodDetail <String>]`: 
    - `[AuthenticationStepDateTime <DateTime?>]`: 
    - `[AuthenticationStepRequirement <String>]`: 
    - `[AuthenticationStepResultDetail <String>]`: 
    - `[Succeeded <Boolean?>]`: 
  - `[AuthenticationMethodsUsed <String[]>]`: 
  - `[AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[AuthenticationRequirement <String>]`: 
  - `[AuthenticationRequirementPolicies <IMicrosoftGraphAuthenticationRequirementPolicy[]>]`: 
    - `[Detail <String>]`: 
    - `[RequirementProvider <String>]`: requirementProvider
  - `[ClientAppUsed <String>]`: Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
  - `[ConditionalAccessStatus <String>]`: conditionalAccessStatus
  - `[CorrelationId <String>]`: The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
  - `[CreatedDateTime <DateTime?>]`: Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
  - `[DeviceDetailBrowser <String>]`: Indicates the browser information of the used for signing in.
  - `[DeviceDetailBrowserId <String>]`: 
  - `[DeviceDetailDeviceId <String>]`: Refers to the UniqueID of the device used for signing in.
  - `[DeviceDetailDisplayName <String>]`: Refers to the name of the device used for signing in.
  - `[DeviceDetailIsCompliant <Boolean?>]`: Indicates whether the device is compliant.
  - `[DeviceDetailIsManaged <Boolean?>]`: Indicates whether the device is managed.
  - `[DeviceDetailOperatingSystem <String>]`: Indicates the operating system name and version used for signing in.
  - `[DeviceDetailTrustType <String>]`: Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
  - `[GeoCoordinateAltitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
  - `[GeoCoordinateLatitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
  - `[GeoCoordinateLongitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
  - `[IPAddress <String>]`: IP address of the client used to sign in.
  - `[IsInteractive <Boolean?>]`: Indicates if a sign-in is interactive or not.
  - `[LocationCity <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[LocationCountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
  - `[LocationState <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[MfaDetailAuthDetail <String>]`: 
  - `[MfaDetailAuthMethod <String>]`: 
  - `[NetworkLocationDetails <IMicrosoftGraphNetworkLocationDetail[]>]`: 
    - `[NetworkNames <String[]>]`: 
    - `[NetworkType <String>]`: networkType
  - `[OriginalRequestId <String>]`: 
  - `[ProcessingTimeInMilliseconds <Int32?>]`: 
  - `[ResourceDisplayName <String>]`: Name of the resource the user signed into.
  - `[ResourceId <String>]`: ID of the resource that the user signed into.
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskEventTypes <String[]>]`: Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
  - `[RiskEventTypesV2 <String[]>]`: The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
  - `[RiskLevelAggregated <String>]`: riskLevel
  - `[RiskLevelDuringSignIn <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[ServicePrincipalId <String>]`: 
  - `[ServicePrincipalName <String>]`: 
  - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
  - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
  - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
  - `[TokenIssuerName <String>]`: 
  - `[TokenIssuerType <String>]`: tokenIssuerType
  - `[UserAgent <String>]`: 
  - `[UserDisplayName <String>]`: Display name of the user that initiated the sign-in.
  - `[UserId <String>]`: ID of the user that initiated the sign-in.
  - `[UserPrincipalName <String>]`: User principal name of the user that initiated the sign-in.
  - `[Id <String>]`: Read-only.
  - `[TargetTenantId <String>]`: 

SIGNINS <IMicrosoftGraphSignIn1[]>: Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AlternateSignInName <String>]`: 
  - `[AppDisplayName <String>]`: App name displayed in the Azure Portal.
  - `[AppId <String>]`: Unique GUID representing the app ID in the Azure Active Directory.
  - `[AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>]`: 
    - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
    - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
    - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
    - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
    - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
    - `[Id <String>]`: Unique GUID of the conditional access polic.y
    - `[Result <String>]`: 
  - `[AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>]`: 
    - `[AuthenticationMethod <String>]`: 
    - `[AuthenticationMethodDetail <String>]`: 
    - `[AuthenticationStepDateTime <DateTime?>]`: 
    - `[AuthenticationStepRequirement <String>]`: 
    - `[AuthenticationStepResultDetail <String>]`: 
    - `[Succeeded <Boolean?>]`: 
  - `[AuthenticationMethodsUsed <String[]>]`: 
  - `[AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>]`: 
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[AuthenticationRequirement <String>]`: 
  - `[AuthenticationRequirementPolicies <IMicrosoftGraphAuthenticationRequirementPolicy[]>]`: 
    - `[Detail <String>]`: 
    - `[RequirementProvider <String>]`: requirementProvider
  - `[ClientAppUsed <String>]`: Identifies the legacy client used for sign-in activity.  Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.
  - `[ConditionalAccessStatus <String>]`: conditionalAccessStatus
  - `[CorrelationId <String>]`: The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.
  - `[CreatedDateTime <DateTime?>]`: Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.
  - `[DeviceDetailBrowser <String>]`: Indicates the browser information of the used for signing in.
  - `[DeviceDetailBrowserId <String>]`: 
  - `[DeviceDetailDeviceId <String>]`: Refers to the UniqueID of the device used for signing in.
  - `[DeviceDetailDisplayName <String>]`: Refers to the name of the device used for signing in.
  - `[DeviceDetailIsCompliant <Boolean?>]`: Indicates whether the device is compliant.
  - `[DeviceDetailIsManaged <Boolean?>]`: Indicates whether the device is managed.
  - `[DeviceDetailOperatingSystem <String>]`: Indicates the operating system name and version used for signing in.
  - `[DeviceDetailTrustType <String>]`: Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
  - `[GeoCoordinateAltitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
  - `[GeoCoordinateLatitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
  - `[GeoCoordinateLongitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
  - `[IPAddress <String>]`: IP address of the client used to sign in.
  - `[IsInteractive <Boolean?>]`: Indicates if a sign-in is interactive or not.
  - `[LocationCity <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[LocationCountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
  - `[LocationState <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[MfaDetailAuthDetail <String>]`: 
  - `[MfaDetailAuthMethod <String>]`: 
  - `[NetworkLocationDetails <IMicrosoftGraphNetworkLocationDetail[]>]`: 
    - `[NetworkNames <String[]>]`: 
    - `[NetworkType <String>]`: networkType
  - `[OriginalRequestId <String>]`: 
  - `[ProcessingTimeInMilliseconds <Int32?>]`: 
  - `[ResourceDisplayName <String>]`: Name of the resource the user signed into.
  - `[ResourceId <String>]`: ID of the resource that the user signed into.
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskEventTypes <String[]>]`: Risk event types associated with the sign-in. The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, and unknownFutureValue.
  - `[RiskEventTypesV2 <String[]>]`: The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue.
  - `[RiskLevelAggregated <String>]`: riskLevel
  - `[RiskLevelDuringSignIn <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[ServicePrincipalId <String>]`: 
  - `[ServicePrincipalName <String>]`: 
  - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
  - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
  - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
  - `[TokenIssuerName <String>]`: 
  - `[TokenIssuerType <String>]`: tokenIssuerType
  - `[UserAgent <String>]`: 
  - `[UserDisplayName <String>]`: Display name of the user that initiated the sign-in.
  - `[UserId <String>]`: ID of the user that initiated the sign-in.
  - `[UserPrincipalName <String>]`: User principal name of the user that initiated the sign-in.

## RELATED LINKS

