---
external help file:
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/add-mgapplicationpassword
schema: 2.0.0
---

# Add-MgApplicationPassword

## SYNOPSIS
Invoke action addPassword

## SYNTAX

### AddExpanded (Default)
```
Add-MgApplicationPassword -ApplicationId <String> [-AdditionalProperties <Hashtable>]
 [-PasswordCredential <IMicrosoftGraphPasswordCredential>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-MgApplicationPassword -ApplicationId <String>
 -BodyParameter <IPaths141Ryo0ApplicationsApplicationIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgApplicationPassword -InputObject <IApplicationsIdentity>
 -BodyParameter <IPaths141Ryo0ApplicationsApplicationIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgApplicationPassword -InputObject <IApplicationsIdentity> [-AdditionalProperties <Hashtable>]
 [-PasswordCredential <IMicrosoftGraphPasswordCredential>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action addPassword

## EXAMPLES

### Example 1: Add a password credential to an application with a six month expiry
```powershell

Connect-MgGraph -Scopes 'Application.ReadWrite.All'

$appObjectId = 'eaf1e531-0d58-4874-babe-b9a9f436e6c3'

$passwordCred = @{
   displayName = 'Created in PowerShell'
   endDateTime = (Get-Date).AddMonths(6)
}

$secret = Add-MgApplicationPassword -applicationId $appObjectId -PasswordCredential $passwordCred
$secret | Format-List

CustomKeyIdentifier  :
DisplayName          : Created in PowerShell
EndDateTime          : 26/11/2022 12:03:31 pm
Hint                 : Q_e
KeyId                : c82bb763-741b-4575-9d9d-df7e766f6999
SecretText           : Q_e8Q~ZDWJD.bkgajbREp-VFFUayCuEk8b1hDcr9
StartDateTime        : 26/5/2022 1:03:31 pm
AdditionalProperties : {[@odata.context,
                       https://graph.microsoft.com/v1.0/$metadata#microsoft.graph.passwordCredential]}
```

Add a password to an application that expires in six months from the current date.

### Example 2: Add a password credential to an application with a start date
```powershell

Connect-MgGraph -Scopes 'Application.ReadWrite.All'

$appObjectId = 'eaf1e531-0d58-4874-babe-b9a9f436e6c3'

$startDate = (Get-Date).AddDays(1).Date
$endDate = $startDate.AddMonths(6)

$passwordCred = @{
   displayName = 'Created in PowerShell'
   startDateTime = $startDate
   endDateTime = $endDate
}

$secret = Add-MgApplicationPassword -applicationId $appObjectId -PasswordCredential $passwordCred
$secret | Format-List

CustomKeyIdentifier  :
DisplayName          : Created in PowerShell
EndDateTime          : 26/11/2022 1:00:00 pm
Hint                 : TiA
KeyId                : 082bf20f-63d6-4970-bb4e-55e504f50d8b
SecretText           : TiA8Q~Zs7ej1cGtlW0qnmuFi~JlxXTZew_tU1bGA
StartDateTime        : 26/5/2022 2:00:00 pm
AdditionalProperties : {[@odata.context,
                       https://graph.microsoft.com/v1.0/$metadata#microsoft.graph.passwordCredential]}
```

Add a password to an application that becomes valid at 12:00 am the next day and is valid for six months.

Use `$secret.StartDateTime.ToLocalTime()` to convert the returned dates from UTC to the local timezone.

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApplicationId
key: id of application

```yaml
Type: System.String
Parameter Sets: Add, AddExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
.
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths141Ryo0ApplicationsApplicationIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -InputObject
Identity Parameter
To construct, please use Get-Help -Online and see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IApplicationsIdentity
Parameter Sets: AddViaIdentity, AddViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -PasswordCredential
passwordCredential
To construct, please use Get-Help -Online and see NOTES section for PASSWORDCREDENTIAL properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordCredential
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IApplicationsIdentity

### Microsoft.Graph.PowerShell.Models.IPaths141Ryo0ApplicationsApplicationIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphPasswordCredential

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


BODYPARAMETER <IPaths141Ryo0ApplicationsApplicationIdMicrosoftGraphAddpasswordPostRequestbodyContentApplicationJsonSchema>: .
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
    - `[DisplayName <String>]`: Friendly name for the password. Optional.
    - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
    - `[KeyId <String>]`: The unique identifier for the password.
    - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
    - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

INPUTOBJECT <IApplicationsIdentity>: Identity Parameter
  - `[AppManagementPolicyId <String>]`: key: id of appManagementPolicy
  - `[AppRoleAssignmentId <String>]`: key: id of appRoleAssignment
  - `[ApplicationId <String>]`: key: id of application
  - `[ApplicationTemplateId <String>]`: key: id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: id of claimsMappingPolicy
  - `[ConnectorGroupId <String>]`: key: id of connectorGroup
  - `[ConnectorId <String>]`: key: id of connector
  - `[DelegatedPermissionClassificationId <String>]`: key: id of delegatedPermissionClassification
  - `[DirectoryDefinitionId <String>]`: key: id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: id of directoryObject
  - `[EndpointId <String>]`: key: id of endpoint
  - `[ExtensionPropertyId <String>]`: key: id of extensionProperty
  - `[FederatedIdentityCredentialId <String>]`: key: id of federatedIdentityCredential
  - `[GroupId <String>]`: key: id of group
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: id of homeRealmDiscoveryPolicy
  - `[LicenseDetailsId <String>]`: key: id of licenseDetails
  - `[OAuth2PermissionGrantId <String>]`: key: id of oAuth2PermissionGrant
  - `[OnPremisesAgentGroupId <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentGroupId1 <String>]`: key: id of onPremisesAgentGroup
  - `[OnPremisesAgentId <String>]`: key: id of onPremisesAgent
  - `[OnPremisesPublishingProfileId <String>]`: key: id of onPremisesPublishingProfile
  - `[PublishedResourceId <String>]`: key: id of publishedResource
  - `[ServicePrincipalId <String>]`: key: id of servicePrincipal
  - `[SynchronizationJobId <String>]`: key: id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: id of tokenLifetimePolicy
  - `[UserId <String>]`: key: id of user

PASSWORDCREDENTIAL <IMicrosoftGraphPasswordCredential>: passwordCredential
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[DisplayName <String>]`: Friendly name for the password. Optional.
  - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
  - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
  - `[KeyId <String>]`: The unique identifier for the password.
  - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.

## RELATED LINKS

