---
external help file:
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/get-mgusermanagerbyref
schema: 2.0.0
---

# Get-MgUserManagerByRef

## SYNOPSIS
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

## SYNTAX

### Get (Default)
```
Get-MgUserManagerByRef -UserId <String> [<CommonParameters>]
```

### GetViaIdentity
```
Get-MgUserManagerByRef -InputObject <IUsersIdentity> [<CommonParameters>]
```

## DESCRIPTION
Returns the user or organizational contact assigned as the user's manager.
Optionally, you can expand the manager's chain up to the root node.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
{{ Add code here }}
```



### -------------------------- EXAMPLE 2 --------------------------
```powershell
{{ Add code here }}
```



## PARAMETERS

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IUsersIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -UserId
key: id of user

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

### Microsoft.Graph.PowerShell.Models.IUsersIdentity

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IUsersIdentity>`: Identity Parameter
  - `[AttachmentBaseId <String>]`: key: id of attachmentBase
  - `[AttachmentSessionId <String>]`: key: id of attachmentSession
  - `[ChecklistItemId <String>]`: key: id of checklistItem
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[ExtensionId <String>]`: key: id of extension
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[LinkedResourceId <String>]`: key: id of linkedResource
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OutlookCategoryId <String>]`: key: id of outlookCategory
  - `[ProfilePhotoId <String>]`: key: id of profilePhoto
  - `[TodoTaskId <String>]`: key: id of todoTask
  - `[TodoTaskListId <String>]`: key: id of todoTaskList
  - `[UserId <String>]`: key: id of user

## RELATED LINKS

