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
    ];
}
