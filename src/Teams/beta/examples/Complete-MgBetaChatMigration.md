### Example 1: Complete the migration of external messages in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Complete-MgBetaChatMigration -ChatId $chatId

```
This example will complete the migration of external messages in a chat

### Example 2: Complete the migration when a chat is already in migration mode

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Complete-MgBetaChatMigration -ChatId $chatId

```
This example will complete the migration when a chat is already in migration mode

