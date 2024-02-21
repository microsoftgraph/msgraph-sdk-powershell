---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/new-mgbetasecurityauditlogquery
schema: 2.0.0
---

# New-MgBetaSecurityAuditLogQuery

## SYNOPSIS
Create new navigation property to queries for security

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaSecurityAuditLogQuery [-AdditionalProperties <Hashtable>] [-AdministrativeUnitIdFilters <String[]>]
 [-DisplayName <String>] [-FilterEndDateTime <DateTime>] [-FilterStartDateTime <DateTime>] [-Id <String>]
 [-IPAddressFilters <String[]>] [-KeywordFilter <String>] [-ObjectIdFilters <String[]>]
 [-OperationFilters <String[]>] [-Records <IMicrosoftGraphSecurityAuditLogRecord[]>]
 [-RecordTypeFilters <String[]>] [-ResponseHeadersVariable <String>] [-ServiceFilters <String[]>]
 [-Status <String>] [-UserPrincipalNameFilters <String[]>] [-Headers <IDictionary>] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Create
```
New-MgBetaSecurityAuditLogQuery -BodyParameter <IMicrosoftGraphSecurityAuditLogQuery>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to queries for security

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

### -AdministrativeUnitIdFilters
The administrative units tagged to an audit log record.

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

### -BodyParameter
auditLogQuery
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditLogQuery
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The display name of the saved audit log query.

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

### -FilterEndDateTime
The end date of the date range in the query.

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

### -FilterStartDateTime
The start date of the date range in the query.

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

### -IPAddressFilters
The IP address of the device that was used when the activity was logged.

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

### -KeywordFilter
Free text field to search non-indexed properties of the audit log.

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

### -ObjectIdFilters
For SharePoint and OneDrive for Business activity, the full path name of the file or folder accessed by the user.
For Exchange admin audit logging, the name of the object that was modified by the cmdlet.

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

### -OperationFilters
The name of the user or admin activity.
For a description of the most common operations/activities, see Search the audit log in the Office 365 Protection Center.

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

### -Records
An individual audit log record.
To construct, see NOTES section for RECORDS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditLogRecord[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RecordTypeFilters
.

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

### -ServiceFilters
.

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

### -Status
auditLogQueryStatus

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

### -UserPrincipalNameFilters
The UPN (user principal name) of the user who performed the action (specified in the operation property) that resulted in the record being logged; for example, myname@mydomain_name.

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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditLogQuery

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditLogQuery

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityAuditLogQuery>`: auditLogQuery
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdministrativeUnitIdFilters <String[]>]`: The administrative units tagged to an audit log record.
  - `[DisplayName <String>]`: The display name of the saved audit log query.
  - `[FilterEndDateTime <DateTime?>]`: The end date of the date range in the query.
  - `[FilterStartDateTime <DateTime?>]`: The start date of the date range in the query.
  - `[IPAddressFilters <String[]>]`: The IP address of the device that was used when the activity was logged.
  - `[KeywordFilter <String>]`: Free text field to search non-indexed properties of the audit log.
  - `[ObjectIdFilters <String[]>]`: For SharePoint and OneDrive for Business activity, the full path name of the file or folder accessed by the user. For Exchange admin audit logging, the name of the object that was modified by the cmdlet.
  - `[OperationFilters <String[]>]`: The name of the user or admin activity. For a description of the most common operations/activities, see Search the audit log in the Office 365 Protection Center.
  - `[RecordTypeFilters <String[]>]`: 
  - `[Records <IMicrosoftGraphSecurityAuditLogRecord[]>]`: An individual audit log record.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AdministrativeUnits <String[]>]`: The administrative units tagged to an audit log record.
    - `[AuditData <IMicrosoftGraphSecurityAuditData>]`: auditData
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AuditLogRecordType <String>]`: auditLogRecordType
    - `[ClientIP <String>]`: The IP address of the device used when the activity was logged. The IP address is displayed in either an IPv4 or IPv6 address format.
    - `[CreatedDateTime <DateTime?>]`: The date and time in UTC when the user performed the activity.
    - `[ObjectId <String>]`: For Exchange admin audit logging, the name of the object modified by the cmdlet. For SharePoint activity, the full URL path name of the file or folder accessed by a user. For Microsoft Entra activity, the name of the user account that was modified.
    - `[Operation <String>]`: The name of the user or admin activity.
    - `[OrganizationId <String>]`: The GUID for your organization.
    - `[Service <String>]`: The Microsoft 365 service where the activity occurred.
    - `[UserId <String>]`: The user who performed the action (specified in the Operation property) that resulted in the record being logged. Audit records for activity performed by system accounts (such as SHAREPOINT/system or NT AUTHORITY/SYSTEM) are also included in the audit log. Another common value for the UserId property is app@sharepoint. It indicates that the 'user' who performed the activity was an application with the necessary permissions in SharePoint to perform organization-wide actions (such as searching a SharePoint site or OneDrive account) on behalf of a user, admin, or service.
    - `[UserPrincipalName <String>]`: UPN of the user who performed the action.
    - `[UserType <String>]`: auditLogUserType
  - `[ServiceFilters <String[]>]`: 
  - `[Status <String>]`: auditLogQueryStatus
  - `[UserPrincipalNameFilters <String[]>]`: The UPN (user principal name) of the user who performed the action (specified in the operation property) that resulted in the record being logged; for example, myname@mydomain_name.

`RECORDS <IMicrosoftGraphSecurityAuditLogRecord[]>`: An individual audit log record.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AdministrativeUnits <String[]>]`: The administrative units tagged to an audit log record.
  - `[AuditData <IMicrosoftGraphSecurityAuditData>]`: auditData
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AuditLogRecordType <String>]`: auditLogRecordType
  - `[ClientIP <String>]`: The IP address of the device used when the activity was logged. The IP address is displayed in either an IPv4 or IPv6 address format.
  - `[CreatedDateTime <DateTime?>]`: The date and time in UTC when the user performed the activity.
  - `[ObjectId <String>]`: For Exchange admin audit logging, the name of the object modified by the cmdlet. For SharePoint activity, the full URL path name of the file or folder accessed by a user. For Microsoft Entra activity, the name of the user account that was modified.
  - `[Operation <String>]`: The name of the user or admin activity.
  - `[OrganizationId <String>]`: The GUID for your organization.
  - `[Service <String>]`: The Microsoft 365 service where the activity occurred.
  - `[UserId <String>]`: The user who performed the action (specified in the Operation property) that resulted in the record being logged. Audit records for activity performed by system accounts (such as SHAREPOINT/system or NT AUTHORITY/SYSTEM) are also included in the audit log. Another common value for the UserId property is app@sharepoint. It indicates that the 'user' who performed the activity was an application with the necessary permissions in SharePoint to perform organization-wide actions (such as searching a SharePoint site or OneDrive account) on behalf of a user, admin, or service.
  - `[UserPrincipalName <String>]`: UPN of the user who performed the action.
  - `[UserType <String>]`: auditLogUserType

## RELATED LINKS

