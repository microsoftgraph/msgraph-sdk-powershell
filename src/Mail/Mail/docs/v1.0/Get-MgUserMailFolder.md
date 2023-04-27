---
external help file:
Module Name: Microsoft.Graph.Mail
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.mail/get-mgusermailfolder
schema: 2.0.0
---

# Get-MgUserMailFolder

## SYNOPSIS
The user's mail folders.
Read-only.
Nullable.

## SYNTAX

### List (Default)
```
Get-MgUserMailFolder -UserId <String> [-ExpandProperty <String[]>] [-Filter <String>]
 [-IncludeHiddenFolders <String>] [-Property <String[]>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [-All] [-CountVariable <String>] [-PageSize <Int32>] [<CommonParameters>]
```

### Get
```
Get-MgUserMailFolder -MailFolderId <String> -UserId <String> [-ExpandProperty <String[]>]
 [-IncludeHiddenFolders <String>] [-Property <String[]>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserMailFolder -InputObject <IMailIdentity> [-ExpandProperty <String[]>]
 [-IncludeHiddenFolders <String>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
The user's mail folders.
Read-only.
Nullable.

## EXAMPLES

### Example 1: Using the Get-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```

This example shows how to use the Get-MgUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the Get-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId
```

This example shows how to use the Get-MgUserMailFolder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the Get-MgUserMailFolder Cmdlet
```powershell
Import-Module Microsoft.Graph.Mail
# A UPN can also be used as -UserId.
Get-MgUserMailFolder -UserId $userId -MailFolderId $mailFolderId
```

This example shows how to use the Get-MgUserMailFolder Cmdlet.
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

### -IncludeHiddenFolders
Include Hidden Folders

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

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMailIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -MailFolderId
The unique identifier of mailFolder

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

### -UserId
The unique identifier of user

```yaml
Type: System.String
Parameter Sets: Get, List
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

### Microsoft.Graph.PowerShell.Models.IMailIdentity

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphMailFolder

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


INPUTOBJECT <IMailIdentity>: Identity Parameter
  - `[AttachmentId <String>]`: The unique identifier of attachment
  - `[ExtensionId <String>]`: The unique identifier of extension
  - `[InferenceClassificationOverrideId <String>]`: The unique identifier of inferenceClassificationOverride
  - `[MailFolderId <String>]`: The unique identifier of mailFolder
  - `[MailFolderId1 <String>]`: The unique identifier of mailFolder
  - `[MentionId <String>]`: The unique identifier of mention
  - `[MessageId <String>]`: The unique identifier of message
  - `[MessageRuleId <String>]`: The unique identifier of messageRule
  - `[MultiValueLegacyExtendedPropertyId <String>]`: The unique identifier of multiValueLegacyExtendedProperty
  - `[SingleValueLegacyExtendedPropertyId <String>]`: The unique identifier of singleValueLegacyExtendedProperty
  - `[UserConfigurationId <String>]`: The unique identifier of userConfiguration
  - `[UserId <String>]`: The unique identifier of user

## RELATED LINKS

