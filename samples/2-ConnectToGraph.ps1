# Connect To Graph

# Connect using previously consented permisssions
Connect-Graph

# Try to Get-User
Get-User

# Grant more permissions
Connect-Graph -Scopes "User.Read","User.ReadWrite.All","Mail.ReadWrite",`
            "Directory.ReadWrite.All","Chat.ReadWrite", "People.Read", `
            "Group.Read.All", "Directory.AccessAsUser.All", "Tasks.ReadWrite", `
            "Sites.Manage.All"
# Now Get-User works

# Tokens persist across Terminal sessions

# Forget all access tokens
Disconnect-Graph