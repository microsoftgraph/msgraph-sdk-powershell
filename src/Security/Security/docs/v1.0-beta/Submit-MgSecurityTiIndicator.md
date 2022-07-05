---
external help file:
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
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Submit
```
Submit-MgSecurityTiIndicator
 -BodyParameter <IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action submitTiIndicators

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
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
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema
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
To construct, please use Get-Help -Online and see NOTES section for VALUE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTiIndicator[]
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

### Microsoft.Graph.PowerShell.Models.IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTiIndicator

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Value <IMicrosoftGraphTiIndicator[]>]`: 
    - `[Id <String>]`: 
    - `[Action <String>]`: tiAction
    - `[ActivityGroupNames <String[]>]`: The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
    - `[AdditionalInformation <String>]`: A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.
    - `[AzureTenantId <String>]`: Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.
    - `[Confidence <Int32?>]`: An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.
    - `[Description <String>]`: Brief description (100 characters or less) of the threat represented by the indicator. Required.
    - `[DiamondModel <String>]`: diamondModel
    - `[DomainName <String>]`: 
    - `[EmailEncoding <String>]`: 
    - `[EmailLanguage <String>]`: 
    - `[EmailRecipient <String>]`: 
    - `[EmailSenderAddress <String>]`: 
    - `[EmailSenderName <String>]`: 
    - `[EmailSourceDomain <String>]`: 
    - `[EmailSourceIPAddress <String>]`: 
    - `[EmailSubject <String>]`: 
    - `[EmailXMailer <String>]`: 
    - `[ExpirationDateTime <DateTime?>]`: DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
    - `[ExternalId <String>]`: An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).
    - `[FileCompileDateTime <DateTime?>]`: 
    - `[FileCreatedDateTime <DateTime?>]`: 
    - `[FileHashType <String>]`: fileHashType
    - `[FileHashValue <String>]`: 
    - `[FileMutexName <String>]`: 
    - `[FileName <String>]`: 
    - `[FilePacker <String>]`: 
    - `[FilePath <String>]`: 
    - `[FileSize <Int64?>]`: 
    - `[FileType <String>]`: 
    - `[IngestedDateTime <DateTime?>]`: Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[IsActive <Boolean?>]`: Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.
    - `[KillChain <String[]>]`: A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.
    - `[KnownFalsePositives <String>]`: Scenarios in which the indicator may cause false positives. This should be human-readable text.
    - `[LastReportedDateTime <DateTime?>]`: The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[MalwareFamilyNames <String[]>]`: The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.
    - `[NetworkCidrBlock <String>]`: 
    - `[NetworkDestinationAsn <Int64?>]`: 
    - `[NetworkDestinationCidrBlock <String>]`: 
    - `[NetworkDestinationIPv4 <String>]`: 
    - `[NetworkDestinationIPv6 <String>]`: 
    - `[NetworkDestinationPort <Int32?>]`: 
    - `[NetworkIPv4 <String>]`: 
    - `[NetworkIPv6 <String>]`: 
    - `[NetworkPort <Int32?>]`: 
    - `[NetworkProtocol <Int32?>]`: 
    - `[NetworkSourceAsn <Int64?>]`: 
    - `[NetworkSourceCidrBlock <String>]`: 
    - `[NetworkSourceIPv4 <String>]`: 
    - `[NetworkSourceIPv6 <String>]`: 
    - `[NetworkSourcePort <Int32?>]`: 
    - `[PassiveOnly <Boolean?>]`: Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.
    - `[Severity <Int32?>]`: An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.
    - `[Tags <String[]>]`: A JSON array of strings that stores arbitrary tags/keywords.
    - `[TargetProduct <String>]`: A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required
    - `[ThreatType <String>]`: Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
    - `[TlpLevel <String>]`: tlpLevel
    - `[Url <String>]`: 
    - `[UserAgent <String>]`: 

VALUE <IMicrosoftGraphTiIndicator[]>: .
  - `[Id <String>]`: 
  - `[Action <String>]`: tiAction
  - `[ActivityGroupNames <String[]>]`: The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
  - `[AdditionalInformation <String>]`: A catchall area into which extra data from the indicator not covered by the other tiIndicator properties may be placed. Data placed into additionalInformation will typically not be utilized by the targetProduct security tool.
  - `[AzureTenantId <String>]`: Stamped by the system when the indicator is ingested. The Azure Active Directory tenant id of submitting client. Required.
  - `[Confidence <Int32?>]`: An integer representing the confidence the data within the indicator accurately identifies malicious behavior. Acceptable values are 0 – 100 with 100 being the highest.
  - `[Description <String>]`: Brief description (100 characters or less) of the threat represented by the indicator. Required.
  - `[DiamondModel <String>]`: diamondModel
  - `[DomainName <String>]`: 
  - `[EmailEncoding <String>]`: 
  - `[EmailLanguage <String>]`: 
  - `[EmailRecipient <String>]`: 
  - `[EmailSenderAddress <String>]`: 
  - `[EmailSenderName <String>]`: 
  - `[EmailSourceDomain <String>]`: 
  - `[EmailSourceIPAddress <String>]`: 
  - `[EmailSubject <String>]`: 
  - `[EmailXMailer <String>]`: 
  - `[ExpirationDateTime <DateTime?>]`: DateTime string indicating when the Indicator expires. All indicators must have an expiration date to avoid stale indicators persisting in the system. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Required.
  - `[ExternalId <String>]`: An identification number that ties the indicator back to the indicator provider’s system (e.g. a foreign key).
  - `[FileCompileDateTime <DateTime?>]`: 
  - `[FileCreatedDateTime <DateTime?>]`: 
  - `[FileHashType <String>]`: fileHashType
  - `[FileHashValue <String>]`: 
  - `[FileMutexName <String>]`: 
  - `[FileName <String>]`: 
  - `[FilePacker <String>]`: 
  - `[FilePath <String>]`: 
  - `[FileSize <Int64?>]`: 
  - `[FileType <String>]`: 
  - `[IngestedDateTime <DateTime?>]`: Stamped by the system when the indicator is ingested. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[IsActive <Boolean?>]`: Used to deactivate indicators within system. By default, any indicator submitted is set as active. However, providers may submit existing indicators with this set to ‘False’ to deactivate indicators in the system.
  - `[KillChain <String[]>]`: A JSON array of strings that describes which point or points on the Kill Chain this indicator targets. See ‘killChain values’ below for exact values.
  - `[KnownFalsePositives <String>]`: Scenarios in which the indicator may cause false positives. This should be human-readable text.
  - `[LastReportedDateTime <DateTime?>]`: The last time the indicator was seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[MalwareFamilyNames <String[]>]`: The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible which can be found via the Windows Defender Security Intelligence threat encyclopedia.
  - `[NetworkCidrBlock <String>]`: 
  - `[NetworkDestinationAsn <Int64?>]`: 
  - `[NetworkDestinationCidrBlock <String>]`: 
  - `[NetworkDestinationIPv4 <String>]`: 
  - `[NetworkDestinationIPv6 <String>]`: 
  - `[NetworkDestinationPort <Int32?>]`: 
  - `[NetworkIPv4 <String>]`: 
  - `[NetworkIPv6 <String>]`: 
  - `[NetworkPort <Int32?>]`: 
  - `[NetworkProtocol <Int32?>]`: 
  - `[NetworkSourceAsn <Int64?>]`: 
  - `[NetworkSourceCidrBlock <String>]`: 
  - `[NetworkSourceIPv4 <String>]`: 
  - `[NetworkSourceIPv6 <String>]`: 
  - `[NetworkSourcePort <Int32?>]`: 
  - `[PassiveOnly <Boolean?>]`: Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools will not notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they will simply log that a match occurred but will not perform the action. Default value is false.
  - `[Severity <Int32?>]`: An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero is not severe at all. Default value is 3.
  - `[Tags <String[]>]`: A JSON array of strings that stores arbitrary tags/keywords.
  - `[TargetProduct <String>]`: A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required
  - `[ThreatType <String>]`: Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
  - `[TlpLevel <String>]`: tlpLevel
  - `[Url <String>]`: 
  - `[UserAgent <String>]`: 

## RELATED LINKS

