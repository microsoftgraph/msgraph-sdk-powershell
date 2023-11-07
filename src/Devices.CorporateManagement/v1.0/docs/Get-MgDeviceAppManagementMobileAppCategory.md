---
external help file:
Module Name: Microsoft.Graph.Devices.CorporateManagement
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.devices.corporatemanagement/get-mgdeviceappmanagementmobileappcategory
schema: 2.0.0
---

# Get-MgDeviceAppManagementMobileAppCategory

## SYNOPSIS
Read properties and relationships of the mobileAppCategory object.

## SYNTAX

### List (Default)
```
Get-MgDeviceAppManagementMobileAppCategory [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List (Default)
```
Get-MgDeviceAppManagementMobileAppCategory [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All]
 [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### Get
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get1
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get10
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get10
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get11
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get11
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get12
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get12
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get13
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get13
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get14
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get14
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get15
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get15
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get16
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get16
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get17
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get17
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get2
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get2
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get3
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get3
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get4
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get4
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get5
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get5
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get6
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get6
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get7
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get7
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get8
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get8
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get9
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### Get9
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppCategoryId <String> -MobileAppId <String>
 [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

### List13
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List14
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List15
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List16
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List17
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List2
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List3
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List4
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List5
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List6
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List7
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List7
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List8
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List8
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List9
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### List9
```
Get-MgDeviceAppManagementMobileAppCategory -MobileAppId <String> [-ExpandProperty <String[]>]
 [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>]
 [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Read properties and relationships of the mobileAppCategory object.

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

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases: CV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExpandProperty
Expand related entities

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Expand

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppCategoryId
The unique identifier of mobileAppCategory

```yaml
Type: System.String
Parameter Sets: Get, Get, Get1, Get1, Get10, Get10, Get11, Get11, Get12, Get12, Get13, Get13, Get14, Get14, Get15, Get15, Get16, Get16, Get17, Get17, Get2, Get2, Get3, Get3, Get4, Get4, Get5, Get5, Get6, Get6, Get7, Get7, Get8, Get8, Get9, Get9
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MobileAppId
The unique identifier of mobileApp

```yaml
Type: System.String
Parameter Sets: Get1, Get1, Get10, Get10, Get11, Get11, Get12, Get12, Get13, Get13, Get14, Get14, Get15, Get15, Get16, Get16, Get17, Get17, Get2, Get2, Get3, Get3, Get4, Get4, Get5, Get5, Get6, Get6, Get7, Get7, Get8, Get8, Get9, Get9, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Property
Select properties to be returned

```yaml
Type: System.String[]
Parameter Sets: (All)
Aliases: Select

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Search
Search items by search phrases

```yaml
Type: System.String
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sort
Order items by property values

```yaml
Type: System.String[]
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases: OrderBy

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Top
Show only the first n items

```yaml
Type: System.Int32
Parameter Sets: List, List, List13, List14, List15, List16, List17, List2, List3, List4, List5, List6, List7, List7, List8, List8, List9, List9
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IDevicesCorporateManagementIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMobileAppCategory

## NOTES

ALIASES

Get-MgDeviceAppMgtMobileAppCategory

## RELATED LINKS

