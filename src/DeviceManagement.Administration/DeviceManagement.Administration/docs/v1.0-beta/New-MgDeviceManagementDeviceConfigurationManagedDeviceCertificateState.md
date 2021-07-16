---
external help file: Microsoft.Graph.DeviceManagement.Administration-help.xml
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementdeviceconfigurationmanageddevicecertificatestate
schema: 2.0.0
---

# New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState

## SYNOPSIS
Summary of all certificates for all devices.

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState [-AdditionalProperties <Hashtable>]
 [-CertificateExpirationDateTime <DateTime>] [-CertificateExtendedKeyUsages <String>]
 [-CertificateIssuanceDateTime <DateTime>] [-CertificateIssuerName <String>] [-CertificateKeyUsages <Int32>]
 [-CertificateRevokeStatus <String>] [-CertificateRevokeStatusLastChangeDateTime <DateTime>]
 [-CertificateSerialNumber <String>] [-CertificateSubjectName <String>] [-CertificateThumbprint <String>]
 [-Id <String>] [-ManagedDeviceDisplayName <String>] [-UserPrincipalName <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementDeviceConfigurationManagedDeviceCertificateState
 -BodyParameter <IMicrosoftGraphManagedAllDeviceCertificateState> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Summary of all certificates for all devices.

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

### -BodyParameter
managedAllDeviceCertificateState
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphManagedAllDeviceCertificateState
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
Type: DateTime
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
Type: String
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
Type: DateTime
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
Type: String
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
Type: Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CertificateRevokeStatus
certificateRevocationStatus

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

### -CertificateRevokeStatusLastChangeDateTime
The time the revoke status was last changed

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

### -CertificateSerialNumber
Serial number

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

### -CertificateSubjectName
Certificate subject name

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

### -CertificateThumbprint
Thumbprint

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

### -ManagedDeviceDisplayName
Device display name

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

### -UserPrincipalName
User principal name

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAllDeviceCertificateState
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphManagedAllDeviceCertificateState
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphManagedAllDeviceCertificateState>: managedAllDeviceCertificateState
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[CertificateExpirationDateTime <DateTime?>]`: Certificate expiry date
  - `[CertificateExtendedKeyUsages <String>]`: Enhanced Key Usage
  - `[CertificateIssuanceDateTime <DateTime?>]`: Issuance date
  - `[CertificateIssuerName <String>]`: Issuer
  - `[CertificateKeyUsages <Int32?>]`: Key Usage
  - `[CertificateRevokeStatus <String>]`: certificateRevocationStatus
  - `[CertificateRevokeStatusLastChangeDateTime <DateTime?>]`: The time the revoke status was last changed
  - `[CertificateSerialNumber <String>]`: Serial number
  - `[CertificateSubjectName <String>]`: Certificate subject name
  - `[CertificateThumbprint <String>]`: Thumbprint
  - `[ManagedDeviceDisplayName <String>]`: Device display name
  - `[UserPrincipalName <String>]`: User principal name

## RELATED LINKS
