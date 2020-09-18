# Microsoft Graph PowerShell SDK Preview
The Microsoft Graph PowerShell SDK is a collection of PowerShell modules that contain commands for calling Microsoft Graph service.

## Installing the Microsoft.Graph Module

All the modules are published on [PowerShell Gallery](https://www.powershellgallery.com/packages/Microsoft.Graph). Installing is as simple as:

```ps
Install-Module Microsoft.Graph
```

If you are upgrading from our preview modules, run `Install-Module` with AllowClobber and Force parameter to avoid command name conflicts:
```ps
 Install-Module Microsoft.Graph -AllowClobber -Force
```

Given the large size of the API surface area, one can also install only the service module(s) they are interested in:
```ps
Install-Module Microsoft.Graph.Users
```
There are a set of samples in the `samples` folder to help in getting started with the library. If you have an older version of these modules installed, there are extra uninstall instructions in the [InstallModule](./samples/0-InstallModule.ps1) script.

## Usage

1. Authentication
    
    The SDK supports two types of authentication: delegated access, and app-oly access.
    - Delegated access via Device Code Flow.

        ```ps
        Connect-Graph -Scopes "User.Read.All", "Group.ReadWrite.All"
        ```

    - App only access via Client Credential with a certificate.

        The certificate will be loaded from `Cert:\CurrentUser\My\` store. Ensure the certificate is present in the store before calling `Connect-Graph`.
        
        You can pass either `-CertificateThumbprint` or `-CertificateName` to `Connect-Graph`.

        ```ps
        # Using -CertificateThumbprint
        Connect-Graph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateThumbprint "YOUR_CERT_THUMBPRINT"
        ```

        or

        ```ps
        # Using -CertificateName
        Connect-Graph -ClientId "YOUR_APP_ID" -TenantId "YOUR_TENANT_ID" -CertificateName "YOUR_CERT_SUBJECT"
        ```

2. List users in your tenant.

    ```ps
    Get-User -Top 10 -Property Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
    ```

3. Filter a user in your tenant.

    ```ps
    $user = Get-MgUser -Filter "displayName eq 'Megan Bowen'"
    ```

4. Create a new app registration.

    ```ps
    New-MgApplication -DisplayName "ScriptedGraphPSApp" `
                      -SignInAudience "AzureADMyOrg" `
                      -Web @{ RedirectUris = "https://localhost"}
    ```

5. Sign out of the current logged-in context i.e. app only or delegated access.

    ```ps
    Disconnect-Graph
    ```
## API Version
By default, the SDK uses the Microsoft Graph REST API v1.0. You can change this by using the `Select-MgProfile` command. This reloads all modules and only loads commands that call beta endpoint.

```ps
Select-MgProfile -Name "beta"
```

## Troubleshooting Permission Related Errors

When working with various operations in the Graph, you may encounter an error such as "Insufficient privileges to complete the operation."  For example, this particular error can occur when using the `New-MgApplication` command if the appropriate permissions are not granted.

If permission related errors occur and the user you authenticated with in the popup has the appropriate permissions to perform the operation try these steps.

- You can try running `Disconnect-Graph`, then `Connect-Graph`.  Then, run the code that encountered the permission issues to see if it works.
- You can try running `Connect-Graph -ForceRefresh`.  This will trigger a refresh of the access token in your cache. MSAL will only refresh the access token in your cache if it has expired (usually an hour), or if you explicitly refresh it via `-ForceRefresh`.  Then, run the code that encountered the permission issues to see if it works.
