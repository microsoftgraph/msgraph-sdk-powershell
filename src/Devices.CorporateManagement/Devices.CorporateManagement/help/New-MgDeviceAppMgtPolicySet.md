---
external help file: Microsoft.Graph.Devices.CorporateManagement-help.xml
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtpolicyset
schema: 2.0.0
---

# New-MgDeviceAppMgtPolicySet

## SYNOPSIS
Create new navigation property to policySets for deviceAppManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceAppMgtPolicySet [-AdditionalProperties <Hashtable>]
 [-Assignments <IMicrosoftGraphPolicySetAssignment[]>] [-CreatedDateTime <DateTime>] [-Description <String>]
 [-DisplayName <String>] [-ErrorCode <String>] [-GuidedDeploymentTags <String[]>] [-Id <String>]
 [-Items <IMicrosoftGraphPolicySetItem[]>] [-LastModifiedDateTime <DateTime>] [-RoleScopeTags <String[]>]
 [-Status <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceAppMgtPolicySet -BodyParameter <IMicrosoftGraphPolicySet> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to policySets for deviceAppManagement

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Assignments
Assignments of the PolicySet.
To construct, see NOTES section for ASSIGNMENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySetAssignment[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
A class containing the properties used for PolicySet.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySet
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Creation time of the PolicySet.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description of the PolicySet.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
DisplayName of the PolicySet.

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorCode
errorCode

```yaml
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GuidedDeploymentTags
Tags of the guided deployment

```yaml
Type: String[]
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Items
Items of the PolicySet with maximum count 100.
To construct, see NOTES section for ITEMS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPolicySetItem[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastModifiedDateTime
Last modified time of the PolicySet.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RoleScopeTags
RoleScopeTags of the PolicySet

```yaml
Type: String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
policySetStatus

```yaml
Type: String
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySet
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPolicySet
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

ASSIGNMENTS \<IMicrosoftGraphPolicySetAssignment\[\]\>: Assignments of the PolicySet.
  \[Id \<String\>\]: Read-only.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetAssignment.
  \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
    \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType

BODYPARAMETER \<IMicrosoftGraphPolicySet\>: A class containing the properties used for PolicySet.
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Assignments \<IMicrosoftGraphPolicySetAssignment\[\]\>\]: Assignments of the PolicySet.
    \[Id \<String\>\]: Read-only.
    \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetAssignment.
    \[Target \<IMicrosoftGraphDeviceAndAppManagementAssignmentTarget\>\]: Base type for assignment targets.
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DeviceAndAppManagementAssignmentFilterId \<String\>\]: The Id of the filter for the target assignment.
      \[DeviceAndAppManagementAssignmentFilterType \<String\>\]: deviceAndAppManagementAssignmentFilterType
  \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySet.
  \[Description \<String\>\]: Description of the PolicySet.
  \[DisplayName \<String\>\]: DisplayName of the PolicySet.
  \[ErrorCode \<String\>\]: errorCode
  \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
  \[Items \<IMicrosoftGraphPolicySetItem\[\]\>\]: Items of the PolicySet with maximum count 100.
    \[Id \<String\>\]: Read-only.
    \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySetItem.
    \[DisplayName \<String\>\]: DisplayName of the PolicySetItem.
    \[ErrorCode \<String\>\]: errorCode
    \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
    \[ItemType \<String\>\]: policySetType of the PolicySetItem.
    \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetItem.
    \[PayloadId \<String\>\]: PayloadId of the PolicySetItem.
    \[Status \<String\>\]: policySetStatus
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySet.
  \[RoleScopeTags \<String\[\]\>\]: RoleScopeTags of the PolicySet
  \[Status \<String\>\]: policySetStatus

ITEMS \<IMicrosoftGraphPolicySetItem\[\]\>: Items of the PolicySet with maximum count 100.
  \[Id \<String\>\]: Read-only.
  \[CreatedDateTime \<DateTime?\>\]: Creation time of the PolicySetItem.
  \[DisplayName \<String\>\]: DisplayName of the PolicySetItem.
  \[ErrorCode \<String\>\]: errorCode
  \[GuidedDeploymentTags \<String\[\]\>\]: Tags of the guided deployment
  \[ItemType \<String\>\]: policySetType of the PolicySetItem.
  \[LastModifiedDateTime \<DateTime?\>\]: Last modified time of the PolicySetItem.
  \[PayloadId \<String\>\]: PayloadId of the PolicySetItem.
  \[Status \<String\>\]: policySetStatus

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtpolicyset](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.corporatemanagement/new-mgdeviceappmgtpolicyset)

