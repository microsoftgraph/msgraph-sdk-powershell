---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecurityidentityhealthissue
schema: 2.0.0
---

# New-MgBetaSecurityIdentityHealthIssue

## SYNOPSIS
Create new navigation property to healthIssues for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityIdentityHealthIssue [-AdditionalInformation <String[]>] [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-Description <String>] [-DisplayName <String>] [-DomainNames <String[]>]
 [-HealthIssueType <String>] [-Id <String>] [-IssueTypeId <String>] [-LastModifiedDateTime <DateTime>]
 [-Recommendations <String[]>] [-RecommendedActionCommands <String[]>] [-ResponseHeadersVariable <String>]
 [-SensorDnsNames <String[]>] [-Severity <String>] [-Status <String>] [-Headers <IDictionary>] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityIdentityHealthIssue -BodyParameter <IMicrosoftGraphSecurityHealthIssue>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to healthIssues for security

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

### -AdditionalInformation
Contains additional information about the issue, such as a list of items to fix.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
healthIssue
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityHealthIssue
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
The date and time of when the health issue was generated.

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

### -Description
Contains more detailed information about the health issue.

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

### -DisplayName
The display name of the health issue.

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

### -DomainNames
A list of the fully qualified domain names of the domains or the sensors the health issue is related to.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Headers
Optional headers that will be added to the request.

```yaml
Type: System.Collections.IDictionary
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -HealthIssueType
healthIssueType

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

### -Id
The unique identifier for an entity.
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

### -IssueTypeId
The type identifier of the health issue.
For a list of all health issues and their identifiers, see Microsoft Defender for Identity health issues.

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

### -LastModifiedDateTime
The date and time of when the health issue was last updated.

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

### -Recommendations
This field contains a list of recommended actions that can be taken to resolve the issue effectively and efficiently.
These actions might include how to investigate the issue further.
Not limited to prewritten responses.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecommendedActionCommands
Contains a list of commands from the product's PowerShell module that can be used to resolve the issue, if available.
If there aren't any commands that can be used to solve the issue, this field is empty.
The commands, if present, provide a quick and efficient way to address the issue.
The commands run in order for the single recommended fix.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResponseHeadersVariable
Optional Response Headers Variable.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases: RHV

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SensorDnsNames
A list of the dns names of the sensors the health issue is related to.

```yaml
Type: System.String[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Severity
healthIssueSeverity

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

### -Status
healthIssueStatus

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityHealthIssue

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityHealthIssue

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityHealthIssue>`: healthIssue
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdditionalInformation <String[]>]`: Contains additional information about the issue, such as a list of items to fix.
  - `[CreatedDateTime <DateTime?>]`: The date and time of when the health issue was generated.
  - `[Description <String>]`: Contains more detailed information about the health issue.
  - `[DisplayName <String>]`: The display name of the health issue.
  - `[DomainNames <String[]>]`: A list of the fully qualified domain names of the domains or the sensors the health issue is related to.
  - `[HealthIssueType <String>]`: healthIssueType
  - `[IssueTypeId <String>]`: The type identifier of the health issue. For a list of all health issues and their identifiers, see Microsoft Defender for Identity health issues.
  - `[LastModifiedDateTime <DateTime?>]`: The date and time of when the health issue was last updated.
  - `[Recommendations <String[]>]`: This field contains a list of recommended actions that can be taken to resolve the issue effectively and efficiently. These actions might include how to investigate the issue further. Not limited to prewritten responses.
  - `[RecommendedActionCommands <String[]>]`: Contains a list of commands from the product's PowerShell module that can be used to resolve the issue, if available. If there aren't any commands that can be used to solve the issue, this field is empty. The commands, if present, provide a quick and efficient way to address the issue. The commands run in order for the single recommended fix.
  - `[SensorDnsNames <String[]>]`: A list of the dns names of the sensors the health issue is related to.
  - `[Severity <String>]`: healthIssueSeverity
  - `[Status <String>]`: healthIssueStatus

## RELATED LINKS

