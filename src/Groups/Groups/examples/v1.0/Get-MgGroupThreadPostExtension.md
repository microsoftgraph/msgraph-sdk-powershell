### Example 1: Using the Get-MgGroupThreadPostExtension Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId
```
This example shows how to use the Get-MgGroupThreadPostExtension Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
