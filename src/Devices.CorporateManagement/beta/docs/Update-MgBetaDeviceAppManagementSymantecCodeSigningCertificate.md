---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.corporatemanagement/update-mgbetadeviceappmanagementsymanteccodesigningcertificate
schema: 2.0.0
---

# Update-MgBetaDeviceAppManagementSymantecCodeSigningCertificate

## SYNOPSIS
Update the navigation property symantecCodeSigningCertificate in deviceAppManagement

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaDeviceAppManagementSymantecCodeSigningCertificate [-AdditionalProperties <Hashtable>]
 [-ContentInputFile <String>] [-ExpirationDateTime <DateTime>] [-Id <String>] [-Issuer <String>]
 [-IssuerName <String>] [-Password <String>] [-Status <String>] [-Subject <String>] [-SubjectName <String>]
 [-UploadDateTime <DateTime>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaDeviceAppManagementSymantecCodeSigningCertificate
 -BodyParameter <IMicrosoftGraphSymantecCodeSigningCertificate> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property symantecCodeSigningCertificate in deviceAppManagement

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
symantecCodeSigningCertificate
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSymantecCodeSigningCertificate
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentInputFile
Input File for Content (The Windows Symantec Code-Signing Certificate in the raw data format.)

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpirationDateTime
The Cert Expiration Date.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Issuer
The Issuer value for the cert.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IssuerName
The Issuer Name for the cert.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Password
The Password required for .pfx file.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
certificateStatus

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Subject
The Subject value for the cert.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubjectName
The Subject Name for the cert.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UploadDateTime
The Type of the CodeSigning Cert as Symantec Cert.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSymantecCodeSigningCertificate

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSymantecCodeSigningCertificate

## NOTES

ALIASES

Update-MgBetaDeviceAppMgtSymantecCodeSigningCertificate

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSymantecCodeSigningCertificate>`: symantecCodeSigningCertificate
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Content <Byte[]>]`: The Windows Symantec Code-Signing Certificate in the raw data format.
  - `[ExpirationDateTime <DateTime?>]`: The Cert Expiration Date.
  - `[Issuer <String>]`: The Issuer value for the cert.
  - `[IssuerName <String>]`: The Issuer Name for the cert.
  - `[Password <String>]`: The Password required for .pfx file.
  - `[Status <String>]`: certificateStatus
  - `[Subject <String>]`: The Subject value for the cert.
  - `[SubjectName <String>]`: The Subject Name for the cert.
  - `[UploadDateTime <DateTime?>]`: The Type of the CodeSigning Cert as Symantec Cert.

## RELATED LINKS

