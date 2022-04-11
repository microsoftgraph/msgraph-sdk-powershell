---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.functions/get-mgdevicemanagementdevicecustomattributeshellscriptdevicerunstatemanageddevicefilevaultkey
schema: 2.0.0
---

# Get-MgDeviceManagementDeviceCustomAttributeShellScriptDeviceRunStateManagedDeviceFileVaultKey

## SYNOPSIS
Invoke function getFileVaultKey

## SYNTAX

### Get (Default)
```
Get-MgDeviceManagementDeviceCustomAttributeShellScriptDeviceRunStateManagedDeviceFileVaultKey
 -DeviceCustomAttributeShellScriptId <String> -DeviceManagementScriptDeviceStateId <String>
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDeviceManagementDeviceCustomAttributeShellScriptDeviceRunStateManagedDeviceFileVaultKey
 -InputObject <IDeviceManagementFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getFileVaultKey

## EXAMPLES

## PARAMETERS

### -DeviceCustomAttributeShellScriptId
key: id of deviceCustomAttributeShellScript

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

### -DeviceManagementScriptDeviceStateId
key: id of deviceManagementScriptDeviceState

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IDeviceManagementFunctionsIdentity>: Identity Parameter
  - `[Category <String>]`: Usage: category={category}
  - `[CloudPcId <String>]`: key: id of cloudPC
  - `[DepOnboardingSettingId <String>]`: key: id of depOnboardingSetting
  - `[DeviceAndAppManagementAssignmentFilterId <String>]`: key: id of deviceAndAppManagementAssignmentFilter
  - `[DeviceAndAppManagementRoleAssignmentId <String>]`: key: id of deviceAndAppManagementRoleAssignment
  - `[DeviceComplianceScriptDeviceStateId <String>]`: key: id of deviceComplianceScriptDeviceState
  - `[DeviceComplianceScriptId <String>]`: key: id of deviceComplianceScript
  - `[DeviceConfigurationGroupAssignmentId <String>]`: key: id of deviceConfigurationGroupAssignment
  - `[DeviceConfigurationId <String>]`: key: id of deviceConfiguration
  - `[DeviceCustomAttributeShellScriptId <String>]`: key: id of deviceCustomAttributeShellScript
  - `[DeviceHealthScriptDeviceStateId <String>]`: key: id of deviceHealthScriptDeviceState
  - `[DeviceHealthScriptId <String>]`: key: id of deviceHealthScript
  - `[DeviceManagementIntentId <String>]`: key: id of deviceManagementIntent
  - `[DeviceManagementScriptDeviceStateId <String>]`: key: id of deviceManagementScriptDeviceState
  - `[DeviceManagementScriptId <String>]`: key: id of deviceManagementScript
  - `[DeviceManagementScriptUserStateId <String>]`: key: id of deviceManagementScriptUserState
  - `[DeviceManagementTemplateId <String>]`: key: id of deviceManagementTemplate
  - `[DeviceManagementTemplateId1 <String>]`: key: id of deviceManagementTemplate
  - `[DeviceShellScriptId <String>]`: key: id of deviceShellScript
  - `[DomainName <String>]`: Usage: domainName={domainName}
  - `[EnrollmentProfileId <String>]`: key: id of enrollmentProfile
  - `[EnrollmentType <String>]`: Usage: enrollmentType={enrollmentType}
  - `[ExpiringBeforeDateTime <String>]`: Usage: expiringBeforeDateTime={expiringBeforeDateTime}
  - `[ManagedDeviceId <String>]`: key: id of managedDevice
  - `[ManagementConditionId <String>]`: key: id of managementCondition
  - `[ManagementConditionStatementId <String>]`: key: id of managementConditionStatement
  - `[Platform <String>]`: Usage: platform={platform}
  - `[PolicyId <String>]`: Usage: policyId={policyId}
  - `[Resource <String>]`: Usage: resource={resource}
  - `[ResourceOperationId <String>]`: key: id of resourceOperation
  - `[Scope <String>]`: Usage: scope={scope}
  - `[SecretReferenceValueId <String>]`: Usage: secretReferenceValueId={secretReferenceValueId}
  - `[SummarizeBy <String>]`: Usage: summarizeBy={summarizeBy}
  - `[TemplateId <String>]`: Usage: templateId={templateId}
  - `[Userid <String>]`: Usage: userid={userid}

## RELATED LINKS

