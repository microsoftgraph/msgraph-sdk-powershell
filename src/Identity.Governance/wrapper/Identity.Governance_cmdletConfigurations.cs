using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> IdentityGovernanceCmdletConfigurations =
    [
        // Agreement file item operations ship only from the /file singleton; /files/{} items
        // ship nothing, while /files/{}/versions remains a valid descendant.
        new(OverrideKind.SuppressOperation, Method: null, "/agreements/{}/files/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: /files/{} item ops ship nothing; file surface is the /file singleton (Update/Remove-MgAgreementFile)"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/termsofuse/agreements/{}/files/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: ships nothing; mirrors /agreements/{}/files/{} suppression"),
        // GET of the file/files pair ships from the collection; Update/Remove stay on singleton.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/agreements/{}/file", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgAgreementFile serves /file and /files; GET generated from the collection side only"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/identitygovernance/termsofuse/agreements/{}/file", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgIdentityGovernanceTermsOfUseAgreementFile serves /file and /files; GET from the collection side only"),
        // The /scope node duplicates its parent's noun and ships nothing anywhere; its
        // children ship with the Scope segment elided.
        new(OverrideKind.SuppressOperation, Method: null, "/resourcerolescopes/{}/scope", Match: PathMatch.Suffix, Value: null,
            Reason: "oracle: the /scope node ships nothing under any parent; children ship with Scope elided"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/entitlementmanagement/assignments/{}/assignmentpolicy", Match: PathMatch.Exact, Value: null,
            Reason: "nav duplicate of /assignmentPolicies (Get-MgEntitlementManagementAssignmentPolicy); ships nothing"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/entitlementmanagement/resources/{}/environment", Match: PathMatch.Exact, Value: null,
            Reason: "nav duplicate of /resourceEnvironments (Get-MgEntitlementManagementResourceEnvironment); ships nothing"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/lifecycleworkflows", Match: PathMatch.Exact, Value: null,
            Reason: "the container node's own operations ship nothing; its children ship"),
        new(OverrideKind.SuppressOperation, Method: null, "/identitygovernance/termsofuse/agreements/{}/acceptances", Match: PathMatch.Prefix, Value: null,
            Reason: "ships nothing; acceptances ship from /termsOfUse/agreementAcceptances (Get-MgIdentityGovernanceTermsOfUseAgreementAcceptance)"),
    ];
}
