using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    // The shared module file has no cmdlet directives; preserve structural and derived naming.
    private static readonly List<Entry> DeviceManagementFunctionsCmdletConfigurations = [];
}
