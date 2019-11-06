# Teams Chat snippets

# Get list of 1:1 chats
Get-Chat

# Get Messages from Chat
Get-ChatMessage -chatId $chatId 

# Send a message in that 1:1 chat
New-ChatMessage -chatId $chatId -BodyContent "Hi from VSCode again!"