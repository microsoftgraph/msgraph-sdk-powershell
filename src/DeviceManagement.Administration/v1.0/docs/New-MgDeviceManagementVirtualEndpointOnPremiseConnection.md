---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointonpremiseconnection
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointOnPremiseConnection

## SYNOPSIS
Create a new cloudPcOnPremisesConnection object for provisioning Cloud PCs.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointOnPremiseConnection [-AdditionalProperties <Hashtable>]
 [-AdDomainName <String>] [-AdDomainPassword <String>] [-AdDomainUsername <String>]
 [-AlternateResourceUrl <String>] [-ConnectionType <String>] [-DisplayName <String>]
 [-HealthCheckStatus <String>]
 [-HealthCheckStatusDetail <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetail>] [-Id <String>] [-InUse]
 [-OrganizationalUnit <String>] [-ResourceGroupId <String>] [-ResponseHeadersVariable <String>]
 [-SubnetId <String>] [-SubscriptionId <String>] [-SubscriptionName <String>] [-VirtualNetworkId <String>]
 [-VirtualNetworkLocation <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointOnPremiseConnection
 -BodyParameter <IMicrosoftGraphCloudPcOnPremisesConnection> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new cloudPcOnPremisesConnection object for provisioning Cloud PCs.

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
Maximum length is 255.
Optional.

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

### -AdDomainPassword
The password associated with the username of an Active Directory account (adDomainUsername).

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

### -AdDomainUsername
The username of an Active Directory account (user or service account) that has permission to create computer objects in Active Directory.
Required format: admin@contoso.com.
Optional.

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

### -AlternateResourceUrl
The interface URL of the partner service's resource that links to this Azure network connection.
Returned only on $select.

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

### -BodyParameter
cloudPcOnPremisesConnection
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnection
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConnectionType
cloudPcOnPremisesConnectionType

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

### -DisplayName
The display name for the Azure network connection.

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

### -HealthCheckStatus
cloudPcOnPremisesConnectionStatus

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

### -HealthCheckStatusDetail
cloudPcOnPremisesConnectionStatusDetail
To construct, see NOTES section for HEALTHCHECKSTATUSDETAIL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetail
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InUse
When true, the Azure network connection is in use.
When false, the connection isn't in use.
You can't delete a connection that’s in use.
Returned only on $select.
For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetail.
Read-only.

```yaml
Type: System.Management.Automation.SwitchParameter
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
If left null, the OU configured as the default (a well-known computer object container) in the tenant's Active Directory domain (OU) is used.
Optional.

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

### -ResourceGroupId
The unique identifier of the target resource group used associated with the on-premises network connectivity for Cloud PCs.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'

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

### -SubnetId
The unique identifier of the target subnet used associated with the on-premises network connectivity for Cloud PCs.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'

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

### -SubscriptionId
The unique identifier of the Azure subscription associated with the tenant.

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

### -SubscriptionName
The name of the Azure subscription is used to create an Azure network connection.
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

### -VirtualNetworkId
The unique identifier of the target virtual network used associated with the on-premises network connectivity for Cloud PCs.
Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'

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

### -VirtualNetworkLocation
Indicates the resource location of the target virtual network.
For example, the location can be eastus2, westeurope, etc.
Read-only (computed value).

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnection

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcOnPremisesConnection

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphCloudPcOnPremisesConnection>`: cloudPcOnPremisesConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdDomainName <String>]`: The fully qualified domain name (FQDN) of the Active Directory domain you want to join. Maximum length is 255. Optional.
  - `[AdDomainPassword <String>]`: The password associated with the username of an Active Directory account (adDomainUsername).
  - `[AdDomainUsername <String>]`: The username of an Active Directory account (user or service account) that has permission to create computer objects in Active Directory. Required format: admin@contoso.com. Optional.
  - `[AlternateResourceUrl <String>]`: The interface URL of the partner service's resource that links to this Azure network connection. Returned only on $select.
  - `[ConnectionType <String>]`: cloudPcOnPremisesConnectionType
  - `[DisplayName <String>]`: The display name for the Azure network connection.
  - `[HealthCheckStatus <String>]`: cloudPcOnPremisesConnectionStatus
  - `[HealthCheckStatusDetail <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetail>]`: cloudPcOnPremisesConnectionStatusDetail
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[EndDateTime <DateTime?>]`: The end time of the connection health check. The Timestamp  is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z. Read-Only.
    - `[HealthChecks <IMicrosoftGraphCloudPcOnPremisesConnectionHealthCheck[]>]`: A list of all checks that have been run on the connection. Read-Only.
      - `[AdditionalDetail <String>]`: Additional details about the health check or the recommended action. For exmaple, the string value can be download.microsoft.com:443;software-download.microsoft.com:443; Read-only.
      - `[CorrelationId <String>]`: The unique identifier of the health check item-related activities. This identifier can be useful in troubleshooting.
      - `[DisplayName <String>]`: The display name for this health check item.
      - `[EndDateTime <DateTime?>]`: The value cannot be modified and is automatically populated when the health check ends. The Timestamp type represents date and time information using ISO 8601 format and is in Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2024 would look like this: '2024-01-01T00:00:00Z'. Returned by default. Read-only.
      - `[ErrorType <String>]`: cloudPcOnPremisesConnectionHealthCheckErrorType
      - `[RecommendedAction <String>]`: The recommended action to fix the corresponding error. For example, The Active Directory domain join check failed because the password of the domain join user has expired. Read-Only.
      - `[StartDateTime <DateTime?>]`: The value cannot be modified and is automatically populated when the health check starts. The Timestamp type represents date and time information using ISO 8601 format and is in  Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2024 would look like this: '2024-01-01T00:00:00Z'. Returned by default. Read-only.
      - `[Status <String>]`: cloudPcOnPremisesConnectionStatus
    - `[StartDateTime <DateTime?>]`: The start time of the health check. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appear as 2014-01-01T00:00:00Z. Read-Only.
  - `[InUse <Boolean?>]`: When true, the Azure network connection is in use. When false, the connection isn't in use. You can't delete a connection that’s in use. Returned only on $select. For an example that shows how to get the inUse property, see Example 2: Get the selected properties of an Azure network connection, including healthCheckStatusDetail. Read-only.
  - `[OrganizationalUnit <String>]`: The organizational unit (OU) in which the computer account is created. If left null, the OU configured as the default (a well-known computer object container) in the tenant's Active Directory domain (OU) is used. Optional.
  - `[ResourceGroupId <String>]`: The unique identifier of the target resource group used associated with the on-premises network connectivity for Cloud PCs. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}'
  - `[SubnetId <String>]`: The unique identifier of the target subnet used associated with the on-premises network connectivity for Cloud PCs. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkId}/subnets/{subnetName}'
  - `[SubscriptionId <String>]`: The unique identifier of the Azure subscription associated with the tenant.
  - `[SubscriptionName <String>]`: The name of the Azure subscription is used to create an Azure network connection. Read-only.
  - `[VirtualNetworkId <String>]`: The unique identifier of the target virtual network used associated with the on-premises network connectivity for Cloud PCs. Required format: '/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}'
  - `[VirtualNetworkLocation <String>]`: Indicates the resource location of the target virtual network. For example, the location can be eastus2, westeurope, etc. Read-only (computed value).

`HEALTHCHECKSTATUSDETAIL <IMicrosoftGraphCloudPcOnPremisesConnectionStatusDetail>`: cloudPcOnPremisesConnectionStatusDetail
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[EndDateTime <DateTime?>]`: The end time of the connection health check. The Timestamp  is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z. Read-Only.
  - `[HealthChecks <IMicrosoftGraphCloudPcOnPremisesConnectionHealthCheck[]>]`: A list of all checks that have been run on the connection. Read-Only.
    - `[AdditionalDetail <String>]`: Additional details about the health check or the recommended action. For exmaple, the string value can be download.microsoft.com:443;software-download.microsoft.com:443; Read-only.
    - `[CorrelationId <String>]`: The unique identifier of the health check item-related activities. This identifier can be useful in troubleshooting.
    - `[DisplayName <String>]`: The display name for this health check item.
    - `[EndDateTime <DateTime?>]`: The value cannot be modified and is automatically populated when the health check ends. The Timestamp type represents date and time information using ISO 8601 format and is in Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2024 would look like this: '2024-01-01T00:00:00Z'. Returned by default. Read-only.
    - `[ErrorType <String>]`: cloudPcOnPremisesConnectionHealthCheckErrorType
    - `[RecommendedAction <String>]`: The recommended action to fix the corresponding error. For example, The Active Directory domain join check failed because the password of the domain join user has expired. Read-Only.
    - `[StartDateTime <DateTime?>]`: The value cannot be modified and is automatically populated when the health check starts. The Timestamp type represents date and time information using ISO 8601 format and is in  Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2024 would look like this: '2024-01-01T00:00:00Z'. Returned by default. Read-only.
    - `[Status <String>]`: cloudPcOnPremisesConnectionStatus
  - `[StartDateTime <DateTime?>]`: The start time of the health check. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appear as 2014-01-01T00:00:00Z. Read-Only.

## RELATED LINKS

