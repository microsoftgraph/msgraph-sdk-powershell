---
external help file:
Module Name: Microsoft.Graph.Beta.DirectoryObjects
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.directoryobjects/confirm-mgdirectoryobjectmembergroup
schema: 2.0.0
---

# Confirm-MgBetaDirectoryObjectMemberGroup

## SYNOPSIS
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

## SYNTAX

### CheckExpanded1 (Default)
```
Confirm-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId <String> [-AdditionalProperties <Hashtable>]
 [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Check1
```
Confirm-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId <String>
 -BodyParameter <IPaths1Ffes6MDirectoryobjectsDirectoryobjectIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentity1
```
Confirm-MgBetaDirectoryObjectMemberGroup -InputObject <IDirectoryObjectsIdentity>
 -BodyParameter <IPaths1Ffes6MDirectoryobjectsDirectoryobjectIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### CheckViaIdentityExpanded1
```
Confirm-MgBetaDirectoryObjectMemberGroup -InputObject <IDirectoryObjectsIdentity>
 [-AdditionalProperties <Hashtable>] [-GroupIds <String[]>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Check for membership in a specified list of group IDs, and return from that list those groups (identified by IDs) of which the specified user, group, service principal, organizational contact, device, or directory object is a member.
This function is transitive.
You can check up to a maximum of 20 groups per request.
This function supports all groups provisioned in Azure AD.
Because Microsoft 365 groups cannot contain other groups, membership in a Microsoft 365 group is always direct.

## EXAMPLES

### Example 1: Using the Confirm-MgBetaDirectoryObjectMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DirectoryObjects
$params = @{
	GroupIds = @(
		"f448435d-3ca7-4073-8152-a1fd73c0fd09"
		"bd7c6263-4dd5-4ae8-8c96-556e1c0bece6"
		"93670da6-d731-4366-94b5-abed40b6016b"
		"f5484ab1-4d4d-41ec-a9b8-754b3957bfc7"
		"c9103f26-f3cf-4004-a611-2a14e81b8f79"
	)
}
Confirm-MgBetaDirectoryObjectMemberGroup -DirectoryObjectId $directoryObjectId -BodyParameter $params
```

This example shows how to use the Confirm-MgBetaDirectoryObjectMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IPaths1Ffes6MDirectoryobjectsDirectoryobjectIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Check1, CheckViaIdentity1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DirectoryObjectId
key: id of directoryObject

```yaml
Type: System.String
Parameter Sets: Check1, CheckExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -GroupIds
.

```yaml
Type: System.String[]
Parameter Sets: CheckExpanded1, CheckViaIdentityExpanded1
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
Type: Microsoft.Graph.Beta.PowerShell.Models.IDirectoryObjectsIdentity
Parameter Sets: CheckViaIdentity1, CheckViaIdentityExpanded1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### Microsoft.Graph.Beta.PowerShell.Models.IDirectoryObjectsIdentity

### Microsoft.Graph.Beta.PowerShell.Models.IPaths1Ffes6MDirectoryobjectsDirectoryobjectIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### System.String

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths1Ffes6MDirectoryobjectsDirectoryobjectIdMicrosoftGraphCheckmembergroupsPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[GroupIds <String[]>]`: 

INPUTOBJECT <IDirectoryObjectsIdentity>: Identity Parameter
  - `[DirectoryObjectId <String>]`: key: id of directoryObject

## RELATED LINKS

