using System;

namespace WrapperGenerator;

// The per-module values CmdletEmitter's templates need, so the emitter stays module-agnostic.
// ClientNamespace is whatever --namespace-name the module was generated with, for example
// "Microsoft.Graph.PowerShell.Mail.Client".
public sealed record EmitContext(string ClientNamespace)
{
    public string ModelsNamespace => $"{ClientNamespace}.Models";

    // The emitted cmdlets' own namespace: the client namespace with its trailing ".Client"
    // dropped ("Microsoft.Graph.PowerShell.Mail.Client" -> "Microsoft.Graph.PowerShell.Mail"),
    // so it is per-module like everything else the client generates rather than a shared
    // placeholder every module's cmdlets would otherwise collide into.
    public string CmdletNamespace => ClientNamespace.EndsWith(".Client", StringComparison.Ordinal)
        ? ClientNamespace[..^".Client".Length]
        : ClientNamespace;
}
