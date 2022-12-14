---
external help file:
Module Name: Microsoft.Graph.Beta.DeviceManagement.Actions
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.devicemanagement.actions/invoke-mgdownloaddevicemanagementcomanageddeviceappdiagnostic
schema: 2.0.0
---

# Invoke-MgBetaDownloadDeviceManagementComanagedDeviceAppDiagnostic

## SYNOPSIS
Invoke action downloadAppDiagnostics

## SYNTAX

### DownloadExpanded (Default)
```
Invoke-MgBetaDownloadDeviceManagementComanagedDeviceAppDiagnostic -OutFile <String>
 [-AdditionalProperties <Hashtable>] [-Request <IMicrosoftGraphPowerliftDownloadRequest>] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Download
```
Invoke-MgBetaDownloadDeviceManagementComanagedDeviceAppDiagnostic
 -BodyParameter <IPaths1K3Iuv6DevicemanagementComanageddevicesMicrosoftGraphDownloadappdiagnosticsPostRequestbodyContentApplicationJsonSchema>
 -OutFile <String> [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action downloadAppDiagnostics

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: DownloadExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1K3Iuv6DevicemanagementComanageddevicesMicrosoftGraphDownloadappdiagnosticsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Download
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -OutFile
Path to write output file to

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
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

### -Request
Request used to download app diagnostic files.
To construct, please use Get-Help -Online and see NOTES section for REQUEST properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPowerliftDownloadRequest
Parameter Sets: DownloadExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1K3Iuv6DevicemanagementComanageddevicesMicrosoftGraphDownloadappdiagnosticsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1K3Iuv6DevicemanagementComanageddevicesMicrosoftGraphDownloadappdiagnosticsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Request <IMicrosoftGraphPowerliftDownloadRequest>]`: Request used to download app diagnostic files.
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Files <String[]>]`: The list of files to download
    - `[PowerliftId <String>]`: The unique id for the request

REQUEST <IMicrosoftGraphPowerliftDownloadRequest>: Request used to download app diagnostic files.
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Files <String[]>]`: The list of files to download
  - `[PowerliftId <String>]`: The unique id for the request

## RELATED LINKS

