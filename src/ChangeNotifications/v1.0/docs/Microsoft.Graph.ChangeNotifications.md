---
Module Name: Microsoft.Graph.ChangeNotifications
Module Guid: 7c27c1a4-4944-473f-8ac4-f43e70e2b634
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.changenotifications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.ChangeNotifications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.ChangeNotifications Cmdlets
### [Get-MgSubscription](Get-MgSubscription.md)
Retrieve the properties and relationships of a subscription.
See the table in the Permissions section for the list of resources that support subscribing to change notifications.
This API is available in the following national cloud deployments.

### [Invoke-MgReauthorizeSubscription](Invoke-MgReauthorizeSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.
This API is available in the following national cloud deployments.

### [New-MgSubscription](New-MgSubscription.md)
Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph.
To identify the resources for which you can create subscriptions and the limitations on subscriptions, see Set up notifications for changes in resource data: Supported resources.
Some resources support rich notifications, that is, notifications that include resource data.
For more information about these resources, see Set up change notifications that include resource data: Supported resources.
This API is available in the following national cloud deployments.

### [Remove-MgSubscription](Remove-MgSubscription.md)
Delete a subscription.
For the list of resources that support subscribing to change notifications, see the table in the Permissions section.
This API is available in the following national cloud deployments.

### [Update-MgSubscription](Update-MgSubscription.md)
Renew a subscription by extending its expiry time.
The table in the Permissions section lists the resources that support subscribing to change notifications.
Subscriptions expire after a length of time that varies by resource type.
In order to avoid missing change notifications, an app should renew its subscriptions well in advance of their expiry date.
See subscription for maximum length of a subscription for each resource type.
This API is available in the following national cloud deployments.

