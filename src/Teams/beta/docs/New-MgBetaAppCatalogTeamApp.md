---
external help file:
Module Name: Microsoft.Graph.Beta.Teams
online version: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.teams/new-mgbetaappcatalogteamapp
schema: 2.0.0
---

# New-MgBetaAppCatalogTeamApp

## SYNOPSIS
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

## SYNTAX

### CreateExpanded (Default)
```
New-MgBetaAppCatalogTeamApp [-AdditionalProperties <Hashtable>]
 [-AppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>] [-DisplayName <String>]
 [-DistributionMethod <String>] [-ExternalId <String>] [-Id <String>] [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Create
```
New-MgBetaAppCatalogTeamApp -BodyParameter <IMicrosoftGraphTeamsApp> [-ResponseHeadersVariable <String>]
 [-Headers <IDictionary>] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Publish an app to the Microsoft Teams app catalog.\nSpecifically, this API publishes the app to your organization's catalog (the tenant app catalog);\nthe created resource has a distributionMethod property value of organization.
The requiresReview property allows any user to submit an app for review by an administrator.
Admins can approve or reject these apps via this API or the Microsoft Teams admin center.

## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Teams
```

$params = [Zip file containing a Teams app package]


New-MgBetaAppCatalogTeamApp -BodyParameter $params

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Import-Module Microsoft.Graph.Beta.Teams
```

New-MgBetaAppCatalogTeamApp -Requiresreview true

## PARAMETERS

### -AdditionalProperties
Additional Parameters

```yaml
Type: System.Collections.Hashtable
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AppDefinitions
The details for each version of the app.
To construct, see NOTES section for APPDEFINITIONS properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsAppDefinition[]
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -BodyParameter
teamsApp
To construct, see NOTES section for BODYPARAMETER properties and create a hash table.

```yaml
Type: Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsApp
Parameter Sets: Create
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DisplayName
The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DistributionMethod
teamsAppDistributionMethod

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ExternalId
The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

```yaml
Type: System.String
Parameter Sets: CreateExpanded
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
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
Parameter Sets: CreateExpanded
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

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsApp

### System.Collections.IDictionary

## OUTPUTS

### Microsoft.Graph.Beta.PowerShell.Models.IMicrosoftGraphTeamsApp

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`APPDEFINITIONS <IMicrosoftGraphTeamsAppDefinition[]>`: The details for each version of the app.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
  - `[Authorization <IMicrosoftGraphTeamsAppAuthorization>]`: teamsAppAuthorization
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[RequiredPermissionSet <IMicrosoftGraphTeamsAppPermissionSet>]`: teamsAppPermissionSet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[ResourceSpecificPermissions <IMicrosoftGraphTeamsAppResourceSpecificPermission[]>]`: A collection of resource-specific permissions.
        - `[PermissionType <String>]`: teamsAppResourceSpecificPermissionType
        - `[PermissionValue <String>]`: The name of the resource-specific permission.
  - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
  - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
      - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
    - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
  - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
    - `[(Any) <Object>]`: This indicates any property can be added to this object.
    - `[Application <IMicrosoftGraphIdentity>]`: identity
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
      - `[Id <String>]`: The identifier of the identity. This property is read-only.
    - `[Device <IMicrosoftGraphIdentity>]`: identity
    - `[User <IMicrosoftGraphIdentity>]`: identity
  - `[DashboardCards <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>]`: Dashboard cards specified in the Teams app manifest.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ContentSource <IMicrosoftGraphTeamsAppDashboardCardContentSource>]`: teamsAppDashboardCardContentSource
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[BotConfiguration <IMicrosoftGraphTeamsAppDashboardCardBotConfiguration>]`: teamsAppDashboardCardBotConfiguration
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BotId <String>]`: The ID (usually a GUID) of the bot associated with the specific teamsAppDefinition. This is a unique app ID for the bot as registered with the Bot Framework.
      - `[SourceType <String>]`: teamsAppDashboardCardSourceType
    - `[DefaultSize <String>]`: teamsAppDashboardCardSize
    - `[Description <String>]`: The description for the card. Required.
    - `[DisplayName <String>]`: The name of the card. Required.
    - `[Icon <IMicrosoftGraphTeamsAppDashboardCardIcon>]`: teamsAppDashboardCardIcon
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[IconUrl <String>]`: The icon for the card, displayed in the toolbox and card bar, is represented as a URL. The preferred size for raster images is 28x28 pixels. If this property has a value, the officeFabricIconFontName property is ignored.
      - `[OfficeUiFabricIconName <String>]`: The friendly name of the Office UI Fabric/Fluent UI icon for the card that is used when the iconUrl property isn't specified. For example, 'officeUIFabricIconName': 'Search'.
    - `[PickerGroupId <String>]`: ID for the group in the card picker. Required.
  - `[Description <String>]`: 
  - `[DisplayName <String>]`: The name of the app provided by the app developer.
  - `[LastModifiedDateTime <DateTime?>]`: 
  - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
  - `[PublishingState <String>]`: teamsAppPublishingState
  - `[Shortdescription <String>]`: 
  - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
  - `[Version <String>]`: The version number of the application.

`BODYPARAMETER <IMicrosoftGraphTeamsApp>`: teamsApp
  - `[(Any) <Object>]`: This indicates any property can be added to this object.
  - `[Id <String>]`: The unique identifier for an entity. Read-only.
  - `[AppDefinitions <IMicrosoftGraphTeamsAppDefinition[]>]`: The details for each version of the app.
    - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[AllowedInstallationScopes <String>]`: teamsAppInstallationScopes
    - `[Authorization <IMicrosoftGraphTeamsAppAuthorization>]`: teamsAppAuthorization
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[RequiredPermissionSet <IMicrosoftGraphTeamsAppPermissionSet>]`: teamsAppPermissionSet
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[ResourceSpecificPermissions <IMicrosoftGraphTeamsAppResourceSpecificPermission[]>]`: A collection of resource-specific permissions.
          - `[PermissionType <String>]`: teamsAppResourceSpecificPermissionType
          - `[PermissionValue <String>]`: The name of the resource-specific permission.
    - `[AzureAdAppId <String>]`: The WebApplicationInfo.Id from the Teams app manifest.
    - `[Bot <IMicrosoftGraphTeamworkBot>]`: teamworkBot
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
    - `[ColorIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[HostedContent <IMicrosoftGraphTeamworkHostedContent>]`: teamworkHostedContent
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[Id <String>]`: The unique identifier for an entity. Read-only.
        - `[ContentBytes <Byte[]>]`: Write only. Bytes for the hosted content (such as images).
        - `[ContentType <String>]`: Write only. Content type, such as image/png, image/jpg.
      - `[WebUrl <String>]`: The web URL that can be used for downloading the image.
    - `[CreatedBy <IMicrosoftGraphIdentitySet>]`: identitySet
      - `[(Any) <Object>]`: This indicates any property can be added to this object.
      - `[Application <IMicrosoftGraphIdentity>]`: identity
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[DisplayName <String>]`: The display name of the identity. This property is read-only.
        - `[Id <String>]`: The identifier of the identity. This property is read-only.
      - `[Device <IMicrosoftGraphIdentity>]`: identity
      - `[User <IMicrosoftGraphIdentity>]`: identity
    - `[DashboardCards <IMicrosoftGraphTeamsAppDashboardCardDefinition[]>]`: Dashboard cards specified in the Teams app manifest.
      - `[Id <String>]`: The unique identifier for an entity. Read-only.
      - `[ContentSource <IMicrosoftGraphTeamsAppDashboardCardContentSource>]`: teamsAppDashboardCardContentSource
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[BotConfiguration <IMicrosoftGraphTeamsAppDashboardCardBotConfiguration>]`: teamsAppDashboardCardBotConfiguration
          - `[(Any) <Object>]`: This indicates any property can be added to this object.
          - `[BotId <String>]`: The ID (usually a GUID) of the bot associated with the specific teamsAppDefinition. This is a unique app ID for the bot as registered with the Bot Framework.
        - `[SourceType <String>]`: teamsAppDashboardCardSourceType
      - `[DefaultSize <String>]`: teamsAppDashboardCardSize
      - `[Description <String>]`: The description for the card. Required.
      - `[DisplayName <String>]`: The name of the card. Required.
      - `[Icon <IMicrosoftGraphTeamsAppDashboardCardIcon>]`: teamsAppDashboardCardIcon
        - `[(Any) <Object>]`: This indicates any property can be added to this object.
        - `[IconUrl <String>]`: The icon for the card, displayed in the toolbox and card bar, is represented as a URL. The preferred size for raster images is 28x28 pixels. If this property has a value, the officeFabricIconFontName property is ignored.
        - `[OfficeUiFabricIconName <String>]`: The friendly name of the Office UI Fabric/Fluent UI icon for the card that is used when the iconUrl property isn't specified. For example, 'officeUIFabricIconName': 'Search'.
      - `[PickerGroupId <String>]`: ID for the group in the card picker. Required.
    - `[Description <String>]`: 
    - `[DisplayName <String>]`: The name of the app provided by the app developer.
    - `[LastModifiedDateTime <DateTime?>]`: 
    - `[OutlineIcon <IMicrosoftGraphTeamsAppIcon>]`: teamsAppIcon
    - `[PublishingState <String>]`: teamsAppPublishingState
    - `[Shortdescription <String>]`: 
    - `[TeamsAppId <String>]`: The ID from the Teams app manifest.
    - `[Version <String>]`: The version number of the application.
  - `[DisplayName <String>]`: The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.
  - `[DistributionMethod <String>]`: teamsAppDistributionMethod
  - `[ExternalId <String>]`: The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.

## RELATED LINKS

