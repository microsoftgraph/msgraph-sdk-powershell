using System.Collections.Generic;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> DevicesCorporateManagementCmdletConfigurations =
    [
        new(OverrideKind.SuppressOperation, Method: null, "/deviceappmanagement/mobileapps/{}/categories", Match: PathMatch.Prefix, Value: null,
            Reason: "oracle: nested app categories ship nothing; the set ships top-level (mobileAppCategories)"),
    ];
}
