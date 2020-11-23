---
external help file: Microsoft.Graph.Reports-help.xml
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportemailappusageuserdetail62ec
schema: 2.0.0
---

# Get-MgReportEmailAppUsageUserDetail62Ec

## SYNOPSIS
Invoke function getEmailAppUsageUserDetail

## SYNTAX

### Get1 (Default)
```
Get-MgReportEmailAppUsageUserDetail62Ec -Date <DateTime> [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgReportEmailAppUsageUserDetail62Ec -InputObject <IReportsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getEmailAppUsageUserDetail

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

### -Date
.

```yaml
Type: DateTime
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IReportsIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IReportsIdentity
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphEmailAppUsageUserDetail
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT \<IReportsIdentity\>: Identity Parameter
  \[ApplicationSignInDetailedSummaryId \<String\>\]: key: id of applicationSignInDetailedSummary
  \[CredentialUserRegistrationDetailsId \<String\>\]: key: id of credentialUserRegistrationDetails
  \[Date \<DateTime?\>\]: 
  \[DirectoryAuditId \<String\>\]: key: id of directoryAudit
  \[Filter \<String\>\]: 
  \[Period \<String\>\]: 
  \[PrintUsageSummaryByPrinterId \<String\>\]: key: id of PrintUsageSummaryByPrinter
  \[PrintUsageSummaryByUserId \<String\>\]: key: id of PrintUsageSummaryByUser
  \[ProvisioningObjectSummaryId \<String\>\]: key: id of provisioningObjectSummary
  \[RestrictedSignInId \<String\>\]: key: id of restrictedSignIn
  \[SignInId \<String\>\]: key: id of signIn
  \[Skip \<Int32?\>\]: 
  \[SkipToken \<String\>\]: 
  \[Top \<Int32?\>\]: 
  \[UserCredentialUsageDetailsId \<String\>\]: key: id of userCredentialUsageDetails

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportemailappusageuserdetail62ec](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportemailappusageuserdetail62ec)

