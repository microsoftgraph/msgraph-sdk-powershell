---
external help file: Microsoft.Graph.Teams-help.xml
Module Name: Microsoft.Graph.Teams
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgchat
schema: 2.0.0
---

# New-MgChat

## SYNOPSIS
Add new entity to chats

## SYNTAX

### CreateExpanded (Default)
```
New-MgChat [-AdditionalProperties <Hashtable>] [-ChatType <String>] [-CreatedDateTime <DateTime>]
 [-Id <String>] [-InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>] [-LastUpdatedDateTime <DateTime>]
 [-Members <IMicrosoftGraphConversationMember[]>] [-Messages <IMicrosoftGraphChatMessage[]>]
 [-Tabs <IMicrosoftGraphTeamsTab[]>] [-Topic <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgChat -BodyParameter <IMicrosoftGraphChat> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to chats

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

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
chat

```yaml
Type: IMicrosoftGraphChat
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ChatType
chatType

```yaml
Type: String
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
Type: DateTime
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
Type: String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InstalledApps
.
To construct, see NOTES section for INSTALLEDAPPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsAppInstallation[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -LastUpdatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Members
.
To construct, see NOTES section for MEMBERS properties and create a hash table.

```yaml
Type: IMicrosoftGraphConversationMember[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Messages
.
To construct, see NOTES section for MESSAGES properties and create a hash table.

```yaml
Type: IMicrosoftGraphChatMessage[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tabs
.
To construct, see NOTES section for TABS properties and create a hash table.

```yaml
Type: IMicrosoftGraphTeamsTab[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Topic
.

```yaml
Type: String
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat
## NOTES

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgchat](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams/new-mgchat)

