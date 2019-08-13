# Microsoft Graph PowerShell SDK
The Microsoft Graph Powershell SDK is a collection of PowerShell modules that contain cmdlets that can be used to make Microsoft Graph REST calls.

## Generate Module
1. [Download](https://github.com/PowerShell/PowerShell/releases/tag/v6.2.2) and install PowerShell Core.
2. Install [Node.js](https://nodejs.org/en/) (Choose the LTS version) and remember to include the NPM Packet Manager when installing.
3. Install [GitHub Desktop](https://desktop.github.com/).
4. Install AutoRest.
   Open a PowerShell Core terminal.
    ```ps
    npm install -g autorest@beta
    ```
5. Clone [msgraph-sdk-powershell](https://github.com/microsoftgraph/msgraph-sdk-powershell).
    In the PowerShell terminal, remember to navigate to the folder you want the clone to be stored in.
    ```ps
    git clone https://github.com/microsoftgraph/msgraph-sdk-powershell.git -b dev
    ```
6. Generate PowerShell modules by tags. For a complete list of tags, see [OpenApiSplice](https://github.com/microsoftgraph/msgraph-openapi-introspection). Due to issue [msgraph-openapi-introspection#12](https://github.com/microsoftgraph/msgraph-openapi-introspection/issues/12), we will add `-useLocalOpenApiDoc` switch to use a local sanitized OpenAPI document for `me.message` tag.
    ```ps
    .\msgraph-sdk-powershell\scripts\GenerateModules.ps1 -tags "me.message" -useLocalOpenApiDoc
    ```
    This generates a Microsoft Graph `me.message` PowerShell module in `.\msgraph-sdk-powershell\src\me.message\me.message`.

## Run Generated Module
1. Build Generate Module with `-Run` switch.
    ```ps
    .\msgraph-sdk-powershell\src\me.message\me.message\build-module.ps1 -Run 
    ```

2. Import Common Module.
    For now, we have to manually import Common module which houses cmdlets to handle authentication - `Connect-Graph` and `Disconnect-Graph`.
    ```ps
    Import-Module .\msgraph-sdk-powershell\src\me.message\me.message\bin\Common.dll  
    ```
3. Authenicate to Azure AD to get an access token to call Microsoft Graph API.
    ```ps
    Connect-Graph -ClientId 'ID' -Scopes 'user.read, Calendars.Read, Files.Read'
    ```
4. Call `Get-MeMessage` cmdlet.
    ```
    Get-MeMessage -Top 10 -Skip 10 -Select 'Id, Subject, CreatedDateTime' | Format-Table CreatedDateTime, Subject, Id
    ```
