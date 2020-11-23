---
external help file: Microsoft.Graph.Identity.SignIns-help.xml
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgtrustframeworkkeysetactivekey
schema: 2.0.0
---

# Get-MgTrustFrameworkKeySetActiveKey

## SYNOPSIS
Invoke function getActiveKey

## SYNTAX

### Get (Default)
```
Get-MgTrustFrameworkKeySetActiveKey -TrustFrameworkKeySetId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgTrustFrameworkKeySetActiveKey -InputObject <IIdentitySignInsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getActiveKey

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IIdentitySignInsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -TrustFrameworkKeySetId
key: id of trustFrameworkKeySet

```yaml
Type: String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IIdentitySignInsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTrustFrameworkKey
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IIdentitySignInsIdentity\>: Identity Parameter
  \[ActivityBasedTimeoutPolicyId \<String\>\]: key: id of activityBasedTimeoutPolicy
  \[AuthenticationContextClassReferenceId \<String\>\]: key: id of authenticationContextClassReference
  \[AuthenticationMethodId \<String\>\]: key: id of authenticationMethod
  \[AuthorizationPolicyId \<String\>\]: key: id of authorizationPolicy
  \[ClaimsMappingPolicyId \<String\>\]: key: id of claimsMappingPolicy
  \[ConditionalAccessPolicyId \<String\>\]: key: id of conditionalAccessPolicy
  \[DataLossPreventionPolicyId \<String\>\]: key: id of dataLossPreventionPolicy
  \[DataPolicyOperationId \<String\>\]: key: id of dataPolicyOperation
  \[EmailAuthenticationMethodId \<String\>\]: key: id of emailAuthenticationMethod
  \[Fido2AuthenticationMethodId \<String\>\]: key: id of fido2AuthenticationMethod
  \[HomeRealmDiscoveryPolicyId \<String\>\]: key: id of homeRealmDiscoveryPolicy
  \[IdentityProviderId \<String\>\]: key: id of identityProvider
  \[IdentityUserFlowId \<String\>\]: key: id of identityUserFlow
  \[InformationProtectionLabelId \<String\>\]: key: id of informationProtectionLabel
  \[LongRunningOperationId \<String\>\]: key: id of longRunningOperation
  \[NamedLocationId \<String\>\]: key: id of namedLocation
  \[OAuth2PermissionGrantId \<String\>\]: key: id of oAuth2PermissionGrant
  \[OrganizationId \<String\>\]: key: id of organization
  \[PasswordAuthenticationMethodId \<String\>\]: key: id of passwordAuthenticationMethod
  \[PasswordlessMicrosoftAuthenticatorAuthenticationMethodId \<String\>\]: key: id of passwordlessMicrosoftAuthenticatorAuthenticationMethod
  \[PermissionGrantConditionSetId \<String\>\]: key: id of permissionGrantConditionSet
  \[PermissionGrantPolicyId \<String\>\]: key: id of permissionGrantPolicy
  \[PhoneAuthenticationMethodId \<String\>\]: key: id of phoneAuthenticationMethod
  \[PrivateLinkResourcePolicyId \<String\>\]: key: id of privateLinkResourcePolicy
  \[RiskDetectionId \<String\>\]: key: id of riskDetection
  \[RiskyUserHistoryItemId \<String\>\]: key: id of riskyUserHistoryItem
  \[RiskyUserId \<String\>\]: key: id of riskyUser
  \[SensitivityLabelId \<String\>\]: key: id of sensitivityLabel
  \[SensitivityLabelId1 \<String\>\]: key: id of sensitivityLabel
  \[ThreatAssessmentRequestId \<String\>\]: key: id of threatAssessmentRequest
  \[ThreatAssessmentResultId \<String\>\]: key: id of threatAssessmentResult
  \[TokenIssuancePolicyId \<String\>\]: key: id of tokenIssuancePolicy
  \[TokenLifetimePolicyId \<String\>\]: key: id of tokenLifetimePolicy
  \[TrustFrameworkKeySetId \<String\>\]: key: id of trustFrameworkKeySet
  \[TrustFrameworkPolicyId \<String\>\]: key: id of trustFrameworkPolicy
  \[UserId \<String\>\]: key: id of user

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgtrustframeworkkeysetactivekey](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgtrustframeworkkeysetactivekey)

