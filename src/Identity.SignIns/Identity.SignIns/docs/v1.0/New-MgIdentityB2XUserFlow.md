---
external help file:
Module Name: Microsoft.Graph.Identity.SignIns
online version: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.identity.signins/new-mgidentityb2xuserflow
schema: 2.0.0
---

# New-MgIdentityB2XUserFlow

## SYNOPSIS
Create new navigation property to b2xUserFlows for identity

## SYNTAX

### CreateExpanded1 (Default)
```
New-MgIdentityB2XUserFlow [-AdditionalProperties <Hashtable>]
 [-ApiConnectorConfiguration <IMicrosoftGraphUserFlowApiConnectorConfiguration>] [-Id <String>]
 [-IdentityProviders <IMicrosoftGraphIdentityProvider[]>]
 [-Languages <IMicrosoftGraphUserFlowLanguageConfiguration[]>]
 [-UserAttributeAssignments <IMicrosoftGraphIdentityUserFlowAttributeAssignment[]>]
 [-UserFlowIdentityProviders <IMicrosoftGraphIdentityProviderBase[]>] [-UserFlowType <String>]
 [-UserFlowTypeVersion <Single>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create1
```
New-MgIdentityB2XUserFlow -BodyParameter <IMicrosoftGraphB2XIdentityUserFlow> [-Confirm] [-WhatIf]
 [<CommonParameters>]
```

## DESCRIPTION
Create new navigation property to b2xUserFlows for identity

## EXAMPLES

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ApiConnectorConfiguration
userFlowApiConnectorConfiguration
To construct, please use Get-Help -Online and see NOTES section for APICONNECTORCONFIGURATION properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserFlowApiConnectorConfiguration
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
b2xIdentityUserFlow
To construct, please use Get-Help -Online and see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphB2XIdentityUserFlow
Parameter Sets: Create1
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Id
.

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -IdentityProviders
The identity providers included in the user flow.
To construct, please use Get-Help -Online and see NOTES section for IDENTITYPROVIDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProvider[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Languages
The languages supported for customization within the user flow.
Language customization is enabled by default in self-service sign up user flow.
You cannot create custom languages in self-service sign up user flows.
To construct, please use Get-Help -Online and see NOTES section for LANGUAGES properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphUserFlowLanguageConfiguration[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserAttributeAssignments
The user attribute assignments included in the user flow.
To construct, please use Get-Help -Online and see NOTES section for USERATTRIBUTEASSIGNMENTS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityUserFlowAttributeAssignment[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserFlowIdentityProviders
.
To construct, please use Get-Help -Online and see NOTES section for USERFLOWIDENTITYPROVIDERS properties and create a hash table.

```yaml
Type: Microsoft.Graph.PowerShell.Models.IMicrosoftGraphIdentityProviderBase[]
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserFlowType
userFlowType

```yaml
Type: System.String
Parameter Sets: CreateExpanded1
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -UserFlowTypeVersion
.

```yaml
Type: System.Single
Parameter Sets: CreateExpanded1
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

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphB2XIdentityUserFlow

## OUTPUTS

### Microsoft.Graph.PowerShell.Models.IMicrosoftGraphB2XIdentityUserFlow

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


APICONNECTORCONFIGURATION <IMicrosoftGraphUserFlowApiConnectorConfiguration>: userFlowApiConnectorConfiguration
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[PostAttributeCollection <IMicrosoftGraphIdentityApiConnector>]`: identityApiConnector
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[AuthenticationConfiguration <IMicrosoftGraphApiAuthenticationConfigurationBase>]`: apiAuthenticationConfigurationBase
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[DisplayName <String>]`: The name of the API connector.
    - `[TargetUrl <String>]`: The URL of the API endpoint to call.
  - `[PostFederationSignup <IMicrosoftGraphIdentityApiConnector>]`: identityApiConnector

BODYPARAMETER <IMicrosoftGraphB2XIdentityUserFlow>: b2xIdentityUserFlow
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[UserFlowType <String>]`: userFlowType
  - `[UserFlowTypeVersion <Single?>]`: 
  - `[Id <String>]`: 
  - `[ApiConnectorConfiguration <IMicrosoftGraphUserFlowApiConnectorConfiguration>]`: userFlowApiConnectorConfiguration
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[PostAttributeCollection <IMicrosoftGraphIdentityApiConnector>]`: identityApiConnector
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[AuthenticationConfiguration <IMicrosoftGraphApiAuthenticationConfigurationBase>]`: apiAuthenticationConfigurationBase
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The name of the API connector.
      - `[TargetUrl <String>]`: The URL of the API endpoint to call.
    - `[PostFederationSignup <IMicrosoftGraphIdentityApiConnector>]`: identityApiConnector
  - `[IdentityProviders <IMicrosoftGraphIdentityProvider[]>]`: The identity providers included in the user flow.
    - `[Id <String>]`: 
    - `[ClientId <String>]`: The client ID for the application obtained when registering the application with the identity provider. This is a required field.  Required. Not nullable.
    - `[ClientSecret <String>]`: The client secret for the application obtained when registering the application with the identity provider. This is write-only. A read operation will return ****. This is a required field. Required. Not nullable.
    - `[Name <String>]`: The display name of the identity provider. Not nullable.
    - `[Type <String>]`: The identity provider type is a required field. For B2B scenario: Google, Facebook. For B2C scenario: Microsoft, Google, Amazon, LinkedIn, Facebook, GitHub, Twitter, Weibo,QQ, WeChat, OpenIDConnect. Not nullable.
  - `[Languages <IMicrosoftGraphUserFlowLanguageConfiguration[]>]`: The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign up user flow. You cannot create custom languages in self-service sign up user flows.
    - `[Id <String>]`: 
    - `[DefaultPages <IMicrosoftGraphUserFlowLanguagePage[]>]`: Collection of pages with the default content to display in a user flow for a specified language. This collection does not allow any kind of modification.
      - `[Id <String>]`: 
    - `[DisplayName <String>]`: The language name to display. This property is read-only.
    - `[IsEnabled <Boolean?>]`: Indicates whether the language is enabled within the user flow.
    - `[OverridesPages <IMicrosoftGraphUserFlowLanguagePage[]>]`: Collection of pages with the overrides messages to display in a user flow for a specified language. This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).
  - `[UserAttributeAssignments <IMicrosoftGraphIdentityUserFlowAttributeAssignment[]>]`: The user attribute assignments included in the user flow.
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The display name of the identityUserFlowAttribute within a user flow.
    - `[IsOptional <Boolean?>]`: Determines whether the identityUserFlowAttribute is optional. true means the user doesn't have to provide a value. false means the user cannot complete sign-up without providing a value.
    - `[RequiresVerification <Boolean?>]`: Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user's phone number or email address.
    - `[UserAttribute <IMicrosoftGraphIdentityUserFlowAttribute>]`: identityUserFlowAttribute
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: 
      - `[DataType <String>]`: identityUserFlowAttributeDataType
      - `[Description <String>]`: The description of the user flow attribute that's shown to the user at the time of sign-up.
      - `[DisplayName <String>]`: The display name of the user flow attribute.
      - `[UserFlowAttributeType <String>]`: identityUserFlowAttributeType
    - `[UserAttributeValues <IMicrosoftGraphUserAttributeValuesItem[]>]`: The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.
      - `[IsDefault <Boolean?>]`: Used to set the value as the default.
      - `[Name <String>]`: The display name of the property displayed to the end user in the user flow.
      - `[Value <String>]`: The value that is set when this item is selected.
    - `[UserInputType <String>]`: identityUserFlowAttributeInputType
  - `[UserFlowIdentityProviders <IMicrosoftGraphIdentityProviderBase[]>]`: 
    - `[Id <String>]`: 
    - `[DisplayName <String>]`: The display name of the identity provider.

IDENTITYPROVIDERS <IMicrosoftGraphIdentityProvider[]>: The identity providers included in the user flow.
  - `[Id <String>]`: 
  - `[ClientId <String>]`: The client ID for the application obtained when registering the application with the identity provider. This is a required field.  Required. Not nullable.
  - `[ClientSecret <String>]`: The client secret for the application obtained when registering the application with the identity provider. This is write-only. A read operation will return ****. This is a required field. Required. Not nullable.
  - `[Name <String>]`: The display name of the identity provider. Not nullable.
  - `[Type <String>]`: The identity provider type is a required field. For B2B scenario: Google, Facebook. For B2C scenario: Microsoft, Google, Amazon, LinkedIn, Facebook, GitHub, Twitter, Weibo,QQ, WeChat, OpenIDConnect. Not nullable.

LANGUAGES <IMicrosoftGraphUserFlowLanguageConfiguration[]>: The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign up user flow. You cannot create custom languages in self-service sign up user flows.
  - `[Id <String>]`: 
  - `[DefaultPages <IMicrosoftGraphUserFlowLanguagePage[]>]`: Collection of pages with the default content to display in a user flow for a specified language. This collection does not allow any kind of modification.
    - `[Id <String>]`: 
  - `[DisplayName <String>]`: The language name to display. This property is read-only.
  - `[IsEnabled <Boolean?>]`: Indicates whether the language is enabled within the user flow.
  - `[OverridesPages <IMicrosoftGraphUserFlowLanguagePage[]>]`: Collection of pages with the overrides messages to display in a user flow for a specified language. This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).

USERATTRIBUTEASSIGNMENTS <IMicrosoftGraphIdentityUserFlowAttributeAssignment[]>: The user attribute assignments included in the user flow.
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The display name of the identityUserFlowAttribute within a user flow.
  - `[IsOptional <Boolean?>]`: Determines whether the identityUserFlowAttribute is optional. true means the user doesn't have to provide a value. false means the user cannot complete sign-up without providing a value.
  - `[RequiresVerification <Boolean?>]`: Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user's phone number or email address.
  - `[UserAttribute <IMicrosoftGraphIdentityUserFlowAttribute>]`: identityUserFlowAttribute
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: 
    - `[DataType <String>]`: identityUserFlowAttributeDataType
    - `[Description <String>]`: The description of the user flow attribute that's shown to the user at the time of sign-up.
    - `[DisplayName <String>]`: The display name of the user flow attribute.
    - `[UserFlowAttributeType <String>]`: identityUserFlowAttributeType
  - `[UserAttributeValues <IMicrosoftGraphUserAttributeValuesItem[]>]`: The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.
    - `[IsDefault <Boolean?>]`: Used to set the value as the default.
    - `[Name <String>]`: The display name of the property displayed to the end user in the user flow.
    - `[Value <String>]`: The value that is set when this item is selected.
  - `[UserInputType <String>]`: identityUserFlowAttributeInputType

USERFLOWIDENTITYPROVIDERS <IMicrosoftGraphIdentityProviderBase[]>: .
  - `[Id <String>]`: 
  - `[DisplayName <String>]`: The display name of the identity provider.

## RELATED LINKS

