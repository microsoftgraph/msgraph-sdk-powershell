---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.security/update-mgsecuritythreatintelligence
schema: 2.0.0
---

# Update-MgSecurityThreatIntelligence

## SYNOPSIS
Update the navigation property threatIntelligence in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityThreatIntelligence [-AdditionalProperties <Hashtable>]
 [-ArticleIndicators <IMicrosoftGraphSecurityArticleIndicator[]>]
 [-Articles <IMicrosoftGraphSecurityArticle[]>] [-HostComponents <IMicrosoftGraphSecurityHostComponent[]>]
 [-HostCookies <IMicrosoftGraphSecurityHostCookie[]>] [-Hosts <IMicrosoftGraphSecurityHost[]>]
 [-HostTrackers <IMicrosoftGraphSecurityHostTracker[]>] [-Id <String>]
 [-IntelligenceProfileIndicators <IMicrosoftGraphSecurityIntelligenceProfileIndicator[]>]
 [-IntelProfiles <IMicrosoftGraphSecurityIntelligenceProfile[]>]
 [-PassiveDnsRecords <IMicrosoftGraphSecurityPassiveDnsRecord[]>]
 [-Vulnerabilities <IMicrosoftGraphSecurityVulnerability[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityThreatIntelligence -BodyParameter <IMicrosoftGraphSecurityThreatIntelligence> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property threatIntelligence in security

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ArticleIndicators
Refers to indicators of threat or compromise highlighted in an microsoft.graph.security.article.Note: List retrieval is not yet supported.
To construct, see NOTES section for ARTICLEINDICATORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityArticleIndicator[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Articles
A list of article objects.
To construct, see NOTES section for ARTICLES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityArticle[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
threatIntelligence
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityThreatIntelligence
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -HostComponents
Retrieve details about microsoft.graph.security.hostComponent objects.Note: List retrieval is not yet supported.
To construct, see NOTES section for HOSTCOMPONENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostComponent[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostCookies
Retrieve details about microsoft.graph.security.hostCookie objects.Note: List retrieval is not yet supported.
To construct, see NOTES section for HOSTCOOKIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostCookie[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Hosts
Refers to microsoft.graph.security.host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.
To construct, see NOTES section for HOSTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHost[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostTrackers
Retrieve details about microsoft.graph.security.hostTracker objects.Note: List retrieval is not yet supported.
To construct, see NOTES section for HOSTTRACKERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostTracker[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique idenfier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntelligenceProfileIndicators
.
To construct, see NOTES section for INTELLIGENCEPROFILEINDICATORS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIntelligenceProfileIndicator[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IntelProfiles
A list of intelligenceProfile objects.
To construct, see NOTES section for INTELPROFILES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityIntelligenceProfile[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassiveDnsRecords
Retrieve details about microsoft.graph.security.passiveDnsRecord objects.Note: List retrieval is not yet supported.
To construct, see NOTES section for PASSIVEDNSRECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityPassiveDnsRecord[]
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Vulnerabilities
Retrieve details about microsoft.graph.security.vulnerabilities.Note: List retrieval is not yet supported.
To construct, see NOTES section for VULNERABILITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityVulnerability[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityThreatIntelligence

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityThreatIntelligence

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ARTICLEINDICATORS <IMicrosoftGraphSecurityArticleIndicator[]>`: Refers to indicators of threat or compromise highlighted in an microsoft.graph.security.article.Note: List retrieval is not yet supported.
  - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Source <String>]`: indicatorSource
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.

`ARTICLES <IMicrosoftGraphSecurityArticle[]>`: A list of article objects.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Body <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of this formattedContent.
    - `[Format <String>]`: contentFormat
  - `[CreatedDateTime <DateTime?>]`: The date and time when this article was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ImageUrl <String>]`: URL of the header image for this article, used for display purposes.
  - `[Indicators <IMicrosoftGraphSecurityArticleIndicator[]>]`: Indicators related to this article.
    - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Source <String>]`: indicatorSource
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[IsFeatured <Boolean?>]`: Indicates whether this article is currently featured by Microsoft.
  - `[LastUpdatedDateTime <DateTime?>]`: The most recent date and time when this article was updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Summary <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
  - `[Tags <String[]>]`: Tags for this article, communicating keywords, or key concepts.
  - `[Title <String>]`: The title of this article.

`BODYPARAMETER <IMicrosoftGraphSecurityThreatIntelligence>`: threatIntelligence
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ArticleIndicators <IMicrosoftGraphSecurityArticleIndicator[]>]`: Refers to indicators of threat or compromise highlighted in an microsoft.graph.security.article.Note: List retrieval is not yet supported.
    - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Source <String>]`: indicatorSource
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Articles <IMicrosoftGraphSecurityArticle[]>]`: A list of article objects.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Body <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of this formattedContent.
      - `[Format <String>]`: contentFormat
    - `[CreatedDateTime <DateTime?>]`: The date and time when this article was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ImageUrl <String>]`: URL of the header image for this article, used for display purposes.
    - `[Indicators <IMicrosoftGraphSecurityArticleIndicator[]>]`: Indicators related to this article.
    - `[IsFeatured <Boolean?>]`: Indicates whether this article is currently featured by Microsoft.
    - `[LastUpdatedDateTime <DateTime?>]`: The most recent date and time when this article was updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Summary <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[Tags <String[]>]`: Tags for this article, communicating keywords, or key concepts.
    - `[Title <String>]`: The title of this article.
  - `[HostComponents <IMicrosoftGraphSecurityHostComponent[]>]`: Retrieve details about microsoft.graph.security.hostComponent objects.Note: List retrieval is not yet supported.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Domain <String>]`: The URI for which the cookie is valid.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
        - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
      - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
      - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[Classification <String>]`: hostReputationClassification
        - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
          - `[Description <String>]`: The description of the rule that gives more context.
          - `[Name <String>]`: The name of the rule.
          - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
          - `[Severity <String>]`: hostReputationRuleSeverity
        - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
      - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Value <String>]`: The identification value for the hostTracker.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
    - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.
  - `[HostCookies <IMicrosoftGraphSecurityHostCookie[]>]`: Retrieve details about microsoft.graph.security.hostCookie objects.Note: List retrieval is not yet supported.
  - `[HostTrackers <IMicrosoftGraphSecurityHostTracker[]>]`: Retrieve details about microsoft.graph.security.hostTracker objects.Note: List retrieval is not yet supported.
  - `[Hosts <IMicrosoftGraphSecurityHost[]>]`: Refers to microsoft.graph.security.host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.
  - `[IntelProfiles <IMicrosoftGraphSecurityIntelligenceProfile[]>]`: A list of intelligenceProfile objects.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Aliases <String[]>]`: A list of commonly-known aliases for the threat intelligence included in the intelligenceProfile.
    - `[CountriesOrRegionsOfOrigin <IMicrosoftGraphSecurityIntelligenceProfileCountryOrRegionOfOrigin[]>]`: The country/region of origin for the given actor or threat associated with this intelligenceProfile.
      - `[Code <String>]`: A codified representation for this country/region of origin.
      - `[Label <String>]`: A display label for this ountry/region of origin.
    - `[Description <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[FirstActiveDateTime <DateTime?>]`: The date and time when this intelligenceProfile was first active. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Indicators <IMicrosoftGraphSecurityIntelligenceProfileIndicator[]>]`: Includes an assemblage of high-fidelity network indicators of compromise.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[Source <String>]`: indicatorSource
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: Designate when an artifact was first used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.
      - `[LastSeenDateTime <DateTime?>]`: Designate when an artifact was most recently used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.
    - `[Kind <String>]`: intelligenceProfileKind
    - `[Summary <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[Targets <String[]>]`: Known targets related to this intelligenceProfile.
    - `[Title <String>]`: The title of this intelligenceProfile.
    - `[Tradecraft <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
  - `[IntelligenceProfileIndicators <IMicrosoftGraphSecurityIntelligenceProfileIndicator[]>]`: 
  - `[PassiveDnsRecords <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Retrieve details about microsoft.graph.security.passiveDnsRecord objects.Note: List retrieval is not yet supported.
  - `[Vulnerabilities <IMicrosoftGraphSecurityVulnerability[]>]`: Retrieve details about microsoft.graph.security.vulnerabilities.Note: List retrieval is not yet supported.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[ActiveExploitsObserved <Boolean?>]`: Indicates whether this vulnerability has any known exploits associated to known bad actors.
    - `[Articles <IMicrosoftGraphSecurityArticle[]>]`: Articles related to this vulnerability.
    - `[CommonWeaknessEnumerationIds <String[]>]`: Community-defined common weakness enumerations (CWE).
    - `[Components <IMicrosoftGraphSecurityVulnerabilityComponent[]>]`: Components related to this vulnerability article.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Name <String>]`: The name of this vulnerability component.
    - `[CreatedDateTime <DateTime?>]`: The date and time when this vulnerability article was first created.
    - `[Cvss2Summary <IMicrosoftGraphSecurityCvssSummary>]`: cvssSummary
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Score <Double?>]`: The CVSS score about this vulnerability.
      - `[Severity <String>]`: vulnerabilitySeverity
      - `[VectorString <String>]`: The CVSS vector string for this vulnerability.
    - `[Cvss3Summary <IMicrosoftGraphSecurityCvssSummary>]`: cvssSummary
    - `[Description <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[Exploits <IMicrosoftGraphSecurityHyperlink[]>]`: Known exploits for this vulnerability.
      - `[Name <String>]`: The name for this hyperlink.
      - `[Url <String>]`: The URL for this hyperlink.
    - `[ExploitsAvailable <Boolean?>]`: Indicates whether this vulnerability has exploits in public sources (such as Packetstorm or Exploit-DB) online.
    - `[HasChatter <Boolean?>]`: Indicates whether chatter about this vulnerability has been discovered online.
    - `[LastModifiedDateTime <DateTime?>]`: The date and time when this vulnerability article was most recently updated.
    - `[PriorityScore <Int32?>]`: A unique algorithm that reflects the priority of a vulnerability based on the CVSS score, exploits, chatter, and linkage to malware. This property also evaluates the recency of these components so users can understand which vulnerability should be remediated first.
    - `[PublishedDateTime <DateTime?>]`: The date and time when this vulnerability article was published.
    - `[References <IMicrosoftGraphSecurityHyperlink[]>]`: Reference links where further information can be learned about this vulnerability.
    - `[Remediation <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[Severity <String>]`: vulnerabilitySeverity

`HOSTCOMPONENTS <IMicrosoftGraphSecurityHostComponent[]>`: Retrieve details about microsoft.graph.security.hostComponent objects.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
      - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
    - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
    - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Classification <String>]`: hostReputationClassification
      - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
        - `[Description <String>]`: The description of the rule that gives more context.
        - `[Name <String>]`: The name of the rule.
        - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
        - `[Severity <String>]`: hostReputationRuleSeverity
      - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Value <String>]`: The identification value for the hostTracker.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
  - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.

`HOSTCOOKIES <IMicrosoftGraphSecurityHostCookie[]>`: Retrieve details about microsoft.graph.security.hostCookie objects.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Domain <String>]`: The URI for which the cookie is valid.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
      - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
    - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
    - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Classification <String>]`: hostReputationClassification
      - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
        - `[Description <String>]`: The description of the rule that gives more context.
        - `[Name <String>]`: The name of the rule.
        - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
        - `[Severity <String>]`: hostReputationRuleSeverity
      - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Value <String>]`: The identification value for the hostTracker.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.

`HOSTS <IMicrosoftGraphSecurityHost[]>`: Refers to microsoft.graph.security.host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
    - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.
  - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Domain <String>]`: The URI for which the cookie is valid.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
  - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
  - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Classification <String>]`: hostReputationClassification
    - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
      - `[Description <String>]`: The description of the rule that gives more context.
      - `[Name <String>]`: The name of the rule.
      - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
      - `[Severity <String>]`: hostReputationRuleSeverity
    - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
  - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Value <String>]`: The identification value for the hostTracker.

`HOSTTRACKERS <IMicrosoftGraphSecurityHostTracker[]>`: Retrieve details about microsoft.graph.security.hostTracker objects.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
      - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
    - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
    - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Classification <String>]`: hostReputationClassification
      - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
        - `[Description <String>]`: The description of the rule that gives more context.
        - `[Name <String>]`: The name of the rule.
        - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
        - `[Severity <String>]`: hostReputationRuleSeverity
      - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
  - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Value <String>]`: The identification value for the hostTracker.

`INTELLIGENCEPROFILEINDICATORS <IMicrosoftGraphSecurityIntelligenceProfileIndicator[]>`: .
  - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Source <String>]`: indicatorSource
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[FirstSeenDateTime <DateTime?>]`: Designate when an artifact was first used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.
  - `[LastSeenDateTime <DateTime?>]`: Designate when an artifact was most recently used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.

`INTELPROFILES <IMicrosoftGraphSecurityIntelligenceProfile[]>`: A list of intelligenceProfile objects.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Aliases <String[]>]`: A list of commonly-known aliases for the threat intelligence included in the intelligenceProfile.
  - `[CountriesOrRegionsOfOrigin <IMicrosoftGraphSecurityIntelligenceProfileCountryOrRegionOfOrigin[]>]`: The country/region of origin for the given actor or threat associated with this intelligenceProfile.
    - `[Code <String>]`: A codified representation for this country/region of origin.
    - `[Label <String>]`: A display label for this ountry/region of origin.
  - `[Description <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: The content of this formattedContent.
    - `[Format <String>]`: contentFormat
  - `[FirstActiveDateTime <DateTime?>]`: The date and time when this intelligenceProfile was first active. The timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Indicators <IMicrosoftGraphSecurityIntelligenceProfileIndicator[]>]`: Includes an assemblage of high-fidelity network indicators of compromise.
    - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Source <String>]`: indicatorSource
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: Designate when an artifact was first used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.
    - `[LastSeenDateTime <DateTime?>]`: Designate when an artifact was most recently used actively in an attack, when a particular sample was compiled, or if neither of those could be ascertained when the file was first seen in public repositories (for example, VirusTotal, ANY.RUN, Hybrid Analysis) or reported publicly.
  - `[Kind <String>]`: intelligenceProfileKind
  - `[Summary <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
  - `[Targets <String[]>]`: Known targets related to this intelligenceProfile.
  - `[Title <String>]`: The title of this intelligenceProfile.
  - `[Tradecraft <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent

`PASSIVEDNSRECORDS <IMicrosoftGraphSecurityPassiveDnsRecord[]>`: Retrieve details about microsoft.graph.security.passiveDnsRecord objects.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This should not be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
    - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
    - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Classification <String>]`: hostReputationClassification
      - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
        - `[Description <String>]`: The description of the rule that gives more context.
        - `[Name <String>]`: The name of the rule.
        - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
        - `[Severity <String>]`: hostReputationRuleSeverity
      - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Value <String>]`: The identification value for the hostTracker.
  - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.

`VULNERABILITIES <IMicrosoftGraphSecurityVulnerability[]>`: Retrieve details about microsoft.graph.security.vulnerabilities.Note: List retrieval is not yet supported.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ActiveExploitsObserved <Boolean?>]`: Indicates whether this vulnerability has any known exploits associated to known bad actors.
  - `[Articles <IMicrosoftGraphSecurityArticle[]>]`: Articles related to this vulnerability.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Body <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Content <String>]`: The content of this formattedContent.
      - `[Format <String>]`: contentFormat
    - `[CreatedDateTime <DateTime?>]`: The date and time when this article was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ImageUrl <String>]`: URL of the header image for this article, used for display purposes.
    - `[Indicators <IMicrosoftGraphSecurityArticleIndicator[]>]`: Indicators related to this article.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique idenfier for an entity. Read-only.
      - `[Source <String>]`: indicatorSource
      - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[IsFeatured <Boolean?>]`: Indicates whether this article is currently featured by Microsoft.
    - `[LastUpdatedDateTime <DateTime?>]`: The most recent date and time when this article was updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Summary <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
    - `[Tags <String[]>]`: Tags for this article, communicating keywords, or key concepts.
    - `[Title <String>]`: The title of this article.
  - `[CommonWeaknessEnumerationIds <String[]>]`: Community-defined common weakness enumerations (CWE).
  - `[Components <IMicrosoftGraphSecurityVulnerabilityComponent[]>]`: Components related to this vulnerability article.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[Name <String>]`: The name of this vulnerability component.
  - `[CreatedDateTime <DateTime?>]`: The date and time when this vulnerability article was first created.
  - `[Cvss2Summary <IMicrosoftGraphSecurityCvssSummary>]`: cvssSummary
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Score <Double?>]`: The CVSS score about this vulnerability.
    - `[Severity <String>]`: vulnerabilitySeverity
    - `[VectorString <String>]`: The CVSS vector string for this vulnerability.
  - `[Cvss3Summary <IMicrosoftGraphSecurityCvssSummary>]`: cvssSummary
  - `[Description <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
  - `[Exploits <IMicrosoftGraphSecurityHyperlink[]>]`: Known exploits for this vulnerability.
    - `[Name <String>]`: The name for this hyperlink.
    - `[Url <String>]`: The URL for this hyperlink.
  - `[ExploitsAvailable <Boolean?>]`: Indicates whether this vulnerability has exploits in public sources (such as Packetstorm or Exploit-DB) online.
  - `[HasChatter <Boolean?>]`: Indicates whether chatter about this vulnerability has been discovered online.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time when this vulnerability article was most recently updated.
  - `[PriorityScore <Int32?>]`: A unique algorithm that reflects the priority of a vulnerability based on the CVSS score, exploits, chatter, and linkage to malware. This property also evaluates the recency of these components so users can understand which vulnerability should be remediated first.
  - `[PublishedDateTime <DateTime?>]`: The date and time when this vulnerability article was published.
  - `[References <IMicrosoftGraphSecurityHyperlink[]>]`: Reference links where further information can be learned about this vulnerability.
  - `[Remediation <IMicrosoftGraphSecurityFormattedContent>]`: formattedContent
  - `[Severity <String>]`: vulnerabilitySeverity

## RELATED LINKS

