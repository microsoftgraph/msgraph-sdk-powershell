# Microsoft Graph PowerShell SDK (alpha)
The Microsoft Graph Powershell SDK will be a collection of PowerShell modules that conatain cmdlets that can be used to make Microsoft Graph REST calls.  Currently we are just building the infrastructure in order to generate the modules.  Stay tuned!

## Generate Module

### Prerequisite

1. [Download](https://github.com/PowerShell/PowerShell/releases/tag/v6.2.2) and install PowerShell core.

2. Install AutoRest.

    ```ps
    npm install -g "@autorest/autorest"
    ```

3. Create an [Azure DevOps](https://docs.microsoft.com/en-us/azure/devops/artifacts/tutorials/private-powershell-library?view=azure-devops) Artifacts Feed or host a local [Nuget.Server](https://docs.microsoft.com/en-us/nuget/hosting-packages/nuget-server), and register it as a local PowerShell repository using `Register-PSRepository` command. Once done, take note of the `RepositoryName` and `APIKey`. You can always get the repository name by running `Get-PSRepository`.
    This will be used as a temporary repository to the publish generated modules in order to specify them as dependencies for the `Graph` roll-up module.

    ***N.B - Once we have a preview version of the modules in PowerShell Gallery, this step won't be needed.***

### Generation Steps

1. Clone the [msgraph-sdk-powershell](https://github.com/microsoftgraph/msgraph-sdk-powershell) repo locally.

    ```ps
    git clone https://github.com/microsoftgraph/msgraph-sdk-powershell.git -b dev
    ```

2. Generate, pack and optionally publish `Graph.Authentication` module.

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateAuthenticationModule.ps1 -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

3. Generate, pack and optionally publish Microsoft Graph service PowerShell modules by tags. For a complete list of tags, see [OpenApiSplice](https://github.com/microsoftgraph/msgraph-openapi-introspection).

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateModules.ps1 -Tags "subscriptions", "teams" -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

    This performs the following actions :
    - Generates `Graph.subscriptions` and `Graph.teams` PowerShell modules in `.\msgraph-sdk-powershell\src\subscriptions\subscriptions\` and `.\msgraph-sdk-powershell\src\teams\teams\` respectively.
    - Specifies modules dependencies for the generated modules.
    - Packages and publishes the modules to the specified repository as `.nupkg` files. The generated `nupkg` can be found in `.\msgraph-sdk-powershell\artifacts\subscriptions\` and `.\msgraph-sdk-powershell\artifacts\teams\` respectively.

4. Generate, pack and optionally publish `Graph` roll-up module.

    ```ps
    . \msgraph-sdk-powershell\tools\GenerateRollUpModule.ps1 -RequiredModules "Authentication", "Subscriptions", "Teams" -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ModuleVersion {ModuleVersion} -Publish
    ```

    This generates a `Graph` module manifest with the generated Graph service modules (`Graph.subscriptions`, `Graph.teams`) and `Graph.Authentication` module as its dependencies.

5. Optionally, publish all generated from an artifacts location.

    ```ps
    . \msgraph-sdk-powershell\tools\PublishModule.ps1 -Modules "Graph", "Authentication", "subscriptions", "teams" -RepositoryName {RepositoryName} -RepositoryApiKey {APIKey} -ArtifactsLocation {ArtifactsLocation}
    ```

#### Common Generation Scripts Parameters
- ***`-ModuleVersion`***: The version of the module to generate. This defaults to `0.1.0` when not specified.
- ***`-ModulePreviewNumber`***: An optional preview number of the module(s) to generate. When not specified, the module is generated as a non preview module(s) of the `ModuleVersion`.
- ***`-Publish`***: An optional switch that publishes generated module(s) to the specified `RepositoryName`. This used  when module dependencies are not locally installed in your machine.

## Run Generated Modules

1. By default, the generated modules should already be installed on your PC in `%UserProfile%\Documents\PowerShell\Modules` as part of the generation process. If it's not present or you want to install the modules on another machine, then install them as such by specifying your repository name:

    ```ps
    Install-Module Graph -Repository {RepositoryName}
    ```

2. Authenticate to Microsoft Identity to get an access token to call Microsoft Graph API.
    - Delegated access via Device Code Flow.

        ```ps
        Connect-Graph -Scopes "User.Read.All"
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
