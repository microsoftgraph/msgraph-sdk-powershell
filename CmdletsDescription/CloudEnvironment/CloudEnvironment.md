## Cloud Environment

The SDK supports managing of cloud environments through `Get-MgEnvironment`, `Set-MgEnvironment`, `Add-MgEnvironment`, and `remove-MgEnvironment` commands
- Add Environment.

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
     - Get Environment.

        A collection of environments will be returned by using the `Get-MgEnvironment` command.

        ``` powershell
        Get-MgEnvironment
        ```
    - Set Microsoft Graph Environment.

        `Set-MgEnvironment` command switches to a `user-defined` environment type using the existing microsoft graph session

        ``` powershell
        Set-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME' -AzureADEndpoint 'AZURE_ENDPOINT' -GraphEndpoint 'GRAPH_ENDPOINT
        ```
    - Remove Environment.

        `Remove-MgEnvironment` command removes an environment initially set by a user, from the existing microsoft graph session. It eventually defaults to Global.

        ``` powershell
        Remove-MgEnvironment -Name 'YOUR_ENVIRONMENT_NAME'
        ```