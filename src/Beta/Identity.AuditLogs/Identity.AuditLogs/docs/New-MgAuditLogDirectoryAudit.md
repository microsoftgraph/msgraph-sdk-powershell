---
external help file:
Module Name: Microsoft.Graph.Identity.AuditLogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.auditlogs/new-mgauditlogdirectoryaudit
schema: 2.0.0
---

# New-MgAuditLogDirectoryAudit

## SYNOPSIS
Create new navigation property to directoryAudits for auditLogs

## SYNTAX

### CreateExpanded (Default)
```
New-MgAuditLogDirectoryAudit [-ActivityDateTime <DateTime>] [-ActivityDisplayName <String>]
 [-AdditionalDetails <IMicrosoftGraphKeyValue[]>] [-AppDisplayName <String>] [-AppId <String>]
 [-AppServicePrincipalId <String>] [-AppServicePrincipalName <String>] [-Category <String>]
 [-CorrelationId <String>] [-Id <String>] [-LoggedByService <String>] [-OperationType <String>]
 [-Result <String>] [-ResultReason <String>] [-TargetResources <IMicrosoftGraphTargetResource[]>]
 [-UserDisplayName <String>] [-UserId <String>] [-UserIPAddress <String>] [-UserPrincipalName <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgAuditLogDirectoryAudit -BodyParameter <IMicrosoftGraphDirectoryAudit> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to directoryAudits for auditLogs

## EXAMPLES

### Example 1: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

### Example 2: {{ Add title here }}
```powershell
PS C:\> {{ Add code here }}

{{ Add output here }}
```

{{ Add description here }}

## PARAMETERS

### -ActivityDateTime
Indicates the date and time the activity was performed.
The Timestamp type is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ActivityDisplayName
Indicates the activity name or the operation name (examples: 'Create User' and 'Add member to group').
For full list, see Azure AD activity list.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AdditionalDetails
Indicates additional details on the activity.
To construct, see NOTES section for ADDITIONALDETAILS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyValue[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppDisplayName
Refers to the Application Name displayed in the Azure Portal.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppId
Refers to the Unique GUID representing Application Id in the Azure Active Directory.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppServicePrincipalId
Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -AppServicePrincipalName
Refers to the Service Principal Name is the Application name in the tenant.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
directoryAudit
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryAudit
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Category
Indicates which resource category that's targeted by the activity.
(For example: User Management, Group Management etc..)

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CorrelationId
Indicates a unique ID that helps correlate activities that span across various services.
Can be used to trace logs across services.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Id
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
Dynamic: False
```

### -LoggedByService
Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -OperationType
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Result
operationResult

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResultReason
Describes cause of 'failure' or 'timeout' results.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetResources
Indicates information on which resource was changed due to the activity.
Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
To construct, see NOTES section for TARGETRESOURCES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTargetResource[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserDisplayName
The identity's display name.
Note that this may not always be available or up-to-date.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserIPAddress
Indicates the client IP address used by user performing the activity (audit log only).

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -UserPrincipalName
The userPrincipalName attribute of the user.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
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
Dynamic: False
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
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryAudit

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDirectoryAudit

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### ADDITIONALDETAILS <IMicrosoftGraphKeyValue[]>: Indicates additional details on the activity.
  - `[Key <String>]`: Key for the key-value pair.
  - `[Value <String>]`: Value for the key-value pair.

#### BODYPARAMETER <IMicrosoftGraphDirectoryAudit>: directoryAudit
  - `[Id <String>]`: Read-only.
  - `[ActivityDateTime <DateTime?>]`: Indicates the date and time the activity was performed. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[ActivityDisplayName <String>]`: Indicates the activity name or the operation name (examples: 'Create User' and 'Add member to group'). For full list, see Azure AD activity list.
  - `[AdditionalDetails <IMicrosoftGraphKeyValue[]>]`: Indicates additional details on the activity.
    - `[Key <String>]`: Key for the key-value pair.
    - `[Value <String>]`: Value for the key-value pair.
  - `[AppDisplayName <String>]`: Refers to the Application Name displayed in the Azure Portal.
  - `[AppId <String>]`: Refers to the Unique GUID representing Application Id in the Azure Active Directory.
  - `[AppServicePrincipalId <String>]`: Refers to the Unique GUID indicating Service Principal Id in Azure Active Directory for the corresponding App.
  - `[AppServicePrincipalName <String>]`: Refers to the Service Principal Name is the Application name in the tenant.
  - `[Category <String>]`: Indicates which resource category that's targeted by the activity. (For example: User Management, Group Management etc..)
  - `[CorrelationId <String>]`: Indicates a unique ID that helps correlate activities that span across various services. Can be used to trace logs across services.
  - `[LoggedByService <String>]`: Indicates information on which service initiated the activity (For example: Self-service Password Management, Core Directory, B2C, Invited Users, Microsoft Identity Manager, Privileged Identity Management.
  - `[OperationType <String>]`: 
  - `[Result <String>]`: operationResult
  - `[ResultReason <String>]`: Describes cause of 'failure' or 'timeout' results.
  - `[TargetResources <IMicrosoftGraphTargetResource[]>]`: Indicates information on which resource was changed due to the activity. Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
    - `[DisplayName <String>]`: Indicates the visible name defined for the resource. Typically specified when the resource is created.
    - `[GroupType <String>]`: groupType
    - `[Id <String>]`: Indicates the unique ID of the resource.
    - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.
      - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
      - `[NewValue <String>]`: Indicates the updated value for the propery.
      - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
    - `[Type <String>]`: Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.
    - `[UserPrincipalName <String>]`: When type is set to User, this includes the user name that initiated the action; null for other types.
  - `[UserDisplayName <String>]`: The identity's display name. Note that this may not always be available or up-to-date.
  - `[UserIPAddress <String>]`: Indicates the client IP address used by user performing the activity (audit log only).
  - `[UserId <String>]`: Unique identifier for the identity.
  - `[UserPrincipalName <String>]`: The userPrincipalName attribute of the user.

#### TARGETRESOURCES <IMicrosoftGraphTargetResource[]>: Indicates information on which resource was changed due to the activity. Target Resource Type can be User, Device, Directory, App, Role, Group, Policy or Other.
  - `[DisplayName <String>]`: Indicates the visible name defined for the resource. Typically specified when the resource is created.
  - `[GroupType <String>]`: groupType
  - `[Id <String>]`: Indicates the unique ID of the resource.
  - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: Indicates name, old value and new value of each attribute that changed. Property values depend on the operation type.
    - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
    - `[NewValue <String>]`: Indicates the updated value for the propery.
    - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
  - `[Type <String>]`: Describes the resource type.  Example values include Application, Group, ServicePrincipal, and User.
  - `[UserPrincipalName <String>]`: When type is set to User, this includes the user name that initiated the action; null for other types.

## RELATED LINKS

