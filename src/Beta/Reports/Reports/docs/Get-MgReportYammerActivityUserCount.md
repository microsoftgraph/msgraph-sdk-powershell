---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportyammeractivityusercount
schema: 2.0.0
---

# Get-MgReportYammerActivityUserCount

## SYNOPSIS
Invoke function getYammerActivityUserCounts

## SYNTAX

### Get (Default)
```
Get-MgReportYammerActivityUserCount -Period <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgReportYammerActivityUserCount -InputObject <IReportsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getYammerActivityUserCounts

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IReportsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Period
.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IReportsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphYammerActivitySummary

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <IReportsIdentity>: Identity Parameter
  - `[ApplicationSignInDetailedSummaryId <String>]`: key: applicationSignInDetailedSummary-id of applicationSignInDetailedSummary
  - `[CredentialUserRegistrationDetailsId <String>]`: key: credentialUserRegistrationDetails-id of credentialUserRegistrationDetails
  - `[Date <DateTime?>]`: 
  - `[Filter <String>]`: 
  - `[Period <String>]`: 
  - `[Skip <Int32?>]`: 
  - `[SkipToken <String>]`: 
  - `[Top <Int32?>]`: 
  - `[UserCredentialUsageDetailsId <String>]`: key: userCredentialUsageDetails-id of userCredentialUsageDetails

## RELATED LINKS

