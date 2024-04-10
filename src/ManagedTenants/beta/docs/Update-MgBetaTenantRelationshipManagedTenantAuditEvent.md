---
external help file:
Module Name: Microsoft.Graph.Beta.ManagedTenants
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.managedtenants/update-mgbetatenantrelationshipmanagedtenantauditevent
schema: 2.0.0
---

# Update-MgBetaTenantRelationshipManagedTenantAuditEvent

## SYNOPSIS
Update the navigation property auditEvents in tenantRelationships

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaTenantRelationshipManagedTenantAuditEvent -AuditEventId <String> [-Activity <String>]
 [-ActivityDateTime <DateTime>] [-ActivityId <String>] [-AdditionalProperties <Hashtable>]
 [-Category <String>] [-HttpVerb <String>] [-Id <String>] [-InitiatedByAppId <String>]
 [-InitiatedByUpn <String>] [-InitiatedByUserId <String>] [-IPAddress <String>] [-RequestBody <String>]
 [-RequestUrl <String>] [-ResponseHeadersVariable <String>] [-TenantIds <String>] [-TenantNames <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaTenantRelationshipManagedTenantAuditEvent -AuditEventId <String>
 -BodyParameter <IMicrosoftGraphManagedTenantsAuditEvent> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgBetaTenantRelationshipManagedTenantAuditEvent -InputObject <IManagedTenantsIdentity>
 -BodyParameter <IMicrosoftGraphManagedTenantsAuditEvent> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgBetaTenantRelationshipManagedTenantAuditEvent -InputObject <IManagedTenantsIdentity>
 [-Activity <String>] [-ActivityDateTime <DateTime>] [-ActivityId <String>]
 [-AdditionalProperties <Hashtable>] [-Category <String>] [-HttpVerb <String>] [-Id <String>]
 [-InitiatedByAppId <String>] [-InitiatedByUpn <String>] [-InitiatedByUserId <String>] [-IPAddress <String>]
 [-RequestBody <String>] [-RequestUrl <String>] [-ResponseHeadersVariable <String>] [-TenantIds <String>]
 [-TenantNames <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property auditEvents in tenantRelationships

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -Activity
A string that uniquely represents the operation that occurred.
Required.
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

### -ActivityDateTime
The time when the activity occurred.
Required.
Read-only.

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

### -ActivityId
The identifier of the activity request that made the audit event.
Required.
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

### -AuditEventId
The unique identifier of auditEvent

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

### -BodyParameter
auditEvent
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAuditEvent
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
A category that represents a logical grouping of activities.
Required.
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

### -HttpVerb
The HTTP verb that was used when making the API request.
Required.
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

### -InitiatedByAppId
The identifier of the app that was used to make the request.
Required.
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

### -InitiatedByUpn
The UPN of the user who initiated the activity.
Required.
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

### -InitiatedByUserId
The identifier of the user who initiated the activity.
Required.
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IPAddress
The IP address of where the activity was initiated.
This may be an IPv4 or IPv6 address.
Required.
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

### -RequestBody
The raw HTTP request body.
Some sensitive information may be removed.

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

### -RequestUrl
The raw HTTP request URL.
Required.
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

### -TenantIds
The collection of Microsoft Entra tenant identifiers for the managed tenants that were affected by a change, and is formatted as a list of comma-separated values.
Required.
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

### -TenantNames
The collection of tenant names that were affected by a change, and is formatted as a list of comma-separated values.
Required.
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

### Microsoft.Graph.Beta.PowerShell.Models.IManagedTenantsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAuditEvent

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphManagedTenantsAuditEvent

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphManagedTenantsAuditEvent>`: auditEvent
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Activity <String>]`: A string that uniquely represents the operation that occurred. Required. Read-only.
  - `[ActivityDateTime <DateTime?>]`: The time when the activity occurred. Required. Read-only.
  - `[ActivityId <String>]`: The identifier of the activity request that made the audit event. Required. Read-only.
  - `[Category <String>]`: A category that represents a logical grouping of activities. Required. Read-only.
  - `[HttpVerb <String>]`: The HTTP verb that was used when making the API request. Required. Read-only.
  - `[IPAddress <String>]`: The IP address of where the activity was initiated. This may be an IPv4 or IPv6 address. Required. Read-only.
  - `[InitiatedByAppId <String>]`: The identifier of the app that was used to make the request. Required. Read-only.
  - `[InitiatedByUpn <String>]`: The UPN of the user who initiated the activity. Required. Read-only.
  - `[InitiatedByUserId <String>]`: The identifier of the user who initiated the activity. Required. Read-only.
  - `[RequestBody <String>]`: The raw HTTP request body. Some sensitive information may be removed.
  - `[RequestUrl <String>]`: The raw HTTP request URL. Required. Read-only.
  - `[TenantIds <String>]`: The collection of Microsoft Entra tenant identifiers for the managed tenants that were affected by a change, and is formatted as a list of comma-separated values. Required. Read-only.
  - `[TenantNames <String>]`: The collection of tenant names that were affected by a change, and is formatted as a list of comma-separated values. Required. Read-only.

`INPUTOBJECT <IManagedTenantsIdentity>`: Identity Parameter
  - `[AggregatedPolicyComplianceId <String>]`: The unique identifier of aggregatedPolicyCompliance
  - `[AppPerformanceId <String>]`: The unique identifier of appPerformance
  - `[AuditEventId <String>]`: The unique identifier of auditEvent
  - `[CloudPcConnectionId <String>]`: The unique identifier of cloudPcConnection
  - `[CloudPcDeviceId <String>]`: The unique identifier of cloudPcDevice
  - `[CloudPcOverviewTenantId <String>]`: The unique identifier of cloudPcOverview
  - `[ConditionalAccessPolicyCoverageId <String>]`: The unique identifier of conditionalAccessPolicyCoverage
  - `[CredentialUserRegistrationsSummaryId <String>]`: The unique identifier of credentialUserRegistrationsSummary
  - `[DeviceAppPerformanceId <String>]`: The unique identifier of deviceAppPerformance
  - `[DeviceCompliancePolicySettingStateSummaryId <String>]`: The unique identifier of deviceCompliancePolicySettingStateSummary
  - `[DeviceHealthStatusId <String>]`: The unique identifier of deviceHealthStatus
  - `[ManagedDeviceComplianceId <String>]`: The unique identifier of managedDeviceCompliance
  - `[ManagedDeviceComplianceTrendId <String>]`: The unique identifier of managedDeviceComplianceTrend
  - `[ManagedTenantAlertId <String>]`: The unique identifier of managedTenantAlert
  - `[ManagedTenantAlertLogId <String>]`: The unique identifier of managedTenantAlertLog
  - `[ManagedTenantAlertRuleDefinitionId <String>]`: The unique identifier of managedTenantAlertRuleDefinition
  - `[ManagedTenantAlertRuleId <String>]`: The unique identifier of managedTenantAlertRule
  - `[ManagedTenantApiNotificationId <String>]`: The unique identifier of managedTenantApiNotification
  - `[ManagedTenantEmailNotificationId <String>]`: The unique identifier of managedTenantEmailNotification
  - `[ManagedTenantTicketingEndpointId <String>]`: The unique identifier of managedTenantTicketingEndpoint
  - `[ManagementActionId <String>]`: The unique identifier of managementAction
  - `[ManagementActionTenantDeploymentStatusId <String>]`: The unique identifier of managementActionTenantDeploymentStatus
  - `[ManagementIntentId <String>]`: The unique identifier of managementIntent
  - `[ManagementTemplateCollectionId <String>]`: The unique identifier of managementTemplateCollection
  - `[ManagementTemplateCollectionTenantSummaryId <String>]`: The unique identifier of managementTemplateCollectionTenantSummary
  - `[ManagementTemplateId <String>]`: The unique identifier of managementTemplate
  - `[ManagementTemplateStepDeploymentId <String>]`: The unique identifier of managementTemplateStepDeployment
  - `[ManagementTemplateStepId <String>]`: The unique identifier of managementTemplateStep
  - `[ManagementTemplateStepTenantSummaryId <String>]`: The unique identifier of managementTemplateStepTenantSummary
  - `[ManagementTemplateStepVersionId <String>]`: The unique identifier of managementTemplateStepVersion
  - `[MyRoleTenantId <String>]`: The unique identifier of myRole
  - `[TenantCustomizedInformationId <String>]`: The unique identifier of tenantCustomizedInformation
  - `[TenantDetailedInformationId <String>]`: The unique identifier of tenantDetailedInformation
  - `[TenantGroupId <String>]`: The unique identifier of tenantGroup
  - `[TenantId <String>]`: The unique identifier of tenant
  - `[TenantTagId <String>]`: The unique identifier of tenantTag
  - `[WindowsDeviceMalwareStateId <String>]`: The unique identifier of windowsDeviceMalwareState
  - `[WindowsProtectionStateId <String>]`: The unique identifier of windowsProtectionState

## RELATED LINKS

