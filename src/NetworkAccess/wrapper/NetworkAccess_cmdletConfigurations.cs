using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> NetworkAccessCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, HttpMethod.Patch,
            "/networkaccess/forwardingpolicies/{}/policyrules/{}",
            Match: PathMatch.Exact, Value: null,
            Reason: "NetworkAccess.md directive 3 removes Update NetworkAccessForwardingPolicyRule"),

        // A policyLink and its linked policy have identical IDs but different response models.
        // Keep ordinary policy-link List/Get names and distinguish the nested policy navigation.
        new(OverrideKind.ReplaceNoun, HttpMethod.Get,
            "/networkaccess/connectivity/remotenetworks/{}/forwardingprofiles/{}/policies/{}/policy",
            Match: PathMatch.Exact, Value: "NetworkAccessConnectivityRemoteNetworkForwardingProfilePolicyLinkPolicy",
            Reason: "GET policy beneath a networkaccess.policyLink returns networkaccess.policy, not the parent link"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get,
            "/networkaccess/filteringprofiles/{}/policies/{}/policy",
            Match: PathMatch.Exact, Value: "NetworkAccessFilteringProfilePolicyLinkPolicy",
            Reason: "GET policy beneath a networkaccess.policyLink returns networkaccess.policy, not the parent link"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get,
            "/networkaccess/forwardingprofiles/{}/policies/{}/policy",
            Match: PathMatch.Exact, Value: "NetworkAccessForwardingProfilePolicyLinkPolicy",
            Reason: "GET policy beneath a networkaccess.policyLink returns networkaccess.policy, not the parent link"),
    ];
}
