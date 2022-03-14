---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgriskdetection
schema: 2.0.0
---

# New-MgRiskDetection

## SYNOPSIS
Add new entity to riskDetections

## SYNTAX

### CreateExpanded (Default)
```
New-MgRiskDetection [-Activity <String>] [-ActivityDateTime <DateTime>] [-AdditionalInfo <String>]
 [-AdditionalProperties <Hashtable>] [-CorrelationId <String>] [-DetectedDateTime <DateTime>]
 [-DetectionTimingType <String>] [-Id <String>] [-IPAddress <String>] [-LastUpdatedDateTime <DateTime>]
 [-Location <IMicrosoftGraphSignInLocation>] [-RequestId <String>] [-RiskDetail <String>]
 [-RiskEventType <String>] [-RiskLevel <String>] [-RiskState <String>] [-RiskType <String>] [-Source <String>]
 [-TokenIssuerType <String>] [-UserDisplayName <String>] [-UserId <String>] [-UserPrincipalName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgRiskDetection -BodyParameter <IMicrosoftGraphRiskDetection> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to riskDetections

## EXAMPLES

## PARAMETERS

### -Activity
activityType

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

### -ActivityDateTime
Date and time that the risky activity occurred.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z

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

### -AdditionalInfo
Additional information associated with the risk detection in JSON format.
For example, '[{/'Key/':/'userAgent/',/'Value/':/'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36/'}]'.
Possible keys in the additionalInfo JSON string are: userAgent, alertUrl, relatedEventTimeInUtc, relatedUserAgent, deviceInformation, relatedLocation, requestId, correlationId, lastActivityTimeInUtc, malwareName, clientLocation, clientIp, riskReasons.
For more information about riskReasons and possible values, see riskReasons values.

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
riskDetection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskDetection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CorrelationId
Correlation ID of the sign-in associated with the risk detection.
This property is null if the risk detection is not associated with a sign-in.

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

### -DetectedDateTime
Date and time that the risk was detected.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 looks like this: 2014-01-01T00:00:00Z

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

### -DetectionTimingType
riskDetectionTimingType

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

### -Id
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

### -IPAddress
Provides the IP address of the client from where the risk occurred.

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

### -LastUpdatedDateTime
Date and time that the risk detection was last updated.
The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z

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

### -Location
signInLocation
To construct, please use Get-Help -Online and see NOTES section for LOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSignInLocation
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RequestId
Request ID of the sign-in associated with the risk detection.
This property is null if the risk detection is not associated with a sign-in.

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

### -RiskDetail
riskDetail

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

### -RiskEventType
The type of risk event detected.
The possible values are unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic,adminConfirmedUserCompromised, passwordSpray, impossibleTravel, newCountry, anomalousToken, tokenIssuerAnomaly,suspiciousBrowser, riskyIPAddress, mcasSuspiciousInboxManipulationRules, suspiciousInboxForwarding, and unknownFutureValue.
If the risk detection is a premium detection, will show generic.
For more information about each value, see riskEventType values.

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

### -RiskLevel
riskLevel

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

### -RiskState
riskState

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

### -RiskType
riskEventType

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

### -Source
Source of the risk detection.
For example, activeDirectory.

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

### -TokenIssuerType
tokenIssuerType

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

### -UserDisplayName
The user principal name (UPN) of the user.

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

### -UserId
Unique ID of the user.

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

### -UserPrincipalName
The user principal name (UPN) of the user.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskDetection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphRiskDetection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphRiskDetection>: riskDetection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[Activity <String>]`: activityType
  - `[ActivityDateTime <DateTime?>]`: Date and time that the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z
  - `[AdditionalInfo <String>]`: Additional information associated with the risk detection in JSON format. For example, '[{/'Key/':/'userAgent/',/'Value/':/'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36/'}]'. Possible keys in the additionalInfo JSON string are: userAgent, alertUrl, relatedEventTimeInUtc, relatedUserAgent, deviceInformation, relatedLocation, requestId, correlationId, lastActivityTimeInUtc, malwareName, clientLocation, clientIp, riskReasons. For more information about riskReasons and possible values, see riskReasons values.
  - `[CorrelationId <String>]`: Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
  - `[DetectedDateTime <DateTime?>]`: Date and time that the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 looks like this: 2014-01-01T00:00:00Z
  - `[DetectionTimingType <String>]`: riskDetectionTimingType
  - `[IPAddress <String>]`: Provides the IP address of the client from where the risk occurred.
  - `[LastUpdatedDateTime <DateTime?>]`: Date and time that the risk detection was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is look like this: 2014-01-01T00:00:00Z
  - `[Location <IMicrosoftGraphSignInLocation>]`: signInLocation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[City <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
    - `[CountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
    - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
      - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
      - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
    - `[State <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[RequestId <String>]`: Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.
  - `[RiskDetail <String>]`: riskDetail
  - `[RiskEventType <String>]`: The type of risk event detected. The possible values are unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic,adminConfirmedUserCompromised, passwordSpray, impossibleTravel, newCountry, anomalousToken, tokenIssuerAnomaly,suspiciousBrowser, riskyIPAddress, mcasSuspiciousInboxManipulationRules, suspiciousInboxForwarding, and unknownFutureValue. If the risk detection is a premium detection, will show generic. For more information about each value, see riskEventType values.
  - `[RiskLevel <String>]`: riskLevel
  - `[RiskState <String>]`: riskState
  - `[RiskType <String>]`: riskEventType
  - `[Source <String>]`: Source of the risk detection. For example, activeDirectory.
  - `[TokenIssuerType <String>]`: tokenIssuerType
  - `[UserDisplayName <String>]`: The user principal name (UPN) of the user.
  - `[UserId <String>]`: Unique ID of the user.
  - `[UserPrincipalName <String>]`: The user principal name (UPN) of the user.

LOCATION <IMicrosoftGraphSignInLocation>: signInLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[City <String>]`: Provides the city where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.
  - `[CountryOrRegion <String>]`: Provides the country code info (2 letter code) where the sign-in originated.  This is calculated using latitude/longitude information from the sign-in activity.
  - `[GeoCoordinates <IMicrosoftGraphGeoCoordinates>]`: geoCoordinates
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Altitude <Double?>]`: Optional. The altitude (height), in feet,  above sea level for the item. Read-only.
    - `[Latitude <Double?>]`: Optional. The latitude, in decimal, for the item. Read-only.
    - `[Longitude <Double?>]`: Optional. The longitude, in decimal, for the item. Read-only.
  - `[State <String>]`: Provides the State where the sign-in originated. This is calculated using latitude/longitude information from the sign-in activity.

## RELATED LINKS

