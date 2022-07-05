---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementuserpfxcertificate
schema: 2.0.0
---

# New-MgDeviceManagementUserPfxCertificate

## SYNOPSIS
Create new navigation property to userPfxCertificates for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementUserPfxCertificate [-AdditionalProperties <Hashtable>] [-CreatedDateTime <DateTime>]
 [-EncryptedPfxBlobInputFile <String>] [-EncryptedPfxPassword <String>] [-ExpirationDateTime <DateTime>]
 [-Id <String>] [-IntendedPurpose <UserPfxIntendedPurpose>] [-KeyName <String>]
 [-LastModifiedDateTime <DateTime>] [-PaddingScheme <UserPfxPaddingScheme>] [-ProviderName <String>]
 [-StartDateTime <DateTime>] [-Thumbprint <String>] [-UserPrincipalName <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementUserPfxCertificate -BodyParameter <IMicrosoftGraphUserPfxCertificate> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to userPfxCertificates for deviceManagement

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
Entity that encapsulates all information required for a user's PFX certificates.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserPfxCertificate
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
Date/time when this PFX certificate was imported.

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

### -EncryptedPfxBlobInputFile
Input File for EncryptedPfxBlob (Encrypted PFX blob.)

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

### -EncryptedPfxPassword
Encrypted PFX password.

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

### -ExpirationDateTime
Certificate's validity expiration date/time.

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

### -IntendedPurpose
Supported values for the intended purpose of a user PFX certificate.

```yaml
Type: Microsoft.Graph.PowerShell.Support.UserPfxIntendedPurpose
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -KeyName
Name of the key (within the provider) used to encrypt the blob.

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

### -LastModifiedDateTime
Date/time when this PFX certificate was last modified.

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

### -PaddingScheme
Supported values for the padding scheme used by encryption provider.

```yaml
Type: Microsoft.Graph.PowerShell.Support.UserPfxPaddingScheme
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProviderName
Crypto provider used to encrypt this blob.

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

### -StartDateTime
Certificate's validity start date/time.

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

### -Thumbprint
SHA-1 thumbprint of the PFX certificate.

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
User Principal Name of the PFX certificate.

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserPfxCertificate

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserPfxCertificate

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphUserPfxCertificate>: Entity that encapsulates all information required for a user's PFX certificates.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: Date/time when this PFX certificate was imported.
  - `[EncryptedPfxBlob <Byte[]>]`: Encrypted PFX blob.
  - `[EncryptedPfxPassword <String>]`: Encrypted PFX password.
  - `[ExpirationDateTime <DateTime?>]`: Certificate's validity expiration date/time.
  - `[IntendedPurpose <UserPfxIntendedPurpose?>]`: Supported values for the intended purpose of a user PFX certificate.
  - `[KeyName <String>]`: Name of the key (within the provider) used to encrypt the blob.
  - `[LastModifiedDateTime <DateTime?>]`: Date/time when this PFX certificate was last modified.
  - `[PaddingScheme <UserPfxPaddingScheme?>]`: Supported values for the padding scheme used by encryption provider.
  - `[ProviderName <String>]`: Crypto provider used to encrypt this blob.
  - `[StartDateTime <DateTime?>]`: Certificate's validity start date/time.
  - `[Thumbprint <String>]`: SHA-1 thumbprint of the PFX certificate.
  - `[UserPrincipalName <String>]`: User Principal Name of the PFX certificate.

## RELATED LINKS

