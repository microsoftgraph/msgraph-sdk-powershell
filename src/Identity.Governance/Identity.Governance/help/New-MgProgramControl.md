---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogramcontrol
schema: 2.0.0
---

# New-MgProgramControl

## SYNOPSIS
Add new entity to programControls

## SYNTAX

### CreateExpanded (Default)
```
New-MgProgramControl [-ProgramId <String>] [-AdditionalProperties <Hashtable>] [-ControlId <String>]
 [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-Owner <IMicrosoftGraphUserIdentity>] [-Program <IMicrosoftGraphProgram>]
 [-Resource <IMicrosoftGraphProgramResource>] [-Status <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgProgramControl [-ProgramId <String>] -InputObject <IIdentityGovernanceIdentity>
 [-AdditionalProperties <Hashtable>] [-ControlId <String>] [-ControlTypeId <String>]
 [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>] [-Owner <IMicrosoftGraphUserIdentity>]
 [-Program <IMicrosoftGraphProgram>] [-Resource <IMicrosoftGraphProgramResource>] [-Status <String>] [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### CreateExpanded1
```
New-MgProgramControl -ProgramId <String> [-AdditionalProperties <Hashtable>] [-ControlId <String>]
 [-ControlTypeId <String>] [-CreatedDateTime <DateTime>] [-DisplayName <String>] [-Id <String>]
 [-Owner <IMicrosoftGraphUserIdentity>] [-Program <IMicrosoftGraphProgram>]
 [-Resource <IMicrosoftGraphProgramResource>] [-Status <String>] [-ProgramId1 <String>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create1
```
New-MgProgramControl -ProgramId <String> -BodyParameter <IMicrosoftGraphProgramControl> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgProgramControl -InputObject <IIdentityGovernanceIdentity> -BodyParameter <IMicrosoftGraphProgramControl>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgProgramControl -BodyParameter <IMicrosoftGraphProgramControl> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to programControls

## EXAMPLES

### EXAMPLE 1
```
{{ Add code here }}
```

{{ Add output here }}

### EXAMPLE 2
```
{{ Add code here }}
```

{{ Add output here }}

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
programControl
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphProgramControl
Parameter Sets: Create1, CreateViaIdentity, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ControlId
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ControlTypeId
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DisplayName
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Id
Read-only.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: IIdentityGovernanceIdentity
Parameter Sets: CreateViaIdentityExpanded, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Owner
userIdentity
To construct, see NOTES section for OWNER properties and create a hash table.

```yaml
Type: IMicrosoftGraphUserIdentity
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Program
program
To construct, see NOTES section for PROGRAM properties and create a hash table.

```yaml
Type: IMicrosoftGraphProgram
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramId
key: id of program

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

```yaml
Type: String
Parameter Sets: CreateExpanded1, Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProgramId1
.

```yaml
Type: String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Resource
programResource
To construct, see NOTES section for RESOURCE properties and create a hash table.

```yaml
Type: IMicrosoftGraphProgramResource
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Status
.

```yaml
Type: String
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded, CreateExpanded1
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
Type: SwitchParameter
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
Type: SwitchParameter
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

### Microsoft.Graph.PowerShell.Models.IIdentityGovernanceIdentity
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphProgramControl
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphProgramControl\>: programControl
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[ControlId \<String\>\]: 
  \[ControlTypeId \<String\>\]: 
  \[CreatedDateTime \<DateTime?\>\]: 
  \[DisplayName \<String\>\]: 
  \[Owner \<IMicrosoftGraphUserIdentity\>\]: userIdentity
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
    \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
  \[Program \<IMicrosoftGraphProgram\>\]: program
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Id \<String\>\]: Read-only.
    \[Controls \<IMicrosoftGraphProgramControl\[\]\>\]: 
    \[Description \<String\>\]: 
    \[DisplayName \<String\>\]: 
  \[ProgramId \<String\>\]: 
  \[Resource \<IMicrosoftGraphProgramResource\>\]: programResource
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
    \[Id \<String\>\]: Unique identifier for the identity.
    \[Type \<String\>\]: 
  \[Status \<String\>\]: 

INPUTOBJECT \<IIdentityGovernanceIdentity\>: Identity Parameter
  \[AccessPackageAssignmentId \<String\>\]: key: id of accessPackageAssignment
  \[AccessPackageAssignmentPolicyId \<String\>\]: key: id of accessPackageAssignmentPolicy
  \[AccessPackageAssignmentRequestId \<String\>\]: key: id of accessPackageAssignmentRequest
  \[AccessPackageAssignmentResourceRoleId \<String\>\]: key: id of accessPackageAssignmentResourceRole
  \[AccessPackageCatalogId \<String\>\]: key: id of accessPackageCatalog
  \[AccessPackageId \<String\>\]: key: id of accessPackage
  \[AccessPackageResourceId \<String\>\]: key: id of accessPackageResource
  \[AccessPackageResourceRequestId \<String\>\]: key: id of accessPackageResourceRequest
  \[AccessPackageResourceRoleId \<String\>\]: key: id of accessPackageResourceRole
  \[AccessPackageResourceRoleScopeId \<String\>\]: key: id of accessPackageResourceRoleScope
  \[AccessPackageResourceScopeId \<String\>\]: key: id of accessPackageResourceScope
  \[AccessReviewDecisionId \<String\>\]: key: id of accessReviewDecision
  \[AccessReviewId \<String\>\]: key: id of accessReview
  \[AccessReviewId1 \<String\>\]: key: id of accessReview
  \[AccessReviewInstanceId \<String\>\]: key: id of accessReviewInstance
  \[AccessReviewReviewerId \<String\>\]: key: id of accessReviewReviewer
  \[AccessReviewScheduleDefinitionId \<String\>\]: key: id of accessReviewScheduleDefinition
  \[AgreementAcceptanceId \<String\>\]: key: id of agreementAcceptance
  \[AgreementFileLocalizationId \<String\>\]: key: id of agreementFileLocalization
  \[AgreementFileVersionId \<String\>\]: key: id of agreementFileVersion
  \[AgreementId \<String\>\]: key: id of agreement
  \[BusinessFlowTemplateId \<String\>\]: key: id of businessFlowTemplate
  \[ConnectedOrganizationId \<String\>\]: key: id of connectedOrganization
  \[DirectoryObjectId \<String\>\]: key: id of directoryObject
  \[GovernanceResourceId \<String\>\]: key: id of governanceResource
  \[GovernanceRoleAssignmentId \<String\>\]: key: id of governanceRoleAssignment
  \[GovernanceRoleAssignmentRequestId \<String\>\]: key: id of governanceRoleAssignmentRequest
  \[GovernanceRoleDefinitionId \<String\>\]: key: id of governanceRoleDefinition
  \[GovernanceRoleSettingId \<String\>\]: key: id of governanceRoleSetting
  \[PrivilegedAccessId \<String\>\]: key: id of privilegedAccess
  \[PrivilegedApprovalId \<String\>\]: key: id of privilegedApproval
  \[PrivilegedOperationEventId \<String\>\]: key: id of privilegedOperationEvent
  \[PrivilegedRoleAssignmentId \<String\>\]: key: id of privilegedRoleAssignment
  \[PrivilegedRoleAssignmentRequestId \<String\>\]: key: id of privilegedRoleAssignmentRequest
  \[PrivilegedRoleId \<String\>\]: key: id of privilegedRole
  \[ProgramControlId \<String\>\]: key: id of programControl
  \[ProgramControlTypeId \<String\>\]: key: id of programControlType
  \[ProgramId \<String\>\]: key: id of program
  \[UserId \<String\>\]: key: id of user

OWNER \<IMicrosoftGraphUserIdentity\>: userIdentity
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  \[Id \<String\>\]: Unique identifier for the identity.
  \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
  \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.

PROGRAM \<IMicrosoftGraphProgram\>: program
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Id \<String\>\]: Read-only.
  \[Controls \<IMicrosoftGraphProgramControl\[\]\>\]: 
    \[Id \<String\>\]: Read-only.
    \[ControlId \<String\>\]: 
    \[ControlTypeId \<String\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[DisplayName \<String\>\]: 
    \[Owner \<IMicrosoftGraphUserIdentity\>\]: userIdentity
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[IPAddress \<String\>\]: Indicates the client IP address used by user performing the activity (audit log only).
      \[UserPrincipalName \<String\>\]: The userPrincipalName attribute of the user.
    \[Program \<IMicrosoftGraphProgram\>\]: program
    \[ProgramId \<String\>\]: 
    \[Resource \<IMicrosoftGraphProgramResource\>\]: programResource
      \[(Any) \<Object\>\]: This indicates any property can be added to this object.
      \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
      \[Id \<String\>\]: Unique identifier for the identity.
      \[Type \<String\>\]: 
    \[Status \<String\>\]: 
  \[Description \<String\>\]: 
  \[DisplayName \<String\>\]: 

RESOURCE \<IMicrosoftGraphProgramResource\>: programResource
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[DisplayName \<String\>\]: The identity's display name.
Note that this may not always be available or up to date.
For example, if a user changes their display name, the API may show the new value in a future response, but the items associated with the user won't show up as having changed when using delta.
  \[Id \<String\>\]: Unique identifier for the identity.
  \[Type \<String\>\]:

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogramcontrol](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgprogramcontrol)

