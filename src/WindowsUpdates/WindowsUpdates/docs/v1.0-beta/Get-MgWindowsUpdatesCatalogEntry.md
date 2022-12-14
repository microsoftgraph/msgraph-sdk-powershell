---
external help file:
Module Name: Microsoft.Graph.Beta.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.windowsupdates/get-mgwindowsupdatescatalogentry
schema: 2.0.0
---

# Get-MgBetaWindowsUpdatesCatalogEntry

## SYNOPSIS
Lists the content that you can approve for deployment.
Read-only.

## SYNTAX

### List (Default)
```
Get-MgBetaWindowsUpdatesCatalogEntry [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>]
 [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgBetaWindowsUpdatesCatalogEntry -CatalogEntryId <String> [-ExpandProperty <String[]>] [-Property <String[]>]
 [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgBetaWindowsUpdatesCatalogEntry -InputObject <IWindowsUpdatesIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Lists the content that you can approve for deployment.
Read-only.

## EXAMPLES

### Example 1: Using the Get-MgBetaWindowsUpdatesCatalogEntry Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
Get-MgBetaWindowsUpdatesCatalogEntry
```

This example shows how to use the Get-MgBetaWindowsUpdatesCatalogEntry Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CatalogEntryId
key: id of catalogEntry

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
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
Parameter Sets: List
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
Parameter Sets: List
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: System.Int32
Parameter Sets: List
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
Parameter Sets: List
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
Parameter Sets: List
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
Parameter Sets: List
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
Parameter Sets: List
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

### Microsoft.Graph.Beta.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphWindowsUpdatesCatalogEntry

## NOTES

ALIASES

### Get-MgBetaWuCatalogEntry

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: key: id of catalogEntry
  - `[DeploymentId <String>]`: key: id of deployment
  - `[ResourceConnectionId <String>]`: key: id of resourceConnection
  - `[UpdatableAssetId <String>]`: key: id of updatableAsset

## RELATED LINKS

