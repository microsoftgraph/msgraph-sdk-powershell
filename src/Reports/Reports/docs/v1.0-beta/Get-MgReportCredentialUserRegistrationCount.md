---
external help file:
Module Name: Microsoft.Graph.Beta.Reports
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.reports/get-mgreportcredentialuserregistrationcount
schema: 2.0.0
---

# Get-MgBetaReportCredentialUserRegistrationCount

## SYNOPSIS
Report the current state of how many users in your organization are registered for self-service password reset and multi-factor authentication (MFA) capabilities.

## SYNTAX

```
Get-MgBetaReportCredentialUserRegistrationCount [-Count] [-Filter <String>] [-Property <String[]>]
 [-Search <String>] [-Skip <Int32>] [-Sort <String[]>] [-Top <Int32>] [<CommonParameters>]
```

## DESCRIPTION
Report the current state of how many users in your organization are registered for self-service password reset and multi-factor authentication (MFA) capabilities.

## EXAMPLES

### Example 1: Using the Get-MgBetaReportCredentialUserRegistrationCount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
Get-MgBetaReportCredentialUserRegistrationCount
```

This example shows how to use the Get-MgBetaReportCredentialUserRegistrationCount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

### -Count
Include count of items

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

### -Filter
Filter items by property values

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

### -Search
Search items by search phrases

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

### -Skip
Skip the first n items

```yaml
Type: System.Int32
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
Type: System.String[]
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
Type: System.Int32
Parameter Sets: (All)
Aliases: Limit

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphCredentialUserRegistrationCount

## NOTES

ALIASES

## RELATED LINKS

