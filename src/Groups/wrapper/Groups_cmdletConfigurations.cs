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
    ];
}
