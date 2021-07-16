---
external help file: Microsoft.Graph.Users-help.xml
Module Name: Microsoft.Graph.Users
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.users/get-mguseroauth2permissiongrant
schema: 2.0.0
---

# Get-MgUserOauth2PermissionGrant

## SYNOPSIS
Get oauth2PermissionGrants from users

## SYNTAX

```
Get-MgUserOauth2PermissionGrant -UserId <String> [-ExpandProperty <String[]>] [-Filter <String>]
 [-Property <String[]>] [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>]
 [-PageSize <Int32>] [-All] [-CountVariable <String>] [<CommonParameters>]
```

## DESCRIPTION
Get oauth2PermissionGrants from users

## EXAMPLES

### Example 1: Get user's oAuth2PermissionGrant
```powershell
Get-MgUserOauth2permissionGrant  -UserId 'afeb5811-0582-4188-8546-4440c2b921bd' | Format-List

ClientId             : 202397ec-d9d7-4b95-b5a8-ff85f5ccae11
ConsentType          : Principal
Id                   : F-eYWQGKuUS7WYM4IyWyuchvEPl3fYZLhdmaX2Ic7rRBDFVooxheSaodz2KMFxtI
PrincipalId          : afeb5811-0582-4188-8546-4440c2b921bd
ResourceId           : f9106fc8-7d77-4b86-85d9-9a5f621ceeb4
Scope                :  User.Read offline_access profile openid User.Read.All Group.ReadWrite.All Directory.ReadWrite.All
AdditionalProperties : {}
```

This example gets the oauth2PermissionGrants for the specified user.

## PARAMETERS

### -All
List all pages.

```yaml
Type: SwitchParameter
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
Type: String
Parameter Sets: (All)
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
Type: String[]
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
Type: String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PageSize
Sets the page size of results.

```yaml
Type: Int32
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
Type: String[]
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
Type: String
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
Type: String[]
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
Type: Int32
Parameter Sets: (All)
Aliases: Limit

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserId
key: id of user

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Skip
Skip the first n items

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOAuth2PermissionGrant1
## NOTES

ALIASES

## RELATED LINKS
