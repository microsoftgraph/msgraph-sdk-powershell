# Microsoft Graph AutoRest Configuration

> Common

``` yaml
azure: false
powershell: true
version: latest
use: "@autorest/powershell@2.1.401"
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

> Profiles

``` yaml
tag: all-api-versions
profile:
  - v1.0
  - v1.0-beta
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
    - microsoft.graph.printer
    - microsoft.graph.printerShare
    - microsoft.graph.governanceResource
    - microsoft.graph.governanceRoleAssignment
    - microsoft.graph.governanceRoleDefinition
    - microsoft.graph.workbookOperationError
    - microsoft.graph.parentLabelDetails
    - microsoft.graph.ediscovery.tag
    - microsoft.graph.ediscovery.sourceCollection
    - microsoft.graph.contentType
    - microsoft.graph.columnDefinition

  # Set parameter alias
  - where:
      parameter-name: OrderBy
    set:
      parameter-name: Sort
      alias: OrderBy
  - where:
      parameter-name: Top
    set:
      alias:
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
      model-name: ^MicrosoftGraphUser\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Mail
          - UserPrincipalName
          - UserType
  - where:
      model-name: ^MicrosoftGraphPerson\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - MailboxType
          - PersonType
          - IsFavorite
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - EmailAddresses
          - Phones
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphCalendar\d*$
    set:
      format-table:
        properties:
          - Id
          - Name
          - OwnerName
          - OwnerAddress
  - where:
      model-name: ^MicrosoftGraphEvent\d*$
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
      model-name: ^MicrosoftGraphDrive\d*$
    set:
      format-table:
        properties:
          - Id
          - Name
          - DriveType
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphDriveItem\d*$
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
      model-name: ^MicrosoftGraphList\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - WebUrl
          - CreatedDateTime
  - where:
      model-name: ^MicrosoftGraphSite\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Name
          - SiteCollectionHostname
          - WebUrl
  - where:
      model-name: ^MicrosoftGraphGroup\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - GroupTypes
          - AccessType
  - where:
      model-name: ^MicrosoftGraphTeam\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - Description
          - IsArchived
  - where:
      model-name: ^MicrosoftGraphMessage\d*$
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
      model-name: ^MicrosoftGraphNotebook\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - IsShared
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphSectionGroup\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - CreatedDateTime
          - ParentNotebookDisplayName
          - IsDefault
  - where:
      model-name: ^MicrosoftGraphConversation\d*$
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
      model-name: ^MicrosoftGraphConversationThread\d*$
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
          - Id
          - DisplayName
          - AddressCity
          - Phone
  - where:
      model-name: ^MicrosoftGraphPlannerTask\d*$
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
      model-name: ^MicrosoftGraphPlannerPlan\d*$
    set:
      format-table:
        properties:
          - Id
          - Title
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
          - Id
          - Description
          - Properties
          - TargetTypes
          - Status
          - Owner
  - where:
      model-name: ^MicrosoftGraphContact\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - emailAddresses
  - where:
      model-name: ^MicrosoftGraphApplication\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AppId
          - SignInAudience
          - PublisherDomain
  - where:
      model-name: ^MicrosoftGraphServicePrincipal\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - AppId
          - SignInAudience
          - PublisherName
  - where:
      model-name: ^MicrosoftGraphTodoTaskList\d*$
    set:
      format-table:
        properties:
          - Id
          - DisplayName
          - IsOwner
          - IsShared
          - WellknownListName
  - where:
      model-name: ^MicrosoftGraphTodoTask\d*$
    set:
      format-table:
        properties:
          - Id
          - Title
          - Status
          - Body
          - DueDateTime
          - Importance
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
# Rename all /$ref cmdlets to *ByRef e.g. New-MgGroupOwnerByRef
  - where:
      subject: ^(\w*[a-z])Ref([A-Z]\w*)$
    set:
      subject: $1$2ByRef
  - where:
      verb: Get|New
      subject: ^GroupMemberByRef$
      variant: ^List$|^Create$|^CreateExpanded$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^List3$|^Create3$|^CreateExpanded3$|^CreateViaIdentity3$|^CreateViaIdentityExpanded3$
    set:
      subject: GroupMemberOfByRef
  - where:
      verb: Get|New
      subject: ^GroupMemberByRef$
      variant: ^List2$|^Create2$|^CreateExpanded2$|^CreateViaIdentity2$|^CreateViaIdentityExpanded2$|^List5$|^Create5$|^CreateExpanded5$|^CreateViaIdentity5$|^CreateViaIdentityExpanded5$
    set:
      subject: GroupMemberWithLicenseErrorByRef
  - where:
      verb: Get
      subject: ^GroupTransitiveMemberByRef$
      variant: ^List$|^List2$
    set:
      subject: GroupTransitiveMemberOfByRef
# Alias then rename cmdlets to avoid breaking change.
  - where:
      subject: ^(User|ServicePrincipal|Contact|Device)(Member|TransitiveMember)ByRef$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(User|ServicePrincipal|Contact|Device)(Member|TransitiveMember)ByRef$
    set:
      subject: $1$2OfByRef
  - where:
      subject: ^(Application|Group)(CreatedOnBehalf)ByRef$
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: ^(Application|Group)(CreatedOnBehalf)ByRef$
    set:
      subject: $1$2OfByRef
# Modify generated .json.cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5C\w*MicrosoftGraph\w*\d*.json.cs/gm))
      {
        return $;
      } else {
        // Add AfterToJson
        let afterJsonDeclarationRegex = /(^\s*)(partial\s*void\s*AfterFromJson\s*\(Microsoft.Graph.PowerShell.Runtime.Json.JsonObject\s*json\s*\);$)/gm
        $ = $.replace(afterJsonDeclarationRegex, '$1$2\n$1partial void AfterToJson(ref Microsoft.Graph.PowerShell.Runtime.Json.JsonObject container, Microsoft.Graph.PowerShell.Runtime.SerializationMode serializationMode);\n');
        let afterJsonRegex = /(^\s*)(AfterToJson\(ref\s*container\s*\);$)/gm
        $ = $.replace(afterJsonRegex, '$1$2\n$1AfterToJson(ref container, serializationMode);\n');

        // Pass exclusion properties to base classes during serialization.
        let baseClassInitializerRegex = /(new\s*Microsoft.Graph.PowerShell.Models.MicrosoftGraph\w*\(\s*json\s*,\s*new\s*global::System.Collections.Generic.HashSet<string>\()(\){\W.*}\);)/gm
        $ = $.replace(baseClassInitializerRegex, '$1(exclusions ?? new System.Collections.Generic.HashSet<string>())$2');

        // Fix additional properties deserialization in Complex Types.
        let complexTypeHintRegex = /(\s*)(Microsoft\.Graph\.PowerShell\.Runtime\.JsonSerializable\.FromJson)/gm
        if($.match(complexTypeHintRegex)) {
          let classNameRegex = /partial\s*class\s*(\w*)\s*{/gm
          let match = classNameRegex.exec($);
          let interfaceName = "I" + match[1] + "Internal";

          let getExclusionsDynamically = '\n$1if (exclusions == null) { exclusions = new System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase); var properties = typeof('+interfaceName+').GetProperties(); foreach (var property in properties) { exclusions.Add(property.Name);}}'
          $ = $.replace(complexTypeHintRegex, getExclusionsDynamically + '\n$1$2');
        }

        return $;
      }
# Modify generated .dictionary.cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5C\w*\d*.dictionary.cs/gm))
      {
        return $;
      } else {
        // Remove Count, Keys, and Values properties from implementations of an IAssociativeArray in models.
        let propertiesToRemoveRegex = /^.*Microsoft\.Graph\.PowerShell\.Runtime\.IAssociativeArray<global::System\.Object>\.(Count|Keys|Values).*$/gm
        $ = $.replace(propertiesToRemoveRegex, '');

        return $;
      }
# Modify generated .cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5CModels%5C\w*MicrosoftGraph\w*\d*.cs/gm))
      {
        return $;
      } else {
        // Add new modifier to 'additionalProperties' properties of classes that implement IAssociativeArray. See example https://regex101.com/r/hnX7xO/2.
        let additionalPropertiesRegex = /(SerializedName\s*=\s*@"additionalProperties".*\s*.*)(\s*)(.*AdditionalProperties\s*{\s*get;\s*set;\s*})/gmi
        if($.match(additionalPropertiesRegex)) {
          $ = $.replace(additionalPropertiesRegex, '$1$2 new $3');
        }

        return $;
      }
# Modify generated .cs cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2F\w*\d*.cs/gm))
      {
        return $;
      } else {
        // Initialize AdditionalProperties prop to a new Hashtable by default.
        let additionalPropertiesPropRegex = /System.Collections.Hashtable\s*AdditionalProperties\s*{\s*get;\s*set;\s*}$/gmi
        let newAdditionalPropertiesProp = "System.Collections.Hashtable AdditionalProperties { get; set; } = new System.Collections.Hashtable();"
        $ = $.replace(additionalPropertiesPropRegex, newAdditionalPropertiesProp);

        // Override OnDefault to handle all success, 2xx responses, as success and not error.
        let overrideOnDefaultRegex = /(\s*)(partial\s*void\s*overrideOnDefault)/gmi
        let overrideOnDefaultImplementation = "$1partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Graph.PowerShell.Models.IOdataError> response, ref global::System.Threading.Tasks.Task<bool> returnNow) => this.OverrideOnDefault(responseMessage,ref returnNow);$1$2"
        $ = $.replace(overrideOnDefaultRegex, overrideOnDefaultImplementation);

        return $;
      }

# Modify generated .cs list cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FGet\w*_List\d*.cs/gm))
      {
        return $;
      } else {
        let odataNextLinkRegex = /(^\s*)(if\s*\(\s*result.OdataNextLink\s*!=\s*null\s*\))/gmi
        if($.match(odataNextLinkRegex)) {
          // Add custom -PageSize parameter to *_List cmdlets that support Odata next link.
          $ = $.replace(odataNextLinkRegex, '$1if (result.OdataNextLink != null && this.ShouldIteratePages(this.InvocationInformation.BoundParameters, result.Value.Length))\n$1');

          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1Microsoft.Graph.PowerShell.Cmdlets.Custom.ListCmdlet');

          let beginProcessingRegex = /(^\s*)(protected\s*override\s*void\s*BeginProcessing\(\)\s*{)/gmi
          $ = $.replace(beginProcessingRegex, '$1$2\n$1  if (this.InvocationInformation?.BoundParameters != null){ InitializeCmdlet(ref this.__invocationInfo, ref this._top, ref this._count); }\n$1');

          let odataNextLinkCallRegex = /(^\s*)(await\s*this\.Client\.UsersUserListUser_Call\(requestMessage\,\s*onOk\,\s*onDefault\,\s*this\,\s*Pipeline\)\;)/gmi
          $ = $.replace(odataNextLinkCallRegex, '$1requestMessage.RequestUri = GetOverflowItemsNextLinkUri(requestMessage.RequestUri);\n$1$2');

          // Set -Count parameter to private. This will be replaced by -CountVariable
          let countParameterRegex = /public(\s*global::System\.Management\.Automation\.SwitchParameter\s*Count\s*)/gm
          $ = $.replace(countParameterRegex, 'private$1');

          // Call OnBeforeWriteObject to deserialize '@odata.count' from the response object.
          let writeObjectRegex = /^(\s*)(WriteObject\(result\.Value,true\);)$/gm
          $ = $.replace(writeObjectRegex,'\n$1OnBeforeWriteObject(this.InvocationInformation.BoundParameters, result?.AdditionalProperties);\n$1$2');

          // Format all Search values by adding quotes around them.
          let searchQueryRegex = /this\.InvocationInformation\.BoundParameters\.ContainsKey\("Search"\)\s*\?\s*Search\s*:\s*null/gm
          $ = $.replace(searchQueryRegex, 'this.FormatSearchValue(this.InvocationInformation.BoundParameters, Search)');
        }
        return $;
      }

# Modify generated .cs file download cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FGet\w*\d*.cs/gm))
      {
        return $;
      } else {
        let outFileParameterRegex = /(^\s*)public\s*global::System\.String\s*OutFile\s*/gmi
        let streamResponseRegex = /global::System\.Threading\.Tasks\.Task<global::System\.IO\.Stream>\s*response/gmi
        if($.match(outFileParameterRegex) && $.match(streamResponseRegex)) {
          // Handle file download.
          let overrideOnOkCallRegex = /(^\s*)(overrideOnOk\(\s*responseMessage\s*,\s*response\s*,\s*ref\s*_returnNow\s*\);)/gmi
          $ = $.replace(overrideOnOkCallRegex, '$1$2\n$1using(var stream = await response){ this.WriteToFile(responseMessage, stream, this.GetProviderPath(OutFile, false), _cancellationTokenSource.Token); _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);}\n$1');
        }
        return $;
      }

# Modify generated .cs file upload cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FSet\w*\d*.cs/gm))
      {
        return $;
      } else {
        let streamBodyParameterRegex = /(^\s*)public\s*global::System.IO.Stream\s*BodyParameter\s*/gmi
        if($.match(streamBodyParameterRegex)) {
          // Replace base class with FileUploadCmdlet.
          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1Microsoft.Graph.PowerShell.Cmdlets.Custom.FileUploadCmdlet');

          // Set bodyParameter to required to false.
          let streamBodyParameterAnnotation = /(global::System\.IO\.Stream _bodyParameter;\s*\[global::System\.Management\.Automation\.Parameter\(Mandatory\s*=\s*)(true)/gmi
          $ = $.replace(streamBodyParameterAnnotation, '$1false');

          // Handle file upload.
          let processRecordCallRegex = /(^\s*)(asyncCommandRuntime\.Wait\(\s*ProcessRecordAsync\s*\(\))/gmi
          $ = $.replace(processRecordCallRegex, '$1if (!MyInvocation.BoundParameters.ContainsKey(nameof(BodyParameter))){BodyParameter = GetFileAsStream() ?? BodyParameter;}\n$1$2');
        }
        return $;
      }

# Modify generated runtime TypeConverterExtensions class.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Cruntime%5CTypeConverterExtensions.cs/gm))
      {
        return $;
      } else {
        // Use a case-insensitive contains search.
        let keyValueContainsRegex = /(exclusions|inclusions)(\?.Contains\(key\?.ToString\(\))(\)\))/gm
        $ = $.replace(keyValueContainsRegex, '$1$2, System.StringComparer.OrdinalIgnoreCase$3');

        let propertyContainsRegex = /(exclusions|inclusions)(\?.Contains\(property.Name)(\)\))/gm
        $ = $.replace(propertyContainsRegex, '$1$2, System.StringComparer.OrdinalIgnoreCase$3');
        return $;
      }

# Modify generated runtime IJsonSerializable interface.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Cruntime%5CCustomizations%5CIJsonSerializable.cs/gm))
      {
        return $;
      } else {
        // Changes excludes hashset to a case-insensitive hashset.
        let fromJsonRegex = /(\s*FromJson<\w*>\s*\(JsonObject\s*json\s*,\s*System\.Collections\.Generic\.IDictionary.*)(\s*)({)/gm
        $ = $.replace(fromJsonRegex, '$1$2$3\n$2 if (excludes != null){ excludes = new System.Collections.Generic.HashSet<string>(excludes, global::System.StringComparer.OrdinalIgnoreCase);}');
        return $;
      }

# Modify generated runtime IAssociativeArray interface.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Cruntime%5CIAssociativeArray.cs/gm))
      {
        return $;
      } else {
        // Remove Count from IAssociativeArray interface.
        let countRegex = /int\s*Count\s*{\s*get;\s*}/gm
        $ = $.replace(countRegex, '');

        // Remove Keys from IAssociativeArray interface.
        let keysRegex = /System\.Collections\.Generic\.IEnumerable<string>\s*Keys\s*{\s*get;\s*}/gm
        $ = $.replace(keysRegex, '');

        // Remove Values from IAssociativeArray interface.
        let valuesRegex = /System\.Collections\.Generic\.IEnumerable<T>\s*Values\s*{\s*get;\s*}/gm
        $ = $.replace(valuesRegex, '');

        return $;
      }

# Serialize all $count parameter to lowercase true or false.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%5Capi%5C\w*.cs/gm))
      {
        return $;
      } else {
        // Add '.ToLower()' at the end of all 'Count.ToString()'
        let countRegex = /(Count\.ToString\(\))/gmi
        $ = $.replace(countRegex, '$1.ToLower()');
        return $;
      }
```
