---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/update-mgpolicydefaultappmanagementpolicy
schema: 2.0.0
---

# Update-MgPolicyDefaultAppManagementPolicy

## SYNOPSIS
Update the properties of a tenantAppManagementPolicy object.

## SYNTAX

### UpdateExpanded (Default)
```
Update-MgPolicyDefaultAppManagementPolicy [-AdditionalProperties <Hashtable>]
 [-ApplicationRestrictions <IMicrosoftGraphAppManagementConfiguration>] [-DeletedDateTime <DateTime>]
 [-Description <String>] [-DisplayName <String>] [-Id <String>] [-IsEnabled]
 [-ServicePrincipalRestrictions <IMicrosoftGraphAppManagementConfiguration>] [-PassThru] [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

### Update
```
Update-MgPolicyDefaultAppManagementPolicy -BodyParameter <IMicrosoftGraphTenantAppManagementPolicy1>
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Update the properties of a tenantAppManagementPolicy object.

## EXAMPLES

### Example 1: Using the Update-MgPolicyDefaultAppManagementPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	IsEnabled = $true
	ApplicationRestrictions = @{
		PasswordCredentials = @(
			@{
				RestrictionType = "passwordAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "passwordLifetime"
				MaxLifetime = "P4DT12H30M5S"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2017-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "symmetricKeyAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2021-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "customPasswordAddition"
				MaxLifetime = $null
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
			@{
				RestrictionType = "symmetricKeyLifetime"
				MaxLifetime = "P40D"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
		)
		KeyCredentials = @(
			@{
				RestrictionType = "asymmetricKeyLifetime"
				MaxLifetime = "P30D"
				RestrictForAppsCreatedAfterDateTime = [System.DateTime]::Parse("2015-01-01T10:37:00Z")
			}
		)
	}
}
Update-MgPolicyDefaultAppManagementPolicy -BodyParameter $params
```

This example shows how to use the Update-MgPolicyDefaultAppManagementPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

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

### -ApplicationRestrictions
appManagementConfiguration
To construct, please use Get-Help -Online and see NOTES section for APPLICATIONRESTRICTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppManagementConfiguration
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
tenantAppManagementPolicy
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTenantAppManagementPolicy1
Parameter Sets: Update
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DeletedDateTime
Date and time when this object was deleted.
Always null when the object hasn't been deleted.

```yaml
Type: System.DateTime
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Description
Description for this policy.
Required.

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

### -DisplayName
Display name for this policy.
Required.

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

### -Id
The unique idenfier for an entity.
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

### -IsEnabled
Denotes whether the policy is enabled.
Default value is false.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: UpdateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
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
```

### -ServicePrincipalRestrictions
appManagementConfiguration
To construct, please use Get-Help -Online and see NOTES section for SERVICEPRINCIPALRESTRICTIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphAppManagementConfiguration
Parameter Sets: UpdateExpanded
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphTenantAppManagementPolicy1

## OUTPUTS

### System.Boolean

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APPLICATIONRESTRICTIONS <IMicrosoftGraphAppManagementConfiguration>: appManagementConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
    - `[MaxLifetime <TimeSpan?>]`: 
    - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
    - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
    - `[MaxLifetime <TimeSpan?>]`: 
    - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.
    - `[RestrictionType <String>]`: appCredentialRestrictionType

BODYPARAMETER <IMicrosoftGraphTenantAppManagementPolicy1>: tenantAppManagementPolicy
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Description <String>]`: Description for this policy. Required.
  - `[DisplayName <String>]`: Display name for this policy. Required.
  - `[DeletedDateTime <DateTime?>]`: Date and time when this object was deleted. Always null when the object hasn't been deleted.
  - `[Id <String>]`: The unique idenfier for an entity. Read-only.
  - `[ApplicationRestrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
      - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
      - `[MaxLifetime <TimeSpan?>]`: 
      - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.
      - `[RestrictionType <String>]`: appCredentialRestrictionType
  - `[IsEnabled <Boolean?>]`: Denotes whether the policy is enabled. Default value is false.
  - `[ServicePrincipalRestrictions <IMicrosoftGraphAppManagementConfiguration>]`: appManagementConfiguration

SERVICEPRINCIPALRESTRICTIONS <IMicrosoftGraphAppManagementConfiguration>: appManagementConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[KeyCredentials <IMicrosoftGraphKeyCredentialConfiguration[]>]`: Collection of keyCredential restrictions settings to be applied to an application or service principal.
    - `[MaxLifetime <TimeSpan?>]`: 
    - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Timestamp when the policy is enforced for all apps created on or after the specified date. For existing applications, the enforcement date would be back dated. To apply to all applications regardless of their creation date, this property would be null. Nullable.
    - `[RestrictionType <String>]`: appKeyCredentialRestrictionType
  - `[PasswordCredentials <IMicrosoftGraphPasswordCredentialConfiguration[]>]`: Collection of password restrictions settings to be applied to an application or service principal.
    - `[MaxLifetime <TimeSpan?>]`: 
    - `[RestrictForAppsCreatedAfterDateTime <DateTime?>]`: Enforces the policy for an app created on or after the enforcement date. For existing applications, the enforcement date would be back dated. To apply to all applications, enforcement datetime would be null.
    - `[RestrictionType <String>]`: appCredentialRestrictionType

## RELATED LINKS

