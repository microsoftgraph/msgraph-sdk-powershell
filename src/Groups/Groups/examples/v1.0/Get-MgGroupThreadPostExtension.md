### Example 1
``` powershell
Import-Module Microsoft.Graph.Groups
Get-MgGroupThreadPostExtension -GroupId $groupId -ConversationThreadId $conversationThreadId -PostId $postId -ExtensionId $extensionId
```
