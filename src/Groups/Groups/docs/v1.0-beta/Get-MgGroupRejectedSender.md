---
external help file:
Module Name: Microsoft.Graph.Beta.Groups
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.groups/get-mggrouprejectedsender
schema: 2.0.0
---

# Get-MgBetaGroupRejectedSender

## SYNOPSIS
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

## SYNTAX

```
Get-MgBetaGroupRejectedSender -GroupId <String> [-Filter <String>] [-Property <String[]>] [-Skip <Int32>]
 [-Sort <String[]>] [-Top <Int32>] [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Get a list of users or groups that are in the rejected-senders list for this group.
Users in the rejected senders list cannot post to conversations of the group (identified in the GET request URL).
Make sure you do not specify the same user or group in the rejected senders and accepted senders lists, otherwise you will get an error.

## EXAMPLES

### Example 1: Using the Get-MgBetaGroupRejectedSender Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
Get-MgBetaGroupRejectedSender -GroupId $groupId
```

This example shows how to use the Get-MgBetaGroupRejectedSender Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -All
List all pages.

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

### -CountVariable
Specifies a count of the total number of items in a collection.
By default, this variable will be set in the global scope.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: CV

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

### -GroupId
key: id of group

```yaml
Type: System.String
Parameter Sets: (All)
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphDirectoryObject

## NOTES

ALIASES

## RELATED LINKS

