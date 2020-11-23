---
external help file: Microsoft.Graph.Identity.Governance-help.xml
Module Name: Microsoft.Graph.Identity.Governance
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreementfilelocalization
schema: 2.0.0
---

# New-MgAgreementFileLocalization

## SYNOPSIS
Create new navigation property to localizations for agreements

## SYNTAX

### CreateExpanded (Default)
```
New-MgAgreementFileLocalization -AgreementId <String> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-FileData <IMicrosoftGraphAgreementFileData>] [-FileName <String>]
 [-Id <String>] [-IsDefault] [-IsMajorVersion] [-Language <String>]
 [-Versions <IMicrosoftGraphAgreementFileVersion[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### Create
```
New-MgAgreementFileLocalization -AgreementId <String> -BodyParameter <IMicrosoftGraphAgreementFileLocalization>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentityExpanded
```
New-MgAgreementFileLocalization -InputObject <IIdentityGovernanceIdentity> [-AdditionalProperties <Hashtable>]
 [-CreatedDateTime <DateTime>] [-FileData <IMicrosoftGraphAgreementFileData>] [-FileName <String>]
 [-Id <String>] [-IsDefault] [-IsMajorVersion] [-Language <String>]
 [-Versions <IMicrosoftGraphAgreementFileVersion[]>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### CreateViaIdentity
```
New-MgAgreementFileLocalization -InputObject <IIdentityGovernanceIdentity>
 -BodyParameter <IMicrosoftGraphAgreementFileLocalization> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to localizations for agreements

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
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgreementId
key: id of agreement

```yaml
Type: String
Parameter Sets: CreateExpanded, Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
agreementFileLocalization
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileLocalization
Parameter Sets: Create, CreateViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -CreatedDateTime
.

```yaml
Type: DateTime
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileData
agreementFileData
To construct, see NOTES section for FILEDATA properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileData
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -FileName
.

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

### -Id
Read-only.

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

### -IsDefault
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsMajorVersion
.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Language
.

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

### -Versions
.
To construct, see NOTES section for VERSIONS properties and create a hash table.

```yaml
Type: IMicrosoftGraphAgreementFileVersion[]
Parameter Sets: CreateExpanded, CreateViaIdentityExpanded
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
### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreementFileLocalization
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAgreementFileLocalization
## NOTES
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties.
For information on hash tables, run Get-Help about_Hash_Tables.

BODYPARAMETER \<IMicrosoftGraphAgreementFileLocalization\>: agreementFileLocalization
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.
  \[Versions \<IMicrosoftGraphAgreementFileVersion\[\]\>\]: 
    \[CreatedDateTime \<DateTime?\>\]: 
    \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[FileName \<String\>\]: 
    \[IsDefault \<Boolean?\>\]: 
    \[IsMajorVersion \<Boolean?\>\]: 
    \[Language \<String\>\]: 
    \[Id \<String\>\]: Read-only.

FILEDATA \<IMicrosoftGraphAgreementFileData\>: agreementFileData
  \[(Any) \<Object\>\]: This indicates any property can be added to this object.
  \[Data \<Byte\[\]\>\]: 

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

VERSIONS \<IMicrosoftGraphAgreementFileVersion\[\]\>: .
  \[CreatedDateTime \<DateTime?\>\]: 
  \[FileData \<IMicrosoftGraphAgreementFileData\>\]: agreementFileData
    \[(Any) \<Object\>\]: This indicates any property can be added to this object.
    \[Data \<Byte\[\]\>\]: 
  \[FileName \<String\>\]: 
  \[IsDefault \<Boolean?\>\]: 
  \[IsMajorVersion \<Boolean?\>\]: 
  \[Language \<String\>\]: 
  \[Id \<String\>\]: Read-only.

## RELATED LINKS

[https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreementfilelocalization](https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.governance/new-mgagreementfilelocalization)

