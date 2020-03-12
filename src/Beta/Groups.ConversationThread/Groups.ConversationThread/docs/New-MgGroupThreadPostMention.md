---
external help file:
Module Name: Microsoft.Graph.Groups.ConversationThread
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.groups.conversationthread/new-mggroupthreadpostmention
schema: 2.0.0
---

# New-MgGroupThreadPostMention

## SYNOPSIS
Create new navigation property to mentions for groups

## SYNTAX

### CreateExpanded (Default)
```
New-MgGroupThreadPostMention -ConversationThreadId <String> -GroupId <String> -PostId <String>
 [-Application <String>] [-ClientReference <String>] [-CreatedByAddress <String>] [-CreatedByName <String>]
 [-CreatedDateTime <DateTime>] [-DeepLink <String>] [-Id <String>] [-MentionedAddress <String>]
 [-MentionedName <String>] [-MentionText <String>] [-ServerCreatedDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgGroupThreadPostMention -ConversationThreadId <String> -GroupId <String> -PostId <String>
 -BodyParameter <IMicrosoftGraphMention> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgGroupThreadPostMention -InputObject <IGroupsConversationThreadIdentity>
 -BodyParameter <IMicrosoftGraphMention> [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgGroupThreadPostMention -InputObject <IGroupsConversationThreadIdentity> [-Application <String>]
 [-ClientReference <String>] [-CreatedByAddress <String>] [-CreatedByName <String>]
 [-CreatedDateTime <DateTime>] [-DeepLink <String>] [-Id <String>] [-MentionedAddress <String>]
 [-MentionedName <String>] [-MentionText <String>] [-ServerCreatedDateTime <DateTime>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to mentions for groups

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

### -Application
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
mention
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMention
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ClientReference
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ConversationThreadId
key: conversationThread-id of conversationThread

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedByAddress
The email address of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedByName
The display name of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DeepLink
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -GroupId
key: group-id of group

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
Read-only.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IGroupsConversationThreadIdentity
Parameter Sets: CreateViaIdentity, CreateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -MentionedAddress
The email address of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MentionedName
The display name of the person or entity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -MentionText
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PostId
key: post-id of post

```yaml
Type: System.String
Parameter Sets: Create, CreateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServerCreatedDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IGroupsConversationThreadIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMention

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMention

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphMention>: mention
  - `[Id <String>]`: Read-only.
  - `[Application <String>]`: 
  - `[ClientReference <String>]`: 
  - `[CreatedByAddress <String>]`: The email address of the person or entity.
  - `[CreatedByName <String>]`: The display name of the person or entity.
  - `[CreatedDateTime <DateTime?>]`: 
  - `[DeepLink <String>]`: 
  - `[MentionText <String>]`: 
  - `[MentionedAddress <String>]`: The email address of the person or entity.
  - `[MentionedName <String>]`: The display name of the person or entity.
  - `[ServerCreatedDateTime <DateTime?>]`: 

#### INPUTOBJECT <IGroupsConversationThreadIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: key: attachment-id of attachment
  - `[ConversationThreadId <String>]`: key: conversationThread-id of conversationThread
  - `[ExtensionId <String>]`: key: extension-id of extension
  - `[GroupId <String>]`: key: group-id of group
  - `[MentionId <String>]`: key: mention-id of mention
  - `[MultiValueLegacyExtendedPropertyId <String>]`: key: multiValueLegacyExtendedProperty-id of multiValueLegacyExtendedProperty
  - `[PostId <String>]`: key: post-id of post
  - `[SingleValueLegacyExtendedPropertyId <String>]`: key: singleValueLegacyExtendedProperty-id of singleValueLegacyExtendedProperty

## RELATED LINKS

