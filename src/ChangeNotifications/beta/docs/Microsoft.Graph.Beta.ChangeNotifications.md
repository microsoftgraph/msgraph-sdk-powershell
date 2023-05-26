---
Module Name: Microsoft.Graph.Beta.ChangeNotifications
Module Guid: 78bae420-d0d3-4b57-98db-c92c96d143be
Download Help Link: https://learn.microsoft.com/powershell/module/microsoft.graph.beta.changenotifications
Help Version: 1.0.0.0
Locale: en-US
---

# Microsoft.Graph.Beta.ChangeNotifications Module
## Description
Microsoft Graph PowerShell Cmdlets

## Microsoft.Graph.Beta.ChangeNotifications Cmdlets
### [Get-MgBetaSubscription](Get-MgBetaSubscription.md)
Retrieve the properties and relationships of a subscription.
See the table in the Permissions section for the list of resources that support subscribing to change notifications.

### [Invoke-MgBetaReauthorizeSubscription](Invoke-MgBetaReauthorizeSubscription.md)
Reauthorize a subscription when you receive a **reauthorizationRequired** challenge.

### [New-MgBetaSubscription](New-MgBetaSubscription.md)
Subscribes a listener application to receive change notifications when the requested type of changes occur to the specified resource in Microsoft Graph.
See the table in the Permissions section for the list of resources that support subscribing to change notifications.
Some resources support the option to include encrypted resource data in change notifications.
These resources include chatMessage, contact, event, message, onlineMeetings and presence.
For more information, see Set up change notifications that include resource data and Change notifications for Outlook resources in Microsoft Graph.

### [Remove-MgBetaSubscription](Remove-MgBetaSubscription.md)
Delete a subscription.
For the list of resources that support subscribing to change notifications, see the table in the Permissions section.

### [Update-MgBetaSubscription](Update-MgBetaSubscription.md)
Renew a subscription by extending its expiry time.
The table in the Permissions section lists the resources that support subscribing to change notifications.
Subscriptions expire after a length of time that varies by resource type.
In order to avoid missing change notifications, an app should renew its subscriptions well in advance of their expiry date.
See subscription for maximum length of a subscription for each resource type.

