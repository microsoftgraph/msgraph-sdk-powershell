using System.Collections.Generic;
using System.Net.Http;

namespace WrapperGenerator;

public static partial class CmdletConfigurator
{
    private static readonly List<Entry> UsersCmdletConfigurations =
    [
        // Users.md directive 1 matches these three legacy operations, not the nested
        // /todo/lists routes or user_GetOutlook (the original regex uses lowercase outlook).
        new(OverrideKind.SuppressOperation, HttpMethod.Get, "/users/{}/todo", PathMatch.Exact, null,
            "Users.md directive 1: user_GetTodo -> users.GetTodo in both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/users/{}/todo", PathMatch.Exact, null,
            "Users.md directive 1: user_UpdateTodo -> users.UpdateTodo in both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Delete, "/users/{}/todo", PathMatch.Exact, null,
            "Users.md directive 1: user_DeleteTodo -> users.DeleteTodo in both profiles"),
        new(OverrideKind.SuppressOperation, HttpMethod.Post, "/users/{}/licensedetails", PathMatch.Exact, null,
            "Users.md directive 2: remove New UserLicenseDetail; retain license-detail reads and item operations"),
        new(OverrideKind.SuppressOperation, HttpMethod.Patch, "/users/{}/photo", PathMatch.Exact, null,
            "Users.md directive 4: remove Update UserPhoto; retain photo reads and content operations"),

        new(OverrideKind.ReplaceNoun, HttpMethod.Delete, "/users/{}/sponsors/{}/$ref", PathMatch.Exact,
            "UserSponsorDirectoryObjectByRef",
            "Published beta metadata and Learn: item SponsorDirectoryObjectByRef is distinct from collection SponsorByRef"),

        // Get-MgUserPhoto serves both /photo and /photos; the /photos routes ship no distinct
        // cmdlet, and generating them would collide with the singleton's noun.
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: Get-MgUserPhoto serves /photo and /photos; the collection ships no distinct cmdlet"),
        new(OverrideKind.SuppressOperation, Method: null, "/users/{}/photos/{}", Match: PathMatch.Exact, Value: null,
            Reason: "oracle: /photos/{} ships nothing; the photo surface is the /photo singleton"),
    ];
}
