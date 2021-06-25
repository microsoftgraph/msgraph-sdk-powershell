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

### CreateExpanded1 (Default)
```
New-MgAgreement [-Acceptances <IMicrosoftGraphAgreementAcceptance[]>] [-AdditionalProperties <Hashtable>]
 [-DisplayName <String>] [-File <IMicrosoftGraphAgreementFile>]
 [-Files <IMicrosoftGraphAgreementFileLocalization[]>] [-Id <String>] [-IsPerDeviceAcceptanceRequired]
 [-IsViewingBeforeAcceptanceRequired] [-TermsExpiration <IMicrosoftGraphTermsExpiration>]
 [-UserReacceptRequiredFrequency <TimeSpan>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create1
```
New-MgAgreement -BodyParameter <IMicrosoftGraphAgreement> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to agreements

## EXAMPLES

## PARAMETERS

### -Acceptances
Read-only.
Information about acceptances of this agreement.
To construct, see NOTES section for ACCEPTANCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementAcceptance[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
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
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
Display name of the agreement.
The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement.

```yaml
Type: String
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Files
PDFs linked to this agreement.
Note: This property is in the process of being deprecated.
Use the file property instead.
To construct, see NOTES section for FILES properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileLocalization[]
Parameter Sets: CreateExpanded1
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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsPerDeviceAcceptanceRequired
This setting enables you to require end users to accept this agreement on every device that they are accessing it from.
The end user will be required to register their device in Azure AD, if they haven't already done so.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsViewingBeforeAcceptanceRequired
Indicates whether the user has to expand the agreement before accepting.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TermsExpiration
termsExpiration
To construct, see NOTES section for TERMSEXPIRATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphTermsExpiration
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserReacceptRequiredFrequency
The duration after which the user must re-accept the terms of use.
The value is represented in ISO 8601 format for durations.

```yaml
Type: TimeSpan
Parameter Sets: CreateExpanded1
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

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ACCEPTANCES <IMicrosoftGraphAgreementAcceptance[]>: Read-only. Information about acceptances of this agreement.
  - `[Id <String>]`: Read-only.
  - `[AgreementFileId <String>]`: ID of the agreement file accepted by the user.
  - `[AgreementId <String>]`: ID of the agreement.
  - `[DeviceDisplayName <String>]`: The display name of the device used for accepting the agreement.
  - `[DeviceId <String>]`: The unique identifier of the device used for accepting the agreement.
  - `[DeviceOSType <String>]`: The operating system used for accepting the agreement.
  - `[DeviceOSVersion <String>]`: The operating system version of the device used for accepting the agreement.
  - `[ExpirationDateTime <DateTime?>]`: The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[RecordedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[State <String>]`: agreementAcceptanceState
  - `[UserDisplayName <String>]`: Display name of the user when the acceptance was recorded.
  - `[UserEmail <String>]`: Email of the user when the acceptance was recorded.
  - `[UserId <String>]`: ID of the user who accepted the agreement.
  - `[UserPrincipalName <String>]`: UPN of the user when the acceptance was recorded.

BODYPARAMETER <IMicrosoftGraphAgreement>: agreement
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Acceptances <IMicrosoftGraphAgreementAcceptance[]>]`: Read-only. Information about acceptances of this agreement.
    - `[Id <String>]`: Read-only.
    - `[AgreementFileId <String>]`: ID of the agreement file accepted by the user.
    - `[AgreementId <String>]`: ID of the agreement.
    - `[DeviceDisplayName <String>]`: The display name of the device used for accepting the agreement.
    - `[DeviceId <String>]`: The unique identifier of the device used for accepting the agreement.
    - `[DeviceOSType <String>]`: The operating system used for accepting the agreement.
    - `[DeviceOSVersion <String>]`: The operating system version of the device used for accepting the agreement.
    - `[ExpirationDateTime <DateTime?>]`: The expiration date time of the acceptance. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[RecordedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[State <String>]`: agreementAcceptanceState
    - `[UserDisplayName <String>]`: Display name of the user when the acceptance was recorded.
    - `[UserEmail <String>]`: Email of the user when the acceptance was recorded.
    - `[UserId <String>]`: ID of the user who accepted the agreement.
    - `[UserPrincipalName <String>]`: UPN of the user when the acceptance was recorded.
  - `[DisplayName <String>]`: Display name of the agreement. The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement.
  - `[File <IMicrosoftGraphAgreementFile>]`: agreementFile
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Data <Byte[]>]`: 
    - `[FileName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[IsMajorVersion <Boolean?>]`: 
    - `[Language <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Localizations <IMicrosoftGraphAgreementFileLocalization[]>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
      - `[FileName <String>]`: 
      - `[IsDefault <Boolean?>]`: 
      - `[IsMajorVersion <Boolean?>]`: 
      - `[Language <String>]`: 
      - `[Id <String>]`: Read-only.
      - `[Versions <IMicrosoftGraphAgreementFileVersion[]>]`: 
        - `[CreatedDateTime <DateTime?>]`: 
        - `[DisplayName <String>]`: 
        - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
        - `[FileName <String>]`: 
        - `[IsDefault <Boolean?>]`: 
        - `[IsMajorVersion <Boolean?>]`: 
        - `[Language <String>]`: 
        - `[Id <String>]`: Read-only.
  - `[Files <IMicrosoftGraphAgreementFileLocalization[]>]`: PDFs linked to this agreement. Note: This property is in the process of being deprecated. Use the  file property instead.
  - `[IsPerDeviceAcceptanceRequired <Boolean?>]`: This setting enables you to require end users to accept this agreement on every device that they are accessing it from. The end user will be required to register their device in Azure AD, if they haven't already done so.
  - `[IsViewingBeforeAcceptanceRequired <Boolean?>]`: Indicates whether the user has to expand the agreement before accepting.
  - `[TermsExpiration <IMicrosoftGraphTermsExpiration>]`: termsExpiration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Frequency <TimeSpan?>]`: Represents the frequency at which the terms will expire, after its first expiration as set in startDateTime. The value is represented in ISO 8601 format for durations. For example, PT1M represents a time period of 1 month.
    - `[StartDateTime <DateTime?>]`: The DateTime when the agreement is set to expire for all users. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[UserReacceptRequiredFrequency <TimeSpan?>]`: The duration after which the user must re-accept the terms of use. The value is represented in ISO 8601 format for durations.

FILE <IMicrosoftGraphAgreementFile>: agreementFile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Data <Byte[]>]`: 
  - `[FileName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsMajorVersion <Boolean?>]`: 
  - `[Language <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Localizations <IMicrosoftGraphAgreementFileLocalization[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
    - `[FileName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[IsMajorVersion <Boolean?>]`: 
    - `[Language <String>]`: 
    - `[Id <String>]`: Read-only.
    - `[Versions <IMicrosoftGraphAgreementFileVersion[]>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[DisplayName <String>]`: 
      - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
      - `[FileName <String>]`: 
      - `[IsDefault <Boolean?>]`: 
      - `[IsMajorVersion <Boolean?>]`: 
      - `[Language <String>]`: 
      - `[Id <String>]`: Read-only.

FILES <IMicrosoftGraphAgreementFileLocalization[]>: PDFs linked to this agreement. Note: This property is in the process of being deprecated. Use the file property instead.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DisplayName <String>]`: 
  - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Data <Byte[]>]`: 
  - `[FileName <String>]`: 
  - `[IsDefault <Boolean?>]`: 
  - `[IsMajorVersion <Boolean?>]`: 
  - `[Language <String>]`: 
  - `[Id <String>]`: Read-only.
  - `[Versions <IMicrosoftGraphAgreementFileVersion[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DisplayName <String>]`: 
    - `[FileData <IMicrosoftGraphAgreementFileData>]`: agreementFileData
    - `[FileName <String>]`: 
    - `[IsDefault <Boolean?>]`: 
    - `[IsMajorVersion <Boolean?>]`: 
    - `[Language <String>]`: 
    - `[Id <String>]`: Read-only.

TERMSEXPIRATION <IMicrosoftGraphTermsExpiration>: termsExpiration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Frequency <TimeSpan?>]`: Represents the frequency at which the terms will expire, after its first expiration as set in startDateTime. The value is represented in ISO 8601 format for durations. For example, PT1M represents a time period of 1 month.
  - `[StartDateTime <DateTime?>]`: The DateTime when the agreement is set to expire for all users. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

## RELATED LINKS
