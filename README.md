# Microsoft Graph PowerShell Module

Consume [Microsoft Graph](https://developer.microsoft.com/graph) resources directly from your PowerShell scripts!

The Microsoft Graph PowerShell Module consists of a collection of PowerShell modules that contain commands for calling Microsoft Graph API. The module acts as an API wrapper for the Microsoft Graph APIs, exposing the entire API set for use in PowerShell.

## Modules

The table below contains a link to our latest Microsoft Graph meta module. This module installs all the service modules as their dependencies.
Description       | Module Name       | PowerShell Gallery Link
----------------- | ----------------- | ------------------------
Microsoft Graph   | `Microsoft.Graph` | [![Mg]][MgGallery]

See [Microsoft Graph PowerShell modules](https://github.com/microsoftgraph/msgraph-sdk-powershell/wiki/MS-Graph-PowerShell-Modules) for a list of all modules found in this repository, .

## Installation

### PowerShell Gallery

Microsoft Graph PowerShell module is published on [PowerShell Gallery](https://www.powershellgallery.com/packages/Microsoft.Graph). Installing is as simple as:

``` powershell
Install-Module Microsoft.Graph
```

> If you are upgrading from our preview modules, run `Install-Module` with AllowClobber and Force parameters to avoid command name conflicts:
>
>``` powershell
> Install-Module Microsoft.Graph -AllowClobber -Force
>```

See [Install the Microsoft Graph PowerShell Module](https://learn.microsoft.com/powershell/microsoftgraph/installation) for detailed installation instructions.
## Usage

### 1. Authentication

The module supports two types of authentication models:

#### Delegated access

Get access to Microsoft Graph resources on behalf of a user.

``` powershell
# Using interactive authentication.
Connect-MgGraph -Scopes "User.ReadBasic.All", "Application.ReadWrite.All"
```

#### App-only access (client credentials grant flow)

Get access to Microsoft Graph resources using the identity on an app and not on behalf of a user.

``` powershell
# Using -CertificateThumbprint
Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
```

> The certificate will be loaded from `Cert:\CurrentUser\My\` store when `-CertificateThumbprint` or `-CertificateName` is specified. Ensure the certificate is present in the store before calling `Connect-MgGraph`.

See [Authentication module cmdlets in Microsoft Graph PowerShell](https://learn.microsoft.com/powershell/microsoftgraph/authentication-commands) for more information.

### 2. List users in your tenant

``` powershell
Get-MgUser -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
```

### 3. Filter a user in your tenant

``` powershell
$User = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
```

### 4. Create a new app registration

``` powershell
New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                  -SignInAudience "AzureADMyOrg" `
                  -Web @{ RedirectUris = "https://localhost"}
```

### 5. Sign out of the current logged-in context i.e. app only or delegated access

``` powershell
Disconnect-MgGraph
```

## API Version

By default, the SDK uses the Microsoft Graph REST API v1.0. You can change this by using the `Select-MgProfile` command. This reloads all modules and only loads commands that call beta endpoint.

``` powershell
Select-MgProfile -Name "beta"
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

## Troubleshooting Permission Related Errors

When working with various operations in the Graph, you may encounter an error such as "Insufficient privileges to complete the operation." For example, this particular error can occur when using the `New-MgApplication` command if the appropriate permissions are not granted.

If permission-related errors occur and the user you authenticated within the popup has the appropriate permissions to perform the operation try these steps.

- You can try running `Disconnect-MgGraph`, then `Connect-MgGraph`.  Then, run the code that encountered the permission issues to see if it works.
- You can try running `Connect-MgGraph -ForceRefresh`.  This will trigger a refresh of the access token in your cache. MSAL will only refresh the access token in your cache if it has expired (usually an hour), or if you explicitly refresh it via `-ForceRefresh`. Then, run the code that encountered the permission issues to see if it works.

## Known Issues

- Using `-Property {PropertyName}` parameter will not select the property as the output of the command. All commands return CLR objects, and customers should pipe the command outputs to `Format-Table` or `Select-Object` to return individual properties.

- Customers upgrading from previous versions of the SDK may encounter auth prompts on every command call. If this happens, one can use the following steps to reset their token cache:
  - Use `Disconnect-MgGraph` to sign out of the current session.
  - Run `Remove-Item "$env:USERPROFILE\.graph" -Recurse -Force` to delete your token cache.
  - Run `Connect-MgGraph` to reconstruct a clean token cache.

## Issues

If you find any bugs when using the Microsoft Graph PowerShell modules, please file an issue on our GitHub issues page.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information, see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## License

Copyright (c) Microsoft Corporation. All Rights Reserved. Licensed under the MIT [license](LICENSE.txt).

<!-- References -->

<!-- Shields -->
[Mg]: https://img.shields.io/powershellgallery/v/Microsoft.Graph.svg?style=flat-square&label=Microsoft.Graph

<!-- PS Gallery -->
[MgGallery]: https://www.powershellgallery.com/packages/Microsoft.Graph/
