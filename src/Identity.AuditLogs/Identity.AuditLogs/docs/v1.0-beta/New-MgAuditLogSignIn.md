---
external help file:
Module Name: Microsoft.Graph.Identity.AuditLogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.auditlogs/new-mgauditlogsignin
schema: 2.0.0
---

# New-MgAuditLogSignIn

## SYNOPSIS
Create new navigation property to signIns for auditLogs

## SYNTAX

### CreateExpanded (Default)
```
New-MgAuditLogSignIn [-AlternateSignInName <String>] [-AppDisplayName <String>] [-AppId <String>]
 [-AppliedConditionalAccessPolicies <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>]
 [-AuthenticationDetails <IMicrosoftGraphAuthenticationDetail[]>] [-AuthenticationMethodsUsed <String[]>]
 [-AuthenticationProcessingDetails <IMicrosoftGraphKeyValue[]>] [-AuthenticationRequirement <String>]
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
 [-ResourceId <String>] [-RiskDetail <String>] [-RiskEventTypes <String[]>] [-RiskEventTypesV2 <String[]>]
 [-RiskLevelAggregated <String>] [-RiskLevelDuringSignIn <String>] [-RiskState <String>]
 [-ServicePrincipalId <String>] [-ServicePrincipalName <String>] [-StatusAdditionalDetails <String>]
 [-StatusErrorCode <Int32>] [-StatusFailureReason <String>] [-TokenIssuerName <String>]
 [-TokenIssuerType <String>] [-UserAgent <String>] [-UserDisplayName <String>] [-UserId <String>]
 [-UserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAuditLogSignIn -BodyParameter <IMicrosoftGraphSignIn1> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to signIns for auditLogs

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
```

### -AppliedConditionalAccessPolicies
.
To construct, see NOTES section for APPLIEDCONDITIONALACCESSPOLICIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppliedConditionalAccessPolicy1[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -AuthenticationRequirement
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
```

### -BodyParameter
signIn
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSignIn1
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
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
```

### -RiskEventTypesV2
The list of risk event types associated with the sign-in.
Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic, or unknownFutureValue.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSignIn1

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSignIn1

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLIEDCONDITIONALACCESSPOLICIES <IMicrosoftGraphAppliedConditionalAccessPolicy1[]>: .
  - `[ConditionsNotSatisfied <String>]`: conditionalAccessConditions
  - `[ConditionsSatisfied <String>]`: conditionalAccessConditions
  - `[DisplayName <String>]`: Refers to the Name of the conditional access policy (example: 'Require MFA for Salesforce').
  - `[EnforcedGrantControls <String[]>]`: Refers to the grant controls enforced by the conditional access policy (example: 'Require multi-factor authentication').
  - `[EnforcedSessionControls <String[]>]`: Refers to the session controls enforced by the conditional access policy (example: 'Require app enforced controls').
  - `[Id <String>]`: Unique GUID of the conditional access polic.y
  - `[Result <String>]`: 

AUTHENTICATIONDETAILS <IMicrosoftGraphAuthenticationDetail[]>: .
  - `[AuthenticationMethod <String>]`: 
  - `[AuthenticationMethodDetail <String>]`: 
  - `[AuthenticationStepDateTime <DateTime?>]`: 
  - `[AuthenticationStepRequirement <String>]`: 
  - `[AuthenticationStepResultDetail <String>]`: 
  - `[Succeeded <Boolean?>]`: 

AUTHENTICATIONPROCESSINGDETAILS <IMicrosoftGraphKeyValue[]>: .
  - `[Key <String>]`: Key for the key-value pair.
  - `[Value <String>]`: Value for the key-value pair.

AUTHENTICATIONREQUIREMENTPOLICIES <IMicrosoftGraphAuthenticationRequirementPolicy[]>: .
  - `[Detail <String>]`: 
  - `[RequirementProvider <String>]`: requirementProvider

BODYPARAMETER <IMicrosoftGraphSignIn1>: signIn
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

NETWORKLOCATIONDETAILS <IMicrosoftGraphNetworkLocationDetail[]>: .
  - `[NetworkNames <String[]>]`: 
  - `[NetworkType <String>]`: networkType

## RELATED LINKS

