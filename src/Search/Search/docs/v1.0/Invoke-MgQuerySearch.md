---
external help file:
Module Name: Microsoft.Graph.Search
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.search/invoke-mgquerysearch
schema: 2.0.0
---

# Invoke-MgQuerySearch

## SYNOPSIS
Invoke action query

## SYNTAX

### QueryExpanded (Default)
```
Invoke-MgQuerySearch [-AdditionalProperties <Hashtable>] [-Requests <IMicrosoftGraphSearchRequest[]>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Query
```
Invoke-MgQuerySearch
 -BodyParameter <IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema> [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action query

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: QueryExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Query
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Requests
.
To construct, see NOTES section for REQUESTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchRequest[]
Parameter Sets: QueryExpanded
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

### Microsoft.Graph.PowerShell.Models.IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphSearchResponse

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Kd2XrlSearchMicrosoftGraphQueryPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Requests <IMicrosoftGraphSearchRequest[]>]`: 
    - `[ContentSources <String[]>]`: Contains the connection to be targeted. Respects the following format : /external/connections/connectionid where connectionid is the ConnectionId defined in the Connectors Administration.  Note: contentSource is only applicable when entityType=externalItem. Optional.
    - `[EnableTopResults <Boolean?>]`: This triggers hybrid sort for messages: the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.
    - `[EntityTypes <String[]>]`: One or more types of resources expected in the response. Possible values are: list, site, listItem, message, event, drive, driveItem, externalItem. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.
    - `[Fields <String[]>]`: Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from content that Microsoft Graph connectors bring in. The fields property can be using the semantic labels applied to properties. For example, if a property is label as title, you can retrieve it using the following syntax : label_title.Optional.
    - `[From <Int32?>]`: Specifies the offset for the search results. Offset 0 returns the very first result. Optional.
    - `[Query <IMicrosoftGraphSearchQuery>]`: searchQuery
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[QueryString <String>]`: The search query containing the search terms. Required.
    - `[Size <Int32?>]`: The size of the page to be retrieved. Optional.

REQUESTS <IMicrosoftGraphSearchRequest[]>: .
  - `[ContentSources <String[]>]`: Contains the connection to be targeted. Respects the following format : /external/connections/connectionid where connectionid is the ConnectionId defined in the Connectors Administration.  Note: contentSource is only applicable when entityType=externalItem. Optional.
  - `[EnableTopResults <Boolean?>]`: This triggers hybrid sort for messages: the first 3 messages are the most relevant. This property is only applicable to entityType=message. Optional.
  - `[EntityTypes <String[]>]`: One or more types of resources expected in the response. Possible values are: list, site, listItem, message, event, drive, driveItem, externalItem. See known limitations for those combinations of two or more entity types that are supported in the same search request. Required.
  - `[Fields <String[]>]`: Contains the fields to be returned for each resource object specified in entityTypes, allowing customization of the fields returned by default otherwise, including additional fields such as custom managed properties from SharePoint and OneDrive, or custom fields in externalItem from content that Microsoft Graph connectors bring in. The fields property can be using the semantic labels applied to properties. For example, if a property is label as title, you can retrieve it using the following syntax : label_title.Optional.
  - `[From <Int32?>]`: Specifies the offset for the search results. Offset 0 returns the very first result. Optional.
  - `[Query <IMicrosoftGraphSearchQuery>]`: searchQuery
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[QueryString <String>]`: The search query containing the search terms. Required.
  - `[Size <Int32?>]`: The size of the page to be retrieved. Optional.

## RELATED LINKS

