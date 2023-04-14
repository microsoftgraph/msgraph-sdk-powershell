---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/get-mgwindowsupdatesupdatableasset
schema: 2.0.0
---

# Get-MgWindowsUpdatesUpdatableAsset

## SYNOPSIS
Assets registered with the deployment service that can receive updates.

## SYNTAX

### List (Default)
```
Get-MgWindowsUpdatesUpdatableAsset [-ExpandProperty <String[]>] [-Filter <String>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>]
 [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId <String> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgWindowsUpdatesUpdatableAsset -InputObject <IWindowsUpdatesIdentity> [-ExpandProperty <String[]>]
 [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Assets registered with the deployment service that can receive updates.

## EXAMPLES

### Example 1: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId $updatableAssetId
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId $updatableAssetId
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -UpdatableAssetId $updatableAssetId
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -Filter "isof('microsoft.graph.windowsUpdates.azureADDevice')" 
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 5: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 6: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -OutFile $outFileId
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 7: Using the Get-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
Get-MgWindowsUpdatesUpdatableAsset -Filter "isof('microsoft.graph.windowsUpdates.updatableAssetGroup')" 
```

This example shows how to use the Get-MgWindowsUpdatesUpdatableAsset Cmdlet.
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
Type: Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity
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

### -UpdatableAssetId
The unique identifier of updatableAsset

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IWindowsUpdatesIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesUpdatableAsset

### System.String

## NOTES

ALIASES

### Get-MgWuUpdatableAsset

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IWindowsUpdatesIdentity>: Identity Parameter
  - `[CatalogEntryId <String>]`: The unique identifier of catalogEntry
  - `[ComplianceChangeId <String>]`: The unique identifier of complianceChange
  - `[DeploymentId <String>]`: The unique identifier of deployment
  - `[ResourceConnectionId <String>]`: The unique identifier of resourceConnection
  - `[UpdatableAssetId <String>]`: The unique identifier of updatableAsset
  - `[UpdatePolicyId <String>]`: The unique identifier of updatePolicy

## RELATED LINKS

