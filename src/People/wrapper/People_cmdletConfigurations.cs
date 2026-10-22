using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> PeopleCmdletConfigurations =
    [
        // The original operation-ID regex matches only the beta analytics singleton, not
        // the plural ActivityStatistics IDs. See People_directiveMigrationMap.json.
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/analytics", PathMatch.Exact, null,
            "People.md directive 1: legacy user_GetAnalytic"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/users/{}/analytics", PathMatch.Exact, null,
            "People.md directive 1: legacy user_UpdateAnalytic"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/users/{}/analytics", PathMatch.Exact, null,
            "People.md directive 1: legacy user_DeleteAnalytic"),

        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/analytics/activitystatistics", PathMatch.Exact, "UserActivityStatistics",
            "People.md directive 3: UserAnalyticActivityStatistics -> UserActivityStatistics"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Post, "/users/{}/analytics/activitystatistics", PathMatch.Exact, "UserActivityStatistics",
            "People.md directive 3: UserAnalyticActivityStatistics -> UserActivityStatistics"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Get, "/users/{}/analytics/activitystatistics/{}", PathMatch.Exact, "UserActivityStatistics",
            "People.md directive 3: UserAnalyticActivityStatistics -> UserActivityStatistics"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Patch, "/users/{}/analytics/activitystatistics/{}", PathMatch.Exact, "UserActivityStatistics",
            "People.md directive 3: UserAnalyticActivityStatistics -> UserActivityStatistics"),
        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/users/{}/analytics/activitystatistics/{}", PathMatch.Exact, "UserActivityStatistics",
            "People.md directive 3: UserAnalyticActivityStatistics -> UserActivityStatistics"),
    ];
}
