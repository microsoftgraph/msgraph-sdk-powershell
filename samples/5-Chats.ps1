# Teams Chat snippets

# Get list of 1:1 chats
Get-MgChat

# Get Messages from Chat
Get-MgChatMessage -chatId $chatId 

# Send a message in that 1:1 chat
New-MgChatMessage -chatId $chatId -BodyContent "Hi from VSCode again!"