---
external help file:
Module Name: Microsoft.Graph.Identity.Application
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.application/add-mgapplicationkey
schema: 2.0.0
---

# Add-MgApplicationKey

## SYNOPSIS
Invoke action addKey

## SYNTAX

### AddExpanded (Default)
```
Add-MgApplicationKey -ApplicationId <String> [-KeyCredentialCustomKeyIdentifierInputFile <String>]
 [-KeyCredentialDisplayName <String>] [-KeyCredentialEndDateTime <DateTime>] [-KeyCredentialKeyId <String>]
 [-KeyCredentialKeyInputFile <String>] [-KeyCredentialStartDateTime <DateTime>] [-KeyCredentialType <String>]
 [-KeyCredentialUsage <String>] [-PasswordCredentialCustomKeyIdentifierInputFile <String>]
 [-PasswordCredentialDisplayName <String>] [-PasswordCredentialEndDateTime <DateTime>]
 [-PasswordCredentialHint <String>] [-PasswordCredentialKeyId <String>]
 [-PasswordCredentialSecretText <String>] [-PasswordCredentialStartDateTime <DateTime>] [-Proof <String>]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Add
```
Add-MgApplicationKey -ApplicationId <String>
 -BodyParameter <IPaths17CrvdcApplicationsApplicationIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentity
```
Add-MgApplicationKey -InputObject <IIdentityApplicationIdentity>
 -BodyParameter <IPaths17CrvdcApplicationsApplicationIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema>
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### AddViaIdentityExpanded
```
Add-MgApplicationKey -InputObject <IIdentityApplicationIdentity>
 [-KeyCredentialCustomKeyIdentifierInputFile <String>] [-KeyCredentialDisplayName <String>]
 [-KeyCredentialEndDateTime <DateTime>] [-KeyCredentialKeyId <String>] [-KeyCredentialKeyInputFile <String>]
 [-KeyCredentialStartDateTime <DateTime>] [-KeyCredentialType <String>] [-KeyCredentialUsage <String>]
 [-PasswordCredentialCustomKeyIdentifierInputFile <String>] [-PasswordCredentialDisplayName <String>]
 [-PasswordCredentialEndDateTime <DateTime>] [-PasswordCredentialHint <String>]
 [-PasswordCredentialKeyId <String>] [-PasswordCredentialSecretText <String>]
 [-PasswordCredentialStartDateTime <DateTime>] [-Proof <String>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Invoke action addKey

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

### -ApplicationId
key: application-id of application

```yaml
Type: System.String
Parameter Sets: Add, AddExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -BodyParameter
.
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IPaths17CrvdcApplicationsApplicationIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema
Parameter Sets: Add, AddViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity
Parameter Sets: AddViaIdentity, AddViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialCustomKeyIdentifierInputFile
Input File for KeyCredentialCustomKeyIdentifier (Custom key identifier)

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialDisplayName
Friendly name for the key.
Optional.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialEndDateTime
The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialKeyId
The unique identifier (GUID) for the key.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialKeyInputFile
Input File for KeyCredentialKey (Value for the key credential.
Should be a base 64 encoded value.)

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialStartDateTime
The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'

```yaml
Type: System.DateTime
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialType
The type of key credential; for example, 'Symmetric'.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -KeyCredentialUsage
A string that describes the purpose for which the key can be used; for example, 'Verify'.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialCustomKeyIdentifierInputFile
Input File for PasswordCredentialCustomKeyIdentifier (Do not use.)

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialDisplayName
Friendly name for the password.
Optional.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialEndDateTime
The date and time at which the password expires represented using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Optional.

```yaml
Type: System.DateTime
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialHint
Contains the first three characters of the password.
Read-only.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialKeyId
The unique identifier for the password.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialSecretText
Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length.
The generated password value is only returned during the initial POST request to addPassword.
There is no way to retrieve this password in the future.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -PasswordCredentialStartDateTime
The date and time at which the password becomes valid.
The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time.
For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
Optional.

```yaml
Type: System.DateTime
Parameter Sets: AddExpanded, AddViaIdentityExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -Proof
.

```yaml
Type: System.String
Parameter Sets: AddExpanded, AddViaIdentityExpanded
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

### Microsoft.Graph.PowerShell.Models.IIdentityApplicationIdentity

### Microsoft.Graph.PowerShell.Models.IPaths17CrvdcApplicationsApplicationIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphKeyCredential

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### BODYPARAMETER <IPaths17CrvdcApplicationsApplicationIdMicrosoftGraphAddkeyPostRequestbodyContentApplicationJsonSchema>: .
  - `[KeyCredentialCustomKeyIdentifier <Byte[]>]`: Custom key identifier
  - `[KeyCredentialDisplayName <String>]`: Friendly name for the key. Optional.
  - `[KeyCredentialEndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[KeyCredentialKey <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
  - `[KeyCredentialKeyId <String>]`: The unique identifier (GUID) for the key.
  - `[KeyCredentialStartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
  - `[KeyCredentialType <String>]`: The type of key credential; for example, 'Symmetric'.
  - `[KeyCredentialUsage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
  - `[PasswordCredentialCustomKeyIdentifier <Byte[]>]`: Do not use.
  - `[PasswordCredentialDisplayName <String>]`: Friendly name for the password. Optional.
  - `[PasswordCredentialEndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[PasswordCredentialHint <String>]`: Contains the first three characters of the password. Read-only.
  - `[PasswordCredentialKeyId <String>]`: The unique identifier for the password.
  - `[PasswordCredentialSecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
  - `[PasswordCredentialStartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Optional.
  - `[Proof <String>]`: 

#### INPUTOBJECT <IIdentityApplicationIdentity>: Identity Parameter
  - `[ApplicationId <String>]`: key: application-id of application
  - `[ApplicationTemplateId <String>]`: key: applicationTemplate-id of applicationTemplate
  - `[ClaimsMappingPolicyId <String>]`: key: claimsMappingPolicy-id of claimsMappingPolicy
  - `[DirectoryDefinitionId <String>]`: key: directoryDefinition-id of directoryDefinition
  - `[DirectoryObjectId <String>]`: key: directoryObject-id of directoryObject
  - `[ExtensionPropertyId <String>]`: key: extensionProperty-id of extensionProperty
  - `[HomeRealmDiscoveryPolicyId <String>]`: key: homeRealmDiscoveryPolicy-id of homeRealmDiscoveryPolicy
  - `[SynchronizationJobId <String>]`: key: synchronizationJob-id of synchronizationJob
  - `[SynchronizationTemplateId <String>]`: key: synchronizationTemplate-id of synchronizationTemplate
  - `[TokenIssuancePolicyId <String>]`: key: tokenIssuancePolicy-id of tokenIssuancePolicy
  - `[TokenLifetimePolicyId <String>]`: key: tokenLifetimePolicy-id of tokenLifetimePolicy

## RELATED LINKS

