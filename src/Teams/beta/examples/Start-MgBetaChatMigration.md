### Example 1: Start the migration in a chat

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Start-MgBetaChatMigration -ChatId $chatId

```
This example will start the migration in a chat

### Example 2: Start the migration when a chat is already in migration mode

```powershell

Import-Module Microsoft.Graph.Beta.Teams

Start-MgBetaChatMigration -ChatId $chatId

```
This example will start the migration when a chat is already in migration mode

