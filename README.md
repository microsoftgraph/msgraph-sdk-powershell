<h1 align="center">
    <img alt="Microsoft Graph PowerShell" src="./docs/images/graph_color256.png" height="78" />
  <br>Microsoft Graph PowerShell<br>
</h1>

<h4 align="center">
  Consume <a href="https://graph.microsoft.com">Microsoft Graph</a> resources directly from your PowerShell scripts
</h4>

<h3 align="center"><a href="https://learn.microsoft.com/powershell/microsoftgraph/overview">Documentation</a></h3>

<p align="center">
The Microsoft Graph PowerShell module consists of a collection of PowerShell modules that contain commands for calling Microsoft Graph API. The module acts as an API wrapper for the Microsoft Graph APIs, exposing the entire API set for use in PowerShell.
</p>

<p align="center">
  <a href="#modules">Modules</a> |
  <a href="#getting-started">Getting Started</a> |
  <a href="#api-version">API Version</a> |
  <a href="#notes">Notes</a> |
  <a href="#troubleshooting">Troubleshooting</a> |
  <a href="#known-issues">Known Issues</a> |
  <a href="#feedback">Feedback</a> |
  <a href="#license">License</a>
</p>

## Modules

The table below contains links to our latest and preview versions of the Microsoft Graph module. The meta modules will install all the service modules as their dependencies.
| Module                                  | Latest             | Preview                        |
| --------------------------------------- | ------------------ | ------------------------------ |
| [`Microsoft.Graph`][mggallery]          | [![mg]][mggallery] | [![mgnext]][mggallery]         |
| [`Microsoft.Graph.Beta`][mggallerybeta] | -                  | [![mgbetaNext]][mggallerybeta] |

See [Microsoft Graph PowerShell modules](https://github.com/microsoftgraph/msgraph-sdk-powershell/wiki/MS-Graph-PowerShell-Modules) for a list of all modules supported by this repository.

## Getting Started

### 1. Installation

Microsoft Graph PowerShell module is published on [PowerShell Gallery](https://www.powershellgallery.com/packages/Microsoft.Graph). Installing is as simple as:

```powershell
Install-Module Microsoft.Graph -AllowPrerelease
```

> Run `Install-Module` with AllowClobber and Force parameters if you run into command name conflicts when upgrading to older versions of the module:
>
> ```powershell
> Install-Module Microsoft.Graph -AllowPrerelease -AllowClobber -Force
> ```

See [Install the Microsoft Graph PowerShell Module](https://learn.microsoft.com/powershell/microsoftgraph/installation) guide for detailed installation instructions.

### 2. Authentication

The module supports two main types of authentication:

#### Delegated access

Get access to Microsoft Graph resources on behalf of a user.

```powershell
# Using interactive authentication.
Connect-MgGraph -Scopes "User.ReadBasic.All", "Application.ReadWrite.All"
```

#### App-only access (client credentials grant flow)

Get access to Microsoft Graph resources using the identity on an app and not on behalf of a user.

```powershell
# Using -CertificateThumbprint
Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
```

See [Authentication](./docs/authentication.md) for more information on usage of `Connect-MgGraph`.

### 3. List users in your tenant

```powershell
Get-MgUser -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
```

### 4. Filter a user in your tenant

```powershell
$User = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
```

### 5. Create a new app registration

```powershell
New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                  -SignInAudience "AzureADMyOrg" `
                  -Web @{ RedirectUris = "https://localhost"}
```

### 6. Sign out of the current logged-in context i.e. app only or delegated access

```powershell
Disconnect-MgGraph
```

## API Version

Install `Microsoft.Graph.Beta` module to commands that call Microsoft Graph Beta API endpoint.

```powershell
Install-Module Microsoft.Graph.Beta -AllowPrerelease
# Consume Microsoft Graph beta resources.
Connect-MgGraph
$Users = Get-MgBetaUser
```

## Notes

### Upgrading to v2

The following breaking changes have been introduced between `v1.x` and `v2.x`:

- Dropped profile support.
- Dropped support for `-ForceRefresh` on `Connect-MgGraph`.
- Renamed `beta` command names from `<Verb>-Mg<Noun>` to `<Verb>-MgBeta<Noun>`.
- Changed beta namespace from `Microsoft.Graph.PowerShell.Models.<Entity>` to `Microsoft.Graph.Beta.PowerShell.Models.<Entity>`.
- Changed `-AccessToken` type on `Connect-MgGraph` from `String` to `SecureString`.

See [v2 upgrade guide](https://github.com/microsoftgraph/msgraph-sdk-powershell/blob/features/2.0/docs/upgrade-to-v2.md) for more details.

## Troubleshooting

### Permission Related Errors

When working with various operations in the Graph, you may encounter an error such as "Insufficient privileges to complete the operation." For example, this particular error can occur when using the `New-MgApplication` command if the appropriate permissions are not granted.

If permission-related errors occur and the signed in user/app has been granted the appropriate permissions to perform the operation, you can explicitly fetch a new access token by running `Disconnect-MgGraph`, then `Connect-MgGraph`. This will trigger a refresh of the access token in your cache. Microsoft Authentication Library (MSAL) will only refresh access tokens in your cache if they have expired (usually an hour).

### Common Errors

See our [troubleshooting guide](https://learn.microsoft.com/powershell/microsoftgraph/troubleshooting) for detailed view on how to troubleshoot common errors when using Microsoft Graph.

## Known Issues

- Using `-Property {PropertyName}` parameter will not select the property as the output of the command. All commands return CLR objects, and customers should pipe the command outputs to `Format-Table` or `Select-Object` to return individual properties.

- Customers upgrading from previous versions of the SDK may encounter auth prompts on every command call. If this happens, one can use the following steps to reset their token cache:
  - Use `Disconnect-MgGraph` to sign out of the current session.
  - Run `Remove-Item "$env:USERPROFILE\.graph" -Recurse -Force` to delete your token cache.
  - Run `Connect-MgGraph` to reconstruct a clean token cache.

## Feedback

If you find any bugs when using the Microsoft Graph PowerShell modules, please file an issue on our GitHub issues page.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt).

<!-- References -->

<!-- Shields -->

[mg]: https://img.shields.io/powershellgallery/v/Microsoft.Graph.svg?style=flat-square&label=Microsoft.Graph
[mgnext]: https://img.shields.io/powershellgallery/v/Microsoft.Graph.svg?include_prereleases&style=flat-square&label=Microsoft.Graph
[mgbetanext]: https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.svg?include_prereleases&style=flat-square&label=Microsoft.Graph.Beta

<!-- PS Gallery -->

[mggallery]: https://www.powershellgallery.com/packages/Microsoft.Graph/
[mggallerybeta]: https://www.powershellgallery.com/packages/Microsoft.Graph.Beta/
