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

Microsoft Graph is a unified endpoint for accessing data, intelligence, and insights in Microsoft 365. You can find more information at [developer.microsoft.com/graph](https://developer.microsoft.com/graph). You can also get started trying out queries right away against your own account using the [Graph Explorer](https://developer.microsoft.com/graph/graph-explorer).

## Why Microsoft Graph PowerShell Module?

Using Microsoft Graph PowerShell Module, PowerShell users can directly consuming Microsoft Graph resources directly from a PowerShell session. The module provides a few shortcuts:

- HTTP logic is handled for you so you reduce the amount of boilerplate you need to get started. This includes retries, redirects and many more [handlers](https://github.com/microsoftgraph/msgraph-sdk-design#sdk-features-support).
- The module handles retrieval and caching of access tokens for you. For interactive scenarios, all you need is a list scopes. For scripted scenarios, all you need is a client id, tenant id and a certificate.
- The module handles deserialization of JSON responses into PowerShell objects instead of working directly with JSON.
- An extra layer of error handling and intelligent defaults help you debug your application.
- Commands make it easy for you to discover paths through which you can access the rich data stores in Graph.
- Helpers for Graph functionality, such as pagination and `Invoke-GraphRequest`, simplify accomplishing specific scenarios.
