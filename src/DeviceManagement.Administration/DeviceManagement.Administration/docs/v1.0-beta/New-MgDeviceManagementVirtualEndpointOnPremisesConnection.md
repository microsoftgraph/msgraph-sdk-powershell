---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointonpremisesconnection
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointOnPremisesConnection

## SYNOPSIS
A defined collection of Azure resource information that can be used to establish on-premises network connectivity for cloud PCs.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointOnPremisesConnection [-AdDomainName <String>] [-AdDomainPassword <String>]
 [-AdDomainUsername <String>] [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-HealthCheckStatus <String>]
 [-HealthCheckStatusDetails <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetails>] [-Id <String>] [-InUse]
 [-OrganizationalUnit <String>] [-ResourceGroupId <String>] [-SubnetId <String>] [-SubscriptionId <String>]
 [-SubscriptionName <String>] [-VirtualNetworkId <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointOnPremisesConnection
 -BodyParameter <IMicrosoftGraphCloudPcOnPremisesConnection> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
A defined collection of Azure resource information that can be used to establish on-premises network connectivity for cloud PCs.

## EXAMPLES

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

### -AdDomainName
The fully qualified domain name (FQDN) of the Active Directory domain you want to join.

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

### -AdDomainPassword
The password associated with adDomainUsername.

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

### -AdDomainUsername
The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory.
Required format: admin@contoso.com.

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

### -BodyParameter
cloudPcOnPremisesConnection
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphCloudPcOnPremisesConnection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name for the on-premises connection.

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

### -HealthCheckStatus
cloudPcOnPremisesConnectionStatus

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

### -HealthCheckStatusDetails
cloudPcOnPremisesConnectionStatusDetails
To construct, see NOTES section for HEALTHCHECKSTATUSDETAILS properties and create a hash table.

```yaml
Type: IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetails
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

### -InUse
When true, the on-premises connection is in use.
When false, the connection is not in use.
You cannot delete a connection that's in use.
Returned only on $select.
For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails.
Read-only.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -OrganizationalUnit
The organizational unit (OU) in which the computer account is created.
If left null, the OU that's configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used.
Optional.

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

### -ResourceGroupId
The ID of the target resource group.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'.

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

### -SubnetId
The ID of the target subnet.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'.

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

### -SubscriptionId
The ID of the target Azure subscription that's associated with your tenant.

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

### -SubscriptionName
The name of the target Azure subscription.
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

### -VirtualNetworkId
The ID of the target virtual network.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnection
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnection
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcOnPremisesConnection>: cloudPcOnPremisesConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AdDomainName <String>]`: The fully qualified domain name (FQDN) of the Active Directory domain you want to join.
  - `[AdDomainPassword <String>]`: The password associated with adDomainUsername.
  - `[AdDomainUsername <String>]`: The username of an Active Directory account (user or service account) that has permissions to create computer objects in Active Directory. Required format: admin@contoso.com.
  - `[DisplayName <String>]`: The display name for the on-premises connection.
  - `[HealthCheckStatus <String>]`: cloudPcOnPremisesConnectionStatus
  - `[HealthCheckStatusDetails <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetails>]`: cloudPcOnPremisesConnectionStatusDetails
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndDateTime <DateTime?>]`: The end time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[HealthChecks <IMicrosoftGraphCloudPcOnPremisesConnectionHealthCheck[]>]`: All checks that are done on the connection.
      - `[AdditionalDetails <String>]`: Additional details about the health check or the recommended action.
      - `[DisplayName <String>]`: The display name for this health check item.
      - `[EndDateTime <DateTime?>]`: The end time of the health check item. Read-only.
      - `[ErrorType <String>]`: cloudPcOnPremisesConnectionHealthCheckErrorType
      - `[RecommendedAction <String>]`: The recommended action to fix the corresponding error.
      - `[StartDateTime <DateTime?>]`: The start time of the health check item. Read-only.
      - `[Status <String>]`: cloudPcOnPremisesConnectionStatus
    - `[StartDateTime <DateTime?>]`: The start time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[InUse <Boolean?>]`: When true, the on-premises connection is in use. When false, the connection is not in use. You cannot delete a connection that's in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an on-premises connection, including healthCheckStatusDetails. Read-only.
  - `[OrganizationalUnit <String>]`: The organizational unit (OU) in which the computer account is created. If left null, the OU that's configured as the default (a well-known computer object container) in your Active Directory domain (OU) is used. Optional.
  - `[ResourceGroupId <String>]`: The ID of the target resource group. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'.
  - `[SubnetId <String>]`: The ID of the target subnet. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'.
  - `[SubscriptionId <String>]`: The ID of the target Azure subscription that's associated with your tenant.
  - `[SubscriptionName <String>]`: The name of the target Azure subscription. Read-only.
  - `[VirtualNetworkId <String>]`: The ID of the target virtual network. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'.

HEALTHCHECKSTATUSDETAILS <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetails>: cloudPcOnPremisesConnectionStatusDetails
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EndDateTime <DateTime?>]`: The end time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[HealthChecks <IMicrosoftGraphCloudPcOnPremisesConnectionHealthCheck[]>]`: All checks that are done on the connection.
    - `[AdditionalDetails <String>]`: Additional details about the health check or the recommended action.
    - `[DisplayName <String>]`: The display name for this health check item.
    - `[EndDateTime <DateTime?>]`: The end time of the health check item. Read-only.
    - `[ErrorType <String>]`: cloudPcOnPremisesConnectionHealthCheckErrorType
    - `[RecommendedAction <String>]`: The recommended action to fix the corresponding error.
    - `[StartDateTime <DateTime?>]`: The start time of the health check item. Read-only.
    - `[Status <String>]`: cloudPcOnPremisesConnectionStatus
  - `[StartDateTime <DateTime?>]`: The start time of the connection health check. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

## RELATED LINKS
