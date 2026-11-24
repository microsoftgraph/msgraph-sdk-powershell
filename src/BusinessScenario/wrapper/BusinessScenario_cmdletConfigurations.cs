using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    // BusinessScenario.md records the absence of shared directives; retain existing shared naming rules.
    private static readonly List<Entry> BusinessScenarioCmdletConfigurations = [];
}
