---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.DirectoryManagement
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.directorymanagement/get-mgcontactdelta
schema: 2.0.0
---

# Get-MgBetaContactDelta

## SYNOPSIS
Invoke function delta

## SYNTAX

```
Get-MgBetaContactDelta [-Count] [-Filter <String>] [-Property <String[]>] [-Search <String>] [-Skip <Int32>]
 [-Sort <String[]>] [-Top <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Invoke function delta

## EXAMPLES

### Example 1: Using the Get-MgBetaContactDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaContactDelta
```

This example shows how to use the Get-MgBetaContactDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -Count
Include count of items

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

### -Filter
Filter items by property values

```yaml
Type: System.String
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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
Parameter Sets: (All)
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

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphOrgContact1

## NOTES

ALIASES

## RELATED LINKS

