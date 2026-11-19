using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> SearchCmdletConfigurations =
    [
        new(OverrideKind.ReplaceNoun, HttpMethod.Get,
            "/external/industrydata/runs/{}/microsoft.graph.industrydata.getstatistics",
            PathMatch.Exact, "ExternalIndustryDataRunStatistics",
            "Source description: Get statistics for an industryDataRun. Preserve the published item Statistics noun; the collection-bound function retains its structural GetStatistics name."),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get,
            "/external/industrydata/runs/{}/activities/{}/activity",
            PathMatch.Exact, "ExternalIndustryDataRunActivityFlow",
            "Source description: The flow that was run by this activity. This returns industryDataActivity, not the industryDataRunActivity exposed by the ordinary list/item command with the same IDs."),
    ];
}
