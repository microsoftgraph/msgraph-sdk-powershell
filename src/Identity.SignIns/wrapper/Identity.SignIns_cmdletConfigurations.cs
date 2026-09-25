using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> IdentitySignInsCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, Method: null, "/identityproviders", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: the deprecated top-level /identityProviders set ships nothing in v1.0; shipped surface is /identity/identityProviders (Get-MgIdentityProvider)"),
    ];
}
