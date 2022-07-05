---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/update-mgreportauthenticationmethoduserregistrationdetail
schema: 2.0.0
---

# Update-MgReportAuthenticationMethodUserRegistrationDetail

## SYNOPSIS
Update the navigation property userRegistrationDetails in reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgReportAuthenticationMethodUserRegistrationDetail -UserRegistrationDetailsId <String>
 [-AdditionalProperties <Hashtable>] [-DefaultMfaMethod <String>] [-Id <String>] [-IsMfaCapable]
 [-IsMfaRegistered] [-IsPasswordlessCapable] [-IsSsprCapable] [-IsSsprEnabled] [-IsSsprRegistered]
 [-MethodsRegistered <String[]>] [-UserDisplayName <String>] [-UserPrincipalName <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgReportAuthenticationMethodUserRegistrationDetail -UserRegistrationDetailsId <String>
 -BodyParameter <IMicrosoftGraphUserRegistrationDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgReportAuthenticationMethodUserRegistrationDetail -InputObject <IReportsIdentity>
 -BodyParameter <IMicrosoftGraphUserRegistrationDetails> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgReportAuthenticationMethodUserRegistrationDetail -InputObject <IReportsIdentity>
 [-AdditionalProperties <Hashtable>] [-DefaultMfaMethod <String>] [-Id <String>] [-IsMfaCapable]
 [-IsMfaRegistered] [-IsPasswordlessCapable] [-IsSsprCapable] [-IsSsprEnabled] [-IsSsprRegistered]
 [-MethodsRegistered <String[]>] [-UserDisplayName <String>] [-UserPrincipalName <String>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property userRegistrationDetails in reports

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
userRegistrationDetails
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserRegistrationDetails
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultMfaMethod
defaultMfaMethodType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: Microsoft.Graph.PowerShell.Models.IReportsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsMfaCapable
Whether the user has registered a strong authentication method for multi-factor authentication.
The method must be allowed by the authentication methods policy.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsMfaRegistered
Whether the user has registered a strong authentication method for multi-factor authentication.
The method may not necessarily be allowed by the authentication methods policy.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPasswordlessCapable
Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSsprCapable
Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSsprEnabled
Whether the user is allowed to perform self-service password reset by policy.
The user may not necessarily have registered the required number of authentication methods for self-service password reset.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsSsprRegistered
Whether the user has registered the required number of authentication methods for self-service password reset.
The user may not necessarily be allowed to perform self-service password reset by policy.
Supports $filter (eq).

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MethodsRegistered
Collection of authentication methods registered, such as mobilePhone, email, fido2.
Supports $filter (any with eq).

```yaml
Type: System.String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### -UserDisplayName
The user display name, such as Adele Vance.
Supports $filter (eq, startsWith) and $orderBy.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserPrincipalName
The user principal name, such as AdeleV@contoso.com.
Supports $filter (eq, startsWith) and $orderBy.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserRegistrationDetailsId
key: id of userRegistrationDetails

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserRegistrationDetails

### Microsoft.Graph.PowerShell.Models.IReportsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserRegistrationDetails>: userRegistrationDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DefaultMfaMethod <String>]`: defaultMfaMethodType
  - `[IsMfaCapable <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).
  - `[IsMfaRegistered <Boolean?>]`: Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).
  - `[IsPasswordlessCapable <Boolean?>]`: Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).
  - `[IsSsprCapable <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).
  - `[IsSsprEnabled <Boolean?>]`: Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).
  - `[IsSsprRegistered <Boolean?>]`: Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).
  - `[MethodsRegistered <String[]>]`: Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).
  - `[UserDisplayName <String>]`: The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.
  - `[UserPrincipalName <String>]`: The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.

INPUTOBJECT <IReportsIdentity>: Identity Parameter
  - `[ApplicationSignInDetailedSummaryId <String>]`: key: id of applicationSignInDetailedSummary
  - `[CredentialUserRegistrationDetailsId <String>]`: key: id of credentialUserRegistrationDetails
  - `[Date <DateTime?>]`: Usage: date={date}
  - `[DeviceManagementCachedReportConfigurationId <String>]`: key: id of deviceManagementCachedReportConfiguration
  - `[DeviceManagementExportJobId <String>]`: key: id of deviceManagementExportJob
  - `[DirectoryAuditId <String>]`: key: id of directoryAudit
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime='{endDateTime}'
  - `[Filter <String>]`: Usage: filter='{filter}'
  - `[GroupId <String>]`: Usage: groupId='{groupId}'
  - `[IncludedUserRoles <String>]`: Usage: includedUserRoles='{includedUserRoles}'
  - `[IncludedUserTypes <String>]`: Usage: includedUserTypes='{includedUserTypes}'
  - `[Period <String>]`: Usage: period='{period}'
  - `[PrintUsageByPrinterId <String>]`: key: id of printUsageByPrinter
  - `[PrintUsageByUserId <String>]`: key: id of printUsageByUser
  - `[PrinterId <String>]`: Usage: printerId='{printerId}'
  - `[ProvisioningObjectSummaryId <String>]`: key: id of provisioningObjectSummary
  - `[RestrictedSignInId <String>]`: key: id of restrictedSignIn
  - `[SignInId <String>]`: key: id of signIn
  - `[Skip <Int32?>]`: Usage: skip={skip}
  - `[SkipToken <String>]`: Usage: skipToken='{skipToken}'
  - `[StartDateTime <DateTime?>]`: Usage: startDateTime='{startDateTime}'
  - `[Top <Int32?>]`: Usage: top={top}
  - `[UserCredentialUsageDetailsId <String>]`: key: id of userCredentialUsageDetails
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[UserRegistrationDetailsId <String>]`: key: id of userRegistrationDetails

## RELATED LINKS

