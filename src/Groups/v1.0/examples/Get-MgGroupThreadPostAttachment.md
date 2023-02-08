### Example 1: Using the Get-MgGroupThreadPostAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupThreadPostAttachment -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId
```
This example shows how to use the Get-MgGroupThreadPostAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
