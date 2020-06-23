# Microsoft Graph AutoRest Configuration

> Common

``` yaml
azure: false
powershell: true
version: latest
use: "@autorest/powershell@latest"
metadata:
    authors: Microsoft Corporation
    owners: Microsoft Corporation
    companyName: Microsoft Corporation
    description: 'Microsoft Graph PowerShell Cmdlets'
    copyright: &copy; Microsoft Corporation. All rights reserved.
    tags: Microsoft Office365 Graph PowerShell
    requireLicenseAcceptance: true
    licenseUri: https://aka.ms/devservicesagreement
    projectUri: https://github.com/microsoftgraph/msgraph-sdk-powershell
    iconUri: https://raw.githubusercontent.com/microsoftgraph/g-raph/master/g-raph.png
```

> Names

``` yaml
prefix: Mg
module-name: Microsoft.Graph.$(service-name)
subject-prefix: $(service-name)
namespace: Microsoft.Graph.PowerShell
sanitize-names: false
```

> Folders

``` yaml
clear-output-folder: true
output-folder: .
```

> Custom Directives

``` yaml
declare-directive:
  where-operation-byRegex: >-
    (() => {
      return { from: "openapi-document", where: `$..paths.*[?(/${$}/gmi.exec(@.operationId))]` };
    })()
  remove-path-by-operation: >-
    [{
      from: 'openapi-document',
      "where-operation-byRegex": $,
      transform: '$ = undefined'
    }]
```

> Directives

``` yaml
directive:
  - no-inline:
    - microsoft.graph.sharepointIds
    - microsoft.graph.identitySet
    - microsoft.graph.itemReference
    - microsoft.graph.directoryObject
    - microsoft.graph.user
    - microsoft.graph.drive
    - microsoft.graph.listItem
    - microsoft.graph.post
    - microsoft.graph.sectionGroup
    - microsoft.graph.team
    - microsoft.graph.recipient
    - microsoft.graph.groupPolicyCategory

  # Set parameter alias
  - where:
      parameter-name: OrderBy
    set:
      parameter-name: Sort
      alias: OrderBy
  - where:
      parameter-name: Top
    set:
      parameter-name: PageSize
      alias:
        - Top
        - Limit
  - where:
      parameter-name: Select
    set:
      parameter-name: Property
      alias: Select
  - where:
      parameter-name: Expand
    set:
      parameter-name: ExpandProperty
      alias: Expand
  # Format cmdlet response.
  - where:
      model-name: MicrosoftGraphUser
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Mail
          - UserPrincipalName
          - UserType
  - where:
      model-name: MicrosoftGraphPerson
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - MailboxType
          - PersonType
          - IsFavorite
  - where:
      model-name: MicrosoftGraphContact
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - EmailAddresses
          - Phones
          - CreatedDateTime
  - where:
      model-name: MicrosoftGraphCalendar
    set:
      format-table:
        properties:
          - Id
          - Name
          - OwnerName
          - OwnerAddress
  - where:
      model-name: MicrosoftGraphEvent
    set:
      format-table:
        properties:
          - Id
          - Subject
          - StartDateTime
          - StartTimeZone
          - EndDateTime
          - EndTimeZone
  - where:
      model-name: MicrosoftGraphDrive
    set:
      format-table:
        properties:
          - Id
          - Name
          - DriveType
          - CreatedDateTime
  - where:
      model-name: MicrosoftGraphDriveItem
    set:
      format-table:
        properties:
          - Id
          - Name
          - WebUrl
          - FolderChildCount
          - Size
          - CreatedDateTime
  - where:
      model-name: MicrosoftGraphList
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - WebUrl
          - CreatedDateTime
  - where:
      model-name: MicrosoftGraphSite
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - SiteCollectionHostname
          - WebUrl
  - where:
      model-name: MicrosoftGraphGroup
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - GroupTypes
          - AccessType
  - where:
      model-name: MicrosoftGraphTeam
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - IsArchived
  - where:
      model-name: MicrosoftGraphMessage
    set:
      format-table:
        properties:
          - Id
          - Subject
          - FromEmailAddressAddress
          - ReceivedDateTime
          - BodyContentType
          - hasAttachments
  - where:
      model-name: MicrosoftGraphNotebook
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - IsShared
          - IsDefault
  - where:
      model-name: MicrosoftGraphSectionGroup
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - ParentNotebookDisplayName
          - IsDefault
  - where:
      model-name: MicrosoftGraphConversation
    set:
      format-table:
        properties:
          - Id
          - Topic
          - UniqueSenders
          - HasAttachments
          - Threads
          - LastDeliveredDateTime
  - where:
      model-name: MicrosoftGraphConversationThread
    set:
      format-table:
        properties:
          - Id
          - Topic
          - UniqueSenders
          - HasAttachments
          - Posts
          - LastDeliveredDateTime
  - where:
      model-name: MicrosoftGraphPost
    set:
      format-table:
        properties:
          - Id
          - SenderEmailAddressAddress
          - BodyContentType
          - HasAttachments
          - ReceivedDateTime
  - where:
      model-name: MicrosoftGraphDirectoryObject
    set:
      format-table:
        properties:
          - Id
          - DeletedDateTime
  - where:
      model-name: MicrosoftGraphPlace
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AddressCity
          - Phone
  - where:
      model-name: MicrosoftGraphPlannerTask
    set:
      format-table:
        properties:
          - Id
          - PlanId
          - BucketId
          - Title
          - Priority
          - StartDateTime
          - CompletedDateTime
          - PercentComplete
  - where:
      model-name: MicrosoftGraphPlannerPlan
    set:
      format-table:
        properties:
          - Id
          - Title
          - Owner
          - CreatedDateTime
  - where:
      model-name: MicrosoftGraphPlannerPlanDetails
    set:
      format-table:
        properties:
          - Id
          - CategoryDescriptions
          - SharedWith
          - ContextDetails
  - where:
      model-name: MicrosoftGraphSchemaExtension
    set:
      format-table:
        properties:
          - Id
          - Description
          - Properties
          - TargetTypes
          - Status
          - Owner
# Rename cmdlets
  - where:
      verb: Invoke
      subject: (^Delta)(.*)
    set:
      verb: Get
      subject: $2$1
  - where:
      verb: Test
      variant: ^Check(.*)
    set:
      verb: Confirm
# Remove cmdlets
  - where:
      verb: Test
      subject: (Application|ServicePrincipal)SynchronizationJobCredentials
      variant: Validate1|ValidateExpanded1|ValidateViaIdentity1|ValidateViaIdentityExpanded1
    remove: true
# Add AfterToJson
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5CMicrosoftGraph\w*.json.cs/gm))
      {
        return $;
      } else {
        let afterJsonDeclarationRegex = /(^\s*)(partial\s*void\s*AfterFromJson\s*\(Microsoft.Graph.PowerShell.Runtime.Json.JsonObject\s*json\s*\);$)/gm
        $ = $.replace(afterJsonDeclarationRegex, '$1$2\n$1partial void AfterToJson(ref Microsoft.Graph.PowerShell.Runtime.Json.JsonObject container, Microsoft.Graph.PowerShell.Runtime.SerializationMode serializationMode);\n');
        let afterJsonRegex = /(^\s*)(AfterToJson\(ref\s*container\s*\);$)/gm
        $ = $.replace(afterJsonRegex, '$1$2\n$1AfterToJson(ref container, serializationMode);\n');
        return $;
      }
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5CMicrosoftGraph\w*.cs/gm))
      {
        return $;
      } else {
        let regexPattern = /^\s*public\s*partial\s*class\s*MicrosoftGraph(?<EntityName>.*):$/gm;
        let regexArray;
        while ((regexArray = regexPattern.exec($)) !== null) {
          if (regexArray['groups'] != null)
          {
            let EntityName = regexArray['groups'].EntityName.trim();
            let newEntityId = EntityName + 'Id';
            let newEntityIdPropRegex = new RegExp("^\\s*public\\s*string\\s*"+newEntityId+"\\.*","gm");
            let existingIdPropRegex = /(^\s*)(public\s*string\s*Id\s.*)/gm;
            if ((!$.match(newEntityIdPropRegex)) && $.match(existingIdPropRegex) && (newEntityId != "EntityId") && (newEntityId != "BaseItemId")) {
              $ = $.replace(existingIdPropRegex, '$1$2\n\n$1partial void AfterToJson(ref Microsoft.Graph.PowerShell.Runtime.Json.JsonObject container, Microsoft.Graph.PowerShell.Runtime.SerializationMode serializationMode)\n$1{\n$1\tif (serializationMode == Microsoft.Graph.PowerShell.Runtime.SerializationMode.IncludeAll) {\n$1\t\tAddIf(null != this.Id ? (Microsoft.Graph.PowerShell.Runtime.Json.JsonNode)new Microsoft.Graph.PowerShell.Runtime.Json.JsonString(this.Id) : null, "'+ EntityName.toLowerCase() +'-id", container.Add);\n$1\t}\n$1}');
            }
          }
        }
        return $;
      }
# Add GraphPSCmdlet base class.
# - Override OnDefault to handle all success, 2xx response, as success and not error.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2F\w*.cs/gm))
      {
        return $;
      } else {
        let overrideOnDefaultRegex = /(\s*)(partial\s*void\s*overrideOnDefault)/gmi
        let overrideOnDefaultImplementation = "$1partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow) => this.OverrideOnDefault(responseMessage,ref returnNow);$1$2"
        $ = $.replace(overrideOnDefaultRegex, overrideOnDefaultImplementation);

        return $;
      }

# Add custom -All parameter to *_List cmdlets that support Odata next link.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FGet\w*_List\d*.cs/gm))
      {
        return $;
      } else {
        let odataNextLinkRegex = /(^\s*)(if\s*\(\s*result.OdataNextLink\s*!=\s*null\s*\))/gmi
        if($.match(odataNextLinkRegex)) {
          $ = $.replace(odataNextLinkRegex, '$1if (result.OdataNextLink != null && this.ShouldIteratePages(this.InvocationInformation.BoundParameters, result.Value.Length))\n$1');

          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1Microsoft.Graph.PowerShell.Cmdlets.Custom.ListCmdlet');

          let beginProcessingRegex = /(^\s*)(protected\s*override\s*void\s*BeginProcessing\(\)\s*{)/gmi
          $ = $.replace(beginProcessingRegex, '$1$2\n$1$1if (this.InvocationInformation.BoundParameters.ContainsKey("PageSize")){ InitializePaging(ref this.__invocationInfo, ref this._pageSize); }\n$1');

          let odataNextLinkCallRegex = /(^\s*)(await\s*this\.Client\.UsersUserListUser_Call\(requestMessage\,\s*onOk\,\s*onDefault\,\s*this\,\s*Pipeline\)\;)/gmi
          $ = $.replace(odataNextLinkCallRegex, '$1requestMessage.RequestUri = GetOverflowItemsNextLinkUri(requestMessage.RequestUri);\n$1$2');
        }
        return $;
      }
```
