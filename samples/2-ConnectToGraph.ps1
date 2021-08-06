# Connect To Graph

# Connect using previously consented permissions
Connect-Graph

# Try to Get-User
Get-MgUser

# Search for delegated permissions related to sites
Find-MgGraphPermission sites

# Grant more permissions
Connect-Graph -Scopes "User.Read","User.ReadWrite.All","Mail.ReadWrite",`
            "Directory.Read.All","Chat.ReadWrite", "People.Read", `
            "Group.Read.All", "Tasks.ReadWrite", `
            "Sites.Manage.All"
# Now Get-MgUser works

# Tokens persist across Terminal sessions

# Forget all access tokens
Disconnect-Graph

# Launch detailed permissions documentation
Get-Help Find-MgGraphPermission -Online

