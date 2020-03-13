---
external help file:
Module Name: Microsoft.Graph.Identity.AuditLogs
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.auditlogs/update-mgauditlogdirectoryprovisioning
schema: 2.0.0
---

# Update-MgAuditLogDirectoryProvisioning

## SYNOPSIS
Update the navigation property directoryProvisioning in auditLogs

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgAuditLogDirectoryProvisioning -ProvisioningObjectSummaryId <String> [-Action <String>]
 [-ActivityDateTime <DateTime>] [-ChangeId <String>] [-CycleId <String>] [-DurationInMilliseconds <Int32>]
 [-Id <String>] [-InitiatedByDisplayName <String>] [-InitiatedById <String>]
 [-InitiatedByInitiatorType <String>] [-JobId <String>]
 [-ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]
 [-ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>] [-ServicePrincipalDisplayName <String>]
 [-ServicePrincipalId <String>] [-SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]
 [-SourceIdentityDisplayName <String>] [-SourceIdentityId <String>] [-SourceIdentityType <String>]
 [-SourceSystemDetails <IMicrosoftGraphDetailsInfo>] [-SourceSystemDisplayName <String>]
 [-SourceSystemId <String>] [-StatusInfoStatus <String>] [-TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]
 [-TargetIdentityDisplayName <String>] [-TargetIdentityId <String>] [-TargetIdentityType <String>]
 [-TargetSystemDetails <IMicrosoftGraphDetailsInfo>] [-TargetSystemDisplayName <String>]
 [-TargetSystemId <String>] [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Update
```
Update-MgAuditLogDirectoryProvisioning -ProvisioningObjectSummaryId <String>
 -BodyParameter <IMicrosoftGraphProvisioningObjectSummary> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentity
```
Update-MgAuditLogDirectoryProvisioning -InputObject <IIdentityAuditLogsIdentity>
 -BodyParameter <IMicrosoftGraphProvisioningObjectSummary> [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### UpdateViaIdentityExpanded
```
Update-MgAuditLogDirectoryProvisioning -InputObject <IIdentityAuditLogsIdentity> [-Action <String>]
 [-ActivityDateTime <DateTime>] [-ChangeId <String>] [-CycleId <String>] [-DurationInMilliseconds <Int32>]
 [-Id <String>] [-InitiatedByDisplayName <String>] [-InitiatedById <String>]
 [-InitiatedByInitiatorType <String>] [-JobId <String>]
 [-ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]
 [-ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>] [-ServicePrincipalDisplayName <String>]
 [-ServicePrincipalId <String>] [-SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]
 [-SourceIdentityDisplayName <String>] [-SourceIdentityId <String>] [-SourceIdentityType <String>]
 [-SourceSystemDetails <IMicrosoftGraphDetailsInfo>] [-SourceSystemDisplayName <String>]
 [-SourceSystemId <String>] [-StatusInfoStatus <String>] [-TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]
 [-TargetIdentityDisplayName <String>] [-TargetIdentityId <String>] [-TargetIdentityType <String>]
 [-TargetSystemDetails <IMicrosoftGraphDetailsInfo>] [-TargetSystemDisplayName <String>]
 [-TargetSystemId <String>] [-TenantId <String>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the navigation property directoryProvisioning in auditLogs

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

### -Action
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ActivityDateTime
.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
provisioningObjectSummary
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisioningObjectSummary
Parameter Sets: Update, UpdateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -ChangeId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -CycleId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -DurationInMilliseconds
.

```yaml
Type: System.Int32
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InitiatedByDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InitiatedById
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InitiatedByInitiatorType
initiatorType

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityAuditLogsIdentity
Parameter Sets: UpdateViaIdentity, UpdateViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -JobId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ModifiedProperties
.
To construct, see NOTES section for MODIFIEDPROPERTIES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphModifiedProperty[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningObjectSummaryId
key: provisioningObjectSummary-id of provisioningObjectSummary

```yaml
Type: System.String
Parameter Sets: Update, UpdateExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ProvisioningSteps
.
To construct, see NOTES section for PROVISIONINGSTEPS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisioningStep[]
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalDisplayName
The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ServicePrincipalId
Unique identifier for the identity.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceIdentityDetails
detailsInfo

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetailsInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceIdentityDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceIdentityId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceIdentityType
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceSystemDetails
detailsInfo

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetailsInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceSystemDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SourceSystemId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -StatusInfoStatus
provisioningResult

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetIdentityDetails
detailsInfo

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetailsInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetIdentityDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetIdentityId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetIdentityType
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetSystemDetails
detailsInfo

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphDetailsInfo
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetSystemDisplayName
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TargetSystemId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -TenantId
.

```yaml
Type: System.String
Parameter Sets: UpdateExpanded, UpdateViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityAuditLogsIdentity

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProvisioningObjectSummary

## OUTPUTS

### System.Boolean

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IMicrosoftGraphProvisioningObjectSummary>: provisioningObjectSummary
  - `[Id <String>]`: Read-only.
  - `[Action <String>]`: 
  - `[ActivityDateTime <DateTime?>]`: 
  - `[ChangeId <String>]`: 
  - `[CycleId <String>]`: 
  - `[DurationInMilliseconds <Int32?>]`: 
  - `[InitiatedByDisplayName <String>]`: 
  - `[InitiatedById <String>]`: 
  - `[InitiatedByInitiatorType <String>]`: initiatorType
  - `[JobId <String>]`: 
  - `[ModifiedProperties <IMicrosoftGraphModifiedProperty[]>]`: 
    - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
    - `[NewValue <String>]`: Indicates the updated value for the propery.
    - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.
  - `[ProvisioningSteps <IMicrosoftGraphProvisioningStep[]>]`: 
    - `[Description <String>]`: 
    - `[Details <IMicrosoftGraphDetailsInfo>]`: detailsInfo
    - `[Name <String>]`: 
    - `[ProvisioningStepType <String>]`: provisioningStepType
    - `[Status <String>]`: provisioningResult
  - `[ServicePrincipalDisplayName <String>]`: The identity's display name. Note that this may not always be available or up to date. For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  - `[ServicePrincipalId <String>]`: Unique identifier for the identity.
  - `[SourceIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceIdentityDisplayName <String>]`: 
  - `[SourceIdentityId <String>]`: 
  - `[SourceIdentityType <String>]`: 
  - `[SourceSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[SourceSystemDisplayName <String>]`: 
  - `[SourceSystemId <String>]`: 
  - `[StatusInfoStatus <String>]`: provisioningResult
  - `[TargetIdentityDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetIdentityDisplayName <String>]`: 
  - `[TargetIdentityId <String>]`: 
  - `[TargetIdentityType <String>]`: 
  - `[TargetSystemDetails <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[TargetSystemDisplayName <String>]`: 
  - `[TargetSystemId <String>]`: 
  - `[TenantId <String>]`: 

#### INPUTOBJECT <IIdentityAuditLogsIdentity>: Identity Parameter
  - `[DirectoryAuditId <String>]`: key: directoryAudit-id of directoryAudit
  - `[ProvisioningObjectSummaryId <String>]`: key: provisioningObjectSummary-id of provisioningObjectSummary
  - `[RestrictedSignInId <String>]`: key: restrictedSignIn-id of restrictedSignIn
  - `[SignInId <String>]`: key: signIn-id of signIn

#### MODIFIEDPROPERTIES <IMicrosoftGraphModifiedProperty[]>: .
  - `[DisplayName <String>]`: Indicates the property name of the target attribute that was changed.
  - `[NewValue <String>]`: Indicates the updated value for the propery.
  - `[OldValue <String>]`: Indicates the previous value (before the update) for the property.

#### PROVISIONINGSTEPS <IMicrosoftGraphProvisioningStep[]>: .
  - `[Description <String>]`: 
  - `[Details <IMicrosoftGraphDetailsInfo>]`: detailsInfo
  - `[Name <String>]`: 
  - `[ProvisioningStepType <String>]`: provisioningStepType
  - `[Status <String>]`: provisioningResult

## RELATED LINKS

