---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecuritythreatsubmissionemailthreat
schema: 2.0.0
---

# New-MgBetaSecurityThreatSubmissionEmailThreat

## SYNOPSIS
Create a new emailThreatSubmission object.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityThreatSubmissionEmailThreat [-AdditionalProperties <Hashtable>]
 [-AdminReview <IMicrosoftGraphSecuritySubmissionAdminReview>]
 [-AttackSimulationInfo <IMicrosoftGraphSecurityAttackSimulationInfo>] [-Category <String>]
 [-ClientSource <String>] [-ContentType <String>] [-CreatedBy <IMicrosoftGraphSecuritySubmissionUserIdentity>]
 [-CreatedDateTime <DateTime>] [-Id <String>] [-InternetMessageId <String>] [-OriginalCategory <String>]
 [-ReceivedDateTime <DateTime>] [-RecipientEmailAddress <String>] [-ResponseHeadersVariable <String>]
 [-Result <IMicrosoftGraphSecuritySubmissionResult>] [-Sender <String>] [-SenderIP <String>]
 [-Source <String>] [-Status <String>] [-Subject <String>]
 [-TenantAllowOrBlockListAction <IMicrosoftGraphSecurityTenantAllowOrBlockListAction>] [-TenantId <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityThreatSubmissionEmailThreat -BodyParameter <IMicrosoftGraphSecurityEmailThreatSubmission>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create a new emailThreatSubmission object.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"@odata.type" = "#microsoft.graph.emailUrlThreatSubmission"
	Category = "spam"
	RecipientEmailAddress = "tifc@a830edad9050849EQTPWBJZXODQ.onmicrosoft.com"
	MessageUrl = "https://graph.microsoft.com/beta/users/c52ce8db-3e4b-4181-93c4-7d6b6bffaf60/messages/AAMkADU3MWUxOTU0LWNlOTEt="
}
New-MgBetaSecurityThreatSubmissionEmailThreat -BodyParameter $params
```



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

### -AdminReview
submissionAdminReview
To construct, see NOTES section for ADMINREVIEW properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySubmissionAdminReview
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AttackSimulationInfo
attackSimulationInfo
To construct, see NOTES section for ATTACKSIMULATIONINFO properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAttackSimulationInfo
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
emailThreatSubmission
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityEmailThreatSubmission
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Category
submissionCategory

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

### -ClientSource
submissionClientSource

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
submissionContentType

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
submissionUserIdentity
To construct, see NOTES section for CREATEDBY properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySubmissionUserIdentity
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
Specifies when the threat submission was created.
Supports $filter = createdDateTime ge 2022-01-01T00:00:00Z and createdDateTime lt 2022-01-02T00:00:00Z.

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

### -InternetMessageId
Specifies the internet message ID of the email being submitted.
This information is present in the email header.

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

### -OriginalCategory
submissionCategory

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

### -ReceivedDateTime
Specifies the date and time stamp when the email was received.

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

### -RecipientEmailAddress
Specifies the email address (in smtp format) of the recipient who received the email.

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

### -Result
submissionResult
To construct, see NOTES section for RESULT properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecuritySubmissionResult
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Sender
Specifies the email address of the sender.

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

### -SenderIP
Specifies the IP address of the sender.

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

### -Source
submissionSource

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
longRunningOperationStatus

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

### -Subject
Specifies the subject of the email.

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

### -TenantAllowOrBlockListAction
tenantAllowOrBlockListAction
To construct, see NOTES section for TENANTALLOWORBLOCKLISTACTION properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityTenantAllowOrBlockListAction
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -TenantId
Indicates the tenant id of the submitter.
Not required when created using a POST operation.
It's extracted from the token of the post API call.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityEmailThreatSubmission

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityEmailThreatSubmission

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`ADMINREVIEW <IMicrosoftGraphSecuritySubmissionAdminReview>`: submissionAdminReview
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[ReviewBy <String>]`: Specifies who reviewed the email. The identification is an email ID or other identity strings.
  - `[ReviewDateTime <DateTime?>]`: Specifies the date time when the review occurred.
  - `[ReviewResult <String>]`: submissionResultCategory

`ATTACKSIMULATIONINFO <IMicrosoftGraphSecurityAttackSimulationInfo>`: attackSimulationInfo
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AttackSimDateTime <DateTime?>]`: The date and time of the attack simulation.
  - `[AttackSimDurationTime <TimeSpan?>]`: The duration (in time) for the attack simulation.
  - `[AttackSimId <String>]`: The activity ID for the attack simulation.
  - `[AttackSimUserId <String>]`: The unique identifier for the user who got the attack simulation email.

`BODYPARAMETER <IMicrosoftGraphSecurityEmailThreatSubmission>`: emailThreatSubmission
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AdminReview <IMicrosoftGraphSecuritySubmissionAdminReview>]`: submissionAdminReview
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[ReviewBy <String>]`: Specifies who reviewed the email. The identification is an email ID or other identity strings.
    - `[ReviewDateTime <DateTime?>]`: Specifies the date time when the review occurred.
    - `[ReviewResult <String>]`: submissionResultCategory
  - `[Category <String>]`: submissionCategory
  - `[ClientSource <String>]`: submissionClientSource
  - `[ContentType <String>]`: submissionContentType
  - `[CreatedBy <IMicrosoftGraphSecuritySubmissionUserIdentity>]`: submissionUserIdentity
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
    - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Email <String>]`: The email of user who is making the submission when logged in (delegated token case).
  - `[CreatedDateTime <DateTime?>]`: Specifies when the threat submission was created. Supports $filter = createdDateTime ge 2022-01-01T00:00:00Z and createdDateTime lt 2022-01-02T00:00:00Z.
  - `[Result <IMicrosoftGraphSecuritySubmissionResult>]`: submissionResult
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Category <String>]`: submissionResultCategory
    - `[Detail <String>]`: submissionResultDetail
    - `[DetectedFiles <IMicrosoftGraphSecuritySubmissionDetectedFile[]>]`: Specifies the files detected by Microsoft in the submitted emails.
      - `[FileHash <String>]`: The file hash.
      - `[FileName <String>]`: The file name.
    - `[DetectedUrls <String[]>]`: Specifies the URLs detected by Microsoft in the submitted email.
    - `[UserMailboxSetting <String>]`: userMailboxSetting
  - `[Source <String>]`: submissionSource
  - `[Status <String>]`: longRunningOperationStatus
  - `[TenantId <String>]`: Indicates the tenant id of the submitter. Not required when created using a POST operation. It's extracted from the token of the post API call.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AttackSimulationInfo <IMicrosoftGraphSecurityAttackSimulationInfo>]`: attackSimulationInfo
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AttackSimDateTime <DateTime?>]`: The date and time of the attack simulation.
    - `[AttackSimDurationTime <TimeSpan?>]`: The duration (in time) for the attack simulation.
    - `[AttackSimId <String>]`: The activity ID for the attack simulation.
    - `[AttackSimUserId <String>]`: The unique identifier for the user who got the attack simulation email.
  - `[InternetMessageId <String>]`: Specifies the internet message ID of the email being submitted. This information is present in the email header.
  - `[OriginalCategory <String>]`: submissionCategory
  - `[ReceivedDateTime <DateTime?>]`: Specifies the date and time stamp when the email was received.
  - `[RecipientEmailAddress <String>]`: Specifies the email address (in smtp format) of the recipient who received the email.
  - `[Sender <String>]`: Specifies the email address of the sender.
  - `[SenderIP <String>]`: Specifies the IP address of the sender.
  - `[Subject <String>]`: Specifies the subject of the email.
  - `[TenantAllowOrBlockListAction <IMicrosoftGraphSecurityTenantAllowOrBlockListAction>]`: tenantAllowOrBlockListAction
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Action <String>]`: tenantAllowBlockListAction
    - `[ExpirationDateTime <DateTime?>]`: Specifies when the tenant allow-block-list expires in date time.
    - `[Note <String>]`: Specifies the note added to the tenant allow-or-block list entry in the format of string.
    - `[Results <IMicrosoftGraphSecurityTenantAllowBlockListEntryResult[]>]`: Contains the result of the submission that lead to the tenant allow-block-list entry creation.
      - `[EntryType <String>]`: tenantAllowBlockListEntryType
      - `[ExpirationDateTime <DateTime?>]`: Specifies the date and time when the entry expires.
      - `[Identity <String>]`: Specifies the identity of the entry generated by the tenant allow block list system.
      - `[Status <String>]`: longRunningOperationStatus
      - `[Value <String>]`: Specifies the value of the created tenant allow block list entry.

`CREATEDBY <IMicrosoftGraphSecuritySubmissionUserIdentity>`: submissionUserIdentity
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
  - `[Id <String>]`: The identifier of the identity. This property is read-only.
  - `[Email <String>]`: The email of user who is making the submission when logged in (delegated token case).

`RESULT <IMicrosoftGraphSecuritySubmissionResult>`: submissionResult
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Category <String>]`: submissionResultCategory
  - `[Detail <String>]`: submissionResultDetail
  - `[DetectedFiles <IMicrosoftGraphSecuritySubmissionDetectedFile[]>]`: Specifies the files detected by Microsoft in the submitted emails.
    - `[FileHash <String>]`: The file hash.
    - `[FileName <String>]`: The file name.
  - `[DetectedUrls <String[]>]`: Specifies the URLs detected by Microsoft in the submitted email.
  - `[UserMailboxSetting <String>]`: userMailboxSetting

`TENANTALLOWORBLOCKLISTACTION <IMicrosoftGraphSecurityTenantAllowOrBlockListAction>`: tenantAllowOrBlockListAction
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Action <String>]`: tenantAllowBlockListAction
  - `[ExpirationDateTime <DateTime?>]`: Specifies when the tenant allow-block-list expires in date time.
  - `[Note <String>]`: Specifies the note added to the tenant allow-or-block list entry in the format of string.
  - `[Results <IMicrosoftGraphSecurityTenantAllowBlockListEntryResult[]>]`: Contains the result of the submission that lead to the tenant allow-block-list entry creation.
    - `[EntryType <String>]`: tenantAllowBlockListEntryType
    - `[ExpirationDateTime <DateTime?>]`: Specifies the date and time when the entry expires.
    - `[Identity <String>]`: Specifies the identity of the entry generated by the tenant allow block list system.
    - `[Status <String>]`: longRunningOperationStatus
    - `[Value <String>]`: Specifies the value of the created tenant allow block list entry.

## RELATED LINKS

