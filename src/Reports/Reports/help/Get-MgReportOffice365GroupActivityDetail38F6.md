---
external help file: Microsoft.Graph.Reports-help.xml
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportoffice365groupactivitydetail38f6
schema: 2.0.0
---

# Get-MgReportOffice365GroupActivityDetail38F6

## SYNOPSIS
Invoke function getOffice365GroupsActivityDetail

## SYNTAX

### Get1 (Default)
```
Get-MgReportOffice365GroupActivityDetail38F6 -Period <String> [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgReportOffice365GroupActivityDetail38F6 -InputObject <IReportsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getOffice365GroupsActivityDetail

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
Type: IReportsIdentity
Parameter Sets: GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Period
.

```yaml
Type: String
Parameter Sets: Get1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOffice365GroupsActivityDetail
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportoffice365groupactivitydetail38f6](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportoffice365groupactivitydetail38f6)

