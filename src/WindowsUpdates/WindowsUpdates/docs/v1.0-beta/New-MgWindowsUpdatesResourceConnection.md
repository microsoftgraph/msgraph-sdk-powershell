---
external help file:
Module Name: Microsoft.Graph.WindowsUpdates
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.windowsupdates/new-mgwindowsupdatesresourceconnection
schema: 2.0.0
---

# New-MgWindowsUpdatesResourceConnection

## SYNOPSIS
Create a new operationalInsightsConnection object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgWindowsUpdatesResourceConnection [-AdditionalProperties <Hashtable>] [-Id <String>] [-State <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgWindowsUpdatesResourceConnection -BodyParameter <IMicrosoftGraphWindowsUpdatesResourceConnection>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new operationalInsightsConnection object.

## EXAMPLES

### Example 1: Using the New-MgWindowsUpdatesResourceConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.operationalInsightsConnection"
	AzureSubscriptionId = "322ec614-e9c2-4cd5-a55c-5711fdecf02e"
	AzureResourceGroupName = "target-resource-group"
	WorkspaceName = "my-workspace"
}
New-MgWindowsUpdatesResourceConnection -BodyParameter $params
```

This example shows how to use the New-MgWindowsUpdatesResourceConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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
resourceConnection
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesResourceConnection
Parameter Sets: Create
Aliases:

Required: True
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -State
resourceConnectionState

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesResourceConnection

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphWindowsUpdatesResourceConnection

## NOTES

ALIASES

### New-MgWuResourceConnection

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphWindowsUpdatesResourceConnection>: resourceConnection
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[State <String>]`: resourceConnectionState

## RELATED LINKS

