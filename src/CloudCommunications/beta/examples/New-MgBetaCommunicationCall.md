### Example 1: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Application = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "2891555a-92ff-42e6-80fa-6e1300c6b5c6"
			}
		}
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "John"
					Id = "112f7296-5fa4-42ca-bae8-6a692b15d4b8"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	CallOptions = @{
		"@odata.type" = "#microsoft.graph.outgoingCallOptions"
		IsContentSharingNotificationEnabled = $true
	}
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			ApplicationInstance = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Calling Bot"
				Id = "3d913abb-aec0-4964-8fa6-3c6850c4f278"
			}
		}
		CountryCode = $null
		EndpointType = $null
		Region = $null
		LanguageId = $null
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				Phone = @{
					"@odata.type" = "#microsoft.graph.identity"
					Id = "+12345678901"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	Direction = "outgoing"
	Subject = "Create a group call with app hosted media"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Application = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "TestBot"
				Id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "user1"
					Id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.participantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "user2"
					Id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
		RemoveFromDefaultAudioGroup = $false
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 6: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	Direction = "outgoing"
	Subject = "Create a group call with service hosted media"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Application = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "TestBot"
				Id = "dd3885da-f9ab-486b-bfae-85de3d445555"
			}
		}
	}
	Targets = @(
		@{
			"@odata.type" = "#microsoft.graph.invitationParticipantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "user1"
					Id = "98da8a1a-1b87-452c-a713-65d3f10b5555"
				}
			}
		}
		@{
			"@odata.type" = "#microsoft.graph.participantInfo"
			Identity = @{
				"@odata.type" = "#microsoft.graph.identitySet"
				User = @{
					"@odata.type" = "#microsoft.graph.identity"
					DisplayName = "user2"
					Id = "bf5aae9a-d11d-47a8-93b1-782504c95555"
				}
			}
		}
	)
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		RemoveFromDefaultAudioGroup = $false
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 7: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	Source = @{
		"@odata.type" = "#microsoft.graph.participantInfo"
		Identity = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			Guest = @{
				"@odata.type" = "#microsoft.graph.identity"
				DisplayName = "Guest User"
				Id = "d7a3b999-17ac-4bca-9e77-e6a730d2ec2e"
			}
		}
	}
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		ThreadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		MessageId = "1533758867081"
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 8: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		ThreadId = "19:cbee7c1c860e465f8258e3cebf7bee0d@thread.skype"
		MessageId = "1533758867081"
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 9: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	Direction = "outgoing"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.appHostedMediaConfig"
		Blob = "<Media Session Configuration>"
	}
	ChatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		ThreadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		MessageId = "0"
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
	TenantId = "aa67bd4c-8475-432d-bd41-39f255720e0a"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 10: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	ChatInfo = @{
		"@odata.type" = "#microsoft.graph.chatInfo"
		ThreadId = "19:meeting_Win6Ydo4wsMijFjZS00ZGVjLTk5MGUtOTRjNWY2NmNkYTFm@thread.v2"
		MessageId = "0"
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.organizerMeetingInfo"
		Organizer = @{
			"@odata.type" = "#microsoft.graph.identitySet"
			User = @{
				"@odata.type" = "#microsoft.graph.identity"
				Id = "5810cede-f3cc-42eb-b2c1-e9bd5d53ec96"
				TenantId = "9f386a15-f9cc-445b-8106-ac85e314a07b"
				DisplayName = "Bob"
			}
		}
		AllowConversationWithoutHost = $true
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 11: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.joinMeetingIdMeetingInfo"
		JoinMeetingId = "1234567"
		Passcode = "psw123"
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 12: Using the New-MgBetaCommunicationCall Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.CloudCommunications
$params = @{
	"@odata.type" = "#microsoft.graph.call"
	CallbackUri = "https://bot.contoso.com/callback"
	RequestedModalities = @(
		"audio"
	)
	MediaConfig = @{
		"@odata.type" = "#microsoft.graph.serviceHostedMediaConfig"
		PreFetchMedia = @(
		)
	}
	MeetingInfo = @{
		"@odata.type" = "#microsoft.graph.joinMeetingIdMeetingInfo"
		JoinMeetingId = "1234567"
		Passcode = $null
	}
	TenantId = "86dc81db-c112-4228-9222-63f3esaa1edb"
}
New-MgBetaCommunicationCall -BodyParameter $params
```
This example shows how to use the New-MgBetaCommunicationCall Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
