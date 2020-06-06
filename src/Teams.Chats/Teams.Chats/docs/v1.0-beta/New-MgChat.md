---
external help file:
Module Name: Microsoft.Graph.Teams.Chats
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.teams.chats/new-mgchat
schema: 2.0.0
---

# New-MgChat

## SYNOPSIS
Add new entity to chats

## SYNTAX

### CreateExpanded (Default)
```
New-MgChat [-CreatedDateTime <DateTime>] [-Id <String>]
 [-InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>] [-LastUpdatedDateTime <DateTime>]
 [-Members <IMicrosoftGraphConversationMember[]>] [-Messages <IMicrosoftGraphChatMessage[]>] [-Topic <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgChat -BodyParameter <IMicrosoftGraphChat> [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to chats

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -BodyParameter
chat
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
.

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

### -InstalledApps
.
To construct, see NOTES section for INSTALLEDAPPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTeamsAppInstallation[]
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
Type: System.DateTime
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphConversationMember[]
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
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChatMessage[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphChat

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphChat>: chat
  - `[Id <String>]`: Read-only.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[InstalledApps <IMicrosoftGraphTeamsAppInstallation[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[TeamAppDefinitionDisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamAppDefinitionId <String>]`: Read-only.
    - `[TeamAppDefinitionTeamsAppId <String>]`: The id from the Teams App manifest.
    - `[TeamAppDefinitionVersion <String>]`: The version number of the application.
    - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
      - `[Id <String>]`: Read-only.
      - `[DisplayName <String>]`: The name of the app provided by the app developer.
      - `[TeamsAppId <String>]`: The id from the Teams App manifest.
      - `[Version <String>]`: The version number of the application.
    - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
    - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
    - `[TeamAppId <String>]`: Read-only.
    - `[TeamAppName <String>]`: 
  - `[LastUpdatedDateTime <DateTime?>]`: 
  - `[Members <IMicrosoftGraphConversationMember[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: 
    - `[Roles <String[]>]`: 
  - `[Messages <IMicrosoftGraphChatMessage[]>]`: 
    - `[Id <String>]`: Read-only.
    - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: 
      - `[Content <String>]`: 
      - `[ContentType <String>]`: 
      - `[ContentUrl <String>]`: 
      - `[Id <String>]`: 
      - `[Name <String>]`: 
      - `[ThumbnailUrl <String>]`: 
    - `[BodyContent <String>]`: The content of the item.
    - `[BodyContentType <String>]`: bodyType
    - `[CreatedDateTime <DateTime?>]`: 
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Etag <String>]`: 
    - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
        - `[Id <String>]`: Unique identifier for the identity.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
      - `[Id <String>]`: Read-only.
    - `[Importance <String>]`: chatMessageImportance
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[Locale <String>]`: 
    - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: 
      - `[Id <Int32?>]`: 
      - `[MentionText <String>]`: 
      - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[MessageType <String>]`: chatMessageType
    - `[PolicyTipComplianceUrl <String>]`: 
    - `[PolicyTipGeneralText <String>]`: 
    - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
    - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
    - `[PolicyViolationJustificationText <String>]`: 
    - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
    - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
    - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
      - `[CreatedDateTime <DateTime?>]`: 
      - `[ReactionType <String>]`: 
      - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Replies <IMicrosoftGraphChatMessage[]>]`: 
    - `[ReplyToId <String>]`: 
    - `[Subject <String>]`: 
    - `[Summary <String>]`: 
    - `[WebUrl <String>]`: 
  - `[Topic <String>]`: 

INSTALLEDAPPS <IMicrosoftGraphTeamsAppInstallation[]>: .
  - `[Id <String>]`: Read-only.
  - `[TeamAppDefinitionDisplayName <String>]`: The name of the app provided by the app developer.
  - `[TeamAppDefinitionId <String>]`: Read-only.
  - `[TeamAppDefinitionTeamsAppId <String>]`: The id from the Teams App manifest.
  - `[TeamAppDefinitionVersion <String>]`: The version number of the application.
  - `[TeamAppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[Id <String>]`: Read-only.
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[TeamsAppId <String>]`: The id from the Teams App manifest.
    - `[Version <String>]`: The version number of the application.
  - `[TeamAppDisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppDistributionMethod <String>]`: teamsAppDistributionMethod
  - `[TeamAppExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.
  - `[TeamAppId <String>]`: Read-only.
  - `[TeamAppName <String>]`: 

MEMBERS <IMicrosoftGraphConversationMember[]>: .
  - `[Id <String>]`: Read-only.
  - `[DisplayName <String>]`: 
  - `[Roles <String[]>]`: 

MESSAGES <IMicrosoftGraphChatMessage[]>: .
  - `[Id <String>]`: Read-only.
  - `[Attachments <IMicrosoftGraphChatMessageAttachment[]>]`: 
    - `[Content <String>]`: 
    - `[ContentType <String>]`: 
    - `[ContentUrl <String>]`: 
    - `[Id <String>]`: 
    - `[Name <String>]`: 
    - `[ThumbnailUrl <String>]`: 
  - `[BodyContent <String>]`: The content of the item.
  - `[BodyContentType <String>]`: bodyType
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DeletedDateTime <DateTime?>]`: 
  - `[Etag <String>]`: 
  - `[From <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[DisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[HostedContents <IMicrosoftGraphChatMessageHostedContent[]>]`: 
    - `[Id <String>]`: Read-only.
  - `[Importance <String>]`: chatMessageImportance
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[Locale <String>]`: 
  - `[Mentions <IMicrosoftGraphChatMessageMention[]>]`: 
    - `[Id <Int32?>]`: 
    - `[MentionText <String>]`: 
    - `[Mentioned <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[MessageType <String>]`: chatMessageType
  - `[PolicyTipComplianceUrl <String>]`: 
  - `[PolicyTipGeneralText <String>]`: 
  - `[PolicyTipMatchedConditionDescriptions <String[]>]`: 
  - `[PolicyViolationDlpAction <String>]`: chatMessagePolicyViolationDlpActionTypes
  - `[PolicyViolationJustificationText <String>]`: 
  - `[PolicyViolationUserAction <String>]`: chatMessagePolicyViolationUserActionTypes
  - `[PolicyViolationVerdictDetails <String>]`: chatMessagePolicyViolationVerdictDetailsTypes
  - `[Reactions <IMicrosoftGraphChatMessageReaction[]>]`: 
    - `[CreatedDateTime <DateTime?>]`: 
    - `[ReactionType <String>]`: 
    - `[User <IMicrosoftGraphIdentitySet>]`: identitySet
  - `[Replies <IMicrosoftGraphChatMessage[]>]`: 
  - `[ReplyToId <String>]`: 
  - `[Subject <String>]`: 
  - `[Summary <String>]`: 
  - `[WebUrl <String>]`: 

## RELATED LINKS

