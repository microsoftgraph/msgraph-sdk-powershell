# Switch to beta profile. This loads cmdlets that call MS Graph beta endpoint.

# Create a new team.
$TeamName = "2020 Interns"
New-MgBetaTeam -DisplayName $TeamName -Description $TeamName `
    -AdditionalProperties @{
        "template@odata.bind" = "https://graph.microsoft.com/beta/teamsTemplates('standard')"
    }

# Filter groups by displayName and resourceProvisioningOptions to find team.
$InternsTeam = Get-MgBetaGroup -Filter "StartsWith(DisplayName, '$TeamName')" `
               | Where-Object { $_.ResourceProvisioningOptions -Contains "Team" }

# Add team owner.
$teamOwner = Get-MgBetaUser -UserId "{TEAM_OWNER_UPN}"
New-MgBetaTeamMember -TeamId $InternsTeam.Id -Roles "owner" `
    -AdditionalProperties @{ 
        "@odata.type" = "#microsoft.graph.aadUserConversationMember"; 
        "user@odata.bind" = "https://graph.microsoft.com/beta/users/" + $teamOwner.Id
    }

# Filter users to find users who have a UPN that starts with 't-'.
$TeamMembers = Get-MgBetaUser -Filter "startswith(userPrincipalName, 't-')"

# Add team members.
foreach ($teamMember in $TeamMembers) {
    New-MgBetaTeamMember -TeamId $InternsTeam.Id -Roles "member" `
        -AdditionalProperties @{
            "@odata.type" = "#microsoft.graph.aadUserConversationMember";
            "user@odata.bind" = "https://graph.microsoft.com/beta/users/" + $teamMember.Id
        }
}

# Send a welcome message to the channel.
$PrimaryChannel = Get-MgBetaTeamPrimaryChannel -TeamId $InternsTeam.Id
New-MgBetaTeamChannelMessage -TeamId $InternsTeam.Id `
                         -ChannelId $PrimaryChannel.Id `
                         -Body @{
                             Content = "Welcome to Teams!"
                            }

# Delete team.
Remove-MgBetaGroup -GroupId $InternsTeam.Id

# Teams Chat snippets

# Get list of 1:1 chats
Get-MgBetaChat

# Get Messages from Chat
Get-MgBetaChatMessage -chatId $chatId 

# Send a message in that 1:1 chat
New-MgBetaChatMessage -chatId $chatId -Body @{ Content = "Hi from VSCode again!" }

# Mention a user in a channel message.
$User = Get-MgBetaUser -UserId $userUPN | select id, displayName, userIdentityType
$UserToMention  = @{
    Id = $User.Id;
    DisplayName = $User.DisplayName;
    UserIdentityType = "aadUser";
}

New-MgBetaTeamChannelMessage -ChannelId $ChannelId -TeamId $TeamId `
    -Body @{ `
        ContentType = "html"; `
        Content = "Welcome to the channel! <at id='0'>$($UserToMention.DisplayName)</at>" `
    } `
    -Mentions @( `
        @{ `
            id          = 0; `
            mentionText = $UserToMention.DisplayName; `
            mentioned   = @{user = $UserToMention } `
        })
