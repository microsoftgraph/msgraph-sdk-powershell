---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/get-mgpolicydeviceregistrationpolicy
schema: 2.0.0
---

# Get-MgPolicyDeviceRegistrationPolicy

## SYNOPSIS
Read the properties and relationships of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

## SYNTAX

```
Get-MgPolicyDeviceRegistrationPolicy [-ExpandProperty <String[]>] [-Property <String[]>] [<CommonParameters>]
```

## DESCRIPTION
Read the properties and relationships of a deviceRegistrationPolicy object.
Represents deviceRegistrationPolicy quota restrictions, additional authentication, and authorization policies to register device identities to your organization.

## EXAMPLES

### Example 1: Using the Get-MgPolicyDeviceRegistrationPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgPolicyDeviceRegistrationPolicy
```

This example shows how to use the Get-MgPolicyDeviceRegistrationPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

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

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDeviceRegistrationPolicy

## NOTES

ALIASES

## RELATED LINKS

