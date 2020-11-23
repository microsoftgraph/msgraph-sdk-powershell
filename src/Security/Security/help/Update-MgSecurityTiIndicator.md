---
external help file: Microsoft.Graph.Security-help.xml
Module Name: Microsoft.Graph.Security
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecuritytiindicator
schema: 2.0.0
---

# Update-MgSecurityTiIndicator

## SYNOPSIS
Update the navigation property tiIndicators in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityTiIndicator -TiIndicatorId <String> [-Action <String>] [-ActivityGroupNames <String[]>]
 [-AdditionalInformation <String>] [-AdditionalProperties <Hashtable>] [-AzureTenantId <String>]
 [-Confidence <Int32>] [-Description <String>] [-DiamondModel <String>] [-DomainName <String>]
 [-EmailEncoding <String>] [-EmailLanguage <String>] [-EmailRecipient <String>] [-EmailSenderAddress <String>]
 [-EmailSenderName <String>] [-EmailSourceDomain <String>] [-EmailSourceIPAddress <String>]
 [-EmailSubject <String>] [-EmailXMailer <String>] [-ExpirationDateTime <DateTime>] [-ExternalId <String>]
 [-FileCompileDateTime <DateTime>] [-FileCreatedDateTime <DateTime>] [-FileHashType <String>]
 [-FileHashValue <String>] [-FileMutexName <String>] [-FileName <String>] [-FilePacker <String>]
 [-FilePath <String>] [-FileSize <Int64>] [-FileType <String>] [-Id <String>] [-IngestedDateTime <DateTime>]
 [-IsActive] [-KillChain <String[]>] [-KnownFalsePositives <String>] [-LastReportedDateTime <DateTime>]
 [-MalwareFamilyNames <String[]>] [-NetworkCidrBlock <String>] [-NetworkDestinationAsn <Int32>]
 [-NetworkDestinationCidrBlock <String>] [-NetworkDestinationIPv4 <String>] [-NetworkDestinationIPv6 <String>]
 [-NetworkDestinationPort <Int32>] [-NetworkIPv4 <String>] [-NetworkIPv6 <String>] [-NetworkPort <Int32>]
 [-NetworkProtocol <Int32>] [-NetworkSourceAsn <Int32>] [-NetworkSourceCidrBlock <String>]
 [-NetworkSourceIPv4 <String>] [-NetworkSourceIPv6 <String>] [-NetworkSourcePort <Int32>] [-PassiveOnly]
 [-Severity <Int32>] [-Tags <String[]>] [-TargetProduct <String>] [-ThreatType <String>] [-TlpLevel <String>]
 [-Url <String>] [-UserAgent <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgSecurityTiIndicator -TiIndicatorId <String> -BodyParameter <IMicrosoftGraphTiIndicator> [-PassThru]
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityTiIndicator -InputObject <ISecurityIdentity> [-Action <String>]
 [-ActivityGroupNames <String[]>] [-AdditionalInformation <String>] [-AdditionalProperties <Hashtable>]
 [-AzureTenantId <String>] [-Confidence <Int32>] [-Description <String>] [-DiamondModel <String>]
 [-DomainName <String>] [-EmailEncoding <String>] [-EmailLanguage <String>] [-EmailRecipient <String>]
 [-EmailSenderAddress <String>] [-EmailSenderName <String>] [-EmailSourceDomain <String>]
 [-EmailSourceIPAddress <String>] [-EmailSubject <String>] [-EmailXMailer <String>]
 [-ExpirationDateTime <DateTime>] [-ExternalId <String>] [-FileCompileDateTime <DateTime>]
 [-FileCreatedDateTime <DateTime>] [-FileHashType <String>] [-FileHashValue <String>] [-FileMutexName <String>]
 [-FileName <String>] [-FilePacker <String>] [-FilePath <String>] [-FileSize <Int64>] [-FileType <String>]
 [-Id <String>] [-IngestedDateTime <DateTime>] [-IsActive] [-KillChain <String[]>]
 [-KnownFalsePositives <String>] [-LastReportedDateTime <DateTime>] [-MalwareFamilyNames <String[]>]
 [-NetworkCidrBlock <String>] [-NetworkDestinationAsn <Int32>] [-NetworkDestinationCidrBlock <String>]
 [-NetworkDestinationIPv4 <String>] [-NetworkDestinationIPv6 <String>] [-NetworkDestinationPort <Int32>]
 [-NetworkIPv4 <String>] [-NetworkIPv6 <String>] [-NetworkPort <Int32>] [-NetworkProtocol <Int32>]
 [-NetworkSourceAsn <Int32>] [-NetworkSourceCidrBlock <String>] [-NetworkSourceIPv4 <String>]
 [-NetworkSourceIPv6 <String>] [-NetworkSourcePort <Int32>] [-PassiveOnly] [-Severity <Int32>]
 [-Tags <String[]>] [-TargetProduct <String>] [-ThreatType <String>] [-TlpLevel <String>] [-Url <String>]
 [-UserAgent <String>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityTiIndicator -InputObject <ISecurityIdentity> -BodyParameter <IMicrosoftGraphTiIndicator>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property tiIndicators in security

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

### -Action
tiAction

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ActivityGroupNames
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalInformation
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AzureTenantId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
tiIndicator
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphTiIndicator
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Confidence
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DiamondModel
diamondModel

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DomainName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailEncoding
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailLanguage
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailRecipient
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSenderAddress
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSenderName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSourceDomain
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSourceIPAddress
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailSubject
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EmailXMailer
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileCompileDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileCreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileHashType
fileHashType

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileHashValue
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileMutexName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileName
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilePacker
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FilePath
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileSize
.

```yaml
Type: Int64
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IngestedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: ISecurityIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsActive
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -KillChain
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KnownFalsePositives
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastReportedDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MalwareFamilyNames
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkCidrBlock
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDestinationAsn
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDestinationCidrBlock
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDestinationIPv4
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDestinationIPv6
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkDestinationPort
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkIPv4
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkIPv6
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkPort
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkProtocol
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceAsn
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceCidrBlock
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceIPv4
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourceIPv6
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NetworkSourcePort
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassiveOnly
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Severity
.

```yaml
Type: Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: 0
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tags
.

```yaml
Type: String[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetProduct
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ThreatType
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TiIndicatorId
key: id of tiIndicator

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TlpLevel
tlpLevel

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Url
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAgent
.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTiIndicator
### Microsoft.Graph.PowerShell.Models.ISecurityIdentity
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphTiIndicator\>: tiIndicator
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
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

INPUTOBJECT \<ISecurityIdentity\>: Identity Parameter
  \[AlertId \<String\>\]: key: id of alert
  \[CloudAppSecurityProfileId \<String\>\]: key: id of cloudAppSecurityProfile
  \[DomainSecurityProfileId \<String\>\]: key: id of domainSecurityProfile
  \[FileSecurityProfileId \<String\>\]: key: id of fileSecurityProfile
  \[HostSecurityProfileId \<String\>\]: key: id of hostSecurityProfile
  \[IPSecurityProfileId \<String\>\]: key: id of ipSecurityProfile
  \[ProviderTenantSettingId \<String\>\]: key: id of providerTenantSetting
  \[SecureScoreControlProfileId \<String\>\]: key: id of secureScoreControlProfile
  \[SecureScoreId \<String\>\]: key: id of secureScore
  \[SecurityActionId \<String\>\]: key: id of securityAction
  \[TiIndicatorId \<String\>\]: key: id of tiIndicator
  \[UserSecurityProfileId \<String\>\]: key: id of userSecurityProfile

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecuritytiindicator](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.security/update-mgsecuritytiindicator)

