###Example 1
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	"Group@odata.bind" = "https://graph.microsoft.com/v1.0/groups('dbd8de4f-5d47-48da-87f1-594bed003375')"
	Channels = @(
		@{
			DisplayName = "Class Announcements ðŸ“¢"
			IsFavoriteByDefault = $true
		}
		@{
			DisplayName = "Homework ðŸ‹ï¸"
			IsFavoriteByDefault = $true
		}
	)
	MemberSettings = @{
		AllowCreateUpdateChannels = $false
		AllowDeleteChannels = $false
		AllowAddRemoveApps = $false
		AllowCreateUpdateRemoveTabs = $false
		AllowCreateUpdateRemoveConnectors = $false
	}
	InstalledApps = @(
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}
New-MgTeam -BodyParameter $params
```
###Example 2
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('educationClass')"
	DisplayName = "My Class Team"
	Description = "My Class Teamâ€™s Description"
}
New-MgTeam -BodyParameter $params
```
###Example 3
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('educationClass')"
	DisplayName = "My Class Team"
	Description = "My Class Teamâ€™s Description"
	Channels = @(
		@{
			DisplayName = "Class Announcements ðŸ“¢"
			IsFavoriteByDefault = $true
		}
		@{
			DisplayName = "Homework ðŸ‹ï¸"
			IsFavoriteByDefault = $true
		}
	)
	MemberSettings = @{
		AllowCreateUpdateChannels = $false
		AllowDeleteChannels = $false
		AllowAddRemoveApps = $false
		AllowCreateUpdateRemoveTabs = $false
		AllowCreateUpdateRemoveConnectors = $false
	}
	InstalledApps = @(
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}
New-MgTeam -BodyParameter $params
```
###Example 4
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	"Group@odata.bind" = "https://graph.microsoft.com/v1.0/groups('71392b2f-1765-406e-86af-5907d9bdb2ab')"
}
New-MgTeam -BodyParameter $params
```
###Example 5
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	Visibility = "Private"
	DisplayName = "Sample Engineering Team"
	Description = "This is a sample engineering team, used to showcase the range of properties supported by this API"
	Channels = @(
		@{
			DisplayName = "Announcements ðŸ“¢"
			IsFavoriteByDefault = $true
			Description = "This is a sample announcements channel that is favorited by default. Use this channel to make important team, product, and service announcements."
		}
		@{
			DisplayName = "Training ðŸ‹ï¸"
			IsFavoriteByDefault = $true
			Description = "This is a sample training channel, that is favorited by default, and contains an example of pinned website and YouTube tabs."
			Tabs = @(
				@{
					"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.web')"
					DisplayName = "A Pinned Website"
					Configuration = @{
						ContentUrl = "https://docs.microsoft.com/microsoftteams/microsoft-teams"
					}
				}
				@{
					"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.youtube')"
					DisplayName = "A Pinned YouTube Video"
					Configuration = @{
						ContentUrl = "https://tabs.teams.microsoft.com/Youtube/Home/YoutubeTab?videoId=X8krAMdGvCQ"
						WebsiteUrl = "https://www.youtube.com/watch?v=X8krAMdGvCQ"
					}
				}
			)
		}
		@{
			DisplayName = "Planning ðŸ“… "
			Description = "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu."
			IsFavoriteByDefault = $false
		}
		@{
			DisplayName = "Issues and Feedback ðŸž"
			Description = "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu."
		}
	)
	MemberSettings = @{
		AllowCreateUpdateChannels = $true
		AllowDeleteChannels = $true
		AllowAddRemoveApps = $true
		AllowCreateUpdateRemoveTabs = $true
		AllowCreateUpdateRemoveConnectors = $true
	}
	GuestSettings = @{
		AllowCreateUpdateChannels = $false
		AllowDeleteChannels = $false
	}
	FunSettings = @{
		AllowGiphy = $true
		GiphyContentRating = "Moderate"
		AllowStickersAndMemes = $true
		AllowCustomMemes = $true
	}
	MessagingSettings = @{
		AllowUserEditMessages = $true
		AllowUserDeleteMessages = $true
		AllowOwnerDeleteMessages = $true
		AllowTeamMentions = $true
		AllowChannelMentions = $true
	}
	InstalledApps = @(
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"TeamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}
New-MgTeam -BodyParameter $params
```
###Example 6
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	DisplayName = "My Sample Team"
	Description = "My Sample Teamâ€™s Description"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('0040b377-61d8-43db-94f5-81374122dc7e')"
		}
	)
}
New-MgTeam -BodyParameter $params
```
###Example 7
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	DisplayName = "My Sample Team"
	Description = "My Sample Teamâ€™s Description"
}
New-MgTeam -BodyParameter $params
```
###Example 8
```
Import-Module Microsoft.Graph.Teams
$params = @{
	"Template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	DisplayName = "My Sample Team"
	Description = "My Sample Teamâ€™s Description"
	Members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			Roles = @(
				"owner"
			)
			"User@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
		}
	)
}
New-MgTeam -BodyParameter $params
```
