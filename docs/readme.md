# Microsoft Graph PowerShell Module

- [Overview](https://learn.microsoft.com/powershell/microsoftgraph/overview)
- [Authentication](./authentication.md)
- [Navigating the Module](https://learn.microsoft.com/powershell/microsoftgraph/navigating)
- [Query Parameters](https://learn.microsoft.com/powershell/microsoftgraph/use-query-parameters)
- [Errors](https://learn.microsoft.com/powershell/microsoftgraph/troubleshooting)
- [Upgrade to Microsoft Graph PowerShell v2](./upgrade-to-v2.md)
- [Upgrade from AzureAD PowerShell](https://learn.microsoft.com/powershell/microsoftgraph/migration-steps)
- [Contributions](../CONTRIBUTING.md)

## What is Microsoft Graph?

Microsoft Graph is a unified endpoint for accessing data, intelligence, and insights in Microsoft 365. You can find more information at [developer.microsoft.com/graph](https://developer.microsoft.com/graph).

## Why Microsoft Graph PowerShell Module?

Microsoft Graph PowerShell module acts as an API wrapper for Microsoft Graph APIs, exposing the entire API set for use in PowerShell. It contains a set of commands that help you manage identities at scale; from automating tasks to managing users in bulk using Azure Active Directory (Azure AD). It will help administer every Azure AD feature that has an API in Microsoft Graph.

The module provides the following advantages to PowerShell users:

- HTTP logic is handled for you. This includes retries, redirects, and many more [handlers](https://github.com/microsoftgraph/msgraph-sdk-design#sdk-features-support).
- The module handles access token acquisition and caching for you. For interactive scenarios, all you need is a list scopes. For scripted scenarios, all you need is a client id, tenant id and a certificate. See [Authentication](./authentication.md).
- The module handles serialization and deserialization of JSON responses into PowerShell objects.
- The module adds an extra layer of error handling and rich debug logs to help you debug your scripts.
- Commands make it easy for you to discover paths through which you can access the rich data stores in Graph.
- Helpers for Microsoft Graph functionality such as pagination , file upload and download, and [Invoke-MgGraphRequest](https://learn.microsoft.com/powershell/microsoftgraph/authentication-commands?view=graph-powershell-1.0#using-invoke-mggraphrequest).
