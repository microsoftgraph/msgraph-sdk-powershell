# Microsoft Graph PowerShell SDK Preview
The Microsoft Graph PowerShell SDK is a collection of PowerShell modules that contain cmdlets for calling Microsoft Graph.

## Installing the Microsoft.Graph Module

The modules are now published on the PowerShell Gallery. Installing is as simple as:

```ps
Install-module Microsoft.Graph
```

There are a set of samples in the `samples` folder to help getting started with the library.  If you have an older version of these modules installed, there are uninstall instructions in the [InstallModule](./samples/0-InstallModule.ps1) script.

## Generate Module

### Prerequisite

1. [Download](https://github.com/PowerShell/PowerShell/releases/tag/v6.2.3) and install PowerShell Core.

2. Install AutoRest.

    ```ps
    npm install -g "@autorest/autorest"
    ```

3. Create an [Azure DevOps](https://docs.microsoft.com/en-us/azure/devops/artifacts/tutorials/private-powershell-library?view=azure-devops) Artifacts Feed or host a local [Nuget.Server](https://docs.microsoft.com/en-us/nuget/hosting-packages/nuget-server), and register it as a local PowerShell repository using `Register-PSRepository` command. Once done, take note of the `RepositoryName` and `APIKey`. You can always get the repository name by running `Get-PSRepository`.
    This will be used as a temporary repository to publish generated modules in order to specify them as dependencies for `Microsoft.Graph` roll-up module.

    ***N.B - Once we have a preview version of the modules in PowerShell Gallery, this step won't be needed.***

### Generation Steps

1. Clone the [msgraph-sdk-powershell](https://github.com/microsoftgraph/msgraph-sdk-powershell) repo locally.

    ```ps
    git clone https://github.com/microsoftgraph/msgraph-sdk-powershell.git -b dev
    ```

2. Generate, pack and optionally publish `Microsoft.Graph.Authentication` module.

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateAuthenticationModule.ps1 -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

3. Generate, pack and optionally publish Microsoft Graph service PowerShell modules by tags. For a complete list of tags, see [OpenApiSplice](https://github.com/microsoftgraph/msgraph-openapi-introspection).

    Edit `.\config\ModulesMapping.jsonc` by adding key-value pairs of the tags you want to generate modules for. The key is the name of the module to be generated and the value is a regex expression that will be used to query [OpenApiSplice](https://github.com/microsoftgraph/msgraph-openapi-introspection) for an OpenAPI document for your module.

    To generate v1.0 modules, run the following script:

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateModules.ps1 -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

    To generate beta endpoint modules, add `-BetaGraphVersion` switch when running `GenerateModules.ps1`.

    This performs the following actions :
    - Generates the modules specified in `.\config\ModulesMapping.jsonc` in `.\msgraph-sdk-powershell\src\{GraphVersion}\{Module-Name}\{Module-Name}\`.
    - Adds appropriate dependencies to the generated modules.
    - Packs and optionally publishes the modules to the specified repository as `.nupkg` files. The generated `nupkg` can be found in `.\msgraph-sdk-powershell\artifacts\{GraphVersion}\{Module-Name}\`.

4. Generate, pack and optionally publish `Microsoft.Graph` roll-up module.

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateRollUpModule.ps1 -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

    To generate a roll-up module for Microsoft Graph beta modules, add `-BetaGraphVersion` switch when running `GenerateRollUpModule.ps1`.

    The above script generates a `Microsoft.Graph` module manifest with the generated Microsoft Graph service modules specified in `.\config\ModulesMapping.jsonc` and `Microsoft.Graph.Authentication` module as its dependencies.

5. Optionally, manually publish modules from an artifacts location.

    ```ps
    . \msgraph-sdk-powershell\tools\PublishModule.ps1 -Modules "Graph", "Authentication", "Subscriptions", "Teams" -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ArtifactsLocation {ArtifactsLocation}
    ```

#### Common Generation Scripts Parameters

- ***`-ModuleVersion`***: The version of the module to generate. This defaults to `0.1.0` when not specified.
- ***`-ModulePreviewNumber`***: An optional preview number of the module(s) to generate. When not specified, the module is generated as a non preview module(s) of the `ModuleVersion`.
- ***`-Publish`***: An optional switch that publishes generated module(s) to the specified `RepositoryName`. This used when module dependencies are not locally installed in your machine.
- ***`-BetaGraphVersion`***: A switch that indicates tells the generation scripts to generate beta modules of Microsoft Graph. If not specified, the generation scripts will generate v1.0 modules.

## Run Generated Modules

1. By default, the generated modules should already be installed on your PC in `%UserProfile%\Documents\PowerShell\Modules` as part of the generation process. If it's not present or you want to install the modules on another machine, then install them as such by specifying your repository name:

    ```ps
    Install-Module Microsoft.Graph -Repository {RepositoryName} # v1.0 modules
    or
    Install-Module Microsoft.Graph.Beta -Repository {RepositoryName} # beta modules
    ```

2. Authenticate to Microsoft Identity to get an access token to call Microsoft Graph modules.
    - Delegated access via Device Code Flow.

        ```ps
        Connect-Graph -Scopes "User.Read.All"
        ```

    - App only access via Client Credential Flow with a certificate.

        ```ps
        # Replace CN=DaemonConsoleCert with your certificate name.
        Connect-Graph -ClientId ClientId -TenantId TenantId -CertificateName "CN=DaemonConsoleCert"
        ```

3. Call `Get-User` command.

    ```ps
    # Authenticate for delegated access.
    Connect-Graph

    Get-User -Top 10 -Select Id, DisplayName, BusinessPhones | Format-Table Id, DisplayName, BusinessPhones
    ```

4. Call `Get-UserMessage` cmdlet.

    ```ps
    # Authenticate for app only access.
    Connect-Graph -ClientId ClientId -TenantId TenantId -CertificateName CertificateName

    Get-UserMessage -UserId UserId -Top 10 -Skip 10 -Select Id, Subject, CreatedDateTime | Format-Table CreatedDateTime, Subject, Id
    ```

5. Sign out of the current logged in context i.e. app only or delegated access.

    ```ps
    Disconnect-Graph
    ```

## Troubleshooting Permission Related Errors

When working with various operations in the Graph, you may encounter an error such as "Insufficient privileges to complete the operation."  For example, this particular error can occur when using the `New-Application` command if the appropriate permissions are not granted.

If permission related errors occur and the user you authenticated with in the popup has the appropriate permissions to perform the operation try these steps.

- You can try running `Disconnect-Graph`, then `Connect-Graph`.  Then, run the code that encountered the permission issues to see if it works.
- You can try running `Connect-Graph -ForceRefresh`.  This will trigger a refresh of the access token in your cache. MSAL will only refresh the access token in your cache if it has expired (usually an hour), or if you explicitly refresh it via `-ForceRefresh`.  Then, run the code that encountered the permission issues to see if it works.
