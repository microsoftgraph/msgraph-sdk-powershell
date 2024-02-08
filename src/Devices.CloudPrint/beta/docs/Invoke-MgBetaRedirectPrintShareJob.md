---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/invoke-mgbetaredirectprintsharejob
schema: 2.0.0
---

# Invoke-MgBetaRedirectPrintShareJob

## SYNOPSIS
Redirect a print job to a different printer.
Redirecting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.
For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.

## SYNTAX

### RedirectExpanded (Default)
```
Invoke-MgBetaRedirectPrintShareJob -PrinterShareId <String> -PrintJobId <String>
 [-AdditionalProperties <Hashtable>] [-Configuration <IMicrosoftGraphPrintJobConfiguration>]
 [-DestinationPrinterId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Redirect
```
Invoke-MgBetaRedirectPrintShareJob -PrinterShareId <String> -PrintJobId <String>
 -BodyParameter <IPathsQcb95LPrintSharesPrintershareIdJobsPrintjobIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentity
```
Invoke-MgBetaRedirectPrintShareJob -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IPathsQcb95LPrintSharesPrintershareIdJobsPrintjobIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### RedirectViaIdentityExpanded
```
Invoke-MgBetaRedirectPrintShareJob -InputObject <IDevicesCloudPrintIdentity>
 [-AdditionalProperties <Hashtable>] [-Configuration <IMicrosoftGraphPrintJobConfiguration>]
 [-DestinationPrinterId <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Redirect a print job to a different printer.
Redirecting a print job will only succeed if there is a printTask in a processing state on the associated print job, started by a trigger that the requesting app created.
For details about how to use this API to add pull printing support to Universal Print, see Extending Universal Print to support pull printing.

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
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IPathsQcb95LPrintSharesPrintershareIdJobsPrintjobIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Redirect, RedirectViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Configuration
printJobConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJobConfiguration
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DestinationPrinterId
.

```yaml
Type: System.String
Parameter Sets: RedirectExpanded, RedirectViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity
Parameter Sets: RedirectViaIdentity, RedirectViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PrinterShareId
The unique identifier of printerShare

```yaml
Type: System.String
Parameter Sets: Redirect, RedirectExpanded
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
Parameter Sets: Redirect, RedirectExpanded
Aliases:

Required: True
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

### Microsoft.Graph.Beta.PowerShell.Models.IPathsQcb95LPrintSharesPrintershareIdJobsPrintjobIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJob

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IPathsQcb95LPrintSharesPrintershareIdJobsPrintjobIdMicrosoftGraphRedirectPostRequestbodyContentApplicationJsonSchema>`: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Configuration <IMicrosoftGraphPrintJobConfiguration>]`: printJobConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Collate <Boolean?>]`: Whether the printer should collate pages when printing multiple copies of a multi-page document.
    - `[ColorMode <String>]`: printColorMode
    - `[Copies <Int32?>]`: The number of copies that should be printed. Read-only.
    - `[Dpi <Int32?>]`: The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.
    - `[DuplexMode <String>]`: printDuplexMode
    - `[FeedOrientation <String>]`: printerFeedOrientation
    - `[Finishings <String[]>]`: Finishing processes to use when printing.
    - `[FitPdfToPage <Boolean?>]`: 
    - `[InputBin <String>]`: The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.
    - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Bottom <Int32?>]`: The margin in microns from the bottom edge.
      - `[Left <Int32?>]`: The margin in microns from the left edge.
      - `[Right <Int32?>]`: The margin in microns from the right edge.
      - `[Top <Int32?>]`: The margin in microns from the top edge.
    - `[MediaSize <String>]`: The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
    - `[MediaType <String>]`: The default media (such as paper) type to print the document on.
    - `[MultipageLayout <String>]`: printMultipageLayout
    - `[Orientation <String>]`: printOrientation
    - `[OutputBin <String>]`: The output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
    - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: The page ranges to print. Read-only.
      - `[End <Int64?>]`: The inclusive upper bound of the integer range.
      - `[Maximum <Int64?>]`: 
      - `[Minimum <Int64?>]`: 
      - `[Start <Int64?>]`: The inclusive lower bound of the integer range.
    - `[PagesPerSheet <Int32?>]`: The number of document pages to print on each sheet.
    - `[Quality <String>]`: printQuality
    - `[Scaling <String>]`: printScaling
  - `[DestinationPrinterId <String>]`: 

`CONFIGURATION <IMicrosoftGraphPrintJobConfiguration>`: printJobConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Collate <Boolean?>]`: Whether the printer should collate pages when printing multiple copies of a multi-page document.
  - `[ColorMode <String>]`: printColorMode
  - `[Copies <Int32?>]`: The number of copies that should be printed. Read-only.
  - `[Dpi <Int32?>]`: The resolution to use when printing the job, expressed in dots per inch (DPI). Read-only.
  - `[DuplexMode <String>]`: printDuplexMode
  - `[FeedOrientation <String>]`: printerFeedOrientation
  - `[Finishings <String[]>]`: Finishing processes to use when printing.
  - `[FitPdfToPage <Boolean?>]`: 
  - `[InputBin <String>]`: The input bin (tray) to use when printing. See the printer's capabilities for a list of supported input bins.
  - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Bottom <Int32?>]`: The margin in microns from the bottom edge.
    - `[Left <Int32?>]`: The margin in microns from the left edge.
    - `[Right <Int32?>]`: The margin in microns from the right edge.
    - `[Top <Int32?>]`: The margin in microns from the top edge.
  - `[MediaSize <String>]`: The media sizeto use when printing. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
  - `[MediaType <String>]`: The default media (such as paper) type to print the document on.
  - `[MultipageLayout <String>]`: printMultipageLayout
  - `[Orientation <String>]`: printOrientation
  - `[OutputBin <String>]`: The output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
  - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: The page ranges to print. Read-only.
    - `[End <Int64?>]`: The inclusive upper bound of the integer range.
    - `[Maximum <Int64?>]`: 
    - `[Minimum <Int64?>]`: 
    - `[Start <Int64?>]`: The inclusive lower bound of the integer range.
  - `[PagesPerSheet <Int32?>]`: The number of document pages to print on each sheet.
  - `[Quality <String>]`: printQuality
  - `[Scaling <String>]`: printScaling

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

