# Microsoft Graph PowerShell SDK

The Microsoft Graph PowerShell SDK is a collection of PowerShell modules that contain commands for calling Microsoft Graph service.

## Modules

The table below contains our Microsoft Graph rollup module. This module installs all the service modules as its dependencies.
Description       | Module Name       | PowerShell Gallery Link
----------------- | ----------------- | ------------------------
Microsoft Graph   | `Microsoft.Graph` | [![Mg]][MgGallery]

For a list of modules found in this repository, see the [Microsoft Graph PowerShell modules](https://github.com/microsoftgraph/msgraph-sdk-powershell/wiki/MS-Graph-PowerShell-Modules) document.

## Installation

### PowerShell Gallery

All the modules are published on [PowerShell Gallery](https://www.powershellgallery.com/packages/Microsoft.Graph). Installing is as simple as:

``` powershell
Install-Module Microsoft.Graph
```

If you are upgrading from our preview modules, run `Install-Module` with AllowClobber and Force parameters to avoid command name conflicts:

``` powershell
 Install-Module Microsoft.Graph -AllowClobber -Force
```

There is a set of samples in the `samples` folder to help in getting started with the library. If you have an older version of these modules installed, there are extra uninstall instructions in the [InstallModule](./samples/0-InstallModule.ps1) script.

## Usage

* [Authentication](./README.md#authentication)

* [Users](./README.md#users)

* [Cloud Environment](./README.md#cloud-environment)

## Authentication
The SDK supports two types of authentication: delegated access and app-only access.
- Delegated access.

    ``` powershell
    # Using interactive authentication.
    Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All"
    ```

    or

    ``` powershell
    # Using device code flow.
    Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All" -UseDeviceAuthentication
    ```

    or

    ``` powershell
    # Using your own access token.
    Connect-MgGraph -AccessToken $AccessToken
    ```

- App-only access via Client Credential with a certificate.

    The certificate will be loaded from `Cert:\CurrentUser\My\` store when `-CertificateThumbprint` or `-CertificateName` is specified. Ensure the certificate is present in the store before calling `Connect-MgGraph`.

    ``` powershell
    # Using -CertificateThumbprint
    Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
    ```

    or

    ``` powershell
    # Using -CertificateName
    Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateName "YOUR_CERT_SUBJECT"
    ```

    or

    ``` powershell
    # Using -Certificate
    $Cert = Get-ChildItem Cert:\LocalMachine\My\$CertThumbprint
    Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -Certificate $Cert
    ```
## Users

1. List users in your tenant.

    ``` powershell
    Get-MgUser -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
    ```

2. Filter a user in your tenant.

    ``` powershell
    $user = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
    ```

3. Create a new app registration.

    ``` powershell
    New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                      -SignInAudience "AzureADMyOrg" `
                      -Web @{ RedirectUris = "https://localhost"}
    ```

4. Sign out of the current logged-in context i.e. app only or delegated access.

    ``` powershell
    Disconnect-MgGraph
    ```

## Cloud Environment

The SDK supports managing of cloud environments through `Get-MgEnvironment`, `Set-MgEnvironment`, `Add-MgEnvironment`, and `remove-MgEnvironment` commands
- Add Microsoft Graph Environment.

    A `user-defined` environment type is added and the name passed as `-Environment` parameter on the `Connect-Mgraph` command for user to be able to switch to a cloud of choice. 
    - Delegated access

        ``` powershell
        # Using interactive authentication.
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All" -Environment $Env.Name
        ```
        or

        ``` powershell
        # Using device code flow.
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        Connect-MgGraph -Scopes "User.Read.All", "Group.ReadWrite.All" -UseDeviceAuthentication -Environment $Env.Name
        ```
        or

        ``` powershell   
        # Using your own access token.
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        Connect-MgGraph -AccessToken $AccessToken -Environment $Env.Name
        ```
    - App-only access via Client Credential with a certificate.
  
         ``` powershell
        # Using -CertificateThumbprint.
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        Connect-MgGraph -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT" -ClientId "YOUR_APP_ID" -Environment $Env.Name
        ```
        or

        ``` powershell
        # Using -CertificateName.
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateName "YOUR_CERT_SUBJECT" -Environment $Env.Name
        ```
        or

        ``` powershell
        # Using -Certificate
        $Env = Add-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT'
        $Cert = Get-ChildItem Cert:\LocalMachine\My\$CertThumbprint
        Connect-MgGraph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -Certificate $Cert -Environment $Env.Name
        ```
     - Get Microsoft Graph Environment.

        A collection of environments will be returned by using the `Get-MgEnvironment` command.

        ``` powershell
        Get-MgEnvironment
        ```
    - Set Microsoft Graph Environment.

        `Set-MgEnvironment` command switches to a `user-defined` environment type using the existing microsoft graph session

        ``` powershell
        Set-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT
        ```
    - Set Microsoft Graph Environment.

        `Remove-MgEnvironment` command removes an environment initially set by a user, from the existing microsoft graph session. It eventually defaults to Global.

        ``` powershell
        Remove-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME'
        ```

    

## API Version

By default, the SDK uses the Microsoft Graph REST API v1.0. You can change this by using the `Select-MgProfile` command. This reloads all modules and only loads commands that call beta endpoint.

``` powershell
Select-MgProfile -Name "beta"
```

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
