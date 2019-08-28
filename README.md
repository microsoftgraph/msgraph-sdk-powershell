# Microsoft Graph PowerShell SDK

The Microsoft Graph PowerShell SDK is a collection of resource specific PowerShell modules that contain cmdlets that can be used to make Microsoft Graph REST calls in PowerShell.

## Generate Module

### Prerequisite

1. [Download](https://github.com/PowerShell/PowerShell/releases/tag/v6.2.2) and install PowerShell core.

2. Install AutoRest.

    ```ps
    npm install -g autorest@beta
    ```

3. Run a local instance of either [Nuget.Server](https://docs.microsoft.com/en-us/nuget/hosting-packages/nuget-server) or [Private PowerShell Gallery](https://github.com/PowerShell/PSPrivateGallery), and register it a local repository using `Register-PSRepository` cmdlet. Once done, take note of the `repository name` and `APIKey`. You can always get the repository name by running `Get-PSRepository`.

    This will be used as a temporary repository to the publish generated modules in order to specify them as dependencies for the `Graph` roll-up module.

    N.B Once we have preview version of the modules in PowerShell Gallery, this step won't be needed.

### Generation Steps

1. Clone the [msgraph-sdk-powershell](https://github.com/microsoftgraph/msgraph-sdk-powershell) repo locally.

    ```ps
    git clone https://github.com/microsoftgraph/msgraph-sdk-powershell.git -b dev
    ```

2. Generate and pack PowerShell modules by tags. For a complete list of tags, see [OpenApiSplice](https://github.com/microsoftgraph/msgraph-openapi-introspection).

    ```ps
    .\msgraph-sdk-powershell\tools\GenerateModules.ps1 -Tags "me.message", "users.message" -RepositoryApiKey {APIKey} -RepositoryName {RepositoryName}
    ```

    This performs the following actions :
    - Generates `Graph.me.message` and `Graph.users.message` PowerShell modules in `.\msgraph-sdk-powershell\src\me.message\me.message\` and `.\msgraph-sdk-powershell\src\users.message\users.message\` respectively.
    - Specifies modules dependencies for the generated modules.
    - Packages and uploads the modules to the specified repository as `.nupkg` files. The generated `nupkg` can be found in `.\msgraph-sdk-powershell\artifacts`.
    - Generates a `Graph` roll-up module manifest with the generated modules + `Graph.Authentication` module as its `DependsOn`.

## Run Generated Modules

1. By default, the generated modules should already be installed on your PC in `C:\Users\{accountName}\Documents\PowerShell\Modules` as part of the generation process. If it's not present or you want to install the modules on another machine, then install them as such by specifying your repository name:

    ```ps
    Install-Module Graph -Repository {RepositoryName}
    ```

2. Authenticate to Microsoft Identity to get an access token to call Microsoft Graph API.
    - Delegated access via Device Code Flow.

            ```ps
            Connect-Graph
            ```

    - App only access via Client Credential Flow with a certificate.

            ```ps
            # Replace CN=DaemonConsoleCert with your certificate name.
            Connect-Graph -ClientId ClientId -TenantId TenantId -CertificateName "CN=DaemonConsoleCert"
            ```

3. Call `Get-MeMessage` cmdlet.

    ```ps
    # Authenticate for delegated access.
    Connect-Graph

    Get-MeMessage -Top 10 -Skip 10 -Select 'Id, Subject, CreatedDateTime' | Format-Table CreatedDateTime, Subject, Id
    ```

4. Call `Get-UserMessage` cmdlet.

    ```ps
    # Authenticate for app only access.
    Connect-Graph -ClientId ClientId -TenantId TenantId -CertificateName CertificateName

    Get-UserMessage -UserId UserId -Top 10 -Skip 10 -Select "Id, Subject, CreatedDateTime" | Format-Table CreatedDateTime, Subject, Id
    ```

5. Sign out of the current logged in context i.e. app only or delegated access.

    ```ps
    Disconnect-Graph
    ```
