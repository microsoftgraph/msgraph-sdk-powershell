using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> GroupsCmdletConfigurations =
    [
        // Groups: the nested lifecycle-policies GET ships renamed; everything else on that
        // route ships from the top-level set. Photos items ship nothing (singleton /photo).
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/groups/{}/grouplifecyclepolicies", Match: PathMatch.Exact, Value: "GroupLifecyclePolicyByGroup",
            Reason: "Groups.md directive (subject $1ByGroup); oracle ships Get-MgGroupLifecyclePolicyByGroup"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/grouplifecyclepolicies/", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: item/children under the nested route ship nothing; the set ships top-level"),
        new(OverrideKind.SuppressOperation, Method: null, "/groups/{}/photos/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: photos items ship nothing; shipped surface is the /photo singleton (Get-MgGroupPhoto)"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/joinedgroups/delta", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: exact compatible operation-ID regex match users.user.joinedGroups.delta"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/joinedgroups/evaluatedynamicmembership", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: exact compatible operation-ID regex match users.user.joinedGroups.evaluateDynamicMembership"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/groups/{}/acceptedsenders/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: legacy group_DeleteAcceptedSenderGraphBPreRef bridges groups.DeleteRefAcceptedSenders at this exact route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/groups/{}/members/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: legacy group_DeleteMemberGraphBPreRef bridges groups.DeleteRefMembers at this exact route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/groups/{}/owners/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: legacy group_DeleteOwnerGraphBPreRef bridges groups.DeleteRefOwners at this exact route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/groups/{}/rejectedsenders/$ref", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 1: legacy group_DeleteRejectedSenderGraphBPreRef bridges groups.DeleteRefRejectedSenders at this exact route"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/validateproperties", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 4: remove unbound Validate1/ValidateExpanded1; retain bound /groups/{id}/validateProperties"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/groups/evaluatedynamicmembership", Match: PathMatch.Exact, Value: "GroupDynamicMembershipRule",
            Reason: "Groups.md directive 5: Evaluate1/Expanded1 is the unbound action, not evaluation of an existing group"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/groups/evaluatedynamicmembership", Match: PathMatch.Exact, Value: "Test",
            Reason: "Groups.md directive 5: preserve the selected Test verb for the renamed unbound action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/grouplifecyclepolicies/{}/removegroup", Match: PathMatch.Exact, Value: "GroupFromLifecyclePolicy",
            Reason: "Groups.md directive 6: GroupLifecyclePolicyGroup becomes GroupFromLifecyclePolicy"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/grouplifecyclepolicies/{}/removegroup", Match: PathMatch.Exact, Value: "Remove",
            Reason: "Groups.md directive 6: preserve the selected Remove verb; POST is an action, not a resource deletion"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/grouplifecyclepolicies/{}/addgroup", Match: PathMatch.Exact, Value: "GroupToLifecyclePolicy",
            Reason: "Groups.md directive 7: GroupLifecyclePolicyGroup becomes GroupToLifecyclePolicy"),
        new(OverrideKind.ReplaceVerb, HttpMethod.Post, "/grouplifecyclepolicies/{}/addgroup", Match: PathMatch.Exact, Value: "Add",
            Reason: "Groups.md directive 7: preserve the selected Add verb for the lifecycle-policy action"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/grouplifecyclepolicies/renewgroup", Match: PathMatch.Exact, Value: "RenewGroupLifecyclePolicy",
            Reason: "Groups.md directive 9: retained unbound Renew/Expanded action; nested Renew1 is already suppressed"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/groups/{}/photo", Match: PathMatch.Exact, Value: null,
            Reason: "Groups.md directive 17: remove Update-GroupPhoto metadata, not GET photo or PUT photo/$value"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/groups/{}/acceptedsenders/{}/$ref", Match: PathMatch.Exact, Value: "GroupAcceptedSenderDirectoryObjectByRef",
            Reason: "beta generation collision: published metadata names the item DELETE Remove-MgBetaGroupAcceptedSenderDirectoryObjectByRef"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/groups/{}/members/{}/$ref", Match: PathMatch.Exact, Value: "GroupMemberDirectoryObjectByRef",
            Reason: "beta generation collision: published metadata names the item DELETE Remove-MgBetaGroupMemberDirectoryObjectByRef"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/groups/{}/owners/{}/$ref", Match: PathMatch.Exact, Value: "GroupOwnerDirectoryObjectByRef",
            Reason: "beta generation collision: published metadata names the item DELETE Remove-MgBetaGroupOwnerDirectoryObjectByRef"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/groups/{}/rejectedsenders/{}/$ref", Match: PathMatch.Exact, Value: "GroupRejectedSenderDirectoryObjectByRef",
            Reason: "beta generation collision: published metadata names the item DELETE Remove-MgBetaGroupRejectedSenderDirectoryObjectByRef"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/groups/{}/grouplifecyclepolicies", Match: PathMatch.Exact, Value: null,
            Reason: "beta generation collision: no published nested POST; New-MgBetaGroupLifecyclePolicy uses /groupLifecyclePolicies, matching v1.0 derived suppression"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/photos/{}/$value", Match: PathMatch.Exact, Value: null,
            Reason: "beta generation collision: no published item-content GET; Get-MgBetaGroupPhotoContent uses /photo/$value, matching v1.0 derived suppression"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/groups/{}/photos/{}/$value", Match: PathMatch.Exact, Value: null,
            Reason: "beta generation collision: no published item-content DELETE; Remove-MgBetaGroupPhotoContent uses /photo/$value, matching v1.0 derived suppression"),
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/groups/{}/photos", Match: PathMatch.Exact, Value: null,
            Reason: "beta generation collision: published Get-MgBetaGroupPhoto also serves /photo; retain singleton pending cross-path parameter-set merging, as in v1.0"),
    ];
}
