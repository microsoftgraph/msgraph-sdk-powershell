---
external help file: Microsoft.Graph.Devices.CloudPrint-help.xml
Module Name: Microsoft.Graph.Devices.CloudPrint
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprintprinter
schema: 2.0.0
---

# Update-MgPrintPrinter

## SYNOPSIS
Update the navigation property printers in print

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPrintPrinter -PrinterId <String> [-AcceptingJobs] [-AdditionalProperties <Hashtable>]
 [-Capabilities <IMicrosoftGraphPrinterCapabilities>] [-Connectors <IMicrosoftGraphPrintConnector[]>]
 [-Defaults <IMicrosoftGraphPrinterDefaults>] [-DisplayName <String>] [-HasPhysicalDevice] [-Id <String>]
 [-IsAcceptingJobs] [-IsShared] [-Jobs <IMicrosoftGraphPrintJob[]>]
 [-Location <IMicrosoftGraphPrinterLocation>] [-Manufacturer <String>] [-Model <String>] [-Name <String>]
 [-RegisteredDateTime <DateTime>] [-Share <IMicrosoftGraphPrinterShare>]
 [-Shares <IMicrosoftGraphPrinterShare[]>] [-Status <IMicrosoftGraphPrinterStatus>]
 [-TaskTriggers <IMicrosoftGraphPrintTaskTrigger[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Update
```
Update-MgPrintPrinter -PrinterId <String> -BodyParameter <IMicrosoftGraphPrinter> [-PassThru] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgPrintPrinter -InputObject <IDevicesCloudPrintIdentity> [-AcceptingJobs]
 [-AdditionalProperties <Hashtable>] [-Capabilities <IMicrosoftGraphPrinterCapabilities>]
 [-Connectors <IMicrosoftGraphPrintConnector[]>] [-Defaults <IMicrosoftGraphPrinterDefaults>]
 [-DisplayName <String>] [-HasPhysicalDevice] [-Id <String>] [-IsAcceptingJobs] [-IsShared]
 [-Jobs <IMicrosoftGraphPrintJob[]>] [-Location <IMicrosoftGraphPrinterLocation>] [-Manufacturer <String>]
 [-Model <String>] [-Name <String>] [-RegisteredDateTime <DateTime>] [-Share <IMicrosoftGraphPrinterShare>]
 [-Shares <IMicrosoftGraphPrinterShare[]>] [-Status <IMicrosoftGraphPrinterStatus>]
 [-TaskTriggers <IMicrosoftGraphPrintTaskTrigger[]>] [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgPrintPrinter -InputObject <IDevicesCloudPrintIdentity> -BodyParameter <IMicrosoftGraphPrinter>
 [-PassThru] [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property printers in print

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AcceptingJobs
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
printer
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrinter
Parameter Sets: Update, UpdateViaIdentity
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
Type: IMicrosoftGraphPrinterCapabilities
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Connectors
.
To construct, see NOTES section for CONNECTORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintConnector[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IMicrosoftGraphPrinterDefaults
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IDevicesCloudPrintIdentity
Parameter Sets: UpdateViaIdentityExpanded, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -IsAcceptingJobs
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsShared
.

```yaml
Type: SwitchParameter
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Jobs
.
To construct, see NOTES section for JOBS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintJob[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IMicrosoftGraphPrinterLocation
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -PrinterId
key: id of printer

```yaml
Type: String
Parameter Sets: UpdateExpanded, Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RegisteredDateTime
.

```yaml
Type: DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Share
printerShare
To construct, see NOTES section for SHARE properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrinterShare
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Shares
.
To construct, see NOTES section for SHARES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrinterShare[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Type: IMicrosoftGraphPrinterStatus
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TaskTriggers
.
To construct, see NOTES section for TASKTRIGGERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphPrintTaskTrigger[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IDevicesCloudPrintIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPrinter
## OUTPUTS

### System.Boolean
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphPrinter\>: printer
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[BottomMargins \<Int32\[\]\>\]: 
    \[Collation \<Boolean?\>\]: 
    \[ColorModes \<String\[\]\>\]: 
    \[ContentTypes \<String\[\]\>\]: 
    \[CopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[End \<Int64?\>\]: 
      \[Maximum \<Int64?\>\]: 
      \[Minimum \<Int64?\>\]: 
      \[Start \<Int64?\>\]: 
    \[Dpis \<Int32\[\]\>\]: 
    \[DuplexModes \<String\[\]\>\]: 
    \[FeedDirections \<String\[\]\>\]: 
    \[FeedOrientations \<String\[\]\>\]: 
    \[Finishings \<String\[\]\>\]: 
    \[InputBins \<String\[\]\>\]: 
    \[IsColorPrintingSupported \<Boolean?\>\]: 
    \[IsPageRangeSupported \<Boolean?\>\]: 
    \[LeftMargins \<Int32\[\]\>\]: 
    \[MediaColors \<String\[\]\>\]: 
    \[MediaSizes \<String\[\]\>\]: 
    \[MediaTypes \<String\[\]\>\]: 
    \[MultipageLayouts \<String\[\]\>\]: 
    \[Orientations \<String\[\]\>\]: 
    \[OutputBins \<String\[\]\>\]: 
    \[PagesPerSheet \<Int32\[\]\>\]: 
    \[Qualities \<String\[\]\>\]: 
    \[RightMargins \<Int32\[\]\>\]: 
    \[Scalings \<String\[\]\>\]: 
    \[SupportedColorConfigurations \<String\[\]\>\]: 
    \[SupportedCopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedDocumentMimeTypes \<String\[\]\>\]: 
    \[SupportedDuplexConfigurations \<String\[\]\>\]: 
    \[SupportedFinishings \<String\[\]\>\]: 
    \[SupportedMediaColors \<String\[\]\>\]: 
    \[SupportedMediaSizes \<String\[\]\>\]: 
    \[SupportedMediaTypes \<String\[\]\>\]: 
    \[SupportedOrientations \<String\[\]\>\]: 
    \[SupportedOutputBins \<String\[\]\>\]: 
    \[SupportedPagesPerSheet \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedPresentationDirections \<String\[\]\>\]: 
    \[SupportedPrintQualities \<String\[\]\>\]: 
    \[SupportsFitPdfToPage \<Boolean?\>\]: 
    \[TopMargins \<Int32\[\]\>\]: 
  \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ColorMode \<String\>\]: printColorMode
    \[ContentType \<String\>\]: 
    \[CopiesPerJob \<Int32?\>\]: 
    \[DocumentMimeType \<String\>\]: 
    \[Dpi \<Int32?\>\]: 
    \[DuplexConfiguration \<String\>\]: printDuplexConfiguration
    \[DuplexMode \<String\>\]: printDuplexMode
    \[Finishings \<String\[\]\>\]: 
    \[FitPdfToPage \<Boolean?\>\]: 
    \[MediaColor \<String\>\]: 
    \[MediaSize \<String\>\]: 
    \[MediaType \<String\>\]: 
    \[MultipageLayout \<String\>\]: printMultipageLayout
    \[Orientation \<String\>\]: printOrientation
    \[OutputBin \<String\>\]: 
    \[PagesPerSheet \<Int32?\>\]: 
    \[PdfFitToPage \<Boolean?\>\]: 
    \[PresentationDirection \<String\>\]: printPresentationDirection
    \[PrintColorConfiguration \<String\>\]: printColorConfiguration
    \[PrintQuality \<String\>\]: printQuality
    \[Quality \<String\>\]: printQuality
    \[Scaling \<String\>\]: printScaling
  \[DisplayName \<String\>\]: 
  \[IsAcceptingJobs \<Boolean?\>\]: 
  \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Configuration \<IMicrosoftGraphPrintJobConfiguration\>\]: printJobConfiguration
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Collate \<Boolean?\>\]: 
      \[ColorMode \<String\>\]: printColorMode
      \[Copies \<Int32?\>\]: 
      \[Dpi \<Int32?\>\]: 
      \[DuplexMode \<String\>\]: printDuplexMode
      \[FeedOrientation \<String\>\]: printerFeedOrientation
      \[Finishings \<String\[\]\>\]: 
      \[FitPdfToPage \<Boolean?\>\]: 
      \[InputBin \<String\>\]: 
      \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Bottom \<Int32?\>\]: 
        \[Left \<Int32?\>\]: 
        \[Right \<Int32?\>\]: 
        \[Top \<Int32?\>\]: 
      \[MediaSize \<String\>\]: 
      \[MediaType \<String\>\]: 
      \[MultipageLayout \<String\>\]: printMultipageLayout
      \[Orientation \<String\>\]: printOrientation
      \[OutputBin \<String\>\]: 
      \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
      \[PagesPerSheet \<Int32?\>\]: 
      \[Quality \<String\>\]: printQuality
      \[Scaling \<String\>\]: printScaling
    \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
      \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Documents \<IMicrosoftGraphPrintDocument\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Configuration \<IMicrosoftGraphPrinterDocumentConfiguration\>\]: printerDocumentConfiguration
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Collate \<Boolean?\>\]: 
        \[ColorMode \<String\>\]: printColorMode
        \[Copies \<Int32?\>\]: 
        \[Dpi \<Int32?\>\]: 
        \[DuplexMode \<String\>\]: printDuplexMode
        \[FeedDirection \<String\>\]: printerFeedDirection
        \[FeedOrientation \<String\>\]: printerFeedOrientation
        \[Finishings \<String\[\]\>\]: 
        \[FitPdfToPage \<Boolean?\>\]: 
        \[InputBin \<String\>\]: 
        \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[MediaSize \<String\>\]: 
        \[MediaType \<String\>\]: 
        \[MultipageLayout \<String\>\]: printMultipageLayout
        \[Orientation \<String\>\]: printOrientation
        \[OutputBin \<String\>\]: 
        \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
        \[PagesPerSheet \<Int32?\>\]: 
        \[Quality \<String\>\]: printQuality
        \[Scaling \<String\>\]: printScaling
      \[ContentType \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[Size \<Int64?\>\]: 
    \[IsFetchable \<Boolean?\>\]: 
    \[RedirectedFrom \<String\>\]: 
    \[RedirectedTo \<String\>\]: 
    \[Status \<IMicrosoftGraphPrintJobStatus\>\]: printJobStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AcquiredByPrinter \<Boolean?\>\]: 
      \[Description \<String\>\]: 
      \[Details \<String\[\]\>\]: 
      \[IsAcquiredByPrinter \<Boolean?\>\]: 
      \[ProcessingState \<String\>\]: printJobProcessingState
      \[ProcessingStateDescription \<String\>\]: 
      \[State \<String\>\]: printJobProcessingState
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
          \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
          \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
          \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
        \[DisplayName \<String\>\]: 
        \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[ParentUrl \<String\>\]: 
      \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Description \<String\>\]: 
        \[State \<String\>\]: printTaskProcessingState
      \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[Event \<String\>\]: printEvent
  \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AltitudeInMeters \<Int32?\>\]: 
    \[Building \<String\>\]: 
    \[City \<String\>\]: 
    \[CountryOrRegion \<String\>\]: 
    \[FloorDescription \<String\>\]: 
    \[FloorNumber \<Int32?\>\]: 
    \[Latitude \<Single?\>\]: 
    \[Longitude \<Single?\>\]: 
    \[Organization \<String\[\]\>\]: 
    \[PostalCode \<String\>\]: 
    \[RoomDescription \<String\>\]: 
    \[RoomNumber \<Int32?\>\]: 
    \[Site \<String\>\]: 
    \[StateOrProvince \<String\>\]: 
    \[StreetAddress \<String\>\]: 
    \[Subdivision \<String\[\]\>\]: 
    \[Subunit \<String\[\]\>\]: 
  \[Manufacturer \<String\>\]: 
  \[Model \<String\>\]: 
  \[Name \<String\>\]: 
  \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[Details \<String\[\]\>\]: 
    \[ProcessingState \<String\>\]: printerProcessingState
    \[ProcessingStateDescription \<String\>\]: 
    \[ProcessingStateReasons \<String\[\]\>\]: 
    \[State \<String\>\]: printerProcessingState
  \[Id \<String\>\]: Read-only.
  \[AcceptingJobs \<Boolean?\>\]: 
  \[Connectors \<IMicrosoftGraphPrintConnector\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[AppVersion \<String\>\]: 
    \[DeviceHealth \<IMicrosoftGraphDeviceHealth\>\]: deviceHealth
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[LastConnectionTime \<DateTime?\>\]: 
    \[DisplayName \<String\>\]: 
    \[FullyQualifiedDomainName \<String\>\]: 
    \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[Name \<String\>\]: 
    \[OperatingSystem \<String\>\]: 
    \[RegisteredDateTime \<DateTime?\>\]: 
  \[HasPhysicalDevice \<Boolean?\>\]: 
  \[IsShared \<Boolean?\>\]: 
  \[RegisteredDateTime \<DateTime?\>\]: 
  \[Share \<IMicrosoftGraphPrinterShare\>\]: printerShare
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[DisplayName \<String\>\]: 
    \[IsAcceptingJobs \<Boolean?\>\]: 
    \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[Manufacturer \<String\>\]: 
    \[Model \<String\>\]: 
    \[Name \<String\>\]: 
    \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[Id \<String\>\]: Read-only.
    \[AllowAllUsers \<Boolean?\>\]: 
    \[AllowedGroups \<IMicrosoftGraphPrintIdentity\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: 
    \[AllowedUsers \<IMicrosoftGraphPrintUserIdentity\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[DisplayName \<String\>\]: 
      \[IPAddress \<String\>\]: 
      \[UserPrincipalName \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Printer \<IMicrosoftGraphPrinter\>\]: printer
  \[Shares \<IMicrosoftGraphPrinterShare\[\]\>\]: 
  \[TaskTriggers \<IMicrosoftGraphPrintTaskTrigger\[\]\>\]: 

CAPABILITIES \<IMicrosoftGraphPrinterCapabilities\>: printerCapabilities
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[BottomMargins \<Int32\[\]\>\]: 
  \[Collation \<Boolean?\>\]: 
  \[ColorModes \<String\[\]\>\]: 
  \[ContentTypes \<String\[\]\>\]: 
  \[CopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[End \<Int64?\>\]: 
    \[Maximum \<Int64?\>\]: 
    \[Minimum \<Int64?\>\]: 
    \[Start \<Int64?\>\]: 
  \[Dpis \<Int32\[\]\>\]: 
  \[DuplexModes \<String\[\]\>\]: 
  \[FeedDirections \<String\[\]\>\]: 
  \[FeedOrientations \<String\[\]\>\]: 
  \[Finishings \<String\[\]\>\]: 
  \[InputBins \<String\[\]\>\]: 
  \[IsColorPrintingSupported \<Boolean?\>\]: 
  \[IsPageRangeSupported \<Boolean?\>\]: 
  \[LeftMargins \<Int32\[\]\>\]: 
  \[MediaColors \<String\[\]\>\]: 
  \[MediaSizes \<String\[\]\>\]: 
  \[MediaTypes \<String\[\]\>\]: 
  \[MultipageLayouts \<String\[\]\>\]: 
  \[Orientations \<String\[\]\>\]: 
  \[OutputBins \<String\[\]\>\]: 
  \[PagesPerSheet \<Int32\[\]\>\]: 
  \[Qualities \<String\[\]\>\]: 
  \[RightMargins \<Int32\[\]\>\]: 
  \[Scalings \<String\[\]\>\]: 
  \[SupportedColorConfigurations \<String\[\]\>\]: 
  \[SupportedCopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
  \[SupportedDocumentMimeTypes \<String\[\]\>\]: 
  \[SupportedDuplexConfigurations \<String\[\]\>\]: 
  \[SupportedFinishings \<String\[\]\>\]: 
  \[SupportedMediaColors \<String\[\]\>\]: 
  \[SupportedMediaSizes \<String\[\]\>\]: 
  \[SupportedMediaTypes \<String\[\]\>\]: 
  \[SupportedOrientations \<String\[\]\>\]: 
  \[SupportedOutputBins \<String\[\]\>\]: 
  \[SupportedPagesPerSheet \<IMicrosoftGraphIntegerRange\>\]: integerRange
  \[SupportedPresentationDirections \<String\[\]\>\]: 
  \[SupportedPrintQualities \<String\[\]\>\]: 
  \[SupportsFitPdfToPage \<Boolean?\>\]: 
  \[TopMargins \<Int32\[\]\>\]: 

CONNECTORS \<IMicrosoftGraphPrintConnector\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[AppVersion \<String\>\]: 
  \[DeviceHealth \<IMicrosoftGraphDeviceHealth\>\]: deviceHealth
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[LastConnectionTime \<DateTime?\>\]: 
  \[DisplayName \<String\>\]: 
  \[FullyQualifiedDomainName \<String\>\]: 
  \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AltitudeInMeters \<Int32?\>\]: 
    \[Building \<String\>\]: 
    \[City \<String\>\]: 
    \[CountryOrRegion \<String\>\]: 
    \[FloorDescription \<String\>\]: 
    \[FloorNumber \<Int32?\>\]: 
    \[Latitude \<Single?\>\]: 
    \[Longitude \<Single?\>\]: 
    \[Organization \<String\[\]\>\]: 
    \[PostalCode \<String\>\]: 
    \[RoomDescription \<String\>\]: 
    \[RoomNumber \<Int32?\>\]: 
    \[Site \<String\>\]: 
    \[StateOrProvince \<String\>\]: 
    \[StreetAddress \<String\>\]: 
    \[Subdivision \<String\[\]\>\]: 
    \[Subunit \<String\[\]\>\]: 
  \[Name \<String\>\]: 
  \[OperatingSystem \<String\>\]: 
  \[RegisteredDateTime \<DateTime?\>\]: 

DEFAULTS \<IMicrosoftGraphPrinterDefaults\>: printerDefaults
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[ColorMode \<String\>\]: printColorMode
  \[ContentType \<String\>\]: 
  \[CopiesPerJob \<Int32?\>\]: 
  \[DocumentMimeType \<String\>\]: 
  \[Dpi \<Int32?\>\]: 
  \[DuplexConfiguration \<String\>\]: printDuplexConfiguration
  \[DuplexMode \<String\>\]: printDuplexMode
  \[Finishings \<String\[\]\>\]: 
  \[FitPdfToPage \<Boolean?\>\]: 
  \[MediaColor \<String\>\]: 
  \[MediaSize \<String\>\]: 
  \[MediaType \<String\>\]: 
  \[MultipageLayout \<String\>\]: printMultipageLayout
  \[Orientation \<String\>\]: printOrientation
  \[OutputBin \<String\>\]: 
  \[PagesPerSheet \<Int32?\>\]: 
  \[PdfFitToPage \<Boolean?\>\]: 
  \[PresentationDirection \<String\>\]: printPresentationDirection
  \[PrintColorConfiguration \<String\>\]: printColorConfiguration
  \[PrintQuality \<String\>\]: printQuality
  \[Quality \<String\>\]: printQuality
  \[Scaling \<String\>\]: printScaling

INPUTOBJECT \<IDevicesCloudPrintIdentity\>: Identity Parameter
  \[GroupId \<String\>\]: 
  \[PeriodEnd \<DateTime?\>\]: 
  \[PeriodStart \<DateTime?\>\]: 
  \[PrintConnectorId \<String\>\]: key: id of printConnector
  \[PrintIdentityId \<String\>\]: key: id of printIdentity
  \[PrintOperationId \<String\>\]: key: id of printOperation
  \[PrintServiceEndpointId \<String\>\]: key: id of printServiceEndpoint
  \[PrintServiceId \<String\>\]: key: id of printService
  \[PrintTaskDefinitionId \<String\>\]: key: id of printTaskDefinition
  \[PrintTaskId \<String\>\]: key: id of printTask
  \[PrintTaskTriggerId \<String\>\]: key: id of printTaskTrigger
  \[PrintUserIdentityId \<String\>\]: key: id of printUserIdentity
  \[PrinterId \<String\>\]: key: id of printer
  \[PrinterId1 \<String\>\]: 
  \[PrinterShareId \<String\>\]: key: id of printerShare
  \[ReportRootId \<String\>\]: key: id of reportRoot
  \[TimeSpanInMinutes \<Int32?\>\]: 
  \[TopListsSize \<Int32?\>\]: 
  \[UserId \<String\>\]: 

JOBS \<IMicrosoftGraphPrintJob\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[Configuration \<IMicrosoftGraphPrintJobConfiguration\>\]: printJobConfiguration
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Collate \<Boolean?\>\]: 
    \[ColorMode \<String\>\]: printColorMode
    \[Copies \<Int32?\>\]: 
    \[Dpi \<Int32?\>\]: 
    \[DuplexMode \<String\>\]: printDuplexMode
    \[FeedOrientation \<String\>\]: printerFeedOrientation
    \[Finishings \<String\[\]\>\]: 
    \[FitPdfToPage \<Boolean?\>\]: 
    \[InputBin \<String\>\]: 
    \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Bottom \<Int32?\>\]: 
      \[Left \<Int32?\>\]: 
      \[Right \<Int32?\>\]: 
      \[Top \<Int32?\>\]: 
    \[MediaSize \<String\>\]: 
    \[MediaType \<String\>\]: 
    \[MultipageLayout \<String\>\]: printMultipageLayout
    \[Orientation \<String\>\]: printOrientation
    \[OutputBin \<String\>\]: 
    \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
      \[End \<Int64?\>\]: 
      \[Maximum \<Int64?\>\]: 
      \[Minimum \<Int64?\>\]: 
      \[Start \<Int64?\>\]: 
    \[PagesPerSheet \<Int32?\>\]: 
    \[Quality \<String\>\]: printQuality
    \[Scaling \<String\>\]: printScaling
  \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Documents \<IMicrosoftGraphPrintDocument\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Configuration \<IMicrosoftGraphPrinterDocumentConfiguration\>\]: printerDocumentConfiguration
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Collate \<Boolean?\>\]: 
      \[ColorMode \<String\>\]: printColorMode
      \[Copies \<Int32?\>\]: 
      \[Dpi \<Int32?\>\]: 
      \[DuplexMode \<String\>\]: printDuplexMode
      \[FeedDirection \<String\>\]: printerFeedDirection
      \[FeedOrientation \<String\>\]: printerFeedOrientation
      \[Finishings \<String\[\]\>\]: 
      \[FitPdfToPage \<Boolean?\>\]: 
      \[InputBin \<String\>\]: 
      \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
      \[MediaSize \<String\>\]: 
      \[MediaType \<String\>\]: 
      \[MultipageLayout \<String\>\]: printMultipageLayout
      \[Orientation \<String\>\]: printOrientation
      \[OutputBin \<String\>\]: 
      \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
      \[PagesPerSheet \<Int32?\>\]: 
      \[Quality \<String\>\]: printQuality
      \[Scaling \<String\>\]: printScaling
    \[ContentType \<String\>\]: 
    \[DisplayName \<String\>\]: 
    \[Size \<Int64?\>\]: 
  \[IsFetchable \<Boolean?\>\]: 
  \[RedirectedFrom \<String\>\]: 
  \[RedirectedTo \<String\>\]: 
  \[Status \<IMicrosoftGraphPrintJobStatus\>\]: printJobStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AcquiredByPrinter \<Boolean?\>\]: 
    \[Description \<String\>\]: 
    \[Details \<String\[\]\>\]: 
    \[IsAcquiredByPrinter \<Boolean?\>\]: 
    \[ProcessingState \<String\>\]: printJobProcessingState
    \[ProcessingStateDescription \<String\>\]: 
    \[State \<String\>\]: printJobProcessingState
  \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
        \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
        \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
        \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
      \[DisplayName \<String\>\]: 
      \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
    \[ParentUrl \<String\>\]: 
    \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Description \<String\>\]: 
      \[State \<String\>\]: printTaskProcessingState
    \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
      \[Event \<String\>\]: printEvent

LOCATION \<IMicrosoftGraphPrinterLocation\>: printerLocation
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[AltitudeInMeters \<Int32?\>\]: 
  \[Building \<String\>\]: 
  \[City \<String\>\]: 
  \[CountryOrRegion \<String\>\]: 
  \[FloorDescription \<String\>\]: 
  \[FloorNumber \<Int32?\>\]: 
  \[Latitude \<Single?\>\]: 
  \[Longitude \<Single?\>\]: 
  \[Organization \<String\[\]\>\]: 
  \[PostalCode \<String\>\]: 
  \[RoomDescription \<String\>\]: 
  \[RoomNumber \<Int32?\>\]: 
  \[Site \<String\>\]: 
  \[StateOrProvince \<String\>\]: 
  \[StreetAddress \<String\>\]: 
  \[Subdivision \<String\[\]\>\]: 
  \[Subunit \<String\[\]\>\]: 

SHARE \<IMicrosoftGraphPrinterShare\>: printerShare
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[BottomMargins \<Int32\[\]\>\]: 
    \[Collation \<Boolean?\>\]: 
    \[ColorModes \<String\[\]\>\]: 
    \[ContentTypes \<String\[\]\>\]: 
    \[CopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[End \<Int64?\>\]: 
      \[Maximum \<Int64?\>\]: 
      \[Minimum \<Int64?\>\]: 
      \[Start \<Int64?\>\]: 
    \[Dpis \<Int32\[\]\>\]: 
    \[DuplexModes \<String\[\]\>\]: 
    \[FeedDirections \<String\[\]\>\]: 
    \[FeedOrientations \<String\[\]\>\]: 
    \[Finishings \<String\[\]\>\]: 
    \[InputBins \<String\[\]\>\]: 
    \[IsColorPrintingSupported \<Boolean?\>\]: 
    \[IsPageRangeSupported \<Boolean?\>\]: 
    \[LeftMargins \<Int32\[\]\>\]: 
    \[MediaColors \<String\[\]\>\]: 
    \[MediaSizes \<String\[\]\>\]: 
    \[MediaTypes \<String\[\]\>\]: 
    \[MultipageLayouts \<String\[\]\>\]: 
    \[Orientations \<String\[\]\>\]: 
    \[OutputBins \<String\[\]\>\]: 
    \[PagesPerSheet \<Int32\[\]\>\]: 
    \[Qualities \<String\[\]\>\]: 
    \[RightMargins \<Int32\[\]\>\]: 
    \[Scalings \<String\[\]\>\]: 
    \[SupportedColorConfigurations \<String\[\]\>\]: 
    \[SupportedCopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedDocumentMimeTypes \<String\[\]\>\]: 
    \[SupportedDuplexConfigurations \<String\[\]\>\]: 
    \[SupportedFinishings \<String\[\]\>\]: 
    \[SupportedMediaColors \<String\[\]\>\]: 
    \[SupportedMediaSizes \<String\[\]\>\]: 
    \[SupportedMediaTypes \<String\[\]\>\]: 
    \[SupportedOrientations \<String\[\]\>\]: 
    \[SupportedOutputBins \<String\[\]\>\]: 
    \[SupportedPagesPerSheet \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedPresentationDirections \<String\[\]\>\]: 
    \[SupportedPrintQualities \<String\[\]\>\]: 
    \[SupportsFitPdfToPage \<Boolean?\>\]: 
    \[TopMargins \<Int32\[\]\>\]: 
  \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ColorMode \<String\>\]: printColorMode
    \[ContentType \<String\>\]: 
    \[CopiesPerJob \<Int32?\>\]: 
    \[DocumentMimeType \<String\>\]: 
    \[Dpi \<Int32?\>\]: 
    \[DuplexConfiguration \<String\>\]: printDuplexConfiguration
    \[DuplexMode \<String\>\]: printDuplexMode
    \[Finishings \<String\[\]\>\]: 
    \[FitPdfToPage \<Boolean?\>\]: 
    \[MediaColor \<String\>\]: 
    \[MediaSize \<String\>\]: 
    \[MediaType \<String\>\]: 
    \[MultipageLayout \<String\>\]: printMultipageLayout
    \[Orientation \<String\>\]: printOrientation
    \[OutputBin \<String\>\]: 
    \[PagesPerSheet \<Int32?\>\]: 
    \[PdfFitToPage \<Boolean?\>\]: 
    \[PresentationDirection \<String\>\]: printPresentationDirection
    \[PrintColorConfiguration \<String\>\]: printColorConfiguration
    \[PrintQuality \<String\>\]: printQuality
    \[Quality \<String\>\]: printQuality
    \[Scaling \<String\>\]: printScaling
  \[DisplayName \<String\>\]: 
  \[IsAcceptingJobs \<Boolean?\>\]: 
  \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Configuration \<IMicrosoftGraphPrintJobConfiguration\>\]: printJobConfiguration
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Collate \<Boolean?\>\]: 
      \[ColorMode \<String\>\]: printColorMode
      \[Copies \<Int32?\>\]: 
      \[Dpi \<Int32?\>\]: 
      \[DuplexMode \<String\>\]: printDuplexMode
      \[FeedOrientation \<String\>\]: printerFeedOrientation
      \[Finishings \<String\[\]\>\]: 
      \[FitPdfToPage \<Boolean?\>\]: 
      \[InputBin \<String\>\]: 
      \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Bottom \<Int32?\>\]: 
        \[Left \<Int32?\>\]: 
        \[Right \<Int32?\>\]: 
        \[Top \<Int32?\>\]: 
      \[MediaSize \<String\>\]: 
      \[MediaType \<String\>\]: 
      \[MultipageLayout \<String\>\]: printMultipageLayout
      \[Orientation \<String\>\]: printOrientation
      \[OutputBin \<String\>\]: 
      \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
      \[PagesPerSheet \<Int32?\>\]: 
      \[Quality \<String\>\]: printQuality
      \[Scaling \<String\>\]: printScaling
    \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
      \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Documents \<IMicrosoftGraphPrintDocument\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Configuration \<IMicrosoftGraphPrinterDocumentConfiguration\>\]: printerDocumentConfiguration
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Collate \<Boolean?\>\]: 
        \[ColorMode \<String\>\]: printColorMode
        \[Copies \<Int32?\>\]: 
        \[Dpi \<Int32?\>\]: 
        \[DuplexMode \<String\>\]: printDuplexMode
        \[FeedDirection \<String\>\]: printerFeedDirection
        \[FeedOrientation \<String\>\]: printerFeedOrientation
        \[Finishings \<String\[\]\>\]: 
        \[FitPdfToPage \<Boolean?\>\]: 
        \[InputBin \<String\>\]: 
        \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[MediaSize \<String\>\]: 
        \[MediaType \<String\>\]: 
        \[MultipageLayout \<String\>\]: printMultipageLayout
        \[Orientation \<String\>\]: printOrientation
        \[OutputBin \<String\>\]: 
        \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
        \[PagesPerSheet \<Int32?\>\]: 
        \[Quality \<String\>\]: printQuality
        \[Scaling \<String\>\]: printScaling
      \[ContentType \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[Size \<Int64?\>\]: 
    \[IsFetchable \<Boolean?\>\]: 
    \[RedirectedFrom \<String\>\]: 
    \[RedirectedTo \<String\>\]: 
    \[Status \<IMicrosoftGraphPrintJobStatus\>\]: printJobStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AcquiredByPrinter \<Boolean?\>\]: 
      \[Description \<String\>\]: 
      \[Details \<String\[\]\>\]: 
      \[IsAcquiredByPrinter \<Boolean?\>\]: 
      \[ProcessingState \<String\>\]: printJobProcessingState
      \[ProcessingStateDescription \<String\>\]: 
      \[State \<String\>\]: printJobProcessingState
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
          \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
          \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
          \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
        \[DisplayName \<String\>\]: 
        \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[ParentUrl \<String\>\]: 
      \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Description \<String\>\]: 
        \[State \<String\>\]: printTaskProcessingState
      \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[Event \<String\>\]: printEvent
  \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AltitudeInMeters \<Int32?\>\]: 
    \[Building \<String\>\]: 
    \[City \<String\>\]: 
    \[CountryOrRegion \<String\>\]: 
    \[FloorDescription \<String\>\]: 
    \[FloorNumber \<Int32?\>\]: 
    \[Latitude \<Single?\>\]: 
    \[Longitude \<Single?\>\]: 
    \[Organization \<String\[\]\>\]: 
    \[PostalCode \<String\>\]: 
    \[RoomDescription \<String\>\]: 
    \[RoomNumber \<Int32?\>\]: 
    \[Site \<String\>\]: 
    \[StateOrProvince \<String\>\]: 
    \[StreetAddress \<String\>\]: 
    \[Subdivision \<String\[\]\>\]: 
    \[Subunit \<String\[\]\>\]: 
  \[Manufacturer \<String\>\]: 
  \[Model \<String\>\]: 
  \[Name \<String\>\]: 
  \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[Details \<String\[\]\>\]: 
    \[ProcessingState \<String\>\]: printerProcessingState
    \[ProcessingStateDescription \<String\>\]: 
    \[ProcessingStateReasons \<String\[\]\>\]: 
    \[State \<String\>\]: printerProcessingState
  \[Id \<String\>\]: Read-only.
  \[AllowAllUsers \<Boolean?\>\]: 
  \[AllowedGroups \<IMicrosoftGraphPrintIdentity\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
  \[AllowedUsers \<IMicrosoftGraphPrintUserIdentity\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[IPAddress \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Printer \<IMicrosoftGraphPrinter\>\]: printer
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[DisplayName \<String\>\]: 
    \[IsAcceptingJobs \<Boolean?\>\]: 
    \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[Manufacturer \<String\>\]: 
    \[Model \<String\>\]: 
    \[Name \<String\>\]: 
    \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[Id \<String\>\]: Read-only.
    \[AcceptingJobs \<Boolean?\>\]: 
    \[Connectors \<IMicrosoftGraphPrintConnector\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AppVersion \<String\>\]: 
      \[DeviceHealth \<IMicrosoftGraphDeviceHealth\>\]: deviceHealth
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[LastConnectionTime \<DateTime?\>\]: 
      \[DisplayName \<String\>\]: 
      \[FullyQualifiedDomainName \<String\>\]: 
      \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
      \[Name \<String\>\]: 
      \[OperatingSystem \<String\>\]: 
      \[RegisteredDateTime \<DateTime?\>\]: 
    \[HasPhysicalDevice \<Boolean?\>\]: 
    \[IsShared \<Boolean?\>\]: 
    \[RegisteredDateTime \<DateTime?\>\]: 
    \[Share \<IMicrosoftGraphPrinterShare\>\]: printerShare
    \[Shares \<IMicrosoftGraphPrinterShare\[\]\>\]: 
    \[TaskTriggers \<IMicrosoftGraphPrintTaskTrigger\[\]\>\]: 

SHARES \<IMicrosoftGraphPrinterShare\[\]\>: .
  \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[BottomMargins \<Int32\[\]\>\]: 
    \[Collation \<Boolean?\>\]: 
    \[ColorModes \<String\[\]\>\]: 
    \[ContentTypes \<String\[\]\>\]: 
    \[CopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[End \<Int64?\>\]: 
      \[Maximum \<Int64?\>\]: 
      \[Minimum \<Int64?\>\]: 
      \[Start \<Int64?\>\]: 
    \[Dpis \<Int32\[\]\>\]: 
    \[DuplexModes \<String\[\]\>\]: 
    \[FeedDirections \<String\[\]\>\]: 
    \[FeedOrientations \<String\[\]\>\]: 
    \[Finishings \<String\[\]\>\]: 
    \[InputBins \<String\[\]\>\]: 
    \[IsColorPrintingSupported \<Boolean?\>\]: 
    \[IsPageRangeSupported \<Boolean?\>\]: 
    \[LeftMargins \<Int32\[\]\>\]: 
    \[MediaColors \<String\[\]\>\]: 
    \[MediaSizes \<String\[\]\>\]: 
    \[MediaTypes \<String\[\]\>\]: 
    \[MultipageLayouts \<String\[\]\>\]: 
    \[Orientations \<String\[\]\>\]: 
    \[OutputBins \<String\[\]\>\]: 
    \[PagesPerSheet \<Int32\[\]\>\]: 
    \[Qualities \<String\[\]\>\]: 
    \[RightMargins \<Int32\[\]\>\]: 
    \[Scalings \<String\[\]\>\]: 
    \[SupportedColorConfigurations \<String\[\]\>\]: 
    \[SupportedCopiesPerJob \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedDocumentMimeTypes \<String\[\]\>\]: 
    \[SupportedDuplexConfigurations \<String\[\]\>\]: 
    \[SupportedFinishings \<String\[\]\>\]: 
    \[SupportedMediaColors \<String\[\]\>\]: 
    \[SupportedMediaSizes \<String\[\]\>\]: 
    \[SupportedMediaTypes \<String\[\]\>\]: 
    \[SupportedOrientations \<String\[\]\>\]: 
    \[SupportedOutputBins \<String\[\]\>\]: 
    \[SupportedPagesPerSheet \<IMicrosoftGraphIntegerRange\>\]: integerRange
    \[SupportedPresentationDirections \<String\[\]\>\]: 
    \[SupportedPrintQualities \<String\[\]\>\]: 
    \[SupportsFitPdfToPage \<Boolean?\>\]: 
    \[TopMargins \<Int32\[\]\>\]: 
  \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[ColorMode \<String\>\]: printColorMode
    \[ContentType \<String\>\]: 
    \[CopiesPerJob \<Int32?\>\]: 
    \[DocumentMimeType \<String\>\]: 
    \[Dpi \<Int32?\>\]: 
    \[DuplexConfiguration \<String\>\]: printDuplexConfiguration
    \[DuplexMode \<String\>\]: printDuplexMode
    \[Finishings \<String\[\]\>\]: 
    \[FitPdfToPage \<Boolean?\>\]: 
    \[MediaColor \<String\>\]: 
    \[MediaSize \<String\>\]: 
    \[MediaType \<String\>\]: 
    \[MultipageLayout \<String\>\]: printMultipageLayout
    \[Orientation \<String\>\]: printOrientation
    \[OutputBin \<String\>\]: 
    \[PagesPerSheet \<Int32?\>\]: 
    \[PdfFitToPage \<Boolean?\>\]: 
    \[PresentationDirection \<String\>\]: printPresentationDirection
    \[PrintColorConfiguration \<String\>\]: printColorConfiguration
    \[PrintQuality \<String\>\]: printQuality
    \[Quality \<String\>\]: printQuality
    \[Scaling \<String\>\]: printScaling
  \[DisplayName \<String\>\]: 
  \[IsAcceptingJobs \<Boolean?\>\]: 
  \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[Configuration \<IMicrosoftGraphPrintJobConfiguration\>\]: printJobConfiguration
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[Collate \<Boolean?\>\]: 
      \[ColorMode \<String\>\]: printColorMode
      \[Copies \<Int32?\>\]: 
      \[Dpi \<Int32?\>\]: 
      \[DuplexMode \<String\>\]: printDuplexMode
      \[FeedOrientation \<String\>\]: printerFeedOrientation
      \[Finishings \<String\[\]\>\]: 
      \[FitPdfToPage \<Boolean?\>\]: 
      \[InputBin \<String\>\]: 
      \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Bottom \<Int32?\>\]: 
        \[Left \<Int32?\>\]: 
        \[Right \<Int32?\>\]: 
        \[Top \<Int32?\>\]: 
      \[MediaSize \<String\>\]: 
      \[MediaType \<String\>\]: 
      \[MultipageLayout \<String\>\]: printMultipageLayout
      \[Orientation \<String\>\]: printOrientation
      \[OutputBin \<String\>\]: 
      \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
      \[PagesPerSheet \<Int32?\>\]: 
      \[Quality \<String\>\]: printQuality
      \[Scaling \<String\>\]: printScaling
    \[CreatedBy \<IMicrosoftGraphUserIdentity\>\]: userIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
      \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
    \[CreatedDateTime \<DateTime?\>\]: 
    \[Documents \<IMicrosoftGraphPrintDocument\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Configuration \<IMicrosoftGraphPrinterDocumentConfiguration\>\]: printerDocumentConfiguration
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Collate \<Boolean?\>\]: 
        \[ColorMode \<String\>\]: printColorMode
        \[Copies \<Int32?\>\]: 
        \[Dpi \<Int32?\>\]: 
        \[DuplexMode \<String\>\]: printDuplexMode
        \[FeedDirection \<String\>\]: printerFeedDirection
        \[FeedOrientation \<String\>\]: printerFeedOrientation
        \[Finishings \<String\[\]\>\]: 
        \[FitPdfToPage \<Boolean?\>\]: 
        \[InputBin \<String\>\]: 
        \[Margin \<IMicrosoftGraphPrintMargin\>\]: printMargin
        \[MediaSize \<String\>\]: 
        \[MediaType \<String\>\]: 
        \[MultipageLayout \<String\>\]: printMultipageLayout
        \[Orientation \<String\>\]: printOrientation
        \[OutputBin \<String\>\]: 
        \[PageRanges \<IMicrosoftGraphIntegerRange\[\]\>\]: 
        \[PagesPerSheet \<Int32?\>\]: 
        \[Quality \<String\>\]: printQuality
        \[Scaling \<String\>\]: printScaling
      \[ContentType \<String\>\]: 
      \[DisplayName \<String\>\]: 
      \[Size \<Int64?\>\]: 
    \[IsFetchable \<Boolean?\>\]: 
    \[RedirectedFrom \<String\>\]: 
    \[RedirectedTo \<String\>\]: 
    \[Status \<IMicrosoftGraphPrintJobStatus\>\]: printJobStatus
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AcquiredByPrinter \<Boolean?\>\]: 
      \[Description \<String\>\]: 
      \[Details \<String\[\]\>\]: 
      \[IsAcquiredByPrinter \<Boolean?\>\]: 
      \[ProcessingState \<String\>\]: printJobProcessingState
      \[ProcessingStateDescription \<String\>\]: 
      \[State \<String\>\]: printJobProcessingState
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
          \[(Any) \<Object\>\]: This indicates any property can be added to this object.
          \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
          \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
          \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
          \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
        \[DisplayName \<String\>\]: 
        \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[ParentUrl \<String\>\]: 
      \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Description \<String\>\]: 
        \[State \<String\>\]: printTaskProcessingState
      \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Id \<String\>\]: Read-only.
        \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
        \[Event \<String\>\]: printEvent
  \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[AltitudeInMeters \<Int32?\>\]: 
    \[Building \<String\>\]: 
    \[City \<String\>\]: 
    \[CountryOrRegion \<String\>\]: 
    \[FloorDescription \<String\>\]: 
    \[FloorNumber \<Int32?\>\]: 
    \[Latitude \<Single?\>\]: 
    \[Longitude \<Single?\>\]: 
    \[Organization \<String\[\]\>\]: 
    \[PostalCode \<String\>\]: 
    \[RoomDescription \<String\>\]: 
    \[RoomNumber \<Int32?\>\]: 
    \[Site \<String\>\]: 
    \[StateOrProvince \<String\>\]: 
    \[StreetAddress \<String\>\]: 
    \[Subdivision \<String\[\]\>\]: 
    \[Subunit \<String\[\]\>\]: 
  \[Manufacturer \<String\>\]: 
  \[Model \<String\>\]: 
  \[Name \<String\>\]: 
  \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Description \<String\>\]: 
    \[Details \<String\[\]\>\]: 
    \[ProcessingState \<String\>\]: printerProcessingState
    \[ProcessingStateDescription \<String\>\]: 
    \[ProcessingStateReasons \<String\[\]\>\]: 
    \[State \<String\>\]: printerProcessingState
  \[Id \<String\>\]: Read-only.
  \[AllowAllUsers \<Boolean?\>\]: 
  \[AllowedGroups \<IMicrosoftGraphPrintIdentity\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
  \[AllowedUsers \<IMicrosoftGraphPrintUserIdentity\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[DisplayName \<String\>\]: 
    \[IPAddress \<String\>\]: 
    \[UserPrincipalName \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[Printer \<IMicrosoftGraphPrinter\>\]: printer
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Capabilities \<IMicrosoftGraphPrinterCapabilities\>\]: printerCapabilities
    \[Defaults \<IMicrosoftGraphPrinterDefaults\>\]: printerDefaults
    \[DisplayName \<String\>\]: 
    \[IsAcceptingJobs \<Boolean?\>\]: 
    \[Jobs \<IMicrosoftGraphPrintJob\[\]\>\]: 
    \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
    \[Manufacturer \<String\>\]: 
    \[Model \<String\>\]: 
    \[Name \<String\>\]: 
    \[Status \<IMicrosoftGraphPrinterStatus\>\]: printerStatus
    \[Id \<String\>\]: Read-only.
    \[AcceptingJobs \<Boolean?\>\]: 
    \[Connectors \<IMicrosoftGraphPrintConnector\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[AppVersion \<String\>\]: 
      \[DeviceHealth \<IMicrosoftGraphDeviceHealth\>\]: deviceHealth
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[LastConnectionTime \<DateTime?\>\]: 
      \[DisplayName \<String\>\]: 
      \[FullyQualifiedDomainName \<String\>\]: 
      \[Location \<IMicrosoftGraphPrinterLocation\>\]: printerLocation
      \[Name \<String\>\]: 
      \[OperatingSystem \<String\>\]: 
      \[RegisteredDateTime \<DateTime?\>\]: 
    \[HasPhysicalDevice \<Boolean?\>\]: 
    \[IsShared \<Boolean?\>\]: 
    \[RegisteredDateTime \<DateTime?\>\]: 
    \[Share \<IMicrosoftGraphPrinterShare\>\]: printerShare
    \[Shares \<IMicrosoftGraphPrinterShare\[\]\>\]: 
    \[TaskTriggers \<IMicrosoftGraphPrintTaskTrigger\[\]\>\]: 

STATUS \<IMicrosoftGraphPrinterStatus\>: printerStatus
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Description \<String\>\]: 
  \[Details \<String\[\]\>\]: 
  \[ProcessingState \<String\>\]: printerProcessingState
  \[ProcessingStateDescription \<String\>\]: 
  \[ProcessingStateReasons \<String\[\]\>\]: 
  \[State \<String\>\]: printerProcessingState

TASKTRIGGERS \<IMicrosoftGraphPrintTaskTrigger\[\]\>: .
  \[Id \<String\>\]: Read-only.
  \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[CreatedBy \<IMicrosoftGraphAppIdentity\>\]: appIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[AppId \<String\>\]: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
      \[DisplayName \<String\>\]: Refers to the Application Name displayed in the Azure Portal.
      \[ServicePrincipalId \<String\>\]: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
      \[ServicePrincipalName \<String\>\]: Refers to the Service Principal Name is the Application name in the tenant.
    \[DisplayName \<String\>\]: 
    \[Tasks \<IMicrosoftGraphPrintTask\[\]\>\]: 
      \[Id \<String\>\]: Read-only.
      \[Definition \<IMicrosoftGraphPrintTaskDefinition\>\]: printTaskDefinition
      \[ParentUrl \<String\>\]: 
      \[Status \<IMicrosoftGraphPrintTaskStatus\>\]: printTaskStatus
        \[(Any) \<Object\>\]: This indicates any property can be added to this object.
        \[Description \<String\>\]: 
        \[State \<String\>\]: printTaskProcessingState
      \[Trigger \<IMicrosoftGraphPrintTaskTrigger\>\]: printTaskTrigger
  \[Event \<String\>\]: printEvent

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprintprinter](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devices.cloudprint/update-mgprintprinter)

