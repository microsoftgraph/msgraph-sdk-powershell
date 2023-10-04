---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/new-mgbetaprintprinter
schema: 2.0.0
---

# New-MgBetaPrintPrinter

## SYNOPSIS
Create (register) a printer with the Universal Print service.
This is a long-running operation and as such, it returns a printerCreateOperation that can be used to track and verify the registration of the printer.

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgBetaPrintPrinter [-AdditionalProperties <Hashtable>]
 [-CertificateSigningRequest <IMicrosoftGraphPrintCertificateSigningRequest>] [-ConnectorId <String>]
 [-DisplayName <String>] [-HasPhysicalDevice] [-Manufacturer <String>] [-Model <String>]
 [-PhysicalDeviceId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgBetaPrintPrinter
 -BodyParameter <IPaths18VwyqhPrintPrintersMicrosoftGraphCreatePostRequestbodyContentApplicationJsonSchema>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create (register) a printer with the Universal Print service.
This is a long-running operation and as such, it returns a printerCreateOperation that can be used to track and verify the registration of the printer.

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
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths18VwyqhPrintPrintersMicrosoftGraphCreatePostRequestbodyContentApplicationJsonSchema
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CertificateSigningRequest
printCertificateSigningRequest
To construct, see NOTES section for CERTIFICATESIGNINGREQUEST properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintCertificateSigningRequest
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConnectorId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HasPhysicalDevice
.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Manufacturer
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Model
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### -PhysicalDeviceId
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths18VwyqhPrintPrintersMicrosoftGraphCreatePostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPaths18VwyqhPrintPrintersMicrosoftGraphCreatePostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CertificateSigningRequest <IMicrosoftGraphPrintCertificateSigningRequest>]`: printCertificateSigningRequest
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Content <String>]`: A base64-encoded pkcs10 certificate request. Read-only.
    - `[TransportKey <String>]`: The base64-encoded public portion of an asymmetric key that is generated by the client. Read-only.
  - `[ConnectorId <String>]`: 
  - `[DisplayName <String>]`: 
  - `[HasPhysicalDevice <Boolean?>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[PhysicalDeviceId <String>]`: 

`CERTIFICATESIGNINGREQUEST <IMicrosoftGraphPrintCertificateSigningRequest>`: printCertificateSigningRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Content <String>]`: A base64-encoded pkcs10 certificate request. Read-only.
  - `[TransportKey <String>]`: The base64-encoded public portion of an asymmetric key that is generated by the client. Read-only.

## RELATED LINKS

