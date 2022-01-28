---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprintreport
schema: 2.0.0
---

# Update-MgPrintReport

## SYNOPSIS
Update the navigation property reports in print

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrintReport [-AdditionalProperties <Hashtable>]
 [-ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]
 [-AuthenticationMethods <IMicrosoftGraphAuthenticationMethodsRoot>]
 [-CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]
 [-DailyPrintUsageByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]
 [-DailyPrintUsageByUser <IMicrosoftGraphPrintUsageByUser[]>]
 [-DailyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]
 [-DailyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageByUser[]>] [-Id <String>]
 [-MonthlyPrintUsageByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]
 [-MonthlyPrintUsageByUser <IMicrosoftGraphPrintUsageByUser[]>]
 [-MonthlyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]
 [-MonthlyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageByUser[]>]
 [-UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPrintReport -BodyParameter <IMicrosoftGraphReportRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property reports in print

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationSignInDetailedSummary
Represents a detailed summary of an application sign-in.
To construct, please use Get-Help -Online and see NOTES section for APPLICATIONSIGNINDETAILEDSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplicationSignInDetailedSummary[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AuthenticationMethods
authenticationMethodsRoot
To construct, please use Get-Help -Online and see NOTES section for AUTHENTICATIONMETHODS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAuthenticationMethodsRoot
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
reportRoot
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CredentialUserRegistrationDetails
Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.
To construct, please use Get-Help -Online and see NOTES section for CREDENTIALUSERREGISTRATIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCredentialUserRegistrationDetails[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageByPrinter
.
To construct, please use Get-Help -Online and see NOTES section for DAILYPRINTUSAGEBYPRINTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByPrinter[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageByUser
.
To construct, please use Get-Help -Online and see NOTES section for DAILYPRINTUSAGEBYUSER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByUser[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageSummariesByPrinter
.
To construct, please use Get-Help -Online and see NOTES section for DAILYPRINTUSAGESUMMARIESBYPRINTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByPrinter[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DailyPrintUsageSummariesByUser
.
To construct, please use Get-Help -Online and see NOTES section for DAILYPRINTUSAGESUMMARIESBYUSER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByUser[]
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

### -MonthlyPrintUsageByPrinter
.
To construct, please use Get-Help -Online and see NOTES section for MONTHLYPRINTUSAGEBYPRINTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByPrinter[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyPrintUsageByUser
.
To construct, please use Get-Help -Online and see NOTES section for MONTHLYPRINTUSAGEBYUSER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByUser[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyPrintUsageSummariesByPrinter
.
To construct, please use Get-Help -Online and see NOTES section for MONTHLYPRINTUSAGESUMMARIESBYPRINTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByPrinter[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MonthlyPrintUsageSummariesByUser
.
To construct, please use Get-Help -Online and see NOTES section for MONTHLYPRINTUSAGESUMMARIESBYUSER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUsageByUser[]
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

### -UserCredentialUsageDetails
Represents the self-service password reset (SSPR) usage for a given tenant.
To construct, please use Get-Help -Online and see NOTES section for USERCREDENTIALUSAGEDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserCredentialUsageDetails[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLICATIONSIGNINDETAILEDSUMMARY <IMicrosoftGraphApplicationSignInDetailedSummary[]>: Represents a detailed summary of an application sign-in.
  - `[Id <String>]`: Read-only.
  - `[AggregatedEventDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[AppDisplayName <String>]`: Name of the application that the user signed in to.
  - `[AppId <String>]`: ID of the application that the user signed in to.
  - `[SignInCount <Int64?>]`: Count of sign-ins made by the application.
  - `[Status <IMicrosoftGraphSignInStatus>]`: signInStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AdditionalDetails <String>]`: Provides additional details on the sign-in activity
    - `[ErrorCode <Int32?>]`: Provides the 5-6 digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
    - `[FailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.

AUTHENTICATIONMETHODS <IMicrosoftGraphAuthenticationMethodsRoot>: authenticationMethodsRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[UserRegistrationDetails <IMicrosoftGraphUserRegistrationDetails[]>]`: Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).
    - `[Id <String>]`: Read-only.
    - `[IsMfaCapable <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).
    - `[IsMfaRegistered <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).
    - `[IsPasswordlessCapable <Boolean?>]`: Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).
    - `[IsSsprCapable <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).
    - `[IsSsprEnabled <Boolean?>]`: Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).
    - `[IsSsprRegistered <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).
    - `[MethodsRegistered <String[]>]`: Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).
    - `[UserDisplayName <String>]`: The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.
    - `[UserPrincipalName <String>]`: The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.

BODYPARAMETER <IMicrosoftGraphReportRoot>: reportRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]`: Represents a detailed summary of an application sign-in.
    - `[Id <String>]`: Read-only.
    - `[AggregatedEventDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[AppDisplayName <String>]`: Name of the application that the user signed in to.
    - `[AppId <String>]`: ID of the application that the user signed in to.
    - `[SignInCount <Int64?>]`: Count of sign-ins made by the application.
    - `[Status <IMicrosoftGraphSignInStatus>]`: signInStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AdditionalDetails <String>]`: Provides additional details on the sign-in activity
      - `[ErrorCode <Int32?>]`: Provides the 5-6 digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
      - `[FailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
  - `[AuthenticationMethods <IMicrosoftGraphAuthenticationMethodsRoot>]`: authenticationMethodsRoot
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: Read-only.
    - `[UserRegistrationDetails <IMicrosoftGraphUserRegistrationDetails[]>]`: Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).
      - `[Id <String>]`: Read-only.
      - `[IsMfaCapable <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).
      - `[IsMfaRegistered <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).
      - `[IsPasswordlessCapable <Boolean?>]`: Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).
      - `[IsSsprCapable <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).
      - `[IsSsprEnabled <Boolean?>]`: Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).
      - `[IsSsprRegistered <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).
      - `[MethodsRegistered <String[]>]`: Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).
      - `[UserDisplayName <String>]`: The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.
      - `[UserPrincipalName <String>]`: The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.
  - `[CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]`: Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.
    - `[Id <String>]`: Read-only.
    - `[AuthMethods <String[]>]`: Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.
    - `[IsCapable <Boolean?>]`: Indicates whether the user is ready to perform self-service password reset or MFA.
    - `[IsEnabled <Boolean?>]`: Indicates whether the user enabled to perform self-service password reset.
    - `[IsMfaRegistered <Boolean?>]`: Indicates whether the user is registered for MFA.
    - `[IsRegistered <Boolean?>]`: Indicates whether the user has registered any authentication methods for self-service password reset.
    - `[UserDisplayName <String>]`: Provides the user name of the corresponding user.
    - `[UserPrincipalName <String>]`: Provides the user principal name of the corresponding user.
  - `[DailyPrintUsageByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]`: 
    - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
    - `[CompletedColorJobCount <Int64?>]`: 
    - `[IncompleteJobCount <Int64?>]`: 
    - `[UsageDate <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[PrinterId <String>]`: 
  - `[DailyPrintUsageByUser <IMicrosoftGraphPrintUsageByUser[]>]`: 
    - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
    - `[CompletedColorJobCount <Int64?>]`: 
    - `[IncompleteJobCount <Int64?>]`: 
    - `[UsageDate <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[UserPrincipalName <String>]`: The UPN of the user represented by these statistics.
  - `[DailyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]`: 
  - `[DailyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageByUser[]>]`: 
  - `[MonthlyPrintUsageByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]`: 
  - `[MonthlyPrintUsageByUser <IMicrosoftGraphPrintUsageByUser[]>]`: 
  - `[MonthlyPrintUsageSummariesByPrinter <IMicrosoftGraphPrintUsageByPrinter[]>]`: 
  - `[MonthlyPrintUsageSummariesByUser <IMicrosoftGraphPrintUsageByUser[]>]`: 
  - `[UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>]`: Represents the self-service password reset (SSPR) usage for a given tenant.
    - `[Id <String>]`: Read-only.
    - `[AuthMethod <String>]`: usageAuthMethod
    - `[EventDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[FailureReason <String>]`: Provides the failure reason for the corresponding reset or registration workflow.
    - `[Feature <String>]`: featureType
    - `[IsSuccess <Boolean?>]`: Indicates success or failure of the workflow.
    - `[UserDisplayName <String>]`: User name of the user performing the reset or registration workflow.
    - `[UserPrincipalName <String>]`: User principal name of the user performing the reset or registration workflow.

CREDENTIALUSERREGISTRATIONDETAILS <IMicrosoftGraphCredentialUserRegistrationDetails[]>: Details of the usage of self-service password reset and multi-factor authentication (MFA) for all registered users.
  - `[Id <String>]`: Read-only.
  - `[AuthMethods <String[]>]`: Represents the authentication method that the user has registered. Possible values are: email, mobilePhone, officePhone,  securityQuestion (only used for self-service password reset), appNotification,  appCode, alternateMobilePhone (supported only in registration),  fido,  appPassword,  unknownFutureValue.
  - `[IsCapable <Boolean?>]`: Indicates whether the user is ready to perform self-service password reset or MFA.
  - `[IsEnabled <Boolean?>]`: Indicates whether the user enabled to perform self-service password reset.
  - `[IsMfaRegistered <Boolean?>]`: Indicates whether the user is registered for MFA.
  - `[IsRegistered <Boolean?>]`: Indicates whether the user has registered any authentication methods for self-service password reset.
  - `[UserDisplayName <String>]`: Provides the user name of the corresponding user.
  - `[UserPrincipalName <String>]`: Provides the user principal name of the corresponding user.

DAILYPRINTUSAGEBYPRINTER <IMicrosoftGraphPrintUsageByPrinter[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[PrinterId <String>]`: 

DAILYPRINTUSAGEBYUSER <IMicrosoftGraphPrintUsageByUser[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[UserPrincipalName <String>]`: The UPN of the user represented by these statistics.

DAILYPRINTUSAGESUMMARIESBYPRINTER <IMicrosoftGraphPrintUsageByPrinter[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[PrinterId <String>]`: 

DAILYPRINTUSAGESUMMARIESBYUSER <IMicrosoftGraphPrintUsageByUser[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[UserPrincipalName <String>]`: The UPN of the user represented by these statistics.

MONTHLYPRINTUSAGEBYPRINTER <IMicrosoftGraphPrintUsageByPrinter[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[PrinterId <String>]`: 

MONTHLYPRINTUSAGEBYUSER <IMicrosoftGraphPrintUsageByUser[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[UserPrincipalName <String>]`: The UPN of the user represented by these statistics.

MONTHLYPRINTUSAGESUMMARIESBYPRINTER <IMicrosoftGraphPrintUsageByPrinter[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[PrinterId <String>]`: 

MONTHLYPRINTUSAGESUMMARIESBYUSER <IMicrosoftGraphPrintUsageByUser[]>: .
  - `[CompletedBlackAndWhiteJobCount <Int64?>]`: 
  - `[CompletedColorJobCount <Int64?>]`: 
  - `[IncompleteJobCount <Int64?>]`: 
  - `[UsageDate <DateTime?>]`: 
  - `[Id <String>]`: Read-only.
  - `[UserPrincipalName <String>]`: The UPN of the user represented by these statistics.

USERCREDENTIALUSAGEDETAILS <IMicrosoftGraphUserCredentialUsageDetails[]>: Represents the self-service password reset (SSPR) usage for a given tenant.
  - `[Id <String>]`: Read-only.
  - `[AuthMethod <String>]`: usageAuthMethod
  - `[EventDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[FailureReason <String>]`: Provides the failure reason for the corresponding reset or registration workflow.
  - `[Feature <String>]`: featureType
  - `[IsSuccess <Boolean?>]`: Indicates success or failure of the workflow.
  - `[UserDisplayName <String>]`: User name of the user performing the reset or registration workflow.
  - `[UserPrincipalName <String>]`: User principal name of the user performing the reset or registration workflow.

## RELATED LINKS

