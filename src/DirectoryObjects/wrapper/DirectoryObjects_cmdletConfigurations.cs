using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    // DirectoryObjects.md's PKI routes are absent from both compatible specs.
    // The adjacent migration ledger audits all 17 groups; do not prune live
    // /directoryObjects operations or invent overrides for absent routes.
    private static readonly List<Entry> DirectoryObjectsCmdletConfigurations = [];
}
