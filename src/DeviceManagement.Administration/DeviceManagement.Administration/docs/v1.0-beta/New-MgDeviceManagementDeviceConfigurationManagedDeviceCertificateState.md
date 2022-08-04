---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementdeviceconfigurationmanageddevicecertificatestate
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState

## SYNOPSIS
Create new navigation property to deviceConfigurationsAllManagedDeviceCertificateStates for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState [-AdditionalProperties <Hashtable>]
 [-CertificateExpirationDateTime <DateTime>] [-CertificateExtendedKeyUsages <String>]
 [-CertificateIssuanceDateTime <DateTime>] [-CertificateIssuerName <String>] [-CertificateKeyUsages <Int32>]
 [-CertificateRevokeStatus <CertificateRevocationStatus>]
 [-CertificateRevokeStatusLastChangeDateTime <DateTime>] [-CertificateSerialNumber <String>]
 [-CertificateSubjectName <String>] [-CertificateThumbprint <String>] [-Id <String>]
 [-ManagedDeviceDisplayName <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState
 -BodyParameter <IMicrosoftGraphManagedAllDeviceCertificateState> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to deviceConfigurationsAllManagedDeviceCertificateStates for deviceManagement

## EXAMPLES

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

### -BodyParameter
managedAllDeviceCertificateState
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAllDeviceCertificateState
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateExpirationDateTime
Certificate expiry date

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

### -CertificateExtendedKeyUsages
Enhanced Key Usage

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

### -CertificateIssuanceDateTime
Issuance date

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

### -CertificateIssuerName
Issuer

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

### -CertificateKeyUsages
Key Usage

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateRevokeStatus
Certificate Revocation Status.

```yaml
Type: Microsoft.Graph.PowerShell.Support.CertificateRevocationStatus
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateRevokeStatusLastChangeDateTime
The time the revoke status was last changed

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

### -CertificateSerialNumber
Serial number

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

### -CertificateSubjectName
Certificate subject name

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

### -CertificateThumbprint
Thumbprint

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
.

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

### -ManagedDeviceDisplayName
Device display name

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
User principal name

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAllDeviceCertificateState

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAllDeviceCertificateState

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedAllDeviceCertificateState>: managedAllDeviceCertificateState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CertificateExpirationDateTime <DateTime?>]`: Certificate expiry date
  - `[CertificateExtendedKeyUsages <String>]`: Enhanced Key Usage
  - `[CertificateIssuanceDateTime <DateTime?>]`: Issuance date
  - `[CertificateIssuerName <String>]`: Issuer
  - `[CertificateKeyUsages <Int32?>]`: Key Usage
  - `[CertificateRevokeStatus <CertificateRevocationStatus?>]`: Certificate Revocation Status.
  - `[CertificateRevokeStatusLastChangeDateTime <DateTime?>]`: The time the revoke status was last changed
  - `[CertificateSerialNumber <String>]`: Serial number
  - `[CertificateSubjectName <String>]`: Certificate subject name
  - `[CertificateThumbprint <String>]`: Thumbprint
  - `[ManagedDeviceDisplayName <String>]`: Device display name
  - `[UserPrincipalName <String>]`: User principal name

## RELATED LINKS

