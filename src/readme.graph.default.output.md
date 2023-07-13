# Microsoft Graph PowerShell Default Output Format

``` yaml
  # Format cmdlet default output.
directive:
  - where:
      model-name: ^MicrosoftGraphUser\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - Mail
          - UserPrincipalName
  - where:
      model-name: ^MicrosoftGraphPerson\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - MailboxType
          - PersonType
          - IsFavorite
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - EmailAddresses
          - Phones
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphCalendar\d*$
    set:
      format-table:
        properties:
          - Name
          - Id
          - OwnerName
          - OwnerAddress
  - where:
      model-name: ^MicrosoftGraphEvent\d*$
    set:
      format-table:
        properties:
          - Subject
          - Id
          - StartDateTime
          - StartTimeZone
          - EndDateTime
          - EndTimeZone
  - where:
      model-name: ^MicrosoftGraphDrive\d*$
    set:
      format-table:
        properties:
          - Name
          - Id
          - DriveType
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphDriveItem\d*$
    set:
      format-table:
        properties:
          - Name
          - Id
          - WebUrl
          - FolderChildCount
          - Size
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphList\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - Name
          - WebUrl
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphSite\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - Name
          - SiteCollectionHostname
          - WebUrl
  - where:
      model-name: ^MicrosoftGraphGroup\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - MailNickname
          - Description
          - GroupTypes
  - where:
      model-name: ^MicrosoftGraphTeam\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - Description
          - IsArchived
  - where:
      model-name: ^MicrosoftGraphMessage\d*$
    set:
      format-table:
        properties:
          - Subject
          - Id
          - FromEmailAddressAddress
          - ReceivedDateTime
          - BodyContentType
          - hasAttachments
  - where:
      model-name: ^MicrosoftGraphNotebook\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - CreatedDateTime
          - IsShared
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphSectionGroup\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - CreatedDateTime
          - ParentNotebookDisplayName
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphConversation\d*$
    set:
      format-table:
        properties:
          - Topic
          - Id
          - UniqueSenders
          - HasAttachments
          - Threads
          - LastDeliveredDateTime
  - where:
      model-name: ^MicrosoftGraphConversationThread\d*$
    set:
      format-table:
        properties:
          - Topic
          - Id
          - UniqueSenders
          - HasAttachments
          - Posts
          - LastDeliveredDateTime
  - where:
      model-name: ^MicrosoftGraphPost\d*$
    set:
      format-table:
        properties:
          - Id
          - SenderEmailAddressAddress
          - BodyContentType
          - HasAttachments
          - ReceivedDateTime
  - where:
      model-name: ^MicrosoftGraphDirectoryObject\d*$
    set:
      format-table:
        properties:
          - Id
          - DeletedDateTime
  - where:
      model-name: ^MicrosoftGraphPlace\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - AddressCity
          - Phone
  - where:
      model-name: ^MicrosoftGraphPlannerTask\d*$
    set:
      format-table:
        properties:
          - Title
          - Id
          - PlanId
          - BucketId
          - Priority
          - StartDateTime
          - CompletedDateTime
          - PercentComplete
  - where:
      model-name: ^MicrosoftGraphPlannerPlan\d*$
    set:
      format-table:
        properties:
          - Title
          - Id
          - Owner
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphPlannerPlanDetails\d*$
    set:
      format-table:
        properties:
          - Id
          - CategoryDescriptions
          - SharedWith
          - ContextDetails
  - where:
      model-name: ^MicrosoftGraphSchemaExtension\d*$
    set:
      format-table:
        properties:
          - Description
          - Id
          - Status
          - Properties
          - TargetTypes
          - Owner
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - EmailAddresses
  - where:
      model-name: ^MicrosoftGraphOrgContact\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - Mail
          - MailNickname
  - where:
      model-name: ^MicrosoftGraphApplication\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - AppId
          - SignInAudience
          - PublisherDomain
  - where:
      model-name: ^MicrosoftGraphServicePrincipal\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - AppId
          - SignInAudience
          - ServicePrincipalType
  - where:
      model-name: ^MicrosoftGraphTodoTaskList\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - IsOwner
          - IsShared
          - WellknownListName
  - where:
      model-name: ^MicrosoftGraphTodoTask\d*$
    set:
      format-table:
        properties:
          - Title
          - Id
          - Status
          - Body
          - DueDateTime
          - Importance
  - where:
      model-name: ^MicrosoftGraphOrganization\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - TenantType
          - CountryLetterCode
          - VerifiedDomains
          - AssignedPlans
  - where:
      model-name: ^MicrosoftGraphUnifiedRoleDefinition\d*$
    set:
      format-table:
        properties:
          - DisplayName
          - Id
          - TemplateId
          - Description
          - IsBuiltIn
          - IsEnabled
  - where:
      model-name: ^MicrosoftGraphUnifiedRoleAssignment\d*$
    set:
      format-table:
        properties:
          - Id
          - PrincipalId
          - RoleDefinitionId
          - DirectoryScopeId
          - AppScopeId
```
