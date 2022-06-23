---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Functions
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.functions/get-mgdevicemanagementconditionstatementmanagementconditionstatementforplatform
schema: 2.0.0
---

# Get-MgDeviceManagementConditionStatementManagementConditionStatementForPlatform

## SYNOPSIS
Invoke function getManagementConditionStatementsForPlatform

## SYNTAX

### Get1 (Default)
```
Get-MgDeviceManagementConditionStatementManagementConditionStatementForPlatform -Platform <String>
 [<CommonParameters>]
```

### Get
```
Get-MgDeviceManagementConditionStatementManagementConditionStatementForPlatform
 -ManagementConditionId <String> -Platform <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgDeviceManagementConditionStatementManagementConditionStatementForPlatform
 -InputObject <IDeviceManagementFunctionsIdentity> [<CommonParameters>]
```

### GetViaIdentity1
```
Get-MgDeviceManagementConditionStatementManagementConditionStatementForPlatform
 -InputObject <IDeviceManagementFunctionsIdentity> [<CommonParameters>]
```

## DESCRIPTION
Invoke function getManagementConditionStatementsForPlatform

## EXAMPLES

## PARAMETERS

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IDeviceManagementFunctionsIdentity
Parameter Sets: GetViaIdentity, GetViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ManagementConditionId
key: id of managementCondition

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

### -Platform
Usage: platform={platform}

```yaml
Type: System.String
Parameter Sets: Get, Get1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagementConditionStatement

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

