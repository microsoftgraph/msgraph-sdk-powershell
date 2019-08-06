# Microsoft Graph PowerShell SDK
The Microsoft Graph Powershell SDK is collection of PowerShell modules that conatain cmdlets that can be used to make Microsoft Graph REST calls.

## Generate Module
1. [Download](https://github.com/PowerShell/PowerShell/releases/tag/v6.2.2) and install PowerShell.
2. Install AutoRest.
    ```ps
    npm install -g autorest@beta
    ```
3. Clone [msgraph-sdk-powershell](https://github.com/microsoftgraph/msgraph-sdk-powershell).
    ```ps
    git clone https://github.com/microsoftgraph/msgraph-sdk-powershell.git -b dev
    ```
4. Generate PowerShell by tags. For a complete list of tags, see [OpenApiSplice](). Due to issue #ref, we will add `-useLocalOpenApiDoc` switch to use a local sanitized OpenAPI document for `me.message` tag.
    ```ps
    .\scripts\GenerateModules.ps1 -tags "me.message" -useLocalOpenApiDoc
    ```
    This generates a Microsoft Graph `me.message` PowerShell module under `.\src\me.message\me.message`.

## Run Generated Module
1. Build Generate Module with `-Run` switch.
    ```ps
    .\src\me.message\me.message\build-module.ps1 -Run 
    ```

2. Import Common Module.
For now, we have to manually import Common module which had cmdlets to handle authentication,
    ```ps
    Import-Module .\src\me.message\me.message\bin\Common.dll  
    ```
3. Authenicate to Azure AD to get an access token to call Microsoft Graph API.
    ```ps
    Connect-Graph -ClientId 'ID' -Scopes 'user.read, Calendars.Read, Files.Read'
    ```
4. Call `Get-MeMessage` cmdlet.
    ```
    Get-MeMessage -Top 10 -Skip 10 -Select 'Id, Subject, CreatedDateTime' | Format-Table CreatedDateTime, Subject, Id
    ```
