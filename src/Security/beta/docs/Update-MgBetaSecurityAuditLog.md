---
external help file:
Module Name: Microsoft.Graph.Beta.Security
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.security/update-mgbetasecurityauditlog
schema: 2.0.0
---

# Update-MgBetaSecurityAuditLog

## SYNOPSIS
Update the navigation property auditLog in security

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgBetaSecurityAuditLog [-AdditionalProperties <Hashtable>] [-Id <String>]
 [-Queries <IMicrosoftGraphSecurityAuditLogQuery[]>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgBetaSecurityAuditLog -BodyParameter <IMicrosoftGraphSecurityAuditCoreRoot>
 [-ResponseHeadersVariable <String>] [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property auditLog in security

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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
auditCoreRoot
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditCoreRoot
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Queries
.
To construct, see NOTES section for QUERIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditLogQuery[]
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditCoreRoot

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphSecurityAuditCoreRoot

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`BODYPARAMETER <IMicrosoftGraphSecurityAuditCoreRoot>`: auditCoreRoot
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[Queries <IMicrosoftGraphSecurityAuditLogQuery[]>]`: 
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

`QUERIES <IMicrosoftGraphSecurityAuditLogQuery[]>`: .
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

## RELATED LINKS

