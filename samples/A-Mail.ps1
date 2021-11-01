## Send a mail

$Message = @{
    "subject" = "Yo"
    "body" = @{
      "content" = "Here is my message"
    }
    "toRecipients" = @(
        @{
           "emailAddress" = @{
              "address" = "user@example.com"
           }
         }
     )
 }

Send-MgUserMail -userId sender@domain.org -Message $Message

