using System;
using System.Collections.Generic;

namespace WrapperGenerator;

// The module and resolved operation values CmdletEmitter's templates need.
// ClientNamespace is whatever --namespace-name the module was generated with, for example
// "Microsoft.Graph.PowerShell.Mail.Client".
public sealed record EmitContext(string ClientNamespace, string ApiVersion = "v1.0")
{
    // Resolved per-operation inputs, not authored generator configuration.
    internal IReadOnlyList<CmdletProperty> RequiredQueries { get; init; } = [];

    public string ModelsNamespace => $"{ClientNamespace}.Models";

    // The emitted cmdlets' own namespace: the client namespace with its trailing ".Client"
    // dropped ("Microsoft.Graph.PowerShell.Mail.Client" -> "Microsoft.Graph.PowerShell.Mail"),
    // so it is per-module like everything else the client generates rather than a shared
    // placeholder every module's cmdlets would otherwise collide into.
    public string CmdletNamespace => ClientNamespace.EndsWith(".Client", StringComparison.Ordinal)
        ? ClientNamespace[..^".Client".Length]
        : ClientNamespace;
}
