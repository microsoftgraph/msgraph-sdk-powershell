---
external help file: Microsoft.Graph.Applications-help.xml
Module Name: Microsoft.Graph.Applications
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.applications/new-mgonpremisepublishingprofile
schema: 2.0.0
---

# New-MgOnPremisePublishingProfile

## SYNOPSIS
Add new entity to onPremisesPublishingProfiles

## SYNTAX

### CreateExpanded (Default)
```
New-MgOnPremisePublishingProfile [-AdditionalProperties <Hashtable>]
 [-AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>] [-Agents <IMicrosoftGraphOnPremisesAgent[]>]
 [-ConnectorGroups <IMicrosoftGraphConnectorGroup[]>] [-Connectors <IMicrosoftGraphConnector[]>]
 [-HybridAgentUpdaterConfiguration <IMicrosoftGraphHybridAgentUpdaterConfiguration>] [-Id <String>]
 [-IsEnabled] [-PublishedResources <IMicrosoftGraphPublishedResource[]>] [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### Create
```
New-MgOnPremisePublishingProfile -BodyParameter <IMicrosoftGraphOnPremisesPublishingProfile> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Add new entity to onPremisesPublishingProfiles

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AgentGroups
List of existing onPremisesAgentGroup objects.
Read-only.
Nullable.
To construct, see NOTES section for AGENTGROUPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesAgentGroup[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Agents
List of existing onPremisesAgent objects.
Read-only.
Nullable.
To construct, see NOTES section for AGENTS properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesAgent[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
onPremisesPublishingProfile
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: IMicrosoftGraphOnPremisesPublishingProfile
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConnectorGroups
List of existing connectorGroup objects for applications published through Application Proxy.
Read-only.
Nullable.
To construct, see NOTES section for CONNECTORGROUPS properties and create a hash table.

```yaml
Type: IMicrosoftGraphConnectorGroup[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Connectors
List of existing connector objects for applications published through Application Proxy.
Read-only.
Nullable.
To construct, see NOTES section for CONNECTORS properties and create a hash table.

```yaml
Type: IMicrosoftGraphConnector[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HybridAgentUpdaterConfiguration
hybridAgentUpdaterConfiguration
To construct, see NOTES section for HYBRIDAGENTUPDATERCONFIGURATION properties and create a hash table.

```yaml
Type: IMicrosoftGraphHybridAgentUpdaterConfiguration
Parameter Sets: CreateExpanded
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
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IsEnabled
Represents if Azure AD Application Proxy is enabled for the tenant.

```yaml
Type: SwitchParameter
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PublishedResources
List of existing publishedResource objects.
Read-only.
Nullable.
To construct, see NOTES section for PUBLISHEDRESOURCES properties and create a hash table.

```yaml
Type: IMicrosoftGraphPublishedResource[]
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesPublishingProfile
## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphOnPremisesPublishingProfile
## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


AGENTGROUPS <IMicrosoftGraphOnPremisesAgentGroup[]>: List of existing onPremisesAgentGroup objects. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
    - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
    - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
    - `[Status <String>]`: agentStatus
    - `[SupportedPublishingTypes <String[]>]`: 
  - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
  - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
  - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
    - `[DisplayName <String>]`: Display Name of the publishedResource.
    - `[PublishingType <String>]`: onPremisesPublishingType
    - `[ResourceName <String>]`: Name of the publishedResource.
  - `[PublishingType <String>]`: onPremisesPublishingType

AGENTS <IMicrosoftGraphOnPremisesAgent[]>: List of existing onPremisesAgent objects. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
    - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
      - `[DisplayName <String>]`: Display Name of the publishedResource.
      - `[PublishingType <String>]`: onPremisesPublishingType
      - `[ResourceName <String>]`: Name of the publishedResource.
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
  - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
  - `[Status <String>]`: agentStatus
  - `[SupportedPublishingTypes <String[]>]`: 

BODYPARAMETER <IMicrosoftGraphOnPremisesPublishingProfile>: onPremisesPublishingProfile
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of existing onPremisesAgentGroup objects. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
      - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
      - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
      - `[Status <String>]`: agentStatus
      - `[SupportedPublishingTypes <String[]>]`: 
    - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
    - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
      - `[DisplayName <String>]`: Display Name of the publishedResource.
      - `[PublishingType <String>]`: onPremisesPublishingType
      - `[ResourceName <String>]`: Name of the publishedResource.
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of existing onPremisesAgent objects. Read-only. Nullable.
  - `[ConnectorGroups <IMicrosoftGraphConnectorGroup[]>]`: List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Applications <IMicrosoftGraphApplication[]>]`: Read-only. Nullable.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
      - `[Api <IMicrosoftGraphApiApplication1>]`: apiApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
        - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
        - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
          - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
          - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
          - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
          - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
          - `[Origin <String>]`: 
          - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
          - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
          - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
          - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
        - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
          - `[AppId <String>]`: The unique identifier for the application.
          - `[PermissionIds <String[]>]`: The unique identifier for the oauth2PermissionScopes the application requires.
        - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
      - `[AppId <String>]`: The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
      - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
        - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
        - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
        - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
        - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
        - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
        - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
        - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
      - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
      - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DeletedDateTime <DateTime?>]`: 
      - `[DefaultRedirectUri <String>]`: 
      - `[Description <String>]`: 
      - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
      - `[DisplayName <String>]`: The display name for the application.
      - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
        - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
        - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
        - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
        - `[Name <String>]`: Name of the extension property. Not nullable.
        - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
      - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
      - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information, see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
      - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
        - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
        - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
        - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
        - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
      - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
      - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
      - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable.
        - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
        - `[DisplayName <String>]`: Friendly name for the key. Optional.
        - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
        - `[KeyId <String>]`: The unique identifier (GUID) for the key.
        - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
        - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
      - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
      - `[Notes <String>]`: Notes relevant for the management of the application.
      - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
        - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
        - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
        - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
        - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
        - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
        - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
        - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
        - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
        - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
        - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
        - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
        - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
        - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
            - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
          - `[SingleSignOnMode <String>]`: singleSignOnMode
        - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
        - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
          - `[SubjectName <String>]`: The subject name of the custom domain certificate.
          - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
        - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
        - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
          - `[DisplayName <String>]`: Friendly name for the password. Optional.
          - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
          - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
          - `[KeyId <String>]`: The unique identifier for the password.
          - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
          - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
      - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
          - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
          - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
          - `[Name <String>]`: The name of the optional claim.
          - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
        - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
        - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
      - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable.
      - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
        - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
      - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
      - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
      - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
      - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of OAuth permission scopes and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. Not nullable.
        - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
          - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
          - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
        - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
      - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. Supported values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, PersonalMicrosoftAccount. See more in the table below.
      - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
      - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
            - `[State <String>]`: synchronizationScheduleState
          - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: Read-only.
            - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
              - `[Id <String>]`: Read-only.
              - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
              - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
              - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
                - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
                  - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
                  - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                    - `[Key <String>]`: Key.
                    - `[Value <String>]`: Value.
                  - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
                  - `[DefaultValue <String>]`: 
                  - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
                  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                    - `[Key <String>]`: Name of the metadata property.
                    - `[Value <String>]`: Value of the metadata property.
                  - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
                  - `[Mutability <String>]`: mutability
                  - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
                  - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                    - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                    - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
                  - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
                  - `[Type <String>]`: attributeType
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
                - `[Name <String>]`: 
                - `[SupportedApis <String[]>]`: 
              - `[ReadOnly <Boolean?>]`: 
              - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
            - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
              - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
              - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
              - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
              - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
              - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
                - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
                  - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
                  - `[ExportMissingReferences <Boolean?>]`: For internal use only.
                  - `[FlowBehavior <String>]`: attributeFlowBehavior
                  - `[FlowType <String>]`: attributeFlowType
                  - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
                  - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                    - `[(Any) <Object>]`: This indicates any property can be added to this object.
                    - `[Expression <String>]`: 
                    - `[Name <String>]`: 
                    - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                      - `[Key <String>]`: The name of the parameter.
                      - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                    - `[Type <String>]`: attributeMappingSourceType
                  - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
                - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
                - `[FlowTypes <String>]`: objectFlowTypes
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                - `[Name <String>]`: Human-friendly name of the object mapping.
                - `[Scope <IMicrosoftGraphFilter>]`: filter
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                    - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
                      - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
                      - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
                      - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                        - `[(Any) <Object>]`: This indicates any property can be added to this object.
                        - `[Values <String[]>]`: Collection of values.
                    - `[Name <String>]`: Human-readable name of the filter group.
                  - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                  - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
                - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
              - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
              - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
              - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
            - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
          - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: synchronizationStatusCode
            - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
            - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
            - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[ActivityIdentifier <String>]`: Identifier of the job run.
              - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
              - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
              - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
              - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
              - `[CountExported <Int64?>]`: Count of exported entries.
              - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
              - `[CountImported <Int64?>]`: Count of imported entries.
              - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
              - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
              - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Code <String>]`: 
                - `[Message <String>]`: 
                - `[TenantActionable <Boolean?>]`: 
              - `[State <String>]`: synchronizationTaskExecutionResult
              - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
              - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
              - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
              - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
              - `[Units <String>]`: An optional description of the units.
            - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
              - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Reason <String>]`: quarantineReason
              - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
            - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
              - `[Key <String>]`: Key.
              - `[Value <Int64?>]`: Value.
            - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
          - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
            - `[Name <String>]`: Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.
            - `[Value <String>]`: Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).
          - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
        - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
          - `[Key <String>]`: synchronizationSecret
          - `[Value <String>]`: The value of the secret.
        - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
          - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
          - `[Description <String>]`: Description of the template.
          - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
          - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
          - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
      - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
      - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this application.
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[UniqueName <String>]`: The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
      - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[HomePageUrl <String>]`: Home page or landing page of the application.
        - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
          - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
        - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[IsDefault <Boolean?>]`: Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
    - `[Members <IMicrosoftGraphConnector[]>]`: Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[ExternalIP <String>]`: The external IP address as detected by the the connector server. Read-only.
      - `[MachineName <String>]`: The machine name the connector is installed and running on.
      - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: The connectorGroup that the connector is a member of. Read-only.
      - `[Status <String>]`: connectorStatus
    - `[Name <String>]`: The name associated with the connectorGroup.
    - `[Region <String>]`: connectorGroupRegion
  - `[Connectors <IMicrosoftGraphConnector[]>]`: List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.
  - `[HybridAgentUpdaterConfiguration <IMicrosoftGraphHybridAgentUpdaterConfiguration>]`: hybridAgentUpdaterConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[AllowUpdateConfigurationOverride <Boolean?>]`: Indicates if updater configuration will be skipped and the agent will receive an update when the next version of the agent is available.
    - `[DeferUpdateDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
    - `[UpdateWindow <IMicrosoftGraphUpdateWindow>]`: updateWindow
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[UpdateWindowEndTime <String>]`: End of a time window during which agents can receive updates
      - `[UpdateWindowStartTime <String>]`: Start of a time window during which agents can receive updates
  - `[IsEnabled <Boolean?>]`: Represents if Azure AD Application Proxy is enabled for the tenant.
  - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of existing publishedResource objects. Read-only. Nullable.

CONNECTORGROUPS <IMicrosoftGraphConnectorGroup[]>: List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[Applications <IMicrosoftGraphApplication[]>]`: Read-only. Nullable.
    - `[DeletedDateTime <DateTime?>]`: 
    - `[Id <String>]`: Read-only.
    - `[Api <IMicrosoftGraphApiApplication1>]`: apiApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
      - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
      - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
        - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
        - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
        - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
        - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
        - `[Origin <String>]`: 
        - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
        - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
        - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
      - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
        - `[AppId <String>]`: The unique identifier for the application.
        - `[PermissionIds <String[]>]`: The unique identifier for the oauth2PermissionScopes the application requires.
      - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
    - `[AppId <String>]`: The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
    - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
      - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
      - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
      - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
      - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
      - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
      - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
      - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
    - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
    - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
    - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[DeletedDateTime <DateTime?>]`: 
    - `[DefaultRedirectUri <String>]`: 
    - `[Description <String>]`: 
    - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
    - `[DisplayName <String>]`: The display name for the application.
    - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
      - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
      - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
      - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
      - `[Name <String>]`: Name of the extension property. Not nullable.
      - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
    - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
    - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information, see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
    - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
      - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
      - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
      - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
      - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
    - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
    - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
    - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable.
      - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
      - `[DisplayName <String>]`: Friendly name for the key. Optional.
      - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
      - `[KeyId <String>]`: The unique identifier (GUID) for the key.
      - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
      - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
      - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
    - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
    - `[Notes <String>]`: Notes relevant for the management of the application.
    - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
      - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
      - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
      - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
      - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
      - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
      - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
      - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
      - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
      - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
      - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
      - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
      - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
      - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
          - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
        - `[SingleSignOnMode <String>]`: singleSignOnMode
      - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
      - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
        - `[SubjectName <String>]`: The subject name of the custom domain certificate.
        - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
      - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
      - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
        - `[DisplayName <String>]`: Friendly name for the password. Optional.
        - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
        - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
        - `[KeyId <String>]`: The unique identifier for the password.
        - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
        - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
    - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
        - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
        - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
        - `[Name <String>]`: The name of the optional claim.
        - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
      - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
      - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
    - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable.
    - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
      - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
    - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
    - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
    - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of OAuth permission scopes and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. Not nullable.
      - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
        - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
        - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
      - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
    - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. Supported values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, PersonalMicrosoftAccount. See more in the table below.
    - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: Read-only.
      - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
          - `[State <String>]`: synchronizationScheduleState
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Id <String>]`: Read-only.
          - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
            - `[Id <String>]`: Read-only.
            - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
            - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
            - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
              - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
                - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
                - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                  - `[Key <String>]`: Key.
                  - `[Value <String>]`: Value.
                - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
                - `[DefaultValue <String>]`: 
                - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                  - `[Key <String>]`: Name of the metadata property.
                  - `[Value <String>]`: Value of the metadata property.
                - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
                - `[Mutability <String>]`: mutability
                - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
                - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                  - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                  - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
                - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
                - `[Type <String>]`: attributeType
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
              - `[Name <String>]`: 
              - `[SupportedApis <String[]>]`: 
            - `[ReadOnly <Boolean?>]`: 
            - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
          - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
            - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
            - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
            - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
            - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
            - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
              - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
                - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
                - `[ExportMissingReferences <Boolean?>]`: For internal use only.
                - `[FlowBehavior <String>]`: attributeFlowBehavior
                - `[FlowType <String>]`: attributeFlowType
                - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
                - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[Expression <String>]`: 
                  - `[Name <String>]`: 
                  - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                    - `[Key <String>]`: The name of the parameter.
                    - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                  - `[Type <String>]`: attributeMappingSourceType
                - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
              - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
              - `[FlowTypes <String>]`: objectFlowTypes
              - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
              - `[Name <String>]`: Human-friendly name of the object mapping.
              - `[Scope <IMicrosoftGraphFilter>]`: filter
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                  - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
                    - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
                    - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
                    - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                      - `[(Any) <Object>]`: This indicates any property can be added to this object.
                      - `[Values <String[]>]`: Collection of values.
                  - `[Name <String>]`: Human-readable name of the filter group.
                - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
              - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
              - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
            - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
            - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
            - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
          - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
        - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[Code <String>]`: synchronizationStatusCode
          - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
          - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
          - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[ActivityIdentifier <String>]`: Identifier of the job run.
            - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
            - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
            - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
            - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
            - `[CountExported <Int64?>]`: Count of exported entries.
            - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
            - `[CountImported <Int64?>]`: Count of imported entries.
            - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
            - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
            - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[Code <String>]`: 
              - `[Message <String>]`: 
              - `[TenantActionable <Boolean?>]`: 
            - `[State <String>]`: synchronizationTaskExecutionResult
            - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
          - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
            - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
            - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
            - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
            - `[Units <String>]`: An optional description of the units.
          - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
            - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Reason <String>]`: quarantineReason
            - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
          - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
            - `[Key <String>]`: Key.
            - `[Value <Int64?>]`: Value.
          - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
        - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
          - `[Name <String>]`: Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.
          - `[Value <String>]`: Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).
        - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
      - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
        - `[Key <String>]`: synchronizationSecret
        - `[Value <String>]`: The value of the secret.
      - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
        - `[Id <String>]`: Read-only.
        - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
        - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
        - `[Description <String>]`: Description of the template.
        - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
        - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
        - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
        - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
    - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
    - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
    - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this application.
      - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
      - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
      - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
      - `[Description <String>]`: Description for this policy.
      - `[DisplayName <String>]`: Display name for this policy.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
    - `[UniqueName <String>]`: The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
    - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[HomePageUrl <String>]`: Home page or landing page of the application.
      - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
        - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
      - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
      - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
      - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
  - `[ConnectorGroupType <String>]`: connectorGroupType
  - `[IsDefault <Boolean?>]`: Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
  - `[Members <IMicrosoftGraphConnector[]>]`: Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[ExternalIP <String>]`: The external IP address as detected by the the connector server. Read-only.
    - `[MachineName <String>]`: The machine name the connector is installed and running on.
    - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: The connectorGroup that the connector is a member of. Read-only.
    - `[Status <String>]`: connectorStatus
  - `[Name <String>]`: The name associated with the connectorGroup.
  - `[Region <String>]`: connectorGroupRegion

CONNECTORS <IMicrosoftGraphConnector[]>: List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[ExternalIP <String>]`: The external IP address as detected by the the connector server. Read-only.
  - `[MachineName <String>]`: The machine name the connector is installed and running on.
  - `[MemberOf <IMicrosoftGraphConnectorGroup[]>]`: The connectorGroup that the connector is a member of. Read-only.
    - `[Id <String>]`: Read-only.
    - `[Applications <IMicrosoftGraphApplication[]>]`: Read-only. Nullable.
      - `[DeletedDateTime <DateTime?>]`: 
      - `[Id <String>]`: Read-only.
      - `[Api <IMicrosoftGraphApiApplication1>]`: apiApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AcceptMappedClaims <Boolean?>]`: When true, allows an application to use claims mapping without specifying a custom signing key.
        - `[KnownClientApplications <String[]>]`: Used for bundling consent if you have a solution that contains two parts: a client app and a custom web API app. If you set the appID of the client app to this value, the user only consents once to the client app. Azure AD knows that consenting to the client means implicitly consenting to the web API and automatically provisions service principals for both APIs at the same time. Both the client and the web API app must be registered in the same tenant.
        - `[Oauth2PermissionScopes <IMicrosoftGraphPermissionScope[]>]`: The definition of the delegated permissions exposed by the web API represented by this application registration. These delegated permissions may be requested by a client application, and may be granted by users or administrators during consent. Delegated permissions are sometimes referred to as OAuth 2.0 scopes.
          - `[AdminConsentDescription <String>]`: A description of the delegated permissions, intended to be read by an administrator granting the permission on behalf of all users. This text appears in tenant-wide admin consent experiences.
          - `[AdminConsentDisplayName <String>]`: The permission's title, intended to be read by an administrator granting the permission on behalf of all users.
          - `[Id <String>]`: Unique delegated permission identifier inside the collection of delegated permissions defined for a resource application.
          - `[IsEnabled <Boolean?>]`: When creating or updating a permission, this property must be set to true (which is the default). To delete a permission, this property must first be set to false.  At that point, in a subsequent call, the permission may be removed.
          - `[Origin <String>]`: 
          - `[Type <String>]`: Specifies whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions. This will be the default behavior, but each customer can choose to customize the behavior in their organization (by allowing, restricting or limiting user consent to this delegated permission.)
          - `[UserConsentDescription <String>]`: A description of the delegated permissions, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
          - `[UserConsentDisplayName <String>]`: A title for the permission, intended to be read by a user granting the permission on their own behalf. This text appears in consent experiences where the user is consenting only on behalf of themselves.
          - `[Value <String>]`: Specifies the value to include in the scp (scope) claim in access tokens. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
        - `[PreAuthorizedApplications <IMicrosoftGraphPreAuthorizedApplication1[]>]`: Lists the client applications that are pre-authorized with the specified delegated permissions to access this application's APIs. Users are not required to consent to any pre-authorized application (for the permissions specified). However, any additional permissions not listed in preAuthorizedApplications (requested through incremental consent for example) will require user consent.
          - `[AppId <String>]`: The unique identifier for the application.
          - `[PermissionIds <String[]>]`: The unique identifier for the oauth2PermissionScopes the application requires.
        - `[RequestedAccessTokenVersion <Int32?>]`: Specifies the access token version expected by this resource. This changes the version and format of the JWT produced independent of the endpoint or client used to request the access token.  The endpoint used, v1.0 or v2.0, is chosen by the client and only impacts the version of id_tokens. Resources need to explicitly configure requestedAccessTokenVersion to indicate the supported access token format.  Possible values for requestedAccessTokenVersion are 1, 2, or null. If the value is null, this defaults to 1, which corresponds to the v1.0 endpoint.  If signInAudience on the application is configured as AzureADandPersonalMicrosoftAccount, the value for this property must be 2
      - `[AppId <String>]`: The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.
      - `[AppRoles <IMicrosoftGraphAppRole[]>]`: The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.
        - `[AllowedMemberTypes <String[]>]`: Specifies whether this app role can be assigned to users and groups (by setting to ['User']), to other application's (by setting to ['Application'], or both (by setting to ['User', 'Application']). App roles supporting assignment to other applications' service principals are also known as application permissions. The 'Application' value is only supported for app roles defined on application entities.
        - `[Description <String>]`: The description for the app role. This is displayed when the app role is being assigned and, if the app role functions as an application permission, during  consent experiences.
        - `[DisplayName <String>]`: Display name for the permission that appears in the app role assignment and consent experiences.
        - `[Id <String>]`: Unique role identifier inside the appRoles collection. When creating a new app role, a new Guid identifier must be provided.
        - `[IsEnabled <Boolean?>]`: When creating or updating an app role, this must be set to true (which is the default). To delete a role, this must first be set to false.  At that point, in a subsequent call, this role may be removed.
        - `[Origin <String>]`: Specifies if the app role is defined on the application object or on the servicePrincipal entity. Must not be included in any POST or PATCH requests. Read-only.
        - `[Value <String>]`: Specifies the value to include in the roles claim in ID tokens and access tokens authenticating an assigned user or service principal. Must not exceed 120 characters in length. Allowed characters are : ! # $ % & ' ( ) * + , - . / : ;  =  ? @ [ ] ^ + _  {  } ~, as well as characters in the ranges 0-9, A-Z and a-z. Any other character, including the space character, are not allowed. May not begin with ..
      - `[ConnectorGroup <IMicrosoftGraphConnectorGroup>]`: connectorGroup
      - `[CreatedDateTime <DateTime?>]`: The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
      - `[CreatedOnBehalfOf <IMicrosoftGraphDirectoryObject>]`: Represents an Azure Active Directory object. The directoryObject type is the base type for many other directory entity types.
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[DeletedDateTime <DateTime?>]`: 
      - `[DefaultRedirectUri <String>]`: 
      - `[Description <String>]`: 
      - `[DisabledByMicrosoftStatus <String>]`: Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).
      - `[DisplayName <String>]`: The display name for the application.
      - `[ExtensionProperties <IMicrosoftGraphExtensionProperty[]>]`: Read-only. Nullable.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
        - `[AppDisplayName <String>]`: Display name of the application object on which this extension property is defined. Read-only.
        - `[DataType <String>]`: Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
        - `[IsSyncedFromOnPremises <Boolean?>]`: Indicates if this extension property was sycned from onpremises directory using Azure AD Connect. Read-only.
        - `[Name <String>]`: Name of the extension property. Not nullable.
        - `[TargetObjects <String[]>]`: Following values are supported. Not nullable. UserGroupOrganizationDeviceApplication
      - `[GroupMembershipClaims <String>]`: Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).
      - `[HomeRealmDiscoveryPolicies <IMicrosoftGraphHomeRealmDiscoveryPolicy1[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[IdentifierUris <String[]>]`: The URIs that identify the application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant. For more information, see Application Objects and Service Principal Objects. The any operator is required for filter expressions on multi-valued properties. Not nullable.
      - `[Info <IMicrosoftGraphInformationalUrl>]`: informationalUrl
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[LogoUrl <String>]`: CDN URL to the application's logo, Read-only.
        - `[MarketingUrl <String>]`: Link to the application's marketing page. For example, https://www.contoso.com/app/marketing
        - `[PrivacyStatementUrl <String>]`: Link to the application's privacy statement. For example, https://www.contoso.com/app/privacy
        - `[SupportUrl <String>]`: Link to the application's support page. For example, https://www.contoso.com/app/support
        - `[TermsOfServiceUrl <String>]`: Link to the application's terms of service statement. For example, https://www.contoso.com/app/termsofservice
      - `[IsDeviceOnlyAuthSupported <Boolean?>]`: Specifies whether this application supports device authentication without a user. The default is false.
      - `[IsFallbackPublicClient <Boolean?>]`: Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.
      - `[KeyCredentials <IMicrosoftGraphKeyCredential[]>]`: The collection of key credentials associated with the application. Not nullable.
        - `[CustomKeyIdentifier <Byte[]>]`: Custom key identifier
        - `[DisplayName <String>]`: Friendly name for the key. Optional.
        - `[EndDateTime <DateTime?>]`: The date and time at which the credential expires.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Key <Byte[]>]`: Value for the key credential. Should be a base 64 encoded value.
        - `[KeyId <String>]`: The unique identifier (GUID) for the key.
        - `[StartDateTime <DateTime?>]`: The date and time at which the credential becomes valid.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        - `[Type <String>]`: The type of key credential; for example, 'Symmetric'.
        - `[Usage <String>]`: A string that describes the purpose for which the key can be used; for example, 'Verify'.
      - `[Logo <Byte[]>]`: The main logo for the application. Not nullable.
      - `[Notes <String>]`: Notes relevant for the management of the application.
      - `[OnPremisesPublishing <IMicrosoftGraphOnPremisesPublishing>]`: onPremisesPublishing
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AlternateUrl <String>]`: If you are configuring a traffic manager in front of multiple App Proxy applications, the alternateUrl is the user-friendly URL that will point to the traffic manager.
        - `[ApplicationServerTimeout <String>]`: The duration the connector will wait for a response from the backend application before closing the connection. Possible values are default, long. When set to default, the backend application timeout has a length of 85 seconds. When set to long, the backend timeout is increased to 180 seconds. Use long if your server takes more than 85 seconds to respond to requests or if you are unable to access the application and the error status is 'Backend Timeout'. Default value is default.
        - `[ApplicationType <String>]`: Indicates if this application is an Application Proxy configured application. This is pre-set by the system. Read-only.
        - `[ExternalAuthenticationType <String>]`: externalAuthenticationType
        - `[ExternalUrl <String>]`: The published external url for the application. For example, https://intranet-contoso.msappproxy.net/.
        - `[InternalUrl <String>]`: The internal url of the application. For example, https://intranet/.
        - `[IsBackendCertificateValidationEnabled <Boolean?>]`: Indicates whether backend SSL certificate validation is enabled for the application. For all new Application Proxy apps, the property will be set to true by default. For all existing apps, the property will be set to false.
        - `[IsHttpOnlyCookieEnabled <Boolean?>]`: Indicates if the HTTPOnly cookie flag should be set in the HTTP response headers. Set this value to true to have Application Proxy cookies include the HTTPOnly flag in the HTTP response headers. If using Remote Desktop Services, set this value to False. Default value is false.
        - `[IsOnPremPublishingEnabled <Boolean?>]`: Indicates if the application is currently being published via Application Proxy or not. This is pre-set by the system. Read-only.
        - `[IsPersistentCookieEnabled <Boolean?>]`: Indicates if the Persistent cookie flag should be set in the HTTP response headers. Keep this value set to false. Only use this setting for applications that can't share cookies between processes. For more information about cookie settings, see Cookie settings for accessing on-premises applications in Azure Active Directory. Default value is false.
        - `[IsSecureCookieEnabled <Boolean?>]`: Indicates if the Secure cookie flag should be set in the HTTP response headers. Set this value to true to transmit cookies over a secure channel such as an encrypted HTTPS request. Default value is true.
        - `[IsTranslateHostHeaderEnabled <Boolean?>]`: Indicates if the application should translate urls in the reponse headers. Keep this value as true unless your application required the original host header in the authentication request. Default value is true.
        - `[IsTranslateLinksInBodyEnabled <Boolean?>]`: Indicates if the application should translate urls in the application body. Keep this value as false unless you have hardcoded HTML links to other on-premises applications and don't use custom domains. For more information, see Link translation with Application Proxy. Default value is false.
        - `[SingleSignOnSettings <IMicrosoftGraphOnPremisesPublishingSingleSignOn>]`: onPremisesPublishingSingleSignOn
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[KerberosSignOnSettings <IMicrosoftGraphKerberosSignOnSettings>]`: kerberosSignOnSettings
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[KerberosServicePrincipalName <String>]`: The Internal Application SPN of the application server. This SPN needs to be in the list of services to which the connector can present delegated credentials.
            - `[KerberosSignOnMappingAttributeType <String>]`: kerberosSignOnMappingAttributeType
          - `[SingleSignOnMode <String>]`: singleSignOnMode
        - `[UseAlternateUrlForTranslationAndRedirect <Boolean?>]`: 
        - `[VerifiedCustomDomainCertificatesMetadata <IMicrosoftGraphVerifiedCustomDomainCertificatesMetadata>]`: verifiedCustomDomainCertificatesMetadata
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[ExpiryDate <DateTime?>]`: The expiry date of the custom domain certificate. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[IssueDate <DateTime?>]`: The issue date of the custom domain. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
          - `[IssuerName <String>]`: The issuer name of the custom domain certificate.
          - `[SubjectName <String>]`: The subject name of the custom domain certificate.
          - `[Thumbprint <String>]`: The thumbprint associated with the custom domain certificate.
        - `[VerifiedCustomDomainKeyCredential <IMicrosoftGraphKeyCredential>]`: keyCredential
        - `[VerifiedCustomDomainPasswordCredential <IMicrosoftGraphPasswordCredential>]`: passwordCredential
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[CustomKeyIdentifier <Byte[]>]`: Do not use.
          - `[DisplayName <String>]`: Friendly name for the password. Optional.
          - `[EndDateTime <DateTime?>]`: The date and time at which the password expires represented using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
          - `[Hint <String>]`: Contains the first three characters of the password. Read-only.
          - `[KeyId <String>]`: The unique identifier for the password.
          - `[SecretText <String>]`: Read-only; Contains the strong passwords generated by Azure AD that are 16-64 characters in length. The generated password value is only returned during the initial POST request to addPassword. There is no way to retrieve this password in the future.
          - `[StartDateTime <DateTime?>]`: The date and time at which the password becomes valid. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Optional.
      - `[OptionalClaims <IMicrosoftGraphOptionalClaims>]`: optionalClaims
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[AccessToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT access token.
          - `[AdditionalProperties <String[]>]`: Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
          - `[Essential <Boolean?>]`: If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
          - `[Name <String>]`: The name of the optional claim.
          - `[Source <String>]`: The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
        - `[IdToken <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the JWT ID token.
        - `[Saml2Token <IMicrosoftGraphOptionalClaim[]>]`: The optional claims returned in the SAML token.
      - `[Owners <IMicrosoftGraphDirectoryObject[]>]`: Directory objects that are owners of the application. Read-only. Nullable.
      - `[ParentalControlSettings <IMicrosoftGraphParentalControlSettings>]`: parentalControlSettings
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[CountriesBlockedForMinors <String[]>]`: Specifies the two-letter ISO country codes. Access to the application will be blocked for minors from the countries specified in this list.
        - `[LegalAgeGroupRule <String>]`: Specifies the legal age group rule that applies to users of the app. Can be set to one of the following values: ValueDescriptionAllowDefault. Enforces the legal minimum. This means parental consent is required for minors in the European Union and Korea.RequireConsentForPrivacyServicesEnforces the user to specify date of birth to comply with COPPA rules. RequireConsentForMinorsRequires parental consent for ages below 18, regardless of country minor rules.RequireConsentForKidsRequires parental consent for ages below 14, regardless of country minor rules.BlockMinorsBlocks minors from using the app.
      - `[PasswordCredentials <IMicrosoftGraphPasswordCredential[]>]`: The collection of password credentials associated with the application. Not nullable.
      - `[PublicClient <IMicrosoftGraphPublicClientApplication>]`: publicClientApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
      - `[PublisherDomain <String>]`: The verified publisher domain for the application. Read-only.
      - `[RequiredResourceAccess <IMicrosoftGraphRequiredResourceAccess[]>]`: Specifies the resources that the application needs to access. This property also specifies the set of OAuth permission scopes and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. Not nullable.
        - `[ResourceAccess <IMicrosoftGraphResourceAccess[]>]`: The list of OAuth2.0 permission scopes and app roles that the application requires from the specified resource.
          - `[Id <String>]`: The unique identifier for one of the oauth2PermissionScopes or appRole instances that the resource application exposes.
          - `[Type <String>]`: Specifies whether the id property references an oauth2PermissionScopes or an appRole. Possible values are Scope or Role.
        - `[ResourceAppId <String>]`: The unique identifier for the resource that the application requires access to.  This should be equal to the appId declared on the target resource application.
      - `[SignInAudience <String>]`: Specifies the Microsoft accounts that are supported for the current application. Supported values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, PersonalMicrosoftAccount. See more in the table below.
      - `[Spa <IMicrosoftGraphSpaApplication>]`: spaApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
      - `[Synchronization <IMicrosoftGraphSynchronization>]`: synchronization
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: Read-only.
        - `[Jobs <IMicrosoftGraphSynchronizationJob[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[Schedule <IMicrosoftGraphSynchronizationSchedule>]`: synchronizationSchedule
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Expiration <DateTime?>]`: Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[Interval <TimeSpan?>]`: The interval between synchronization iterations.
            - `[State <String>]`: synchronizationScheduleState
          - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Id <String>]`: Read-only.
            - `[Directories <IMicrosoftGraphDirectoryDefinition[]>]`: Contains the collection of directories and all of their objects.
              - `[Id <String>]`: Read-only.
              - `[Discoverabilities <String>]`: directoryDefinitionDiscoverabilities
              - `[DiscoveryDateTime <DateTime?>]`: Represents the discovery date and time using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Name <String>]`: Name of the directory. Must be unique within the synchronization schema. Not nullable.
              - `[Objects <IMicrosoftGraphObjectDefinition[]>]`: Collection of objects supported by the directory.
                - `[Attributes <IMicrosoftGraphAttributeDefinition[]>]`: 
                  - `[Anchor <Boolean?>]`: true if the attribute should be used as the anchor for the object. Anchor attributes must have a unique value identifying an object, and must be immutable. Default is false. One, and only one, of the object's attributes must be designated as the anchor to support synchronization.
                  - `[ApiExpressions <IMicrosoftGraphStringKeyStringValuePair[]>]`: 
                    - `[Key <String>]`: Key.
                    - `[Value <String>]`: Value.
                  - `[CaseExact <Boolean?>]`: true if value of this attribute should be treated as case-sensitive. This setting affects how the synchronization engine detects changes for the attribute.
                  - `[DefaultValue <String>]`: 
                  - `[FlowNullValues <Boolean?>]`: 'true' to allow null values for attributes.
                  - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                    - `[Key <String>]`: Name of the metadata property.
                    - `[Value <String>]`: Value of the metadata property.
                  - `[Multivalued <Boolean?>]`: true if an attribute can have multiple values. Default is false.
                  - `[Mutability <String>]`: mutability
                  - `[Name <String>]`: Name of the attribute. Must be unique within the object definition. Not nullable.
                  - `[ReferencedObjects <IMicrosoftGraphReferencedObject[]>]`: For attributes with reference type, lists referenced objects (for example, the manager attribute would list User as the referenced object).
                    - `[ReferencedObjectName <String>]`: Name of the referenced object. Must match one of the objects in the directory definition.
                    - `[ReferencedProperty <String>]`: Currently not supported. Name of the property in the referenced object, the value for which is used as the reference.
                  - `[Required <Boolean?>]`: true if attribute is required. Object can not be created if any of the required attributes are missing. If during synchronization, the required attribute has no value, the default value will be used. If default the value was not set, synchronization will record an error.
                  - `[Type <String>]`: attributeType
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: 
                - `[Name <String>]`: 
                - `[SupportedApis <String[]>]`: 
              - `[ReadOnly <Boolean?>]`: 
              - `[Version <String>]`: Read only value that indicates version discovered. null if discovery has not yet occurred.
            - `[SynchronizationRules <IMicrosoftGraphSynchronizationRule[]>]`: A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.
              - `[Editable <Boolean?>]`: true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.
              - `[Id <String>]`: Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.
              - `[Metadata <IMicrosoftGraphStringKeyStringValuePair[]>]`: Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.
              - `[Name <String>]`: Human-readable name of the synchronization rule. Not nullable.
              - `[ObjectMappings <IMicrosoftGraphObjectMapping[]>]`: Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.
                - `[AttributeMappings <IMicrosoftGraphAttributeMapping[]>]`: Attribute mappings define which attributes to map from the source object into the target object and how they should flow. A number of functions are available to support the transformation of the original source values.
                  - `[DefaultValue <String>]`: Default value to be used in case the source property was evaluated to null. Optional.
                  - `[ExportMissingReferences <Boolean?>]`: For internal use only.
                  - `[FlowBehavior <String>]`: attributeFlowBehavior
                  - `[FlowType <String>]`: attributeFlowType
                  - `[MatchingPriority <Int32?>]`: If higher than 0, this attribute will be used to perform an initial match of the objects between source and target directories. The synchronization engine will try to find the matching object using attribute with lowest value of matching priority first. If not found, the attribute with the next matching priority will be used, and so on a until match is found or no more matching attributes are left. Only attributes that are expected to have unique values, such as email, should be used as matching attributes.
                  - `[Source <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                    - `[(Any) <Object>]`: This indicates any property can be added to this object.
                    - `[Expression <String>]`: 
                    - `[Name <String>]`: 
                    - `[Parameters <IMicrosoftGraphStringKeyAttributeMappingSourceValuePair[]>]`: 
                      - `[Key <String>]`: The name of the parameter.
                      - `[Value <IMicrosoftGraphAttributeMappingSource>]`: attributeMappingSource
                    - `[Type <String>]`: attributeMappingSourceType
                  - `[TargetAttributeName <String>]`: Name of the attribute on the target object.
                - `[Enabled <Boolean?>]`: When true, this object mapping will be processed during synchronization. When false, this object mapping will be skipped.
                - `[FlowTypes <String>]`: objectFlowTypes
                - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
                - `[Name <String>]`: Human-friendly name of the object mapping.
                - `[Scope <IMicrosoftGraphFilter>]`: filter
                  - `[(Any) <Object>]`: This indicates any property can be added to this object.
                  - `[CategoryFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to decide whether given object belongs and should be processed as part of this object mapping. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                    - `[Clauses <IMicrosoftGraphFilterClause[]>]`: Filter clauses (conditions) of this group. All clauses in a group must be satisfied in order for the filter group to evaluate to true.
                      - `[OperatorName <String>]`: Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.
                      - `[SourceOperandName <String>]`: Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.
                      - `[TargetOperand <IMicrosoftGraphFilterOperand>]`: filterOperand
                        - `[(Any) <Object>]`: This indicates any property can be added to this object.
                        - `[Values <String[]>]`: Collection of values.
                    - `[Name <String>]`: Human-readable name of the filter group.
                  - `[Groups <IMicrosoftGraphFilterGroup[]>]`: Filter group set used to decide whether given object is in scope for provisioning. This is the filter which should be used in most cases. If an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is not satisfied any longer, such object will get de-provisioned'. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                  - `[InputFilterGroups <IMicrosoftGraphFilterGroup[]>]`: *Experimental* Filter group set used to filter out objects at the early stage of reading them from the directory. If an object doesn't satisfy this filter it will not be processed further. Important to understand is that if an object used to satisfy this filter at a given moment, and then the object or the filter was changed so that filter is no longer satisfied, such object will NOT get de-provisioned. An object is considered in scope if ANY of the groups in the collection is evaluated to true.
                - `[SourceObjectName <String>]`: Name of the object in the source directory. Must match the object name from the source directory definition.
                - `[TargetObjectName <String>]`: Name of the object in target directory. Must match the object name from the target directory definition.
              - `[Priority <Int32?>]`: Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.
              - `[SourceDirectoryName <String>]`: Name of the source directory. Must match one of the directory definitions in synchronizationSchema.
              - `[TargetDirectoryName <String>]`: Name of the target directory. Must match one of the directory definitions in synchronizationSchema.
            - `[Version <String>]`: The version of the schema, updated automatically with every schema change.
          - `[Status <IMicrosoftGraphSynchronizationStatus>]`: synchronizationStatus
            - `[(Any) <Object>]`: This indicates any property can be added to this object.
            - `[Code <String>]`: synchronizationStatusCode
            - `[CountSuccessiveCompleteFailures <Int64?>]`: Number of consecutive times this job failed.
            - `[EscrowsPruned <Boolean?>]`: true if the job's escrows (object-level errors) were pruned during initial synchronization. Escrows can be pruned if during the initial synchronization, you reach the threshold of errors that would normally put the job in quarantine. Instead of going into quarantine, the synchronization process clears the job's errors and continues until the initial synchronization is completed. When the initial synchronization is completed, the job will pause and wait for the customer to clean up the errors.
            - `[LastExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[ActivityIdentifier <String>]`: Identifier of the job run.
              - `[CountEntitled <Int64?>]`: Count of processed entries that were assigned for this application.
              - `[CountEntitledForProvisioning <Int64?>]`: Count of processed entries that were assigned for provisioning.
              - `[CountEscrowed <Int64?>]`: Count of entries that were escrowed (errors).
              - `[CountEscrowedRaw <Int64?>]`: Count of entries that were escrowed, including system-generated escrows.
              - `[CountExported <Int64?>]`: Count of exported entries.
              - `[CountExports <Int64?>]`: Count of entries that were expected to be exported.
              - `[CountImported <Int64?>]`: Count of imported entries.
              - `[CountImportedDeltas <Int64?>]`: Count of imported delta-changes.
              - `[CountImportedReferenceDeltas <Int64?>]`: Count of imported delta-changes pertaining to reference changes.
              - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
                - `[(Any) <Object>]`: This indicates any property can be added to this object.
                - `[Code <String>]`: 
                - `[Message <String>]`: 
                - `[TenantActionable <Boolean?>]`: 
              - `[State <String>]`: synchronizationTaskExecutionResult
              - `[TimeBegan <DateTime?>]`: Time when this job run began. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[TimeEnded <DateTime?>]`: Time when this job run ended. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[LastSuccessfulExecution <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[LastSuccessfulExecutionWithExports <IMicrosoftGraphSynchronizationTaskExecution>]`: synchronizationTaskExecution
            - `[Progress <IMicrosoftGraphSynchronizationProgress[]>]`: Details of the progress of a job toward completion.
              - `[CompletedUnits <Int64?>]`: The numerator of a progress ratio; the number of units of changes already processed.
              - `[ProgressObservationDateTime <DateTime?>]`: The time of a progress observation as an offset in minutes from UTC.
              - `[TotalUnits <Int64?>]`: The denominator of a progress ratio; a number of units of changes to be processed to accomplish synchronization.
              - `[Units <String>]`: An optional description of the units.
            - `[Quarantine <IMicrosoftGraphSynchronizationQuarantine>]`: synchronizationQuarantine
              - `[(Any) <Object>]`: This indicates any property can be added to this object.
              - `[CurrentBegan <DateTime?>]`: Date and time when the quarantine was last evaluated and imposed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Error <IMicrosoftGraphSynchronizationError>]`: synchronizationError
              - `[NextAttempt <DateTime?>]`: Date and time when the next attempt to re-evaluate the quarantine will be made. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[Reason <String>]`: quarantineReason
              - `[SeriesBegan <DateTime?>]`: Date and time when the quarantine was first imposed in this series (a series starts when a quarantine is first imposed, and is reset as soon as the quarantine is lifted). The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
              - `[SeriesCount <Int64?>]`: Number of times in this series the quarantine was re-evaluated and left in effect (a series starts when quarantine is first imposed, and is reset as soon as quarantine is lifted).
            - `[SteadyStateFirstAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was first achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[SteadyStateLastAchievedTime <DateTime?>]`: The time when steady state (no more changes to the process) was last achieved. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
            - `[SynchronizedEntryCountByType <IMicrosoftGraphStringKeyLongValuePair[]>]`: Count of synchronized objects, listed by object type.
              - `[Key <String>]`: Key.
              - `[Value <Int64?>]`: Value.
            - `[TroubleshootingUrl <String>]`: In the event of an error, the URL with the troubleshooting steps for the issue.
          - `[SynchronizationJobSettings <IMicrosoftGraphKeyValuePair[]>]`: Settings associated with the job. Some settings are inherited from the template.
            - `[Name <String>]`: Name for this key-value pair. Possible names are: AdditionalWSFedEndpointCheckResult,  AllowedAuthenticationClassReferencesCheckResult, AlwaysRequireAuthenticationCheckResult,   AutoUpdateEnabledCheckResult, ClaimsProviderNameCheckResult, EncryptClaimsCheckResult,  EncryptedNameIdRequiredCheckResult, MonitoringEnabledCheckResult,NotBeforeSkewCheckResult,  RequestMFAFromClaimsProvidersCheckResult, SignedSamlRequestsRequiredCheckResult, AdditionalAuthenticationRulesCheckResult, TokenLifetimeCheckResult,  DelegationAuthorizationRulesCheckResult, IssuanceAuthorizationRulesCheckResult, IssuanceTransformRulesCheckResult.
            - `[Value <String>]`: Value for this key-value pair. Possible result values are 0 (when the validation check passed), 1 (when the validation check failed), or 2 (when the validation check is a warning).
          - `[TemplateId <String>]`: Identifier of the synchronization template this job is based on.
        - `[Secrets <IMicrosoftGraphSynchronizationSecretKeyStringValuePair[]>]`: 
          - `[Key <String>]`: synchronizationSecret
          - `[Value <String>]`: The value of the secret.
        - `[Templates <IMicrosoftGraphSynchronizationTemplate[]>]`: 
          - `[Id <String>]`: Read-only.
          - `[ApplicationId <String>]`: Identifier of the application this template belongs to.
          - `[Default <Boolean?>]`: true if this template is recommended to be the default for the application.
          - `[Description <String>]`: Description of the template.
          - `[Discoverable <Boolean?>]`: true if this template should appear in the collection of templates available for the application instance (service principal).
          - `[FactoryTag <String>]`: One of the well-known factory tags supported by the synchronization engine. The factoryTag tells the synchronization engine which implementation to use when processing jobs based on this template.
          - `[Metadata <IMicrosoftGraphMetadataEntry[]>]`: Additional extension properties. Unless mentioned explicitly, metadata values should not be changed.
          - `[Schema <IMicrosoftGraphSynchronizationSchema>]`: synchronizationSchema
      - `[Tags <String[]>]`: Custom strings that can be used to categorize and identify the application. Not nullable.
      - `[TokenEncryptionKeyId <String>]`: Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.
      - `[TokenIssuancePolicies <IMicrosoftGraphTokenIssuancePolicy1[]>]`: 
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[TokenLifetimePolicies <IMicrosoftGraphTokenLifetimePolicy1[]>]`: The tokenLifetimePolicies assigned to this application.
        - `[AppliesTo <IMicrosoftGraphDirectoryObject[]>]`: 
        - `[Definition <String[]>]`: A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        - `[IsOrganizationDefault <Boolean?>]`: If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        - `[Description <String>]`: Description for this policy.
        - `[DisplayName <String>]`: Display name for this policy.
        - `[DeletedDateTime <DateTime?>]`: 
        - `[Id <String>]`: Read-only.
      - `[UniqueName <String>]`: The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.
      - `[Web <IMicrosoftGraphWebApplication1>]`: webApplication
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[HomePageUrl <String>]`: Home page or landing page of the application.
        - `[ImplicitGrantSettings <IMicrosoftGraphImplicitGrantSettings>]`: implicitGrantSettings
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[EnableAccessTokenIssuance <Boolean?>]`: Specifies whether this web application can request an access token using the OAuth 2.0 implicit flow.
          - `[EnableIdTokenIssuance <Boolean?>]`: Specifies whether this web application can request an ID token using the OAuth 2.0 implicit flow.
        - `[LogoutUrl <String>]`: Specifies the URL that will be used by Microsoft's authorization service to logout an user using front-channel, back-channel or SAML logout protocols.
        - `[Oauth2AllowImplicitFlow <Boolean?>]`: 
        - `[RedirectUris <String[]>]`: Specifies the URLs where user tokens are sent for sign-in, or the redirect URIs where OAuth 2.0 authorization codes and access tokens are sent.
    - `[ConnectorGroupType <String>]`: connectorGroupType
    - `[IsDefault <Boolean?>]`: Indicates if the connectorGroup is the default connectorGroup. Only a single connector group can be the default connectorGroup and this is pre-set by the system. Read-only.
    - `[Members <IMicrosoftGraphConnector[]>]`: Read-only. Nullable.
    - `[Name <String>]`: The name associated with the connectorGroup.
    - `[Region <String>]`: connectorGroupRegion
  - `[Status <String>]`: connectorStatus

HYBRIDAGENTUPDATERCONFIGURATION <IMicrosoftGraphHybridAgentUpdaterConfiguration>: hybridAgentUpdaterConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[AllowUpdateConfigurationOverride <Boolean?>]`: Indicates if updater configuration will be skipped and the agent will receive an update when the next version of the agent is available.
  - `[DeferUpdateDateTime <DateTime?>]`: The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
  - `[UpdateWindow <IMicrosoftGraphUpdateWindow>]`: updateWindow
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[UpdateWindowEndTime <String>]`: End of a time window during which agents can receive updates
    - `[UpdateWindowStartTime <String>]`: Start of a time window during which agents can receive updates

PUBLISHEDRESOURCES <IMicrosoftGraphPublishedResource[]>: List of existing publishedResource objects. Read-only. Nullable.
  - `[Id <String>]`: Read-only.
  - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that a publishedResource is assigned to. Read-only. Nullable.
    - `[Id <String>]`: Read-only.
    - `[Agents <IMicrosoftGraphOnPremisesAgent[]>]`: List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
      - `[Id <String>]`: Read-only.
      - `[AgentGroups <IMicrosoftGraphOnPremisesAgentGroup[]>]`: List of onPremisesAgentGroups that an onPremisesAgent is assigned to. Read-only. Nullable.
      - `[ExternalIP <String>]`: The external IP address as detected by the service for the agent machine. Read-only
      - `[MachineName <String>]`: The name of the machine that the aggent is running on. Read-only
      - `[Status <String>]`: agentStatus
      - `[SupportedPublishingTypes <String[]>]`: 
    - `[DisplayName <String>]`: Display name of the onPremisesAgentGroup.
    - `[IsDefault <Boolean?>]`: Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
    - `[PublishedResources <IMicrosoftGraphPublishedResource[]>]`: List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
    - `[PublishingType <String>]`: onPremisesPublishingType
  - `[DisplayName <String>]`: Display Name of the publishedResource.
  - `[PublishingType <String>]`: onPremisesPublishingType
  - `[ResourceName <String>]`: Name of the publishedResource.

## RELATED LINKS

## RELATED LINKS
