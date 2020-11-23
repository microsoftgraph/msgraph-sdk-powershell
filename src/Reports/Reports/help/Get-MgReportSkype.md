---
external help file: Microsoft.Graph.Reports-help.xml
Module Name: Microsoft.Graph.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportskype
schema: 2.0.0
---

# Get-MgReportSkype

## SYNOPSIS
Invoke function getSkypeForBusinessActivityCounts

## SYNTAX

### Get17 (Default)
```
Get-MgReportSkype -Period <String> -InputObject <IReportsIdentity> [<CommonParameters>]
```

### Get33
```
Get-MgReportSkype -Period <String> -InputObject <IReportsIdentity> [<CommonParameters>]
```

### Get32
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get31
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get30
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get29
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get28
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get27
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get26
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get25
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get24
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get22
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get21
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get20
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get18
```
Get-MgReportSkype -Period <String> [<CommonParameters>]
```

### Get23
```
Get-MgReportSkype -Date <DateTime> [<CommonParameters>]
```

### Get19
```
Get-MgReportSkype -Date <DateTime> [<CommonParameters>]
```

### GetViaIdentity33
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity32
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity31
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity30
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity29
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity28
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity27
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity26
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity25
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity24
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity23
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity22
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity21
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity20
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### GetViaIdentity19
```
Get-MgReportSkype -InputObject <IReportsIdentity> [<CommonParameters>]
```

### Get17 (Default)
```
Get-MgReportSkype -Period <String> -InputObject <IReportsIdentity> [<CommonParameters>]
```

### Get33
```
Get-MgReportSkype -Period <String> -InputObject <IReportsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getSkypeForBusinessActivityCounts

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
Parameter Sets: Get23, Get19
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
Parameter Sets: Get17, Get33, GetViaIdentity33, GetViaIdentity32, GetViaIdentity31, GetViaIdentity30, GetViaIdentity29, GetViaIdentity28, GetViaIdentity27, GetViaIdentity26, GetViaIdentity25, GetViaIdentity24, GetViaIdentity23, GetViaIdentity22, GetViaIdentity21, GetViaIdentity20, GetViaIdentity19
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
Parameter Sets: Get17, Get33, Get32, Get31, Get30, Get29, Get28, Get27, Get26, Get25, Get24, Get22, Get21, Get20, Get18
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessActivityCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessActivityUserCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessActivityUserDetail
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessDeviceUsageDistributionUserCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessDeviceUsageUserCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessDeviceUsageUserDetail
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessOrganizerActivityCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessOrganizerActivityMinuteCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessOrganizerActivityUserCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessParticipantActivityCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessParticipantActivityMinuteCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessParticipantActivityUserCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessPeerToPeerActivityCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessPeerToPeerActivityMinuteCounts
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSkypeForBusinessPeerToPeerActivityUserCounts
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

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportskype](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.reports/get-mgreportskype)

