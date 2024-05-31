### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	displayName = "My Sample Team"
	description = "My Sample Team’s Description"
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	displayName = "My Sample Team"
	description = "My Sample Team’s Description"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
			"owner"
		)
		"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('0040b377-61d8-43db-94f5-81374122dc7e')"
	}
)
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 3: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	visibility = "Private"
	displayName = "Sample Engineering Team"
	description = "This is a sample engineering team, used to showcase the range of properties supported by this API"
	channels = @(
		@{
			displayName = "Announcements 📢"
			isFavoriteByDefault = $true
			description = "This is a sample announcements channel that is favorited by default. Use this channel to make important team, product, and service announcements."
		}
		@{
			displayName = "Training 🏋️"
			isFavoriteByDefault = $true
			description = "This is a sample training channel, that is favorited by default, and contains an example of pinned website and YouTube tabs."
			tabs = @(
				@{
					"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.web')"
					displayName = "A Pinned Website"
					configuration = @{
						contentUrl = "https://learn.microsoft.com/microsoftteams/microsoft-teams"
					}
				}
				@{
					"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.youtube')"
					displayName = "A Pinned YouTube Video"
					configuration = @{
						contentUrl = "https://tabs.teams.microsoft.com/Youtube/Home/YoutubeTab?videoId=X8krAMdGvCQ"
						websiteUrl = "https://www.youtube.com/watch?v=X8krAMdGvCQ"
					}
				}
			)
		}
		@{
			displayName = "Planning 📅 "
			description = "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu."
			isFavoriteByDefault = $false
		}
		@{
			displayName = "Issues and Feedback 🐞"
			description = "This is a sample of a channel that is not favorited by default, these channels will appear in the more channels overflow menu."
		}
	)
	memberSettings = @{
		allowCreateUpdateChannels = $true
		allowDeleteChannels = $true
		allowAddRemoveApps = $true
		allowCreateUpdateRemoveTabs = $true
		allowCreateUpdateRemoveConnectors = $true
	}
	guestSettings = @{
		allowCreateUpdateChannels = $false
		allowDeleteChannels = $false
	}
	funSettings = @{
		allowGiphy = $true
		giphyContentRating = "Moderate"
		allowStickersAndMemes = $true
		allowCustomMemes = $true
	}
	messagingSettings = @{
		allowUserEditMessages = $true
		allowUserDeleteMessages = $true
		allowOwnerDeleteMessages = $true
		allowTeamMentions = $true
		allowChannelMentions = $true
	}
	discoverySettings = @{
		showInTeamsSearchAndSuggestions = $true
	}
	installedApps = @(
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 4: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	"group@odata.bind" = "https://graph.microsoft.com/v1.0/groups('71392b2f-1765-406e-86af-5907d9bdb2ab')"
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 5: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	"group@odata.bind" = "https://graph.microsoft.com/v1.0/groups('dbd8de4f-5d47-48da-87f1-594bed003375')"
	channels = @(
		@{
			displayName = "Class Announcements 📢"
			isFavoriteByDefault = $true
		}
		@{
			displayName = "Homework 🏋️"
			isFavoriteByDefault = $true
		}
	)
	memberSettings = @{
		allowCreateUpdateChannels = $false
		allowDeleteChannels = $false
		allowAddRemoveApps = $false
		allowCreateUpdateRemoveTabs = $false
		allowCreateUpdateRemoveConnectors = $false
	}
	installedApps = @(
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 6: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('educationClass')"
	displayName = "My Class Team"
	description = "My Class Team’s Description"
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 7: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('educationClass')"
	displayName = "My Class Team"
	description = "My Class Team’s Description"
	channels = @(
		@{
			displayName = "Class Announcements 📢"
			isFavoriteByDefault = $true
		}
		@{
			displayName = "Homework 🏋️"
			isFavoriteByDefault = $true
		}
	)
	memberSettings = @{
		allowCreateUpdateChannels = $false
		allowDeleteChannels = $false
		allowAddRemoveApps = $false
		allowCreateUpdateRemoveTabs = $false
		allowCreateUpdateRemoveConnectors = $false
	}
	installedApps = @(
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('com.microsoft.teamspace.tab.vsts')"
		}
		@{
			"teamsApp@odata.bind" = "https://graph.microsoft.com/v1.0/appCatalogs/teamsApps('1542629c-01b3-4a6d-8f76-1938b779e48d')"
		}
	)
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

### Example 8: Code snippet

```powershell

Import-Module Microsoft.Graph.Teams

$params = @{
	"template@odata.bind" = "https://graph.microsoft.com/v1.0/teamsTemplates('standard')"
	displayName = "My Sample Team"
	description = "My Sample Team’s Description"
	members = @(
		@{
			"@odata.type" = "#microsoft.graph.aadUserConversationMember"
			roles = @(
			"owner"
		)
		"user@odata.bind" = "https://graph.microsoft.com/v1.0/users('jacob@contoso.com')"
	}
)
}

New-MgTeam -BodyParameter $params

```
This example shows how to use the New-MgTeam Cmdlet.

