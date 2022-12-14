---
external help file:
Module Name: Microsoft.Graph.Beta.Compliance
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.compliance/clear-mgcomplianceediscoverycasesourcecollectiondata
schema: 2.0.0
---

# Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData

## SYNOPSIS
Permanently delete Microsoft Teams messages contained in a sourceCollection.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- Advanced eDiscovery workflow for content in Microsoft Teams

## SYNTAX

### Purge (Default)
```
Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData -CaseId <String> -SourceCollectionId <String> [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentity
```
Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData -InputObject <IComplianceIdentity> [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Permanently delete Microsoft Teams messages contained in a sourceCollection.
You can collect and purge the following categories of Teams content:\n- **Teams 1:1 chats** - Chat messages, posts, and attachments shared in a Teams conversation between two people.
Teams 1:1 chats are also called *conversations*.\n- **Teams group chats** - Chat messages, posts, and attachments shared in a Teams conversation between three or more people.
Also called *1:N* chats or *group conversations*.\n- **Teams channels** - Chat messages, posts, replies, and attachments shared in a standard Teams channel.\n- **Private channels** - Message posts, replies, and attachments shared in a private Teams channel.\n- **Shared channels** - Message posts, replies, and attachments shared in a shared Teams channel.
For more information about purging Teams messages, see:\n- eDiscovery solution series: Data spillage scenario - Search and purge\n- Advanced eDiscovery workflow for content in Microsoft Teams

## EXAMPLES

### Example 1: Using the Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Compliance
Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData -CaseId $caseId -SourceCollectionId $sourceCollectionId
```

This example shows how to use the Clear-MgBetaComplianceEdiscoveryCaseSourceCollectionData Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -CaseId
key: id of case

```yaml
Type: System.String
Parameter Sets: Purge
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity
Parameter Sets: PurgeViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

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

### -SourceCollectionId
key: id of sourceCollection

```yaml
Type: System.String
Parameter Sets: Purge
Aliases:

Required: True
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

### Microsoft.Graph.Beta.PowerShell.Models.IComplianceIdentity

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IComplianceIdentity>: Identity Parameter
  - `[CaseId <String>]`: key: id of case
  - `[CaseOperationId <String>]`: key: id of caseOperation
  - `[CustodianId <String>]`: key: id of custodian
  - `[DataSourceId <String>]`: key: id of dataSource
  - `[LegalHoldId <String>]`: key: id of legalHold
  - `[NoncustodialDataSourceId <String>]`: key: id of noncustodialDataSource
  - `[ReviewSetId <String>]`: key: id of reviewSet
  - `[ReviewSetQueryId <String>]`: key: id of reviewSetQuery
  - `[SiteSourceId <String>]`: key: id of siteSource
  - `[SourceCollectionId <String>]`: key: id of sourceCollection
  - `[TagId <String>]`: key: id of tag
  - `[TagId1 <String>]`: key: id of tag
  - `[UnifiedGroupSourceId <String>]`: key: id of unifiedGroupSource
  - `[UserSourceId <String>]`: key: id of userSource

## RELATED LINKS

