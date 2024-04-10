---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/invoke-mgbetaabortprintprinterjob
schema: 2.0.0
---

# Invoke-MgBetaAbortPrintPrinterJob

## SYNOPSIS
Abort a print job.
Only applications using application permissions can abort a print job.
Aborting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.
For details about how to register a task trigger, see Extending Universal Print to support pull printing.

## SYNTAX

### AbortExpanded (Default)
```
Invoke-MgBetaAbortPrintPrinterJob -PrinterId <String> -PrintJobId <String> [-AdditionalProperties <Hashtable>]
 [-Reason <String>] [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Abort
```
Invoke-MgBetaAbortPrintPrinterJob -PrinterId <String> -PrintJobId <String>
 -BodyParameter <IPathsHsc7MjPrintPrintersPrinterIdJobsPrintjobIdMicrosoftGraphAbortPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### AbortViaIdentity
```
Invoke-MgBetaAbortPrintPrinterJob -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IPathsHsc7MjPrintPrintersPrinterIdJobsPrintjobIdMicrosoftGraphAbortPostRequestbodyContentApplicationJsonSchema>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### AbortViaIdentityExpanded
```
Invoke-MgBetaAbortPrintPrinterJob -InputObject <IDevicesCloudPrintIdentity>
 [-AdditionalProperties <Hashtable>] [-Reason <String>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Abort a print job.
Only applications using application permissions can abort a print job.
Aborting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.
For details about how to register a task trigger, see Extending Universal Print to support pull printing.

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
Parameter Sets: AbortExpanded, AbortViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsHsc7MjPrintPrintersPrinterIdJobsPrintjobIdMicrosoftGraphAbortPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Abort, AbortViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: AbortViaIdentity, AbortViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -PrinterId
The unique identifier of printer

```yaml
Type: System.String
Parameter Sets: Abort, AbortExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrintJobId
The unique identifier of printJob

```yaml
Type: System.String
Parameter Sets: Abort, AbortExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Reason
.

```yaml
Type: System.String
Parameter Sets: AbortExpanded, AbortViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPathsHsc7MjPrintPrintersPrinterIdJobsPrintjobIdMicrosoftGraphAbortPostRequestbodyContentApplicationJsonSchema

### System.Collections.IDictionary

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsHsc7MjPrintPrintersPrinterIdJobsPrintjobIdMicrosoftGraphAbortPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Reason <String>]`: 

`INPUTOBJECT <IDevicesCloudPrintIdentity>`: Identity Parameter
  - `[GroupId <String>]`: The unique identifier of group
  - `[PrintConnectorId <String>]`: The unique identifier of printConnector
  - `[PrintDocumentId <String>]`: The unique identifier of printDocument
  - `[PrintJobId <String>]`: The unique identifier of printJob
  - `[PrintOperationId <String>]`: The unique identifier of printOperation
  - `[PrintServiceEndpointId <String>]`: The unique identifier of printServiceEndpoint
  - `[PrintServiceId <String>]`: The unique identifier of printService
  - `[PrintTaskDefinitionId <String>]`: The unique identifier of printTaskDefinition
  - `[PrintTaskId <String>]`: The unique identifier of printTask
  - `[PrintTaskTriggerId <String>]`: The unique identifier of printTaskTrigger
  - `[PrinterId <String>]`: The unique identifier of printer
  - `[PrinterShareId <String>]`: The unique identifier of printerShare
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

