### Example 1: Get a group chat

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a chat and all its members

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "members"
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Get the meeting details of a chat associated with a Microsoft Teams meeting

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 4: Get the chat along with the preview of the last message sent in the chat

```powershell
Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "lastMessagePreview"
```
This example shows how to use the Get-MgBetaChat Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

