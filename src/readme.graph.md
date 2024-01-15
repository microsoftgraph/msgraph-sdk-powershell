# Microsoft Graph AutoRest Configuration

> Common

``` yaml
azure: false
powershell: true
version: latest
#use: "@autorest/powershell@3.0.509"
use: "$(this-folder)../autorest.powershell"
export-properties-for-dict: false
metadata:
    authors: Microsoft Corporation
    owners: Microsoft Corporation
    companyName: Microsoft Corporation
    description: 'Microsoft Graph PowerShell Cmdlets'
    copyright: &copy; Microsoft Corporation. All rights reserved.
    tags: Microsoft Office365 Graph PowerShell PSModule PSIncludes_Cmdlet
    requireLicenseAcceptance: true
    licenseUri: https://aka.ms/devservicesagreement
    projectUri: https://github.com/microsoftgraph/msgraph-sdk-powershell
    iconUri: https://raw.githubusercontent.com/microsoftgraph/g-raph/master/g-raph.png
```

> Default Output Format

``` yaml
require:
  - $(this-folder)/readme.graph.default.output.md
```

> Names

``` yaml
prefix: Mg
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
    - MicrosoftGraphSharepointIds
    - MicrosoftGraphIdentitySet
    - MicrosoftGraphItemReference
    - MicrosoftGraphDirectoryObject
    - MicrosoftGraphUser
    - MicrosoftGraphDrive
    - MicrosoftGraphListItem
    - MicrosoftGraphPost
    - MicrosoftGraphSectionGroup
    - MicrosoftGraphTeam
    - MicrosoftGraphRecipient
    - MicrosoftGraphGroupPolicyCategory
    - MicrosoftGraphPrinter
    - MicrosoftGraphPrinterShare
    - MicrosoftGraphGovernanceResource
    - MicrosoftGraphGovernanceRoleAssignment
    - MicrosoftGraphGovernanceRoleDefinition
    - MicrosoftGraphWorkbookOperationError
    - MicrosoftGraphParentLabelDetails
    - MicrosoftGraphEdiscoveryTag
    - MicrosoftGraphEdiscoverySourceCollection
    - MicrosoftGraphContentType
    - MicrosoftGraphColumnDefinition
    - MicrosoftGraphGroupPolicyDefinition
    - MicrosoftGraphGroupPolicyDefinitionValue
    - MicrosoftGraphSynchronizationLinkedObjects
    - MicrosoftGraphSecuritySecurity
    - MicrosoftGraphTeamSummary
    - MicrosoftGraphSecurityInformationProtection
    - MicrosoftGraphSecurityInformationProtectionPolicySetting
    - MicrosoftGraphSecuritySensitivityLabel
    - MicrosoftGraphTaskViewpoint
    - MicrosoftGraphSecurityEdiscoveryReviewTag
    - MicrosoftGraphSecurityEdiscoverySearch
    - MicrosoftGraphManagedTenantsManagementTemplateStep
    - MicrosoftGraphPlannerTaskCreation
    - MicrosoftGraphPlannerTeamsPublicationInfo
    - MicrosoftGraphWorkbookComment
    - MicrosoftGraphSecurityHost
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
  - where:
      parameter-name: ConsistencyLevel
    set:
      completer:
        name: ConsistencyLevel Completer
        description: Gets the list of ConsistencyLevel header values.
        script: "'eventual'"
# Rename parameters.
  - where:
      variant: ^(Add|Insert|Apply|Approve|Unset|Clear|Wipe|Check|Copy|Disable|Locate|Get|Delta|Abort|Accept|Answer|Autofit|Bounding|Cell|Clean|Column|Columns|Commit|Decline|Dismiss|Down|Entire|Filter|Forward|Intersection|Invite|Keep|Last|Logout|Mute|Offset|Play|Preview|Range|Reassign|Reauthorize|Record|Redirect|Reject|Renew|Reply|Retire|Return|Row|Rows|Scan|Schedule|Snooze|Subscribe|Supported|Target|Time|Unmerge|Unmute|Unsubmit|View|Associate|Lock|Merge|Transfer|Move|Create|Update|Publish|Delete|Remove|Change|Request|Reset|Reboot|Restore|Recover|Send|Set|Assign|Bypass|Start|Cancel|Stop|Submit|Sync|Is|Unpublish|Purge|Close|Compare|Complete|Verify|Confirm|Clone|Disconnect|Enable|Export|Discover|Find|Acquire|Managed|Top|Grant|Hide|Import|Activate|Account|Archive|As|Batch|Begin|Bulk|Calendar|Clock|Cloud|Consent|Custom|Deprovision|Access|Estimate|Execute|Extend|Extract|Post|Force|Functions|Has|Have|Instantiate|Invalidate|License|Mark|Messages|Override|Parse|Pending|Postpone|Reactivate|Recent|Reenable|Reopen|Report|Reprovision|Reupload|Role|Rotate|Scoped|Self|Shared|Share|Soft|Summarize|Translate|Troubleshoot|Unarchive|Unassign|Unhide|Unshare|Unsubscribe|Upload|Users|Migrate|Provision|Generate|Make|Ping|Release|Rename|Resize|Restart|Resume|Revoke|Search|Trigger|Run|End|Pause|Validate|Evaluate|Unblock|Undo|Upgrade|Reprocess|Patch)\d*$
      parameter-name: Body
    set:
      parameter-name: BodyParameter
  - where:
      variant: ^(.*ViaIdentity)\d*$
      parameter-name: Body
    set:
      parameter-name: BodyParameter
# Rename cmdlets
  - where:
      verb: Invoke
      subject: (^Delta)(.*)
    set:
      verb: Get
      subject: $2$1
  - where:
      verb: Test
      variant: ^(Check|Verify)(.*)
    set:
      verb: Confirm
  - where:
      subject: ^(Office)(Configuration)(ClientConfiguration.*)
    set:
      subject: $1$3
  - where:
      verb: Invoke
      subject: ^Link(.*)HasPayload$
    set:
      subject: Has$1PayloadLink
  - where:
      verb: Get
      subject: ^(.*)List(.*)(As.*)$
    set:
      subject: $1$2$3
  - where:
      subject: ^(Admin)(Person)
    set:
      subject: AdminPeople
# Remove *AvailableExtensionProperty commands except those bound to DirectoryObject.
  - where:
      subject: ^(?!DirectoryObject).*AvailableExtensionProperty$
    remove: true
  - where:
      verb: Clear
      subject: ^UserManagedAppRegistrationByDeviceTag$
      variant: ^Wipe1$|^WipeExpanded1$|^WipeViaIdentity1$|^WipeViaIdentityExpanded1$
# Remove commands
  - where:
      verb: Restore
      subject: ^(Application|Contact|Contract|Device|DirectoryObject|DirectoryRole|DirectoryRoleTemplate|EntitlementManagementConnectedOrganizationInternalSponsor|Group|GroupPermissionGrant|Organization|ServicePrincipal|User|UserAuthenticationMicrosoftAuthenticatorMethodDevice|UserAuthenticationWindowHelloForBusinessMethodDevice|AdministrativeUnit|ChatPermissionGrant|DirectoryAdministrativeUnit|DirectorySettingTemplate|TeamPermissionGrant|UserAuthenticationPasswordlessMicrosoftAuthenticatorMethodDevice|UserChatPermissionGrant|UserDevice)$
    remove: true
# Rename prepositions to bypass https://github.com/Azure/autorest.powershell/issues/795.
  - where:
      subject: ^(\w*[a-z])GraphBPre(\w*)$
    set:
      subject: $1By$2
  - where:
      subject: ^(\w*[a-z])GraphWPre(\w*)$
    set:
      subject: $1With$2
  - where:
      subject: ^(\w*[a-z])GraphAPre(\w*)$
    set:
      subject: $1At$2
  - where:
      subject: ^(\w*[a-z])GraphFPre(\w*)$
    set:
      subject: $1For$2
  - where:
      subject: ^(\w*[a-z])GraphOPre(\w*)$
    set:
      subject: $1Of$2
  - where:
      verb: Clear
      subject: ^UserManagedAppRegistrationByDeviceTag$
      variant: ^Wipe$|^WipeExpanded$|^WipeViaIdentity$|^WipeViaIdentityExpanded$
    remove: true
  - where:
      verb: New|Remove|Update|Get
      subject: ^(.*)(IdentityGovernance)TermOfUse$
    remove: true
# Pluralize commands
  - where:
      subject: (\w*[a-z]|^)Window([^s]\w*|$)
    set:
      subject: $1Windows$2
  - where:
      subject: (\w*[a-z]|^)TermOfUse([A-Z]\w*|$)
    set:
      subject: $1TermsOfUse$2
  - where:
      subject: (\w*[a-z]|^)MethodSm([A-Z]\w*|$)
    set:
      subject: $1MethodSms$2
  - where:
      subject: (\w*[a-z]|^)PassiveDn([^s]\w*|$)
    set:
      subject: $1PassiveDns$2
  - where:
      subject: (\w*[a-z]|^)UsageRight([^s]\w*|$)
    set:
      subject: $1UsageRights$2
# Modify OpenAPI documents to correct AutoREST.PowerShell limitations.
# Change content-type from text/plain to application/json. AutoREST does not support non-json content types.
# See https://github.com/Azure/autorest.powershell/issues/206.
  - from: 'openapi-document'
    where: $.components.responses.ODataCountResponse.content
    transform: >-
          return {
            "application/json": {
                "schema" : {
                    "$ref" : '#/components/schemas/ODataCountResponse'
                }
            }
          }
# Add Microsoft Graph error properties to InnerError.
  - from: 'openapi-document'
    where: $.components.schemas['microsoft.graph.ODataErrors.InnerError']
    transform: >-
      return {
        "type": "object",
        "properties": {
            "date" : {
                "type" : 'string'
            },
            "request-id" : {
                "type" : 'string'
            },
            "client-request-id" : {
                "type" : 'string'
            }
        },
        "additionalProperties": {
            "type" : "object"
        }
      }
# Mark '@odata.id' as required properties for /$ref.
  - from: 'openapi-document'
    where: $.components.schemas.ReferenceCreate
    transform: $['required'] = ['@odata.id']
  - from: 'openapi-document'
    where: $.components.schemas.ReferenceCreate..properties['@odata.id']
    transform: $['description'] = 'The entity reference URL of the resource. For example, https://graph.microsoft.com/v1.0/directoryObjects/{id}.'
  - from: 'openapi-document'
    where: $.components.schemas.ReferenceUpdate
    transform: $['required'] = ['@odata.id']
  - from: 'openapi-document'
    where: $.components.schemas.ReferenceUpdate..properties['@odata.id']
    transform: $['description'] = 'The entity reference URL of the resource. For example, https://graph.microsoft.com/v1.0/directoryObjects/{id}.'
# Fix Base64 serialization.
  - from: 'openapi-document'
    where: $.components.schemas..properties.*
    transform: >-
        if ($.format === 'base64url') { $['format'] = 'byte' }
# Mark consistency level parameter as required for /$count paths when header is present.
  - from: openapi-document
    where: $..paths.*[?(/(.*_GetCount)/gmi.exec(@.operationId))]..parameters[?(@.name === "ConsistencyLevel")]
    transform: $['required'] = true
# Fix binary response definition for AutoREST to generate -OutFile parameter.
  - from: openapi-document
    where: $..paths..responses['2XX'].content['application/octet-stream'].schema
    transform: >-
      if ($.type === 'object') { $['format'] = "binary" }
# Modify generated .json.cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2FModels%2F\w*MicrosoftGraph\w*\d*.json.cs/gm))
      {
        return $;
      } else {
        // Add AfterToJson
        let afterJsonDeclarationRegex = /(^\s*)(partial\s*void\s*AfterFromJson\s*\(Microsoft.(Graph|Graph.Beta).PowerShell.Runtime.Json.JsonObject\s*json\s*\);$)/gm
        $ = $.replace(afterJsonDeclarationRegex, '$1$2\n$1partial void AfterToJson(ref Microsoft.$3.PowerShell.Runtime.Json.JsonObject container, Microsoft.$3.PowerShell.Runtime.SerializationMode serializationMode);\n');
        let afterJsonRegex = /(^\s*)(AfterToJson\(ref\s*container\s*\);$)/gm
        $ = $.replace(afterJsonRegex, '$1$2\n$1AfterToJson(ref container, serializationMode);\n');

        // Pass exclusion properties to base classes during serialization.
        let baseClassInitializerRegex = /(new\s*Microsoft.(Graph|Graph.Beta).PowerShell.Models.MicrosoftGraph\w*\(\s*json\s*,\s*new\s*global::System.Collections.Generic.HashSet<string>\()(\){\W.*}\);)/gm
        $ = $.replace(baseClassInitializerRegex, '$1(exclusions ?? new System.Collections.Generic.HashSet<string>())$3');

        // Fix additional properties deserialization in Complex Types.
        let complexTypeHintRegex = /(\s*)(Microsoft\.(Graph|Graph\.Beta)\.PowerShell\.Runtime\.JsonSerializable\.FromJson)/gm
        if($.match(complexTypeHintRegex)) {
          let classNameRegex = /partial\s*class\s*(\w*)\s*{/gm
          let match = classNameRegex.exec($);
          let interfaceName = "I" + match[1] + "Internal";

          let getExclusionsDynamically = '\n$1if (exclusions == null) { exclusions = new System.Collections.Generic.HashSet<string>(global::System.StringComparer.OrdinalIgnoreCase); var properties = typeof('+interfaceName+').GetProperties(); foreach (var property in properties) { exclusions.Add(property.Name);}}'
          $ = $.replace(complexTypeHintRegex, getExclusionsDynamically + '\n$1$2');
        }

        // Ensure dateTime is always serialized as Utc.
        let dateTimeToJsonRegex = /(\.Json\.JsonString\()(.*)\?(\.ToString\(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss\.fffffffK")/gm
        $ = $.replace(dateTimeToJsonRegex, '$1System.DateTime.SpecifyKind($2.Value.ToUniversalTime(), System.DateTimeKind.Utc)$3');

        return $;
      }
# Modify generated .dictionary.cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2FModels%2F\w*\d*.dictionary.cs/gm))
      {
        return $;
      } else {
        // Remove Count, Keys, and Values properties from implementations of an IAssociativeArray in models.
        let propertiesToRemoveRegex = /^.*Microsoft\.(Graph|Graph\.Beta)\.PowerShell\.Runtime\.IAssociativeArray<global::System\.Object>\.(Count|Keys|Values).*$/gm
        $ = $.replace(propertiesToRemoveRegex, '');

        let classRegex = /((\s*)public\s*partial\s*class\s*MicrosoftGraph(NamedLocation).*\s.*\s*\{)/gm
        if($.match(classRegex)) {
          let toFirstUpperImplementation = 'internal string ToFirstCharacterLowerCase(string text) => System.String.IsNullOrEmpty(text) ? text : $"{char.ToLowerInvariant(text[0])}{text.Substring(1)}";'
          $ = $.replace(classRegex, `$1$2${toFirstUpperImplementation}`)
          
          let directoryKeyRegex = /\.Add\((\s*property\.Key\.ToString\(\))/gm
          $ = $.replace(directoryKeyRegex, '.Add(ToFirstCharacterLowerCase($1)')
        }

        // Rename additionalProperties indexer name from Item to EntityItem to avoid property name conflict.
        // See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/using-indexers
        let indexerRegex = /^(\s*)(public\s*global::System\.Object\s*this\[global::System\.String\s*index\])/gm
        $ = $.replace(indexerRegex, '$1[System.Runtime.CompilerServices.IndexerName("EntityItem")]\n$2')
        
        return $;
      }
# Modify generated .PowerShell.cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2FModels%2F\w*\d*.PowerShell.cs/gm))
      {
        return $;
      } else {
        // Add using namespaces to class.
        let namespaceRegex = /(namespace.*.Models\n\{)/gm
        $ = $.replace(namespaceRegex,'$1\n\tusing System.Linq;');

        // Change XmlDateTimeSerializationMode from Unspecified to Utc.
        let strToDateTimeRegex = /(XmlConvert\.ToDateTime\(.*,.*XmlDateTimeSerializationMode\.)Unspecified/gm
        $ = $.replace(strToDateTimeRegex, '$1Utc');

        // Use case-insensitive dictionary when deserializing from dictionaries/OrderedHashtables.
        let deserializeFromDictionaryRegex = /(.*DeserializeFromDictionary\(.*IDictionary.*\n.*\{.*\n.*new.*\()content(\);)/gm
        $ = $.replace(deserializeFromDictionaryRegex, '$1(content.Cast<global::System.Collections.DictionaryEntry>().ToDictionary(kvp => kvp.Key as string, kvp => kvp.Value, global::System.StringComparer.OrdinalIgnoreCase))$2');

        return $;
      }
# Modify generated .cs model classes.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2FModels%2F\w*MicrosoftGraph\w*\d*.cs/gm))
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

        // Remove noisy log messages.
        let duplicateDebugRegex = /^(\s*)(WriteDebug\(\$"{id}:.*)/gmi
        $ = $.replace(duplicateDebugRegex, "");

        // catch all exceptions in ProcessRecordAsync.
        let processAsyncFinallyRegex = /(finally\s*{\s*await \(\(Microsoft\.(Graph|Graph\.Beta)\.PowerShell\.Runtime\.IEventListener\)this\)\.Signal\(Microsoft\.(Graph|Graph\.Beta)\.PowerShell\.Runtime\.Events\.CmdletProcessRecordAsyncEnd\);)/gmi
        let catchAllExceptionImplementation = '((Runtime.IEventListener)this).Signal(Runtime.Events.CmdletException, $"{ex.GetType().Name} - {ex.Message} : {ex.StackTrace}").Wait(); if (((Runtime.IEventListener)this).Token.IsCancellationRequested) { return; } WriteError(new global::System.Management.Automation.ErrorRecord(ex, string.Empty, global::System.Management.Automation.ErrorCategory.NotSpecified, null));'
        $ = $.replace(processAsyncFinallyRegex, `catch (System.Exception ex){${catchAllExceptionImplementation}}\n$1`);

        // Add API path to should process message.
        let operationRegex = /\[OpenAPI\].s*(.*)=>(.*):\"(.*)\"/gmi
        let shouldProcessRegex = /SupportsShouldProcess\s*=\s*true/gmi
        let shouldProcessMessageRegex = /\$("Call\s*remote\s*').*('\s*operation")/gmi
        if ($.match(shouldProcessRegex)) {
          var operationMatch = operationRegex.exec($);
          if (operationMatch) {
            $ = $.replace(shouldProcessMessageRegex, `$1${operationMatch[2]} ${operationMatch[3]}$2`);
          }
        }

        // Format error details.
        let errorDetailsRegex = /(ErrorDetails\s*=\s*)(new.*ErrorDetails\(message\).*)/gmi
        $ = $.replace(errorDetailsRegex, '$1await this.GetErrorDetailsAsync((await response)?.Error, responseMessage)');

        // Prevents null response objects to the output stream for scenarios where response is a model type
        let responseTypeRegex = /global::System.Threading.Tasks.Task<Microsoft.Graph(.|.Beta.)PowerShell.Models.\w*> \w*\)[^]*?(WriteObject.*(await response).*;)/gm
        var writeObjectRegex = /(WriteObject.*(await response).*;)/gm
        var responseTypeRegexMatch = $.match(responseTypeRegex);
        if(responseTypeRegexMatch){
           responseTypeRegexMatch.forEach((item)=>{
            var writeObjectRegexMatch = writeObjectRegex.exec($);
            if(writeObjectRegexMatch){
              var newContent = item.replace(writeObjectRegex, `var result = ${writeObjectRegexMatch[2]}; if(result!=null){WriteObject(result);}`)
              $ = $.replace(item, newContent);
            }
           });
        }
        
        return $;
      }

# Modify generated .cs list cmdlets.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fcmdlets%2FGet\w*_(List|Delta)\d*.cs/gm))
      {
        return $;
      } else {
        let odataNextLinkRegex = /(^\s*)(while\s*\(\s*_nextLink\s*!=\s*null\s*\))/gmi
        if($.match(odataNextLinkRegex)) {
          // Add custom -PageSize parameter to *_List and *_delta cmdlets that support Odata next link.
          let initializePageCountPlaceholder = 'this.InitializePageCount(result.Value.Length);'
          $ = $.replace(odataNextLinkRegex, `$1${initializePageCountPlaceholder}\n$1while (_nextLink != null && this.ShouldIteratePages(this.InvocationInformation.BoundParameters, result.Value.Length))$1`);

          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1PowerShell.Cmdlets.Custom.ListCmdlet');

          let beginProcessingRegex = /(^\s*)(protected\s*override\s*void\s*BeginProcessing\(\)\s*{)/gmi
          let topPlaceholder = (!$.includes("private int _top;")) ? 'int _top = default;': ''
          let countPlaceholder = (!$.includes("SwitchParameter _count;")) ? 'global::System.Management.Automation.SwitchParameter _count;': ''
          $ = $.replace(beginProcessingRegex, `$1$2\n$1 ${countPlaceholder} ${topPlaceholder} if (this.InvocationInformation?.BoundParameters != null){ InitializeCmdlet(ref this.__invocationInfo, ref _top, ref _count); }\n$1`);

          let odataNextLinkCallRegex = /(^\s*)(await\s*this\.Client\..*_Call\(requestMessage\,\s*onOk\,\s*onDefault\,\s*this\,\s*Pipeline\)\;)/gmi
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

          // Unescape -Filter values before escaping.
          let filterQueryRegex = /(this\.InvocationInformation\.BoundParameters\.ContainsKey\("Filter"\)\s*\?\s*)(Filter)(\s*:\s*null)/gm
          $ = $.replace(filterQueryRegex, '$1this.UnescapeString($2)$3');
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
        let octetStreamSchemaResponseRegex = /global::System\.Threading\.Tasks\.Task<.*(OctetStreamSchema|GraphReport)>\s*response/gmi
        let overrideOn2XxCallRegex = /(^\s*)(overrideOn2Xx\(\s*responseMessage\s*,\s*response\s*,\s*ref\s*_returnNow\s*\);)/gmi
        if($.match(outFileParameterRegex) && $.match(streamResponseRegex)) {
          // Handle file download.
          $ = $.replace(overrideOn2XxCallRegex, '$1$2\n$1using(var stream = await response){ this.WriteToFile(responseMessage, stream, this.GetProviderPath(OutFile, false), _cancellationTokenSource.Token); _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);}\n$1');
        } else if ($.match(outFileParameterRegex) && $.match(octetStreamSchemaResponseRegex)){
          $ = $.replace(overrideOn2XxCallRegex, '$1$2\n$1using(var stream = await responseMessage.Content.ReadAsStreamAsync()){ this.WriteToFile(responseMessage, stream, this.GetProviderPath(OutFile, false), _cancellationTokenSource.Token); _returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);}\n$1');
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
        let streamDataRegex = /(^\s*)public\s*global::System.IO.Stream\s*Data\s*/gmi
        if($.match(streamDataRegex)) {
          // Replace base class with FileUploadCmdlet.
          let psBaseClassImplementationRegex = /(\s*:\s*)(global::System.Management.Automation.PSCmdlet)/gmi
          $ = $.replace(psBaseClassImplementationRegex, '$1PowerShell.Cmdlets.Custom.FileUploadCmdlet');

          // Set Data to required to false.
          let streamDataAnnotation = /(global::System\.IO\.Stream _data;\s*\[global::System\.Management\.Automation\.Parameter\(Mandatory\s*=\s*)(true)/gmi
          $ = $.replace(streamDataAnnotation, '$1false');

          // Handle file upload.
          let processRecordCallRegex = /(^\s*)(asyncCommandRuntime\.Wait\(\s*ProcessRecordAsync\s*\(\))/gmi
          $ = $.replace(processRecordCallRegex, '$1if (!MyInvocation.BoundParameters.ContainsKey(nameof(Data))){Data = GetFileAsStream() ?? Data;}\n$1$2');
        }
        return $;
      }

# Modify generated runtime TypeConverterExtensions class.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fruntime%2FTypeConverterExtensions.cs/gm))
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
      if (!$documentPath.match(/generated%2Fruntime%2FCustomizations%2FIJsonSerializable.cs/gm))
      {
        return $;
      } else {
        // Add using namespaces to class.
        let namespaceRegex = /(namespace.*.Runtime\n\{)/gm
        $ = $.replace(namespaceRegex,'$1\n\tusing System.Linq;');

        // Changes excludes hashset to a case-insensitive hashset.
        let fromJsonRegex = /(\s*FromJson<\w*>\s*\(JsonObject\s*json\s*,\s*System\.Collections\.Generic\.IDictionary.*)(\s*)({)/gm
        $ = $.replace(fromJsonRegex, '$1$2$3\n$2 if (excludes != null){ excludes = new System.Collections.Generic.HashSet<string>(excludes, global::System.StringComparer.OrdinalIgnoreCase);}');

        // Serialize OrderedDictionary
        let enumerableRegex = /(if.*\(value.*IEnumerable.*\))/gm
        let orderedSerializerImpl = 'if (value is System.Collections.Specialized.OrderedDictionary ovalue) { return JsonSerializable.ToJson((ovalue?.Cast<global::System.Collections.DictionaryEntry>().ToDictionary(kvp => kvp.Key as string, kvp => kvp.Value, global::System.StringComparer.OrdinalIgnoreCase)), null);}';
        $ = $.replace(enumerableRegex, `${orderedSerializerImpl}\n\n$1`)

        return $;
      }

# Modify generated runtime IAssociativeArray interface.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fruntime%2FIAssociativeArray.cs/gm))
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

# Modify generated JsonObject class.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fruntime%2FNodes%2FJsonObject.cs/gm))
      {
        return $;
      } else {
        // Make JsonObject's items dictionary case insensitive.
        let dictionaryInitRegex = /(\s*=\s*new\s*Dictionary<string,\s*JsonNode>\()(\);)/gm
        $ = $.replace(dictionaryInitRegex, '$1StringComparer.InvariantCultureIgnoreCase$2');

        return $;
      }

# Modify API class.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2F\w*.cs/gm))
      {
        return $;
      } else {
        // Serialize all $count parameter to lowercase true or false.
        // Add '.ToLower()' at the end of all 'Count.ToString()
        let countRegex = /(Count\.ToString\(\))/gmi
        $ = $.replace(countRegex, '$1.ToLower()');

        // Serialize streams (not supported by AutoREST).
        let streamContentRegex = /(request\.Content\s*=)\s*null\s*\/\*\s*serializeToNode\s*doesn't.*.\s*(request\.Content\.Headers\.ContentType.*Parse)\("application\/json"\);/gmi
        $ = $.replace(streamContentRegex, '$1 new global::System.Net.Http.StreamContent(body);\n $2("application/octet-stream");');

        // Fix double = in date parameter. Temp fix for https://github.com/Azure/autorest.powershell/issues/1025.
        let dateAssignmentRegex = /(date="\n.*)(\+.*"=")(.*\+.*date)/gmi
        $ = $.replace(dateAssignmentRegex, '$1 $3');
        return $;
      }

# Fix enums with underscore.
  - from: source-file-csharp
    where: $
    transform: >
      if (!$documentPath.match(/generated%2Fapi%2FSupport%2F(WindowsMalwareCategory|RunAsAccountType|(AssignmentFilter|DeviceScope)Operator).cs/gmi))
      {
        return $;
      } else {
        // Add underscore to enum properties that have underscore in their value to avoid duplicates.
        let remoteControlSoftwareRegex = /RemoteControlSoftware(\s*=\s*@"remote_Control_Software")/gmi
        $ = $.replace(remoteControlSoftwareRegex, 'Remote_Control_Software$1');

        let equalsRegex = /Equals(\s*=\s*@"equals")/gmi
        $ = $.replace(equalsRegex, '_Equals$1');

        let systemRegex = /System(\s*=\s*@"system")/gmi
        $ = $.replace(systemRegex, '_System$1');
        return $;
      }
```
