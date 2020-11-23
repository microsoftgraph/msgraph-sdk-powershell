---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreement
schema: 2.0.0
---

# New-MgAgreement

## SYNOPSIS
Add new entity to agreements

## SYNTAX

### CreateExpanded (Default)
```
New-MgAgreement [-Acceptances <IMicrosoftGraphAgreementAcceptance[]>] [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-File <IMicrosoftGraphAgreementFile>]
 [-Files <IMicrosoftGraphAgreementFileLocalization[]>] [-Id <String>] [-IsPerDeviceAcceptanceRequired]
 [-IsViewingBeforeAcceptanceRequired] [-TermsExpiration <IMicrosoftGraphTermsExpiration>]
 [-UserReacceptRequiredFrequency <TimeSpan>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgAgreement -BodyParameter <IMicrosoftGraphAgreement> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to agreements

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

### -Acceptances
.
To construct, see NOTES section for ACCEPTANCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementAcceptance[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
agreement
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreement
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -File
agreementFile
To construct, see NOTES section for FILE properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFile
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Files
.
To construct, see NOTES section for FILES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileLocalization[]
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPerDeviceAcceptanceRequired
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsViewingBeforeAcceptanceRequired
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermsExpiration
termsExpiration
To construct, see NOTES section for TERMSEXPIRATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphTermsExpiration
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserReacceptRequiredFrequency
.

```yaml
Type: TimeSpan
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreement
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreement
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ACCEPTANCES \<IMicrosoftGraphAgreementAcceptance\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AgreementFileId \<String\>\]: 
  \[AgreementId \<String\>\]: 
  \[DeviceDisplayName \<String\>\]: 
  \[DeviceId \<String\>\]: 
  \[DeviceOSType \<String\>\]: 
  \[DeviceOSVersion \<String\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[RecordedDateTime \<DateTime?\>\]: 
  \[State \<String\>\]: agreementAcceptanceState
  \[UserDisplayName \<String\>\]: 
  \[UserEmail \<String\>\]: 
  \[UserId \<String\>\]: 
  \[UserPrincipalName \<String\>\]: 

BODYPARAMETER \<IMicrosoftGraphAgreement\>: agreement
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Acceptances \<IMicrosoftGraphAgreementAcceptance\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AgreementFileId \<String\>\]: 
    \[AgreementId \<String\>\]: 
    \[DeviceDisplayName \<String\>\]: 
    \[DeviceId \<String\>\]: 
    \[DeviceOSType \<String\>\]: 
    \[DeviceOSVersion \<String\>\]: 
    \[ExpirationDateTime \<DateTime?\>\]: 
    \[RecordedDateTime \<DateTime?\>\]: 
    \[State \<String\>\]: agreementAcceptanceState
    \[UserDisplayName \<String\>\]: 
    \[UserEmail \<String\>\]: 
    \[UserId \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[DisplayName \<String\>\]: 
  \[File \<IMicrosoftGraphAgreementFile\>\]: agreementFile
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Data \<Byte\[\]\>\]: 
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Localizations \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[FileName \<String\>\]: 
      \[IsDefault \<Boolean?\>\]: 
      \[IsMajorVersion \<Boolean?\>\]: 
      \[Language \<String\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
        \[CreatedDateTime \<DateTime?\>\]: 
        \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
        \[FileName \<String\>\]: 
        \[IsDefault \<Boolean?\>\]: 
        \[IsMajorVersion \<Boolean?\>\]: 
        \[Language \<String\>\]: 
        \[Id \<String\>\]: Read-only.
  \[Files \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
  \[IsPerDeviceAcceptanceRequired \<Boolean?\>\]: 
  \[IsViewingBeforeAcceptanceRequired \<Boolean?\>\]: 
  \[TermsExpiration \<IMicrosoftGraphTermsExpiration\>\]: termsExpiration
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Frequency \<TimeSpan?\>\]: 
    \[StartDateTime \<DateTime?\>\]: 
  \[UserReacceptRequiredFrequency \<TimeSpan?\>\]: 

FILE \<IMicrosoftGraphAgreementFile\>: agreementFile
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Localizations \<IMicrosoftGraphAgreementFileLocalization\[\]\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
      \[CreatedDateTime \<DateTime?\>\]: 
      \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
      \[FileName \<String\>\]: 
      \[IsDefault \<Boolean?\>\]: 
      \[IsMajorVersion \<Boolean?\>\]: 
      \[Language \<String\>\]: 
      \[Id \<String\>\]: Read-only.

FILES \<IMicrosoftGraphAgreementFileLocalization\[\]\>: .
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.

TERMSEXPIRATION \<IMicrosoftGraphTermsExpiration\>: termsExpiration
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Frequency \<TimeSpan?\>\]: 
  \[StartDateTime \<DateTime?\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreement](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreement)

