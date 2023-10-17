---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/submit-mgbetasecuritytiindicator
schema: 2.0.0
---

# Submit-MgBetaSecurityTiIndicator

## SYNOPSIS
Upload multiple threat intelligence (TI) indicators in one request instead of multiple requests.
This API is available in the following national cloud deployments.

## SYNTAX

### SubmitExpanded (Default)
```
Submit-MgBetaSecurityTiIndicator [-AdditionalProperties <Hashtable>] [-Value <IMicrosoftGraphTiIndicator[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Submit
```
Submit-MgBetaSecurityTiIndicator
 -BodyParameter <IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Upload multiple threat intelligence (TI) indicators in one request instead of multiple requests.
This API is available in the following national cloud deployments.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Value = @(
		@{
			ActivityGroupNames = @(
			)
			Confidence = 0
			Description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
			ExpirationDateTime = [System.DateTime]::Parse("2019-03-01T21:44:03.1668987+00:00")
			ExternalId = "Test--8586509942423126760MS164-0"
			FileHashType = "sha256"
			FileHashValue = "b555c45c5b1b01304217e72118d6ca1b14b7013644a078273cea27bbdc1cf9d6"
			KillChain = @(
			)
			MalwareFamilyNames = @(
			)
			Severity = 0
			Tags = @(
			)
			TargetProduct = "Azure Sentinel"
			ThreatType = "WatchList"
			TlpLevel = "green"
		}
		@{
			ActivityGroupNames = @(
			)
			Confidence = 0
			Description = "This is a canary indicator for demo purpose. Take no action on any observables set in this indicator."
			ExpirationDateTime = [System.DateTime]::Parse("2019-03-01T21:44:03.1748779+00:00")
			ExternalId = "Test--8586509942423126760MS164-1"
			FileHashType = "sha256"
			FileHashValue = "1796b433950990b28d6a22456c9d2b58ced1bdfcdf5f16f7e39d6b9bdca4213b"
			KillChain = @(
			)
			MalwareFamilyNames = @(
			)
			Severity = 0
			Tags = @(
			)
			TargetProduct = "Azure Sentinel"
			ThreatType = "WatchList"
			TlpLevel = "green"
		}
	)
}
Submit-MgBetaSecurityTiIndicator -BodyParameter $params
```



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
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTiIndicator[]
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTiIndicator

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths18Nbj75SecurityTiindicatorsMicrosoftGraphSubmittiindicatorsPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Value <IMicrosoftGraphTiIndicator[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Action <String>]`: tiAction
    - `[ActivityGroupNames <String[]>]`: The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
    - `[AdditionalInformation <String>]`: A catchall area for extra data from the indicator that is not specifically covered by other tiIndicator properties. The security tool specified by targetProduct typically does not utilize this data.
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
    - `[ExternalId <String>]`: An identification number that ties the indicator back to the indicator provider’s system (for example, a foreign key).
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
    - `[MalwareFamilyNames <String[]>]`: The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible that can be found via the Windows Defender Security Intelligence threat encyclopedia.
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
    - `[PassiveOnly <Boolean?>]`: Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools won't notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they'll simply log that a match occurred but won't perform the action. Default value is false.
    - `[Severity <Int32?>]`: An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero isn't severe at all. Default value is 3.
    - `[Tags <String[]>]`: A JSON array of strings that stores arbitrary tags/keywords.
    - `[TargetProduct <String>]`: A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required
    - `[ThreatType <String>]`: Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
    - `[TlpLevel <String>]`: tlpLevel
    - `[Url <String>]`: 
    - `[UserAgent <String>]`: 

`VALUE <IMicrosoftGraphTiIndicator[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Action <String>]`: tiAction
  - `[ActivityGroupNames <String[]>]`: The cyber threat intelligence name(s) for the parties responsible for the malicious activity covered by the threat indicator.
  - `[AdditionalInformation <String>]`: A catchall area for extra data from the indicator that is not specifically covered by other tiIndicator properties. The security tool specified by targetProduct typically does not utilize this data.
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
  - `[ExternalId <String>]`: An identification number that ties the indicator back to the indicator provider’s system (for example, a foreign key).
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
  - `[MalwareFamilyNames <String[]>]`: The malware family name associated with an indicator if it exists. Microsoft prefers the Microsoft malware family name if at all possible that can be found via the Windows Defender Security Intelligence threat encyclopedia.
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
  - `[PassiveOnly <Boolean?>]`: Determines if the indicator should trigger an event that is visible to an end-user. When set to ‘true,’ security tools won't notify the end user that a ‘hit’ has occurred. This is most often treated as audit or silent mode by security products where they'll simply log that a match occurred but won't perform the action. Default value is false.
  - `[Severity <Int32?>]`: An integer representing the severity of the malicious behavior identified by the data within the indicator. Acceptable values are 0 – 5 where 5 is the most severe and zero isn't severe at all. Default value is 3.
  - `[Tags <String[]>]`: A JSON array of strings that stores arbitrary tags/keywords.
  - `[TargetProduct <String>]`: A string value representing a single security product to which the indicator should be applied. Acceptable values are: Azure Sentinel, Microsoft Defender ATP. Required
  - `[ThreatType <String>]`: Each indicator must have a valid Indicator Threat Type. Possible values are: Botnet, C2, CryptoMining, Darknet, DDoS, MaliciousUrl, Malware, Phishing, Proxy, PUA, WatchList. Required.
  - `[TlpLevel <String>]`: tlpLevel
  - `[Url <String>]`: 
  - `[UserAgent <String>]`: 

## RELATED LINKS

