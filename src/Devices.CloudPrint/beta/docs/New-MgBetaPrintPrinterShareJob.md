---
external help file:
Module Name: Microsoft.Graph.Beta.Devices.CloudPrint
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.devices.cloudprint/new-mgbetaprintprintersharejob
schema: 2.0.0
---

# New-MgBetaPrintPrinterShareJob

## SYNOPSIS
Create new navigation property to jobs for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaPrintPrinterShareJob -PrinterShareId <String> [-AcknowledgedDateTime <DateTime>]
 [-AdditionalProperties <Hashtable>] [-CompletedDateTime <DateTime>]
 [-Configuration <IMicrosoftGraphPrintJobConfiguration>] [-CreatedBy <IMicrosoftGraphUserIdentity>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Documents <IMicrosoftGraphPrintDocument[]>]
 [-ErrorCode <Int32>] [-Id <String>] [-IsFetchable] [-RedirectedFrom <String>] [-RedirectedTo <String>]
 [-ResponseHeadersVariable <String>] [-Status <IMicrosoftGraphPrintJobStatus>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaPrintPrinterShareJob -PrinterShareId <String> -BodyParameter <IMicrosoftGraphPrintJob>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgBetaPrintPrinterShareJob -InputObject <IDevicesCloudPrintIdentity>
 -BodyParameter <IMicrosoftGraphPrintJob> [-ResponseHeadersVariable <String>] [-Headers <IDictionary>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgBetaPrintPrinterShareJob -InputObject <IDevicesCloudPrintIdentity> [-AcknowledgedDateTime <DateTime>]
 [-AdditionalProperties <Hashtable>] [-CompletedDateTime <DateTime>]
 [-Configuration <IMicrosoftGraphPrintJobConfiguration>] [-CreatedBy <IMicrosoftGraphUserIdentity>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Documents <IMicrosoftGraphPrintDocument[]>]
 [-ErrorCode <Int32>] [-Id <String>] [-IsFetchable] [-RedirectedFrom <String>] [-RedirectedTo <String>]
 [-ResponseHeadersVariable <String>] [-Status <IMicrosoftGraphPrintJobStatus>]
 [-Tasks <IMicrosoftGraphPrintTask[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to jobs for print

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

### -AcknowledgedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printJob
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJob
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CompletedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Configuration
printJobConfiguration
To construct, see NOTES section for CONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJobConfiguration
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedBy
userIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphUserIdentity
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The DateTimeOffset when the job was created.
Read-only.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
The name of the print job.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Documents
.
To construct, see NOTES section for DOCUMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintDocument[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ErrorCode
.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### -Id
The unique identifier for an entity.
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsFetchable
If true, document can be fetched by printer.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrinterShareId
The unique identifier of printerShare

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedirectedFrom
Contains the source job URL, if the job has been redirected from another printer.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RedirectedTo
Contains the destination job URL, if the job has been redirected to another printer.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### -Status
printJobStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJobStatus
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tasks
A list of printTasks that were triggered by this print job.
To construct, see NOTES section for TASKS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintTask[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IDevicesCloudPrintIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJob

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphPrintJob

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphPrintJob>`: printJob
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AcknowledgedDateTime <DateTime?>]`: 
  - `[CompletedDateTime <DateTime?>]`: 
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
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[CreatedDateTime <DateTime?>]`: The DateTimeOffset when the job was created. Read-only.
  - `[DisplayName <String>]`: The name of the print job.
  - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Configuration <IMicrosoftGraphPrinterDocumentConfiguration>]`: printerDocumentConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Collate <Boolean?>]`: 
      - `[ColorMode <String>]`: printColorMode
      - `[Copies <Int32?>]`: 
      - `[Dpi <Int32?>]`: 
      - `[DuplexMode <String>]`: printDuplexMode
      - `[FeedDirection <String>]`: printerFeedDirection
      - `[FeedOrientation <String>]`: printerFeedOrientation
      - `[Finishings <String[]>]`: 
      - `[FitPdfToPage <Boolean?>]`: 
      - `[InputBin <String>]`: 
      - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
      - `[MediaSize <String>]`: 
      - `[MediaType <String>]`: 
      - `[MultipageLayout <String>]`: printMultipageLayout
      - `[Orientation <String>]`: printOrientation
      - `[OutputBin <String>]`: 
      - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: 
      - `[PagesPerSheet <Int32?>]`: 
      - `[Quality <String>]`: printQuality
      - `[Scaling <String>]`: printScaling
    - `[ContentType <String>]`: The document's content (MIME) type. Read-only.
    - `[DisplayName <String>]`: The document's name. Read-only.
    - `[DownloadedDateTime <DateTime?>]`: 
    - `[Size <Int64?>]`: The document's size in bytes. Read-only.
    - `[UploadedDateTime <DateTime?>]`: 
  - `[ErrorCode <Int32?>]`: 
  - `[IsFetchable <Boolean?>]`: If true, document can be fetched by printer.
  - `[RedirectedFrom <String>]`: Contains the source job URL, if the job has been redirected from another printer.
  - `[RedirectedTo <String>]`: Contains the destination job URL, if the job has been redirected to another printer.
  - `[Status <IMicrosoftGraphPrintJobStatus>]`: printJobStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AcquiredByPrinter <Boolean?>]`: 
    - `[Description <String>]`: A human-readable description of the print job's current processing state. Read-only.
    - `[Details <String[]>]`: Additional details for print job state. Valid values are described in the following table. Read-only.
    - `[IsAcquiredByPrinter <Boolean?>]`: True if the job was acknowledged by a printer; false otherwise. Read-only.
    - `[ProcessingState <String>]`: printJobProcessingState
    - `[ProcessingStateDescription <String>]`: 
    - `[State <String>]`: printJobProcessingState
  - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of printTasks that were triggered by this print job.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppId <String>]`: Refers to the unique identifier representing application ID in the Microsoft Entra ID.
        - `[DisplayName <String>]`: Refers to the application name displayed in the Microsoft Entra admin center.
        - `[ServicePrincipalId <String>]`: Refers to the unique identifier indicating service principal ID in Microsoft Entra ID for the corresponding App.
        - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
      - `[DisplayName <String>]`: The name of the printTaskDefinition.
      - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
    - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
    - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
      - `[State <String>]`: printTaskProcessingState
    - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[Event <String>]`: printEvent

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

`CREATEDBY <IMicrosoftGraphUserIdentity>`: userIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. The display name might not always be available or up to date. For example, if a user changes their display name the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[Id <String>]`: Unique identifier for the identity. When the unique identifier is unavailable, the displayName property is provided for the identity, but the id property isn't included in the response.
  - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

`DOCUMENTS <IMicrosoftGraphPrintDocument[]>`: .
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Configuration <IMicrosoftGraphPrinterDocumentConfiguration>]`: printerDocumentConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Collate <Boolean?>]`: 
    - `[ColorMode <String>]`: printColorMode
    - `[Copies <Int32?>]`: 
    - `[Dpi <Int32?>]`: 
    - `[DuplexMode <String>]`: printDuplexMode
    - `[FeedDirection <String>]`: printerFeedDirection
    - `[FeedOrientation <String>]`: printerFeedOrientation
    - `[Finishings <String[]>]`: 
    - `[FitPdfToPage <Boolean?>]`: 
    - `[InputBin <String>]`: 
    - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Bottom <Int32?>]`: The margin in microns from the bottom edge.
      - `[Left <Int32?>]`: The margin in microns from the left edge.
      - `[Right <Int32?>]`: The margin in microns from the right edge.
      - `[Top <Int32?>]`: The margin in microns from the top edge.
    - `[MediaSize <String>]`: 
    - `[MediaType <String>]`: 
    - `[MultipageLayout <String>]`: printMultipageLayout
    - `[Orientation <String>]`: printOrientation
    - `[OutputBin <String>]`: 
    - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: 
      - `[End <Int64?>]`: The inclusive upper bound of the integer range.
      - `[Maximum <Int64?>]`: 
      - `[Minimum <Int64?>]`: 
      - `[Start <Int64?>]`: The inclusive lower bound of the integer range.
    - `[PagesPerSheet <Int32?>]`: 
    - `[Quality <String>]`: printQuality
    - `[Scaling <String>]`: printScaling
  - `[ContentType <String>]`: The document's content (MIME) type. Read-only.
  - `[DisplayName <String>]`: The document's name. Read-only.
  - `[DownloadedDateTime <DateTime?>]`: 
  - `[Size <Int64?>]`: The document's size in bytes. Read-only.
  - `[UploadedDateTime <DateTime?>]`: 

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

`STATUS <IMicrosoftGraphPrintJobStatus>`: printJobStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AcquiredByPrinter <Boolean?>]`: 
  - `[Description <String>]`: A human-readable description of the print job's current processing state. Read-only.
  - `[Details <String[]>]`: Additional details for print job state. Valid values are described in the following table. Read-only.
  - `[IsAcquiredByPrinter <Boolean?>]`: True if the job was acknowledged by a printer; false otherwise. Read-only.
  - `[ProcessingState <String>]`: printJobProcessingState
  - `[ProcessingStateDescription <String>]`: 
  - `[State <String>]`: printJobProcessingState

`TASKS <IMicrosoftGraphPrintTask[]>`: A list of printTasks that were triggered by this print job.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AppId <String>]`: Refers to the unique identifier representing application ID in the Microsoft Entra ID.
      - `[DisplayName <String>]`: Refers to the application name displayed in the Microsoft Entra admin center.
      - `[ServicePrincipalId <String>]`: Refers to the unique identifier indicating service principal ID in Microsoft Entra ID for the corresponding App.
      - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
    - `[DisplayName <String>]`: The name of the printTaskDefinition.
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: A list of tasks that have been created based on this definition. The list includes currently running tasks and recently completed tasks. Read-only.
  - `[ParentUrl <String>]`: The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/beta/print/printers/{printerId}/jobs/{jobId}. Read-only.
  - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Description <String>]`: A human-readable description of the current processing state of the printTask.
    - `[State <String>]`: printTaskProcessingState
  - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
    - `[Event <String>]`: printEvent

## RELATED LINKS

