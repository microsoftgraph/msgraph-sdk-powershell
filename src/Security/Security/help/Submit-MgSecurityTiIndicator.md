---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/submit-mgsecuritytiindicator
schema: 2.0.0
---

# Submit-MgSecurityTiIndicator

## SYNOPSIS
Invoke action submitTiIndicators

## SYNTAX

### SubmitExpanded (Default)
```
Submit-MgSecurityTiIndicator [-AdditionalProperties <Hashtable>] [-Value <IMicrosoftGraphTiIndicator[]>]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Submit
```
Submit-MgSecurityTiIndicator
 -BodyParameter <IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Invoke action submitTiIndicators

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: SubmitExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Submit
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Value
.
To construct, see NOTES section for VALUE properties and create a hash table.

```yaml
Type: IMicrosoftGraphTiIndicator[]
Parameter Sets: SubmitExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTiIndicator
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema\>: .
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Value \<IMicrosoftGraphTiIndicator\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Action \<String\>\]: tiAction
    \[ActivityGroupNames \<String\[\]\>\]: 
    \[AdditionalInformation \<String\>\]: 
    \[AzureTenantId \<String\>\]: 
    \[Confidence \<Int32?\>\]: 
    \[Description \<String\>\]: 
    \[DiamondModel \<String\>\]: diamondModel
    \[DomainName \<String\>\]: 
    \[EmailEncoding \<String\>\]: 
    \[EmailLanguage \<String\>\]: 
    \[EmailRecipient \<String\>\]: 
    \[EmailSenderAddress \<String\>\]: 
    \[EmailSenderName \<String\>\]: 
    \[EmailSourceDomain \<String\>\]: 
    \[EmailSourceIPAddress \<String\>\]: 
    \[EmailSubject \<String\>\]: 
    \[EmailXMailer \<String\>\]: 
    \[ExpirationDateTime \<DateTime?\>\]: 
    \[ExternalId \<String\>\]: 
    \[FileCompileDateTime \<DateTime?\>\]: 
    \[FileCreatedDateTime \<DateTime?\>\]: 
    \[FileHashType \<String\>\]: fileHashType
    \[FileHashValue \<String\>\]: 
    \[FileMutexName \<String\>\]: 
    \[FileName \<String\>\]: 
    \[FilePacker \<String\>\]: 
    \[FilePath \<String\>\]: 
    \[FileSize \<Int64?\>\]: 
    \[FileType \<String\>\]: 
    \[IngestedDateTime \<DateTime?\>\]: 
    \[IsActive \<Boolean?\>\]: 
    \[KillChain \<String\[\]\>\]: 
    \[KnownFalsePositives \<String\>\]: 
    \[LastReportedDateTime \<DateTime?\>\]: 
    \[MalwareFamilyNames \<String\[\]\>\]: 
    \[NetworkCidrBlock \<String\>\]: 
    \[NetworkDestinationAsn \<Int32?\>\]: 
    \[NetworkDestinationCidrBlock \<String\>\]: 
    \[NetworkDestinationIPv4 \<String\>\]: 
    \[NetworkDestinationIPv6 \<String\>\]: 
    \[NetworkDestinationPort \<Int32?\>\]: 
    \[NetworkIPv4 \<String\>\]: 
    \[NetworkIPv6 \<String\>\]: 
    \[NetworkPort \<Int32?\>\]: 
    \[NetworkProtocol \<Int32?\>\]: 
    \[NetworkSourceAsn \<Int32?\>\]: 
    \[NetworkSourceCidrBlock \<String\>\]: 
    \[NetworkSourceIPv4 \<String\>\]: 
    \[NetworkSourceIPv6 \<String\>\]: 
    \[NetworkSourcePort \<Int32?\>\]: 
    \[PassiveOnly \<Boolean?\>\]: 
    \[Severity \<Int32?\>\]: 
    \[Tags \<String\[\]\>\]: 
    \[TargetProduct \<String\>\]: 
    \[ThreatType \<String\>\]: 
    \[TlpLevel \<String\>\]: tlpLevel
    \[Url \<String\>\]: 
    \[UserAgent \<String\>\]: 

VALUE \<IMicrosoftGraphTiIndicator\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[Action \<String\>\]: tiAction
  \[ActivityGroupNames \<String\[\]\>\]: 
  \[AdditionalInformation \<String\>\]: 
  \[AzureTenantId \<String\>\]: 
  \[Confidence \<Int32?\>\]: 
  \[Description \<String\>\]: 
  \[DiamondModel \<String\>\]: diamondModel
  \[DomainName \<String\>\]: 
  \[EmailEncoding \<String\>\]: 
  \[EmailLanguage \<String\>\]: 
  \[EmailRecipient \<String\>\]: 
  \[EmailSenderAddress \<String\>\]: 
  \[EmailSenderName \<String\>\]: 
  \[EmailSourceDomain \<String\>\]: 
  \[EmailSourceIPAddress \<String\>\]: 
  \[EmailSubject \<String\>\]: 
  \[EmailXMailer \<String\>\]: 
  \[ExpirationDateTime \<DateTime?\>\]: 
  \[ExternalId \<String\>\]: 
  \[FileCompileDateTime \<DateTime?\>\]: 
  \[FileCreatedDateTime \<DateTime?\>\]: 
  \[FileHashType \<String\>\]: fileHashType
  \[FileHashValue \<String\>\]: 
  \[FileMutexName \<String\>\]: 
  \[FileName \<String\>\]: 
  \[FilePacker \<String\>\]: 
  \[FilePath \<String\>\]: 
  \[FileSize \<Int64?\>\]: 
  \[FileType \<String\>\]: 
  \[IngestedDateTime \<DateTime?\>\]: 
  \[IsActive \<Boolean?\>\]: 
  \[KillChain \<String\[\]\>\]: 
  \[KnownFalsePositives \<String\>\]: 
  \[LastReportedDateTime \<DateTime?\>\]: 
  \[MalwareFamilyNames \<String\[\]\>\]: 
  \[NetworkCidrBlock \<String\>\]: 
  \[NetworkDestinationAsn \<Int32?\>\]: 
  \[NetworkDestinationCidrBlock \<String\>\]: 
  \[NetworkDestinationIPv4 \<String\>\]: 
  \[NetworkDestinationIPv6 \<String\>\]: 
  \[NetworkDestinationPort \<Int32?\>\]: 
  \[NetworkIPv4 \<String\>\]: 
  \[NetworkIPv6 \<String\>\]: 
  \[NetworkPort \<Int32?\>\]: 
  \[NetworkProtocol \<Int32?\>\]: 
  \[NetworkSourceAsn \<Int32?\>\]: 
  \[NetworkSourceCidrBlock \<String\>\]: 
  \[NetworkSourceIPv4 \<String\>\]: 
  \[NetworkSourceIPv6 \<String\>\]: 
  \[NetworkSourcePort \<Int32?\>\]: 
  \[PassiveOnly \<Boolean?\>\]: 
  \[Severity \<Int32?\>\]: 
  \[Tags \<String\[\]\>\]: 
  \[TargetProduct \<String\>\]: 
  \[ThreatType \<String\>\]: 
  \[TlpLevel \<String\>\]: tlpLevel
  \[Url \<String\>\]: 
  \[UserAgent \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/submit-mgsecuritytiindicator](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/submit-mgsecuritytiindicator)

