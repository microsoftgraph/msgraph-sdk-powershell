---
external help file:
Module Name: Microsoft.Graph.DeviceManagement.Administration
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.devicemanagement.administration/new-mgdevicemanagementvirtualendpointgalleryimage
schema: 2.0.0
---

# New-MgDeviceManagementVirtualEndpointGalleryImage

## SYNOPSIS
Create new navigation property to galleryImages for deviceManagement

## SYNTAX

### CreateExpanded (Default)
```
New-MgDeviceManagementVirtualEndpointGalleryImage [-AdditionalProperties <Hashtable>] [-DisplayName <String>]
 [-EndDate <DateTime>] [-ExpirationDate <DateTime>] [-Id <String>] [-Offer <String>]
 [-OfferDisplayName <String>] [-Publisher <String>] [-RecommendedSku <String>] [-SizeInGb <Int32>]
 [-Sku <String>] [-SkuDisplayName <String>] [-StartDate <DateTime>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgDeviceManagementVirtualEndpointGalleryImage -BodyParameter <IMicrosoftGraphCloudPcGalleryImage>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to galleryImages for deviceManagement

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
cloudPcGalleryImage
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcGalleryImage
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The official display name of the gallery image.
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

### -EndDate
The date in which this image is no longer within long-term support.
The Cloud PC will continue to provide short-term support.
Read-only.

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

### -ExpirationDate
The date when the image is no longer available.
Read-only.

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

### -Offer
The offer name of the gallery image.
This value will be passed to Azure to get the image resource.
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

### -OfferDisplayName
The official display offer name of the gallery image.
For example, Windows 10 Enterprise + OS Optimizations.
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

### -Publisher
The publisher name of the gallery image.
This value will be passed to Azure to get the image resource.
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

### -RecommendedSku
Recommended Cloud PC SKU for this gallery image.
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

### -SizeInGb
The size of this image in gigabytes.
Read-only.

```yaml
Type: System.Int32
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sku
The SKU name of the gallery image.
This value will be passed to Azure to get the image resource.
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

### -SkuDisplayName
The official display stock keeping unit (SKU) name of this gallery image.
For example, 2004.
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

### -StartDate
The date when the image becomes available.
Read-only.

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

### -Status
cloudPcGalleryImageStatus

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcGalleryImage

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphCloudPcGalleryImage

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphCloudPcGalleryImage>: cloudPcGalleryImage
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The official display name of the gallery image. Read-only.
  - `[EndDate <DateTime?>]`: The date in which this image is no longer within long-term support. The Cloud PC will continue to provide short-term support. Read-only.
  - `[ExpirationDate <DateTime?>]`: The date when the image is no longer available. Read-only.
  - `[Offer <String>]`: The offer name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.
  - `[OfferDisplayName <String>]`: The official display offer name of the gallery image. For example, Windows 10 Enterprise + OS Optimizations. Read-only.
  - `[Publisher <String>]`: The publisher name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.
  - `[RecommendedSku <String>]`: Recommended Cloud PC SKU for this gallery image. Read-only.
  - `[SizeInGb <Int32?>]`: The size of this image in gigabytes. Read-only.
  - `[Sku <String>]`: The SKU name of the gallery image. This value will be passed to Azure to get the image resource. Read-only.
  - `[SkuDisplayName <String>]`: The official display stock keeping unit (SKU) name of this gallery image. For example, 2004. Read-only.
  - `[StartDate <DateTime?>]`: The date when the image becomes available. Read-only.
  - `[Status <String>]`: cloudPcGalleryImageStatus

## RELATED LINKS

