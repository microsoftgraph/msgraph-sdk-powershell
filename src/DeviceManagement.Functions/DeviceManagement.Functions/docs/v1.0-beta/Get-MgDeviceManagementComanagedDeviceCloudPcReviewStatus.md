---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.functions/get-mgdevicemanagementcomanageddevicecloudpcreviewstatus
schema: 2.0.0
---

# Get-MgDeviceManagementComanagedDeviceCloudPcReviewStatus

## SYNOPSIS
Invoke function getCloudPcReviewStatus

## SYNTAX

### Get (Default)
```
Get-MgDeviceManagementComanagedDeviceCloudPcReviewStatus -ManagedDeviceId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDeviceManagementComanagedDeviceCloudPcReviewStatus -InputObject <IDeviceManagementFunctionsIdentity>
 [<CommonParameters>]
```

## DESCRIPTION
Invoke function getCloudPcReviewStatus

## EXAMPLES

## PARAMETERS

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagedDeviceId
key: id of managedDevice

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcReviewStatus

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDeviceManagementFunctionsIdentity>: Identity Parameter
  - `[Category <String>]`: Usage: category='{category}'
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: key: id of deviceAndAppManagementAssignmentFilter
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementTemplateId <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: key: id of deviceManagementTemplate
  - `[DomainName <String>]`: Usage: domainName='{domainName}'
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[EnrollmentType <String>]`: Usage: enrollmentType='{enrollmentType}'
  - `[ExpiringBeforeDateTime <String>]`: Usage: expiringBeforeDateTime='{expiringBeforeDateTime}'
  - `[Ids <String[]>]`: Usage: ids={ids}
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[Platform <DevicePlatformType?>]`: Usage: platform='{platform}'
  - `[PolicyId <String>]`: Usage: policyId='{policyId}'
  - `[Resource <String>]`: Usage: resource='{resource}'
  - `[ResourceOperationId <String>]`: key: id of resourceOperation
  - `[Scope <String>]`: Usage: scope='{scope}'
  - `[SecretReferenceValueId <String>]`: Usage: secretReferenceValueId='{secretReferenceValueId}'
  - `[SubscriptionId <String>]`: Usage: subscriptionId='{subscriptionId}'
  - `[SummarizeBy <String>]`: Usage: summarizeBy='{summarizeBy}'
  - `[TemplateId <String>]`: Usage: templateId='{templateId}'
  - `[Upn <String>]`: Usage: upn='{upn}'
  - `[Userid <String>]`: Usage: userid='{userid}'

## RELATED LINKS

