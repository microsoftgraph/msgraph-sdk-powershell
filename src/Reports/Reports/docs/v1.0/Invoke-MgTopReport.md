---
external help file:
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/invoke-mgtopreport
schema: 2.0.0
---

# Invoke-MgTopReport

## SYNOPSIS
Invoke function managedDeviceEnrollmentTopFailures

## SYNTAX

### Top2 (Default)
```
Invoke-MgTopReport -OutFile <String> [-PassThru] [<CommonParameters>]
```

### Top3
```
Invoke-MgTopReport -Period <String> -OutFile <String> [-PassThru] [<CommonParameters>]
```

### TopViaIdentity1
```
Invoke-MgTopReport -InputObject <IReportsIdentity> -OutFile <String> [-PassThru] [<CommonParameters>]
```

## DESCRIPTION
Invoke function managedDeviceEnrollmentTopFailures

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
Parameter Sets: TopViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OutFile
Path to write output file to

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

### -Period
.

```yaml
Type: System.String
Parameter Sets: Top3
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

### Microsoft.Graph.PowerShell.Models.IReportsIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IReportsIdentity>: Identity Parameter
  - `[ApplicationSignInDetailedSummaryId <String>]`: key: applicationSignInDetailedSummary-id of applicationSignInDetailedSummary
  - `[CredentialUserRegistrationDetailsId <String>]`: key: credentialUserRegistrationDetails-id of credentialUserRegistrationDetails
  - `[Date <DateTime?>]`: 
  - `[Filter <String>]`: 
  - `[Period <String>]`: 
  - `[PrintUsageSummaryByPrinterId <String>]`: key: PrintUsageSummaryByPrinter-id of PrintUsageSummaryByPrinter
  - `[PrintUsageSummaryByUserId <String>]`: key: PrintUsageSummaryByUser-id of PrintUsageSummaryByUser
  - `[Skip <Int32?>]`: 
  - `[SkipToken <String>]`: 
  - `[Top <Int32?>]`: 
  - `[UserCredentialUsageDetailsId <String>]`: key: userCredentialUsageDetails-id of userCredentialUsageDetails

## RELATED LINKS

