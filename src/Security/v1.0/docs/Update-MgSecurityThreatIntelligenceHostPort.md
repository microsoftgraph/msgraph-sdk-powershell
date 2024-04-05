---
external help file:
Module Name: Microsoft.Graph.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.security/update-mgsecuritythreatintelligencehostport
schema: 2.0.0
---

# Update-MgSecurityThreatIntelligenceHostPort

## SYNOPSIS
Update the navigation property hostPorts in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgSecurityThreatIntelligenceHostPort -HostPortId <String> [-AdditionalProperties <Hashtable>]
 [-Banners <IMicrosoftGraphSecurityHostPortBanner[]>] [-FirstSeenDateTime <DateTime>]
 [-Host1 <IMicrosoftGraphSecurityHost>] [-Id <String>] [-LastScanDateTime <DateTime>]
 [-LastSeenDateTime <DateTime>] [-MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>]
 [-Port <Int32>] [-Protocol <String>] [-ResponseHeadersVariable <String>]
 [-Services <IMicrosoftGraphSecurityHostPortComponent[]>] [-Status <String>] [-TimesObserved <Int32>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgSecurityThreatIntelligenceHostPort -HostPortId <String>
 -BodyParameter <IMicrosoftGraphSecurityHostPort> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgSecurityThreatIntelligenceHostPort -InputObject <ISecurityIdentity>
 -BodyParameter <IMicrosoftGraphSecurityHostPort> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgSecurityThreatIntelligenceHostPort -InputObject <ISecurityIdentity>
 [-AdditionalProperties <Hashtable>] [-Banners <IMicrosoftGraphSecurityHostPortBanner[]>]
 [-FirstSeenDateTime <DateTime>] [-Host1 <IMicrosoftGraphSecurityHost>] [-Id <String>]
 [-LastScanDateTime <DateTime>] [-LastSeenDateTime <DateTime>]
 [-MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>] [-Port <Int32>] [-Protocol <String>]
 [-ResponseHeadersVariable <String>] [-Services <IMicrosoftGraphSecurityHostPortComponent[]>]
 [-Status <String>] [-TimesObserved <Int32>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property hostPorts in security

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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Banners
The hostPortBanners retrieved from scanning the port.
To construct, see NOTES section for BANNERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostPortBanner[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
hostPort
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostPort
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -FirstSeenDateTime
The first date and time when Microsoft Defender Threat Intelligence observed the hostPort.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Host1
host
To construct, see NOTES section for HOST1 properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHost
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HostPortId
The unique identifier of hostPort

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
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
Type: Microsoft.Graph.PowerShell.Models.ISecurityIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -LastScanDateTime
The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastSeenDateTime
The last date and time when Microsoft Defender Threat Intelligence observed the hostPort.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MostRecentSslCertificate
sslCertificate
To construct, see NOTES section for MOSTRECENTSSLCERTIFICATE properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecuritySslCertificate
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Port
The numerical identifier of the port which is standardized across the internet.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Protocol
hostPortProtocol

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Services
The hostPortComponents retrieved from scanning the port.
To construct, see NOTES section for SERVICES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostPortComponent[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
hostPortStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TimesObserved
The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.

```yaml
Type: System.Int32
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostPort

### Microsoft.Graph.PowerShell.Models.ISecurityIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSecurityHostPort

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BANNERS <IMicrosoftGraphSecurityHostPortBanner[]>`: The hostPortBanners retrieved from scanning the port.
  - `[Banner <String>]`: The text response received from a web component when scanning a hostPort.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[ScanProtocol <String>]`: The specific protocol used to scan the hostPort.
  - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPortBanner in all its scans.

`BODYPARAMETER <IMicrosoftGraphSecurityHostPort>`: hostPort
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: The hostPortBanners retrieved from scanning the port.
    - `[Banner <String>]`: The text response received from a web component when scanning a hostPort.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[ScanProtocol <String>]`: The specific protocol used to scan the hostPort.
    - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPortBanner in all its scans.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a childHost.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence last observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
    - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: The hostPorts associated with a host.
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
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Port <Int32?>]`: The port number.
      - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
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
            - `[PostalCode <String>]`: The postal code.
            - `[State <String>]`: The state.
            - `[Street <String>]`: The street.
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
    - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
      - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
      - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[WhoisServer <String>]`: The WHOIS server that provides the details.
      - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
        - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[DomainStatus <String>]`: The domain status for this WHOIS object.
        - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
        - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[WhoisServer <String>]`: The WHOIS server that provides the details.
        - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[LastScanDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
  - `[Port <Int32?>]`: The numerical identifier of the port which is standardized across the internet.
  - `[Protocol <String>]`: hostPortProtocol
  - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: The hostPortComponents retrieved from scanning the port.
    - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[IsRecent <Boolean?>]`: Indicates whether this hostPortComponent is recent, which is determined by whether the hostPortComponent was observed either at the same time or after the latest hostPortBanner in the scan history, or within two days of the latest scan of the hostPort when there are no hostPortBanners in the scan history.
    - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[Status <String>]`: hostPortStatus
  - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.

`HOST1 <IMicrosoftGraphSecurityHost>`: host
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a childHost.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
    - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence last observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
    - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
  - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
    - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
  - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Domain <String>]`: The URI for which the cookie is valid.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
  - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
  - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: The hostPorts associated with a host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: The hostPortBanners retrieved from scanning the port.
      - `[Banner <String>]`: The text response received from a web component when scanning a hostPort.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[ScanProtocol <String>]`: The specific protocol used to scan the hostPort.
      - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPortBanner in all its scans.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastScanDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
          - `[PostalCode <String>]`: The postal code.
          - `[State <String>]`: The state.
          - `[Street <String>]`: The street.
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
    - `[Port <Int32?>]`: The numerical identifier of the port which is standardized across the internet.
    - `[Protocol <String>]`: hostPortProtocol
    - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: The hostPortComponents retrieved from scanning the port.
      - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[IsRecent <Boolean?>]`: Indicates whether this hostPortComponent is recent, which is determined by whether the hostPortComponent was observed either at the same time or after the latest hostPortBanner in the scan history, or within two days of the latest scan of the hostPort when there are no hostPortBanners in the scan history.
      - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Status <String>]`: hostPortStatus
    - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.
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
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Port <Int32?>]`: The port number.
    - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
  - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
  - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
    - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
    - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[WhoisServer <String>]`: The WHOIS server that provides the details.
    - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
      - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[DomainStatus <String>]`: The domain status for this WHOIS object.
      - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
      - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
      - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[WhoisServer <String>]`: The WHOIS server that provides the details.
      - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Id <String>]`: The unique identifier for an entity. Read-only.

`INPUTOBJECT <ISecurityIdentity>`: Identity Parameter
  - `[AlertId <String>]`: The unique identifier of alert
  - `[ArticleId <String>]`: The unique identifier of article
  - `[ArticleIndicatorId <String>]`: The unique identifier of articleIndicator
  - `[AttackSimulationOperationId <String>]`: The unique identifier of attackSimulationOperation
  - `[AuthoredNoteId <String>]`: The unique identifier of authoredNote
  - `[AuthorityTemplateId <String>]`: The unique identifier of authorityTemplate
  - `[CaseOperationId <String>]`: The unique identifier of caseOperation
  - `[CategoryTemplateId <String>]`: The unique identifier of categoryTemplate
  - `[CitationTemplateId <String>]`: The unique identifier of citationTemplate
  - `[DataSourceId <String>]`: The unique identifier of dataSource
  - `[DepartmentTemplateId <String>]`: The unique identifier of departmentTemplate
  - `[DispositionReviewStageNumber <String>]`: The unique identifier of dispositionReviewStage
  - `[EdiscoveryCaseId <String>]`: The unique identifier of ediscoveryCase
  - `[EdiscoveryCustodianId <String>]`: The unique identifier of ediscoveryCustodian
  - `[EdiscoveryNoncustodialDataSourceId <String>]`: The unique identifier of ediscoveryNoncustodialDataSource
  - `[EdiscoveryReviewSetId <String>]`: The unique identifier of ediscoveryReviewSet
  - `[EdiscoveryReviewSetQueryId <String>]`: The unique identifier of ediscoveryReviewSetQuery
  - `[EdiscoveryReviewTagId <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoveryReviewTagId1 <String>]`: The unique identifier of ediscoveryReviewTag
  - `[EdiscoverySearchId <String>]`: The unique identifier of ediscoverySearch
  - `[EndUserNotificationDetailId <String>]`: The unique identifier of endUserNotificationDetail
  - `[EndUserNotificationId <String>]`: The unique identifier of endUserNotification
  - `[FilePlanReferenceTemplateId <String>]`: The unique identifier of filePlanReferenceTemplate
  - `[HostComponentId <String>]`: The unique identifier of hostComponent
  - `[HostCookieId <String>]`: The unique identifier of hostCookie
  - `[HostId <String>]`: The unique identifier of host
  - `[HostPairId <String>]`: The unique identifier of hostPair
  - `[HostPortId <String>]`: The unique identifier of hostPort
  - `[HostSslCertificateId <String>]`: The unique identifier of hostSslCertificate
  - `[HostTrackerId <String>]`: The unique identifier of hostTracker
  - `[IncidentId <String>]`: The unique identifier of incident
  - `[IntelligenceProfileId <String>]`: The unique identifier of intelligenceProfile
  - `[IntelligenceProfileIndicatorId <String>]`: The unique identifier of intelligenceProfileIndicator
  - `[LandingPageDetailId <String>]`: The unique identifier of landingPageDetail
  - `[LandingPageId <String>]`: The unique identifier of landingPage
  - `[LoginPageId <String>]`: The unique identifier of loginPage
  - `[PassiveDnsRecordId <String>]`: The unique identifier of passiveDnsRecord
  - `[PayloadId <String>]`: The unique identifier of payload
  - `[RetentionEventId <String>]`: The unique identifier of retentionEvent
  - `[RetentionEventTypeId <String>]`: The unique identifier of retentionEventType
  - `[RetentionLabelId <String>]`: The unique identifier of retentionLabel
  - `[SecureScoreControlProfileId <String>]`: The unique identifier of secureScoreControlProfile
  - `[SecureScoreId <String>]`: The unique identifier of secureScore
  - `[SimulationAutomationId <String>]`: The unique identifier of simulationAutomation
  - `[SimulationAutomationRunId <String>]`: The unique identifier of simulationAutomationRun
  - `[SimulationId <String>]`: The unique identifier of simulation
  - `[SiteSourceId <String>]`: The unique identifier of siteSource
  - `[SslCertificateId <String>]`: The unique identifier of sslCertificate
  - `[SubcategoryTemplateId <String>]`: The unique identifier of subcategoryTemplate
  - `[SubdomainId <String>]`: The unique identifier of subdomain
  - `[SubjectRightsRequestId <String>]`: The unique identifier of subjectRightsRequest
  - `[TrainingId <String>]`: The unique identifier of training
  - `[TrainingLanguageDetailId <String>]`: The unique identifier of trainingLanguageDetail
  - `[UnifiedGroupSourceId <String>]`: The unique identifier of unifiedGroupSource
  - `[UserId <String>]`: The unique identifier of user
  - `[UserSourceId <String>]`: The unique identifier of userSource
  - `[VulnerabilityComponentId <String>]`: The unique identifier of vulnerabilityComponent
  - `[VulnerabilityId <String>]`: The unique identifier of vulnerability
  - `[WhoisHistoryRecordId <String>]`: The unique identifier of whoisHistoryRecord
  - `[WhoisRecordId <String>]`: The unique identifier of whoisRecord

`MOSTRECENTSSLCERTIFICATE <IMicrosoftGraphSecuritySslCertificate>`: sslCertificate
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
      - `[PostalCode <String>]`: The postal code.
      - `[State <String>]`: The state.
      - `[Street <String>]`: The street.
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
    - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a childHost.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence last observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
      - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
    - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
      - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
    - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Domain <String>]`: The URI for which the cookie is valid.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
    - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: The hostPorts associated with a host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: The hostPortBanners retrieved from scanning the port.
        - `[Banner <String>]`: The text response received from a web component when scanning a hostPort.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[ScanProtocol <String>]`: The specific protocol used to scan the hostPort.
        - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPortBanner in all its scans.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastScanDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[MostRecentSslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
      - `[Port <Int32?>]`: The numerical identifier of the port which is standardized across the internet.
      - `[Protocol <String>]`: hostPortProtocol
      - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: The hostPortComponents retrieved from scanning the port.
        - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[IsRecent <Boolean?>]`: Indicates whether this hostPortComponent is recent, which is determined by whether the hostPortComponent was observed either at the same time or after the latest hostPortBanner in the scan history, or within two days of the latest scan of the hostPort when there are no hostPortBanners in the scan history.
        - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Status <String>]`: hostPortStatus
      - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.
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
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Port <Int32?>]`: The port number.
      - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
    - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
    - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
      - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
      - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[WhoisServer <String>]`: The WHOIS server that provides the details.
      - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
        - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[DomainStatus <String>]`: The domain status for this WHOIS object.
        - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
        - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
        - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[WhoisServer <String>]`: The WHOIS server that provides the details.
        - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[SerialNumber <String>]`: The serial number associated with an SSL certificate.
  - `[Sha1 <String>]`: A SHA-1 hash of the certificate. Note: This is not the signature.
  - `[Subject <IMicrosoftGraphSecuritySslCertificateEntity>]`: sslCertificateEntity

`SERVICES <IMicrosoftGraphSecurityHostPortComponent[]>`: The hostPortComponents retrieved from scanning the port.
  - `[Component <IMicrosoftGraphSecurityHostComponent>]`: hostComponent
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Category <String>]`: The type of component that was detected (for example, Operating System, Framework, Remote Access, or Server).
    - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ChildHostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are resources associated with a host, where that host is the parentHost and has an outgoing pairing to a childHost.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[ChildHost <IMicrosoftGraphSecurityHost>]`: host
        - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence last observed the hostPair. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LinkKind <String>]`: The reason that two hosts are identified as hostPair.
        - `[ParentHost <IMicrosoftGraphSecurityHost>]`: host
      - `[Components <IMicrosoftGraphSecurityHostComponent[]>]`: The hostComponents that are associated with this host.
      - `[Cookies <IMicrosoftGraphSecurityHostCookie[]>]`: The hostCookies that are associated with this host.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Domain <String>]`: The URI for which the cookie is valid.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostCookie was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Name <String>]`: The name of the cookie, for example, JSESSIONID or SEARCH_NAMESITE.
      - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
      - `[HostPairs <IMicrosoftGraphSecurityHostPair[]>]`: The hostPairs that are associated with this host, where this host is either the parentHost or childHost.
      - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this host was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
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
      - `[Ports <IMicrosoftGraphSecurityHostPort[]>]`: The hostPorts associated with a host.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[Banners <IMicrosoftGraphSecurityHostPortBanner[]>]`: The hostPortBanners retrieved from scanning the port.
          - `[Banner <String>]`: The text response received from a web component when scanning a hostPort.
          - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
          - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortBanner. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
          - `[ScanProtocol <String>]`: The specific protocol used to scan the hostPort.
          - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPortBanner in all its scans.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastScanDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
              - `[PostalCode <String>]`: The postal code.
              - `[State <String>]`: The state.
              - `[Street <String>]`: The street.
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
        - `[Port <Int32?>]`: The numerical identifier of the port which is standardized across the internet.
        - `[Protocol <String>]`: hostPortProtocol
        - `[Services <IMicrosoftGraphSecurityHostPortComponent[]>]`: The hostPortComponents retrieved from scanning the port.
        - `[Status <String>]`: hostPortStatus
        - `[TimesObserved <Int32?>]`: The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.
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
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostSslCertificate was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Ports <IMicrosoftGraphSecurityHostSslCertificatePort[]>]`: The ports related with this hostSslCertificate.
          - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this port was observed. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Port <Int32?>]`: The port number.
        - `[SslCertificate <IMicrosoftGraphSecuritySslCertificate>]`: sslCertificate
      - `[Subdomains <IMicrosoftGraphSecuritySubdomain[]>]`: The subdomains that are associated with this host.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[FirstSeenDateTime <DateTime?>]`: The date and time when Microsoft Defender Threat Intelligence first observed the subdomain. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
      - `[Trackers <IMicrosoftGraphSecurityHostTracker[]>]`: The hostTrackers that are associated with this host.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[FirstSeenDateTime <DateTime?>]`: The first date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[Kind <String>]`: The kind of hostTracker that was detected. For example, GoogleAnalyticsID or JarmHash.
        - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when this hostTracker was observed by Microsoft Defender Threat Intelligence. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
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
        - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Host <IMicrosoftGraphSecurityHost>]`: host
        - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
          - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Host <IMicrosoftGraphSecurityHost>]`: host
          - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS contact. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
        - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[WhoisServer <String>]`: The WHOIS server that provides the details.
        - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[History <IMicrosoftGraphSecurityWhoisHistoryRecord[]>]`: The collection of historical records associated to this WHOIS object.
          - `[Abuse <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[Admin <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[Billing <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[DomainStatus <String>]`: The domain status for this WHOIS object.
          - `[ExpirationDateTime <DateTime?>]`: The date and time when this WHOIS record expires with the registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[FirstSeenDateTime <DateTime?>]`: The first seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Host <IMicrosoftGraphSecurityHost>]`: host
          - `[LastSeenDateTime <DateTime?>]`: The last seen date and time of this WHOIS record. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[LastUpdateDateTime <DateTime?>]`: The date and time when this WHOIS record was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Nameservers <IMicrosoftGraphSecurityWhoisNameserver[]>]`: The nameservers for this WHOIS object.
          - `[Noc <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[RawWhoisText <String>]`: The raw WHOIS details for this WHOIS object.
          - `[Registrant <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[Registrar <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[RegistrationDateTime <DateTime?>]`: The date and time when this WHOIS record was registered with a registrar. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Technical <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[WhoisServer <String>]`: The WHOIS server that provides the details.
          - `[Zone <IMicrosoftGraphSecurityWhoisContact>]`: whoisContact
          - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[LastSeenDateTime <DateTime?>]`: The most recent date and time when Microsoft Defender Threat Intelligence observed this web component. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
    - `[Name <String>]`: A name running on the artifact, for example, Microsoft IIS.
    - `[Version <String>]`: The component version running on the artifact, for example, v8.5. This shouldn't be assumed to be strictly numerical.
  - `[FirstSeenDateTime <DateTime?>]`: The first date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.
  - `[IsRecent <Boolean?>]`: Indicates whether this hostPortComponent is recent, which is determined by whether the hostPortComponent was observed either at the same time or after the latest hostPortBanner in the scan history, or within two days of the latest scan of the hostPort when there are no hostPortBanners in the scan history.
  - `[LastSeenDateTime <DateTime?>]`: The last date and time when Microsoft Defender Threat Intelligence observed the hostPortComponent. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.

## RELATED LINKS

