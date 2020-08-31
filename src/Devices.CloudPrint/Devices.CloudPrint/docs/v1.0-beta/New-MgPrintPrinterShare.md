---
external help file:
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/new-mgprintprintershare
schema: 2.0.0
---

# New-MgPrintPrinterShare

## SYNOPSIS
Create new navigation property to printerShares for print

## SYNTAX

### CreateExpanded (Default)
```
New-MgPrintPrinterShare [-AdditionalProperties <Hashtable>] [-AllowAllUsers]
 [-AllowedGroups <IMicrosoftGraphPrintIdentity[]>] [-AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]
 [-Capabilities <IMicrosoftGraphPrinterCapabilities>] [-CreatedDateTime <DateTime>]
 [-Defaults <IMicrosoftGraphPrinterDefaults>] [-Id <String>] [-IsAcceptingJobs]
 [-Jobs <IMicrosoftGraphPrintJob[]>] [-Location <IMicrosoftGraphPrinterLocation>] [-Manufacturer <String>]
 [-Model <String>] [-Name <String>] [-Printer <IMicrosoftGraphPrinter>]
 [-Status <IMicrosoftGraphPrinterStatus>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgPrintPrinterShare -BodyParameter <IMicrosoftGraphPrinterShare> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to printerShares for print

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

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

### -AllowAllUsers
.

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

### -AllowedGroups
.
To construct, see NOTES section for ALLOWEDGROUPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintIdentity[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AllowedUsers
.
To construct, see NOTES section for ALLOWEDUSERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintUserIdentity[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printerShare
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Capabilities
printerCapabilities
To construct, see NOTES section for CAPABILITIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterCapabilities
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

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

### -Defaults
printerDefaults
To construct, see NOTES section for DEFAULTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterDefaults
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
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsAcceptingJobs
.

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

### -Jobs
.
To construct, see NOTES section for JOBS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrintJob[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Location
printerLocation
To construct, see NOTES section for LOCATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterLocation
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
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

### -Printer
printer
To construct, see NOTES section for PRINTER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
printerStatus
To construct, see NOTES section for STATUS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterStatus
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinterShare

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


ALLOWEDGROUPS <IMicrosoftGraphPrintIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 

ALLOWEDUSERS <IMicrosoftGraphPrintUserIdentity[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[IPAddress <String>]`: 
  - `[UserPrincipalName <String>]`: 

BODYPARAMETER <IMicrosoftGraphPrinterShare>: printerShare
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BottomMargins <Int32[]>]`: 
    - `[Collation <Boolean?>]`: 
    - `[ColorModes <String[]>]`: 
    - `[ContentTypes <String[]>]`: 
    - `[CopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <Int64?>]`: 
      - `[Maximum <Int64?>]`: 
      - `[Minimum <Int64?>]`: 
      - `[Start <Int64?>]`: 
    - `[Dpis <Int32[]>]`: 
    - `[DuplexModes <String[]>]`: 
    - `[FeedDirections <String[]>]`: 
    - `[Finishings <String[]>]`: 
    - `[InputBins <String[]>]`: 
    - `[IsColorPrintingSupported <Boolean?>]`: 
    - `[IsPageRangeSupported <Boolean?>]`: 
    - `[LeftMargins <Int32[]>]`: 
    - `[MediaColors <String[]>]`: 
    - `[MediaSizes <String[]>]`: 
    - `[MediaTypes <String[]>]`: 
    - `[MultipageLayouts <String[]>]`: 
    - `[Orientations <String[]>]`: 
    - `[OutputBins <String[]>]`: 
    - `[PagesPerSheet <Int32[]>]`: 
    - `[Qualities <String[]>]`: 
    - `[RightMargins <Int32[]>]`: 
    - `[Scalings <String[]>]`: 
    - `[SupportedColorConfigurations <String[]>]`: 
    - `[SupportedCopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
    - `[SupportedDocumentMimeTypes <String[]>]`: 
    - `[SupportedDuplexConfigurations <String[]>]`: 
    - `[SupportedFinishings <String[]>]`: 
    - `[SupportedMediaColors <String[]>]`: 
    - `[SupportedMediaSizes <String[]>]`: 
    - `[SupportedMediaTypes <String[]>]`: 
    - `[SupportedOrientations <String[]>]`: 
    - `[SupportedOutputBins <String[]>]`: 
    - `[SupportedPagesPerSheet <IMicrosoftGraphIntegerRange>]`: integerRange
    - `[SupportedPresentationDirections <String[]>]`: 
    - `[SupportedPrintQualities <String[]>]`: 
    - `[SupportsFitPdfToPage <Boolean?>]`: 
    - `[TopMargins <Int32[]>]`: 
  - `[Defaults <IMicrosoftGraphPrinterDefaults>]`: printerDefaults
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ColorMode <String>]`: printColorMode
    - `[ContentType <String>]`: 
    - `[CopiesPerJob <Int32?>]`: 
    - `[DocumentMimeType <String>]`: 
    - `[Dpi <Int32?>]`: 
    - `[DuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DuplexMode <String>]`: printDuplexMode
    - `[Finishings <String[]>]`: 
    - `[FitPdfToPage <Boolean?>]`: 
    - `[MediaColor <String>]`: 
    - `[MediaSize <String>]`: 
    - `[MediaType <String>]`: 
    - `[MultipageLayout <String>]`: printMultipageLayout
    - `[Orientation <String>]`: printOrientation
    - `[OutputBin <String>]`: 
    - `[PagesPerSheet <Int32?>]`: 
    - `[PdfFitToPage <Boolean?>]`: 
    - `[PresentationDirection <String>]`: printPresentationDirection
    - `[PrintColorConfiguration <String>]`: printColorConfiguration
    - `[PrintQuality <String>]`: printQuality
    - `[Quality <String>]`: printQuality
    - `[Scaling <String>]`: printScaling
  - `[IsAcceptingJobs <Boolean?>]`: 
  - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
      - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
      - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Configuration <IMicrosoftGraphPrinterDocumentConfiguration>]`: printerDocumentConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Collate <Boolean?>]`: 
        - `[ColorMode <String>]`: printColorMode
        - `[Copies <Int32?>]`: 
        - `[Dpi <Int32?>]`: 
        - `[DuplexMode <String>]`: printDuplexMode
        - `[FeedDirection <String>]`: printerFeedDirection
        - `[Finishings <String[]>]`: 
        - `[FitPdfToPage <Boolean?>]`: 
        - `[InputBin <String>]`: 
        - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Bottom <Int32?>]`: 
          - `[Left <Int32?>]`: 
          - `[Right <Int32?>]`: 
          - `[Top <Int32?>]`: 
        - `[MediaSize <String>]`: 
        - `[MediaType <String>]`: 
        - `[MultipageLayout <String>]`: printMultipageLayout
        - `[Orientation <String>]`: printOrientation
        - `[OutputBin <String>]`: 
        - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: 
        - `[PagesPerSheet <Int32?>]`: 
        - `[Quality <String>]`: printQuality
        - `[Scaling <String>]`: printScaling
      - `[ContentType <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Size <Int64?>]`: 
    - `[Status <IMicrosoftGraphPrintJobStatus>]`: printJobStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcquiredByPrinter <Boolean?>]`: 
      - `[ProcessingState <String>]`: printJobProcessingState
      - `[ProcessingStateDescription <String>]`: 
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
          - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
          - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
          - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
        - `[DisplayName <String>]`: 
        - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
      - `[ParentUrl <String>]`: 
      - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: 
        - `[State <String>]`: printTaskProcessingState
      - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
        - `[Event <String>]`: printEvent
  - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AltitudeInMeters <Int32?>]`: 
    - `[Building <String>]`: 
    - `[City <String>]`: 
    - `[CountryOrRegion <String>]`: 
    - `[FloorDescription <String>]`: 
    - `[FloorNumber <Int32?>]`: 
    - `[Latitude <Single?>]`: 
    - `[Longitude <Single?>]`: 
    - `[Organization <String[]>]`: 
    - `[PostalCode <String>]`: 
    - `[RoomDescription <String>]`: 
    - `[RoomNumber <Int32?>]`: 
    - `[Site <String>]`: 
    - `[StateOrProvince <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Subdivision <String[]>]`: 
    - `[Subunit <String[]>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[Status <IMicrosoftGraphPrinterStatus>]`: printerStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ProcessingState <String>]`: printerProcessingState
    - `[ProcessingStateDescription <String>]`: 
    - `[ProcessingStateReasons <String[]>]`: 
  - `[Id <String>]`: Read-only.
  - `[AllowAllUsers <Boolean?>]`: 
  - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IPAddress <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Printer <IMicrosoftGraphPrinter>]`: printer
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[Defaults <IMicrosoftGraphPrinterDefaults>]`: printerDefaults
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[Status <IMicrosoftGraphPrinterStatus>]`: printerStatus
    - `[Id <String>]`: Read-only.
    - `[AcceptingJobs <Boolean?>]`: 
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppVersion <String>]`: 
      - `[DeviceHealth <IMicrosoftGraphDeviceHealth>]`: deviceHealth
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[LastConnectionTime <DateTime?>]`: 
      - `[FullyQualifiedDomainName <String>]`: 
      - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
      - `[Name <String>]`: 
      - `[OperatingSystem <String>]`: 
      - `[RegisteredDateTime <DateTime?>]`: 
    - `[IsShared <Boolean?>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
    - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare
    - `[TaskTriggers <IMicrosoftGraphPrintTaskTrigger[]>]`: 

CAPABILITIES <IMicrosoftGraphPrinterCapabilities>: printerCapabilities
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[BottomMargins <Int32[]>]`: 
  - `[Collation <Boolean?>]`: 
  - `[ColorModes <String[]>]`: 
  - `[ContentTypes <String[]>]`: 
  - `[CopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[End <Int64?>]`: 
    - `[Maximum <Int64?>]`: 
    - `[Minimum <Int64?>]`: 
    - `[Start <Int64?>]`: 
  - `[Dpis <Int32[]>]`: 
  - `[DuplexModes <String[]>]`: 
  - `[FeedDirections <String[]>]`: 
  - `[Finishings <String[]>]`: 
  - `[InputBins <String[]>]`: 
  - `[IsColorPrintingSupported <Boolean?>]`: 
  - `[IsPageRangeSupported <Boolean?>]`: 
  - `[LeftMargins <Int32[]>]`: 
  - `[MediaColors <String[]>]`: 
  - `[MediaSizes <String[]>]`: 
  - `[MediaTypes <String[]>]`: 
  - `[MultipageLayouts <String[]>]`: 
  - `[Orientations <String[]>]`: 
  - `[OutputBins <String[]>]`: 
  - `[PagesPerSheet <Int32[]>]`: 
  - `[Qualities <String[]>]`: 
  - `[RightMargins <Int32[]>]`: 
  - `[Scalings <String[]>]`: 
  - `[SupportedColorConfigurations <String[]>]`: 
  - `[SupportedCopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
  - `[SupportedDocumentMimeTypes <String[]>]`: 
  - `[SupportedDuplexConfigurations <String[]>]`: 
  - `[SupportedFinishings <String[]>]`: 
  - `[SupportedMediaColors <String[]>]`: 
  - `[SupportedMediaSizes <String[]>]`: 
  - `[SupportedMediaTypes <String[]>]`: 
  - `[SupportedOrientations <String[]>]`: 
  - `[SupportedOutputBins <String[]>]`: 
  - `[SupportedPagesPerSheet <IMicrosoftGraphIntegerRange>]`: integerRange
  - `[SupportedPresentationDirections <String[]>]`: 
  - `[SupportedPrintQualities <String[]>]`: 
  - `[SupportsFitPdfToPage <Boolean?>]`: 
  - `[TopMargins <Int32[]>]`: 

DEFAULTS <IMicrosoftGraphPrinterDefaults>: printerDefaults
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ColorMode <String>]`: printColorMode
  - `[ContentType <String>]`: 
  - `[CopiesPerJob <Int32?>]`: 
  - `[DocumentMimeType <String>]`: 
  - `[Dpi <Int32?>]`: 
  - `[DuplexConfiguration <String>]`: printDuplexConfiguration
  - `[DuplexMode <String>]`: printDuplexMode
  - `[Finishings <String[]>]`: 
  - `[FitPdfToPage <Boolean?>]`: 
  - `[MediaColor <String>]`: 
  - `[MediaSize <String>]`: 
  - `[MediaType <String>]`: 
  - `[MultipageLayout <String>]`: printMultipageLayout
  - `[Orientation <String>]`: printOrientation
  - `[OutputBin <String>]`: 
  - `[PagesPerSheet <Int32?>]`: 
  - `[PdfFitToPage <Boolean?>]`: 
  - `[PresentationDirection <String>]`: printPresentationDirection
  - `[PrintColorConfiguration <String>]`: printColorConfiguration
  - `[PrintQuality <String>]`: printQuality
  - `[Quality <String>]`: printQuality
  - `[Scaling <String>]`: printScaling

JOBS <IMicrosoftGraphPrintJob[]>: .
  - `[Id <String>]`: Read-only.
  - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
    - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
    - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Configuration <IMicrosoftGraphPrinterDocumentConfiguration>]`: printerDocumentConfiguration
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Collate <Boolean?>]`: 
      - `[ColorMode <String>]`: printColorMode
      - `[Copies <Int32?>]`: 
      - `[Dpi <Int32?>]`: 
      - `[DuplexMode <String>]`: printDuplexMode
      - `[FeedDirection <String>]`: printerFeedDirection
      - `[Finishings <String[]>]`: 
      - `[FitPdfToPage <Boolean?>]`: 
      - `[InputBin <String>]`: 
      - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Bottom <Int32?>]`: 
        - `[Left <Int32?>]`: 
        - `[Right <Int32?>]`: 
        - `[Top <Int32?>]`: 
      - `[MediaSize <String>]`: 
      - `[MediaType <String>]`: 
      - `[MultipageLayout <String>]`: printMultipageLayout
      - `[Orientation <String>]`: printOrientation
      - `[OutputBin <String>]`: 
      - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: 
        - `[End <Int64?>]`: 
        - `[Maximum <Int64?>]`: 
        - `[Minimum <Int64?>]`: 
        - `[Start <Int64?>]`: 
      - `[PagesPerSheet <Int32?>]`: 
      - `[Quality <String>]`: printQuality
      - `[Scaling <String>]`: printScaling
    - `[ContentType <String>]`: 
    - `[DisplayName <String>]`: 
    - `[Size <Int64?>]`: 
  - `[Status <IMicrosoftGraphPrintJobStatus>]`: printJobStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AcquiredByPrinter <Boolean?>]`: 
    - `[ProcessingState <String>]`: printJobProcessingState
    - `[ProcessingStateDescription <String>]`: 
  - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
        - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
        - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
        - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
      - `[DisplayName <String>]`: 
      - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
    - `[ParentUrl <String>]`: 
    - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Description <String>]`: 
      - `[State <String>]`: printTaskProcessingState
    - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
      - `[Event <String>]`: printEvent

LOCATION <IMicrosoftGraphPrinterLocation>: printerLocation
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AltitudeInMeters <Int32?>]`: 
  - `[Building <String>]`: 
  - `[City <String>]`: 
  - `[CountryOrRegion <String>]`: 
  - `[FloorDescription <String>]`: 
  - `[FloorNumber <Int32?>]`: 
  - `[Latitude <Single?>]`: 
  - `[Longitude <Single?>]`: 
  - `[Organization <String[]>]`: 
  - `[PostalCode <String>]`: 
  - `[RoomDescription <String>]`: 
  - `[RoomNumber <Int32?>]`: 
  - `[Site <String>]`: 
  - `[StateOrProvince <String>]`: 
  - `[StreetAddress <String>]`: 
  - `[Subdivision <String[]>]`: 
  - `[Subunit <String[]>]`: 

PRINTER <IMicrosoftGraphPrinter>: printer
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[BottomMargins <Int32[]>]`: 
    - `[Collation <Boolean?>]`: 
    - `[ColorModes <String[]>]`: 
    - `[ContentTypes <String[]>]`: 
    - `[CopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[End <Int64?>]`: 
      - `[Maximum <Int64?>]`: 
      - `[Minimum <Int64?>]`: 
      - `[Start <Int64?>]`: 
    - `[Dpis <Int32[]>]`: 
    - `[DuplexModes <String[]>]`: 
    - `[FeedDirections <String[]>]`: 
    - `[Finishings <String[]>]`: 
    - `[InputBins <String[]>]`: 
    - `[IsColorPrintingSupported <Boolean?>]`: 
    - `[IsPageRangeSupported <Boolean?>]`: 
    - `[LeftMargins <Int32[]>]`: 
    - `[MediaColors <String[]>]`: 
    - `[MediaSizes <String[]>]`: 
    - `[MediaTypes <String[]>]`: 
    - `[MultipageLayouts <String[]>]`: 
    - `[Orientations <String[]>]`: 
    - `[OutputBins <String[]>]`: 
    - `[PagesPerSheet <Int32[]>]`: 
    - `[Qualities <String[]>]`: 
    - `[RightMargins <Int32[]>]`: 
    - `[Scalings <String[]>]`: 
    - `[SupportedColorConfigurations <String[]>]`: 
    - `[SupportedCopiesPerJob <IMicrosoftGraphIntegerRange>]`: integerRange
    - `[SupportedDocumentMimeTypes <String[]>]`: 
    - `[SupportedDuplexConfigurations <String[]>]`: 
    - `[SupportedFinishings <String[]>]`: 
    - `[SupportedMediaColors <String[]>]`: 
    - `[SupportedMediaSizes <String[]>]`: 
    - `[SupportedMediaTypes <String[]>]`: 
    - `[SupportedOrientations <String[]>]`: 
    - `[SupportedOutputBins <String[]>]`: 
    - `[SupportedPagesPerSheet <IMicrosoftGraphIntegerRange>]`: integerRange
    - `[SupportedPresentationDirections <String[]>]`: 
    - `[SupportedPrintQualities <String[]>]`: 
    - `[SupportsFitPdfToPage <Boolean?>]`: 
    - `[TopMargins <Int32[]>]`: 
  - `[Defaults <IMicrosoftGraphPrinterDefaults>]`: printerDefaults
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ColorMode <String>]`: printColorMode
    - `[ContentType <String>]`: 
    - `[CopiesPerJob <Int32?>]`: 
    - `[DocumentMimeType <String>]`: 
    - `[Dpi <Int32?>]`: 
    - `[DuplexConfiguration <String>]`: printDuplexConfiguration
    - `[DuplexMode <String>]`: printDuplexMode
    - `[Finishings <String[]>]`: 
    - `[FitPdfToPage <Boolean?>]`: 
    - `[MediaColor <String>]`: 
    - `[MediaSize <String>]`: 
    - `[MediaType <String>]`: 
    - `[MultipageLayout <String>]`: printMultipageLayout
    - `[Orientation <String>]`: printOrientation
    - `[OutputBin <String>]`: 
    - `[PagesPerSheet <Int32?>]`: 
    - `[PdfFitToPage <Boolean?>]`: 
    - `[PresentationDirection <String>]`: printPresentationDirection
    - `[PrintColorConfiguration <String>]`: printColorConfiguration
    - `[PrintQuality <String>]`: printQuality
    - `[Quality <String>]`: printQuality
    - `[Scaling <String>]`: printScaling
  - `[IsAcceptingJobs <Boolean?>]`: 
  - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[CreatedBy <IMicrosoftGraphUserIdentity>]`: userIdentity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
      - `[IPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
      - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Documents <IMicrosoftGraphPrintDocument[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Configuration <IMicrosoftGraphPrinterDocumentConfiguration>]`: printerDocumentConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Collate <Boolean?>]`: 
        - `[ColorMode <String>]`: printColorMode
        - `[Copies <Int32?>]`: 
        - `[Dpi <Int32?>]`: 
        - `[DuplexMode <String>]`: printDuplexMode
        - `[FeedDirection <String>]`: printerFeedDirection
        - `[Finishings <String[]>]`: 
        - `[FitPdfToPage <Boolean?>]`: 
        - `[InputBin <String>]`: 
        - `[Margin <IMicrosoftGraphPrintMargin>]`: printMargin
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Bottom <Int32?>]`: 
          - `[Left <Int32?>]`: 
          - `[Right <Int32?>]`: 
          - `[Top <Int32?>]`: 
        - `[MediaSize <String>]`: 
        - `[MediaType <String>]`: 
        - `[MultipageLayout <String>]`: printMultipageLayout
        - `[Orientation <String>]`: printOrientation
        - `[OutputBin <String>]`: 
        - `[PageRanges <IMicrosoftGraphIntegerRange[]>]`: 
        - `[PagesPerSheet <Int32?>]`: 
        - `[Quality <String>]`: printQuality
        - `[Scaling <String>]`: printScaling
      - `[ContentType <String>]`: 
      - `[DisplayName <String>]`: 
      - `[Size <Int64?>]`: 
    - `[Status <IMicrosoftGraphPrintJobStatus>]`: printJobStatus
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcquiredByPrinter <Boolean?>]`: 
      - `[ProcessingState <String>]`: printJobProcessingState
      - `[ProcessingStateDescription <String>]`: 
    - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
      - `[Id <String>]`: Read-only.
      - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[CreatedBy <IMicrosoftGraphAppIdentity>]`: appIdentity
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
          - `[DisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
          - `[ServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
          - `[ServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
        - `[DisplayName <String>]`: 
        - `[Tasks <IMicrosoftGraphPrintTask[]>]`: 
      - `[ParentUrl <String>]`: 
      - `[Status <IMicrosoftGraphPrintTaskStatus>]`: printTaskStatus
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Description <String>]`: 
        - `[State <String>]`: printTaskProcessingState
      - `[Trigger <IMicrosoftGraphPrintTaskTrigger>]`: printTaskTrigger
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Definition <IMicrosoftGraphPrintTaskDefinition>]`: printTaskDefinition
        - `[Event <String>]`: printEvent
  - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AltitudeInMeters <Int32?>]`: 
    - `[Building <String>]`: 
    - `[City <String>]`: 
    - `[CountryOrRegion <String>]`: 
    - `[FloorDescription <String>]`: 
    - `[FloorNumber <Int32?>]`: 
    - `[Latitude <Single?>]`: 
    - `[Longitude <Single?>]`: 
    - `[Organization <String[]>]`: 
    - `[PostalCode <String>]`: 
    - `[RoomDescription <String>]`: 
    - `[RoomNumber <Int32?>]`: 
    - `[Site <String>]`: 
    - `[StateOrProvince <String>]`: 
    - `[StreetAddress <String>]`: 
    - `[Subdivision <String[]>]`: 
    - `[Subunit <String[]>]`: 
  - `[Manufacturer <String>]`: 
  - `[Model <String>]`: 
  - `[Name <String>]`: 
  - `[Status <IMicrosoftGraphPrinterStatus>]`: printerStatus
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ProcessingState <String>]`: printerProcessingState
    - `[ProcessingStateDescription <String>]`: 
    - `[ProcessingStateReasons <String[]>]`: 
  - `[Id <String>]`: Read-only.
  - `[AcceptingJobs <Boolean?>]`: 
  - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
  - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[IPAddress <String>]`: 
    - `[UserPrincipalName <String>]`: 
  - `[Connectors <IMicrosoftGraphPrintConnector[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[AppVersion <String>]`: 
    - `[DeviceHealth <IMicrosoftGraphDeviceHealth>]`: deviceHealth
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LastConnectionTime <DateTime?>]`: 
    - `[FullyQualifiedDomainName <String>]`: 
    - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[Name <String>]`: 
    - `[OperatingSystem <String>]`: 
    - `[RegisteredDateTime <DateTime?>]`: 
  - `[IsShared <Boolean?>]`: 
  - `[RegisteredDateTime <DateTime?>]`: 
  - `[Share <IMicrosoftGraphPrinterShare>]`: printerShare
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Capabilities <IMicrosoftGraphPrinterCapabilities>]`: printerCapabilities
    - `[Defaults <IMicrosoftGraphPrinterDefaults>]`: printerDefaults
    - `[IsAcceptingJobs <Boolean?>]`: 
    - `[Jobs <IMicrosoftGraphPrintJob[]>]`: 
    - `[Location <IMicrosoftGraphPrinterLocation>]`: printerLocation
    - `[Manufacturer <String>]`: 
    - `[Model <String>]`: 
    - `[Name <String>]`: 
    - `[Status <IMicrosoftGraphPrinterStatus>]`: printerStatus
    - `[Id <String>]`: Read-only.
    - `[AllowAllUsers <Boolean?>]`: 
    - `[AllowedGroups <IMicrosoftGraphPrintIdentity[]>]`: 
    - `[AllowedUsers <IMicrosoftGraphPrintUserIdentity[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[Printer <IMicrosoftGraphPrinter>]`: printer
  - `[TaskTriggers <IMicrosoftGraphPrintTaskTrigger[]>]`: 

STATUS <IMicrosoftGraphPrinterStatus>: printerStatus
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ProcessingState <String>]`: printerProcessingState
  - `[ProcessingStateDescription <String>]`: 
  - `[ProcessingStateReasons <String[]>]`: 

## RELATED LINKS

