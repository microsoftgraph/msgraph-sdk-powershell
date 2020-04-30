---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/update-mgreportroot
schema: 2.0.0
---

# Update-MgReportRoot

## SYNOPSIS
Update reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgReportRoot [-ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]
 [-CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>] [-Id <String>]
 [-UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgReportRoot -BodyParameter <IMicrosoftGraphReportRoot> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update reports

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

### -ApplicationSignInDetailedSummary
.
To construct, see NOTES section for APPLICATIONSIGNINDETAILEDSUMMARY properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphApplicationSignInDetailedSummary[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
The resource that represents an instance of History Reports.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -CredentialUserRegistrationDetails
.
To construct, see NOTES section for CREDENTIALUSERREGISTRATIONDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCredentialUserRegistrationDetails[]
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
```

### -UserCredentialUsageDetails
.
To construct, see NOTES section for USERCREDENTIALUSAGEDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserCredentialUsageDetails[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphReportRoot

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### APPLICATIONSIGNINDETAILEDSUMMARY <IMicrosoftGraphApplicationSignInDetailedSummary[]>: .
  - `[Id <String>]`: Read-only.
  - `[AggregatedEventDateTime <DateTime?>]`: 
  - `[AppDisplayName <String>]`: 
  - `[AppId <String>]`: 
  - `[SignInCount <Int64?>]`: 
  - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
  - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
  - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.

#### BODYPARAMETER <IMicrosoftGraphReportRoot>: The resource that represents an instance of History Reports.
  - `[Id <String>]`: Read-only.
  - `[ApplicationSignInDetailedSummary <IMicrosoftGraphApplicationSignInDetailedSummary[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AggregatedEventDateTime <DateTime?>]`: 
    - `[AppDisplayName <String>]`: 
    - `[AppId <String>]`: 
    - `[SignInCount <Int64?>]`: 
    - `[StatusAdditionalDetails <String>]`: Provides additional details on the sign-in activity
    - `[StatusErrorCode <Int32?>]`: Provides the 5-6digit error code that's generated during a sign-in failure. Check out the list of error codes and messages.
    - `[StatusFailureReason <String>]`: Provides the error message or the reason for failure for the corresponding sign-in activity. Check out the list of error codes and messages.
  - `[CredentialUserRegistrationDetails <IMicrosoftGraphCredentialUserRegistrationDetails[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AuthMethods <String[]>]`: 
    - `[IsCapable <Boolean?>]`: 
    - `[IsEnabled <Boolean?>]`: 
    - `[IsMfaRegistered <Boolean?>]`: 
    - `[IsRegistered <Boolean?>]`: 
    - `[UserDisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[UserCredentialUsageDetails <IMicrosoftGraphUserCredentialUsageDetails[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AuthMethod <String>]`: usageAuthMethod
    - `[EventDateTime <DateTime?>]`: 
    - `[FailureReason <String>]`: 
    - `[Feature <String>]`: featureType
    - `[IsSuccess <Boolean?>]`: 
    - `[UserDisplayName <String>]`: 
    - `[UserPrincipalName <String>]`: 

#### CREDENTIALUSERREGISTRATIONDETAILS <IMicrosoftGraphCredentialUserRegistrationDetails[]>: .
  - `[Id <String>]`: Read-only.
  - `[AuthMethods <String[]>]`: 
  - `[IsCapable <Boolean?>]`: 
  - `[IsEnabled <Boolean?>]`: 
  - `[IsMfaRegistered <Boolean?>]`: 
  - `[IsRegistered <Boolean?>]`: 
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

#### USERCREDENTIALUSAGEDETAILS <IMicrosoftGraphUserCredentialUsageDetails[]>: .
  - `[Id <String>]`: Read-only.
  - `[AuthMethod <String>]`: usageAuthMethod
  - `[EventDateTime <DateTime?>]`: 
  - `[FailureReason <String>]`: 
  - `[Feature <String>]`: featureType
  - `[IsSuccess <Boolean?>]`: 
  - `[UserDisplayName <String>]`: 
  - `[UserPrincipalName <String>]`: 

## RELATED LINKS

