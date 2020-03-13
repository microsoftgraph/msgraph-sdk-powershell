---
external help file:
Module Name: Microsoft.Graph.Identity.AuditLogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.auditlogs/new-mgauditlogrestrictedsignin
schema: 2.0.0
---

# New-MgAuditLogRestrictedSignIn

## SYNOPSIS
Create new navigation property to restrictedSignIns for auditLogs

## SYNTAX

### CreateExpanded (Default)
```
New-MgAuditLogRestrictedSignIn [-AlternateSignInName <String>] [-AppDisplayName <String>] [-AppId <String>]
 [-AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy[]>]
 [-AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>] [-AuthenticationMethodsUsed <String[]>]
 [-AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>]
 [-AuthenticationRequirementPolicies <IMicrosoftGraphAuthenticationRequirementPolicy[]>]
 [-ClientAppUsed <String>] [-ConditionalAccessStatus <String>] [-CorrelationId <String>]
 [-CreatedDateTime <DateTime>] [-DeviceDetailBrowser <String>] [-DeviceDetailBrowserId <String>]
 [-DeviceDetailDeviceId <String>] [-DeviceDetailDisplayName <String>] [-DeviceDetailIsCompliant]
 [-DeviceDetailIsManaged] [-DeviceDetailOperatingSystem <String>] [-DeviceDetailTrustType <String>]
 [-GeoCoordinateAltitude <Double>] [-GeoCoordinateLatitude <Double>] [-GeoCoordinateLongitude <Double>]
 [-Id <String>] [-IPAddress <String>] [-IsInteractive] [-LocationCity <String>]
 [-LocationCountryOrRegion <String>] [-LocationState <String>] [-MfaDetailAuthDetail <String>]
 [-MfaDetailAuthMethod <String>] [-NetworkLocationDetails <IMicrosoftGraphNetworkLocationDetail[]>]
 [-OriginalRequestId <String>] [-ProcessingTimeInMilliseconds <Int32>] [-ResourceDisplayName <String>]
 [-ResourceId <String>] [-RiskDetail <String>] [-RiskEventTypes <String[]>] [-RiskLevelAggregated <String>]
 [-RiskLevelDuringSignIn <String>] [-RiskState <String>] [-ServicePrincipalId <String>]
 [-ServicePrincipalName <String>] [-StatusAdditionalDetails <String>] [-StatusErrorCode <Int32>]
 [-StatusFailureReason <String>] [-TargetTenantId <String>] [-TokenIssuerName <String>]
 [-TokenIssuerType <String>] [-UserAgent <String>] [-UserDisplayName <String>] [-UserId <String>]
 [-UserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAuditLogRestrictedSignIn -BodyParameter <IMicrosoftGraphRestrictedSignIn> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to restrictedSignIns for auditLogs

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

### -AlternateSignInName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppDisplayName
App name displayed in the Azure Portal.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppId
Unique GUID representing the app ID in the Azure Active Directory.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppliedConditionalAccessPolicies
.
To construct, see NOTES section for APPLIEDCONDITIONALACCESSPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppliedConditionalAccessPolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AuthenticationDetails
.
To construct, see NOTES section for AUTHENTICATIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationDetail[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AuthenticationMethodsUsed
.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AuthenticationProcessingDetails
.
To construct, see NOTES section for AUTHENTICATIONPROCESSINGDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AuthenticationRequirementPolicies
.
To construct, see NOTES section for AUTHENTICATIONREQUIREMENTPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationRequirementPolicy[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
restrictedSignIn
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedSignIn
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ClientAppUsed
Identifies the legacy client used for sign-in activity.
Includes Browser, Exchange Active Sync, modern clients, IMAP, MAPI, SMTP, and POP.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ConditionalAccessStatus
conditionalAccessStatus

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CorrelationId
The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
Date and time (UTC) the sign-in was initiated.
Example: midnight on Jan 1, 2014 is reported as '2014-01-01T00:00:00Z'.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailBrowser
Indicates the browser information of the used for signing in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailBrowserId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailDeviceId
Refers to the UniqueID of the device used for signing in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailDisplayName
Refers to the name of the device used for signing in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailIsCompliant
Indicates whether the device is compliant.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailIsManaged
Indicates whether the device is managed.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailOperatingSystem
Indicates the operating system name and version used for signing in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeviceDetailTrustType
Provides information about whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GeoCoordinateAltitude
Optional.
The altitude (height), in feet, above sea level for the item.
Read-only.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GeoCoordinateLatitude
Optional.
The latitude, in decimal, for the item.
Read-only.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GeoCoordinateLongitude
Optional.
The longitude, in decimal, for the item.
Read-only.

```yaml
Type: System.Double
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IPAddress
IP address of the client used to sign in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -IsInteractive
Indicates if a sign-in is interactive or not.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LocationCity
Provides the city where the sign-in originated.
This is calculated using latitude/longitude information from the sign-in activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LocationCountryOrRegion
Provides the country code info (2 letter code) where the sign-in originated.
This is calculated using latitude/longitude information from the sign-in activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -LocationState
Provides the State where the sign-in originated.
This is calculated using latitude/longitude information from the sign-in activity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MfaDetailAuthDetail
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MfaDetailAuthMethod
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -NetworkLocationDetails
.
To construct, see NOTES section for NETWORKLOCATIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphNetworkLocationDetail[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OriginalRequestId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProcessingTimeInMilliseconds
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceDisplayName
Name of the resource the user signed into.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceId
ID of the resource that the user signed into.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskDetail
riskDetail

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskEventTypes
Risk event types associated with the sign-in.
The possible values are: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic, and unknownFutureValue.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskLevelAggregated
riskLevel

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskLevelDuringSignIn
riskLevel

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -RiskState
riskState

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StatusAdditionalDetails
Provides additional details on the sign-in activity

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StatusErrorCode
Provides the 5-6digit error code that's generated during a sign-in failure.
Check out the list of error codes and messages.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StatusFailureReason
Provides the error message or the reason for failure for the corresponding sign-in activity.
Check out the list of error codes and messages.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetTenantId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenIssuerName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TokenIssuerType
tokenIssuerType

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserAgent
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserDisplayName
Display name of the user that initiated the sign-in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
ID of the user that initiated the sign-in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserPrincipalName
User principal name of the user that initiated the sign-in.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedSignIn

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRestrictedSignIn

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### APPLIEDCONDITIONALACCESSPOLICIES <IMicrosoftGraphAppliedConditionalAccessPolicy[]>: .
  - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
  - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
  - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
  - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
  - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
  - `[Id <String>]`: Unique GUID of the conditional access polic.y
  - `[Result <String>]`: appliedConditionalAccessPolicyResult

#### AUTHENTICATIONDETAILS <IMicrosoftGraphAuthenticationDetail[]>: .
  - `[AuthenticationMethod <String>]`: 
  - `[AuthenticationMethodDetail <String>]`: 
  - `[AuthenticationStepDateTime <DateTime?>]`: 
  - `[AuthenticationStepRequirement <String>]`: 
  - `[AuthenticationStepResultDetail <String>]`: 
  - `[Succeeded <Boolean?>]`: 

#### AUTHENTICATIONPROCESSINGDETAILS <IMicrosoftGraphKeyValue[]>: .
  - `[Key <String>]`: Key for the key-value pair.
  - `[Value <String>]`: Value for the key-value pair.

#### AUTHENTICATIONREQUIREMENTPOLICIES <IMicrosoftGraphAuthenticationRequirementPolicy[]>: .
  - `[Detail <String>]`: 
  - `[RequirementProvider <String>]`: requirementProvider

#### BODYPARAMETER <IMicrosoftGraphRestrictedSignIn>: restrictedSignIn
  - `[AlternateSignInName <String>]`: 
  - `[AppDisplayName <String>]`: App name displayed in the Azure Portal.
  - `[AppId <String>]`: Unique GUID representing the app ID in the Azure Active Directory.
  - `[AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy[]>]`: 
    - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
    - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
    - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
    - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
    - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
    - `[Id <String>]`: Unique GUID of the conditional access polic.y
    - `[Result <String>]`: appliedConditionalAccessPolicyResult
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

#### NETWORKLOCATIONDETAILS <IMicrosoftGraphNetworkLocationDetail[]>: .
  - `[NetworkNames <String[]>]`: 
  - `[NetworkType <String>]`: networkType

## RELATED LINKS

