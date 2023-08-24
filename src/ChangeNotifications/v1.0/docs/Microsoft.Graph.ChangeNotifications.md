---
Module Name: Microsoft.Graph.ChangeNotifications
Module Guid: d43e7963-6ad5-4704-b4e9-5acfc8fbbed8
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

### [Invoke-MgReauthorizeSubscription](Invoke-MgReauthorizeSubscription.md)
Reauthorize a subscription when you receive a reauthorizationRequired challenge.

### [New-MgSubscription](New-MgSubscription.md)
Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph.
To identify the resources for which you can create subscriptions and the limitations on subscriptions, see Set up notifications for changes in resource data: Supported resources.
Some resources support rich notifications, that is, notifications that include resource data.
For more information about these resources, see Set up change notifications that include resource data: Supported resources.

### [Remove-MgSubscription](Remove-MgSubscription.md)
Delete a subscription.
For the list of resources that support subscribing to change notifications, see the table in the Permissions section.

### [Update-MgSubscription](Update-MgSubscription.md)
Renew a subscription by extending its expiry time.
The table in the Permissions section lists the resources that support subscribing to change notifications.
Subscriptions expire after a length of time that varies by resource type.
In order to avoid missing change notifications, an app should renew its subscriptions well in advance of their expiry date.
See subscription for maximum length of a subscription for each resource type.

