---
external help file:
Module Name: Microsoft.Graph.Beta.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/Microsoft.Graph.identity.signins/new-mginformationprotectionthreatassessmentrequest
schema: 2.0.0
---

# New-MgBetaInformationProtectionThreatAssessmentRequest

## SYNOPSIS
Create a new threat assessment request.
A threat assessment request can be one of the following types:

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaInformationProtectionThreatAssessmentRequest [-AdditionalProperties <Hashtable>] [-Category <String>]
 [-ContentType <String>] [-CreatedBy <IMicrosoftGraphIdentitySet>] [-CreatedDateTime <DateTime>]
 [-ExpectedAssessment <String>] [-Id <String>] [-RequestSource <String>]
 [-Results <IMicrosoftGraphThreatAssessmentResult[]>] [-Status <String>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter <IMicrosoftGraphThreatAssessmentRequest>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new threat assessment request.
A threat assessment request can be one of the following types:

## EXAMPLES

### Example 1: Using the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.emailFileAssessmentRequest"
	RecipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	ExpectedAssessment = "block"
	Category = "malware"
	ContentData = "UmVjZWl2ZWQ6IGZyb20gTVcyUFIwME1CMDMxNC5uYW1wcmQwMC....."
}
New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```

This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Using the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.fileAssessmentRequest"
	ExpectedAssessment = "block"
	Category = "malware"
	FileName = "test.txt"
	ContentData = "VGhpcyBpcyBhIHRlc3QgZmlsZQ=="
}
New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```

This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Using the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.mailAssessmentRequest"
	RecipientEmail = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	ExpectedAssessment = "block"
	Category = "spam"
	MessageUri = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}
New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```

This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Using the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	"@odata.type" = "#Microsoft.Graph.Beta.urlAssessmentRequest"
	Url = "http://test.com"
	ExpectedAssessment = "block"
	Category = "phishing"
}
New-MgBetaInformationProtectionThreatAssessmentRequest -BodyParameter $params
```

This example shows how to use the New-MgBetaInformationProtectionThreatAssessmentRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

## PARAMETERS

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
threatAssessmentRequest
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
threatCategory

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

### -ContentType
threatAssessmentContentType

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

### -CreatedBy
identitySet
To construct, please use Get-Help -Online and see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphIdentitySet
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.

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

### -ExpectedAssessment
threatExpectedAssessment

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
The unique idenfier for an entity.
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

### -RequestSource
threatAssessmentRequestSource

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

### -Results
A collection of threat assessment results.
Read-only.
By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
To construct, please use Get-Help -Online and see NOTES section for RESULTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentResult[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
threatAssessmentStatus

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphThreatAssessmentRequest

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IMicrosoftGraphThreatAssessmentRequest>: threatAssessmentRequest
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[Category <String>]`: threatCategory
  - `[ContentType <String>]`: threatAssessmentContentType
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      - `[Id <String>]`: Unique identifier for the identity.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[ExpectedAssessment <String>]`: threatExpectedAssessment
  - `[RequestSource <String>]`: threatAssessmentRequestSource
  - `[Results <IMicrosoftGraphThreatAssessmentResult[]>]`: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
    - `[Id <String>]`: The unique idenfier for an entity. Read-only.
    - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
    - `[Message <String>]`: The result message for each threat assessment.
    - `[ResultType <String>]`: threatAssessmentResultType
  - `[Status <String>]`: threatAssessmentStatus

CREATEDBY <IMicrosoftGraphIdentitySet>: identitySet
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Application <IMicrosoftGraphIdentity>]`: identity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. Note that this might not always be available or up to date. For example, if a user changes their display name, the API might show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    - `[Id <String>]`: Unique identifier for the identity.
  - `[Device <IMicrosoftGraphIdentity>]`: identity
  - `[User <IMicrosoftGraphIdentity>]`: identity

RESULTS <IMicrosoftGraphThreatAssessmentResult[]>: A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[CreatedDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
  - `[Message <String>]`: The result message for each threat assessment.
  - `[ResultType <String>]`: threatAssessmentResultType

## RELATED LINKS

