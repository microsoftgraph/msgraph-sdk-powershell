---
external help file:
Module Name: Microsoft.Graph.Beta.Reports
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.reports/update-mgbetareportpartnerbillingmanifest
schema: 2.0.0
---

# Update-MgBetaReportPartnerBillingManifest

## SYNOPSIS
Update the navigation property manifests in reports

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaReportPartnerBillingManifest -ManifestId <String> [-AdditionalProperties <Hashtable>]
 [-BlobCount <Int32>] [-Blobs <IMicrosoftGraphPartnersBillingBlob[]>] [-CreatedDateTime <DateTime>]
 [-DataFormat <String>] [-ETag <String>] [-Id <String>] [-PartitionType <String>] [-PartnerTenantId <String>]
 [-ResponseHeadersVariable <String>] [-RootDirectory <String>] [-SasToken <String>] [-SchemaVersion <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaReportPartnerBillingManifest -ManifestId <String>
 -BodyParameter <IMicrosoftGraphPartnersBillingManifest> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaReportPartnerBillingManifest -InputObject <IReportsIdentity>
 -BodyParameter <IMicrosoftGraphPartnersBillingManifest> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaReportPartnerBillingManifest -InputObject <IReportsIdentity> [-AdditionalProperties <Hashtable>]
 [-BlobCount <Int32>] [-Blobs <IMicrosoftGraphPartnersBillingBlob[]>] [-CreatedDateTime <DateTime>]
 [-DataFormat <String>] [-ETag <String>] [-Id <String>] [-PartitionType <String>] [-PartnerTenantId <String>]
 [-ResponseHeadersVariable <String>] [-RootDirectory <String>] [-SasToken <String>] [-SchemaVersion <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property manifests in reports

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

### -BlobCount
The total file count for this partner tenant ID.

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

### -Blobs
A collection of blob objects that contain details of all the files for the partner tenant ID.
To construct, see NOTES section for BLOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPartnersBillingBlob[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
manifest
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPartnersBillingManifest
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time when a manifest resource was created.
The timestamp type represents date and time information using ISO 8601 format and is always in UTC.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -DataFormat
The billing data file format.
The possible value is: compressedJSONLines.
Each blob is a compressed file and data in the file is in JSON lines format.
Decompress the file to access the data.

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

### -ETag
Version of data represented by the manifest.
Any change in eTag indicates a new data version.

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
Type: Microsoft.Graph.Beta.PowerShell.Models.IReportsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManifestId
The unique identifier of manifest

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

### -PartitionType
Indicates the division of data.
If a given partition has more than the supported number, the data is split into multiple files, each file representing a specific partitionValue.
By default, the data in the file is partitioned by the number of line items.

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

### -PartnerTenantId
The Microsoft Entra tenant ID of the partner.

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

### -RootDirectory
The root directory that contains all the files.

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

### -SasToken
The SAS token for accessing the directory or an individual file in the directory.

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

### -SchemaVersion
The version of the manifest schema.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPartnersBillingManifest

### Microsoft.Graph.Beta.PowerShell.Models.IReportsIdentity

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPartnersBillingManifest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BLOBS <IMicrosoftGraphPartnersBillingBlob[]>`: A collection of blob objects that contain details of all the files for the partner tenant ID.
  - `[Name <String>]`: The blob name.
  - `[PartitionValue <String>]`: The partition that contains the file. A large partition is split into multiple files, each with the same partitionValue.

`BODYPARAMETER <IMicrosoftGraphPartnersBillingManifest>`: manifest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[BlobCount <Int32?>]`: The total file count for this partner tenant ID.
  - `[Blobs <IMicrosoftGraphPartnersBillingBlob[]>]`: A collection of blob objects that contain details of all the files for the partner tenant ID.
    - `[Name <String>]`: The blob name.
    - `[PartitionValue <String>]`: The partition that contains the file. A large partition is split into multiple files, each with the same partitionValue.
  - `[CreatedDateTime <DateTime?>]`: The date and time when a manifest resource was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[DataFormat <String>]`: The billing data file format. The possible value is: compressedJSONLines. Each blob is a compressed file and data in the file is in JSON lines format. Decompress the file to access the data.
  - `[ETag <String>]`: Version of data represented by the manifest. Any change in eTag indicates a new data version.
  - `[PartitionType <String>]`: Indicates the division of data. If a given partition has more than the supported number, the data is split into multiple files, each file representing a specific partitionValue. By default, the data in the file is partitioned by the number of line items.
  - `[PartnerTenantId <String>]`: The Microsoft Entra tenant ID of the partner.
  - `[RootDirectory <String>]`: The root directory that contains all the files.
  - `[SasToken <String>]`: The SAS token for accessing the directory or an individual file in the directory.
  - `[SchemaVersion <String>]`: The version of the manifest schema.

`INPUTOBJECT <IReportsIdentity>`: Identity Parameter
  - `[ActiveUsersBreakdownMetricId <String>]`: The unique identifier of activeUsersBreakdownMetric
  - `[ActiveUsersMetricId <String>]`: The unique identifier of activeUsersMetric
  - `[AppCredentialSignInActivityId <String>]`: The unique identifier of appCredentialSignInActivity
  - `[ApplicationSignInDetailedSummaryId <String>]`: The unique identifier of applicationSignInDetailedSummary
  - `[AuthenticationsMetricId <String>]`: The unique identifier of authenticationsMetric
  - `[CredentialUserRegistrationDetailsId <String>]`: The unique identifier of credentialUserRegistrationDetails
  - `[CustomSecurityAttributeAuditId <String>]`: The unique identifier of customSecurityAttributeAudit
  - `[DailyInactiveUsersByApplicationMetricId <String>]`: The unique identifier of dailyInactiveUsersByApplicationMetric
  - `[DailyInactiveUsersMetricId <String>]`: The unique identifier of dailyInactiveUsersMetric
  - `[Date <DateTime?>]`: Usage: date={date}
  - `[DeviceManagementCachedReportConfigurationId <String>]`: The unique identifier of deviceManagementCachedReportConfiguration
  - `[DeviceManagementExportJobId <String>]`: The unique identifier of deviceManagementExportJob
  - `[DirectoryAuditId <String>]`: The unique identifier of directoryAudit
  - `[EndDateTime <DateTime?>]`: Usage: endDateTime={endDateTime}
  - `[ExclusiveIntervalEndDateTime <DateTime?>]`: Usage: exclusiveIntervalEndDateTime={exclusiveIntervalEndDateTime}
  - `[Filter <String>]`: Usage: filter='{filter}'
  - `[GroupId <String>]`: Usage: groupId='{groupId}'
  - `[IncludedUserRoles <String>]`: Usage: includedUserRoles='{includedUserRoles}'
  - `[IncludedUserTypes <String>]`: Usage: includedUserTypes='{includedUserTypes}'
  - `[InclusiveIntervalStartDateTime <DateTime?>]`: Usage: inclusiveIntervalStartDateTime={inclusiveIntervalStartDateTime}
  - `[InsightSummaryId <String>]`: The unique identifier of insightSummary
  - `[ManifestId <String>]`: The unique identifier of manifest
  - `[MfaCompletionMetricId <String>]`: The unique identifier of mfaCompletionMetric
  - `[MonthlyInactiveUsersByApplicationMetricId <String>]`: The unique identifier of monthlyInactiveUsersByApplicationMetric
  - `[MonthlyInactiveUsersMetricId <String>]`: The unique identifier of monthlyInactiveUsersMetric
  - `[OperationId <String>]`: The unique identifier of operation
  - `[Period <String>]`: Usage: period='{period}'
  - `[PrintUsageByPrinterId <String>]`: The unique identifier of printUsageByPrinter
  - `[PrintUsageByUserId <String>]`: The unique identifier of printUsageByUser
  - `[PrintUsageId <String>]`: The unique identifier of printUsage
  - `[PrinterId <String>]`: Usage: printerId='{printerId}'
  - `[ProvisioningObjectSummaryId <String>]`: The unique identifier of provisioningObjectSummary
  - `[ServicePrincipalSignInActivityId <String>]`: The unique identifier of servicePrincipalSignInActivity
  - `[SignInId <String>]`: The unique identifier of signIn
  - `[Skip <Int32?>]`: Usage: skip={skip}
  - `[SkipToken <String>]`: Usage: skipToken='{skipToken}'
  - `[StartDateTime <DateTime?>]`: Usage: startDateTime={startDateTime}
  - `[Top <Int32?>]`: Usage: top={top}
  - `[UserCountMetricId <String>]`: The unique identifier of userCountMetric
  - `[UserCredentialUsageDetailsId <String>]`: The unique identifier of userCredentialUsageDetails
  - `[UserId <String>]`: Usage: userId='{userId}'
  - `[UserRegistrationDetailsId <String>]`: The unique identifier of userRegistrationDetails
  - `[UserRequestsMetricId <String>]`: The unique identifier of userRequestsMetric
  - `[UserSignUpMetricId <String>]`: The unique identifier of userSignUpMetric

## RELATED LINKS

