---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecuritythreatintelligencesslcertificate
schema: 2.0.0
---

# New-MgBetaSecurityThreatIntelligenceSslCertificate

## SYNOPSIS
Create new navigation property to sslCertificates for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityThreatIntelligenceSslCertificate [-AdditionalProperties <Hashtable>]
 [-ExpirationDateTime <DateTime>] [-Fingerprint <String>] [-FirstSeenDateTime <DateTime>] [-Id <String>]
 [-IssueDateTime <DateTime>] [-Issuer <IMicrosoftGraphSecuritySslCertificateEntity>]
 [-LastSeenDateTime <DateTime>] [-RelatedHosts <IMicrosoftGraphSecurityHost[]>] [-SerialNumber <String>]
 [-Sha1 <String>] [-Subject <IMicrosoftGraphSecuritySslCertificateEntity>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityThreatIntelligenceSslCertificate -BodyParameter <IMicrosoftGraphSecuritySslCertificate>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to sslCertificates for security

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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
sslCertificate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySslCertificate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ExpirationDateTime
The date and time when a certificate expires.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Fingerprint
A hash of the certificate calculated on the data and signature.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FirstSeenDateTime
The first date and time when this sslCertificate was observed.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IssueDateTime
The date and time when a certificate was issued.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Issuer
sslCertificateEntity
To construct, see NOTES section for ISSUER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySslCertificateEntity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSeenDateTime
The most recent date and time when this sslCertificate was observed.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RelatedHosts
The hosts related with this sslCertificate.
To construct, see NOTES section for RELATEDHOSTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityHost[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SerialNumber
The serial number associated with an SSL certificate.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sha1
A SHA-1 hash of the certificate.
Note: This is not the signature.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
sslCertificateEntity
To construct, see NOTES section for SUBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySslCertificateEntity
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySslCertificate

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySslCertificate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecuritySslCertificate>`: sslCertificate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ExpirationDateTime <DateTime?>]`: The date and time when a certificate expires. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Fingerprint <String>]`: A hash of the certificate calculated on the data and signature.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[IssueDateTime <DateTime?>]`: The date and time when a certificate was issued. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Issuer <IMicrosoftGraphSecuritySslCertificateEntity>]`: sslCertificateEntity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[City <String>]`: The city.
      - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
      - `[PostOfficeBox <String>]`: The post office box number.
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
      - `[Type <String>]`: physicalAddressType
    - `[AlternateNames <String[]>]`: Alternate names for this entity that are part of the certificate.
    - `[CommonName <String>]`: A common name for this entity.
    - `[Email <String>]`: An email for this entity.
    - `[GivenName <String>]`: If the entity is a person, this is the person's given name (first name).
    - `[OrganizationName <String>]`: If the entity is an organization, this is the name of the organization.
    - `[OrganizationUnitName <String>]`: If the entity is an organization, this communicates if a unit in the organization is named on the entity.
    - `[SerialNumber <String>]`: A serial number assigned to the entity; usually only available if the entity is the issuer.
    - `[Surname <String>]`: If the entity is a person, this is the person's surname (last name).
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[RelatedHosts <IMicrosoftGraphSecurityHost[]>]`: The hosts related with this sslCertificate.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a cihldHost.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this web component was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this web component was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ParentHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with a host, where that host is the childHost and has an incoming pairing with a parentHost.
    - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
      - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
    - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
    - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: 
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: 
        - `[Banner <String>]`: 
        - `[FirstSeenDateTime <DateTime?>]`: 
        - `[LastSeenDateTime <DateTime?>]`: 
        - `[ScanProtocol <String>]`: 
        - `[TimesObserved <Int32?>]`: 
      - `[FirstSeenDateTime <DateTime?>]`: 
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastScanDateTime <DateTime?>]`: 
      - `[LastSeenDateTime <DateTime?>]`: 
      - `[MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
      - `[Port <Int32?>]`: 
      - `[Protocol <String>]`: hostPortProtocol
      - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: 
        - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
        - `[FirstSeenDateTime <DateTime?>]`: 
        - `[IsRecent <Boolean?>]`: 
        - `[LastSeenDateTime <DateTime?>]`: 
      - `[Status <String>]`: hostPortStatus
      - `[TimesObserved <Int32?>]`: 
    - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Classification <String>]`: hostReputationClassification
      - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
        - `[Description <String>]`: The description of the rule that gives more context.
        - `[Name <String>]`: The name of the rule.
        - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
        - `[Severity <String>]`: hostReputationRuleSeverity
      - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
    - `[SslCertificates <IMicrosoftGraphSecurityHostSslCertificate[]>]`: The hostSslCertificates that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time that this port was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time that this port was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Port <Int32?>]`: The port number.
      - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
    - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Value <String>]`: The identification value for the hostTracker.
    - `[Whois <IMicrosoftGraphSecurityWhoisRecord>]`: whoisRecord
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
        - `[Email <String>]`: The email of this WHOIS contact.
        - `[Fax <String>]`: The fax of this WHOIS contact. No format is guaranteed.
        - `[Name <String>]`: The name of this WHOIS contact.
        - `[Organization <String>]`: The organization of this WHOIS contact.
        - `[Telephone <String>]`: The telephone of this WHOIS contact. No format is guaranteed.
      - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[DomainStatus <String>]`: The domain status for this WHOIS object.
      - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
      - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[WhoisServer <String>]`: The WHOIS server that provides the details.
      - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
        - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[DomainStatus <String>]`: The domain status for this WHOIS object.
        - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
        - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[WhoisServer <String>]`: The WHOIS server that provides the details.
        - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[SerialNumber <String>]`: The serial number associated with an SSL certificate.
  - `[Sha1 <String>]`: A SHA-1 hash of the certificate. Note: This is not the signature.
  - `[Subject <IMicrosoftGraphSecuritySslCertificateEntity>]`: sslCertificateEntity

`ISSUER <IMicrosoftGraphSecuritySslCertificateEntity>`: sslCertificateEntity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[AlternateNames <String[]>]`: Alternate names for this entity that are part of the certificate.
  - `[CommonName <String>]`: A common name for this entity.
  - `[Email <String>]`: An email for this entity.
  - `[GivenName <String>]`: If the entity is a person, this is the person's given name (first name).
  - `[OrganizationName <String>]`: If the entity is an organization, this is the name of the organization.
  - `[OrganizationUnitName <String>]`: If the entity is an organization, this communicates if a unit in the organization is named on the entity.
  - `[SerialNumber <String>]`: A serial number assigned to the entity; usually only available if the entity is the issuer.
  - `[Surname <String>]`: If the entity is a person, this is the person's surname (last name).

`RELATEDHOSTS <IMicrosoftGraphSecurityHost[]>`: The hosts related with this sslCertificate.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a cihldHost.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
    - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
  - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this web component was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this web component was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
    - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
  - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Domain <String>]`: The URI for which the cookie is valid.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ParentHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with a host, where that host is the childHost and has an incoming pairing with a parentHost.
  - `[PassiveDns <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Passive DNS retrieval about this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Artifact <IMicrosoftGraphSecurityArtifact>]`: artifact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CollectedDateTime <DateTime?>]`: The date and time that this passiveDnsRecord entry was collected by Microsoft. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[FirstSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was first seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The date and time when this passiveDnsRecord entry was most recently seen. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[RecordType <String>]`: The DNS record type for this passiveDnsRecord entry.
  - `[PassiveDnsReverse <IMicrosoftGraphSecurityPassiveDnsRecord[]>]`: Reverse passive DNS retrieval about this host.
  - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: 
      - `[Banner <String>]`: 
      - `[FirstSeenDateTime <DateTime?>]`: 
      - `[LastSeenDateTime <DateTime?>]`: 
      - `[ScanProtocol <String>]`: 
      - `[TimesObserved <Int32?>]`: 
    - `[FirstSeenDateTime <DateTime?>]`: 
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastScanDateTime <DateTime?>]`: 
    - `[LastSeenDateTime <DateTime?>]`: 
    - `[MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ExpirationDateTime <DateTime?>]`: The date and time when a certificate expires. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Fingerprint <String>]`: A hash of the certificate calculated on the data and signature.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[IssueDateTime <DateTime?>]`: The date and time when a certificate was issued. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Issuer <IMicrosoftGraphSecuritySslCertificateEntity>]`: sslCertificateEntity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[City <String>]`: The city.
          - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
          - `[PostOfficeBox <String>]`: The post office box number.
          - `[PostalCode <String>]`: The postal code.
          - `[State <String>]`: The state.
          - `[Street <String>]`: The street.
          - `[Type <String>]`: physicalAddressType
        - `[AlternateNames <String[]>]`: Alternate names for this entity that are part of the certificate.
        - `[CommonName <String>]`: A common name for this entity.
        - `[Email <String>]`: An email for this entity.
        - `[GivenName <String>]`: If the entity is a person, this is the person's given name (first name).
        - `[OrganizationName <String>]`: If the entity is an organization, this is the name of the organization.
        - `[OrganizationUnitName <String>]`: If the entity is an organization, this communicates if a unit in the organization is named on the entity.
        - `[SerialNumber <String>]`: A serial number assigned to the entity; usually only available if the entity is the issuer.
        - `[Surname <String>]`: If the entity is a person, this is the person's surname (last name).
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this sslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[RelatedHosts <IMicrosoftGraphSecurityHost[]>]`: The hosts related with this sslCertificate.
      - `[SerialNumber <String>]`: The serial number associated with an SSL certificate.
      - `[Sha1 <String>]`: A SHA-1 hash of the certificate. Note: This is not the signature.
      - `[Subject <IMicrosoftGraphSecuritySslCertificateEntity>]`: sslCertificateEntity
    - `[Port <Int32?>]`: 
    - `[Protocol <String>]`: hostPortProtocol
    - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: 
      - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
      - `[FirstSeenDateTime <DateTime?>]`: 
      - `[IsRecent <Boolean?>]`: 
      - `[LastSeenDateTime <DateTime?>]`: 
    - `[Status <String>]`: hostPortStatus
    - `[TimesObserved <Int32?>]`: 
  - `[Reputation <IMicrosoftGraphSecurityHostReputation>]`: hostReputation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Classification <String>]`: hostReputationClassification
    - `[Rules <IMicrosoftGraphSecurityHostReputationRule[]>]`: A collection of rules that have been used to calculate the classification and score.
      - `[Description <String>]`: The description of the rule that gives more context.
      - `[Name <String>]`: The name of the rule.
      - `[RelatedDetailsUrl <String>]`: Link to a web page with details related to this rule.
      - `[Severity <String>]`: hostReputationRuleSeverity
    - `[Score <Int32?>]`: The calculated score (0-100) of the requested host. A higher value indicates that this host is more likely to be suspicious or malicious.
  - `[SslCertificates <IMicrosoftGraphSecurityHostSslCertificate[]>]`: The hostSslCertificates that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time that this hostSslCertificate was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time that this port was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time that this port was observed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Port <Int32?>]`: The port number.
    - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
  - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
  - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Value <String>]`: The identification value for the hostTracker.
  - `[Whois <IMicrosoftGraphSecurityWhoisRecord>]`: whoisRecord
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
      - `[Email <String>]`: The email of this WHOIS contact.
      - `[Fax <String>]`: The fax of this WHOIS contact. No format is guaranteed.
      - `[Name <String>]`: The name of this WHOIS contact.
      - `[Organization <String>]`: The organization of this WHOIS contact.
      - `[Telephone <String>]`: The telephone of this WHOIS contact. No format is guaranteed.
    - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[DomainStatus <String>]`: The domain status for this WHOIS object.
    - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
    - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[WhoisServer <String>]`: The WHOIS server that provides the details.
    - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
      - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[DomainStatus <String>]`: The domain status for this WHOIS object.
      - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
      - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
      - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[WhoisServer <String>]`: The WHOIS server that provides the details.
      - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Id <String>]`: The unique identifier for an entity. Read-only.

`SUBJECT <IMicrosoftGraphSecuritySslCertificateEntity>`: sslCertificateEntity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Address <IMicrosoftGraphPhysicalAddress>]`: physicalAddress
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: The city.
    - `[CountryOrRegion <String>]`: The country or region. It's a free-format string value, for example, 'United States'.
    - `[PostOfficeBox <String>]`: The post office box number.
    - `[PostalCode <String>]`: The postal code.
    - `[State <String>]`: The state.
    - `[Street <String>]`: The street.
    - `[Type <String>]`: physicalAddressType
  - `[AlternateNames <String[]>]`: Alternate names for this entity that are part of the certificate.
  - `[CommonName <String>]`: A common name for this entity.
  - `[Email <String>]`: An email for this entity.
  - `[GivenName <String>]`: If the entity is a person, this is the person's given name (first name).
  - `[OrganizationName <String>]`: If the entity is an organization, this is the name of the organization.
  - `[OrganizationUnitName <String>]`: If the entity is an organization, this communicates if a unit in the organization is named on the entity.
  - `[SerialNumber <String>]`: A serial number assigned to the entity; usually only available if the entity is the issuer.
  - `[Surname <String>]`: If the entity is a person, this is the person's surname (last name).

## RELATED LINKS

