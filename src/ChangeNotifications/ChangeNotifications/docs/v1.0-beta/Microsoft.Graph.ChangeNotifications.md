---
Module Name: Microsoft.Graph.ChangeNotifications
Module Guid: 3dce2198-8bda-4ce9-8850-4d186f51efeb
Download Help Link: https://docs.microsoft.com/en-us/powershell/module/microsoft.graph.changenotifications
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
Invoke action reauthorize

### [New-MgSubscription](New-MgSubscription.md)
Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph.
See the table in the Permissions section for the list of resources that support subscribing to change notifications.
Some resources support the option to include encrypted resource data in change notifications.
These resources include chatMessage, contact, event, message, onlineMeetings and presence.
For more information, see Set up change notifications that include resource data and Change notifications for Outlook resources in Microsoft Graph.

### [Remove-MgSubscription](Remove-MgSubscription.md)
Delete a subscription.
For the list of resources that support subscribing to change notifications, see the table in the Permissions section.

### [Update-MgSubscription](Update-MgSubscription.md)
Renew a subscription by extending its expiry time.
The table in the Permissions section lists the resources that support subscribing to change notifications.
Subscriptions expire after a length of time that varies by resource type.
In order to avoid missing change notifications, an app should renew its subscriptions well in advance of their expiry date.
See subscription for maximum length of a subscription for each resource type.

