### Example 1: Get a group chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId

```
This example will get a group chat

### Example 2: Get a chat and all its members

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "members" 

```
This example will get a chat and all its members

### Example 3: Get the meeting details of a chat associated with a Microsoft Teams meeting

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId

```
This example will get the meeting details of a chat associated with a microsoft teams meeting

### Example 4: Get the chat along with the preview of the last message sent in the chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Get-MgBetaChat -ChatId $chatId -ExpandProperty "lastMessagePreview" 

```
This example will get the chat along with the preview of the last message sent in the chat

