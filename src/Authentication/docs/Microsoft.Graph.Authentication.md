---
Module Name: Microsoft.Graph.Authentication
Module Guid: e02d0639-6606-4204-9e67-c2af9fed5bab
Download Help Link: https://learn.microsoft.com/powershell/module/Microsoft.Graph.Authentication
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Authentication Module
## Description
Microsoft Graph PowerShell Authentication Cmdlets

## Microsoft.Graph.Authentication Cmdlets
### [Add-MgEnvironment](Add-MgEnvironment.md)
{{ Fill in the Synopsis }}

### [Connect-MgGraph](Connect-MgGraph.md)
Microsoft Graph PowerShell supports two types of authentication: delegated and app-only access. There are a number of cmdlets that can be used to manage the different parameters required during authentication, for example, environment, application ID, and certificate.

### [Disconnect-MgGraph](Disconnect-MgGraph.md)
Once you're signed in, you'll remain signed in until you invoke Disconnect-MgGraph. Microsoft Graph PowerShell automatically refreshes the access token for you and sign-in persists across PowerShell sessions because Microsoft Graph PowerShell securely caches the token.

### [Find-MgGraphCommand](Find-MgGraphCommand.md)
Find-MgGraphCommand aims to make it easier for you to discover which API path a command calls, by providing a URI or a command name. The Find-MgGraphCommand allows to:  - Pass a Microsoft Graph URL (relative and absolute) and get an equivalent Microsoft Graph PowerShell command. - Pass a command and get the URL it calls. - Pass a command or URI wildcard (.*) to find all commands that match it.

### [Find-MgGraphPermission](Find-MgGraphPermission.md)
The Microsoft Graph PowerShell SDK application requires users to have domain knowledge of both the semantics and syntax of Microsoft Graph API permissions used to authorize access to the API. This cmdlet helps to answer the following questions:  - How do I find the values to supply to the permission-related parameters of commands like New-MgApplication and other application and consent related commands? - What permissions are applicable to a certain domain, for example, application, directory? To use Microsoft Graph PowerShell SDK to access Microsoft Graph, users must sign in to an Azure AD application using the Connect-MgGraph command. Use the Find-MgGraphCommand to find which permissions to use for a specific cmdlet or API.-  Currently PowerShell commands and scripts, including those implemented with Microsoft Graph PowerShell SDK itself, have no way of validating user input that refers to permissions or providing "auto-complete" user experiences to help users accurately supply input to commands

### [Get-MgContext](Get-MgContext.md)
Get-MgContext is used to retrieve the details about your current session, which include:  - ClientID - TenantID - Certificate Thumbprint - Scopes consented to - AuthType: Delegated or app-only - AuthProviderType - CertificateName - Account - AppName - ContextScope - Certificate - PSHostVersion - ClientTimeOut.

### [Get-MgEnvironment](Get-MgEnvironment.md)
When you use Connect-MgGraph, you can choose to target other environments. By default, Connect-MgGraph targets the global public cloud.

### [Get-MgGraphOption](Get-MgGraphOption.md)
{{ Fill in the Synopsis }}

### [Get-MgRequestContext](Get-MgRequestContext.md)
{{ Fill in the Synopsis }}

### [Invoke-MgGraphRequest](Invoke-MgGraphRequest.md)
Invoke-MgGraphRequest issues REST API requests to the Graph API. It works for any Graph API if you know the REST URI, method, and optional body parameter. This command is especially useful for accessing APIs for which there isn't an equivalent cmdlet yet.

### [Remove-MgEnvironment](Remove-MgEnvironment.md)
{{ Fill in the Synopsis }}

### [Set-MgEnvironment](Set-MgEnvironment.md)
{{ Fill in the Synopsis }}

### [Set-MgGraphOption](Set-MgGraphOption.md)
{{ Fill in the Synopsis }}

### [Set-MgRequestContext](Set-MgRequestContext.md)
{{ Fill in the Synopsis }}

