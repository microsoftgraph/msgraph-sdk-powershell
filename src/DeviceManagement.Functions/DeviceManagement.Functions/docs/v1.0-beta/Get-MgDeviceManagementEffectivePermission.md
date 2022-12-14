---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.functions/get-mgdevicemanagementeffectivepermission
schema: 2.0.0
---

# Get-MgBetaDeviceManagementEffectivePermission

## SYNOPSIS
Invoke function getEffectivePermissions

## SYNTAX

### Get (Default)
```
Get-MgBetaDeviceManagementEffectivePermission [-Count] [-Filter <String>] [-Search <String>] [-Skip <Int32>]
 [-Top <Int32>] [<CommonParameters>]
```

### Get1
```
Get-MgBetaDeviceManagementEffectivePermission -Scope <String> [-Count] [-Filter <String>] [-Search <String>]
 [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaDeviceManagementEffectivePermission -InputObject <IDeviceManagementFunctionsIdentity> [-Count]
 [-Filter <String>] [-Search <String>] [-Skip <Int32>] [-Top <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Invoke function getEffectivePermissions

## EXAMPLES

## PARAMETERS

### -Count
Include count of items

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementFunctionsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Scope
Usage: scope='{scope}'

```yaml
Type: System.String
Parameter Sets: Get1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IDeviceManagementFunctionsIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphRolePermission1

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDeviceManagementFunctionsIdentity>: Identity Parameter
  - `[Category <String>]`: Usage: category='{category}'
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[CloudPcId1 <String>]`: Usage: cloudPcId='{cloudPcId}'
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
  - `[SessionKey <String>]`: Usage: sessionKey='{sessionKey}'
  - `[SubscriptionId <String>]`: Usage: subscriptionId='{subscriptionId}'
  - `[SummarizeBy <String>]`: Usage: summarizeBy='{summarizeBy}'
  - `[TemplateId <String>]`: Usage: templateId='{templateId}'
  - `[Upn <String>]`: Usage: upn='{upn}'
  - `[Userid <String>]`: Usage: userid='{userid}'

## RELATED LINKS

